using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class AmmoRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Rocket I
        if (CurrentRecipesConfig.Instance.RocketI)
            Recipe.Create(ItemID.RocketI, 100)
                .AddRecipeGroup("IronBar")
                .AddIngredient(ItemID.EmptyBullet, 100)
                .AddIngredient(ItemID.ExplosivePowder, 4)
                .AddTile(TileID.Anvils)
                .Register();

        // Rocket II
        if (CurrentRecipesConfig.Instance.RocketII)
            Recipe.Create(ItemID.RocketII, 100)
                .AddRecipeGroup("IronBar")
                .AddIngredient(ItemID.EmptyBullet, 100)
                .AddIngredient(ItemID.ExplosivePowder, 5)
                .AddTile(TileID.Anvils)
                .Register();

        #endregion
    }
}
