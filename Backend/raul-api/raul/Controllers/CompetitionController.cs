
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using raul.Models.Db;
using raul.Services;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Controllers
{
    [Route("api/competition/")]
    [ApiController]
    public class CompetitionController : RaulController
    {

        public CompetitionService competitionService;

        public CompetitionController()
        {
            setServiceImplementation(new CompetitionService());
        }

        [HttpGet("nextCompetition")]
        public IActionResult getNextCompetition()
        {
            Competition nextCompetition = competitionService.getNextCompetition();
            return Ok(nextCompetition);
        }

        [HttpGet("comptList")]
        public IActionResult getCompetitionList()
        {
            List<String> comptList = new List<String>();
            comptList.Add("League");
            comptList.Add("Cup");
            comptList.Add("Super Cup");
            comptList.Add("League Cup");
            comptList.Add("Champions League");
            comptList.Add("Intercontinental");

            return Ok(comptList);
        }

        [HttpGet("calendar")]
        public IActionResult getCalendar ()
        {
            Competition competition = new Competition();//TODO: get a competition or competition Id from Front-end
            List<Game> calendar = competitionService.getCalendar(competition);
            return Ok(calendar);
        }
    }
}
