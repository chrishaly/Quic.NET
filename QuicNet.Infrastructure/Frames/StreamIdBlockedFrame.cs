﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicNet.Infrastructure.Frames
{
    public class StreamIdBlockedFrame : Frame
    {
        public override byte Type => 0x0a;

        public override byte[] Build()
        {
            throw new NotImplementedException();
        }
    }
}