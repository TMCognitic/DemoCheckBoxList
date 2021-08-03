using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCheckBoxList.Models.Forms
{
    public class RegisterForm
    {
        public string Name { get; set; }

        public IEnumerable<SelectListItem> Choices { get; set; }
    }
}
