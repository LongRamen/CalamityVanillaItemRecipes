using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public class MurkyPaste : ModItem // DEPRECATED
{
    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 2, 0);
        Item.rare = ItemRarityID.Blue;
        Item.maxStack = Item.CommonMaxStack;
        Item.width = 20;
        Item.height = 28;
    }
}
