﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskManager.WebAPI.Controller
{
    public class TasksController : ApiController
    {
        public IHttpActionResult GetTaskList()
        {
            return Ok("blablabla");
        }


    }
}
