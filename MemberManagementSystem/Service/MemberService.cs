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
        public void DeleteMemberData(int Id)
        {
            Member DeleteMember = db.Member.SingleOrDefault(x=>x.Id==Id);
            db.Member.Remove(DeleteMember);
            db.SaveChanges();
        }
        public void EditMemberData(Member EditMember)
        {
            Member oldMember = db.Member.SingleOrDefault(x => x.Id == EditMember.Id);
            oldMember.Name = EditMember.Name;
            oldMember.Age = EditMember.Age;
            oldMember.Address = EditMember.Address;
            oldMember.Tel = EditMember.Tel;
            db.SaveChanges();
        }
    }
}