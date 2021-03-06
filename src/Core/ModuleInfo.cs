﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core
{
    public class ModuleInfo
    {
        public string Name { get; set; }
        public Assembly Assembly { get; set; }
        public string SortName
        {
            get
            {
                return Name.Split('.').Last();
            }
        }

        public string Path { get; set; }
    }
}
