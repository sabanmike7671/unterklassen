using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//nie namen ändern  sondern löschen
namespace Step2Coder_ConsoleApp12
{
    //Klassen immer Großbuchstaben:
    internal class Car
    {
        //Deklaration der Zeichenkette:
        public string model;
        public string color;
        public string super;
        public string diesel;
        public string bestandteile;
        public string kfz_extra;


        //Deklaration der Fließkommmazahlen:
        public double year;
        public double power_horse;
        public double miles;



        //privat ist verschlüsselt und nicht lesbar:
        private double price;



        //Deklaration der Wahrheitswerte mit public öffentlich für jedermann lesbar:
        public bool accident;
        public bool service;
        public bool tuning;




        //Methode als Funktion innerhalb einer Klasse
        //Bezeichnung der Variable nicht in Funktionstitel verwenden CS0102

        public void services()
        {

        }

        public void tunings()
        {

        }

        //Methode ohne static also Bezug auf Klasse ohne Aufruf:
        public void print_data()
        {
            Console.WriteLine("\nAuto: " + "\n" + model + "\nJahre: " + "\n" + year);
        }

        // carriage return \r löscht erste zeichen in zeile


    }
}
