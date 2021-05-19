// Copyright (c) RelaperCrystal.
// Licensed under GNU GPL version 3 or any later version.

using System.Collections.Generic;
using GTA;
using Newtonsoft.Json;

namespace CityCompanion.Util
{
    public class AmmuNationShopItems
    {
        [JsonProperty("Weapons", DefaultValueHandling = DefaultValueHandling.Ignore, Required = Required.Always)]
        public Dictionary<WeaponHash, AmmuNationProduct> Products { get; set; }
    }

    public class AmmuNationProduct
    {
        [JsonProperty("price", Required = Required.Always)]
        public int Price { get; set; }
        [JsonProperty("Ammo", Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public short AmmoAmount { get; set; } = 100;
        [JsonProperty(Required =  Required.Always)]
        public bool AllowExisting { get; set; }
}
}
