using System.ComponentModel.DataAnnotations;

namespace JS_Tree2.Models
{
    public class TreeViewNode
    {

        [Key]
        [Required]
        public string id { get; set; }
        [Required]
        public string parent { get; set; }
        [Required]
        public string text { get; set; }
    }
}

