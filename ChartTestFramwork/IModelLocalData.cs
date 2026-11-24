using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGTestNovember2026
{
    internal interface IModelLocalData
    {
        IViewECG ViewEKG { set; }
        IModelECGDevice ModelECGDevice { set; }
        IControllerECG ControllerECG { set; }

        List<double> get24hData();
        void set24hData(ECGValue aktuellerWert);

        void saveLiveData(ECGValue aktuellerWert);

        

    }
}
