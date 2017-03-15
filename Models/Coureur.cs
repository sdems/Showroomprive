using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Coureur
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Id { get; set; }

        public Entraineur Entraineur { get; set; }

        public Coureur(string prenom,string nom,Entraineur entraineur)
        {
            Prenom = prenom;
            Nom = nom;
            Entraineur = entraineur;
        }
    }
}