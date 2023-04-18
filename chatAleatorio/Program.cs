using System;

class Program {
    static void Main(string[] args) {
        Random rnd = new Random();

        Console.Write("Digite o valor inicial do intervalo: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor final do intervalo: ");
        int max = int.Parse(Console.ReadLine());

        Console.Write("Quantos números você deseja gerar? ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade > max - min + 1) {
            Console.WriteLine("Não é possível gerar {0} números sem repetição no intervalo [{1}, {2}].", quantidade, min, max);
            return;
        }

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++) {
            int numero;

            do {
                numero = rnd.Next(min, max + 1);
            } while (Array.IndexOf(numeros, numero) != -1);

            numeros[i] = numero;
        }

        Console.WriteLine("Os números gerados são: ");

        foreach (int numero in numeros) {
            Console.Write(numero + "-");
        }

        Console.ReadKey();
    }
}
