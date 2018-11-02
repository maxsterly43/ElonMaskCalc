using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EM.Calc.Web.Models
{
    public class InputModel
    {
        [Display(Name = "Операция")]
        [Required(ErrorMessage = "Необходимо ввести операцию для расчета")]
        public string Name { get; set; }

        [Display(Name = "Значения")]
        public double[] values { get; set; }
    }
}