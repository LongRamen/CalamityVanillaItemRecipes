using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Terraria.ModLoader.Config;

namespace CalamityVanillaItemRecipes.Config
{
    public class MainConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        /*
		[DefaultValue(false)]
		[ReloadRequired]
		public bool NewItemsEnabled;
		*/

        [Header("$Mods.CalamityVanillaItemRecipes.Configs.MainConfig.EnableItemsHeader")]

        [DefaultValue(false)]
        [ReloadRequired]
        public bool AncientBoneDust_Enabled;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool BloodOrb_Enabled;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool DemonicBoneAsh_Enabled;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool EssenceofEleum_Enabled;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool Essence_CoreofSunlight_Enabled;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool MurkyPaste_Enabled;

        [JsonExtensionData]
        private IDictionary<string, JToken> _additionalData = new Dictionary<string, JToken>();

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (_additionalData.TryGetValue("NewItemsEnabled", out JToken token))
            {
                bool NewItemsEnabled = token.ToObject<bool>();

                AncientBoneDust_Enabled = NewItemsEnabled;
                BloodOrb_Enabled = NewItemsEnabled;
                DemonicBoneAsh_Enabled = NewItemsEnabled;
                EssenceofEleum_Enabled = NewItemsEnabled;
                Essence_CoreofSunlight_Enabled = NewItemsEnabled;
                MurkyPaste_Enabled = NewItemsEnabled;
            }
            _additionalData.Clear();
        }
    }
}