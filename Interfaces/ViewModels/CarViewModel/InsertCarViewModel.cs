using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ViewModels.CarViewModel
{
    public class InsertCarViewModel
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public bool isComplete { get; set; }
    }
}
