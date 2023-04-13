using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctest.Controllers
{
    public class Show_StaffController : Controller
    {
        // GET: Show_Staff
        //查询员工信息
        public ActionResult StaffList()
        {
            IList<Staff> staff= null;
            using (CinemaEntities1 db = new CinemaEntities1()) 
            {
                staff=db.Staff.Select(s => s).ToList();
            }
                return View(staff);
        }
        //添加员工信息操作
        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(Staff staff)
        {
            using (CinemaEntities1 db=new CinemaEntities1())
            {
                db.Staff.Add(staff);
                db.SaveChanges();
            }         
                return RedirectToAction("StaffList");
        }

        //更新员工信息
        [HttpGet]
        public ActionResult UpdateStaff(int id)
        {
            Staff staff = null;
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                staff = db.Staff.Where(w => w.S_id==id).FirstOrDefault();
            }
            return View(staff);
        }
        [HttpPost]
        public ActionResult UpdateStaff(Staff staff)
        {
            using (CinemaEntities1 db = new CinemaEntities1()) 
            {
                var Editstu =db.Staff.Attach(staff);//编辑状态
                Editstu.S_name = staff.S_name;
                Editstu.S_age = staff.S_age;
                Editstu.S_gender = staff.S_gender;
                Editstu.S_post = staff.S_post;
                Editstu.S_department = staff.S_department;
                db.Entry(Editstu).Property(p => p.S_name).IsModified = true;
                db.Entry(Editstu).Property(p => p.S_age).IsModified = true;
                db.Entry(Editstu).Property(p => p.S_gender).IsModified = true;
                db.Entry(Editstu).Property(p => p.S_post).IsModified = true;
                db.Entry(Editstu).Property(p => p.S_department).IsModified = true;
                db.Configuration.ValidateOnSaveEnabled = false;
                db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
            }
            return RedirectToAction("StaffList");
        }

        //删除员工信息
        [HttpGet]
        public ActionResult DeleteStaff(int id)
        {
            Staff staff = null;
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                staff = db.Staff.Where(w => w.S_id == id).FirstOrDefault();
                if (staff != null)
                {
                    db.Staff.Remove(staff);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("StaffList");
        }
        
    }
}