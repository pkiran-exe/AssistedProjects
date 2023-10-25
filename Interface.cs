using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    public interface IPerson
    {
        string getInfo();
        string getTypeOfPerson();
    }
    public class Student1 : IPerson
    {
        private string name;
        private string address;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string getInfo()
        {
            string retVal = "Name: " + name + ", Address=" + address + ", Joining Date =" + dateOfJoining.ToShortDateString();
            return retVal;
        }

        public string getTypeOfPerson()
        {
            return "student";
        }
    }
    public class Teacher1 : IPerson
    {
        private string name;
        private string address;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string getInfo()
        {
            string retVal = "Name: " + name + ", Address=" + address + ", Joining Date =" + dateOfJoining.ToShortDateString();
            return retVal;
        }

        public string getTypeOfPerson()
        {
            return "teacher";
        }
    }
    public class OfficeStaff : IPerson
    {
        private string name;
        private string address;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string getInfo()
        {
            string retVal = "Name: " + name + ", Address=" + address + ", Joining Date =" + dateOfJoining.ToShortDateString();
            return retVal;
        }

        public string getTypeOfPerson()
        {
            return "OfficeStaff";
        }
    }

    internal class Interface
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            Teacher1 teacher = new Teacher1();
            teacher.Name = "Mr.Teacher";
            teacher.Address = "some address";
            teacher.DateOfJoining = DateTime.Today;

            Student1 student = new Student1();
            student.Name = "Student name";
            student.Address = "some address";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Staff";
            staff.Address = "some address";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }

    }
}