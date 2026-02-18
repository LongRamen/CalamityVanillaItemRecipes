using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class MaterialRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Removed

        // Black Lens
        if (RemovedRecipesConfig.Instance.BlackLens)
            Recipe.Create(ItemID.BlackLens)
                .AddIngredient(ItemID.Lens)
                .AddIngredient(ItemID.BlackDye)
                .AddTile(TileID.DyeVat)
                .Register();

        #endregion
    }
}
