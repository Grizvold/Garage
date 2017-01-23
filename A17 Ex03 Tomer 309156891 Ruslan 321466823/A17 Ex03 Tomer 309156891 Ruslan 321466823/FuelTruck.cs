using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelTruck : FuelVehicle
    {
        bool m_HasDangerousMaterials;
        float m_MaxWeightAllowed;

        public FuelTruck(bool i_DangerousMaterials, float i_MaxWeight, float i_CurrFuel, float i_MaxFuel, eFuelType i_FuelType, string i_Model, string i_LicenseNum, float i_Energy, Wheel[] i_Wheels) 
            : base(i_CurrFuel, i_MaxFuel, i_FuelType, i_Model, i_LicenseNum, i_Wheels)
        {
            m_HasDangerousMaterials = i_DangerousMaterials;
            m_MaxWeightAllowed = i_MaxWeight;
        }

        public override string ToString()
        {
            string DangerousMaterialsWarning = string.Empty;
            if (m_HasDangerousMaterials)
            {
                DangerousMaterialsWarning = "Truck carries dangerous materials";
            }
            else
            {
                DangerousMaterialsWarning = "Truck doesn't carry dangerous materials";
            }

            return string.Format("Truck Details:{0}Maximum Carry Weight - {1},{2}{0}{3}", Environment.NewLine, m_MaxWeightAllowed, DangerousMaterialsWarning, base.ToString());
        }
    }
}
