using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._5 {
    class ClassRedPanda {
        //      SAME FOR ALL
        private static int eyes = 2;
        private static int legs = 4;
        private static int tail = 1;

        public ClassRedPanda(bool gender) {
            if(gender == true) {
                Console.WriteLine("It's a female!");
            }
            else {
                Console.WriteLine("It's a male!");
            }
        }

        //      UNIQUE FOR ALL
        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        private int age;
        public int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        //      STUFF THEY DO
        public static void Sleep(string name) {    // Need to mention "name" as an agument here since it's private.
            Console.WriteLine("sssh, {0} sover", name);
            return;
        }
    }
}
