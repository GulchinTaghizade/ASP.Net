using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> stuList = new List<Student>(){
                    new Student(){ StudentID=1, StudentName="Steve", Age = 21 },
                    new Student(){ StudentID=2, StudentName="Bill", Age = 25 },
                    new Student(){ StudentID=3, StudentName="Ram", Age = 20 },
                    new Student(){ StudentID=4, StudentName="Ron", Age = 31 },
                    new Student(){ StudentID=5, StudentName="Rob", Age = 19 }
                };
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                ViewBag.model = stuList;
                return View();
            }
            else
            {
                foreach(var stu in stuList)
                {
                    if (id == stu.StudentID)
                    {
                        TempData["id"] = stu.StudentID;
                        TempData["name"] = stu.StudentName;
                        TempData["age"] = stu.Age;
                    }
                }

                ViewResult view = new ViewResult();
                view.ViewName = "Indexx";
                return view;
            }

    }
}
}
