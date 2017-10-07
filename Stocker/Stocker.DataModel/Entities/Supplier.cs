﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.DataModel.Entities
{
    public class Supplier: BaseEntity
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
