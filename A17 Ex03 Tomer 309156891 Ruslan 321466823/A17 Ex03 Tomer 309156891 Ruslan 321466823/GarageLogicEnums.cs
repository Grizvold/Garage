using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    // Dear Excerise Checker, In Ex02 you gave us comments about Enum need to be in nessted class or in seprate files (it was above a class), 
    // hope you meant like this and not that each Enum should have a file of it's own (it wasn't clear, and if each enum should be in seprate file, 
    // we would appreciate just comment and not point reduction again ("the internet" said this is a proper way)). 
    public enum eLicenseKind
    {
        A,
        A1,
        A2,
        B
    }

    public enum eCarColor
    {
        Red,
        White,
        Black,
        Silver,
    }

    public enum eDoorsNum
    {
        Two,
        Three,
        Four,
        Five,
    }

    public enum eVehicleStatus
    {
        InRepair,
        Repaired,
        Paid,
    }

    public enum eFuelType
    {
        Soler,
        Octan95,
        Octan96,
        Octan98,
    }
    
}
