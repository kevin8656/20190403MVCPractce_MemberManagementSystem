using MemberManagementSystem.Models;
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

        public ActionResult AddMember()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddMember(Member Data) 
        {
            memberService.InsertMemeberData(Data);
            return RedirectToAction("index");
                }

    }
}