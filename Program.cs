using System;
using System.Collections.Generic;
using System.Threading;

class Genius
{
   static void Main()
    {
        Console.WriteLine("--- Genius ---\n");

        Console.WriteLine("Dificuldades: \n");
        Console.WriteLine("1 - Facil (8 botões)");
        Console.WriteLine("2 - Medio (14 botões)");
        Console.WriteLine("3 - Dificil (20 botões)");
        Console.WriteLine("4 - Expert (31 botões)");

        while (true)
        {
            Console.Write("Escolha a dificuldade (1 a 4): ");
            if (int.TryParse(Console.ReadLine(), out nivel) && nivel >= 1 && nivel <= 4)
                break;
            Console.WriteLine("Opção inválida!");
        }

        int sequenciaMax = dificuldade[nivel];
        List<char> sequencia = new List<char>();
        char[] botoes = { 'R', 'G', 'Y', 'B' };

        Console.WriteLine("Prepare-se para a sequência...");
        Thread.Sleep(1000);

        for (int rodada = 0; rodada < sequenciaMax; rodada++)
        {
            char proximo = botoes[random.Next(4)];
            sequencia.Add(proximo);

            Console.Clear();
            Console.WriteLine($"Rodada {rodada + 1} de {sequenciaMax}");
            Console.WriteLine("Memorize a sequência:");

            MostrarSequencia(sequencia);

            Console.Clear();
            Console.WriteLine("Agora é sua vez! Digite a sequência usando:");
            Console.WriteLine("R = Vermelho | G = Verde | Y = Amarelo | B = Azul");

            for (int i = 0; i < sequencia.Count; i++)
            {
                Console.Write($"Botão #{i + 1}: ");
                string entrada = Console.ReadLine()!.ToUpper();

                if (entrada.Length != 1 || !"RGYB".Contains(entrada))
                {
                    Console.WriteLine("Entrada inválida. Você perdeu!");
                    SomDerrota();
                    return;
                }

                if (entrada[0] != sequencia[i])
                {
                    Console.WriteLine($"Errou! O correto era {colors[sequencia[i]]}. Você perdeu!");
                    SomDerrota();
                    return;
                }
            }

            Console.WriteLine("Sequência correta! Próxima rodada...");
            Thread.Sleep(1000);
        }

        // Venceu o jogo
        Console.WriteLine("Parabéns! Você venceu o jogo!");

        if (nivel == 4)
            SomVitoriaEspecial();
        else
            SomVitoria();
    }

     static Random random = new Random();

    static Dictionary<char, string> colors = new Dictionary<char, string>
    {
        {'R', "Vermelho" },
        {'G', "Verde" },
        {'Y', "Amarelo" },
        {'B', "Azul" }
    };

    static Dictionary<int, int> dificuldade = new Dictionary<int, int>
    {
        {1, 8},
        {2, 14},
        {3, 20},
        {4, 31}
    };

    static int nivel;


    static void MostrarSequencia(List<char> sequencia)
    {
        foreach (char c in sequencia)
        {
            Console.WriteLine($"-> {colors[c]}");
            Console.Beep(GetFrequencia(c), 500);
            Thread.Sleep(200);
        }
    }

    static int GetFrequencia(char cor)
    {
        return cor switch
        {
            'R' => 400,
            'G' => 500,
            'Y' => 600,
            'B' => 700,
            _ => 800
        };
    }

    static void SomDerrota()
    {
        Console.Beep(300, 700);
        Console.Beep(200, 700);
        Console.Beep(100, 700);
    }

    static void SomVitoria()
    {
        Console.Beep(600, 300);
        Console.Beep(800, 300);
        Console.Beep(1000, 300);
    }

    static void SomVitoriaEspecial()
    {
        Console.Beep(900, 300);
        Console.Beep(1100, 300);
        Console.Beep(1300, 300);
        Console.Beep(1500, 300);
    }
}