using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace virtusl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, carpim = 1;
            string sonuc = "";
            Console.WriteLine("sayı giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
            while(sayi>0)
            {
                carpim *= sayi;
                if (sayi != 1)
                    sonuc += $"{sayi} X ";
                else
                    sonuc += $"{sayi} = {carpim}";

                sayi--;
            }
            Console.WriteLine("sayının faktöriyeli" + sonuc);




            Console.WriteLine("sayı gir:");
            int sayii = Convert.ToInt32(Console.ReadLine());
            int carpimm = 1;
           
            for (int i=sayii; i>0; i--)
            {
                carpimm *=i;
                
            }
            Console.WriteLine(carpimm);

            Console.Read();


        }
    }
}






