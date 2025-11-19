using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class PlaceableRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Target Dummy #
			
			// Bowl #
			
			// Clay Pot #
			
			// Glass #
			
			// Pink Vase #
			
			// Plate #
			
			// Teapot #
			
			// Golden Cross Grave Marker
			Recipe.Create(ItemID.RichGravestone1)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddRecipeGroup(nameof(ItemID.GoldBar))
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Golden Grave Marker
			Recipe.Create(ItemID.RichGravestone3)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddRecipeGroup(nameof(ItemID.GoldBar))
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Golden Gravestone
			Recipe.Create(ItemID.RichGravestone4)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddRecipeGroup(nameof(ItemID.GoldBar))
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Golden Headstone
			Recipe.Create(ItemID.RichGravestone5)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddRecipeGroup(nameof(ItemID.GoldBar))
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Golden Tombstone
			Recipe.Create(ItemID.RichGravestone2)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddRecipeGroup(nameof(ItemID.GoldBar))
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Gravestone
			Recipe.Create(ItemID.Gravestone)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Headstone
			Recipe.Create(ItemID.Headstone)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Obelisk
			Recipe.Create(ItemID.Obelisk)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Tombstone
			Recipe.Create(ItemID.Tombstone)
				.AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
				.AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();
			
			// Bast Statue
			Recipe.Create(ItemID.CatBast)
				.AddRecipeGroup("IronBar", 7)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 3)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Ultrabright Torch #
			
			// Cross Grave Marker
			Recipe.Create(ItemID.CrossGraveMarker)
				.AddRecipeGroup("Wood", 15)
				.AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();
			
			// Grave Marker
			Recipe.Create(ItemID.GraveMarker)
				.AddRecipeGroup("Wood", 15)
				.AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();
			
			// Aether Torch #
        }
    }
}