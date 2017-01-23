using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        float m_MaxValue;
        float m_MinValue;

        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue, string i_ErrorMessage)
            : base(i_ErrorMessage)
        {
            MinValue = i_MinValue;
            MaxValue = i_MaxValue;
        }

        public float MinValue // DO WE NEED PROPERTY?! CHECK!@!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! VE GAM LEMATA
        {
            get { return m_MinValue; }
            set { m_MinValue = value; }
        }

        public float MaxValue
        {
            get { return m_MaxValue; }
            set { m_MaxValue = value; }
        }
    }
}
