using CalamityVanillaItemRecipes.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes;

public class WeaponRecipes : ModSystem
{
    public override void AddRecipes()
    {
        #region Current

        // Ball O' Hurt
        if (CurrentRecipesConfig.Instance.BallOHurt)
            Recipe.Create(ItemID.BallOHurt)
                .AddIngredient(ItemID.TheRottedFork)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Chain Guillotines
        if (CurrentRecipesConfig.Instance.ChainGuillotines)
            Recipe.Create(ItemID.ChainGuillotines)
                .AddIngredient(ItemID.FetidBaghnakhs)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Clinger Staff
        if (CurrentRecipesConfig.Instance.ClingerStaff)
            Recipe.Create(ItemID.ClingerStaff)
                .AddIngredient(ItemID.SoulDrain)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Crimson Rod
        if (CurrentRecipesConfig.Instance.CrimsonRod)
            Recipe.Create(ItemID.CrimsonRod)
                .AddIngredient(ItemID.Vilethorn)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Dart Pistol
        if (CurrentRecipesConfig.Instance.DartPistol)
            Recipe.Create(ItemID.DartPistol)
                .AddIngredient(ItemID.DartRifle)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Dart Rifle
        if (CurrentRecipesConfig.Instance.DartRifle)
            Recipe.Create(ItemID.DartRifle)
                .AddIngredient(ItemID.DartPistol)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Fetid Baghnakhs
        if (CurrentRecipesConfig.Instance.FetidBaghnakhs)
            Recipe.Create(ItemID.FetidBaghnakhs)
                .AddIngredient(ItemID.ChainGuillotines)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Finch Staff
        if (CurrentRecipesConfig.Instance.FinchStaff)
            Recipe.Create(ItemID.BabyBirdStaff)
                .AddIngredient(ItemID.Bird)
                .AddRecipeGroup("Wood", 8)
                .AddTile(TileID.WorkBenches)
                //.DisableDecraft()
                .Register();

        // Life Drain
        if (CurrentRecipesConfig.Instance.LifeDrain)
            Recipe.Create(ItemID.SoulDrain)
                .AddIngredient(ItemID.ClingerStaff)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Musket
        if (CurrentRecipesConfig.Instance.Musket)
            Recipe.Create(ItemID.Musket)
                .AddIngredient(ItemID.TheUndertaker)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Pulse Bow
        if (CurrentRecipesConfig.Instance.PulseBow)
            Recipe.Create(ItemID.PulseBow)
                .AddIngredient(ItemID.ShroomiteBar, 16)
                .AddTile(TileID.MythrilAnvil)
                .DisableDecraft()
                .Register();

        // Sergeant United Shield
        if (CurrentRecipesConfig.Instance.SergeantUnitedShield)
            Recipe.Create(ItemID.BouncingShield)
                .AddRecipeGroup(nameof(ItemID.CobaltBar), 12)
                .AddIngredient(ItemID.SoulofLight, 4)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Slime Staff
        if (CurrentRecipesConfig.Instance.SlimeStaff)
            Recipe.Create(ItemID.SlimeStaff)
                .AddRecipeGroup("Wood", 6)
                .AddIngredient(ItemID.Gel, 40)
                .AddTile(TileID.Anvils)
                //.DisableDecraft()
                .Register();

        // The Rotted Fork
        if (CurrentRecipesConfig.Instance.TheRottedFork)
            Recipe.Create(ItemID.TheRottedFork)
                .AddIngredient(ItemID.BallOHurt)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // The Undertaker
        if (CurrentRecipesConfig.Instance.TheUndertaker)
            Recipe.Create(ItemID.TheUndertaker)
                .AddIngredient(ItemID.Musket)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Vilethorn
        if (CurrentRecipesConfig.Instance.Vilethorn)
            Recipe.Create(ItemID.Vilethorn)
                .AddIngredient(ItemID.CrimsonRod)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();

        // Wand of Sparking
        if (CurrentRecipesConfig.Instance.WandOfSparking)
            Recipe.Create(ItemID.WandofSparking)
                .AddRecipeGroup("Wood", 5)
                .AddIngredient(ItemID.Torch, 3)
                .AddIngredient(ItemID.FallenStar)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.NotRemixWorld)
                //.DisableDecraft()
                .Register();

        // Water Bolt
        if (CurrentRecipesConfig.Instance.WaterBolt)
            Recipe.Create(ItemID.WaterBolt)
                .AddIngredient(ItemID.SpellTome)
                .AddIngredient(ItemID.Waterleaf, 3)
                .AddIngredient(ItemID.WaterCandle)
                .AddTile(TileID.Bookcases)
                .DisableDecraft()
                .Register();

        // Wooden Boomerang
        if (CurrentRecipesConfig.Instance.WoodenBoomerang)
            Recipe.Create(ItemID.WoodenBoomerang)
                .AddRecipeGroup("Wood", 7)
                .AddTile(TileID.WorkBenches)
                //.DisableDecraft()
                .Register();

        #endregion


        #region Removed

        // Flare Gun
        if (RemovedRecipesConfig.Instance.FlareGun)
            Recipe.Create(ItemID.FlareGun)
                .AddRecipeGroup(nameof(ItemID.CopperBar), 5)
                .AddIngredient(ItemID.Torch, 10)
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Ice Boomerang
        if (RemovedRecipesConfig.Instance.IceBoomerang)
            Recipe.Create(ItemID.IceBoomerang)
                .AddIngredient(ItemID.WoodenBoomerang)
                .AddRecipeGroup(nameof(ItemID.IceBlock), 20)
                .AddIngredient(ItemID.SnowBlock, 10)
                .AddIngredient(ItemID.Shiverthorn)
                .AddTile(TileID.IceMachine)
                .DisableDecraft()
                .Register();

        // Shuriken
        if (RemovedRecipesConfig.Instance.Shuriken)
            Recipe.Create(ItemID.Shuriken, 50)
                .AddRecipeGroup("IronBar")
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        // Throwing Knife
        if (RemovedRecipesConfig.Instance.ThrowingKnife)
            Recipe.Create(ItemID.ThrowingKnife, 50)
                .AddRecipeGroup("IronBar")
                .AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();

        #endregion
    }
}
