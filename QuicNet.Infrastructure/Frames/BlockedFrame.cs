﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicNet.Infrastructure.Frames
{
    public class BlockedFrame : Frame
    {
        public override byte Type => 0x08;

        public override byte[] Build()
        {
            throw new NotImplementedException();
        }
    }
}
