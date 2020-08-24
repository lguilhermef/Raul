using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using raul.Models.Db;

namespace RaulWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class RaulController : ControllerBase
    {

        public DbContext db { get; set; }

        public RaulController (DbContext context)
        {
            this.db = context;
        }

        public void test()
        {
            Goal goal = new Goal();
            goal.AssistId = 1;

            var a = db.Add(goal);
            db.SaveChanges();
        }
    }
}