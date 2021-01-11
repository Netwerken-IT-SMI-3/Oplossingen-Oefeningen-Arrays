using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// 
/// Naam: Dhr. Gillade Tom
/// Datum: 04/01/2021
/// Project: Inleiding tot Arrays: voorbeelden en oefeningen
///

namespace _5NIT_ConsApp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //slecht voorbeeld
            //we wensen de neerslag te registreren van een volledige week
            int dag1 = 34;
            int dag2 = 3;
            int dag3 = 37;
            int dag4 = 3;
            int dag5 = 3;
            int dag6 = 3;
            int dag7 = 3;

            int somneerslag = dag1 + dag2 + dag3;

            #region Voorbeeld 1
            /// 
            /// Voorbeeld 1: 
            /// 
            Console.WriteLine("Voorbeeld 1");

            //We maken een array aan die volledige leeg is.
            //De vierkante haakjes duiden erop dat het gaat om een array.
            string[] mijnMerk;

            //We vullen onze array op met 4 gegevens.
            //De array kan niet meer aangepast worden qua grootte.
            mijnMerk = new string[] { "Maes", "Duvel", "Cornet", "Jupiler" };

            //Aan de hand van mijnMerk[waarde] krijg je de corresponderende waarde in het 
            //Console-venster afgedrukt
            Console.WriteLine(mijnMerk[0]);
            Console.WriteLine(mijnMerk[1]);
            Console.WriteLine(mijnMerk[2]);
            Console.WriteLine(mijnMerk[3]);

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Voorbeeld 2
            /// 
            /// Voorbeeld 2 
            /// 
            Console.WriteLine("Voorbeeld 2");

            string[] mijnMerk2 = { "Coca Cola", "Fanta Orange", "Sprite", "Red Bull", "Spa Blauw", "Spa Rood" };

            for (int teller = 0; teller < 6; teller++)
            {
                Console.WriteLine(mijnMerk2[teller]);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Voorbeeld 3
            /// 
            /// Voorbeeld 3 
            /// 
            Console.WriteLine("Voorbeeld 3");

            string[] mijnMerk3;

            //We geven de array direct een vaste grootte mee (van 8 waarden), maar nog geen inhoud.
            mijnMerk3 = new string[8];

            //een waarde inlezen en bewaren op positie 0 in onze array         
            for (int teller = 0; teller < 8; teller++)
            {
                Console.Write("Gelieve een drankje in te vullen:     ");
                mijnMerk3[teller] = Console.ReadLine();
            }

            Console.WriteLine("De eerste waarde van de array " + mijnMerk3[0]);
            Console.WriteLine("De laatste waarde van de array " + mijnMerk3[7]);

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Voorbeeld 4
            /// 
            /// Voorbeeld 4 
            /// 
            Console.WriteLine("Voorbeeld 4");

            string[] mijnAuto = { "Audi", "Volvo", "Mercedes", "BMW" };
            //Als de gebruiker niet weet hoe groot de array is, kan je gebruik maken van .Length
            for (int teller = 0; teller < mijnAuto.Length; teller++)
            {
                Console.WriteLine(mijnAuto[teller]);
            }

            Console.WriteLine("----------------------------------------------------------------");

            //Sorteer de array
            Array.Sort(mijnAuto);

            for (int teller = 0; teller < mijnAuto.Length; teller++)
            {
                Console.WriteLine(mijnAuto[teller]);
            }

            Console.WriteLine("----------------------------------------------------------------");

            //Draai de array om
            Array.Reverse(mijnAuto);

            for (int teller = 0; teller < mijnAuto.Length; teller++)
            {
                Console.WriteLine(mijnAuto[teller]);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening 1
            /// 
            /// Oefening 1: Er worden 10 getallen ingelezen. 
            /// De getallen worden in omgekeerde volgorde afgedrukt.
            /// 
            Console.WriteLine("Oefening 1");

            int[] oefening1 = new int[10];

            for (int teller = 0; teller < oefening1.Length; teller++)
            {
                Console.Write($"Geef getal {teller+1} in:     ");
                oefening1[teller] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(oefening1);

            for (int teller = 0; teller < oefening1.Length; teller++)
            {
                Console.Write(oefening1[teller].ToString().PadLeft(5));
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening 2
            /// 
            /// Oefening 2: Schrijf een methode/functie om te controleren of 
            /// een array (5 elementen) een bepaalde waarde bevat.
            /// 
            Console.WriteLine("Oefening 2");

            int[] oefening2 = new int[5];

            for (int teller = 0; teller < oefening2.Length; teller++)
            {
                Console.Write($"Geef getal {teller + 1} in:     ");
                oefening2[teller] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Welke waarde wens je op te zoeken in de array?     ");
            int opTeZoekenGetal = Convert.ToInt32(Console.ReadLine());

            bool controle = false;

            //for (int teller = 0; teller < oefening2.Length; teller++)
            //{
            //    if (oefening2[teller] == opTeZoekenGetal)
            //    {
            //        controle = true;
            //    }
            //}

            controle = oefening2.Contains(opTeZoekenGetal);

            Console.Write(controle);

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening 3
            /// 
            /// Oefening 3: Schrijf een methode/functie waar je als resultaat 
            /// weergeeft hoeveel waarden van een array (4 elementen) gelijk zijn aan ‘true’.
            /// 
            Console.WriteLine("Oefening 3");

            bool[] oefening3 = new bool[4];

            for (int teller = 0; teller < oefening3.Length; teller++)
            {
                Console.Write("Geef een true/false waarde in:     ");
                oefening3[teller] = Convert.ToBoolean(Console.ReadLine());
            }

            int aantal = 0;

            for (int teller = 0; teller < oefening3.Length; teller++)
            {
                if (oefening3[teller] == true)
                {
                    aantal += 1;
                }
            }

            Console.WriteLine($"Er zijn {aantal} waarden gelijk aan true.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            
            #region Voorbeeld 5
            /// 
            /// Voorbeeld 5 
            /// 
            Console.WriteLine("Voorbeeld 5");

            int[] voorbeeld5 = new int[4];

            voorbeeld5[0] = 10;
            voorbeeld5[1] = 20;
            voorbeeld5[2] = 30;
            voorbeeld5[3] = 40;

            for (int teller = 0; teller < voorbeeld5.Length; teller++)
            {
                Console.WriteLine($"Voor de aanpassing: {voorbeeld5[teller]}");
            }

            Array.Resize(ref voorbeeld5, 2);

            for (int teller = 0; teller < voorbeeld5.Length; teller++)
            {
                Console.WriteLine($"Na de aanpassing: {voorbeeld5[teller]}");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Voorbeeld 6
            /// 
            /// Voorbeeld 6 
            /// 
            Console.WriteLine("Voorbeeld 6");

            char[] woord = new char[5];

            woord[0] = 's';
            woord[1] = 'c';
            woord[2] = 'h';
            woord[3] = 'o';
            woord[4] = 'o';
            
            Console.Write(new string(woord));

            Console.ReadKey();
            Console.Clear();
            #endregion

            
            #region Oefening
            /// 
            /// Oefening: Maak een programma waarbij de gebruiker een getal ingeeft. 
            /// Vervolgens maak je een array aan ter grootte van dit getal. 
            /// Vul de array op met alle waarden in aflopende volgorde.
            /// 
            Console.WriteLine("Oefening");

            Console.Write("Geef de grootte van de array op:     ");
            int arrayGrootte = Convert.ToInt32(Console.ReadLine()) + 1;

            int[] oefeningAfloop = new int[arrayGrootte];

            for (int teller = 0; teller < oefeningAfloop.Length; teller++)
            {
                oefeningAfloop[teller] = arrayGrootte - 1;
                arrayGrootte -= 1;

                Console.Write(oefeningAfloop[teller].ToString().PadRight(5));
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening
            /// 
            /// Oefening: Maak een programma waarbij je de gebruiker een getal laat invullen. 
            /// Toon vervolgens alle even getallen tussen dat getal en 0.
            /// 
            Console.WriteLine("Oefening");

            Console.Write("Geef een getal in:     ");
            int arrayMax = Convert.ToInt32(Console.ReadLine()) + 1;

            int[] oefeningEven = new int[arrayMax];

            for (int teller = 0; teller < oefeningEven.Length; teller++)
            {
                if (teller%2==0)
                {
                    oefeningEven[teller] = teller;
                    Console.Write(oefeningEven[teller].ToString().PadRight(5));
                }
            }

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening 
            /// 
            /// Oefening: Maak een programma waarbij je de gebruiker een woord laat invullen. 
            /// Vervolgens maak je een array aan waar je opbouwend alle lettercombinaties in bewaard.
            /// 
            Console.WriteLine("Oefening");

            Console.Write("Geef een woord in:     ");
            string woord = Console.ReadLine();

            int lengteWoord = woord.Length;

            string[] oefeningWoord = new string[lengteWoord];

            for (int teller = 0; teller < oefeningWoord.Length; teller++)
            {
                    oefeningWoord[teller] = woord.Substring(0, teller+1);
                    Console.WriteLine(oefeningWoord[teller]);
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            

            #region Oefening SomVanArray
            /// 
            /// Oefening SomVanArray: Vraag 5 getallen op. 
            /// Bewaar ze in een array. Bereken de som van de getallen en geef de uitkomst weer.
            /// 
            Console.WriteLine("Oefening SomVanArray");

            int[] somVanArray = new int[5];

            for (int teller = 0; teller < somVanArray.Length; teller++)
            {
                Console.Write("Gelieve een getal in te geven:     ");
                somVanArray[teller] = Convert.ToInt32(Console.ReadLine());
            }

            int som = 0;

            for (int teller = 0; teller < somVanArray.Length; teller++)
            {
                som += somVanArray[teller];
            }

            Console.WriteLine($"De som van alle arraywaarden is: {som}");

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening ArrayAlternerend
            /// 
            /// Oefening ArrayAlternerend: Vraag 5 getallen op. 
            /// Bewaar ze in een array. Alterneer tussen + en - en geef de uitkomst weer.
            /// 
            Console.WriteLine("Oefening ArrayAlternerend");

            int alternerend = somVanArray[0];

            for (int teller = 1; teller < somVanArray.Length; teller++)
            {
                if (teller%2 == 0)
                {
                    alternerend -= somVanArray[teller];
                }
                else
                {
                    alternerend += somVanArray[teller];
                }
                
            }

            Console.WriteLine($"De alternerende waarde is: {alternerend}");

            Console.ReadKey();
            Console.Clear();
            #endregion


            #region Oefening WelkGetal
            /// 
            /// Oefening WelkGetal: Vraag 7 getallen op. Bewaar ze in een array. 
            /// Vraag de gebruiker het hoeveelste getal hij wil terugzien 
            /// en toon het gevraagde getal.
            /// 
            Console.WriteLine("Oefening WelkGetal");

            int[] welkGetalVanArray = new int[7];
            Random willekeurigGetal = new Random();

            for (int teller = 0; teller < welkGetalVanArray.Length; teller++)
            {
                welkGetalVanArray[teller] = willekeurigGetal.Next(0,11);
            }

            Console.Write("Het hoeveelste getal uit de array wens je te zien?     ");
            int welkGetal = Convert.ToInt32(Console.ReadLine());


            for (int teller = 0; teller < welkGetalVanArray.Length; teller++)
            {
                Console.WriteLine(welkGetalVanArray[teller]);
            }

            Console.WriteLine($"Getal {welkGetal} uit de array is: {welkGetalVanArray[welkGetal-1]} ");

            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
}
