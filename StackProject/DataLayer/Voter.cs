﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Voter
    {
        [DefaultValue(0)]
        public int count { get; set; } = 0;
    }
}
