﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBServer.Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotationController : ControllerBase
    {
        [HttpPost]
        public ActionResult SubmitVote()
        {
            return BadRequest();
        }
    }
}