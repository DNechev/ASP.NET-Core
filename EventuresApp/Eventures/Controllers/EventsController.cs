using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Domain;
using Eventures.Models.BindingModels;
using Eventures.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext context;

        public EventsController(EventuresDbContext context)
        {
            this.context = context;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(EventCreateBindingModel model)
        {
            if (this.ModelState.IsValid)
            {
                Event eventForDb = new Event
                {
                    Name = model.Name,
                    Place = model.Place,
                    Start = model.Start,
                    End = model.End,
                    TotalTickets = model.TotalTickets,
                    PricePerTicket = model.PricePerTicket
                };

                context.Events.Add(eventForDb);
                context.SaveChanges();

                return this.RedirectToAction("All");
            }

            return this.View();
        }
        public IActionResult All()
        {
            List<AllEventsViewModel> events = context.Events
                .Select(eventFromDb => new AllEventsViewModel
                {
                    Name = eventFromDb.Name,
                    Start = eventFromDb.Start,
                    End = eventFromDb.End,
                    Place = eventFromDb.Place
                })
                .ToList();


            return View(events);
}
    }
}