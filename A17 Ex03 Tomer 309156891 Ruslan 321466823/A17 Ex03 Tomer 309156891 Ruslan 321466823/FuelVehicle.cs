using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class FuelVehicle : Vehicle
    {
        private float m_CurrentFuel;
        private float m_MaximumFuel;
        eFuelType m_FuelType;

        public FuelVehicle(float i_CurrFuel, float i_MaxFuel, eFuelType i_FuelType, string i_Model, string i_LicenseNum, Wheel[] i_Wheels) 
            : base(i_Model, i_LicenseNum, (i_CurrFuel / i_MaxFuel) * 100f, i_Wheels)
        {
            m_CurrentFuel = i_CurrFuel;
            m_MaximumFuel = i_MaxFuel;
            m_FuelType = i_FuelType;
        }

        public bool VehicleRefueling(eFuelType i_FuelType, float i_FuelToAdd)
        {
            bool refuelingDone = true;
            if (i_FuelType == m_FuelType)
            {
                if (m_MaximumFuel >= m_CurrentFuel + i_FuelToAdd) /*&& i_FuelType == m_FuelType)*/
                {
                    m_CurrentFuel += i_FuelToAdd;
                    EnergyPercentageLeft = (m_MaximumFuel / m_CurrentFuel) * 100f;
                }
                else
                {
                    refuelingDone = false;
                    throw new ValueOutOfRangeException(0, m_MaximumFuel - m_CurrentFuel, "You have entered out of range value to refuel");
                }
            }
            else
            {
                refuelingDone = false;
                throw new ArgumentException("You have put wrong fuel type to refuel");
            }

            return refuelingDone;
        }

        public override string ToString()
        {
            return string.Format("Fuel Level - {0}, fuel type - {1}{2}{3}", m_CurrentFuel, m_FuelType, Environment.NewLine, base.ToString());
        }
    }
}
