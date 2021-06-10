using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.UI;

namespace CityCompanion.VehicleMod
{
    public class VehicleModScript : Script
    {
        public VehicleModScript()
        {
            Notification.Show("This build of vehicle modification is preliminary and solely for testing purposes. Press N to activate vehicle mod menu.");
            this.KeyDown += VehicleModScript_KeyDown;
            this.Tick += VehicleModScript_Tick;
        }

        private void VehicleModScript_Tick(object sender, EventArgs e)
        {
            
        }

        private void VehicleModScript_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
