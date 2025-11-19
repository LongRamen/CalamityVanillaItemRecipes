using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class ArmorRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Phraraoh's Mask
			Recipe.Create(ItemID.PharaohsMask)
				.AddIngredient(ItemID.AncientCloth, 3)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Pharaoh's Robe
			Recipe.Create(ItemID.PharaohsRobe)
				.AddIngredient(ItemID.AncientCloth, 4)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Snow Coat
			Recipe.Create(ItemID.EskimoCoat)
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.Leather, 4)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Snow Hood
			Recipe.Create(ItemID.EskimoHood)
				.AddIngredient(ItemID.Silk, 4)
				.AddIngredient(ItemID.Leather, 2)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Snow Pants
			Recipe.Create(ItemID.EskimoPants)
				.AddIngredient(ItemID.Silk, 6)
				.AddIngredient(ItemID.Leather, 3)
				.AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();
			
			// Wandering Jingasa #
			
			// Phraraoh's Mask # ?
			
			// Phraraoh's Robe # ?
        }
    }
}