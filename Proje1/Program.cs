using System.Net;

Console.WriteLine("X Bankasi \nKartli İslem İcin 1'e, Kartsiz İslem İcin 2'ye basiniz.");

int SECİM = Convert.ToInt32(Console.ReadLine());
int BAKİYE = 25000;


if (SECİM == 1)
{
    string SİFRE;

    SİFRE = "ab18";
    
    Console.WriteLine("Kartli İslem Bölümü \nSifreyi Giriniz: ");
    string GirilenSifre = Console.ReadLine();


    if (SİFRE != GirilenSifre)
    {

        for (int i = 0; i < 3; i++)
        {
            if (SİFRE != GirilenSifre)

            {
             
                Console.WriteLine("Kartli İslem Bölümü \nSifreyi Giriniz: ");
                string GirilenSifre1 = Console.ReadLine();

                GirilenSifre = GirilenSifre1;
                
            }
            else if (SİFRE == GirilenSifre)
            {
                goto ANAMENÜ;
            }
        }
        Environment.Exit(0);
    }
    
    else if (SİFRE == GirilenSifre)
    {
        goto ANAMENÜ;
    }

    else
    {
        Environment.Exit(0);
    }

    ANAMENÜ:
        Console.WriteLine("ANA MENÜ \n Para Cekmek İcin 1 \n " +
            "Para Yatirmak İcin 2 \n Para Transferleri İcin 3 \n" +
            "Eğitim Ödemeleri İcin 4 \n Ödemeler İcin 5 \n " +
            "Bilgi Güncelleme İcin 6 ");

        int Secim = Convert.ToInt32(Console.ReadLine());

        if (Secim == 1)
        {

            Console.WriteLine("Cekmek İstediğiniz Tutari Ekrana Giriniz.:");

            int CekilecekPara = Convert.ToInt32(Console.ReadLine());

            if (0 < CekilecekPara && CekilecekPara <= BAKİYE)
            {

                Console.WriteLine("Paranizi Aliniz. \n");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
            else if (BAKİYE < CekilecekPara)
            {
                Console.WriteLine("Yetersiz Bakiye \n");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }

        }
        else if (Secim == 2)
        {
            Console.WriteLine("Kredi Kartina Yatirmak İcin 1'e, Kendi Hesabiniza" +
                " Yatirmak İcin 2'ye Basin.: ");

            int Tercih = Convert.ToInt32(Console.ReadLine());

            if (1 == Tercih)
            {
                Console.WriteLine("En Az 12 Haneli Kart Numarasi Girin..\n ");
                string KartNO = Console.ReadLine();
                int uzunluk = KartNO.Length;

                if (12 == uzunluk)
                {
                    Console.WriteLine("Kredi Kartina Yatirmak İstediğiniz Tutari Girin..\n ");
                    int YatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                    if (0 < YatirilacakTutar && YatirilacakTutar <= BAKİYE)
                    {

                        Console.WriteLine("Para Kredi Kartina Yatirildi.\n ");
                        Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                        int Karar = Convert.ToInt32(Console.ReadLine());

                        if (Karar == 9)
                        {
                            goto ANAMENÜ;
                        }
                        else if (Karar == 0)
                        {


                        }
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye.\n ");
                    }
                }
                else
                {
                    Console.WriteLine("Kart Numarasını Eksik veya Hatali Tusladiniz.\n ");
                }
            }

            if (2 == Tercih)
            {
                Console.WriteLine("Hesaba Yatirirmak İstediğiniz Tutari Girin.\n ");
                int YatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(YatirilacakTutar + " Kendi Hesabiniza Yatirildi.\n ");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }

        }
        else if (Secim == 3)
        {
            Console.WriteLine("Baska Hesaba EFT İcin 1'e " +
               " Baska Hesaba Havale İcin 2'ye Basin. : ");

            int Tercih = Convert.ToInt32(Console.ReadLine());

            if (1 == Tercih)
            {
                Console.WriteLine("EFT Numarasini Basinda TR olup 14 Hane Olacak Sekilde Girin. ");
                string EFTNo = Console.ReadLine();

                int Uzunluk = EFTNo.Substring(2).Length;

                if (EFTNo.StartsWith("TR") && (12 == Uzunluk))
                {

                    Console.WriteLine("Yatirilacak Tutari Giriniz.");
                    int YatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(YatirilacakTutar + " EFT Gerceklesti.");

                }
                else
                {
                    Console.WriteLine("Hatali Tuslama Yaptiniz.");
                    Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                    int Karar = Convert.ToInt32(Console.ReadLine());

                    if (Karar == 9)
                    {
                        goto ANAMENÜ;
                    }
                    else if (Karar == 0)
                    {


                    }
                }

            }
            else if (2 == Tercih)
            {
             Console.WriteLine("11 Haneli Hesap Numarasin Girin");
             string HesapNo = Console.ReadLine();

            if(11 == HesapNo.Length)
            {
             Console.WriteLine("Gönderilecek Para Tutarini Girin:");
             int GönderilecekTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GönderilecekTutar + " TL Tutarinda Havale Gerçekleşti");
            }
            else
            {
                Console.WriteLine("Hatali Tuslama Yaptiniz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
        }

        }

        else if (Secim == 4)

        {
        Console.WriteLine("Eğitim Ödemeleri İslemleri Arizalidir. İsleminizi Gerceklestiremiyoruz.");
        Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
        int Karar = Convert.ToInt32(Console.ReadLine());

        if (Karar == 9)
        {
            goto ANAMENÜ;
        }
        else if (Karar == 0)
        {


        }


    }
        else if (Secim == 5)
        {
         Console.WriteLine(" Elektrik Faturasi İcin 1 \n " +
            "Telefon Faturasi İcin 2 \n İnternet Faturasi İcin 3 \n" +
            "Su Faturasi İcin 4 \n OGS Ödemeler İcin 5 \n " );
         int Tercih = Convert.ToInt32(Console.ReadLine());

        if (1 == Tercih)
        {
            Console.WriteLine("Fatura Tutarini Girin");
            int Fatura = Convert.ToInt32(Console.ReadLine());

            if(Fatura <= BAKİYE)
            {
                BAKİYE -= Fatura;
                Console.WriteLine("Faturaniz Ödendi. Yeni Bakiyeniz :" + BAKİYE);
            }
            else
            {
                Console.WriteLine("Bu İslem İcin Bakiyeniz Yetersiz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }

        }

        else if(2 == Tercih)
        {
            Console.WriteLine("Fatura Tutarini Girin");
            int Fatura = Convert.ToInt32(Console.ReadLine());

            if (Fatura <= BAKİYE)
            {
                BAKİYE -= Fatura;
                Console.WriteLine("Faturaniz Ödendi. Yeni Bakiyeniz :" + BAKİYE);
            }
            else
            {
                Console.WriteLine("Bu İslem İcin Bakiyeniz Yetersiz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
        }

        else if (3 == Tercih)
        {
            Console.WriteLine("Fatura Tutarini Girin");
            int Fatura = Convert.ToInt32(Console.ReadLine());

            if (Fatura <= BAKİYE)
            {
                BAKİYE -= Fatura;
                Console.WriteLine("Faturaniz Ödendi. Yeni Bakiyeniz :" + BAKİYE);
            }
            else
            {
                Console.WriteLine("Bu İslem İcin Bakiyeniz Yetersiz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
        }
        else if (4 == Tercih)
        {
            Console.WriteLine("Fatura Tutarini Girin");
            int Fatura = Convert.ToInt32(Console.ReadLine());

            if (Fatura <= BAKİYE)
            {
                BAKİYE -= Fatura;
                Console.WriteLine("Faturaniz Ödendi. Yeni Bakiyeniz :" + BAKİYE);
            }
            else
            {
                Console.WriteLine("Bu İslem İcin Bakiyeniz Yetersiz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
        }
        else if (5 == Tercih)
        {
            Console.WriteLine("Fatura Tutarini Girin");
            int Fatura = Convert.ToInt32(Console.ReadLine());

            if (Fatura <= BAKİYE)
            {
                BAKİYE -= Fatura;
                Console.WriteLine("Faturaniz Ödendi. Yeni Bakiyeniz :" + BAKİYE);
            }
            else
            {
                Console.WriteLine("Bu İslem İcin Bakiyeniz Yetersiz.");
                Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
                int Karar = Convert.ToInt32(Console.ReadLine());

                if (Karar == 9)
                {
                    goto ANAMENÜ;
                }
                else if (Karar == 0)
                {


                }
            }
        }

    }
        
    
    
    
        else if (Secim == 6)
    {

        Console.WriteLine("Sifre Degistirmek İcin 1'e Basin.");
        int Tercih = Convert.ToInt32(Console.ReadLine());

        if(1==Tercih)
        {
            Console.WriteLine("Yeni Sifreyi Girin.");
            string YeniSifre = Console.ReadLine();

            SİFRE = YeniSifre;

            Console.WriteLine("Yeni Sifreniz: " + SİFRE);

            Console.WriteLine("Ana Menüye Dönmek İcin 9, Cikmak İcin 0'a Basin.\n");
            int Karar = Convert.ToInt32(Console.ReadLine());

            if (Karar == 9)
            {
                goto ANAMENÜ;
            }
            else if (Karar == 0)
            {


            }
        }

    }
}


