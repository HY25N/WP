using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity;
using System.Diagnostics;


namespace pr1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());

        }
    }


    public partial class Form1 : Form
    {
        SQLiteConnection conn;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // todo 더 상위에서 초기화 해야할듯
            var context = new ApplicationDbContext();
            context.Database.Initialize(force: true);
            // context.Database.Create();

            // 자동 생성에 문자가 있어서 테이블 수동 생성한다.
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Students (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER NOT NULL,
                    Major TEXT NOT NULL
                )");

            // 데이터 추가
            context.Students.Add(new Student { Name = "Alice", Age = 21, Major = "Computer Science" });
            context.SaveChanges();

            // 데이터 조회
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Debug.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Major: {student.Major}");
            }






            InitDB("db");

            UpdateListView();
        }



        private void InitDB(String dbName)
        {

            // db 생성 경로 지정
            string exeDirPathString = Application.StartupPath;
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            var dbPath = $"{exeDirPathString}\\{dbName}.sqlite";

            // db 파일 생성
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            // db 연결
            string connectionString = $"Data Source={dbPath}; Version=3;";
            conn = new SQLiteConnection(connectionString);
            conn.Open();

            // DB: DDL
            string sql = "SELECT count(*) FROM sqlite_master WHERE name = 'student'";
            int result = new SQLiteCommand(sql, conn).ExecuteNonQuery();


            sql = "CREATE TABLE IF NOT EXISTS student (" +
                "id int," +
                "name varchar(50)," +
                "lecture varchar(250)," +
                "midTermScore int," +
                "finalTermScore int)";
            result = new SQLiteCommand(sql, conn).ExecuteNonQuery();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);
            string name = textBox1.Text;
            string lecture = textBox2.Text;
            int midTermScore = (int)numericUpDown1.Value;
            int finalTermScore = (int)numericUpDown2.Value;

            string sql = $"insert into student (id, name, lecture, midTermScore, finalTermScore) values (" +
                $"{id}, '{name}', '{lecture}', '{midTermScore}', '{finalTermScore}')";

            int result = new SQLiteCommand(sql, conn).ExecuteNonQuery();

            UpdateListView();
        }



        private int UpdateListView()
        {
            String sql;// = "insert into members (name, age) values ('한강', 46)";
            int result; // = new SQLiteCommand(sql, conn).ExecuteNonQuery();

            sql = "select * from student";
            SQLiteDataReader sdr = new SQLiteCommand(sql, conn).ExecuteReader();

            listView1.Items.Clear();
            int cnt = 0;
            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                // lvi.Text = "er";
                lvi.SubItems.Add(sdr["id"].ToString());
                lvi.SubItems.Add(sdr["name"].ToString());
                lvi.SubItems.Add(sdr["lecture"].ToString());
                lvi.SubItems.Add(sdr["midTermScore"].ToString());
                lvi.SubItems.Add(sdr["finalTermScore"].ToString());
                //
                listView1.Items.Add(lvi);
                cnt++;
            }

            return cnt;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1qq2"; //listView1.Items[listView1.FocusedItem.Index].Text;   
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox2.Text = "1123"; //listView1.Items[listView1.FocusedItem.Index].Text;   
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "112w"; //listView1.Items[listView1.FocusedItem.Index].Text;   
        }
    }
}
