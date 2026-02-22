using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content;

public class NewItemDrops : GlobalItem
{
    public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
    {
        if (ModContent.GetInstance<MainConfig>().EssenceOfEleum_Obtainable)
        {
            // Essence of Eleum - Boreal Crate
            if (item.type == ItemID.FrozenCrateHard)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.EssenceofEleum>(), 2, 2, 5));
            }
        }
    }
}
