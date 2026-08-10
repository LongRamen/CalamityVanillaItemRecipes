using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;

namespace CalamityVanillaItemRecipes.Content.Items;

public class EssenceofEleum : GlowmaskItem
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.ItemNoGravity[Item.type] = true;
    }

    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 4, 0);
        Item.rare = ItemRarityID.LightRed;
        Item.maxStack = 9999;
        Item.width = 28;
        Item.height = 24;
    }

    public override void AddRecipes()
    {
        #region Removed

        // Frozen Turtle Shell
        if (MainConfig.Instance.FrozenTurtleShell)
            Recipe.Create(ItemID.FrozenTurtleShell)
                .AddIngredient(ItemID.TurtleShell, 2)
                .AddIngredient<EssenceofEleum>(4)
                .AddTile(TileID.IceMachine)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
