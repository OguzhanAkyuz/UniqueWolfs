using System;

namespace RandomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int diziBoyutu = 5 + new Random().Next(2 * 10^5);

            int[] dizi = new int[diziBoyutu];
            for (int i = 0; i < diziBoyutu; i++)
            {
                dizi[i] = 1 + new Random().Next(5);
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();

            int enCokTespitEdilenID = enCokTespitEdilenEnDusukID(dizi);

            Console.WriteLine("\nEn çok tekrar eden en düşük değer: " + enCokTespitEdilenID);
        }

        private static int enCokTespitEdilenEnDusukID(int[] dizi)
        {
            int enCokTespitSayisi = 0;
            int enCokTespitEdilenID = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        sayi++;
                    }
                }

                if (sayi > enCokTespitSayisi)
                {
                    enCokTespitSayisi = sayi;
                    enCokTespitEdilenID = dizi[i];
                }
                else if (sayi == enCokTespitSayisi && dizi[i] < enCokTespitEdilenID)
                {
                    enCokTespitEdilenID = dizi[i];
                }
            }

            return enCokTespitEdilenID;
        }
    }
}
