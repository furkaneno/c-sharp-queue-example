using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_kuyruk_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // queue yapısında fifo mantığı vardır ilk giren ilk çıkar

           // Enqueue(T)  Kuyruğa bir öğe ekler.
           // Dequeue Kuyruğun başındakini döndürür ve onu kuyruktan kaldırır.
           // Peek(T) Kuyruktan ilk öğeyi kaldırmadan döndürür.
           // Contains(T) Bir öğenin kuyrukta olup olmadığını kontrol eder
           // Clear() Queue içindeki tüm öğeleri siler.

            Queue<string> isimler = new Queue<string>();

            isimler.Enqueue("furkan");
            isimler.Enqueue("conor");
            isimler.Enqueue("eno");

            foreach(var s in isimler)
            {
                Console.WriteLine(s); // furkan,conor,eno
            }


            Console.WriteLine("---------");

            // dequeue 

            Queue<string> kelime = new Queue<string>();

            kelime.Enqueue("M");
            kelime.Enqueue("e");
            kelime.Enqueue("r");
            kelime.Enqueue("h");
            kelime.Enqueue("a");
            kelime.Enqueue("b");
            kelime.Enqueue("a");

            Console.WriteLine("kelime sayisi = {0}",kelime.Count);

            while(kelime.Count > 0)
            {
                Console.Write(kelime.Dequeue()); // merhaba
            }
            Console.WriteLine("\ntoplam kelime sayisi {0}",kelime.Count());

            Console.WriteLine("---------");


            /// peek

            Queue<string> mesaj = new Queue<string>();

            mesaj.Enqueue("M");
            mesaj.Enqueue("e");
            mesaj.Enqueue("r");
            mesaj.Enqueue("h");
            mesaj.Enqueue("a");
            mesaj.Enqueue("b");
            mesaj.Enqueue("a");

            Console.WriteLine("Toplam: {0}", mesaj.Count); //çıktı 7

            if (mesaj.Count > 0)
            {
                Console.WriteLine(mesaj.Peek()); //çıktı m
            }

            Console.WriteLine("Toplam: {0}", mesaj.Count); // çıktı 7

            Console.ReadKey();


        }
    }
}
