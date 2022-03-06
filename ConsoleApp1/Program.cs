using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Harf> list = new List<Harf>();
            list.Add(new Harf
            {
                Harfid = 0,
                Harfad = "A"
            });
            list.Add(new Harf
            {
                Harfid = 1,
                Harfad = "B"
            });
            list.Add(new Harf
            {
                Harfid = 2,
                Harfad = "C"
            });
            list.Add(new Harf
            {
                Harfid = 3,
                Harfad = "Ç"
            });
            list.Add(new Harf
            {
                Harfid = 4,
                Harfad = "D"
            });
            list.Add(new Harf
            {
                Harfid = 5,
                Harfad = "E"
            });
            list.Add(new Harf
            {
                Harfid = 6,
                Harfad = "F"
            });
            list.Add(new Harf
            {
                Harfid = 7,
                Harfad = "G"
            });
            list.Add(new Harf
            {
                Harfid = 8,
                Harfad = "Ğ"
            });
            list.Add(new Harf
            {
                Harfid = 9,
                Harfad = "H"
            });
            list.Add(new Harf
            {
                Harfid = 10,
                Harfad = "I"
            });
            list.Add(new Harf
            {
                Harfid = 11,
                Harfad = "İ"
            });
            list.Add(new Harf
            {
                Harfid = 12,
                Harfad = "J"
            });
            list.Add(new Harf
            {
                Harfid = 13,
                Harfad = "K"
            });
            list.Add(new Harf
            {
                Harfid = 14,
                Harfad = "L"
            });
            list.Add(new Harf
            {
                Harfid = 15,
                Harfad = "M"
            });
            list.Add(new Harf
            {
                Harfid = 16,
                Harfad = "N"
            });
            list.Add(new Harf
            {
                Harfid = 17,
                Harfad = "O"
            });
            list.Add(new Harf
            {
                Harfid = 18,
                Harfad = "Ö"
            });
            list.Add(new Harf
            {
                Harfid = 19,
                Harfad = "P"
            });
            list.Add(new Harf
            {
                Harfid = 20,
                Harfad = "R"
            });
            list.Add(new Harf
            {
                Harfid = 21,
                Harfad = "S"
            });
            list.Add(new Harf
            {
                Harfid = 22,
                Harfad = "Ş"
            });
            list.Add(new Harf
            {
                Harfid = 23,
                Harfad = "T"
            });
            list.Add(new Harf
            {
                Harfid = 24,
                Harfad = "U"
            });
            list.Add(new Harf
            {
                Harfid = 25,
                Harfad = "Ü"
            });
            list.Add(new Harf
            {
                Harfid = 26,
                Harfad = "V"
            });
            list.Add(new Harf
            {
                Harfid = 27,
                Harfad = "Y"
            });
            list.Add(new Harf
            {
                Harfid = 28,
                Harfad = "Z"
            });
            int durum = 0;
            Console.WriteLine("Lütfen artış miktarını giriniz");
            durum = Convert.ToInt16(Console.ReadLine());
            string kelime;
            Console.WriteLine("Lutfen kelime giriniz");
            kelime = Console.ReadLine();
            kelime = kelime.ToUpper();
            char[] karakterler = kelime.ToCharArray();
            int a = 0;
            List<int> sayi = new List<int>();
            List<string> harfler = new List<string>();
            int selamlar = 0;
            foreach (var eleman in karakterler)
            {
                foreach (var x in list)
                {
                    if (x.Harfad.Contains(karakterler[a]))
                    {
                        if ((x.Harfid + durum) <= 28)
                        {
                            sayi.Add(x.Harfid + durum);
                        }
                        else
                        {
                            selamlar = (x.Harfid + durum) % 29;
                            sayi.Add(selamlar);
                        }
                    }
                }
                a++;
            }
            int b = 0;
            foreach (var y in sayi)
            {
                foreach (var x in list)
                {
                    if (x.Harfid == sayi[b])
                    {
                        harfler.Add(x.Harfad);
                    }
                }
                b++;
            }
            Console.Write("Kaydırmalı şifrelenmiş hali = ");
            foreach (var z in harfler)
            {
                Console.Write(Convert.ToChar(z).ToString());
            }
            int c = 0;
            int olacak = 0;
            Console.WriteLine("");
            Console.Write("Çözülmüş Hali = ");
            int hamsayi = 0;
            foreach (var elemanlar in sayi)
            {
                olacak = sayi[c] - durum;
                hamsayi = Mod(olacak, 29);
                foreach (var x in list)
                {
                    if (x.Harfid == hamsayi)
                    {
                        Console.Write(x.Harfad);
                    }
                }
                c++;
            }
            int Mod(int modalinacaksayi, int boluneceksayi)
            {

                while (modalinacaksayi > boluneceksayi)
                {
                    modalinacaksayi = modalinacaksayi - boluneceksayi;
                }
                while (modalinacaksayi < 0)
                {
                    modalinacaksayi = modalinacaksayi + boluneceksayi;
                }
                return modalinacaksayi;
            }
        }
    }
}