namespace Alım_Satım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] barkod = new int[100];
            string[] ad = new string[100];
            double[] fiyat = new double[100];
            int[] stok = new int[100];

            // pm başlangıç ürün miktarı p ürün stok artış miktarı
            int pm = 0;
            int p = 1;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İşlem Menüsüne Hoşgeldiniz");
                Console.WriteLine();
                Console.WriteLine("Ürün Eklemek İçin 1");
                Console.WriteLine("Ürün Alımı İçin 2");
                Console.WriteLine("Ürün Satışı İçin 3");
                Console.WriteLine("Ürün Listesi İçin 4");
                Console.WriteLine("Çıkış için 5");
                Console.WriteLine();
                

                string sec = Console.ReadLine();

                if (sec == "1")
                {
                    Console.Write("Ürün ismi: ");
                    ad[pm] = Console.ReadLine();
                    Console.Write("Ürün fiyatı: ");
                    fiyat[pm] = double.Parse(Console.ReadLine());
                    Console.Write("Stok miktarı: ");
                    stok[pm] = int.Parse(Console.ReadLine());
                    barkod[pm] = p++;
                    pm++;

                    Console.WriteLine("Ürün Eklendi!");
                }
                else if (sec == "2")
                {
                    Console.WriteLine("\n**** Ürün Listesi ****");
                    for (int i = 0; i < pm; i++)
                    {
                        Console.WriteLine($"Barkod: {barkod[i]}, İsim: {ad[i]}, Fiyat: ,{fiyat[i]:C}, Stok: {stok[i]}");
                    }

                    Console.Write("Almak istediğiniz ürün barkodunu girin: ");
                    Console.WriteLine();
                    int albarkod= int.Parse(Console.ReadLine());
                    Console.Write("Kaç adet almak istiyorsunuz? ");
                    int alAdet = int.Parse(Console.ReadLine());

                    for (int i = 0; i < pm; i++)
                    {
                        if (barkod[i] == albarkod)
                        {
                            stok[i] += alAdet;
                            Console.WriteLine($"{alAdet} adet {ad[i]} başarıyla alındı. Yeni stok: {ad[i]}");
                            break;
                        }
                    }
                }
                else if (sec == "3")
                {
                    Console.WriteLine("\n**** Ürün Listesi ****");
                    for (int i = 0; i < pm; i++)
                    {
                        Console.WriteLine($"Barkod: {barkod[i]}, İsim: {ad[i]}, Fiyat: {fiyat[i]:C}, Stok: {stok[i]}");
                    }

                    Console.Write("Satmak istediğiniz ürün barkodunu girin: ");
                    int satbarkod= int.Parse(Console.ReadLine());
                    Console.Write("Kaç adet satmak istiyorsunuz? ");
                    int satilanAdet = int.Parse(Console.ReadLine());

                    for (int i = 0; i < pm; i++)
                    {
                        if (barkod[i] == satbarkod)
                        {
                            if (stok[i] >= satilanAdet)
                            {
                                stok[i] -= satilanAdet;
                                double toplamKazanc = satbarkod * fiyat[i];
                                Console.WriteLine($"{satilanAdet} adet {ad[i]} başarıyla satıldı. Toplam kazanç: {toplamKazanc:C}. Yeni stok: {stok[i]}");
                            }
                            else
                            {
                                Console.WriteLine("Yeterli stok yok!");

                            }

                            break;

                        }
                    }
                }
                else if (sec == "4")
                {
                    Console.WriteLine("\n****Ürün Listesi ****");
                    for (int i = 0; i < pm; i++)
                    {
                        Console.WriteLine($"Barkod: {barkod[i]}, İsim: {ad[i]}, Fiyat: {fiyat[i]:C}, Stok: {stok[i]}");
                    }
                }
               
               
               
                else if (sec == "5")
                {
                    Console.WriteLine("****Programdan çıkılıyor****");
                    break;
                }
                
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }
            }
        }
    }
}
               
