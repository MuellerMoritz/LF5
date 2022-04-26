/**
  *Kundennummer Generator
  *
  *@author  Moritz Müller
  *@date    26.04.22
  *
  */

namespace Kundennummer{
    class Kundennummer{

        public static void Main(){
            while(true){
                Console.WriteLine("Die vergebene Kundennummer ist: " + kundennummerGenerieren());
                Console.ReadLine();
            }
        }

        static string kundennummerGenerieren(){
            //Object Init
            Random rnd = new Random();  //Zufallsgenerator

            //Variablen Init
            string kundennummer = "KD";
            int quersumme = 0;
            int ziffer = 0;
            bool ungueltig = true;

            //Logik

            //Kundennummern generieren, bis eine gültige gefunden wurde
            while(ungueltig){
                //Stellen 3 bis 10 generieren
                for(int i = 0; i < 8 ; i++){
                    ziffer = rnd.Next(10);
                    quersumme += ziffer;
                    kundennummer += ziffer.ToString();
                }
                //Quersumme überprufen
                if ( 9 < quersumme && quersumme < 100 ){
                    //Gültige Kundennummer
                    kundennummer += quersumme.ToString();
                    ungueltig = false; 
                    //TODO implement findCustomNumber(kundennummer) 
                } else {
                    //Ungültige Kundennummer -> ziffern neu generieren
                    kundennummer = "KD";
                }
            }
            //Ausgabe der gültigen Kundennummer
            return kundennummer;
        }

    }
}
