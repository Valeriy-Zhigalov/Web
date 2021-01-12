using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Web.ViewModels;
using System.IO;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private ApplicationDBContext db;
        public HomeController(ApplicationDBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> ListOrders()
        {
            return View(await db.Orders.ToListAsync());
        }
        public async Task<IActionResult> ListRemont()
        {
            return View(await db.Remonts.ToListAsync());
        }

        public async Task<IActionResult> CatalogComputers()
        {
            return View(await db.Computers.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> CabinetAdmin()
        {
            return View(await db.Computers.ToListAsync());
        }
        public IActionResult CreateProvider()
        {
            return View();
        }
        public IActionResult CreateCharac() 
        { 
            return View();
        }
        public IActionResult Remont()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProvider(Provider provider)
        {
            db.Providers.Add(provider);
            await db.SaveChangesAsync();
            return RedirectToAction("CreateProvider");

        }
        [HttpPost]
        public async Task<IActionResult> CreateRemont(Remont remont)
        {
            db.Remonts.Add(remont);
            await db.SaveChangesAsync();
            return RedirectToAction("Remont");

        }
        [HttpPost]
        public IActionResult CabinetAdmin(int ComputerId)
        {
            var comp = db.Computers.Find(ComputerId);
            db.Computers.Remove(comp);
            db.SaveChanges();
            return RedirectToAction("CatalogComputers");
        }
        [HttpPost]
        public IActionResult CreateComputers(ComputerViewModel pvm)
        {
            Computer computer = new Computer { ComputerId = pvm.ComputerId, Name = pvm.Name, Model = pvm.Model, CPU = pvm.CPU, MotherBoard = pvm.MotherBoard, GraphicsCard = pvm.GraphicsCard, HardDisk = pvm.HardDisk, Price = pvm.Price};

            if (pvm.Image != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(pvm.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Image.Length);
                }
                computer.Image = imageData;
            }
            db.Computers.Add(computer);
            db.SaveChanges();

            return RedirectToAction("CatalogComputers");
        }
        public async Task<IActionResult> SendMessage()
        {
            
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("v.stv@bk.ru", "Тема письма: Техническое обслуживание", "Уважаемый клиент, спешим Вам сообщить о возможности прохождения технического обслуживания в магазине компьютерной техники ComputerGrand");
            return RedirectToAction("ListOrders");
        }
        public async Task<IActionResult> SendMessageRemont()
        {

            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("v.stv@bk.ru", "Тема письма: Ремонт техники", "Уважаемый клиент, запись на ремонт осуществлена, ждём вас!");
            return RedirectToAction("ListRemont");
        }
    }
}
