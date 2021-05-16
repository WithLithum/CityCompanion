using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCompanion.Util;
using GTA;
using GTA.Math;
using LemonUI;
using LemonUI.Menus;
using Newtonsoft.Json;
using PlayerCompanion;

namespace CityCompanion
{
    public class AmmuNation : Script
    {
        private static readonly Vector3[] AmmuNationLocations = { new Vector3(18.18945f, -1120.384f, 28.91654f), new Vector3(-325.6184f, 6072.246f, 31.21228f) };

        private readonly ObjectPool pool = new ObjectPool();
        private readonly NativeMenu menu = new NativeMenu("Ammu-Nation", "Ammu-Nation");
        private readonly List<NativeItem> purchases = new List<NativeItem>();
        private readonly List<Blip> blips = new List<Blip>();
        private int delay;

        public AmmuNation()
        {
            Tick += AmmuNation_Tick;
            Aborted += AmmuNation_Aborted;
            pool.Add(menu);
            var shopItems = JsonConvert.DeserializeObject<AmmuNationShopItems>(File.ReadAllText(@"scripts\CityCompanion\ammu_nation.json"));
            foreach (var pos in AmmuNationLocations)
            {
                var blip = World.CreateBlip(pos);
                blip.Sprite = BlipSprite.AmmuNation;
                blip.Scale = 0.75f;
                blips.Add(blip);
            }
            foreach (var item in shopItems.Products)
            {
                var purchase = new NativeItem(item.Name, $"Purchases a {item.Name} for $${item.Price}.", "$" + item.Price.ToString());
                purchase.Activated += (sender, e) =>
                {
                    if (Companion.Wallet.Money < item.Price)
                    {
                        GTA.UI.Screen.ShowSubtitle("~r~You don't have enough money to purchase.");
                        return;
                    }
                    Companion.Wallet.Money -= item.Price;
                    if (Game.Player.Character.Weapons.HasWeapon(item.Hash))
                    {
                        Game.Player.Character.Weapons[item.Hash].Ammo += item.AmmoAmount;
                    }
                    else
                    {
                        Game.Player.Character.Weapons.Give(item.Hash, item.AmmoAmount, false, true);
                    }
                };
                purchases.Add(purchase);
                menu.Add(purchase);
            }
        }

        private void AmmuNation_Aborted(object sender, EventArgs e)
        {
            foreach (var item in blips)
            {
                if (item?.Exists() == true)
                {
                    item.Delete();
                }
            }
        }

        private void AmmuNation_Tick(object sender, EventArgs e)
        {
            pool.Process();
            foreach (var ammu in AmmuNationLocations)
            {
                Yield();
                if (ammu.DistanceTo(Game.Player.Character.Position) < 5f)
                {
                    if (!menu.Visible)
                    {
                        GTA.UI.Screen.ShowHelpTextThisFrame("Press ~KEY_CONTEXT~ to open Ammu-Nation menu.");
                    }

                    Game.DisableControlThisFrame(Control.Context);
                    if (Game.IsControlJustPressed(Control.Context) && delay == 0)
                    {
                        menu.Visible = !menu.Visible;
                        delay = 2;
                    }
                }
            }

            if (delay > 0)
            {
                delay--;
            }

            if (delay < 0)
            {
                delay = 0;
            }
        }
    }
}
