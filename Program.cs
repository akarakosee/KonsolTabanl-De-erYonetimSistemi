using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace udemycsharpodev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanıcısecim = string.Empty;
            ArrayList degerlistesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("1-Değer Ekle");
                Console.WriteLine("2-Değer Listele");
                Console.WriteLine("3-Değer Ara");
                Console.WriteLine("4-Değer Düzenle");
                Console.WriteLine("5-Çıkış");
                Console.Write("Seçiniz: ");
                kullanıcısecim = Console.ReadLine();
                switch (kullanıcısecim)
                {
                    case "1":
                        Console.Write("Lütfen Eklemek İstediğiniz Değeri Giriniz: ");
                        string kullanicideger = Console.ReadLine();
                        degerlistesi.Add(kullanicideger);
                        Console.WriteLine("Değeriniz Başarılı Bir Şekilde Eklendi.");
                        Console.WriteLine("----------------------------");
                        break;

                    case "2":
                        for (int i = 0; i < degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0} .Değer = {1}", i, degerlistesi[i]);
                        }
                        Console.WriteLine("Devam Etmek İçin Bir Tuşa Basınız.");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Aramak İstediğiniz Değeri Giriniz: ");
                        string kullaniciaramadeger = Console.ReadLine();
                        bool kontrol = degerlistesi.Contains(kullaniciaramadeger);
                        if (kontrol)
                        {
                            int bulunanindex = degerlistesi.IndexOf(kullaniciaramadeger);
                            string bulunandeger = degerlistesi[bulunanindex].ToString();
                            Console.WriteLine("Değeriniz Bulundu : index sırası :{0} - Değer : {1}", bulunanindex, bulunandeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Kriterlerde Bir Değer Bulunamadı.");
                        }
                        break;

                    case "4":
                        Console.Write("Güncellemek İstediğiniz Değeri Giriniz : ");
                        string kullaniciduzenlenecekdeger = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("{0} Değerini Hangi Değer İle Güncellemek İstiyorsunuz : ", kullaniciduzenlenecekdeger);
                        string kullaniciyenideger = Console.ReadLine();

                        if (degerlistesi.Contains(kullaniciduzenlenecekdeger))
                        {
                            int kullanicihedefindex = degerlistesi.IndexOf(kullaniciduzenlenecekdeger);
                            degerlistesi[kullanicihedefindex] = kullaniciyenideger;
                            Console.WriteLine("Değeriniz Güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Değer Listede Bulunamadı.");
                        }

                        break;

                    case "5":
                        break;

                    default:
                        break;
                }

            } while (kullanıcısecim != "5");
        }
    }
}
