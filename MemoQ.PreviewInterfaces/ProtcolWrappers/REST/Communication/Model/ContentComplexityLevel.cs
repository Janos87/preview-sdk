﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoQ.PreviewInterfaces.ProtcolWrappers.REST.Communication.Model
{
    public enum ContentComplexityLevel
    {
        /// <summary>
        /// The final plain text of the segment part without any inline tags or formatting.
        /// </summary>
        Minimal,
        /// <summary>
        /// The final plain text of the segment part with interpreted formatting (b/i/u/sup/sub in html format).
        /// </summary>
        PlainWithInterpretedFormatting
    }
}
