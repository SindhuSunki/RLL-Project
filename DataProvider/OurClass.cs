﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class OurClass
    {
        protected ClinicalDbEntities context;

        public OurClass()
        {
            context = new ClinicalDbEntities();
        }
    }
}
