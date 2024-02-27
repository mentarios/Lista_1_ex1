using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex1
{
    internal class Program
    {
        // oi
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("digite 1 numero:");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro numero:");
            n2=int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            if(soma > 10) {soma=soma+5 }
            else { soma=soma-7;}
        }
    }
}
