using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class AccessoryRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Aglet
        if (CurrentRecipesConfig.Instance.Aglet)
            Recipe.Create(ItemID.Aglet)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 5)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Anklet of the Wind
        if (CurrentRecipesConfig.Instance.AnkletOfTheWind)
            Recipe.Create(ItemID.AnkletoftheWind)
                .AddIngredient(ItemID.JungleSpores, 15)
                .AddIngredient(ItemID.Cloud, 5)
                .AddIngredient(ItemID.PinkGel, 5)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Blizzard in a Bottle
        if (CurrentRecipesConfig.Instance.BlizzardInABottle)
            Recipe.Create(ItemID.BlizzardinaBottle)
                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.Cloud, 5)
                .AddIngredient(ItemID.SnowBlock, 5)
                .AddIngredient(ItemID.Feather, 3)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Brain of Confusion
        if (CurrentRecipesConfig.Instance.BrainOfConfusion)
            Recipe.Create(ItemID.BrainOfConfusion)
                .AddIngredient(ItemID.WormScarf)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Cloud in a Bottle
        if (CurrentRecipesConfig.Instance.CloudInABottle)
            Recipe.Create(ItemID.CloudinaBottle)
                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.Cloud, 5)
                .AddIngredient(ItemID.Feather, 2)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Cobalt Shield
        if (CurrentRecipesConfig.Instance.CobaltShield)
            Recipe.Create(ItemID.CobaltShield)
                .AddRecipeGroup(nameof(ItemID.CobaltBar), 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Crimson Heart
        if (CurrentRecipesConfig.Instance.CrimsonHeart)
            Recipe.Create(ItemID.CrimsonHeart)
                .AddIngredient(ItemID.ShadowOrb)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Flame Waker Boots
        if (CurrentRecipesConfig.Instance.FlameWakerBoots)
            Recipe.Create(ItemID.FlameWakerBoots)
                .AddIngredient(ItemID.Silk, 8)
                .AddIngredient(ItemID.HellstoneBar, 5)
                .AddIngredient(ItemID.Obsidian, 4)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Flesh Knuckles
        if (CurrentRecipesConfig.Instance.FleshKnuckles)
            Recipe.Create(ItemID.FleshKnuckles)
                .AddIngredient(ItemID.PutridScent)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Flower Boots
        if (CurrentRecipesConfig.Instance.FlowerBoots)
            Recipe.Create(ItemID.FlowerBoots)
                .AddIngredient(ItemID.Silk, 7)
                .AddIngredient(ItemID.JungleRose)
                .AddIngredient(ItemID.JungleGrassSeeds, 5)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Frog Leg
        if (CurrentRecipesConfig.Instance.FrogLeg)
            Recipe.Create(ItemID.FrogLeg)
                .AddIngredient(ItemID.Frog, 6)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Hand Warmer
        if (CurrentRecipesConfig.Instance.HandWarmer)
            Recipe.Create(ItemID.HandWarmer)
                .AddIngredient(ItemID.Silk, 10)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Hermes Boots
        if (CurrentRecipesConfig.Instance.HermesBoots)
            Recipe.Create(ItemID.HermesBoots)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.SwiftnessPotion, 5)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Ice Skates
        if (CurrentRecipesConfig.Instance.IceSkates)
            Recipe.Create(ItemID.IceSkates)
                .AddIngredient(ItemID.FlinxFur, 3)
                .AddRecipeGroup("IronBar", 5)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Lava Charm
        if (CurrentRecipesConfig.Instance.LavaCharm)
            Recipe.Create(ItemID.LavaCharm)
                .AddIngredient(ItemID.LavaBucket, 3)
                .AddIngredient(ItemID.Obsidian, 5)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Lucky Horseshoe
        if (CurrentRecipesConfig.Instance.LuckyHorseshoe)
            Recipe.Create(ItemID.LuckyHorseshoe)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 8)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Obsidian Rose
        if (CurrentRecipesConfig.Instance.ObsidianRose)
            Recipe.Create(ItemID.ObsidianRose)
                .AddIngredient(ItemID.JungleRose)
                .AddIngredient(ItemID.Obsidian, 5)
                .AddIngredient(ItemID.Hellstone, 5)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Putrid Scent
        if (CurrentRecipesConfig.Instance.PutridScent)
            Recipe.Create(ItemID.PutridScent)
                .AddIngredient(ItemID.FleshKnuckles)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Radar
        if (CurrentRecipesConfig.Instance.Radar)
            Recipe.Create(ItemID.Radar)
                .AddRecipeGroup("IronBar", 5)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Shadow Orb
        if (CurrentRecipesConfig.Instance.ShadowOrb)
            Recipe.Create(ItemID.ShadowOrb)
                .AddIngredient(ItemID.CrimsonHeart)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Shiny Red Balloon
        if (CurrentRecipesConfig.Instance.ShinyRedBalloon)
            Recipe.Create(ItemID.ShinyRedBalloon)
                .AddIngredient(ItemID.WhiteString)
                .AddIngredient(ItemID.Cloud, 10)
                .AddTile(TileID.Solidifier)
                //.DisableDecraft()
                .Register();

        // Step Stool
        if (CurrentRecipesConfig.Instance.StepStool)
            Recipe.Create(ItemID.PortableStool)
                .AddRecipeGroup("Wood", 10)
                .AddTile(TileID.Sawmill)
                //.DisableDecraft()
                .Register();

        // Water Walking Boots
        if (CurrentRecipesConfig.Instance.WaterWalkingBoots)
            Recipe.Create(ItemID.WaterWalkingBoots)
                .AddIngredient(ItemID.Leather, 5)
                .AddIngredient(ItemID.WaterWalkingPotion, 5)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Worm Scarf
        if (CurrentRecipesConfig.Instance.WormScarf)
            Recipe.Create(ItemID.WormScarf)
                .AddIngredient(ItemID.BrainOfConfusion)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        #endregion


        #region Removed

        // Adhesive Bandage
        if (RemovedRecipesConfig.Instance.AdhesiveBandage)
            Recipe.Create(ItemID.AdhesiveBandage)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.Gel, 10)
                .AddIngredient(ItemID.HealingPotion)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Band of Regeneration
        if (RemovedRecipesConfig.Instance.BandOfRegeneration)
            Recipe.Create(ItemID.BandofRegeneration)
                .AddIngredient(ItemID.Shackle)
                .AddIngredient(ItemID.LifeCrystal)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Blindfold
        if (RemovedRecipesConfig.Instance.Blindfold)
            Recipe.Create(ItemID.Blindfold)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.TatteredCloth)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Celestial Magnet
        if (RemovedRecipesConfig.Instance.CelestialMagnet)
            Recipe.Create(ItemID.CelestialMagnet)
                .AddIngredient(ItemID.TreasureMagnet)
                .AddIngredient(ItemID.FallenStar, 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // DPS Meter
        if (RemovedRecipesConfig.Instance.DPSMeter)
            Recipe.Create(ItemID.DPSMeter)
                .AddIngredient(ItemID.Wire, 10)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Fast Clock
        if (RemovedRecipesConfig.Instance.FastClock)
            Recipe.Create(ItemID.FastClock)
                .AddIngredient(ItemID.Timer1Second)
                .AddIngredient(ItemID.PixieDust, 5)
                .AddIngredient(ItemID.SoulofLight, 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Feral Claws
        if (RemovedRecipesConfig.Instance.FeralClaws)
            Recipe.Create(ItemID.FeralClaws)
                .AddIngredient(ItemID.Leather, 10)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Guide Voodoo Doll
        if (RemovedRecipesConfig.Instance.GuideVoodooDoll)
            Recipe.Create(ItemID.GuideVoodooDoll)
                .AddIngredient(ItemID.Leather, 2)
                .AddRecipeGroup(nameof(ItemID.VilePowder), 10)
                .AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();

        // Lavaproof Fishing Hook
        if (RemovedRecipesConfig.Instance.LavaproofFishingHook)
            Recipe.Create(ItemID.LavaFishingHook)
                .AddIngredient(ItemID.Seashell)
                .AddIngredient(ItemID.HellstoneBar, 10)
                .AddTile(TileID.Hellforge)
                .Register();

        // Magic Quiver
        if (RemovedRecipesConfig.Instance.MagicQuiver)
            Recipe.Create(ItemID.MagicQuiver)
                .AddIngredient(ItemID.EndlessQuiver)
                .AddIngredient(ItemID.PixieDust, 5)
                .AddIngredient(ItemID.Lens, 3)
                .AddIngredient(ItemID.SoulofLight, 5)
                .AddTile(TileID.CrystalBall)
                .DisableDecraft()
                .Register();

        // Megaphone
        if (RemovedRecipesConfig.Instance.Megaphone)
            Recipe.Create(ItemID.Megaphone)
                .AddIngredient(ItemID.Wire, 5)
                .AddRecipeGroup(nameof(ItemID.CobaltBar), 3)
                .AddIngredient(ItemID.Ruby)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Metal Detector
        if (RemovedRecipesConfig.Instance.MetalDetector)
            Recipe.Create(ItemID.MetalDetector)
                .AddIngredient(ItemID.Wire, 10)
                .AddIngredient(ItemID.SpelunkerGlowstick, 5)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Nazar
        if (RemovedRecipesConfig.Instance.Nazar)
            Recipe.Create(ItemID.Nazar)
                .AddIngredient(ItemID.SoulofNight, 5)
                .AddIngredient(ItemID.Lens, 3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Pocket Mirror
        if (RemovedRecipesConfig.Instance.PocketMirror)
            Recipe.Create(ItemID.PocketMirror)
                .AddIngredient(ItemID.Glass, 5)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 3)
                .AddIngredient(ItemID.CrystalShard, 2)
                .AddIngredient(ItemID.SoulofNight, 2)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Shoe Spikes
        if (RemovedRecipesConfig.Instance.ShoeSpikes)
            Recipe.Create(ItemID.ShoeSpikes)
                .AddRecipeGroup("IronBar", 5)
                .AddIngredient(ItemID.Spike, 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Trifold Map
        if (RemovedRecipesConfig.Instance.TrifoldMap)
            Recipe.Create(ItemID.TrifoldMap)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.SoulofLight, 3)
                .AddIngredient(ItemID.SoulofNight, 3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
