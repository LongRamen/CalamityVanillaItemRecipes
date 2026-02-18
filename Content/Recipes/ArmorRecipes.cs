using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class ArmorRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Snow Coat
        if (CurrentRecipesConfig.Instance.SnowCoat)
            Recipe.Create(ItemID.EskimoCoat)
                .AddIngredient(ItemID.Silk, 8)
                .AddIngredient(ItemID.FlinxFur, 2)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Snow Hood
        if (CurrentRecipesConfig.Instance.SnowHood)
            Recipe.Create(ItemID.EskimoHood)
                .AddIngredient(ItemID.Silk, 4)
                .AddIngredient(ItemID.FlinxFur)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Snow Pants
        if (CurrentRecipesConfig.Instance.SnowPants)
            Recipe.Create(ItemID.EskimoPants)
                .AddIngredient(ItemID.Silk, 6)
                .AddIngredient(ItemID.FlinxFur)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        #endregion


        #region Removed

        // Pharaoh's Mask - removed in 2.0.7 but include anyway
        if (RemovedRecipesConfig.Instance.PharaohsMask)
            Recipe.Create(ItemID.PharaohsMask)
                .AddIngredient(ItemID.AncientCloth, 3)
                .AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();

        // Pharaoh's Robe - removed in 2.0.7 but include anyway
        if (RemovedRecipesConfig.Instance.PharaohsRobe)
            Recipe.Create(ItemID.PharaohsRobe)
                .AddIngredient(ItemID.AncientCloth, 4)
                .AddTile(TileID.Loom)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
