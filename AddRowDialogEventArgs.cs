using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySetup
{
  internal class AddRowDialogEventArgs : EventArgs
  {
    public string Name { get; set; } = String.Empty;
    public string Link { get; set; } = String.Empty;
  }
}
