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

            // Vstup od uživatele TO-DO

            //Logika pro výpis řady TO-DO

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }


}


