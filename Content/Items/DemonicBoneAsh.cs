using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items
{
    public class DemonicBoneAsh : ModItem
    {
        public override void SetDefaults()
        {
			Item.value = Item.sellPrice(0, 0, 6, 0);
			Item.rare = ItemRarityID.Orange;
			Item.maxStack = 9999;
			Item.width = 40;
			Item.height = 30;
        }
		
		public override void AddRecipes()
		{
			if (ModContent.GetInstance<Config.MainConfig>().DemonicBoneAsh_Enabled)
			{
				// Demon Conch
				Recipe.Create(ItemID.DemonConch)
					.AddIngredient<Content.Items.DemonicBoneAsh>()
					.AddIngredient(ItemID.HellstoneBar, 4)
					.AddTile(TileID.Hellforge)
					.Register();
			}
		}
    }
}