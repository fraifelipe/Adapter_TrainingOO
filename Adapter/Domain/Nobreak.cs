﻿using System;
using System.Collections.Generic;

namespace Adapter.Domain
{
    public class Nobreak:IEntradaAmericana
    {
        public bool EntradaDeTomada { get; set; } = false;
        public bool Ligado { get; set; } = true;
    }
}