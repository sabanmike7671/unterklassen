
using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;


//nie namen ändern  sondern löschen

namespace Step2Coder_ConsoleApp12
{
    internal class Program
    {

        //unter program.cs die main als hauptprogramm:

        //Klasse mit Kunde wie ein eigener Datentyp

        //static gehört zu statistischen Methoden müssen Variablen aus Klassen mit int static ... deklariert werden
        //private static void Main(string[] args) sonst Compilerfehler CS5001
        private static void Main(string[] args)
        {

            //Deklaration mit Datentyp und Variable:
            int zahl1;

            //Datentyp Kunde mit Variable kunde:
            Kunde kunde1 = new Kunde();
            Kunde kunde2 = new Kunde();

            //Datentyp Car Auto mit Variable model:
            Car model1 = new Car();
            Car model2 = new Car(); 

            //Datentyp Human Mensch mit Variable attribut:
            Human attribut1 = new Human();
            Human attribut2 = new Human();  



            //Klasse Kunde.cs beginnt ab hier:
            //kunde1 ist hier Objekt mit Klasse erzeugt:
            kunde1.name = "Max Mustermann";
            kunde1.soz_nr = "4257241086";


            Console.WriteLine("Wie heißt dein Kunde ?");
            kunde1.name = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Was ist deine Sozialversicherungsnummer ?");
            kunde1.soz_nr = Convert.ToString(Console.ReadLine());





            //Klasse Car.cs beginnt ab hier:
            model1.bestandteile  = "turbolader";
            model1.kfz_extra = "keramikbremsen";


            //model1 ist hier Objekt mit Klasse erzeugt:
            Console.WriteLine("Welches Auto fährst du ?");
            model1.model = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Seit wann fährst du dieses Auto ?");
            model1.year = Convert.ToInt32(Console.ReadLine());




            //Klasse Human.cs beginnt ab hier:
            attribut1.hobby = "tauchen";
            attribut1.shoes = 47;


            Console.WriteLine("Wann bist du geboren ?");
            attribut1.geb_dat = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Was ist deine Haarfarbe ?");
            attribut1.hair_color = Convert.ToString(Console.ReadLine());



            //newline \n oder leerzeichen in c#
            //Kunde aufrufen methode über das Objekt greife ich auf Methode print_data zu:
            kunde1.print_data();
         
            //Klasse Auto wird durch die Methode print_data(); ausgegeben:
            model1.print_data();


        }
    }
}
