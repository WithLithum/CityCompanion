// Copyright (c) RelaperCrystal.
// Licensed under GNU GPL version 3 or any later version.

using GTA;
using PlayerCompanion;

namespace CityCompanion
{
    public class MoneyPickupHandler : Script
    {
        public MoneyPickupHandler()
        {
            Tick += MoneyPickupHandler_Tick;
        }

        private void MoneyPickupHandler_Tick(object sender, System.EventArgs e)
        {
            foreach (var pickup in World.GetAllPickupObjects())
            {
                Yield();
                if (pickup?.Exists() == true && pickup.Model.NativeValue == 0xee5ebc97 && Game.Player.Character.Position.DistanceTo(pickup.Position) <= 1.5f) 
                {
                    pickup.Delete();
                    Companion.Wallet.Money += 15;
                }
            }
        }
    }
}
