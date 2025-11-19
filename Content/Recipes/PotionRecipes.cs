using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class PotionRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Ammo Reservation Potion - BloodOrb.cs
			
			// Archery Potion - BloodOrb.cs
			
			// Battle Potion - BloodOrb.cs
			
			// Biome Sight Potion - BloodOrb.cs
			
			// Builder Potion - BloodOrb.cs
			
			// Calming Potion - BloodOrb.cs
			
			// Crate Potion - BloodOrb.cs
			
			// Dangersense Potion - BloodOrb.cs
			
			// Endurance Potion - BloodOrb.cs
			
			// Featherfall Potion - BloodOrb.cs
			
			// Fishing Potion - BloodOrb.cs
			
			// Flipper Potion - BloodOrb.cs
			
			// Gender Change Potion - BloodOrb.cs
			
			// Gills Potion - BloodOrb.cs
			
			// Gravitation Potion - BloodOrb.cs
			
			// Greater Luck Potion - BloodOrb.cs
			
			// Heartreach Potion - BloodOrb.cs
			
			// Hunter Potion - BloodOrb.cs
			
			// Inferno Potion - BloodOrb.cs
			
			// Invisibility Potion - BloodOrb.cs
			
			// Ironskin Potion - BloodOrb.cs
			
			// Lesser Luck Potion - BloodOrb.cs
			
			// Lifeforce Potion - BloodOrb.cs
			
			// Love Potion - BloodOrb.cs
			
			// Luck Potion - BloodOrb.cs
			
			// Magic Power Potion - BloodOrb.cs
			
			// Mana Regeneration Potion - BloodOrb.cs
			
			// Mining Potion - BloodOrb.cs
			
			// Night Owl Potion - BloodOrb.cs
			
			// Obsidian Skin Potion - BloodOrb.cs
			
			// Potion of Return - BloodOrb.cs
			
			// Rage Potion - BloodOrb.cs
			
			// Recall Potion - BloodOrb.cs
			
			// Regeneration Potion - BloodOrb.cs
			
			// Shine Potion - BloodOrb.cs
			
			// Sonar Potion - BloodOrb.cs
			
			// Spelunker Potion - BloodOrb.cs
			
			// Stink Potion - BloodOrb.cs
			
			// Summoning Potion - BloodOrb.cs
			
			// Swiftness Potion - BloodOrb.cs
			
			// Teleportation Potion - BloodOrb.cs
			
			// Thorns Potion - BloodOrb.cs
			
			// Titan Potion - BloodOrb.cs
			
			// Warmth Potion - BloodOrb.cs
			
			// Water Walking Potion - BloodOrb.cs
			
			// Wormhole Potion - BloodOrb.cs
			
			// Wrath Potion - BloodOrb.cs
			
			// Banana Split
			Recipe.Create(ItemID.BananaSplit)
				.AddIngredient(ItemID.Banana)
				.AddIngredient(ItemID.IceBlock)
				.AddIngredient(ItemID.MilkCarton)
				.AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();
			
			// Bowl of Soup #
			
			// Carton of Milk
			Recipe.Create(ItemID.MilkCarton)
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient(ItemID.Bone, 2)
				.AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();
			
			// Cooked Fish #
			
			// Cooked Shrimp #
			
			// Nachos
			Recipe.Create(ItemID.Nachos)
				.AddIngredient(ItemID.PotatoChips)
				.AddIngredient(ItemID.MilkCarton)
				.AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();
			
			// Seafood Dinner #
			
			// Apple Pie
			Recipe.Create(ItemID.ApplePie)
				.AddIngredient(ItemID.Apple, 3)
				.AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();
			
			// Bacon #
			
			// BBQ Ribs
			Recipe.Create(ItemID.BBQRibs)
				.AddIngredient(ItemID.FleshBlock, 6)
				.AddIngredient(ItemID.Bone, 6)
				.AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();

			// Teleportation Potion #
			/*
			Recipe.Create(ItemID.TeleportationPotion, 5)
				.AddIngredient(ItemID.BottledWater, 5)
				.AddIngredient(ItemID.ChaosFish)
				.AddIngredient(ItemID.Fireblossom)
				.AddTile(TileID.Bottles)
				.Regi/ster();
			*/

			// Sashimi #

			// Milkshake
			Recipe.Create(ItemID.Milkshake)
				.AddIngredient(ItemID.IceBlock)
				.AddIngredient(ItemID.MilkCarton)
				.AddTile(TileID.IceMachine)
				.DisableDecraft()
				.Register();
        }
    }
}