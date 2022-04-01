using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CvAsp2.Models
{
    public class ExpérienceForm

    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public int AnnéeDébut { get; set; }
        [Required]
        public int AnnéeFin { get; set; }
        [Required]
        public string Employeur { get; set; }
        [Required]
        public string Fonction { get; set; }
    }
}
