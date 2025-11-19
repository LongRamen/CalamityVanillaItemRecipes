using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class CraftingStationRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Ice Machine
			Recipe.Create(ItemID.IceMachine)
				.AddRecipeGroup(nameof(ItemID.IceBlock), 10)
				.AddIngredient(ItemID.SnowBlock, 5)
				.AddRecipeGroup("IronBar", 5)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Sky Mill
			Recipe.Create(ItemID.SkyMill)
				.AddIngredient(ItemID.SunplateBlock, 10)
				.AddIngredient(ItemID.Cloud, 5)
				.AddIngredient(ItemID.RainCloud, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Living Loom
			Recipe.Create(ItemID.LivingLoom)
				.AddIngredient(ItemID.Loom)
				.AddIngredient(ItemID.Vine, 2)
				.AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();
        }
    }
}