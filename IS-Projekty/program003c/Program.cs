using System;

class Program {
    static void Main() {
        
        // Opakování programu po stisku klávesy "a"
        string again = "a"; 
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("*************** Písmeno N ***************");
            Console.WriteLine("****************************************");
            Console.WriteLine("*********** Karolína Hájková ***********");
            Console.WriteLine("****************************************\n\n");

            // Vstup od uživatele pro výšku normálního "N"
            Console.Write("Zadejte výšku obrazce N (celé číslo): ");
            int heightN;
            while(!int.TryParse(Console.ReadLine(), out heightN) || heightN < 2) {
                Console.Write("Nezadali jste platné celé číslo (výška musí být alespoň 2). Zadejte znovu výšku obrazce N: ");
            }

            Console.WriteLine();

            // Generování písmena "N"
            for(int i = 0; i < heightN; i++) {
                for(int j = 0; j < heightN; j++) {
                    if(j == 0 || j == heightN - 1 || j == i) {
                        Console.Write("* ");
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n****************************************");
            Console.WriteLine("************* Zrcadlové N **************");
            Console.WriteLine("****************************************\n\n");

            // Vstup od uživatele pro výšku zrcadlového "N"
            Console.Write("Zadejte výšku obrazce zrcadlového N (celé číslo): ");
            int heightMirrorN;
            while(!int.TryParse(Console.ReadLine(), out heightMirrorN) || heightMirrorN < 2) {
                Console.Write("Nezadali jste platné celé číslo (výška musí být alespoň 2). Zadejte znovu výšku obrazce zrcadlového N: ");
            }

            Console.WriteLine();

            // Generování zrcadlového "N"
            for(int i = 0; i < heightMirrorN; i++) {
                for(int j = 0; j < heightMirrorN; j++) {
                    if(j == 0 || j == heightMirrorN - 1 || j == heightMirrorN - i - 1) {
                        Console.Write("* ");
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n****************************************");
            Console.WriteLine("************** Kosočtverec **************");
            Console.WriteLine("****************************************\n\n");

            // Vstup pro výšku kosočtverce
            Console.Write("Zadejte výšku kosočtverce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height) || height < 1) {
                Console.Write("Nezadali jste platné celé číslo (výška musí být alespoň 1). Zadejte znovu výšku kosočtverce: ");
            }

            Console.WriteLine();

            // Generování kosočtverce (vyplněného)
            // Horní část kosočtverce
            for(int i = 0; i < height; i++) {
                for(int j = 0; j < height - i - 1; j++) {
                    Console.Write("  "); // Mezery na začátku řádku
                }
                for(int j = 0; j < 2 * i + 1; j++) {
                    Console.Write("* "); // Vytvoření hvězdiček
                }
                Console.WriteLine();
            }

            // Spodní část kosočtverce
            for(int i = height - 2; i >= 0; i--) {
                for(int j = 0; j < height - i - 1; j++) {
                    Console.Write("  "); // Mezery na začátku řádku
                }
                for(int j = 0; j < 2 * i + 1; j++) {
                    Console.Write("* "); // Vytvoření hvězdiček
                }
                Console.WriteLine();
            }

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
