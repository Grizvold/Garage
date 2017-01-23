using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        Dictionary<int, VehicleInGarage> m_VehicleMap = new Dictionary<int, VehicleInGarage>();
        List<VehicleInGarage> m_VehiclesInside = new List<VehicleInGarage>();

        public Garage(List<VehicleInGarage> i_VehiclesForGarage)
        {
            m_VehiclesInside = i_VehiclesForGarage;
            foreach (VehicleInGarage vehicle in m_VehiclesInside)
            {
                m_VehicleMap.Add(vehicle.m_Vehicle.GetHashCode(), vehicle);
            }
        }

        public Garage() { }

        public List<VehicleInGarage> VehiclesInGarage
        {
            get { return m_VehiclesInside; }
            //set { m_VehiclesInside = value; }  // not the way we will add cars
        }

        public string AddVehicle(string i_LicenseNumber, Vehicle i_VehicleToAdd, string i_OwnerName, string i_OwnerPhone)
        {
            VehicleInGarage selectedVehicle;
            int licenseNum = i_LicenseNumber.GetHashCode();
            string returningMsg;

            if (m_VehicleMap.TryGetValue(licenseNum, out selectedVehicle))
            {
                selectedVehicle.m_VehicleStatus = eVehicleStatus.InRepair;
                returningMsg = "The vehicle is allready In the garage, and his status has been updated to 'Inrepair'";
            }
            else
            {
                selectedVehicle = new VehicleInGarage();
                selectedVehicle.m_OwnerName = i_OwnerName;
                selectedVehicle.m_PhoneNumber = i_OwnerPhone;
                selectedVehicle.m_Vehicle = i_VehicleToAdd;
                m_VehiclesInside.Add(selectedVehicle);
                m_VehicleMap.Add(selectedVehicle.m_Vehicle.GetHashCode(), selectedVehicle);
                returningMsg = "The vehicle has been added to the garage successfully";
            }

            return returningMsg;
        }

        public void ChangeVehicleStatus(string i_LicenseNum, eVehicleStatus i_Status) //no msg for else, keep in mind
        {
            VehicleInGarage selectedVehicle;
            if (m_VehicleMap.TryGetValue(i_LicenseNum.GetHashCode(), out selectedVehicle))
            {
                selectedVehicle.m_VehicleStatus = i_Status;
            }
        }

        public void TiresInflation(string i_LicenseNum) // NOT FINISHED!!!!
        {
            int maxAir, currAir;
            VehicleInGarage selectedVehicle;

            if (m_VehicleMap.TryGetValue(i_LicenseNum.GetHashCode(), out selectedVehicle))
            {
                foreach (Wheel wheel in selectedVehicle.m_Vehicle.Wheels)
                {
                    wheel.CurrentAir = wheel.MaxAir;
                }

            }

        }

        public bool RefuelingVehicle(string i_LicenseNum, eFuelType i_FuelKind, float i_fuelQuantity)
        {
            VehicleInGarage selectedVehicle;
            FuelVehicle fuelVehicle;
            bool fuelingSucceed = false;

            if (m_VehicleMap.TryGetValue(i_LicenseNum.GetHashCode(), out selectedVehicle))
            {
                fuelVehicle = selectedVehicle.m_Vehicle as FuelVehicle;
                if(fuelVehicle != null)
                {
                    fuelingSucceed =  fuelVehicle.VehicleRefueling(i_FuelKind, i_fuelQuantity);
                }
            }

            return fuelingSucceed;
        }

        public bool RechargingVehicle(string i_LicenseNum, float i_ChargingMinutes)
        {
            VehicleInGarage selectedVehicle;
            ElectricVehicle electricVehicle;
            bool chargingSucceed = false;
            float chargingHours = i_ChargingMinutes / 60f;  //the number  after the decimal point won't be minutes, it will be a part from an hour.

            if (m_VehicleMap.TryGetValue(i_LicenseNum.GetHashCode(), out selectedVehicle))
            {
                electricVehicle = selectedVehicle.m_Vehicle as ElectricVehicle;
                if (electricVehicle != null)
                {

                    chargingSucceed = electricVehicle.VehicleCharging(chargingHours);
                }
            }

            return chargingSucceed;
        }

        public string PrintVehicleData(string i_LicenseNum)
        {
            VehicleInGarage selectedVehicle;
            string vehicleData = string.Empty;

            if (m_VehicleMap.TryGetValue(i_LicenseNum.GetHashCode(), out selectedVehicle))
            {
                vehicleData = selectedVehicle.m_Vehicle.ToString();
            }
            else
            {
                throw new ArgumentException("The vehicle does not exist in the garage");
            }
            return vehicleData;
        }

        public List<string> GarageListOfVehiclesNumbers (bool i_ReturnFilteredList, eVehicleStatus i_VehicleStatus)
        {
            List<string> vehiclesNumbers = new List<string>();
            foreach (VehicleInGarage vehicle in m_VehiclesInside)
            {
                if (i_ReturnFilteredList)
                {
                    if(vehicle.m_VehicleStatus == i_VehicleStatus)
                    {
                        vehiclesNumbers.Add(vehicle.m_Vehicle.GetHashCode().ToString());
                    }
                }

                else
                {
                    vehiclesNumbers.Add(vehicle.GetHashCode().ToString());
                }
                
            }

            return vehiclesNumbers;
        }

     
    }
}
