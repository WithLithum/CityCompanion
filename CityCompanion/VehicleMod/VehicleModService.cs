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

        internal static void SetXenonHeadlightsEnabled(this Vehicle vehicle, bool enabled)
        {
            Function.Call(Hash.TOGGLE_VEHICLE_MOD, vehicle, 22, enabled);
        }

        internal static void SetTireSmokeEnabled(this Vehicle vehicle, bool enabled)
        {
            Function.Call(Hash.TOGGLE_VEHICLE_MOD, vehicle, 20, enabled);
        }
    }
}
