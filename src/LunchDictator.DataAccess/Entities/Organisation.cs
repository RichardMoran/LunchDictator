﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDictator.DataAccess.Entities
{
    public class Organisation : BaseEntity
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
