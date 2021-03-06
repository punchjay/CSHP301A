﻿// Exercise 07
// Gibble, Jay ejg2
using System;

namespace VendingMachine
{
    public class VENDBADFLAVORException : Exception
    {
        public VENDBADFLAVORException()
            : base("Bad Conversion to a Flavor enumeral attempted")
        {
        }

        public VENDBADFLAVORException(string Message)
            : base(Message)
        {
        }

        public VENDBADFLAVORException(string Message, Exception Inner)
            : base(Message, Inner)
        {
        }

        public VENDBADFLAVORException(string Message, string BadFlavorString)
            : base(string.Format("{0}:{1}", Message, BadFlavorString))
        {
        }
    }
}
