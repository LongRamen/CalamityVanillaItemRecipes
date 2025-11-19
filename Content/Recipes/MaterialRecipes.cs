using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class MaterialRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Black Lens
			Recipe.Create(ItemID.BlackLens)
				.AddIngredient(ItemID.Lens)
				.AddIngredient(ItemID.BlackDye)
				.AddTile(TileID.DyeVat)
				.Register();
			
			// Fallen Star #
			
			// Luminite #
			
			// Wood #
			
			// Leather # ?
        }
    }
}