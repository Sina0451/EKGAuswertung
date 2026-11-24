using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace ECGTestNovember2026
{
    internal class ModelLocaldata : IModelLocalData
    {
        private IModelECGDevice modelEKGDevice;
        private IViewECG viewEKG;
        private IControllerECG controllerECG;
        private XDocument xmlDoc = new XDocument(new XElement("EKGDaten"));

        private readonly string customDirectory = @".\";
        private readonly string customFileName = "EKG_Data.xml";

        IViewECG IModelLocalData.ViewEKG { set => viewEKG = value; }
        IModelECGDevice IModelLocalData.ModelECGDevice { set => modelEKGDevice = value; }
        IControllerECG IModelLocalData.ControllerECG { set => controllerECG = value; }

        List<double> IModelLocalData.get24hData()
        {
            throw new NotImplementedException();
        }

        void IModelLocalData.set24hData(ECGValue aktuellerWert)
        {
            throw new NotImplementedException();
        }

        void IModelLocalData.saveLiveData(ECGValue aktuellerWert)
        {
            if (aktuellerWert == null || xmlDoc.Root == null)
                return;

            XElement datenElement = new XElement("Messung",
                new XElement("Zeitstempel", aktuellerWert.TimeStamp),
                new XElement("Wert", aktuellerWert.Value)
            );

            xmlDoc.Root.Add(datenElement);

            string fullPath = Path.Combine(customDirectory, customFileName);
            xmlDoc.Save(fullPath);
        }
    }
}