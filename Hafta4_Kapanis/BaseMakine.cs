using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Kapanis
{
    // Base Class: Tüm makineler için ortak özellikleri ve metotları tanımlar.
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // BaseMakine constructor'ı, üretim tarihini otomatik olarak şu anki tarih olarak atar.
        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        // Ortak bilgileri yazdıran metot.
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("\nÜretim Tarihi: " + UretimTarihi);
            Console.WriteLine("Seri Numarası: " + SeriNumarasi);
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Açıklama: " + Aciklama);
            Console.WriteLine("İşletim Sistemi: " + IsletimSistemi);
        }

        public abstract void UrunAdiGetir();

        // Telefon sınıfı: BaseMakine'den türetilir ve telefonlara özgü özellikleri içerir.
        public class Telefon : BaseMakine
        {
            public bool TrLisans { get; set; }

            // Bilgileri yazdırma metodu, base sınıfın metotlarını kullanır ve kendi özelliklerini ekler.
            public override void BilgileriYazdir()
            {
                base.BilgileriYazdir();
                Console.WriteLine("TR Lisanslı: " + TrLisans);
            }

            public override void UrunAdiGetir()
            {
                Console.WriteLine("Telefonunuzun adı ---> " + Ad);// Override ederek telefonun adını yazdırıyor.
            }
        }

        // Bilgisayar sınıfı: BaseMakine'den türetilir ve bilgisayarlara özgü özellikleri içerir.
        public class Bilgisayar : BaseMakine
        {
            private int usbGirisSayisi;
            public int UsbGirisSayisi
            {
                get { return usbGirisSayisi; }
                set
                {
                    if (value == 2 || value == 4) //If Else ile 2 veya 4 sayısının konsola girilmesini istiyoruz. Başka sayı girilirse değer -1 olarak atanacak.
                    {
                        usbGirisSayisi = value;
                    }
                    else
                    {
                        Console.WriteLine("Hata! Giriş sayısı 2 veya 4 olmalıdır. Varsayılan olarak -1 değeri atandı.");
                        usbGirisSayisi = -1;
                    }
                }
            }

            public bool Bluetooth { get; set; }

            public override void BilgileriYazdir()
            {
                base.BilgileriYazdir();
                Console.WriteLine("USB Giriş Sayısı: " + UsbGirisSayisi);
                Console.WriteLine("Bluetooth: " + Bluetooth);
            }

            public override void UrunAdiGetir()
            {
                Console.WriteLine("Bilgisayarınızın adı ---> " + Ad); // Override ederek bilgisayarın adını yazdırıyor.
            }
        }
    }
}


