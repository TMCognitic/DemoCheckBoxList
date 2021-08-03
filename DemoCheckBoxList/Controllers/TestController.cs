using DemoCheckBoxList.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCheckBoxList.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            RegisterForm form = new RegisterForm()
            {
                Choices = GetSelectListItems()
            };

            return View(form);
        }

        [HttpPost]
        public IActionResult Index(RegisterForm form, string[] choices)
        {
            form.Choices = GetSelectListItems();
            foreach(SelectListItem selectListItem in form.Choices)
            {
                selectListItem.Selected = choices.Contains(selectListItem.Value);
            }

            return View(form);
        }

        private SelectListItem[] GetSelectListItems()
        {
            return new SelectListItem[]
            {
                new SelectListItem("Choice 1", "1"),
                new SelectListItem("Choice 2", "2"),
                new SelectListItem("Choice 3", "3"),
            };
        }
    }
}
