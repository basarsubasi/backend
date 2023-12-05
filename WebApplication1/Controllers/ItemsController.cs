using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult List()
        {
            Items model = new Items();

            var ChildrensBooks = GetChildrensBooks();
            var PhilosophyBook = GetPhilosophyBooks();
            var Stationeries = GetStationery();

            model.ChildrensBooks = ChildrensBooks;
            model.PhilosophyBooks = PhilosophyBook;
            model.Stationery = Stationeries;

            return View(model);
        }

        public IActionResult ListStationery()
        {
            Items model = new Items();
            var Stationeries = GetStationery();
            model.Stationery = Stationeries;
            return View(model);
        }

        public IActionResult ListPhilosophyBooks()
        {
            Items model = new Items();
            var PhilosophyBook = GetPhilosophyBooks();
            model.PhilosophyBooks = PhilosophyBook;
            return View(model);
        }
        public IActionResult ListChildrensBooks()
        { Items model = new Items();
            var ChildrensBook = GetChildrensBooks();
            model.ChildrensBooks = ChildrensBook;
            return View(model);
        }

        private List<ChildrensBooks> GetChildrensBooks()
        {
            return new List<ChildrensBooks>
            {
                new ChildrensBooks
                {
                    ID = 101,
                    Title = "Küçük Prens",
                    Year = 1943,
                    Price = "25.99₺",
                    AgeRange = "5-18",
                    Illustrator = "Antoine de Saint-Exupéry",
                    Image = "~/img/books/KucukPrens.jpg"
                },
                new ChildrensBooks
                {
                    ID = 102,
                    Title = "Aç Tırtıl",
                    Year = 1969,
                    Price = "12.99₺",
                    AgeRange = "3-5",
                    Illustrator = "Eric Carle",
                    Image = "~/img/books/AcTirtil.jpg"
                }
                ,
                new ChildrensBooks
                {
                    ID = 103,
                    Title = "Alice Harikalar Diyarında",
                    Year = 1865,
                    Price = "25.00₺",
                    AgeRange = "5-18",
                    Illustrator = "Lewis Carroll",
                    Image = "~/img/books/AliceHarikalarDiyarinda.png"

                },

                new ChildrensBooks
                {
                    ID = 104,
                    Title = "Çetin Ceviz",
                    Year = 2019,
                    Price = "30.00₺",
                    AgeRange = "5-12",
                    Illustrator = "Sinan Yaşar",
                    Image = "~/img/books/CetinCeviz.png"

                }
                
                
                

            };
        }

        private List<PhilosophyBooks> GetPhilosophyBooks()
        {
            return new List<PhilosophyBooks>
            {
                new PhilosophyBooks
                {
                    ID = 201,
                    Title = "Kendime Düşünceler",
                    Year = 180,
                    Price = "30.50₺",
                    Author = "Marcus Aurelius",
                    Image = "~/img/books/KendimeDusunceler1.jpg"
                },
                new PhilosophyBooks
                {
                    ID = 202,
                    Title = "Böyle Buyurdu Zerdüşt",
                    Year = 1883,
                    Price = "25.99₺",
                    Author = "Friedrich Nietzsche",
                    Image = "~/img/books/BoyleBuyurduZerdust.jpg"
                }
            };
        }

        private List<Stationery> GetStationery()
        {
            return new List<Stationery>
            {
                new Stationery
                {
                    ID = 301,
                    Name = "Kurşun Kalem",
                    Price = "50.00₺",
                    Image = "~/img/stationery/KursunKalem.jpg"
                },
                new Stationery
                {
                    ID = 302,
                    Name = "Silgi",
                    Price = "20.00₺",
                    Image = "~/img/stationery/Silgi.jpg"
                },
                new Stationery
                {
                    ID = 303,
                    Name = "Defter",
                    Price = "35.00₺",
                    Image = "~/img/stationery/Defter.jpg"
                }
            };
        }
    }
}
