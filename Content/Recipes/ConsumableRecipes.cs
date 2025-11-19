using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Recipes
{
    public class ConsumableRecipes : ModSystem
    {
        public override void AddRecipes()
        {
			// Bloody Tear - BloodOrb.cs
			
			// Life Crystal
			Recipe.Create(ItemID.LifeCrystal)
				.AddIngredient(ItemID.StoneBlock, 5)
				.AddIngredient(ItemID.Ruby, 2)
				.AddIngredient(ItemID.HealingPotion)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Snow Globe
			Recipe.Create(ItemID.SnowGlobe)
				.AddIngredient(ItemID.SnowBlock, 10)
				.AddIngredient(ItemID.Glass, 5)
				.AddIngredient(ItemID.SoulofLight, 3)
				.AddIngredient(ItemID.SoulofNight, 3)
				.AddTile(TileID.Anvils)
                .DisableDecraft()
                .Register();
			
			// Lihzahrd Power Cell - CoreofSunlight.cs
			
			// Life Fruit #
			
			// Temple Key
			Recipe.Create(ItemID.TempleKey)
				.AddIngredient(ItemID.JungleSpores, 15)
				.AddIngredient(ItemID.RichMahogany, 10)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddIngredient(ItemID.SoulofNight, 5)
				.AddTile(TileID.MythrilAnvil)
                .DisableDecraft()
                .Register();
			
			// Gelatin Crystal
			Recipe.Create(ItemID.QueenSlimeCrystal)
				.AddIngredient(ItemID.CrystalShard, 10)
				.AddIngredient(ItemID.PinkGel, 5)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();
        }
    }
}