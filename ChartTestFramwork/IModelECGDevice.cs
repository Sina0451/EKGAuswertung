using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECGTestNovember2026.ModelECGDevice;

namespace ECGTestNovember2026
{
    internal interface IModelECGDevice
    {
        IViewECG ViewECG { set; }
        IModelLocalData ModelLocaldata { set; }
        IControllerECG ControllerECG { set; }
        
        event ECGDataRecievedEventHandler ECGDataRecieved;

        void setPort(string portName);

        List<ECGValue> getData24h();

        void deleteData24h();

        void startLiveData();
        void stopLiveData();
       


    }
}
