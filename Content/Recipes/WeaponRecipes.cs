using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class WeaponRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Water Bolt
			Recipe.Create(ItemID.WaterBolt)
				.AddIngredient(ItemID.SpellTome)
				.AddIngredient(ItemID.Waterleaf, 3)
				.AddIngredient(ItemID.WaterCandle)
				.AddTile(TileID.Bookcases)
                .DisableDecraft()
                .Register();
			
			// Ice Boomerang
			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.WoodenBoomerang)
				.AddRecipeGroup(nameof(ItemID.IceBlock), 20)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Shiverthorn)
				.AddTile(TileID.IceMachine)
                .DisableDecraft()
                .Register();
			
			// Enchanted Sword #
			
			// Flare Gun
			Recipe.Create(ItemID.FlareGun)
				.AddRecipeGroup(nameof(ItemID.CopperBar), 5)
				.AddIngredient(ItemID.Torch, 10)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Muramasa #
			
			// Sergeant United Shield
			Recipe.Create(ItemID.BouncingShield)
				.AddRecipeGroup(nameof(ItemID.CobaltBar), 12)
				.AddIngredient(ItemID.SoulofLight, 4)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Shuriken
			Recipe.Create(ItemID.Shuriken, 50)
				.AddRecipeGroup("IronBar")
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Slime Staff
			Recipe.Create(ItemID.SlimeStaff)
				.AddRecipeGroup("Wood", 6)
				.AddIngredient(ItemID.Gel, 40)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Starfury #
			
			// Throwing Knife
			Recipe.Create(ItemID.ThrowingKnife, 50)
				.AddRecipeGroup("IronBar")
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Wand of Sparking
			Recipe.Create(ItemID.WandofSparking)
				.AddIngredient(ItemID.Wood, 5)
				.AddIngredient(ItemID.Torch, 3)
				.AddIngredient(ItemID.FallenStar)
				.AddTile(TileID.Anvils)
                .AddCondition(Condition.NotRemixWorld)
                .DisableDecraft()
                .Register();
			
			// Ball O' Hurt
			Recipe.Create(ItemID.BallOHurt)
				.AddIngredient(ItemID.TheRottedFork)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Chain Guillotines
			Recipe.Create(ItemID.ChainGuillotines)
				.AddIngredient(ItemID.FetidBaghnakhs)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Clinger Staff
			Recipe.Create(ItemID.ClingerStaff)
				.AddIngredient(ItemID.SoulDrain)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Crimson Rod
			Recipe.Create(ItemID.CrimsonRod)
				.AddIngredient(ItemID.Vilethorn)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Dart Pistol
			Recipe.Create(ItemID.DartPistol)
				.AddIngredient(ItemID.DartRifle)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Dart Rifle
			Recipe.Create(ItemID.DartRifle)
				.AddIngredient(ItemID.DartPistol)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Fetid Baghnakhs
			Recipe.Create(ItemID.FetidBaghnakhs)
				.AddIngredient(ItemID.ChainGuillotines)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Life Drain
			Recipe.Create(ItemID.SoulDrain)
				.AddIngredient(ItemID.ClingerStaff)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Musket
			Recipe.Create(ItemID.Musket)
				.AddIngredient(ItemID.TheUndertaker)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// The Rotted Fork
			Recipe.Create(ItemID.TheRottedFork)
				.AddIngredient(ItemID.BallOHurt)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// The Undertaker
			Recipe.Create(ItemID.TheUndertaker)
				.AddIngredient(ItemID.Musket)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Vilethorn
			Recipe.Create(ItemID.Vilethorn)
				.AddIngredient(ItemID.CrimsonRod)
				.AddTile(TileID.Anvils)
				.AddCondition(Condition.InGraveyard)
                .DisableDecraft()
                .Register();
			
			// Pulse Bow
			Recipe.Create(ItemID.PulseBow)
				.AddIngredient(ItemID.ShroomiteBar, 16)
				.AddTile(TileID.MythrilAnvil)
                .DisableDecraft()
                .Register();
			
			// Finch Staff
			Recipe.Create(ItemID.BabyBirdStaff)
				.AddIngredient(ItemID.Bird)
				.AddRecipeGroup("Wood", 8)
				.AddTile(TileID.WorkBenches)
                .DisableDecraft()
                .Register();
			
			// Wooden Boomerang
			Recipe.Create(ItemID.WoodenBoomerang)
				.AddIngredient(ItemID.Wood, 7)
				.AddTile(TileID.WorkBenches)
                .DisableDecraft()
                .Register();
        }
    }
}