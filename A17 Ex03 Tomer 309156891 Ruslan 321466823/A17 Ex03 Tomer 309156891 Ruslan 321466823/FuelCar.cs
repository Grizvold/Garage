using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class FuelCar : FuelVehicle
    {
        eDoorsNum m_NumOfDoors;
        eCarColor m_CarColor;
        
        public FuelCar(eDoorsNum i_DoorsNum, eCarColor i_CarColor, float i_CurrFuel, float i_MaxFuel, eFuelType i_FuelType, string i_Model, string i_License, Wheel[] i_Wheels) 
            : base (i_CurrFuel, i_MaxFuel, i_FuelType, i_Model, i_License, i_Wheels)
        {
            m_CarColor = i_CarColor;
            m_NumOfDoors = i_DoorsNum;
        }

        public override string ToString()
        {
            return string.Format("Car Details:{0}Number of doors - {1}, Color - {2}{0}{3}", Environment.NewLine, m_NumOfDoors, m_CarColor, base.ToString());
        }
    }
}
