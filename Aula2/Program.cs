using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dados no C# (init state)
            int A;
            long B;
            ulong C;

            decimal D=4.555555555555555M;//28 casas    //precisa da letra M no final (Money)
            float E=4.555555F;//6 casas          //precisa da letra F no final
            double F = 4.5555555555; //14 casas


            A = 1234567890; //10^9
            B = 1234567890123456789;//10^19
            C = 12345678901234567890;//10^20 //não tem como usar numero negativo

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);

            Console.WriteLine();
            Console.WriteLine();



            decimal a = 1.994444M;
            Console.WriteLine(Math.Round(a, 2)); //retornar 1.99
            Console.WriteLine(Math.Ceiling(a));  //retornar 2 (Arredonda para o próximo inteiro)
            Console.WriteLine(Math.Floor(a));  //retur 1 (Arredonda para o atual inteiro)
            Console.WriteLine(String.Format("{0:C2}",a)); //resulta em R$1.99
            Console.WriteLine(String.Format("{0:C3}",a)); //resulta em R$1.994

        }
    }
}
