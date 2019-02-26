using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biens
{
    public class Flat:Realty //Ajout de la classe Flat enfant (:) de Realty pour la gestion d'un appartement
    {
        public int rooms; // Nombre de pièces de l'appartement
        public int floor; // Etage où est situé l'appartement
        public Flat(int new_registerNumber, string new_location, int new_area, double new_rent, int new_rooms, int new_floor) : base(new_registerNumber, new_location, new_area, new_rent)
        {
        //Déclaration des variables
        registerNumber = new_registerNumber;
        location = new_location;
        area = new_area;
        rent = new_rent;
        rooms = new_rooms;
        floor = new_floor;
        ////Entrées utilisateur
        ////*
        ////Numéro du bien locatif
        //Console.WriteLine("Numéro du bien : ");
        //new_registerNumber = Convert.ToInt32(Console.ReadLine());
        ////Adresse
        //Console.WriteLine("Adresse de l'appartement : ");
        //new_location = Console.ReadLine();
        ////Superficie
        //Console.WriteLine("Superficie de l'appartement en M² : ");
        //new_area = Convert.ToInt32(Console.ReadLine());
        ////Loyer
        //Console.WriteLine("Loyer mensuel de l'appartement (en euros) : ");
        //new_rent = Convert.ToInt32(Console.ReadLine());
        ////Nombre de pièces
        //Console.WriteLine("Nombre de pièces de l'appartement : ");
        //new_rooms = Convert.ToInt32(Console.ReadLine());
        ////Etage 
        //Console.WriteLine("Etage où se situe l'appartement : ");
        //new_floor = Convert.ToInt32(Console.ReadLine());
        }
        //Méthode d'affichage
        public override string ToString()
        {
        string new_flat = "";
        //Concaténation des entrées utilisateur
        new_flat += $"Numéro du bien locatif : {registerNumber}\n";
        new_flat += $"Adresse : {location}\n";
        new_flat += $"Superficie en m² - {area}\n";
        new_flat += $"Loyer en euros : {rent}\n";
        new_flat += $"Pièces : {rooms}\n";
        new_flat += $"Etage : {floor}\n";
        return new_flat;
        }
    }
}
