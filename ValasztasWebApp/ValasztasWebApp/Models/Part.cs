using System.ComponentModel.DataAnnotations;

namespace ValasztasWebApp.Models
{
    public class Part
    {
        [Key] 
        public string rovidNev { get; set; }
        public string? hosszudNev { get; set; }
        public ICollection<Jelolt> Jeloltek { get; set; } 
    }
}
