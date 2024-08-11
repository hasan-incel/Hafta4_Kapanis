using static Hafta4_Kapanis.BaseMakine;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan veri alıp işlem yapmaya devam etme durumunu kontrol eden döngü.
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basınız:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();
                Console.Write("\nSeri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();
                Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisans = Console.ReadLine().ToLower() == "evet";

                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();
                Console.Write("\nSeri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();
                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";

                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
                continue;
            }

            // Kullanıcıya başka bir ürün üretmek isteyip istemediğini sorar.
            Console.Write("Başka bir ürün üretmek ister misiniz? (Evet/Hayır): ");
            string devam = Console.ReadLine().ToLower();
            if (devam.ToLower() != "evet")
            {
                Console.WriteLine("\nUygulama sonlandırılıyor!");
                break;
            }
        }
    }
}