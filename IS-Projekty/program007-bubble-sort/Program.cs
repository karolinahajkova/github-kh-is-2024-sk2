using System.Diagnostics;

string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("************ Bubble sort ************");
            Console.WriteLine("*************************************");
            Console.WriteLine("********* Karolína Hájková **********");
            Console.WriteLine("*************************************\n\n");
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

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            }

            Stopwatch myStopwatch = new Stopwatch();

            myStopwatch.Start();

            int numberCompare = 0;
            int numberChange = 0;

            numberCompare++;
            numberChange++;

            for(int i=0; i<n-1; i++) {
                for(int j=0; j<n-i-1; j++) {
                    numberCompare++;
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];               //na dalším řádku se mi vyskytne ten prvek
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange++;
                    }
                }
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSeřazení pole podle BUBBLE SORTu: ");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
            }
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem BUBBLE SORT: {0}", myStopwatch.Elapsed);

            Console.WriteLine("\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("Počet výměn: {0}", numberChange);


            Console.ResetColor();
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    


