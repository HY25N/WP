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
            // 파일 존재 여부는 여기서 처리해준다.
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());

        }
    }


    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        private ApplicationDbContext context;


        public Form1()
        {
            InitializeComponent();

            Repository repo = new Repository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDB("db");

            // 데이터 추가
            // context.Students.Add(new Student { Name = "Alice", Age = 22, Major = "Computer Science" });
            // context.SaveChanges();

            // 데이터 조회
            // var students = context.Students.ToList();
            // foreach (var student in students)
            // {
            //     Debug.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Major: {student.Major}");
            // }

            UpdateListView();
        }



        private void InitDB(String dbName)
        {

            // db 생성 경로 지정 (레거시이다. 이전 네이티브 방식에서 쓰던 것)
            string exeDirPathString = Application.StartupPath;
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            var dbPath = $"{exeDirPathString}\\{dbName}.sqlite";

            context = new ApplicationDbContext();
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

            // 학번은 pk로 쓸 것이기 때문에 숫자타입으로 정의한다.
            context.Database.ExecuteSqlCommand(@"
                UPDATE sqlite_sequence 
                SET seq=20240000
                WHERE name ='Students'
                ");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);
            string name = textBox1.Text;
            string lecture = textBox2.Text;
            int midTermScore = (int)numericUpDown1.Value;
            int finalTermScore = (int)numericUpDown2.Value;

            context.Students.Add(new Student
            {
                Id = id,
                Name = name,
                Age = midTermScore,
                Major = finalTermScore.ToString()
            });

            context.SaveChanges();

            UpdateListView();
        }



        private int UpdateListView()
        {
            listView1.Items.Clear();

            var students = context.Students.ToList();
            foreach (var student in students)
            {
                ListViewItem lvi = new ListViewItem();
                // lvi.Text = "er";
                lvi.SubItems.Add(student.Id.ToString());
                lvi.SubItems.Add(student.Name.ToString());
                lvi.SubItems.Add(student.Age.ToString());
                lvi.SubItems.Add(student.Major.ToString());
                //
                listView1.Items.Add(lvi);
            }

            return students.Count;
        }

    }
}
