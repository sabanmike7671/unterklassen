using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step2Coder_ConsoleApp12
{
    internal class Human
    {

        //privat verschlüsselt nicht zugänglich:
        private string soz_nr;

        //Attribute - Eigenschaften einer Klasse:
        public string name;
        public string geb_dat;
        public string hair_color;
        public string skin_color;
        public string hand_size;
        public string hobby;
        public string gender;


        //Numerische Größen:
        public double weight;
        public double height;
        public double shoes;
        public double clothing;


        //Wahrheitswerte True/False nicht Werte zuweisen:
        public bool is_running;
        public bool is_customer;



        //Methode als Funktion innerhalb einer Klasse
        public void laufen ()
        {

        }

        public void springen()
        {

        }



        //Methode ohne static (Bezug auf Klasse ohne Aufruf) zum Ausgeben:
        public void print_data()
        {
            Console.WriteLine("\nName: " + "\n" + geb_dat + "\nVersicherungsnr.: " + "\n" + hair_color);
        }

        // carriage return \r löscht erste zeichen in zeile


    }
}
