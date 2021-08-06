using System;

namespace eNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Sunday);
            Console.WriteLine((int)Gunler.Saturday);

            int sicaklik = 32;
            if(sicaklik<=(int)HavaDurumu.Normal){
                Console.WriteLine("Dışarı çıkmak için biraz daha ısınmasını bekleyelim.");
            }
            else if  (sicaklik>=(int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            
        }
    }//clas Program end

    enum Gunler{
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday=23,
        Saturday,
        Sunday

    }
    enum HavaDurumu{
        Soguk = 5,
        Normal =20,
        Sicak=25,
        CokSicak=35,

    }
}
