using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ViewModels.CarViewModel
{
    public class UpdateCarViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isComplete { get; set; }
    }
}
