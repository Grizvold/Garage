using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicensePlate;
        private float m_EnergyPercentage;
        Wheel[] m_Wheels;
         
        public Vehicle(string i_Model, string i_LicenseNum, float i_Energy, Wheel[] i_Wheels) // WE NEED TO CHECK THAT PERCENTAGE CALC WORKS RIGHT!!
        {
            m_EnergyPercentage = i_Energy;
            m_LicensePlate = i_LicenseNum;
            m_ModelName = i_Model;
            m_Wheels = i_Wheels; // need to check if working properly.......!!!!!!!!!!!!!!!!!!!!!!!!!@#$%
        }

        public Wheel[] Wheels
        {
            get { return m_Wheels; }
            set { m_Wheels = value; } //needs a check to see all good with assignment!!!@#@$$%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        }

        public float EnergyPercentageLeft
        {
            get { return m_EnergyPercentage; }
            set { m_EnergyPercentage = value; }
        }
        public override string ToString()
        {
            return string.Format("Model Name - {0}, License Plate - {1}, Energy percentage left - {2}", m_ModelName, m_LicensePlate, m_EnergyPercentage);
        }

        public string LicensePlate
        {
            get { return m_LicensePlate; }
            set { m_LicensePlate = value; }
        }

        public override int GetHashCode()
        {
            return m_LicensePlate.GetHashCode(); //if the license plate will have a string in it, it will still work.
        }
    }
}
