using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class PlaceableRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Bast Statue
        if (CurrentRecipesConfig.Instance.BastStatue)
            Recipe.Create(ItemID.CatBast)
                .AddRecipeGroup("IronBar", 7)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 3)
                .AddIngredient(ItemID.Ruby)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Cross Grave Marker
        if (CurrentRecipesConfig.Instance.CrossGraveMarker)
            Recipe.Create(ItemID.CrossGraveMarker)
                .AddRecipeGroup("Wood", 15)
                .AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();

        // Golden Cross Grave Marker
        if (CurrentRecipesConfig.Instance.GoldenCrossGraveMarker)
            Recipe.Create(ItemID.RichGravestone1)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddRecipeGroup(nameof(ItemID.GoldBar))
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Golden Grave Marker
        if (CurrentRecipesConfig.Instance.GoldenGraveMarker)
            Recipe.Create(ItemID.RichGravestone3)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddRecipeGroup(nameof(ItemID.GoldBar))
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Golden Gravestone
        if (CurrentRecipesConfig.Instance.GoldenGravestone)
            Recipe.Create(ItemID.RichGravestone4)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddRecipeGroup(nameof(ItemID.GoldBar))
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Golden Headstone
        if (CurrentRecipesConfig.Instance.GoldenHeadstone)
            Recipe.Create(ItemID.RichGravestone5)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddRecipeGroup(nameof(ItemID.GoldBar))
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Golden Tombstone
        if (CurrentRecipesConfig.Instance.GoldenTombstone)
            Recipe.Create(ItemID.RichGravestone2)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddRecipeGroup(nameof(ItemID.GoldBar))
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Grave Marker
        if (CurrentRecipesConfig.Instance.GraveMarker)
            Recipe.Create(ItemID.GraveMarker)
                .AddRecipeGroup("Wood", 15)
                .AddTile(TileID.Sawmill)
                .DisableDecraft()
                .Register();

        // Gravestone
        if (CurrentRecipesConfig.Instance.Gravestone)
            Recipe.Create(ItemID.Gravestone)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Headstone
        if (CurrentRecipesConfig.Instance.Headstone)
            Recipe.Create(ItemID.Headstone)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Obelisk
        if (CurrentRecipesConfig.Instance.Obelisk)
            Recipe.Create(ItemID.Obelisk)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        // Tombstone
        if (CurrentRecipesConfig.Instance.Tombstone)
            Recipe.Create(ItemID.Tombstone)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 15)
                .AddTile(TileID.HeavyWorkBench)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
