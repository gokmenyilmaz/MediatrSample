using MediatR;
using MediatrSample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //_mediatr.Publish(new NotificationMessage { NotifyText = "metin" });

            var response =  _mediatr.Send(new Ping());
            Debug.WriteLine(response.Result); // "Pong"
            return "Completed";
        }
    }
}
