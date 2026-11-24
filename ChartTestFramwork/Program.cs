using System;
using System.Windows.Forms;

namespace ECGTestNovember2026
{
    internal static class Program
    {
        private static IModelLocalData modelLocaldata;
        private static IModelECGDevice modelEKGDevice;
        private static IViewECG viewEKG;
        private static IControllerECG controllerEKG;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            modelLocaldata = new ModelLocaldata();
            modelEKGDevice = new ModelECGDevice();
            viewEKG = new ViewECG();
            controllerEKG = new ControllerECG();

            modelLocaldata.ControllerECG = controllerEKG;
            modelLocaldata.ViewEKG = viewEKG;
            modelLocaldata.ModelECGDevice = modelEKGDevice;

            modelEKGDevice.ControllerECG = controllerEKG;
            modelEKGDevice.ViewECG = viewEKG;
            modelEKGDevice.ModelLocaldata = modelLocaldata;

            viewEKG.ControllerECG = controllerEKG;
            viewEKG.ModelECGDevice = modelEKGDevice;
            viewEKG.ModelLocalData = modelLocaldata;

            controllerEKG.ModelLocaldata = modelLocaldata;
            controllerEKG.ModelEKGDevice = modelEKGDevice;
            controllerEKG.ViewEKG = viewEKG;

            Application.Run((ViewECG)viewEKG);
        }
    }
}