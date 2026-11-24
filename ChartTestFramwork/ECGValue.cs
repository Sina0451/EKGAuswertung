using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGTestNovember2026
{
    internal class ECGValue
    {
        private int value;
        // private DateTime timeStamp;
        private int timeStamp;
        public int Value { get => value; set => this.value = value; }
        //public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public int TimeStamp { get => timeStamp; set => timeStamp = value; }
    }
}
