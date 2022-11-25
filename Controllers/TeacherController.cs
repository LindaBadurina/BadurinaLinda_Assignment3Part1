using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Assignment3.Models;
namespace Assignment3.Controllers
{
    public class TeacherController : Controller
    {
        //GET : /Teacher
        public ActionResult Index()
        {
            // private static Assignment3.Models.Teacher t = new Assignment3.Models.Teacher();
            return View();
        }
        //GET : /Teacher/List
        public ActionResult List()
        {
            TeacherDataController cont = new TeacherDataController();
            IEnumerable<Teacher> Teachers = cont.ListTeachers();
            return View(Teachers);
        }
        //GET /Teacher/Show
        //Calls exactly how the instructor does it in her code, but it doesn't work, as I explained in the TeacherDataController comment.
        public ActionResult Show(string id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewAuthor = controller.FindTeacher(id);


            return View(NewAuthor);
        }
    }
}

