﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Variable
{
    public class MySetting
    {
        public string BrowserType { get; set; }
        public string AppUrl { get; set; }

        public MySetting() 
        {
            BrowserType = "FF";
            AppUrl = "https://www.spicejet.com";
        } 
    }
}
