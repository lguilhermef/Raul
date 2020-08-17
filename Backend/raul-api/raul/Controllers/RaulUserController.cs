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
    [Route("api/raulUser/")]
    [ApiController]
    public class RaulUserController : RaulController
    {

        public RaulUserController (RaulDbContext dbContext) : base (dbContext)
        {
        }


        [HttpGet]
        public ActionResult test ()
        {
            RaulUser user = new RaulUser();
            user.NvcUsername = "TESTE-NOVO";
            db.Add(user);
            db.SaveChanges();

           // Goal goal = new Goal();
           // goal.IntGoalTime = 500; //ISTO FUNCIONA

            //db.Add(goal);
            //db.SaveChanges();

            return BadRequest();
        }
    }
}