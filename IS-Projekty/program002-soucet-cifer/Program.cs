//chci aby se program opakoval po stisku klávesy "a"
using System.ComponentModel;

string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("********* Součet a součin cifer ********");
            Console.WriteLine("****************************************");
            Console.WriteLine("*********** Karolína Hájková ***********");
            Console.WriteLine("****************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele TO-DO - správná verze
            Console.WriteLine("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu celé číslo: ");
            }     

            // Kontrola výpisu 
            Console.WriteLine("========================================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("========================================\n\n");

            int suma = 0;
            int numberBackup = number;
            int digit;

            // pokud je číslo záporné, tak mínus odstraníme
            if(number < 0) {
                number = number - number;
            }

            while(number >= 10) {               //10 tedy bude dvouciferné
                digit = number % 10;            // % operátor modulo, zbytek po dělení čísel
                number = (number - digit) /10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }