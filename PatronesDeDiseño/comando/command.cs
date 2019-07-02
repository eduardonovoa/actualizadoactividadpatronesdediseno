﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Command.RealWorld
{
    abstract class Command

    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
