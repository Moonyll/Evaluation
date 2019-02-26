using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biens
{
    public abstract class Realty
    {
        protected int registerNumber { get; set; } //N° d'enregistrement du bien
        public int id { get => registerNumber; } // Permet la méthode de suppression
        protected string location { get; set; } // Adresse du bien
        protected int area { get; set; } // Superficie du bien
        protected double rent { get; set; } // Loyer du bien
        //Méthode pour ajouter un nouveau bien avec déclaration des attributs
        public Realty(int new_registerNumber, string new_location, int new_area, double new_rent)
        {
            registerNumber = new_registerNumber;
            location = new_location;
            area = new_area;
            rent = new_rent;
        }
        //public new virtual string ToString() { return null; }
        public override string ToString()
        {
            string new_real = "";
            //Concaténation des entrées utilisateur
            new_real += $"Numéro du bien locatif : {registerNumber}\n";
            new_real += $"Adresse : {location}\n";
            new_real += $"Superficie en m² - {area}\n";
            new_real += $"Loyer en euros : {rent}\n";
            //new_real += $"Pièces : {rooms}\n";
            //new_real += $"Etage : {floor}\n";
            return new_real;
        }
    }
}
