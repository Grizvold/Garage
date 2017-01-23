using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleInGarage
    {
        public string m_OwnerName;
        public string m_PhoneNumber;
        public eVehicleStatus m_VehicleStatus = eVehicleStatus.InRepair;
        public Vehicle m_Vehicle;
    }
}
