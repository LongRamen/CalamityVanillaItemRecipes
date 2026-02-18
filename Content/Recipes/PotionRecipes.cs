using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class PotionRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Removed

        // Apple Pie
        if (RemovedRecipesConfig.Instance.ApplePie)
            Recipe.Create(ItemID.ApplePie)
                .AddIngredient(ItemID.Apple, 3)
                .AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();

        // Banana Split
        if (RemovedRecipesConfig.Instance.BananaSplit)
            Recipe.Create(ItemID.BananaSplit)
                .AddIngredient(ItemID.Banana)
                .AddIngredient(ItemID.IceBlock)
                .AddIngredient(ItemID.MilkCarton)
                .AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();

        // BBQ Ribs
        if (RemovedRecipesConfig.Instance.BBQRibs)
            Recipe.Create(ItemID.BBQRibs)
                .AddIngredient(ItemID.FleshBlock, 6)
                .AddIngredient(ItemID.Bone, 6)
                .AddTile(TileID.Hellforge)
                .DisableDecraft()
                .Register();

        // Carton of Milk
        if (RemovedRecipesConfig.Instance.CartonOfMilk)
            Recipe.Create(ItemID.MilkCarton)
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Bone, 2)
                .AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();

        // Milkshake
        if (RemovedRecipesConfig.Instance.Milkshake)
            Recipe.Create(ItemID.Milkshake)
                .AddIngredient(ItemID.IceBlock)
                .AddIngredient(ItemID.MilkCarton)
                .AddTile(TileID.IceMachine)
                .DisableDecraft()
                .Register();

        // Nachos
        if (RemovedRecipesConfig.Instance.Nachos)
            Recipe.Create(ItemID.Nachos)
                .AddIngredient(ItemID.PotatoChips)
                .AddIngredient(ItemID.MilkCarton)
                .AddTile(TileID.CookingPots)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
