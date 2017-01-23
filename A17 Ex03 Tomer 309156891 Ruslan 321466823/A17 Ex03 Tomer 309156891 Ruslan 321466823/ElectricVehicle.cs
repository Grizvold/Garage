using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class ElectricVehicle : Vehicle
    {
        private float m_CurrentBatteryLife;
        private float m_MaximumBatteryLife;

        public ElectricVehicle(float i_CurrBattery, float i_MaxBattery, string i_Model, string i_LicenseNum, Wheel[] i_Wheels)
            : base(i_Model, i_LicenseNum, (i_CurrBattery / i_MaxBattery) * 100f, i_Wheels)
        {
            m_CurrentBatteryLife = i_CurrBattery;
            m_MaximumBatteryLife = i_MaxBattery;
        }

        public bool VehicleCharging (float i_ChargeToAdd)
        {
            bool chargingDone = true;
            if (m_MaximumBatteryLife >= m_CurrentBatteryLife + i_ChargeToAdd )
            {
                m_CurrentBatteryLife += i_ChargeToAdd;
                EnergyPercentageLeft = (m_MaximumBatteryLife / m_CurrentBatteryLife) * 100f;
            }

            else
            {
                chargingDone = false;
                throw new ValueOutOfRangeException(0, m_MaximumBatteryLife - m_CurrentBatteryLife, "Wrong input for battery charge value");
            }
            return chargingDone;

        }

        public override string ToString()
        {
            return string.Format("Battery status - {0}{1}{2}", m_CurrentBatteryLife, Environment.NewLine ,base.ToString());
        }
    }
}
