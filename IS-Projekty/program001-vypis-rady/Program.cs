using System;

class Program {

    static void Main() {
        
        //chci aby se program opakoval po stisku klávesy "a"
        string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("************** Výpis řady **************");
            Console.WriteLine("****************************************");
            Console.WriteLine("*********** Karolína Hájková ***********");
            Console.WriteLine("****************************************\n\n");
            Console.WriteLine();

            
            // Vstup od uživatele TO-DO - špatná varianta
            //Console.WriteLine("Zadejte první číslo řady: ");
            //int first = int.Parse (Console.ReadLine());



            // Vstup od uživatele TO-DO - správná verze
            Console.WriteLine("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            Console.WriteLine("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celé číslo): ");
            }

            Console.WriteLine("Zadejte diference (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diference (celé číslo): ");
            }

            //Výpis uživatelského vstupu
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference číslo řady: {0}", step);
            Console.WriteLine();
            Console.WriteLine();



            //Logika pro výpis řady TO-DO

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }


}


