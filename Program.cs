Console.WriteLine("Gidebileceginiz tatil lokasyonlar uzerinden hesaplama yapilacaktir.\nMarmaris(3000TL) mi Bodrum (4000TL) mu yoksa Cesme(5000TL) mi?");
string lokasyon = Console.ReadLine();
while (lokasyon == "")
{
    Console.WriteLine("Lutfen gitmet istediginiz lokasyonu giriniz.\n Marmaris(3000TL) mi Bodrum (4000TL) mu yoksa Cesme(5000TL) mi?");
    switch (lokasyon)
    {
        case "marmaris":
            break;
        case "bodrum":
            break;
        case ("cesme"):
            break;
        default:
            break;
    }
}
Console.WriteLine("Bu tatili kac kisi yapacaksiniz?");
int sonucKisiSayisi = 0;
int kisi = Convert.ToInt32(Console.ReadLine());
while (kisi <= 0) ;
{
    if (lokasyon == "marmaris")
    {
        sonucKisiSayisi = kisi * 3000;
    }
    else if (lokasyon == "bodrum")
    {
        sonucKisiSayisi = kisi * 4000;
    }
    else if (lokasyon == "cesme")
    {
        sonucKisiSayisi = kisi * 5000;
    }
}
       
if (lokasyon != "")
{
    switch (lokasyon)
    {
        case "marmaris":
            Console.WriteLine("Marmaris guzeldir.");
            break;
        case "bodrum":
            Console.WriteLine("Bodrum guzeldir.");
            break;
        case ("cesme"):
            Console.WriteLine("Marmaris guzeldir.");
            break;
        default:
            break;
    }
}

Console.WriteLine("Nasil gideceksiniz? \n Hava yolu icin 2, Kara yolu icin 1 giriniz.");
int ulasimSekli = Convert.ToInt32(Console.ReadLine());
if(ulasimSekli==2)
{
    Console.WriteLine("Toplam tutar={0}", sonucKisiSayisi+(kisi*4000));
}
else if(ulasimSekli==1)
{
    Console.WriteLine("Toplam tutar={0}", sonucKisiSayisi+(kisi*1500));
}



      