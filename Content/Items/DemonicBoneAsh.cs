using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public class DemonicBoneAsh : ModItem // DEPRECATED
{
    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 6, 0);
        Item.rare = ItemRarityID.Orange;
        Item.maxStack = 9999;
        Item.width = 40;
        Item.height = 30;
    }
}
