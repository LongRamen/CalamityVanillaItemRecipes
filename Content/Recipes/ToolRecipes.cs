using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class ToolRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Demon Conch - DemonicBoneAsh.cs
			
			// Bug Net
			Recipe.Create(ItemID.BugNet)
				.AddIngredient(ItemID.Cobweb, 30)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Desert Minecart
			Recipe.Create(ItemID.DesertMinecart)
				.AddIngredient(ItemID.SandstoneBrick, 20)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 6)
				.AddRecipeGroup("IronBar", 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Encumbering Stone
			Recipe.Create(ItemID.EncumberingStone)
				.AddIngredient(ItemID.StoneBlock, 100)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Magic Conch
			Recipe.Create(ItemID.MagicConch)
				.AddIngredient(ItemID.ShellPileBlock, 20)
				.AddIngredient(ItemID.WhitePearl)
				.AddTile(TileID.Anvils)
				.Register();
			
			// Money Trough - BloodOrb.cs
			
			// Shadow Key
			Recipe.Create(ItemID.ShadowKey)
				.AddIngredient(ItemID.GoldenKey)
				.AddIngredient(ItemID.Obsidian, 10)
				.AddIngredient(ItemID.Bone, 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Leaf Wand
			Recipe.Create(ItemID.LeafWand)
				.AddIngredient(ItemID.Wood, 10)
				.AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();
			
			// Living Mahogany Wand
			Recipe.Create(ItemID.LivingMahoganyWand)
				.AddIngredient(ItemID.RichMahogany, 10)
				.AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();
			
			// Living Wood Wand
			Recipe.Create(ItemID.LivingWoodWand)
				.AddIngredient(ItemID.Wood, 10)
				.AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();
			
			// Rich Mahogany Leaf Wand
			Recipe.Create(ItemID.LivingMahoganyLeafWand)
				.AddIngredient(ItemID.RichMahogany, 10)
				.AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();
			
			// Umbrella
			Recipe.Create(ItemID.Umbrella)
				.AddIngredient(ItemID.Silk, 5)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 2)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Amber Hook # ?
			
			// Tendon Hook
			Recipe.Create(ItemID.TendonHook)
				.AddIngredient(ItemID.WormHook)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Worm Hook
			Recipe.Create(ItemID.WormHook)
				.AddIngredient(ItemID.TendonHook)
				.AddTile(TileID.TinkerersWorkbench)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Staff of Regrowth
			Recipe.Create(ItemID.StaffofRegrowth)
				.AddIngredient(ItemID.RichMahogany, 10)
				.AddIngredient(ItemID.JungleSpores, 5)
				.AddIngredient(ItemID.JungleRose)
				.AddTile(TileID.WorkBenches)
                .DisableDecraft()
                .Register();
        }
    }
}