using System;

namespace VizeFinalOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 ) kullanıcında vize ve final notları istenecek. alınan vize ve finalden ortalama hesaplanacak. Vizenin 0.4'ü finalin 0.6'sı.ve ortalması 100 ile 80 arasında ise AA, 80 ve 70 arasında ise BA diğer değer aralıklarını belirleyerek ekrana harf notunu gösteren mesajı veren prog. yazınız..

            int vize, final, ortalama;

            Console.WriteLine("Vize notunuzu giriniz..");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuzu giriniz..");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = ((vize * 40) / 100) + ((final * 60) / 100);

            if (vize <= 100 && vize > 0 && final <= 100 && final > 0)
            {

                if (ortalama >= 90 && ortalama <= 100)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = AA");
                }

                else if (ortalama >= 80 && ortalama < 90)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = BA");
                }

                else if (ortalama >= 65 && ortalama < 79)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = BB ");
                }

                else if (ortalama >= 55 && ortalama < 64)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = CB");
                }

                else if (ortalama >= 50 && ortalama < 55)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = CC");
                }

                else if (ortalama >= 40 && ortalama < 50)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = DC");
                }

                else if (ortalama >= 35 && ortalama < 40)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = DD");
                }

                else if (ortalama >= 25 && ortalama < 35)
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = FD");
                }

                else
                {
                    Console.WriteLine($"Vize {vize} ve Final {final} ortalaması = {ortalama} 'dır. Harf Notunuz = FF");
                }

            }

            else
            {
                Console.WriteLine("Lütfen 0 ile 100 arası değer giriniz..");
            }

            Console.ReadKey();
        }
    }
}
