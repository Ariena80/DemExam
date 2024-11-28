using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demex2._0.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Deffect { get; set; }
        public string Priority { get; set; } = null;
        public string EmployeeComment { get; set; } = null;
        public string EmployeeName { get; set; }
        public string Status { get; set; } = null;
        public string ClientName { get; set; } = null;
        public string Comment { get; set; }

    }
}
