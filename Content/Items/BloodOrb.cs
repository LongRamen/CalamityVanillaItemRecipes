using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items
{
    public class BloodOrb : ModItem
    {
		public override void SetStaticDefaults()
		{
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 4));
			ItemID.Sets.AnimatesAsSoul[Item.type] = true;
		}
		
        public override void SetDefaults()
        {
			Item.value = Item.sellPrice(0, 0, 1, 20);
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 9999;
			Item.width = 14;
			Item.height = 24;
        }
		
		public override void AddRecipes()
		{
			if (ModContent.GetInstance<Config.MainConfig>().BloodOrb_Enabled)
			{
				CreateRecipe(10)
					.AddIngredient(ItemID.BloodMoonStarter)
					.DisableDecraft()
                    .Register();

				// Vitamins
				Recipe.Create(ItemID.Vitamins)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient(ItemID.Waterleaf, 3)
					.AddIngredient(ItemID.Blinkroot, 3)
					.AddIngredient(ItemID.Daybloom, 3)
					.AddIngredient<Content.Items.BloodOrb>(5)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Bloody Tear
				Recipe.Create(ItemID.BloodMoonStarter)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddRecipeGroup(nameof(ItemID.CopperBar), 3)
					.AddTile(TileID.Anvils)
					.DisableDecraft()
                    .Register();

                ///////////////////////////////////

                // Ammo Reservation Potion
                Recipe.Create(ItemID.AmmoReservationPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();

                // Archery Potion
                Recipe.Create(ItemID.ArcheryPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Battle Potion
				Recipe.Create(ItemID.BattlePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Biome Sight Potion
				Recipe.Create(ItemID.BiomeSightPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Builder Potion
				Recipe.Create(ItemID.BuilderPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Calming Potion
				Recipe.Create(ItemID.CalmingPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Crate Potion
				Recipe.Create(ItemID.CratePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Dangersense Potion
				Recipe.Create(ItemID.TrapsightPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Endurance Potion
				Recipe.Create(ItemID.EndurancePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Featherfall Potion
				Recipe.Create(ItemID.FeatherfallPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Fishing Potion
				Recipe.Create(ItemID.FishingPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Flipper Potion
				Recipe.Create(ItemID.FlipperPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Gender Change Potion
				Recipe.Create(ItemID.GenderChangePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Gills Potion
				Recipe.Create(ItemID.GillsPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Gravitation Potion
				Recipe.Create(ItemID.GravitationPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Greater Luck Potion
				Recipe.Create(ItemID.LuckPotionGreater)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(30)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Heartreach Potion
				Recipe.Create(ItemID.HeartreachPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Hunter Potion
				Recipe.Create(ItemID.HunterPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Inferno Potion
				Recipe.Create(ItemID.InfernoPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Invisibility Potion
				Recipe.Create(ItemID.InvisibilityPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Ironskin Potion
				Recipe.Create(ItemID.IronskinPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Lesser Luck Potion
				Recipe.Create(ItemID.LuckPotionLesser)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Lifeforce Potion
				Recipe.Create(ItemID.LifeforcePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Love Potion
				Recipe.Create(ItemID.LovePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Luck Potion
				Recipe.Create(ItemID.LuckPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(20)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Magic Power Potion
				Recipe.Create(ItemID.MagicPowerPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Mana Regeneration Potion
				Recipe.Create(ItemID.ManaRegenerationPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Mining Potion
				Recipe.Create(ItemID.MiningPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Night Owl Potion
				Recipe.Create(ItemID.NightOwlPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Obsidian Skin Potion
				Recipe.Create(ItemID.ObsidianSkinPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Potion of Return
				Recipe.Create(ItemID.PotionOfReturn)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Rage Potion
				Recipe.Create(ItemID.RagePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Recall Potion ?
				Recipe.Create(ItemID.RecallPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Regeneration Potion
				Recipe.Create(ItemID.RegenerationPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Shine Potion
				Recipe.Create(ItemID.ShinePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Sonar Potion
				Recipe.Create(ItemID.SonarPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Spelunker Potion
				Recipe.Create(ItemID.SpelunkerPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Stink Potion
				Recipe.Create(ItemID.StinkPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Summoning Potion
				Recipe.Create(ItemID.SummoningPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Swiftness Potion
				Recipe.Create(ItemID.SwiftnessPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Teleportation Potion
				Recipe.Create(ItemID.TeleportationPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Thorns Potion
				Recipe.Create(ItemID.ThornsPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Titan Potion
				Recipe.Create(ItemID.TitanPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Warmth Potion
				Recipe.Create(ItemID.WarmthPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Water Walking Potion
				Recipe.Create(ItemID.WaterWalkingPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Wormhole Potion
				Recipe.Create(ItemID.WormholePotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				// Wrath Potion
				Recipe.Create(ItemID.WrathPotion)
					.AddIngredient(ItemID.BottledWater)
					.AddIngredient<Content.Items.BloodOrb>(10)
					.AddTile(TileID.AlchemyTable)
                    .DisableDecraft()
                    .Register();
				
				///////////////////////////////////
				
				// Money Trough
				Recipe.Create(ItemID.MoneyTrough)
					.AddIngredient(ItemID.PiggyBank)
					.AddIngredient(ItemID.Feather, 2)
					.AddIngredient<Content.Items.BloodOrb>()
					.AddIngredient(ItemID.GoldCoin, 15)
					.AddTile(TileID.Anvils)
					.Register();
			}
		}
    }
}