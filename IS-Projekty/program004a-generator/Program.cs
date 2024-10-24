using System.ComponentModel;
using System.Security.Cryptography;

class Program {

    static void Main() {
        
        //chci aby se program opakoval po stisku klávesy "a"
        string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("************ Generátor pseudonáhoných čísel ************");
            Console.WriteLine("********************************************************");
            Console.WriteLine("******************* Karolína Hájková *******************");
            Console.WriteLine("********************************************************n\n");
            Console.WriteLine();

            // Vstup od uživatele TO-DO - správná verze
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
            }     

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }     

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }     

            Console.WriteLine("\n\n============================================================");
            Console.WriteLine("Uživatelský vstup:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("============================================================");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            int kladna = 0;
            int zaporna = 0;
            int nuly = 0;
            int suda = 0;
            int licha = 0;

            Console.WriteLine("\n\nNáhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            
            
            // if(myArray[i]>0)
            //    kladna++;
            // if(myArray[i]<0)
            //    zaporna++;
            // if(myArray[i]=0)
            //    nuly++;

            if(myArray[i]>0) 
                kladna++;
            else if(myArray[i]<0)
                zaporna++;
            else
                nuly++;

            if(myArray[i] % 2 == 0)
                suda++;
            else
               licha++;

            }

            Console.WriteLine("\n\nPočet kladných čísel: {0}", kladna);
            Console.WriteLine("Počet záporných čísel: {0}", zaporna);
            Console.WriteLine("Počet nul: {0}", nuly);

            Console.WriteLine("Počet sudých čísel: {0}", suda);
            Console.WriteLine("Počet lichých čísel: {0}", licha);



            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }

}


