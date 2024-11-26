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
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;


namespace pr3
{
    public class Repository
    {
        public static ApplicationDbContext context;

        public Repository(String dbName)
        {
            InitDB(dbName);
            if (!context.Enrollments.Any()) CreateEnrollentDummy();
            if (!context.Registrations.Any()) CreateRegistrationDummy();
        }

        public static ApplicationDbContext GetContext()
        {
            return context;
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
                    Name VARCHAR(200) NOT NULL,                     -- 교과목
                    Code VARCHAR(100) NULL,                            -- 학수번호
                    Manager VARCHAR(100) NOT NULL,                  -- 교수명
                    Completion VARCHAR(100) NOT NULL,               -- 이수구분
                    Credit INTEGER CHECK(Credit BETWEEN 0 AND 10),  -- 학점
                    Place VARCHAR(100) NULL,                        -- 강의실/시간
                    Capacity INTEGER NOT NULL                       -- 수강인원
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
            List<Student> studentList = new List<Student>
    {
        new Student
        {
            Name = "김철수",
            DateOfBirth = new DateTime(2001, 3, 15),
            Department = "컴퓨터공학과",
            Grade = 3,
            Address = "서울시 강남구 테헤란로 123",
            Email = "cs.kim@domain.com",
            PhoneNumber = "010-1234-5678"
        },
        new Student
        {
            Name = "이영희",
            DateOfBirth = new DateTime(1999, 5, 22),
            Department = "전자공학과",
            Grade = 4,
            Address = "경기도 성남시 분당구 판교로 456",
            Email = "yh.lee@domain.com",
            PhoneNumber = "010-2345-6789"
        },
        new Student
        {
            Name = "박지훈",
            DateOfBirth = new DateTime(2002, 11, 3),
            Department = "소프트웨어학과",
            Grade = 2,
            Address = "부산광역시 해운대구 센텀로 789",
            Email = "jh.park@domain.com",
            PhoneNumber = "010-3456-7890"
        },
        new Student
        {
            Name = "정수빈",
            DateOfBirth = new DateTime(2000, 8, 17),
            Department = "정보통신공학과",
            Grade = 3,
            Address = "대구광역시 수성구 범어로 321",
            Email = "sb.jung@domain.com",
            PhoneNumber = "010-4567-8901"
        },
        new Student
        {
            Name = "최민호",
            DateOfBirth = new DateTime(2001, 2, 5),
            Department = "기계공학과",
            Grade = 1,
            Address = "대전광역시 유성구 궁동로 654",
            Email = "mh.choi@domain.com",
            PhoneNumber = "010-5678-9012"
        },
        new Student
        {
            Name = "김나영",
            DateOfBirth = new DateTime(2003, 7, 25),
            Department = "경영학과",
            Grade = 2,
            Address = "광주광역시 북구 양산로 111",
            Email = "ny.kim@domain.com",
            PhoneNumber = "010-6789-0123"
        },
        new Student
        {
            Name = "이준호",
            DateOfBirth = new DateTime(1998, 4, 12),
            Department = "건축학과",
            Grade = 5,
            Address = "인천광역시 송도동 컨벤시아대로 987",
            Email = "jh.lee@domain.com",
            PhoneNumber = "010-7890-1234"
        },
        new Student
        {
            Name = "한수민",
            DateOfBirth = new DateTime(2000, 1, 20),
            Department = "환경공학과",
            Grade = 4,
            Address = "울산광역시 남구 삼산로 321",
            Email = "sm.han@domain.com",
            PhoneNumber = "010-8901-2345"
        }
    };

            // 데이터 추가
            context.Students.AddRange(studentList);
            context.SaveChanges();
        }

