using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Briza_.Models
{
    public class ModelBrizaEnvio
    {
        [Required(ErrorMessage = "*", AllowEmptyStrings = false)]
        [Display(Name ="Nome")]
        public  string Nome { get; set; }

        [Required(ErrorMessage = "*", AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        public  string Email { get; set; }
 
    }
}
