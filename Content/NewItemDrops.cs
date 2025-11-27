using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content
{
    public class NewItemDrops : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            /* - Removed in Calamity v2.0.7
             * 
            if (ModContent.GetInstance<Config.MainConfig>().AncientBoneDust_Enabled)
            {
                // Ancient Bone Dust - Iron Crate, Mythril Crate
                if (item.type == ItemID.IronCrate || item.type == ItemID.IronCrateHard)
                {
                    itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.AncientBoneDust>(), 4, 5, 8));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().EssenceofEleum_Enabled)
            {
                // Essence of Eleum - Frozen Crate, Boreal Crate
                if (item.type == ItemID.FrozenCrate || item.type == ItemID.FrozenCrateHard)
                {
                    itemLoot.Add(ItemDropRule.ByCondition(new Conditions.IsHardmode(), ModContent.ItemType<Content.Items.EssenceofEleum>(), 5, 2, 4));
                }
            }
            */

            if (ModContent.GetInstance<Config.MainConfig>().Essence_CoreofSunlight_Enabled)
            {
                // Essence of Sunlight - Treasure Bag (Golem), [[REMOVED: Sky Crate, Azure Crate]]

                /* - Removed in Calamity v2.0.7
                if (item.type == ItemID.FloatingIslandFishingCrate || item.type == ItemID.FloatingIslandFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.ByCondition(new Conditions.IsHardmode(), ModContent.ItemType<Content.Items.EssenceofSunlight>(), 5, 2, 4));
                }
                else */if (item.type == ItemID.GolemBossBag)
                {
                    itemLoot.Add(ItemDropRule.ByCondition(new Conditions.IsExpert(), ModContent.ItemType<Content.Items.EssenceofSunlight>(), 1, 10, 12));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().MurkyPaste_Enabled)
            {
                // Murky Paste - Jungle Crate, Bramble Crate
                if (item.type == ItemID.JungleFishingCrate || item.type == ItemID.JungleFishingCrateHard)
                {
                    itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.MurkyPaste>(), 5, 1, 3));
                }
            }
        }
    }
}