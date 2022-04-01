using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CvAsp2.Models
{
    public class InfoPersoForm { 
    
    [HiddenInput]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Téléphone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Etablissement { get; set; }
        [Required]
        public string Diplome { get; set; }
        [Required]
        public string Qualité1 { get; set; }
        [Required]
        public string Qualité2 { get; set; }
        [Required]
        public string Qualité3 { get; set; }
        [Required]
        public string Default1 { get; set; }
        [Required]
        public string Default2 { get; set; }
        [Required]
        public string Default3 { get; set; }
    
    }
}
