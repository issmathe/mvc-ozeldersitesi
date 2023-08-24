using Microsoft.EntityFrameworkCore;
using Proje.Models;
using Proje.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Repositories
{
    public class OgretmenRepository : IOgretmenRepository
    {
        private readonly UygulamaDbContext _context;

        public OgretmenRepository(UygulamaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ogretmen> GetAllOgretmenler()
        {
            return _context.Ogretmenler.ToList();
        }

        public Ogretmen GetOgretmenById(int id)
        {
            return _context.Ogretmenler.FirstOrDefault(o => o.Id == id);
        }

        public void AddOgretmen(Ogretmen ogretmen)
        {
            _context.Ogretmenler.Add(ogretmen);
            _context.SaveChanges();
        }

        public IEnumerable<Ogretmen> GetOgretmenlerByDersVeSehir(string ders, string sehir)
        {
            return _context.Ogretmenler
                .Where(o => o.Bransi == ders && o.Sehir == sehir)
                .ToList();
        }

        // OgretmenRepository.cs

        public void DeleteOgretmen(Ogretmen ogretmen)
        {
            _context.Ogretmenler.Remove(ogretmen);
            _context.SaveChanges();
        }

        public void UpdateOgretmen(Ogretmen ogretmen)
        {
            _context.Ogretmenler.Update(ogretmen);
            _context.SaveChanges();
        }

    }
}
