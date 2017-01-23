using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar : ElectricVehicle
    {
        eDoorsNum m_NumOfDoors;
        eCarColor m_CarColor;

        public ElectricCar(eCarColor i_CarColor, eDoorsNum i_DoorsNum, float i_CurrBattery, float i_MaxBattery, string i_Model, string i_LicenseNum, Wheel[] i_Wheels)
            : base(i_CurrBattery, i_MaxBattery, i_Model, i_LicenseNum, i_Wheels)
        {
            m_CarColor = i_CarColor;
            m_NumOfDoors = i_DoorsNum;
        }

        public override string ToString()
        {
            return string.Format("Car Details:{0}Number of doors - {1}, Color {2}{0}{3}", Environment.NewLine, m_NumOfDoors, m_CarColor, base.ToString());
        }
    }
}
