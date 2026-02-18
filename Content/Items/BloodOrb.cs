using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public class BloodOrb : ModItem
{
    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 4));
        ItemID.Sets.AnimatesAsSoul[Item.type] = true;
    }
    
    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 0, 40);
        Item.rare = ItemRarityID.Green;
        Item.maxStack = 9999;
        Item.width = 14;
        Item.height = 24;
    }
    
    public override void AddRecipes()
    {
        #region Current

        // Bloody Tear
        if (MainConfig.Instance.BloodyTear)
            Recipe.Create(ItemID.BloodMoonStarter)
                .AddIngredient<BloodOrb>(10)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 3)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Money Trough
        if (MainConfig.Instance.MoneyTrough)
            Recipe.Create(ItemID.MoneyTrough)
                .AddIngredient(ItemID.PiggyBank)
                .AddIngredient(ItemID.Feather, 2)
                .AddIngredient<BloodOrb>()
                .AddIngredient(ItemID.GoldCoin, 15)
                .AddTile(TileID.Anvils)
                .Register();

        #endregion


        #region Removed

        // Bloody Tear -> 10 Blood Orbs
        if (MainConfig.Instance.BloodOrb_Recipe)
            CreateRecipe(10)
                .AddIngredient(ItemID.BloodMoonStarter)
                .DisableDecraft()
                .Register();

        // Vitamins
        if (MainConfig.Instance.Vitamins)
            Recipe.Create(ItemID.Vitamins)
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Waterleaf, 3)
                .AddIngredient(ItemID.Blinkroot, 3)
                .AddIngredient(ItemID.Daybloom, 3)
                .AddIngredient<BloodOrb>(5)
                .AddTile(TileID.AlchemyTable)
                .DisableDecraft()
                .Register();

        #endregion


        #region Potions

        // Ammo Reservation Potion
        if (MainConfig.Instance.AmmoReservationPotion)
            Recipe.Create(ItemID.AmmoReservationPotion)
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient<BloodOrb>(5)
                .AddTile(TileID.AlchemyTable)
                .DisableDecraft()
                .Register();

        // Archery Potion
        if (MainConfig.Instance.ArcheryPotion)
            Recipe.Create(ItemID.ArcheryPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Battle Potion
        if (MainConfig.Instance.BattlePotion)
            Recipe.Create(ItemID.BattlePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Biome Sight Potion
        if (MainConfig.Instance.BiomeSightPotion)
            Recipe.Create(ItemID.BiomeSightPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Builder Potion
        if (MainConfig.Instance.BuilderPotion)
            Recipe.Create(ItemID.BuilderPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Calming Potion
        if (MainConfig.Instance.CalmingPotion)
            Recipe.Create(ItemID.CalmingPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Crate Potion
        if (MainConfig.Instance.CratePotion)
            Recipe.Create(ItemID.CratePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Dangersense Potion
        if (MainConfig.Instance.DangersensePotion)
            Recipe.Create(ItemID.TrapsightPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Endurance Potion
        if (MainConfig.Instance.EndurancePotion)
            Recipe.Create(ItemID.EndurancePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Featherfall Potion
        if (MainConfig.Instance.FeatherfallPotion)
            Recipe.Create(ItemID.FeatherfallPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Fishing Potion
        if (MainConfig.Instance.FishingPotion)
            Recipe.Create(ItemID.FishingPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Flipper Potion
        if (MainConfig.Instance.FlipperPotion)
            Recipe.Create(ItemID.FlipperPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Gender Change Potion
        if (MainConfig.Instance.GenderChangePotion)
            Recipe.Create(ItemID.GenderChangePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Gills Potion
        if (MainConfig.Instance.GillsPotion)
            Recipe.Create(ItemID.GillsPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Gravitation Potion
        if (MainConfig.Instance.GravitationPotion)
            Recipe.Create(ItemID.GravitationPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Greater Luck Potion
        if (MainConfig.Instance.GreaterLuckPotion)
            Recipe.Create(ItemID.LuckPotionGreater)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Heartreach Potion
        if (MainConfig.Instance.HeartreachPotion)
            Recipe.Create(ItemID.HeartreachPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Hunter Potion
        if (MainConfig.Instance.HunterPotion)
            Recipe.Create(ItemID.HunterPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Inferno Potion
        if (MainConfig.Instance.InfernoPotion)
            Recipe.Create(ItemID.InfernoPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Invisibility Potion
        if (MainConfig.Instance.InvisibilityPotion)
            Recipe.Create(ItemID.InvisibilityPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Ironskin Potion
        if (MainConfig.Instance.IronskinPotion)
            Recipe.Create(ItemID.IronskinPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Lesser Luck Potion
        if (MainConfig.Instance.LesserLuckPotion)
            Recipe.Create(ItemID.LuckPotionLesser)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Lifeforce Potion
        if (MainConfig.Instance.LifeforcePotion)
            Recipe.Create(ItemID.LifeforcePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Love Potion
        if (MainConfig.Instance.LovePotion)
            Recipe.Create(ItemID.LovePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Luck Potion
        if (MainConfig.Instance.LuckPotion)
            Recipe.Create(ItemID.LuckPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Magic Power Potion
        if (MainConfig.Instance.MagicPowerPotion)
            Recipe.Create(ItemID.MagicPowerPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Mana Regeneration Potion
        if (MainConfig.Instance.ManaRegenerationPotion)
            Recipe.Create(ItemID.ManaRegenerationPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Mining Potion
        if (MainConfig.Instance.MiningPotion)
            Recipe.Create(ItemID.MiningPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Night Owl Potion
        if (MainConfig.Instance.NightOwlPotion)
            Recipe.Create(ItemID.NightOwlPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Obsidian Skin Potion
        if (MainConfig.Instance.ObsidianSkinPotion)
            Recipe.Create(ItemID.ObsidianSkinPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Potion of Return
        if (MainConfig.Instance.PotionOfReturn)
            Recipe.Create(ItemID.PotionOfReturn)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Rage Potion
        if (MainConfig.Instance.RagePotion)
            Recipe.Create(ItemID.RagePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Recall Potion
        if (MainConfig.Instance.RecallPotion)
            Recipe.Create(ItemID.RecallPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Regeneration Potion
        if (MainConfig.Instance.RegenerationPotion)
            Recipe.Create(ItemID.RegenerationPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Shine Potion
        if (MainConfig.Instance.ShinePotion)
            Recipe.Create(ItemID.ShinePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Sonar Potion
        if (MainConfig.Instance.SonarPotion)
            Recipe.Create(ItemID.SonarPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Spelunker Potion
        if (MainConfig.Instance.SpelunkerPotion)
            Recipe.Create(ItemID.SpelunkerPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Stink Potion
        if (MainConfig.Instance.StinkPotion)
            Recipe.Create(ItemID.StinkPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Summoning Potion
        if (MainConfig.Instance.SummoningPotion)
            Recipe.Create(ItemID.SummoningPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Swiftness Potion
        if (MainConfig.Instance.SwiftnessPotion)
            Recipe.Create(ItemID.SwiftnessPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Teleportation Potion
        if (MainConfig.Instance.TeleportationPotion)
            Recipe.Create(ItemID.TeleportationPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Thorns Potion
        if (MainConfig.Instance.ThornsPotion)
            Recipe.Create(ItemID.ThornsPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Titan Potion
        if (MainConfig.Instance.TitanPotion)
            Recipe.Create(ItemID.TitanPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Warmth Potion
        if (MainConfig.Instance.WarmthPotion)
            Recipe.Create(ItemID.WarmthPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(10)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Water Walking Potion
        if (MainConfig.Instance.WaterWalkingPotion)
            Recipe.Create(ItemID.WaterWalkingPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Wormhole Potion
        if (MainConfig.Instance.WormholePotion)
            Recipe.Create(ItemID.WormholePotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(5)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        // Wrath Potion
        if (MainConfig.Instance.WrathPotion)
            Recipe.Create(ItemID.WrathPotion)
            .AddIngredient(ItemID.BottledWater)
            .AddIngredient<BloodOrb>(15)
            .AddTile(TileID.AlchemyTable)
            .DisableDecraft()
            .Register();

        #endregion
    }
}
