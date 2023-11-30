using System.ComponentModel.DataAnnotations;

namespace testASP.Models
{
    public class Photo
    {
        [Display(Name = "Зимня казка")]
        public string Name { get; }
    }
}
