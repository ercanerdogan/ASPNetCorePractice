using ASPNetCoreMVC2Introduction.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASPNetCoreMVC2Introduction.Models.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        private List<Employee> _employees;

        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee { ID = 1, FirstName = "Ercan", LastName = "Erdogan", CityID = 35 },
                new Employee { ID = 2, FirstName = "Hakan", LastName = "Erdogan", CityID = 35 }
            };

        }

        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int ListCount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees.Take(ListCount);

            StringBuilder pHtmlContent = new StringBuilder();

            foreach (var emplyeee in query)
            {
                pHtmlContent.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", emplyeee.ID, emplyeee.FirstName.ToString() + " " + emplyeee.LastName);

            }

            output.Content.SetHtmlContent(pHtmlContent.ToString());

            base.Process(context, output);
        }

    }
}
