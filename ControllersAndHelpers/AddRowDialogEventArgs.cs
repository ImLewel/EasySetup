﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySetup.ControllersAndHelpers
{
    internal class AddRowDialogEventArgs : EventArgs
    {
        public string Name { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
}
