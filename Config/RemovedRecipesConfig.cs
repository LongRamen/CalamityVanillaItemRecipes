using Newtonsoft.Json;
using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityVanillaItemRecipes.Config;

public class RemovedRecipesConfig : ModConfig // 2. Removed Recipes
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    public static RemovedRecipesConfig Instance => ModContent.GetInstance<RemovedRecipesConfig>();

    private const bool defaultValue = true;

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool EnableAll
    {
        get => false;
        set { if (value) ToggleAll(true); }
    }

    [DefaultValue(false)]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableAll
    {
        get => false;
        set { if (value) ToggleAll(false); }
    }

    private void ToggleAll(bool value)
    {
        #region Toggles

        AdhesiveBandage = value;
        BandOfRegeneration = value;
        Blindfold = value;
        CelestialMagnet = value;
        DPSMeter = value;
        FastClock = value;
        FeralClaws = value;
        GuideVoodooDoll = value;
        LavaproofFishingHook = value;
        MagicQuiver = value;
        Megaphone = value;
        MetalDetector = value;
        Nazar = value;
        PocketMirror = value;
        ShoeSpikes = value;
        TrifoldMap = value;

        PharaohsMask = value;
        PharaohsRobe = value;

        GelatinCrystal = value;
        TempleKey = value;

        IceMachine = value;
        LivingLoom = value;
        SkyMill = value;

        BlackLens = value;

        ApplePie = value;
        BananaSplit = value;
        BBQRibs = value;
        CartonOfMilk = value;
        Milkshake = value;
        Nachos = value;

        BugNet = value;
        DesertMinecart = value;
        LeafWand = value;
        LivingMahoganyWand = value;
        LivingWoodWand = value;
        RichMahoganyLeafWand = value;
        ShadowKey = value;
        StaffOfRegrowth = value;

        FlareGun = value;
        IceBoomerang = value;
        Shuriken = value;
        ThrowingKnife = value;

        #endregion
    }


    #region ACCESSORIES

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Accessories")]

    // Adhesive Bandage
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool AdhesiveBandage { get; set; }

    // Band of Regeneration
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BandOfRegeneration { get; set; }

    // Blindfold
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Blindfold { get; set; }

    // Celestial Magnet
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CelestialMagnet { get; set; }

    // DPS Meter
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool DPSMeter { get; set; }

    // Fast Clock
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FastClock { get; set; }

    // Feral Claws
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FeralClaws { get; set; }

    // Guide Voodoo Doll
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GuideVoodooDoll { get; set; }

    // Lavaproof Fishing Hook
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LavaproofFishingHook { get; set; }

    // Magic Quiver
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool MagicQuiver { get; set; }

    // Megaphone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Megaphone { get; set; }

    // Metal Detector
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool MetalDetector { get; set; }

    // Nazar
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Nazar { get; set; }

    // Pocket Mirror
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool PocketMirror { get; set; }

    // Shoe Spikes
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ShoeSpikes { get; set; }

    // Trifold Map
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool TrifoldMap { get; set; }

    #endregion


    #region ARMOR

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Armor")]

    // Pharaoh's Mask - removed in 2.0.7 but include anyway
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool PharaohsMask { get; set; }

    // Pharaoh's Robe - removed in 2.0.7 but include anyway
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool PharaohsRobe { get; set; }

    #endregion


    #region CONSUMABLES

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Consumables")]

    // Gelatin Crystal
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GelatinCrystal { get; set; }

    // Temple Key
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool TempleKey { get; set; }

    #endregion


    #region CRAFTING STATIONS

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.CraftingStations")]

    // Ice Machine
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool IceMachine { get; set; }

    // Living Loom
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LivingLoom { get; set; }

    // Sky Mill
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SkyMill { get; set; }

    #endregion


    #region MATERIALS

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Materials")]

    // Black Lens
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BlackLens { get; set; }

    #endregion


    #region POTIONS

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Potions")]

    // Apple Pie
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ApplePie { get; set; }

    // Banana Split
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BananaSplit { get; set; }

    // BBQ Ribs
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BBQRibs { get; set; }

    // Carton of Milk
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CartonOfMilk { get; set; }

    // Milkshake
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Milkshake { get; set; }

    // Nachos
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Nachos { get; set; }

    #endregion


    #region TOOLS

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Tools")]

    // Bug Net
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BugNet { get; set; }

    // Desert Minecart
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool DesertMinecart { get; set; }

    // Leaf Wand
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LeafWand { get; set; }

    // Living Mahogany Wand
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LivingMahoganyWand { get; set; }

    // Living Wood Wand
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LivingWoodWand { get; set; }

    // Rich Mahogany Leaf Wand
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool RichMahoganyLeafWand { get; set; }

    // Shadow Key
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ShadowKey { get; set; }

    // Staff of Regrowth
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool StaffOfRegrowth { get; set; }

    #endregion


    #region WEAPONS

    [Header("$Mods.CalamityVanillaItemRecipes.CommonSubstitutions.Headers.Weapons")]

    // Flare Gun
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FlareGun { get; set; }

    // Ice Boomerang
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool IceBoomerang { get; set; }

    // Shuriken
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Shuriken { get; set; }

    // Throwing Knife
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ThrowingKnife { get; set; }

    #endregion
}
