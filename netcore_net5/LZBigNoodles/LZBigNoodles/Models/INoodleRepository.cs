﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LZBigNoodles.Models
{
    public interface INoodleRepository
    {
        IEnumerable<Noodle> GetAllNoodles();
        Noodle GetNoodleById(int id);
    }
}
