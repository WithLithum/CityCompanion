using GTA;
using GTA.Native;
using GTA.UI;
using PlayerCompanion;

namespace CityCompanion.Mod.Scripts
{
    public class Respawn : Script
    {
        private bool received;
        private bool processing;
        private int timerTick;

        public Respawn()
        {
            Tick += Respawn_Tick;
        }

        private void Respawn_Tick(object sender, System.EventArgs e)
        {
            if (!received && (Function.Call<int>(Hash.GET_TIME_SINCE_LAST_ARREST) <= 5 || Function.Call<int>(Hash.GET_TIME_SINCE_LAST_DEATH) <= 5))
            {
                received = true;
            }

            if (received && !processing && Screen.IsFadedOut && timerTick <= 250)
            {
                timerTick++;
            }

            if (Screen.IsFadedIn && timerTick != 0)
            {
                received = false;
            }

            if (received && !processing && timerTick > 250)
            {
                processing = true;
                timerTick = 0;
                Screen.FadeIn(500);
                if (Companion.Wallet.Money >= 250)
                {
                    Companion.Wallet.Money -= 250;
                }
            }
        }
    }
}
