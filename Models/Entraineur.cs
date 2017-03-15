using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Entraineur
    {
        public int Num { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public Entraineur(string prenom, string nom, int num)
        {
            Num = num;
            Prenom = prenom;
            Nom = nom;
        }
    }
}