using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Proje.Models;
using Proje.Repositories;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Proje.Utility;

namespace Proje.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly IOgretmenRepository _ogretmenRepository;  
        private readonly IWebHostEnvironment _webHostEnvironment; //fotoğraflar için

        public OgretmenController(IOgretmenRepository ogretmenRepository, IWebHostEnvironment webHostEnvironment)
        {
            _ogretmenRepository = ogretmenRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult TumOgretmenler()
        {
            List<Ogretmen> objOgretmenList = _ogretmenRepository.GetAllOgretmenler().ToList();
            return View(objOgretmenList);
        }

        public IActionResult OgretmenEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgretmenEkle(Ogretmen ogretmen, IFormFile? file)
        {
            if (file != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName); // Dosya adı uzantısız
                string extension = Path.GetExtension(file.FileName); // Dosya uzantısı

                // Benzersiz bir dosya adı oluşturmak için GUID kullandım
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + fileName + extension;

                string resimPath = Path.Combine(wwwRootPath, "img", uniqueFileName);

                using (var fileStream = new FileStream(resimPath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                ogretmen.ResimUrl = @"\img\" + uniqueFileName;
            }

            _ogretmenRepository.AddOgretmen(ogretmen);

            return View("OgretmenEkleSonuc", ogretmen);
        }


        public IActionResult OgretmenBul(string ders, string sehir)
        {
            if (string.IsNullOrEmpty(ders) || string.IsNullOrEmpty(sehir))
            {
                return View("Hata");
            }

            var ogretmenler = _ogretmenRepository.GetOgretmenlerByDersVeSehir(ders, sehir);

            return View("ArananOgretmen", ogretmenler);
        }

        public IActionResult DuzenleOgretmen(int id)
        {
            // İlgili öğretmeni veritabanından alma kısmı
            var ogretmen = _ogretmenRepository.GetOgretmenById(id);

            if (ogretmen == null)
            {
                return NotFound(); //  404 hatası g
            }

            return View(ogretmen); // Öğretmen düzenleme sayfası
        }
        [HttpPost]
        public IActionResult KaydetDuzenle(Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // İlgili öğretmenin mevcut verilerini güncelle
                    _ogretmenRepository.AddOgretmen(ogretmen);

                    return RedirectToAction("TumOgretmenler"); // Başarılı güncelleme sonrası tüm öğretmenlerin listelendiği sayfaya yönlendirme
                }
                catch (Exception ex)
                {
                    // hata durumunda bilgilendirme
                    ModelState.AddModelError(string.Empty, "Öğretmen güncellenirken bir hata oluştu.");
                    // Hata durumunda nereye gidileceği kısım
                    return View("DuzenleOgretmen", ogretmen);
                }
            }
            return View("DuzenleOgretmen", ogretmen);
        }


        [HttpPost]
        public IActionResult Sil(int ogretmenId)
        {
            try
            {
                // Öğretmeni veritabanından aldık
                var ogretmen = _ogretmenRepository.GetOgretmenById(ogretmenId);
                if (ogretmen == null)
                {
                    return NotFound(); //404 hatası göster
                }

                //varsa  Öğretmeni sil
                _ogretmenRepository.DeleteOgretmen(ogretmen);

                // başarı durumund nereye gideceği
                return RedirectToAction("TumOgretmenler");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Öğretmen silinirken bir hata oluştu.");

                return RedirectToAction("DuzenleOgretmen", new { id = ogretmenId });
            }
        }

    }
}
