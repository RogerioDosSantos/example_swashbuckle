using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace swashbuckle.Models
{
    public class ValuesModel
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}
