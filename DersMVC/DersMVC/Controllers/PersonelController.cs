using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Security.Cryptography.X509Certificates;

namespace DersMVC.Controllers
{
    public class PersonelController : Controller
    {

        private readonly IPersonelService personelservice;

        public PersonelController(IPersonelService personelservice)
        {
            this.personelservice = personelservice;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = personelservice.GetAll();
            return View(result);
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Personel pers)
        {
            var result = personelservice.PersonelEkle(pers);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Personel pers)
        {
            var result = personelservice.PersonelSil(pers);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Personel pers)
        {
            var result = personelservice.PersonelGuncelle(pers);
            return View(result);
        }
        
    }
}
