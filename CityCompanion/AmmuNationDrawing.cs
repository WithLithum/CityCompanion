using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using LemonUI;

namespace CityCompanion
{
    [ScriptAttributes(NoDefaultInstance = true)]
    public class AmmuNationDrawing : Script
    {
        public ObjectPool pool = new ObjectPool();

        public AmmuNationDrawing()
        {
            Tick += AmmuNationDrawing_Tick;
        }

        private void AmmuNationDrawing_Tick(object sender, EventArgs e)
        {
            pool.Process();
        }
    }
}
