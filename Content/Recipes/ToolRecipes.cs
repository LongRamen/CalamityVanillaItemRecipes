using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class ToolRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Encumbering Stone
        if (CurrentRecipesConfig.Instance.EncumberingStone)
            Recipe.Create(ItemID.EncumberingStone)
                .AddRecipeGroup(nameof(ItemID.StoneBlock), 100)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // Magic Conch
        if (CurrentRecipesConfig.Instance.MagicConch)
            Recipe.Create(ItemID.MagicConch)
                .AddIngredient(ItemID.ShellPileBlock, 20)
                .AddIngredient(ItemID.WhitePearl)
                .AddTile(TileID.Anvils)
                .Register();

        // Umbrella
        if (CurrentRecipesConfig.Instance.Umbrella)
            Recipe.Create(ItemID.Umbrella)
                .AddIngredient(ItemID.Silk, 5)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 2)
                .AddTile(TileID.Loom)
                //.DisableDecraft()
                .Register();

        // Tendon Hook
        if (CurrentRecipesConfig.Instance.TendonHook)
            Recipe.Create(ItemID.TendonHook)
                .AddIngredient(ItemID.WormHook)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Worm Hook
        if (CurrentRecipesConfig.Instance.WormHook)
            Recipe.Create(ItemID.WormHook)
                .AddIngredient(ItemID.TendonHook)
                .AddTile(TileID.TinkerersWorkbench)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        #endregion


        #region Removed

        // Bug Net
        if (RemovedRecipesConfig.Instance.BugNet)
            Recipe.Create(ItemID.BugNet)
                .AddIngredient(ItemID.Cobweb, 30)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Desert Minecart
        if (RemovedRecipesConfig.Instance.DesertMinecart)
            Recipe.Create(ItemID.DesertMinecart)
                .AddIngredient(ItemID.SandstoneBrick, 20)
                .AddRecipeGroup(nameof(ItemID.GoldBar), 6)
                .AddRecipeGroup("IronBar", 3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Leaf Wand
        if (RemovedRecipesConfig.Instance.LeafWand)
            Recipe.Create(ItemID.LeafWand)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();

        // Living Mahogany Wand
        if (RemovedRecipesConfig.Instance.LivingMahoganyWand)
            Recipe.Create(ItemID.LivingMahoganyWand)
                .AddIngredient(ItemID.RichMahogany, 10)
                .AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();

        // Living Wood Wand
        if (RemovedRecipesConfig.Instance.LivingWoodWand)
            Recipe.Create(ItemID.LivingWoodWand)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();

        // Rich Mahogany Leaf Wand
        if (RemovedRecipesConfig.Instance.RichMahoganyLeafWand)
            Recipe.Create(ItemID.LivingMahoganyLeafWand)
                .AddIngredient(ItemID.RichMahogany, 10)
                .AddTile(TileID.LivingLoom)
                .DisableDecraft()
                .Register();

        // Shadow Key
        if (RemovedRecipesConfig.Instance.ShadowKey)
            Recipe.Create(ItemID.ShadowKey)
                .AddIngredient(ItemID.GoldenKey)
                .AddIngredient(ItemID.Obsidian, 10)
                .AddIngredient(ItemID.Bone, 5)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Staff of Regrowth
        if (RemovedRecipesConfig.Instance.StaffOfRegrowth)
            Recipe.Create(ItemID.StaffofRegrowth)
                .AddIngredient(ItemID.RichMahogany, 10)
                .AddIngredient(ItemID.JungleSpores, 5)
                .AddIngredient(ItemID.JungleRose)
                .AddTile(TileID.WorkBenches)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
