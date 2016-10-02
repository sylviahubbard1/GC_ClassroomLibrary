using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_ClassroomLibrary
{

    public class Classroom

    {
        private Student[] m_students = new Student[7];
        //constructor method "public Classroom(). 
        //A constructor is called when someone calls 'new'
        public Classroom() 
        {
            for (int i = 0; i < m_students.Length; i++)
            {
                m_students[i] = new Student();
            }

            students[0].Name = "Lauren";
            students[0].Gender = "F";
            students[0].Hometown = "Royal Oak";
            students[0].FavoriteFood = "Pizza";
            students[1].Name = "Michelle";
            students[1].Gender = "F";
            students[1].Hometown = "Ferndale";
            students[1].FavoriteFood = "Spaghetti";
            students[2].Name = "Clark";
            students[2].Gender = "M";
            students[2].Hometown = "Detroit";
            students[2].FavoriteFood = "Chicken";
            students[3].Name = "Rumi";
            students[3].Gender = "F";
            students[3].Hometown = "Dearborn Heights";
            students[3].FavoriteFood = "Hummus";
            students[4].Name = "Michael";
            students[4].Gender = "M";
            students[4].Hometown = "Royal Oak";
            students[4].FavoriteFood = "Meatloaf";
            students[5].Name = "Gaby";
            students[5].Gender = "F";
            students[5].Hometown = "Southfield";
            students[5].FavoriteFood = "Salads";
            students[6].Name = "Kim";
            students[6].Gender = "F";
            students[6].Hometown = "Detroit";
            students[6].FavoriteFood = "Pizza";
        }


        public Student[] students
        {
            get { return m_students; }
        }
        public Desk[] desks = new Desk[15];
        public TV[] tvs = new TV[2];

    }
}
