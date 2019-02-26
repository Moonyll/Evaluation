using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biens
{
    class Program
    {
        // Déclaration de la liste des biens
        public static List<Realty> Realties = new List<Realty>();
        // Programme principal
        public static void Main(string[] args)
        {
        Menu();
        }
        public static void Menu()
        {
            List<Realty> Realties = new List<Realty>();
            Console.WriteLine("Menu de l'application");
            Console.WriteLine();
            Console.WriteLine("1. Liste des biens");
            Console.WriteLine("2. Ajouter un appartement");
            Console.WriteLine("3. Ajouter une maison");
            Console.WriteLine("4. Ajouter un parking");
            Console.WriteLine("5. Supprimer un bien immobilier");
            Console.WriteLine("6. Quitter l'application");
            // Choix de l'utilisateur
            int choice = int.Parse(Console.ReadLine());
            // Cas selon choix de l'utilisateur        
            switch (choice)
            {
                case 1: // Afficher la liste des biens immobiliers
                     Console.Clear();
                     DisplayList();
                    Console.ReadKey();
                    Menu();
                    break;
                case 2: // Ajouter un appartement
                    Console.Clear();
                    AddFlat();
                    Console.ReadKey();
                    Menu();
                    break;
                case 3: // Ajouter une nouvelle maison
                    Console.Clear();
                    AddHouse();
                    Console.ReadKey();
                    Menu();
                    break;
                case 4: // Ajouter un nouveau parking
                    Console.Clear();
                    AddParking();
                    Console.ReadKey();
                    Menu();
                    break;
                case 5: // Supprimer un bien immobilier
                    Console.Clear();
                    Remove();
                    Console.ReadKey();
                    Menu();
                    break;
                case 6:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
        // Afficher la liste des biens
        public static void DisplayList()
        {
            // Nombre d'éléments de la liste
            int i = Realties.Count();
            //Boucle for each pour afficher la liste des biens immobiliers
            Console.WriteLine("Gestion du parc immobilier de l'agence"+"\n"+"Le stock immobilier de l'agence est, actuellement de : "+i+"bien(s)" );
            foreach (var real in Realties)
            { 
            Console.WriteLine(real.ToString());
            }
            Console.ReadKey();
        }
        // Supprimer un bien
        public static void Remove()
        {
            Console.WriteLine("Indiquez le n° du bien que vous souhaitez supprimer? ");
            int real_number = int.Parse(Console.ReadLine());
            Realty number = Realties.Single(a => a.id == real_number);
            // Test pour trouver le bien
            if (number != null)
            {
            Realties.Remove(number);
            }
            else
            {
            Console.WriteLine("Le n° du bien est introuvable.");
            }
        }
           // Méthode ajout appartement
            public static void AddFlat()
        {
            //Déclaration des variables
            int new_registerNumber;
            string new_location;
            int new_area;
            double new_rent;
            int new_rooms;
            int new_floor;
            //Entrées utilisateur
            //*
            //Numéro du bien locatif
            Console.WriteLine("Numéro du bien : ");
            new_registerNumber = Convert.ToInt32(Console.ReadLine());
            //Adresse
            Console.WriteLine("Adresse de l'appartement : ");
            new_location = Console.ReadLine();
            //Superficie
            Console.WriteLine("Superficie de l'appartement en M² : ");
            new_area = Convert.ToInt32(Console.ReadLine());
            //Loyer
            Console.WriteLine("Loyer mensuel de l'appartement (en euros) : ");
            new_rent = Convert.ToInt32(Console.ReadLine());
            //Nombre de pièces
            Console.WriteLine("Nombre de pièces de l'appartement : ");
            new_rooms = Convert.ToInt32(Console.ReadLine());
            //Etage 
            Console.WriteLine("Etage où se situe l'appartement : ");
            new_floor = Convert.ToInt32(Console.ReadLine());
            //Entrées utilisateur
            Flat new_flat = new Flat(new_registerNumber, new_location, new_area, new_rent, new_rooms, new_floor);
            //Ajout du nouvel appartement dans la liste des biens
            Realties.Add(new_flat);
            Console.WriteLine(new_flat.ToString());
            //return new_flat;
        }
        // Méthode ajout maison
        public static void AddHouse()
        {
            //Déclaration des variables
            int new_registerNumber;
            string new_location;
            int new_area;
            double new_rent;
            int new_rooms;
            //Entrées utilisateur
            //*
            //Numéro du bien locatif
            Console.WriteLine("Numéro du bien : ");
            new_registerNumber = Convert.ToInt32(Console.ReadLine());
            //Adresse
            Console.WriteLine("Adresse de la maison : ");
            new_location = Console.ReadLine();
            //Superficie
            Console.WriteLine("Superficie de la maison en M² : ");
            new_area = Convert.ToInt32(Console.ReadLine());
            //Loyer
            Console.WriteLine("Loyer mensuel de la maison (en euros) : ");
            new_rent = Convert.ToInt32(Console.ReadLine());
            //Nombre de pièces
            Console.WriteLine("Nombre de pièces de la maison : ");
            new_rooms = Convert.ToInt32(Console.ReadLine());
            //Entrées utilisateur
            House new_house = new House(new_registerNumber, new_location, new_area, new_rent, new_rooms);
            //Ajout de la nouvelle maison dans la liste des biens
            Realties.Add(new_house);
            //return new_house;
        }
        // Méthode ajout parking
        public static void AddParking()
        {
            //Déclaration des variables
            int new_registerNumber;
            string new_location;
            int new_area;
            int new_rent;
            //Entrées utilisateur
            //*
            //Numéro du bien locatif
            Console.WriteLine("Numéro du bien : ");
            new_registerNumber = Convert.ToInt32(Console.ReadLine());
            //Adresse
            Console.WriteLine("Adresse du parking : ");
            new_location = Console.ReadLine();
            //Superficie
            Console.WriteLine("Superficie du parking en m² : ");
            new_area = Convert.ToInt32(Console.ReadLine());
            //Loyer
            Console.WriteLine("Loyer mensuel du parking (en euros) : ");
            new_rent = Convert.ToInt32(Console.ReadLine());
            //Entrées utilisateur
            Parking new_parking = new Parking(new_registerNumber, new_location, new_area, new_rent);
            //Ajout du nouveau parking dans la liste des biens
            Realties.Add(new_parking);
            //return new_parking;
        }
    }
}
