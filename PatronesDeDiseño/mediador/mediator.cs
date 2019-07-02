﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Mediator.RealWorld
{
    abstract class AbstractChatroom

    {
        public abstract void Register(Participant participant);
        public abstract void Send(
          string from, string to, string message);
    }

}


