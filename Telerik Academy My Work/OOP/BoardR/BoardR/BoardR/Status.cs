using System;
using System.Collections.Generic;
using System.Text;

namespace BoardR
{
    public enum Status
    {
      //  Open <-> Todo <-> InProgress <-> Done <-> Verified
      Open = 0,
      Todo = 1,
      InProgress = 2,
      Done = 3,
      Verified = 4
    }
}
