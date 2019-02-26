using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biens
{
    public class House:Realty //Ajout de la classe House enfant (:) de Realty pour la gestion d'une maison
    {
        public int rooms; // Nombre de pièces de la maison
        //Déclaration de la méthode House pour ajouter une maison
        public House(int new_registerNumber, string new_location, int new_area, double new_rent, int new_rooms) : base(new_registerNumber, new_location, new_area, new_rent)
        {
        //Déclaration des variables
        registerNumber = new_registerNumber;
        location = new_location;
        area = new_area;
        rent = new_rent;
        rooms = new_rooms;
        //Entrées utilisateur
        //*
        ////Numéro du bien locatif
        //Console.WriteLine("Numéro du bien : ");
        //new_registerNumber = Convert.ToInt32(Console.ReadLine());
        ////Numéro du bien locatif
        //Console.WriteLine("Numéro du bien : ");
        //new_registerNumber = Convert.ToInt32(Console.ReadLine());
        ////Adresse
        //Console.WriteLine("Adresse de la maison : ");
        //new_location = Console.ReadLine();
        ////Superficie
        //Console.WriteLine("Superficie de la maison en M² : ");
        //new_area = Convert.ToInt32(Console.ReadLine());
        ////Loyer
        //Console.WriteLine("Loyer mensuel de la maison (en euros) : ");
        //new_rent = Convert.ToInt32(Console.ReadLine());
        ////Nombre de pièces
        //Console.WriteLine("Nombre de pièces de la maison : ");
        //new_rooms = Convert.ToInt32(Console.ReadLine());
        }
        //Méthode d'affichage
        public override string ToString()
        {
        string new_house = "";
        //Concaténation des entrées utilisateur
        new_house += $"Numéro du bien locatif : {registerNumber}\n";
        new_house += $"Adresse : {location}\n";
        new_house += $"Superficie en m² : {area}\n";
        new_house += $"Loyer en euros : {rent}\n";
        new_house += $"Nombre de pièces : {rooms}\n";
        return new_house;
        }
    }
}
