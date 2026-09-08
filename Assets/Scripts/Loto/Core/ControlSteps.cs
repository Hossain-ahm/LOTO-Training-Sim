using System;

namespace LotoSim.Core
{
    [Flags]
    public enum ControlSteps
    {
        None = 0,
        Isolate = 1, 
        Lock = 2, 
        ReleaseStored = 4, 
        Verify = 8
    }
}