        public List<Lecture> AddLectureSampleData(DataTable targetDataTable)
        {
            List<Lecture> lectureList = new List<Lecture> {
                new Lecture("CS101", "프로그래밍 기초", "전공 필수", "홍길동", 3, "월 10:00-12:00, 화 10:00-11:00", 40),
                new Lecture("CS102", "자료구조", "전공 선택", "김철수", 3, "수 14:00-16:00, 금 14:00-15:00", 35),
                new Lecture("GE201", "기초영어", "교양 선택", "박영희", 2, "월 09:00-11:00", 50),
                new Lecture("GE202", "논리학", "교양 필수", "이상훈", 2, "수 11:00-13:00", 30),
                new Lecture("CS201", "컴퓨터 네트워크", "전공 필수", "김민수", 3, "월 13:00-15:00, 화 13:00-14:00", 40),
                new Lecture("CS202", "운영체제", "전공 선택", "이성민", 3, "목 10:00-12:00, 금 10:00-11:00", 45),
                new Lecture("CS203", "알고리즘", "전공 필수", "최윤희", 3, "월 10:00-12:00, 수 10:00-11:00", 50),
                new Lecture("CS204", "디지털 논리 회로", "전공 선택", "박재현", 2, "수 15:00-17:00", 30),
                new Lecture("GE301", "심리학", "교양 선택", "김동수", 2, "목 10:00-12:00", 60),
                new Lecture("GE302", "경제학 원론", "교양 필수", "황민지", 3, "월 14:00-16:00, 화 14:00-15:00", 40),
                new Lecture("GE303", "영어회화", "교양 선택", "이상민", 2, "월 11:00-13:00", 45),
                new Lecture("GE304", "철학 개론", "교양 필수", "전지현", 2, "화 13:00-15:00", 50),
                new Lecture("CS301", "인공지능", "전공 필수", "김세훈", 3, "월 15:00-17:00, 수 14:00-15:00", 35),
                new Lecture("CS302", "컴퓨터 그래픽스", "전공 선택", "조수미", 2, "금 13:00-15:00", 25),
                new Lecture("CS303", "데이터베이스 시스템", "전공 필수", "홍수정", 2, "월 09:00-11:00", 40),
                new Lecture("CS304", "소프트웨어 공학", "전공 선택", "이상철", 2, "목 09:00-11:00", 30),
                new Lecture("GE401", "통계학", "교양 필수", "정명훈", 2, "월 13:00-15:00", 50),
                new Lecture("GE402", "기후변화", "교양 선택", "박주희", 2, "화 11:00-13:00", 45),
                new Lecture("GE403", "인문학의 이해", "교양 필수", "한예슬", 3, "화 11:00-13:00, 금 10:00-11:00", 55),
                new Lecture("GE404", "문화학 개론", "교양 선택", "최성훈", 2, "수 14:00-16:00", 50),
                new Lecture("CS401", "컴퓨터 비전", "전공 선택", "김유진", 2, "화 15:00-17:00", 40),
                new Lecture("CS402", "기계학습", "전공 필수", "이하늘", 2, "금 11:00-13:00", 60),
                new Lecture("CS403", "패턴 인식", "전공 선택", "오민수", 2, "수 10:00-12:00", 35),
                new Lecture("CS404", "클라우드 컴퓨팅", "전공 필수", "정다운", 2, "목 15:00-17:00", 50),
                new Lecture("GE501", "세계 문화의 이해", "교양 선택", "이주은", 2, "화 13:00-15:00", 30),
                new Lecture("GE502", "글쓰기", "교양 필수", "김동희", 2, "월 09:00-11:00", 45),
                new Lecture("GE503", "사회학 개론", "교양 선택", "유지윤", 2, "화 15:00-17:00", 40),
                new Lecture("GE504", "예술과 창의성", "교양 선택", "정유진", 2, "월 13:00-15:00", 50)
            };



            // 영속성 컨텍스트의 렉쳐스 새로 만든 렉처 리스트를 새로 생성한다. 
            context.Lectures.AddRange(lectureList);
            // 변동된 영속성 컨텍스트의 렉처스를 db에 실제로 기록한다.
            context.SaveChanges();

            return lectureList;
        }


