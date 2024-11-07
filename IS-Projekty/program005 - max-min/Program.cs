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
            Console.WriteLine("********************************************************\n\n");
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

            Console.WriteLine("\nNáhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            }
            
            int max = myArray[0];
            int min = myArray[0];
            int poziceMax = 0;
            int poziceMin = 0;
    

            for(int i=1; i<n; i++) {
                 if(myArray[i] > max) {
                    max = myArray[i];
                    poziceMax = i;
                }
                if(myArray[i] < min) {
                    min = myArray[i];
                    poziceMin = i;
                }
    }

    Console.WriteLine("\n==================================");
    Console.WriteLine("\nMaximum: {0}, první pozice maxima {1}", max, poziceMax);
    Console.WriteLine("Minimum: {0}, první pozice minima {1}", min, poziceMin);

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }

}


