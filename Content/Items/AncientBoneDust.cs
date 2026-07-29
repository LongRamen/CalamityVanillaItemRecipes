using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public class AncientBoneDust : ModItem
{
    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 0, 10);
        Item.rare = ItemRarityID.Blue;
        Item.maxStack = 9999;
        Item.width = 20;
        Item.height = 20;
    }

    public override void AddRecipes()
    {
        #region Current

        // Fledgling Wings
        if (MainConfig.Instance.FledglingWings)
            Recipe.Create(ItemID.CreativeWings)
                .AddIngredient<AncientBoneDust>(2)
                .AddIngredient(ItemID.Cloud, 5)
                .AddIngredient(ItemID.Feather, 10)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        #endregion


        #region Removed

        // Armor Polish
        if (MainConfig.Instance.ArmorPolish)
            Recipe.Create(ItemID.ArmorPolish)
                .AddIngredient(ItemID.Bone, 10)
                .AddIngredient<AncientBoneDust>(3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
