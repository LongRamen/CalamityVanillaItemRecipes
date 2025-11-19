using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class AccessoryRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Vitamins - BloodOrb.cs
			
			// Magic Quiver
			Recipe.Create(ItemID.MagicQuiver)
				.AddIngredient(ItemID.EndlessQuiver)
				.AddIngredient(ItemID.PixieDust, 5)
				.AddIngredient(ItemID.Lens, 3)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.CrystalBall)
                .DisableDecraft()
                .Register();
			
			// Guide Voodoo Doll
			Recipe.Create(ItemID.GuideVoodooDoll)
				.AddIngredient(ItemID.Leather, 2)
				.AddRecipeGroup(nameof(ItemID.VilePowder), 10)
				.AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();
			
			// Lavaproof Fishing Hook
			Recipe.Create(ItemID.LavaFishingHook)
				.AddIngredient(ItemID.Seashell)
				.AddIngredient(ItemID.HellstoneBar, 10)
				.AddTile(TileID.Hellforge)
				.Register();
			
			// Frozen Turtle Shell - EssenceofEleum.cs
			
            // Adhesive Bandage
            Recipe.Create(ItemID.AdhesiveBandage)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.Gel, 10)
                .AddIngredient(ItemID.HealingPotion)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Aglet
			Recipe.Create(ItemID.Aglet)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Anklet of the Wind
			Recipe.Create(ItemID.AnkletoftheWind)
				.AddIngredient(ItemID.JungleSpores, 15)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.PinkGel, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
				
			// Armor Polish - AncientBoneDust.cs
			
			// Band of Regeneration
			Recipe.Create(ItemID.BandofRegeneration)
				.AddIngredient(ItemID.Shackle)
				.AddIngredient(ItemID.LifeCrystal)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Bezoar - MurkyPaste.cs
			
			// Blindfold
			Recipe.Create(ItemID.Blindfold)
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.TatteredCloth)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Blizzard in a Bottle
			Recipe.Create(ItemID.BlizzardinaBottle)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.SnowBlock, 5)
				.AddIngredient(ItemID.Feather, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Celestial Magnet
			Recipe.Create(ItemID.CelestialMagnet)
				.AddIngredient(ItemID.TreasureMagnet)
				.AddIngredient(ItemID.FallenStar, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Cloud in a Bottle
			Recipe.Create(ItemID.CloudinaBottle)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.Feather, 2)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Cobalt Shield
			Recipe.Create(ItemID.CobaltShield)
				.AddRecipeGroup(nameof(ItemID.CobaltBar), 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// DPS Meter
			Recipe.Create(ItemID.DPSMeter)
				.AddIngredient(ItemID.Wire, 10)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Fast Clock
			Recipe.Create(ItemID.FastClock)
				.AddIngredient(ItemID.Timer1Second)
				.AddIngredient(ItemID.PixieDust, 5)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Feral Claws
			Recipe.Create(ItemID.FeralClaws)
				.AddIngredient(ItemID.Leather, 10)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Flame Waker Boots
			Recipe.Create(ItemID.FlameWakerBoots)
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.HellstoneBar, 5)
				.AddIngredient(ItemID.Obsidian, 4)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Fledgling Wings
			Recipe.Create(ItemID.CreativeWings)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.Feather, 10)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Flying Carpet #
			
			// Frog Leg
			Recipe.Create(ItemID.FrogLeg)
				.AddIngredient(ItemID.Frog, 6)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Ice Skates
			Recipe.Create(ItemID.IceSkates)
				.AddIngredient(ItemID.Leather, 5)
				.AddRecipeGroup("IronBar", 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Lava Charm
			Recipe.Create(ItemID.LavaCharm)
				.AddIngredient(ItemID.LavaBucket, 3)
				.AddIngredient(ItemID.Obsidian, 5)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Lucky Horseshoe
			Recipe.Create(ItemID.LuckyHorseshoe)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 8)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Megaphone
			Recipe.Create(ItemID.Megaphone)
				.AddIngredient(ItemID.Wire, 5)
				.AddRecipeGroup(nameof(ItemID.CobaltBar), 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Metal Detector
			Recipe.Create(ItemID.MetalDetector)
				.AddIngredient(ItemID.Wire, 10)
				.AddIngredient(ItemID.SpelunkerGlowstick, 5)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Nazar
			Recipe.Create(ItemID.Nazar)
				.AddIngredient(ItemID.SoulofNight, 5)
				.AddIngredient(ItemID.Lens, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Obsidian Rose
			Recipe.Create(ItemID.ObsidianRose)
				.AddIngredient(ItemID.JungleRose)
				.AddIngredient(ItemID.Obsidian, 5)
				.AddIngredient(ItemID.Hellstone, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Pocket Mirror
			Recipe.Create(ItemID.PocketMirror)
				.AddIngredient(ItemID.Glass, 5)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 3)
				.AddIngredient(ItemID.CrystalShard, 2)
				.AddIngredient(ItemID.SoulofNight, 2)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Radar
			Recipe.Create(ItemID.Radar)
				.AddRecipeGroup("IronBar", 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Sandstorm in a Bottle
			Recipe.Create(ItemID.SandstorminaBottle)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.SandBlock, 5)
				.AddIngredient(ItemID.AntlionMandible, 3)
				.AddIngredient(ItemID.Feather, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Shoe Spikes
			Recipe.Create(ItemID.ShoeSpikes)
				.AddRecipeGroup("IronBar", 5)
				.AddIngredient(ItemID.Spike, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Trifold Map
			Recipe.Create(ItemID.TrifoldMap)
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.SoulofLight, 3)
				.AddIngredient(ItemID.SoulofNight, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Water Walking Boots
			Recipe.Create(ItemID.WaterWalkingBoots)
				.AddIngredient(ItemID.Leather, 5)
				.AddIngredient(ItemID.WaterWalkingPotion, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Flower Boots
			Recipe.Create(ItemID.FlowerBoots)
				.AddIngredient(ItemID.Silk, 7)
				.AddIngredient(ItemID.JungleRose)
				.AddIngredient(ItemID.JungleGrassSeeds, 5)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Hand Warmer
			Recipe.Create(ItemID.HandWarmer)
				.AddIngredient(ItemID.Silk, 10)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Hermes Boots
			Recipe.Create(ItemID.HermesBoots)
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.SwiftnessPotion, 5)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Step Stool
			Recipe.Create(ItemID.PortableStool)
				.AddRecipeGroup("Wood", 10)
				.AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();
			
			// Flying Carpet # ?
			
			// Sandstorm in a Bottle # ?
			
			// Shiny Red Balloon
			Recipe.Create(ItemID.ShinyRedBalloon)
				.AddIngredient(ItemID.WhiteString)
				.AddIngredient(ItemID.Gel, 15)
				.AddIngredient(ItemID.Cloud, 5)
				.AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();
			
			// Avenger Emblem #
			
			// Brain of Confusion
			Recipe.Create(ItemID.BrainOfConfusion)
				.AddIngredient(ItemID.WormScarf)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Crimson Heart
			Recipe.Create(ItemID.CrimsonHeart)
				.AddIngredient(ItemID.ShadowOrb)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Flesh Knuckles
			Recipe.Create(ItemID.FleshKnuckles)
				.AddIngredient(ItemID.PutridScent)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Putrid Scent
			Recipe.Create(ItemID.PutridScent)
				.AddIngredient(ItemID.FleshKnuckles)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Shadow Orb
			Recipe.Create(ItemID.ShadowOrb)
				.AddIngredient(ItemID.CrimsonHeart)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Worm Scarf
			Recipe.Create(ItemID.WormScarf)
				.AddIngredient(ItemID.BrainOfConfusion)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Music Box
			/*
			Recipe.Create(ItemID.MusicBox)
				.AddIngredient(ItemID.Wood, 6)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 5)
				.AddRecipeGroup("IronBar", 2)
				.AddIngredient(ItemID.LifeCrystal)
				.AddTile(TileID.HeavyWorkBench)
				.Regi/ster();
			*/
        }
    }
}