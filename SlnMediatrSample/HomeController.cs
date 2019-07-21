using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public HomeController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _mediatr.Publish(new NotificationMessage { NotifyText = "metin" });
            return "Completed";
        }
    }
}
