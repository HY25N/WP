using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pr3
{
    public class Repository
    {
        public ApplicationDbContext context;

        public Repository(String dbName)
        {
            InitDB(dbName);
        }

        private void InitDB(String dbName)
        {
            // db 생성 경로 지정 (레거시이다. 이전 네이티브 방식에서 쓰던 것)
            // string exeDirPathString = Application.StartupPath;
            // exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            // exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            // var dbPath = $"{exeDirPathString}\\{dbName}.sqlite";

            context = new ApplicationDbContext();

            // 이하 DDL
            // 아래 작동 안됨...
            context.Database.Initialize(force: true);

            // todo 자동 생성에 문자가 있어서 테이블을 수동 생성한다.
            // context.Database.ExecuteSqlCommand(@"
            //     CREATE TABLE IF NOT EXISTS Students (
            //     StudentID INTEGER PRIMARY KEY AUTOINCREMENT,  -- 학번 (자동 증가)
            //     Name VARCHAR(100) NOT NULL,                          -- 이름
            //     DateOfBirth Date NULL,                   -- 생년월일 (YYYY-MM-DD 형식)
            //     Department VARCHAR(250) NOT NULL,                    -- 학과
            //     Grade INTEGER CHECK(Grade BETWEEN 0 AND 20) NOT NULL,    -- 학년 (0~10학년)
            //     PhoneNumber VARCHAR(20) NULL,                            -- 전화번호
            //     Email VARCHAR(250) UNIQUE NULL,                           -- 이메일 (중복 불가)
            //     Address VARCHAR(500) NULL                               -- 주소
            // );");


            // 학번은 pk로 쓸 것이기 때문에 숫자타입으로 정의한다.
            // context.Database.ExecuteSqlCommand(@"
            //     UPDATE sqlite_sequence 
            //     SET seq=20240000
            //     WHERE name ='Students'
            //     ");

            // 클래스 생성 순서 때문인지 아래 쿼리보다 더미데이터가 먼저 생성되는 듯.
            // 그래서 하나의 트랜젝션으로 쿼리한다.
            // Student 테이블 생성
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Student (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,  -- 학번 (자동 증가)
                    Name VARCHAR(100) NOT NULL,                   -- 이름
                    DateOfBirth DATE NULL,                        -- 생년월일 (YYYY-MM-DD 형식)
                    Department VARCHAR(250) NOT NULL,             -- 학과
                    Grade INTEGER CHECK(Grade BETWEEN 0 AND 20) NOT NULL, -- 학년 (0~20학년)
                    PhoneNumber VARCHAR(20) NULL,                 -- 전화번호
                    Email VARCHAR(250) UNIQUE NULL,               -- 이메일 (중복 불가)
                    Address VARCHAR(500) NULL                     -- 주소
                );

                -- Student 테이블에 데이터가 없으면 기본값 삽입
                INSERT INTO Student (Name, Department, Grade) 
                SELECT 'temp', 'Default', 1
                WHERE NOT EXISTS (SELECT 1 FROM Student);

                -- 시퀀스 값 업데이트 (학번 초기값 설정)
                UPDATE sqlite_sequence 
                SET seq = 20240000
                WHERE name = 'Student';

                -- temp 데이터 삭제
                DELETE FROM Student WHERE Name = 'temp';
            ");

            // Lecture 테이블 생성
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Lecture (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name VARCHAR(200) NOT NULL,            
                    Code INTEGER NULL,
                    Manager VARCHAR(100) NOT NULL,
                    Credit INTEGER CHECK(Credit BETWEEN 0 AND 10),
                    Place VARCHAR(100) NULL,
                    Capacity INTEGER NOT NULL
                );
            ");

            // Enrollment 테이블 생성
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Enrollment (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER NOT NULL,
                    Year INTEGER,
                    Semester INTEGER
                );
            ");

            // Registration 테이블 생성
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Registration (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    EnrollmentId INTEGER NOT NULL,
                    LectureId INTEGER NOT NULL,
                    MidTerm INTEGER,
                    FinalTerm INTEGER,
                    Attendance INTEGER
                );
            ");


        }

        // 더미 데이터 생성
        public void CreateStudentsDummy(int size)
        {
            Random rand = new Random();

            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < size; i++)
            {
                studentsList.Add(new Student
                {
                    Name = "김" + rand.Next(0, 999),
                    DateOfBirth = new DateTime(rand.Next(1955, 2026), rand.Next(1, 13), rand.Next(1, 29)),
                    Department = "제 " + rand.Next(1, 20) + "번 째 통합된 학과명",
                    Grade = rand.Next(0, 15),
                    Address = "한국 집주소 " + rand.Next(-999999, 999999) + " 번지 아파트",
                    Email = "fake" + rand.Next(0, 212121212) + "@domain.com",
                    PhoneNumber = "010-" + rand.Next(1000, 9999) + "-" + rand.Next(1000, 9999)
                });
            }

            // 데이터 추가
            context.Students.AddRange(studentsList);
            context.SaveChanges();
        }
    }



    // db와 연결하는 콘텍스트 겍체
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Registration> Registrations { get; set; }


        public ApplicationDbContext() : base("DefaultConnection")
        {
            // 파일 존재 여부는 여기서 처리해준다.
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }
    }



    // 이하 테이블(엔티티)
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }  // 학번 (자동 증가)

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  // 이름

        public DateTime? DateOfBirth { get; set; }  // 생년월일 (Nullable)

        [Required]
        [StringLength(250)]
        public string Department { get; set; }  // 학과

        [Required]
        [Range(0, 20)]
        public int Grade { get; set; }  // 학년 (0~20학년)

        [StringLength(20)]
        public string PhoneNumber { get; set; }  // 전화번호

        [StringLength(250)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string Email { get; set; }  // 이메일 (중복 불가)

        [StringLength(500)]
        public string Address { get; set; }  // 주소
    }

    [Table("Lecture")]
    public class Lecture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  

        [Required]
        [StringLength(200)]
        public string Name { get; set; }  

        [Required]
        public int Code { get; set; }  

        [Required]
        [StringLength(100)]
        public string Manager { get; set; } 

        [Required]
        [Range(0, 10)]
        public int Credit { get; set; } 

        [StringLength(250)]
        public string Place { get; set; } 

        [Required]
        public int Capacity { get; set; } 
    }

    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Enrollment ID (자동 증가)

        [Required]
        public int StudentId { get; set; }  // Student 테이블의 외래 키

        [ForeignKey("StudentId")]
        public Student Student { get; set; }  // Student와의 네비게이션 속성

        [Range(1880, 2200)]
        public int Year { get; set; }  // 학년도

        [Range(1, 2)]
        public int Semester { get; set; }  // 학기 (1: 1학기, 2: 2학기)
    }

    [Table("Registration")]
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Registration ID (자동 증가)

        [Required]
        public int EnrollmentId { get; set; }  // Enrollment 테이블의 외래 키

        [ForeignKey("EnrollmentId")]
        public Enrollment Enrollment { get; set; }  // Enrollment와의 네비게이션 속성

        [Required]
        public int LectureId { get; set; }  // Lecture 테이블의 외래 키

        [ForeignKey("LectureId")]
        public Lecture Lecture { get; set; }  // Lecture와의 네비게이션 속성

        [Range(0, 100)]
        public int? MidTerm { get; set; }  // 중간고사 점수 (0~100)

        [Range(0, 100)]
        public int? FinalTerm { get; set; }  // 기말고사 점수 (0~100)

        public int? Attendance { get; set; }
    }


}
