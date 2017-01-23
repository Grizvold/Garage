using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricBike : ElectricVehicle
    {
        protected int m_EngineCc;
        protected eLicenseKind m_LicenseKind;

        public ElectricBike(int i_EngineCc, eLicenseKind i_LicenseKind, float i_CurrBattery, float i_MaxBattery, string i_Model, string i_LicenseNum, Wheel[] i_Wheels)
            : base(i_CurrBattery, i_MaxBattery, i_Model, i_LicenseNum, i_Wheels)
        {
            m_EngineCc = i_EngineCc;
            m_LicenseKind = i_LicenseKind;
        }

        public override string ToString()
        {
            return string.Format("Bikes engine capacity - {0}, and the license type is  - {1}", m_EngineCc, m_LicenseKind + Environment.NewLine + base.ToString());
        }
    }
}
