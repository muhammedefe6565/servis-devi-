
using System.ComponentModel.Design;

List<string> ogrenciliste = new List<string>();

ogrenciliste.Add("ahmet");
ogrenciliste.Add("mehmet");

Console.WriteLine("servisi kullanacak öğrenciler");
int ogrencisayisi = 0;

while (true)
{

    int karar = 0;
    karar = Convert.ToInt32(Console.ReadLine());
    if (karar == 1)
    {
        ogrenciliste.Add(Convert.ToString(Console.ReadLine()));
        ogrencisayisi++;

    }
    else if (karar == 2)
    {
        Console.WriteLine("toplam öğrenci sayısı" + ogrencisayisi);
    }
    else
    {
        Console.WriteLine("geçersiz işlem girdiniz");
    }
    Console.WriteLine("aracın kapasitesi kaç kişilik?");
    int kapasite = Convert.ToInt32(Console.ReadLine());
    if (ogrencisayisi <= kapasite)
    {
        Console.WriteLine("öğrenciler araca yerleşebiliyorlar");
    }
    else
    {
        Console.WriteLine("öğrenci sayısı kapasiteyi aşıyor.");
    }
}  
