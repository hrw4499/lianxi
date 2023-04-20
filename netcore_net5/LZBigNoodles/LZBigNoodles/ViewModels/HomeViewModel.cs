using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LZBigNoodles.Models;

namespace LZBigNoodles.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }
    }
}
