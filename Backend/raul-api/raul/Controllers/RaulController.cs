using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using raul.Models.Db;
using raul.Services;

namespace RaulWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class RaulController : ControllerBase
    {
        public GenericService serviceImpl { get; set; }

        public void setServiceImplementation (GenericService serviceImpl)
        {
            this.serviceImpl = serviceImpl;
        }
    }
}