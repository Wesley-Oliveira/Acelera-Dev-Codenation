using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos
            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var mult = 10 * 5;
            var div = 10 / 5;
            var mod = 10 % 5;
            
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtracao: {subtracao}");
            Console.WriteLine($"Multiplicacao: {mult}");
            Console.WriteLine($"Divisão: {div}");
            Console.WriteLine($"Modulo: {mod}");

            // Operadores logicos && - || - !
            var Everdadeiro = true && true;
            var Ouverdadeiro2 = true || false;
            var Efalso1 = true && false;
            var Oufalso2 = false || true;

            Console.WriteLine(Everdadeiro);
            Console.WriteLine(Ouverdadeiro2);
            Console.WriteLine(Efalso1);
            Console.WriteLine(Oufalso2);

            var falsoNegado = !false;
            var verdadeiroNegado = !true;

            Console.WriteLine(falsoNegado);
            Console.WriteLine(verdadeiroNegado);
        }
    }
}
