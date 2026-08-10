using Terraria;
using Terraria.ID;

namespace CalamityVanillaItemRecipes.Content.Items;

public class EssenceofSunlight : GlowmaskItem // DEPRECATED
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.ItemNoGravity[Item.type] = true;
    }

    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 40, 0);
        Item.rare = ItemRarityID.LightRed;
        Item.maxStack = 9999;
        Item.width = 28;
        Item.height = 22;
    }
}
