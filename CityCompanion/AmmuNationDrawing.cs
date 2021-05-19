// Copyright (c) RelaperCrystal.
// Licensed under GNU GPL version 3 or any later version.

using System;
using GTA;
using LemonUI;

namespace CityCompanion
{
    [ScriptAttributes(NoDefaultInstance = true)]
    public class AmmuNationDrawing : Script
    {
        public ObjectPool Pool { get; set; } = new ObjectPool();

        public AmmuNationDrawing()
        {
            Tick += AmmuNationDrawing_Tick;
        }

        private void AmmuNationDrawing_Tick(object sender, EventArgs e)
        {
            Pool.Process();
        }
    }
}
