using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace LX_webapi.Models
{
    public class TestPostViewModel
    {
        [Microsoft.Build.Framework.Required]
        public int I { get; set; }
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
