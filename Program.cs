// See https://aka.ms/new-console-template for more information

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Nilai1");
            Console.WriteLine("Nilai2");
            Console.WriteLine("Nilai3");

            char greetings[] = "Hello World!";

            int main()
            {
                int nomor[4];

                nomor[0] = 15;
                nomor[1] = 25;
                nomor[2] = 70;
                nomor[3] = 100;

                printf("%d\n", nomor[0]);
 
                return 0;
            }
            int main() {
            int Nomor[] = {25, 50, 75, 100};
            Nomor[0] = 77;

            printf("%d", Nomor[0]);
 
          return 0;
            }
        }
    }
}

using System;
using Microsoft.VisualBasic;

namespace LatihanOop{
    class Program{
        static void Main(string[] args){
            Laptop Acer = new Laptop();
            Laptop Axio = new Laptop();

            Acer.hargaLaptop();
            Axio.hargaLaptop();
            Acer.publicMethod();

                    }
    }
    class Laptop
    {
       private int harga = 15000000;
        public void hargaLaptop()
        {
            Console.WriteLine(harga);
        }
        private void privateMethod()
        {
            Console.WriteLine("Private Method");
        }
        public void publicMethod()
        {
            Console.WriteLine("Public Method");

        }
    }

    }
}

