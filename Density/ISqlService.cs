﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Density
{
    public interface ISqlService
    {
        int Execute(SqlModule module);
    }
}