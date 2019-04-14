using MemberManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberManagementSystem.Service
{
    public class MemberService
    {
        Models.MemberManagementSystemEntities db = new Models.MemberManagementSystemEntities();

        public List<Member> GetAllMember()
        {
            return db.Member.ToList();
        }

        public void InsertMemeberData(Member newMember)
        {
            db.Member.Add(newMember);
            db.SaveChanges();
        }
    }
}