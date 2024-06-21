using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step2Coder_ConsoleApp12
{
    internal class Kunde
    {
        //Deklaration mit Zeichenkette mit public also öffentlich zugänglich: 
        public string name;
        public string firmen_status;
        public string soz_nr;
        
        //privat bedeutet geschützt 
        //private string soz_nr;
        private string kunden_pwd;


        //Deklaration mit Fließkommazahlen:
        public double zinssatz;
        public double konto_inhalt;

        //Deklaration mit Wahrheitswerten:
        public bool is_super_customer;
        public bool is_boss;





        //Methoden und Funktionen klein geschreiben
        public void geldabheben()
        {

        }




        //Methode als Funktion innerhalb einer Klasse
        public void versicherungsnummer()
        {

        }


        //Methode ohne static (Bezug auf Klasse ohne Aufruf) zum Ausgeben:
        public void print_data()
        {
            Console.WriteLine("\nName: " + "\n" + name + "\nVersicherungsnr.: " + "\n" + soz_nr);
        }

        // carriage return \r löscht erste zeichen in zeile



    }
}
