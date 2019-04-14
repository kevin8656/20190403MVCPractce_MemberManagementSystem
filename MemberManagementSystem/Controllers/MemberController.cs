using MemberManagementSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberManagementSystem.Controllers
{
    public class MemberController : Controller
    {
        MemberService memberService = new MemberService();
        // GET: Member
        public ActionResult Index()
        {
            return View(memberService.GetAllMember());
        }
    }
}