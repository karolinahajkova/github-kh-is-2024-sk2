class Program {

    static void Main() {
        
        //chci aby se program opakoval po stisku klávesy "a"
        string again = "a";             // operátor = je přiřazení hodnoty
        while(again == "a") {          // == je porovnávání hodnot
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("*************** Obdelník ***************");
            Console.WriteLine("****************************************");
            Console.WriteLine("*********** Karolína Hájková ***********");
            Console.WriteLine("****************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele TO-DO - správná verze
            Console.WriteLine("Zadejte šířku obrazce (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo): ");
            }   

            Console.WriteLine("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
            }       

            // for(int i = 1; i <= 10; i ++){
            //     Console.WriteLine(i);
            // }

            // int j = 1;
            // while(j <= 10) {
            //     Console.WriteLine(j);
            //     j++;
            // }

            Console.WriteLine();
            for(int i=1; i<= height; i++){
                for(int j=1; j<= width; j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }




            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

    }

}


