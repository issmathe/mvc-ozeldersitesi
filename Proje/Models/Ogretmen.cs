using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Ogretmen
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OgretmenAdi { get; set; }
        [Required]
        public string OgretmenSoyadi { get; set; }
        [Required]
        public string Bransi { get; set; }
        [Required]
        public string Universite { get; set; }
        [Required]
        public string Sehir { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Ucret { get; set; }
        [Required]
        public string Aciklama { get; set; }
        [ValidateNever] //doğrulama için kontrol etmeye gerek yok demek 
        public string ResimUrl { get; set; }

    }
    // İller listesi
    public static class Iller
    {
        public static List<string> Liste = new List<string>
    {
        "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Ardahan",
        "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik",
        "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum",
        "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum",
        "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır",
        "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük",
        "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli",
        "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin",
        "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya",
        "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat",
        "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
    };
    }

    // Dersler listesi
    public static class Dersler
    {
        public static List<string> Liste = new List<string>
        {
            "Matematik","Türkçe","İngilizce", "Fizik", "Kimya", "Biyoloji", "Tarih","Coğrafya","Fen Bilgisi",
        };
    }

    public static class Universiteler
    {
        public static List<string> Liste = new List<string>
        {
"Mezun Olduğunuz Üniversiteyi Seçiniz","ABANT İZZET BAYSAL ÜNİVERSİTESİ",
"ABDULLAH GÜL ÜNİVERSİTESİ",
"ACIBADEM MEHMET ALİ AYDINLAR ÜNİVERSİTESİ",
"ADANA BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ",
"ADIYAMAN ÜNİVERSİTESİ",
"ADNAN MENDERES ÜNİVERSİTESİ",
"AFYON KOCATEPE ÜNİVERSİTESİ",
"AĞRI İBRAHİM ÇEÇEN ÜNİVERSİTESİ",
"AHİ EVRAN ÜNİVERSİTESİ",
"AKDENİZ ÜNİVERSİTESİ",
"AKSARAY ÜNİVERSİTESİ",
"ALANYA ALAADDİN KEYKUBAT ÜNİVERSİTESİ",
"ALANYA HAMDULLAH EMİN PAŞA ÜNİVERSİTESİ",
"ALTINBAŞ ÜNİVERSİTESİ",
"AMASYA ÜNİVERSİTESİ",
"ANADOLU ÜNİVERSİTESİ",
"ANKA TEKNOLOJİ ÜNİVERSİTESİ",
"ANKARA MÜZİK VE GÜZEL SANATLAR ÜNİVERSİTESİ",
"ANKARA SOSYAL BİLİMLER ÜNİVERSİTESİ",
"ANKARA ÜNİVERSİTESİ",
"ANKARA YILDIRIM BEYAZIT ÜNİVERSİTESİ",
"ANTALYA AKEV ÜNİVERSİTESİ",
"ANTALYA BİLİM ÜNİVERSİTESİ",
"ARDAHAN ÜNİVERSİTESİ",
"ARTVİN ÇORUH ÜNİVERSİTESİ",
"ATAŞEHİR ADIGÜZEL MESLEK YÜKSEKOKULU",
"ATATÜRK ÜNİVERSİTESİ",
"ATILIM ÜNİVERSİTESİ",
"AVRASYA ÜNİVERSİTESİ",
"AVRUPA MESLEK YÜKSEKOKULU",
"BAHÇEŞEHİR ÜNİVERSİTESİ",
"BALIKESİR ÜNİVERSİTESİ",
"BANDIRMA ONYEDİ EYLÜL ÜNİVERSİTESİ",
"BARTIN ÜNİVERSİTESİ",
"BAŞKENT ÜNİVERSİTESİ",
"BATMAN ÜNİVERSİTESİ",
"BAYBURT ÜNİVERSİTESİ",
"BEYKENT ÜNİVERSİTESİ",
"BEYKOZ ÜNİVERSİTESİ",
"BEZM-İ ÂLEM VAKIF ÜNİVERSİTESİ",
"BİLECİK ŞEYH EDEBALİ ÜNİVERSİTESİ",
"BİNGÖL ÜNİVERSİTESİ",
"BİRUNİ ÜNİVERSİTESİ",
"BİTLİS EREN ÜNİVERSİTESİ",
"BOĞAZİÇİ ÜNİVERSİTESİ",
"BOZOK ÜNİVERSİTESİ",
"BURSA TEKNİK ÜNİVERSİTESİ",
"BÜLENT ECEVİT ÜNİVERSİTESİ",
"CUMHURİYET ÜNİVERSİTESİ",
"ÇAĞ ÜNİVERSİTESİ",
"ÇANAKKALE ONSEKİZ MART ÜNİVERSİTESİ",
"ÇANKAYA ÜNİVERSİTESİ",
"ÇANKIRI KARATEKİN ÜNİVERSİTESİ",
"ÇUKUROVA ÜNİVERSİTESİ",
"DİCLE ÜNİVERSİTESİ",
"DOĞUŞ ÜNİVERSİTESİ",
"DOKUZ EYLÜL ÜNİVERSİTESİ",
"DUMLUPINAR ÜNİVERSİTESİ",
"DÜZCE ÜNİVERSİTESİ",
"EGE ÜNİVERSİTESİ",
"ERCİYES ÜNİVERSİTESİ",
"ERZİNCAN ÜNİVERSİTESİ",
"ERZURUM TEKNİK ÜNİVERSİTESİ",
"ESKİŞEHİR OSMANGAZİ ÜNİVERSİTESİ",
"FARUK SARAÇ TASARIM MESLEK YÜKSEKOKULU",
"FATİH SULTAN MEHMET VAKIF ÜNİVERSİTESİ",
"FENERBAHÇE ÜNİVERSİTESİ",
"FIRAT ÜNİVERSİTESİ",
"GALATASARAY ÜNİVERSİTESİ",
"GAZİ ÜNİVERSİTESİ",
"GAZİANTEP ÜNİVERSİTESİ",
"GAZİOSMANPAŞA ÜNİVERSİTESİ",
"GEBZE TEKNİK ÜNİVERSİTESİ",
"GİRESUN ÜNİVERSİTESİ",
"GÜMÜŞHANE ÜNİVERSİTESİ",
"HACETTEPE ÜNİVERSİTESİ",
"HAKKARİ ÜNİVERSİTESİ",
"HALİÇ ÜNİVERSİTESİ",
"HARRAN ÜNİVERSİTESİ",
"HASAN KALYONCU ÜNİVERSİTESİ",
"HİTİT ÜNİVERSİTESİ",
"IĞDIR ÜNİVERSİTESİ",
"IŞIK ÜNİVERSİTESİ",
"İBN HALDUN ÜNİVERSİTESİ",
"İHSAN DOĞRAMACI BİLKENT ÜNİVERSİTESİ",
"İNÖNÜ ÜNİVERSİTESİ",
"İSKENDERUN TEKNİK ÜNİVERSİTESİ",
"İSTANBUL AREL ÜNİVERSİTESİ",
"İSTANBUL AYDIN ÜNİVERSİTESİ",
"İSTANBUL AYVANSARAY ÜNİVERSİTESİ",
"İSTANBUL BİLGİ ÜNİVERSİTESİ",
"İSTANBUL BİLİM ÜNİVERSİTESİ",
"İSTANBUL ESENYURT ÜNİVERSİTESİ",
"İSTANBUL GEDİK ÜNİVERSİTESİ",
"İSTANBUL GELİŞİM ÜNİVERSİTESİ"
        };
    }



}
