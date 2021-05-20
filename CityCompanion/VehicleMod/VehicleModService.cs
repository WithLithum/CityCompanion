// Copyright (c) RelaperCrystal.
// Licensed under GNU GPL version 3 or any later version.

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
