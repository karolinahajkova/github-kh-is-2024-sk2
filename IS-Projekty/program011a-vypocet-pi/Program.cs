string opakovani = "a";
while(opakovani == "a")
{
    Console.Clear();    
    Console.WriteLine("*************************************");
    Console.WriteLine("******* Výpočet konstanty PI *******");
    Console.WriteLine("*************************************");
    Console.WriteLine("********* Karolína Hájková **********");
    Console.WriteLine("*************************************");

    

    /* Sem vložíme logiku našeho programu */
    Console.Write("\nZadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
    double presnost;
    while(!double.TryParse(Console.ReadLine(), out presnost))
        Console.Write("Zřejmě jste nezadali přesnost správně.\nZadejte znovu: ");
        
    Console.WriteLine("\nZadaná přesnost: {0}", presnost);
    Console.WriteLine("==========================================\n");

    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;

    while((1/i)>presnost) {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko*(1/i);
        if(znamenko==1)
            Console.WriteLine("Zlomek: +(1/{0}); aktuální hodnota PI = {1}", i, piCtvrt * 4);
        else
            Console.WriteLine("Zlomek: -(1/{0}); aktuální hodnota PI = {1}", i, piCtvrt * 4) ;    
    

    }



    
        Console.WriteLine("\n\nHodnota čísla PI = {0}", piCtvrt * 4);
    // Opakování programu
    Console.WriteLine("\n\n\nPro opakování programu stiskněte klávesu a");
    opakovani=Console.ReadLine(); 
}