﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenhou.Models
{
    [Flags]
    enum GameType
    {
        Match_East = 1,
        Match_EastSouth = 9,
        Mode_Fast = 64,
        Level_High = 128,
        Level_VeryHigh = 32,
        Level_Phoenix = 160
    }
}
