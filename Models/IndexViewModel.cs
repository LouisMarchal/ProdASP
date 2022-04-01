namespace CvAsp2.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Compétences> Compétences { get; set; }
        public IEnumerable<Expérience> Expériences { get; set; }
        public IEnumerable<InfoPerso> InfoPerso { get; set; }
    }
}
