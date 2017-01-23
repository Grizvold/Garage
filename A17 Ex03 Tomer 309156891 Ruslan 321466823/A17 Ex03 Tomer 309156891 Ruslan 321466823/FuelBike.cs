using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelBike : FuelVehicle
    {
        int m_EngineCc;
        eLicenseKind m_LicenseKind; 

        public FuelBike(int i_EngineCc, eLicenseKind i_LicenseKind, float i_CurrFuel, float i_MaxFuel, eFuelType i_FuelType, string i_Model, string i_LicenseNum, Wheel[] i_Wheels) 
            : base(i_CurrFuel, i_MaxFuel, i_FuelType, i_Model, i_LicenseNum, i_Wheels)
        {
            m_EngineCc = i_EngineCc;
            m_LicenseKind = i_LicenseKind;
        }

        public override string ToString()
        {
            return string.Format("Bike Details:{0}Engine size - {1}, License type - {2}{0}{3}", Environment.NewLine, m_EngineCc, m_LicenseKind, base.ToString());
        }
    }
}
