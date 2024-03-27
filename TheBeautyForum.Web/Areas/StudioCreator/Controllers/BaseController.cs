﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheBeautyForum.Web.Areas.StudioCreator.Controllers
{
    [Area("StudioCreator")]
    [Route("/StudioCreator/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "StudioCreator")]
    public class BaseController : Controller
    {
    }
}
