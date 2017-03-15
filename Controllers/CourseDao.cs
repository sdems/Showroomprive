using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models;

namespace Test.Controllers
{
    public class CourseDao
    {

        public List<Course> getAllRace()
        {

            List<Course> lesCourses = new List<Course>();

            lesCourses.Add(new Course(1, "La Bicentenaire", "La Roche sur yon", new DateTime(2015, 5, 23)));

            lesCourses.Add(new Course(2, "Marathon de Nantes", "Nantes", new DateTime(2015, 11, 17)));

            lesCourses.Add(new Course(3, "Le Grand Raid des Pyrénées", "Vielle-Aure", new DateTime(2016, 8, 25)));

            return lesCourses;

        }

        public List<Coureur> getRunners(Course laCourse)
        {

            List<Coureur> lesCoureurs = new List<Coureur>();

            Entraineur monEntraineur = new Entraineur("Miguel", "Dupont", 0);

            switch (laCourse.Num)
            {

                case 1:

                    lesCoureurs.Add(new Coureur("Jean", "Dupond", monEntraineur));

                    lesCoureurs.Add(new Coureur("Alain", "Martin", monEntraineur));

                    lesCoureurs.Add(new Coureur("John", "Smith", monEntraineur));

                    lesCoureurs.Add(new Coureur("Hélène", "Tartanpion", monEntraineur));

                    break;

                case 2:

                    lesCoureurs.Add(new Coureur("Jean", "Dupond", monEntraineur));

                    lesCoureurs.Add(new Coureur("Alain", "Martin", monEntraineur));

                    lesCoureurs.Add(new Coureur("Hélène", "Tartanpion", monEntraineur));

                    break;

                case 3:

                    lesCoureurs.Add(new Coureur("Paul", "Dumoulin", monEntraineur));

                    lesCoureurs.Add(new Coureur("Hélène", "Tartanpion", monEntraineur));

                    break;

            }

            return lesCoureurs;

        }

        public bool deleteRunners(Course course, List<Coureur> coureurs)
        {

            return true;

        }

    }

}


