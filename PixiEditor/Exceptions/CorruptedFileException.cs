﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiEditor.Exceptions
{

    [Serializable]
    public class CorruptedFileException : Exception
    {
        public CorruptedFileException()
            : base("Selected file is invalid or corrupted.")
        {
        }

        public CorruptedFileException(string message)
            : base(message)
        {
        }

        public CorruptedFileException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected CorruptedFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}