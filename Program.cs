
//CALCULADORA DO LG

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("..:::| C.A.L.C.U.L.A.D.O.R.A |:::..");
        Console.WriteLine("=====================================");
        Console.WriteLine("Informe um número:");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 0: Sair(); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;
        }

    }


    static void Sair()
    {
        Console.WriteLine("Obrigado por utilizar nossa ferramenta!");
        Thread.Sleep(5000);
        Console.Clear();
        System.Environment.Exit(0);
    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("informe um valor: ");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe outro valor: ");
        int v2 = int.Parse(Console.ReadLine());
        int resultado = v1 + v2;
        Console.WriteLine($"O valor da operação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()

    {
        Console.Clear();
        Console.WriteLine("Informe um valor: ");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informa outro valor");
        int v2 = int.Parse(Console.ReadLine());
        int resultado = v1 - v2;
        Console.WriteLine($"O Valor da operação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("informe um valor:");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("informe outro valor:");
        int v2 = int.Parse(Console.ReadLine());
        int resultado = v1 / v2;
        Console.WriteLine($"O Valor da operação é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("informe um valor:");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("informe outro valor:");
        int v2 = int.Parse(Console.ReadLine());
        int resultado = v1 * v2;
        Console.WriteLine("o valor da operação é: ");
        Console.ReadKey();
        Menu();

    }

}


