using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;

namespace CityCompanion.VehicleMod
{
    internal static class VehicleModService
    {
        internal static void InitializeCar(Vehicle vehicle)
        {
            Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle, 0);
        }
    }
}
