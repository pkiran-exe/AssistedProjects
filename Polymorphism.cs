using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    public class BasicGradeCard
    {
        protected int totalMarks;

        public BasicGradeCard()
        {
            totalMarks = 0;
        }

        public virtual int getTotalMarks()
        {
            return totalMarks;
        }
    }

    public class ElementarySchoolGradeCard : BasicGradeCard
    {
        private int maths = 0;
        private int english = 0;
        private int secondLanguage = 0;
        private int socialScience = 0;

        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public int SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

        public int SocialScience
        {
            get { return socialScience; }
            set { socialScience = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + socialScience + secondLanguage;
            return totalMarks;
        }
    }

    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        private int maths = 0;
        private int english = 0;
        private int secondLanguage = 0;
        private int geography = 0;
        private int history = 0;

        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public int SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

        public int Geography
        {
            get { return geography; }
            set { geography = value; }
        }

        public int History
        {
            get { return history; }
            set { history = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + geography + history;
            return totalMarks;
        }
    }

    public class HighSchoolGradeCard : BasicGradeCard
    {
        private int maths = 0;
        private int english = 0;
        private int secondLanguage = 0;
        private int geography = 0;
        private int history = 0;
        private int physics = 0;
        private int chemistry = 0;
        private int biology = 0;

        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public int SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

        public int Geography
        {
            get { return geography; }
            set { geography = value; }
        }

        public int History
        {
            get { return history; }
            set { history = value; }
        }

        public int Physics
        {
            get { return physics; }
            set { physics = value; }
        }

        public int Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }

        public int Biology
        {
            get { return biology; }
            set { biology = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + geography + history + physics + chemistry + biology;
            return totalMarks;
        }
    }

    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
            elementary.Maths = 90;
            elementary.English = 78;
            elementary.SecondLanguage = 80;
            elementary.SocialScience = 67;
            Console.WriteLine("total marks =" +
                              elementary.getTotalMarks());

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
            middle.Maths = 90;
            middle.English = 78;
            middle.SecondLanguage = 80;
            middle.Geography = 87;
            middle.History = 76;
            Console.WriteLine("total marks =" + middle.getTotalMarks());

            HighSchoolGradeCard high = new HighSchoolGradeCard();
            high.Maths = 90;
            high.English = 78;
            high.SecondLanguage = 80;
            high.Geography = 87;
            high.History = 76;
            high.Physics = 90;
            high.Chemistry = 76;
            high.Biology = 70;
            Console.WriteLine("total marks =" + high.getTotalMarks());
        }

    }
}