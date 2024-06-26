﻿using Microsoft.AspNetCore.Mvc;
using static Bord.Server.DataAccessLayer.DAL;

namespace Bord.Server.Controllers
{
    [ApiController]
    public class ThreadController : ControllerBase
    {
        [HttpPost]
        [Route("/thread/create")]
        public IActionResult createThread([FromBody] Models.Thread thread)
        {                         
            try
            {
                ThreadDAL threadDAL = new ThreadDAL();
                threadDAL.CreateThread(thread);
                return Ok();
            }catch
            {
                return BadRequest();
            }
        }
    }
}
