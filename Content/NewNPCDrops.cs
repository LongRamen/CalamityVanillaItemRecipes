using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content;

public class NewNPCDrops : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        LeadingConditionRule postEoC = new(Condition.DownedEyeOfCthulhu.ToDropCondition(ShowItemDropInUI.Always));
        npcLoot.Add(postEoC);

        if (MainConfig.Instance.AncientBoneDust_Obtainable)
        {
            // Ancient Bone Dust - Skeleton, Armored Skeleton, Skeleton Archer, Spore Skeleton, Hoplite
            if (System.Array.IndexOf([NPCID.Skeleton, NPCID.ArmoredSkeleton, NPCID.SkeletonArcher, NPCID.SporeSkeleton, NPCID.GreekSkeleton], npc.type) > -1)
            {
                npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Items.AncientBoneDust>(), 5, 3));
            }
        }

        if (MainConfig.Instance.BloodOrb_Obtainable)
        {
            // Blood Orb - Blood Zombie, Drippler, The Bride, The Groom, Maggot Zombie, Clown, Wandering Eye Fish, Zombie Merman, Blood Eel, Hemogoblin Shark, Dreadnautilus
            if (npc.type == NPCID.BloodZombie || npc.type == NPCID.Drippler)
            {
                postEoC.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 4));
            }

            else if (npc.type == NPCID.MaggotZombie)
            {
                postEoC.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 5));
            }

            else if (npc.type == NPCID.TheBride || npc.type == NPCID.TheGroom)
            {
                postEoC.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 1, 3, 6));
            }

            else if (npc.type == NPCID.Clown)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 1, 6, 12));
            }

            else if (npc.type == NPCID.EyeballFlyingFish || npc.type == NPCID.ZombieMerman)
            {
                postEoC.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 1, 10, 12));
            }

            else if (npc.type == NPCID.BloodEelHead || npc.type == NPCID.GoblinShark)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 1, 40, 48));
            }

            else if (npc.type == NPCID.BloodNautilus)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.BloodOrb>(), 1, 100, 120));
            }
        }

        if (MainConfig.Instance.EssenceOfEleum_Obtainable)
        {
            // Essence of Eleum - Ice Elemental, Ice Tortoise, Icy Merman, Wolf, Ice Golem, Mister Stabby, Snow Balla, Snowman Gangsta
            if (System.Array.IndexOf([NPCID.IceElemental, NPCID.IceTortoise, NPCID.IcyMerman, NPCID.Wolf], npc.type) > -1)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.EssenceofEleum>()));
            }
            else if (npc.type == NPCID.IceGolem)
            {
                npcLoot.Add(new DropBasedOnExpertMode(ItemDropRule.Common(ModContent.ItemType<Items.EssenceofEleum>(), 1, 8, 10),
                                                      ItemDropRule.Common(ModContent.ItemType<Items.EssenceofEleum>(), 1, 10, 12)));
            }
            else if (System.Array.IndexOf([NPCID.MisterStabby, NPCID.SnowBalla, NPCID.SnowmanGangsta], npc.type) > -1)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.EssenceofEleum>(), 5));
            }
        }
    }
}
