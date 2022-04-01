using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CvAsp2.Models
{

    public class CompétenceForm
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nom de Compétence")]
        public string Name { get; set; }
    }
}
