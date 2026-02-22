using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityVanillaItemRecipes.Config;

public class MainConfig : ModConfig // 3. Calamity Items
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    public static MainConfig Instance => ModContent.GetInstance<MainConfig>();


    #region Toggles

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool EnableAllItemsAndRecipes
    {
        get => false;
        set { if (value) ToggleAllItemsAndRecipes(true); }
    }

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableAllItemsAndRecipes
    {
        get => false;
        set { if (value) ToggleAllItemsAndRecipes(false); }
    }

    private void ToggleAllItemsAndRecipes(bool value)
    {
        // Ancient Bone Dust
        AncientBoneDust_Obtainable = value;
        FledglingWings = value;
        ArmorPolish = value;

        // Blood Orb
        BloodOrb_Obtainable = value;
        BloodyTear = value;
        MoneyTrough = value;
        BloodOrb_Recipe = value;
        Vitamins = value;
        ToggleAllPotions(value);

        // Essence of Eleum
        EssenceOfEleum_Obtainable = value;
        FrozenTurtleShell = value;
    }


    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool EnableAllCurrentRecipes
    {
        get => false;
        set { if (value) ToggleAllCurrentRecipes(true); }
    }

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableAllCurrentRecipes
    {
        get => false;
        set { if (value) ToggleAllCurrentRecipes(false); }
    }

    private void ToggleAllCurrentRecipes(bool value)
    {
        FledglingWings = value;
        BloodyTear = value;
        MoneyTrough = value;
        ToggleAllPotions(value);
    }


    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool EnableAllRemovedRecipes
    {
        get => false;
        set { if (value) ToggleAllRemovedRecipes(true); }
    }

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableAllRemovedRecipes
    {
        get => false;
        set { if (value) ToggleAllRemovedRecipes(false); }
    }

    private void ToggleAllRemovedRecipes(bool value)
    {
        ArmorPolish = value;
        BloodOrb_Recipe = value;
        Vitamins = value;
        FrozenTurtleShell = value;
    }

    #endregion


    #region Ancient Bone Dust

    [Header("AncientBoneDust")]

    [DefaultValue(false)]
    [ReloadRequired]
    public bool AncientBoneDust_Obtainable { get; set; }

    // Fledgling Wings (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool FledglingWings { get; set; }

    // Armor Polish (removed)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ArmorPolish { get; set; }

    #endregion


    #region Blood Orb

    [Header("BloodOrb")]

    [DefaultValue(false)]
    [ReloadRequired]
    public bool BloodOrb_Obtainable { get; set; }

    // Bloody Tear (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool BloodyTear { get; set; }

    // Money Trough (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool MoneyTrough { get; set; }

    // Bloody Tear -> 10 Blood Orbs (removed)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool BloodOrb_Recipe { get; set; }

    // Vitamins (removed)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool Vitamins { get; set; }

    #endregion


    #region Blood Orb - Potions

    [Header("BloodOrbPotions")]

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool EnableAllPotions// { get; set; }
    {
        get => false;
        set { if (value) ToggleAllPotions(true); }
    }

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableAllPotions// { get; set; }
    {
        get => false;
        set { if (value) ToggleAllPotions(false); }
    }

    private void ToggleAllPotions(bool value)
    {
        #region Toggles

        AmmoReservationPotion = value;
        ArcheryPotion = value;
        BattlePotion = value;
        BiomeSightPotion = value;
        BuilderPotion = value;
        CalmingPotion = value;
        CratePotion = value;
        DangersensePotion = value;
        EndurancePotion = value;
        FeatherfallPotion = value;
        FishingPotion = value;
        FlipperPotion = value;
        GenderChangePotion = value;
        GillsPotion = value;
        GravitationPotion = value;
        GreaterLuckPotion = value;
        HeartreachPotion = value;
        HunterPotion = value;
        InfernoPotion = value;
        InvisibilityPotion = value;
        IronskinPotion = value;
        LesserLuckPotion = value;
        LifeforcePotion = value;
        LovePotion = value;
        LuckPotion = value;
        MagicPowerPotion = value;
        ManaRegenerationPotion = value;
        MiningPotion = value;
        NightOwlPotion = value;
        ObsidianSkinPotion = value;
        PotionOfReturn = value;
        RagePotion = value;
        RecallPotion = value;
        RegenerationPotion = value;
        ShinePotion = value;
        SonarPotion = value;
        SpelunkerPotion = value;
        StinkPotion = value;
        SummoningPotion = value;
        SwiftnessPotion = value;
        TeleportationPotion = value;
        ThornsPotion = value;
        TitanPotion = value;
        WarmthPotion = value;
        WaterWalkingPotion = value;
        WormholePotion = value;
        WrathPotion = value;

        #endregion
    }

    // Ammo Reservation Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool AmmoReservationPotion { get; set; }

    // Archery Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ArcheryPotion { get; set; }

    // Battle Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool BattlePotion { get; set; }

    // Biome Sight Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool BiomeSightPotion { get; set; }

    // Builder Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool BuilderPotion { get; set; }

    // Calming Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool CalmingPotion { get; set; }

    // Crate Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool CratePotion { get; set; }

    // Dangersense Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool DangersensePotion { get; set; }

    // Endurance Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool EndurancePotion { get; set; }

    // Featherfall Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool FeatherfallPotion { get; set; }

    // Fishing Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool FishingPotion { get; set; }

    // Flipper Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool FlipperPotion { get; set; }

    // Gender Change Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool GenderChangePotion { get; set; }

    // Gills Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool GillsPotion { get; set; }

    // Gravitation Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool GravitationPotion { get; set; }

    // Greater Luck Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool GreaterLuckPotion { get; set; }

    // Heartreach Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool HeartreachPotion { get; set; }

    // Hunter Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool HunterPotion { get; set; }

    // Inferno Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool InfernoPotion { get; set; }

    // Invisibility Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool InvisibilityPotion { get; set; }

    // Ironskin Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool IronskinPotion { get; set; }

    // Lesser Luck Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool LesserLuckPotion { get; set; }

    // Lifeforce Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool LifeforcePotion { get; set; }

    // Love Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool LovePotion { get; set; }

    // Luck Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool LuckPotion { get; set; }

    // Magic Power Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool MagicPowerPotion { get; set; }

    // Mana Regeneration Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ManaRegenerationPotion { get; set; }

    // Mining Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool MiningPotion { get; set; }

    // Night Owl Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool NightOwlPotion { get; set; }

    // Obsidian Skin Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ObsidianSkinPotion { get; set; }

    // Potion of Return (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool PotionOfReturn { get; set; }

    // Rage Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool RagePotion { get; set; }

    // Recall Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool RecallPotion { get; set; }

    // Regeneration Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool RegenerationPotion { get; set; }

    // Shine Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ShinePotion { get; set; }

    // Sonar Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool SonarPotion { get; set; }

    // Spelunker Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool SpelunkerPotion { get; set; }

    // Stink Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool StinkPotion { get; set; }

    // Summoning Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool SummoningPotion { get; set; }

    // Swiftness Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool SwiftnessPotion { get; set; }

    // Teleportation Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool TeleportationPotion { get; set; }

    // Thorns Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool ThornsPotion { get; set; }

    // Titan Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool TitanPotion { get; set; }

    // Warmth Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool WarmthPotion { get; set; }

    // Water Walking Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool WaterWalkingPotion { get; set; }

    // Wormhole Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool WormholePotion { get; set; }

    // Wrath Potion (current)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool WrathPotion { get; set; }

    #endregion


    #region Essence of Eleum

    [Header("EssenceOfEleum")]

    [DefaultValue(false)]
    [ReloadRequired]
    public bool EssenceOfEleum_Obtainable { get; set; }

    // Frozen Turtle Shell (removed)
    [DefaultValue(false)]
    [ReloadRequired]
    public bool FrozenTurtleShell { get; set; }

    #endregion


    #region OnDeserialized

    [JsonExtensionData]
    private readonly Dictionary<string, JToken> _additionalData = [];

    [OnDeserialized]
    internal void OnDeserializedMethod(StreamingContext context)
    {
        try
        {
            if (_additionalData.TryGetValue("NewItemsEnabled", out JToken token))
            {
                bool NewItemsEnabled = token.ToObject<bool>();

                ToggleAllItemsAndRecipes(NewItemsEnabled);
            }
            if (_additionalData.TryGetValue("AncientBoneDust_Enabled", out token))
            {
                bool AncientBoneDust_Enabled = token.ToObject<bool>();

                AncientBoneDust_Obtainable = AncientBoneDust_Enabled;
                FledglingWings = AncientBoneDust_Enabled;
                ArmorPolish = AncientBoneDust_Enabled;
            }
            if (_additionalData.TryGetValue("BloodOrb_Enabled", out token))
            {
                bool BloodOrb_Enabled = token.ToObject<bool>();

                BloodOrb_Obtainable = BloodOrb_Enabled;
                BloodyTear = BloodOrb_Enabled;
                MoneyTrough = BloodOrb_Enabled;
                BloodOrb_Recipe = BloodOrb_Enabled;
                Vitamins = BloodOrb_Enabled;
                ToggleAllPotions(BloodOrb_Enabled);
            }
            if (_additionalData.TryGetValue("EssenceofEleum_Enabled", out token))
            {
                bool EssenceofEleum_Enabled = token.ToObject<bool>();

                EssenceOfEleum_Obtainable = EssenceofEleum_Enabled;
                FrozenTurtleShell = EssenceofEleum_Enabled;
            }
        }
        catch { }
        _additionalData.Clear();
    }

    #endregion
}
