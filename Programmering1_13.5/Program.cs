using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._5 {
    class Program {
        static void Main(string[] args) {
            ClassRedPanda redPanda = new ClassRedPanda(true);
            redPanda.Name = "Tails";
            redPanda.Age = 23;

            Console.WriteLine("Denna kattbjörnen heter {0} och är {1}år gammal.", redPanda.Name, redPanda.Age);
            Console.ReadKey();

            ClassRedPanda.Sleep(redPanda.Name);
            Console.ReadKey();
        }
    }
}
