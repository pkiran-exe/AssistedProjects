using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssistedProject
{
    public class Subject
    {
        private string name;
        private string shortName;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
    }
    public class Teacher
    {
        private string name;
        private string address;
        private string contactAddress;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactAddress
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }
    }
    public class Students
    {
        private string name;
        private DateTime dateOfBirth;
        private string address;
        private string guardianName;
        private string contactNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
    }
    public class CClass
    {
        private string name;
        private Teacher classTeacher;
        private List<Students> students;
        private List<Subject> subjects;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teacher ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        public List<Students> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
    }

    internal class Classes
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Students> listStudents = new List<Students>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Students student = new Students();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";

            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;
        }

    }
}