        public void CreateEnrollentDummy()
        {
            List<Enrollment> enrooEnrollmentstList = new List<Enrollment>
            {
                new Enrollment(20240001,2024, 1),
                new Enrollment(20240002,2024, 1),
                new Enrollment(20240003,2024, 1),
                new Enrollment(20240004,2024, 1),

                new Enrollment(20240001,2024, 2),
                new Enrollment(20240002,2024, 2),
                new Enrollment(20240003,2024, 2),
                new Enrollment(20240004,2024, 2),
            };

            // 데이터 추가
            context.Enrollments.AddRange(enrooEnrollmentstList);
            context.SaveChanges();
        }

        public void CreateRegistrationDummy()
        {
            List<Registration> RegistrationList = new List<Registration>
            {
                new Registration(1, 1, 20, 21, 30),
                new Registration(1, 2, 10, 26, 31),
                new Registration(1, 3, 30, 11, 51),
                new Registration(1, 4, 14, 24, 11),
                new Registration(5, 1, 11, 14, 34),
                new Registration(5, 2, 30, 24, 21),
                new Registration(5, 3, 14, 21, 11),
                new Registration(5, 4, 21, 29, 41),
            };

            // 데이터 추가
            context.Registrations.AddRange(RegistrationList);
            context.SaveChanges();
        }




        public Boolean BackupDb(string backupPath)
        {
            string sourcePath = AppDomain.CurrentDomain.BaseDirectory;
            Debug.WriteLine("소스는" + sourcePath);
            sourcePath = Path.Combine(sourcePath, "db.sqlite");

            var sourceFile = new SQLiteConnection($"Data Source={sourcePath}");
            var backupFile = new SQLiteConnection($"Data Source={backupPath}");

            sourceFile.Open();
            backupFile.Open();
            sourceFile.BackupDatabase(backupFile, "main", "main", -1, null, 0);

            return true;
        }

        public void OverwriteDb(string sourcePath)
        {
            string targetPath = AppDomain.CurrentDomain.BaseDirectory;
            string destinationPath = Path.Combine(targetPath, "db.sqlite");

            // 파일 복사 (덮어쓰기)
            File.Copy(sourcePath, destinationPath, overwrite: true);
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
        public string Name { get; set; }  // 교과목

        [Required]
        [StringLength(100)]
        public string Code { get; set; }  // 학수 번호

        [Required]
        [StringLength(100)]
        public string Manager { get; set; }  // 교수명

        [Required]
        [StringLength(100)]
        public string Completion { get; set; }  // 이수구분

        [Required]
        [Range(0, 10)]
        public int Credit { get; set; }  // 학점

        [StringLength(250)]
        public string Place { get; set; }  // 강의실/시간

        [Required]
        public int Capacity { get; set; }  // 수강인원


        public Lecture() { }

        // CS101", "프로그래밍 기초", "전공 필수", "홍길동", 3, "월/수 10:00-12:00", 40);
        public Lecture(string code, string name, string completion, string manager, int credit, string place, int capacity)
        {
            Name = name;
            Code = code;
            Manager = manager;
            Completion = completion;
            Credit = credit;
            Place = place;
            Capacity = capacity;
        }
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

        public Enrollment(int studentId, int year, int semester)
        {
            StudentId = studentId;
            Year = year;
            Semester = semester;
        }

        public Enrollment() { }
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

        public Registration(int enrollmentId, int lectureId, int? midTerm, int? finalTerm, int? attendance)
        {
            EnrollmentId = enrollmentId;
            LectureId = lectureId;
            MidTerm = midTerm;
            FinalTerm = finalTerm;
            Attendance = attendance;
            Lecture = pr3.Repository.GetContext().Lectures.SingleOrDefault(v => v.Id == lectureId);
        }

        public Registration() {}
    }


}
