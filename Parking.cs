using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biens
{
    public class Parking:Realty //Ajout de la classe Parking enfant (:) de Realty pour la gestion d'un parking
    {
        //Déclaration de la méthode Parking pour ajouter un parking
        public Parking(int new_registerNumber, string new_location, int new_area, double new_rent) : base(new_registerNumber, new_location, new_area, new_rent)
        {
        //Déclaration des variables
        registerNumber = new_registerNumber;
        location = new_location;
        area = new_area;
        rent = new_rent;
        ////Entrées utilisateur
        ////*
        ////Numéro du bien locatif
        //Console.WriteLine("Numéro du bien : ");
        //new_registerNumber = Convert.ToInt32(Console.ReadLine());
        ////Adresse
        //Console.WriteLine("Adresse du parking : ");
        //new_location = Console.ReadLine();
        ////Superficie
        //Console.WriteLine("Superficie du parking en m² : ");
        //new_area = Convert.ToInt32(Console.ReadLine());
        ////Loyer
        //Console.WriteLine("Loyer mensuel du parking (en euros) : ");
        //new_rent = Convert.ToInt32(Console.ReadLine());
        }
        //Méthode d'affichage
        public override string ToString()
        {
        string new_parking = "";
        //Concaténation des entrées utilisateur
        new_parking += $"Numéro du bien locatif : {registerNumber}\n";
        new_parking += $"Localisation du bien : {location}\n";
        new_parking += $"Superficie en m² : {area}\n";
        new_parking += $"Loyer en euros : {rent}\n";
        return new_parking;
        }
    }
}
