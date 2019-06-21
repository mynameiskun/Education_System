using NewLife.Cube;
using NewLife.School.Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Areas.TakeCourse.Controllers
{
    [DisplayName("我要选课")]
    public class SelectCourseController : EntityController<Course>
    {
        // GET: TakeCourse/SelectCourse
       public ActionResult TakeCourse()
        {
            Response.Write("<script>aaa</script>");
            return View();
        }
    }
}