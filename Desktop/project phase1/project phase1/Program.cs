using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_phase1
{
    struct student
    {
        public string stuname;
        public int section;
        public  string datastudent()

        {

            return " student's name: " + stuname + ",student section:"  + section;
        }
    }
    struct teacher
    {
        public string teachername;
        public int section;
        public string datateacher()

        {

            return "teacher's name:" + teachername + ",section:" + section;
        }
    }
    struct subject
    {
        public string subjectname;
        public int subjectcode;
        public  string datasubject()

        {
         
            return "subject name:"+ subjectname+",subject code:"+ subjectcode;
        }
    }
  
   
    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.stuname = "maha";
            st.section = 13;
            Console.WriteLine(st.datastudent());
            teacher te = new teacher();
            te.teachername = "fatima";
            te.section = 14;
            Console.WriteLine(te.datateacher());
            subject su = new subject();
            su.subjectname = "math";
            su.subjectcode = 23453;
            Console.WriteLine(su.datasubject());
            Console.ReadLine();

         
        }
    }
}
