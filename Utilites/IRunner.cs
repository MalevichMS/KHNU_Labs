﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserInterface
{
    public interface IRunner
    {
        Iinterface UserInterface { get; set; }
        

        void Run();
    }
}
