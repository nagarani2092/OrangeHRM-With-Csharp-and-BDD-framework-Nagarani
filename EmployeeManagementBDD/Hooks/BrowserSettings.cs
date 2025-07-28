using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBDD.Hooks
{
    public class BrowserSettings
    {
        public string BrowserName { get; set; } = "chrome"; // chromium, firefox, webkit
        public bool? Headless { get; set; } = false;
        public int? SlowMo { get; set; } = 0;
        public int? Timeout { get; set; } = 30000;
        public int? DefaultTimeout { get; set; } = 30000;
    }
}
