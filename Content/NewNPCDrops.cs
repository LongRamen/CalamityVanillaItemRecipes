using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content
{
    public class NewNPCDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (ModContent.GetInstance<Config.MainConfig>().AncientBoneDust_Enabled)
            {
                // Ancient Bone Dust - Skeleton, Armored Skeleton, Skeleton Archer, Spore Skeleton, Hoplite
                if (System.Array.IndexOf([NPCID.Skeleton, NPCID.ArmoredSkeleton, NPCID.SkeletonArcher, NPCID.SporeSkeleton, NPCID.GreekSkeleton], npc.type) > -1)
                {
                    npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Content.Items.AncientBoneDust>(), 5, 3));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().BloodOrb_Enabled)
            {
                // Blood Orb - Blood Zombie, Drippler, The Bride, The Groom, Maggot Zombie, Clown, Wandering Eye Fish, Zombie Merman, Blood Eel, Hemogoblin Shark, Dreadnautilus
                if (npc.type == NPCID.BloodZombie || npc.type == NPCID.Drippler)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 4));
                }
                else if (System.Array.IndexOf([NPCID.TheBride, NPCID.TheGroom, NPCID.MaggotZombie], npc.type) > -1)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 10));
                }
                else if (npc.type == NPCID.Clown)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 1, 6, 12));
                }
                else if (npc.type == NPCID.EyeballFlyingFish || npc.type == NPCID.ZombieMerman)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 1, 10, 12));
                }
                else if (npc.type == NPCID.BloodEelHead || npc.type == NPCID.GoblinShark)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 1, 40, 48));
                }
                else if (npc.type == NPCID.BloodNautilus)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.BloodOrb>(), 1, 100, 120));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().DemonicBoneAsh_Enabled)
            {
                // Demonic Bone Ash - Demon, Voodoo Demon, Red Devil, Bone Serpent
                if (System.Array.IndexOf([NPCID.Demon, NPCID.VoodooDemon, NPCID.RedDevil, NPCID.BoneSerpentHead], npc.type) > -1)
                {
                    npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Content.Items.DemonicBoneAsh>(), 3, 2));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().EssenceofEleum_Enabled)
            {
                // Essence of Eleum - Ice Elemental, Ice Tortoise, Icy Merman, Wolf, Ice Golem, Mister Stabby, Snow Balla, Snowman Gangsta
                if (System.Array.IndexOf([NPCID.IceElemental, NPCID.IceTortoise, NPCID.IcyMerman, NPCID.Wolf], npc.type) > -1)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofEleum>()));
                }
                else if (npc.type == NPCID.IceGolem)
                {
                    npcLoot.Add(new DropBasedOnExpertMode(ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofEleum>(), 1, 8, 10),
                                                          ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofEleum>(), 1, 10, 12)));
                }
                else if (System.Array.IndexOf([NPCID.MisterStabby, NPCID.SnowBalla, NPCID.SnowmanGangsta], npc.type) > -1)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofEleum>(), 5));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().Essence_CoreofSunlight_Enabled)
            {
                // Essence of Sunlight - Harpy(in Hardmode), Wyvern, Angry Nimbus, Golem
                if (npc.type == NPCID.Harpy)
                {
                    npcLoot.Add(ItemDropRule.ByCondition(new Conditions.IsHardmode(), ModContent.ItemType<Content.Items.EssenceofSunlight>(), 2));
                }
                else if (npc.type == NPCID.WyvernHead)
                {
                    npcLoot.Add(new DropBasedOnExpertMode(ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofSunlight>(), 1, 8, 10),
                                                          ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofSunlight>(), 1, 10, 12)));
                }
                else if (npc.type == NPCID.AngryNimbus)
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.EssenceofSunlight>(), 2));
                }
                else if (npc.type == NPCID.Golem)
                {
                    npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotExpert(), ModContent.ItemType<Content.Items.EssenceofSunlight>(), 1, 8, 10));
                }
            }

            if (ModContent.GetInstance<Config.MainConfig>().MurkyPaste_Enabled)
            {
                // Murky Paste - Arapaima, Spiked Jungle Slime
                if (npc.type == NPCID.Arapaima || npc.type == NPCID.SpikedJungleSlime)
                {
                    npcLoot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<Content.Items.MurkyPaste>(), 4, 3));
                }
            }
        }
    }
}