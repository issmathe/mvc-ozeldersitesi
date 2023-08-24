using Proje.Models;
using System.Collections.Generic;

namespace Proje.Repositories
{
    public interface IOgretmenRepository
    {
        IEnumerable<Ogretmen> GetAllOgretmenler();
        Ogretmen GetOgretmenById(int id);
        void AddOgretmen(Ogretmen ogretmen);
        IEnumerable<Ogretmen> GetOgretmenlerByDersVeSehir(string ders, string sehir);
        void DeleteOgretmen(Ogretmen ogretmen);
    }
}
