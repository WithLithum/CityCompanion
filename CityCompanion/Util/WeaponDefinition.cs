using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CityCompanion.Util
{
    /// <summary>
    /// Represents a weapon.
    /// </summary>
    public class WeaponDefinition
    {
        /// <summary>
        /// Gets or sets the internal name of this weapon.
        /// </summary>
        /// <value>
        /// The internal name of this weapon.
        /// </value>
        public string HashKey { get; set; }

        /// <summary>
        /// Gets or sets the name localization key.
        /// </summary>
        /// <value>
        /// The name localization key.
        /// </value>
        [JsonProperty("NameGXT")]
        public string NameLocalizationKey { get; set; }

        /// <summary>
        /// Gets or sets the description localization key.
        /// </summary>
        /// <value>
        /// The description localization key.
        /// </value>
        [JsonProperty("DescriptionGXT")]
        public string DescriptionLocalizationKey { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}
