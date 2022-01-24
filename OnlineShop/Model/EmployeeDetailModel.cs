using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model
{
    internal class EmployeeDetailModel
    {
        public string Name { get; set; }
        public string TaskId { get; set; }
        public string TaskDetails { get; set; }
        public string StartDate { get; set; }


        public string EndDate { get; set; }
        public string Count { get; set; }
        public string Status { get; set; }
    }
}
