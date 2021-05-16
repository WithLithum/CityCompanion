using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using Newtonsoft.Json;

namespace CityCompanion.Util
{
    public struct AmmuNationShopItems
    {
        [JsonProperty("products", DefaultValueHandling = DefaultValueHandling.Ignore, Required = Required.Always)]
#pragma warning disable S1104 // Fields should not have public accessibility
        public AmmuNationProduct[] Products;
#pragma warning restore S1104 // Fields should not have public accessibility
    }

    public class AmmuNationProduct
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
        [JsonProperty("hash", Required = Required.Always)]
        public WeaponHash Hash { get; set; }
        [JsonProperty("price", Required = Required.Always)]
        public int Price { get; set; }
        [JsonProperty("ammos", Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public short AmmoAmount { get; set; } = 100;
}
}
