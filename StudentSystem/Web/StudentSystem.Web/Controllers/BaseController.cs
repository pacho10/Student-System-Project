﻿using AutoMapper;
using StudentSystem.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentSystem.Web.Controllers
{
    public class BaseController : Controller
    {
       protected IMapper Mapper
        {
           get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}