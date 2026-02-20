using Newtonsoft.Json;
using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityVanillaItemRecipes.Config;

public class CurrentRecipesConfig : ModConfig // 1. Current Recipes
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    public static CurrentRecipesConfig Instance => ModContent.GetInstance<CurrentRecipesConfig>();

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

        Aglet = value;
        AnkletOfTheWind = value;
        BlizzardInABottle = value;
        BrainOfConfusion = value;
        CloudInABottle = value;
        CobaltShield = value;
        CrimsonHeart = value;
        FlameWakerBoots = value;
        FleshKnuckles = value;
        FlowerBoots = value;
        FrogLeg = value;
        HandWarmer = value;
        HermesBoots = value;
        IceSkates = value;
        LavaCharm = value;
        LuckyHorseshoe = value;
        ObsidianRose = value;
        PutridScent = value;
        Radar = value;
        ShadowOrb = value;
        ShinyRedBalloon = value;
        StepStool = value;
        WaterWalkingBoots = value;
        WormScarf = value;

        RocketI = value;
        RocketII = value;

        SnowCoat = value;
        SnowHood = value;
        SnowPants = value;

        LifeCrystal = value;
        SnowGlobe = value;

        BastStatue = value;
        CrossGraveMarker = value;
        GoldenCrossGraveMarker = value;
        GoldenGraveMarker = value;
        GoldenGravestone = value;
        GoldenHeadstone = value;
        GoldenTombstone = value;
        GraveMarker = value;
        Gravestone = value;
        Headstone = value;
        Obelisk = value;
        Tombstone = value;

        EncumberingStone = value;
        MagicConch = value;
        Umbrella = value;
        TendonHook = value;
        WormHook = value;

        BallOHurt = value;
        ChainGuillotines = value;
        ClingerStaff = value;
        CrimsonRod = value;
        DartPistol = value;
        DartRifle = value;
        FetidBaghnakhs = value;
        FinchStaff = value;
        LifeDrain = value;
        Musket = value;
        PulseBow = value;
        SergeantUnitedShield = value;
        SlimeStaff = value;
        TheRottedFork = value;
        TheUndertaker = value;
        Vilethorn = value;
        WandOfSparking = value;
        WaterBolt = value;
        WoodenBoomerang = value;

        #endregion
    }


    #region ACCESSORIES

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Accessories")]

    // Aglet
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Aglet { get; set; }

    // Anklet of the Wind
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool AnkletOfTheWind { get; set; }

    // Blizzard in a Bottle
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BlizzardInABottle { get; set; }

    // Brain of Confusion
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BrainOfConfusion { get; set; }

    // Cloud in a Bottle
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CloudInABottle { get; set; }

    // Cobalt Shield
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CobaltShield { get; set; }

    // Crimson Heart
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CrimsonHeart { get; set; }

    // Flame Waker Boots
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FlameWakerBoots { get; set; }

    // Flesh Knuckles
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FleshKnuckles { get; set; }

    // Flower Boots
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FlowerBoots { get; set; }

    // Frog Leg
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FrogLeg { get; set; }

    // Hand Warmer
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool HandWarmer { get; set; }

    // Hermes Boots
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool HermesBoots { get; set; }

    // Ice Skates
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool IceSkates { get; set; }

    // Lava Charm
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LavaCharm { get; set; }

    // Lucky Horseshoe
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LuckyHorseshoe { get; set; }

    // Obsidian Rose
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ObsidianRose { get; set; }

    // Putrid Scent
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool PutridScent { get; set; }

    // Radar
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Radar { get; set; }

    // Shadow Orb
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ShadowOrb { get; set; }

    // Shiny Red Balloon
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ShinyRedBalloon { get; set; }

    // Step Stool
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool StepStool { get; set; }

    // Water Walking Boots
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WaterWalkingBoots { get; set; }

    // Worm Scarf
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WormScarf { get; set; }

    #endregion


    #region AMMO

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Ammo")]

    // Rocket I
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool RocketI { get; set; }

    // Rocket II
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool RocketII { get; set; }

    #endregion


    #region ARMOR

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Armor")]

    // Snow Coat
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SnowCoat { get; set; }

    // Snow Hood
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SnowHood { get; set; }

    // Snow Pants
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SnowPants { get; set; }

    #endregion


    #region CONSUMABLES

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Consumables")]

    // Life Crystal
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LifeCrystal { get; set; }

    // Snow Globe
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SnowGlobe { get; set; }

    #endregion


    #region PLACEABLES

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Placeables")]

    // Bast Statue
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BastStatue { get; set; }

    // Cross Grave Marker
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CrossGraveMarker { get; set; }

    // Golden Cross Grave Marker
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GoldenCrossGraveMarker { get; set; }

    // Golden Grave Marker
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GoldenGraveMarker { get; set; }

    // Golden Gravestone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GoldenGravestone { get; set; }

    // Golden Headstone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GoldenHeadstone { get; set; }

    // Golden Tombstone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GoldenTombstone { get; set; }

    // Grave Marker
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool GraveMarker { get; set; }

    // Gravestone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Gravestone { get; set; }

    // Headstone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Headstone { get; set; }

    // Obelisk
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Obelisk { get; set; }

    // Tombstone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Tombstone { get; set; }

    #endregion


    #region TOOLS

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Tools")]

    // Encumbering Stone
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool EncumberingStone { get; set; }

    // Magic Conch
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool MagicConch { get; set; }

    // Umbrella
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Umbrella { get; set; }

    // Tendon Hook
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool TendonHook { get; set; }

    // Worm Hook
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WormHook { get; set; }

    #endregion


    #region WEAPONS

    [Header("$Mods.CalamityVanillaItemRecipes.Substitutions.Headers.Weapons")]

    // Ball O' Hurt
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool BallOHurt { get; set; }

    // Chain Guillotines
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ChainGuillotines { get; set; }

    // Clinger Staff
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool ClingerStaff { get; set; }

    // Crimson Rod
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool CrimsonRod { get; set; }

    // Dart Pistol
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool DartPistol { get; set; }

    // Dart Rifle
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool DartRifle { get; set; }

    // Fetid Baghnakhs
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FetidBaghnakhs { get; set; }

    // Finch Staff
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool FinchStaff { get; set; }

    // Life Drain
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool LifeDrain { get; set; }

    // Musket
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Musket { get; set; }

    // Pulse Bow
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool PulseBow { get; set; }

    // Sergeant United Shield
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SergeantUnitedShield { get; set; }

    // Slime Staff
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool SlimeStaff { get; set; }

    // The Rotted Fork
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool TheRottedFork { get; set; }

    // The Undertaker
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool TheUndertaker { get; set; }

    // Vilethorn
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool Vilethorn { get; set; }

    // Wand of Sparking
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WandOfSparking { get; set; }

    // Water Bolt
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WaterBolt { get; set; }

    // Wooden Boomerang
    [DefaultValue(defaultValue)]
    [ReloadRequired]
    public bool WoodenBoomerang { get; set; }

    #endregion
}
