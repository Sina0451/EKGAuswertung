using System;

namespace ECGTestNovember2026
{
    public class ECGDataRecievedEventArgs : EventArgs
    {
        internal ECGValue ECGValueRecieved { get; set; }
    }
}