using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.Models
{
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInStock { get; set; } //判断是否有库存
        
    }
}
