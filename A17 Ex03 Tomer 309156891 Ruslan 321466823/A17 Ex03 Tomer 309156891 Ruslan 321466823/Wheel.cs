using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_Manufacturer;
        private float m_CurrAirPressure;
        private float m_MaxAirPressure;
        
        public Wheel(string i_Manufacturer, float i_CurrentAir, float i_MaxAir)
        {
            m_Manufacturer = i_Manufacturer;
            m_CurrAirPressure = i_CurrentAir;
            m_MaxAirPressure = i_MaxAir;
        }

        public float CurrentAir
        {
            get { return m_CurrAirPressure; }
            set { m_CurrAirPressure = value; }
        }

        public float MaxAir
        {
            get { return m_MaxAirPressure; }
            set { m_MaxAirPressure = value; }
        }

        public bool TireInflation(float i_AirToAdd)
        {
            bool InflationIsPossible = true;
            if(m_MaxAirPressure >= m_CurrAirPressure + i_AirToAdd)
            {
                m_CurrAirPressure += i_AirToAdd;
            }
            else
            {
                InflationIsPossible = false;
                throw new ValueOutOfRangeException (0, m_MaxAirPressure, "You have entered out of range value for inflation");
            }

            return InflationIsPossible;
        }
        public override string ToString()
        {

            return string.Format("wheel: manufactorer - {0}, current air pressure - {1}", m_Manufacturer, m_CurrAirPressure);
        }
    }
}
