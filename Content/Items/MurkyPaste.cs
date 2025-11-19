using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items
{
    public class MurkyPaste : ModItem
    {
        public override void SetDefaults()
        {
			Item.value = Item.sellPrice(0, 0, 2, 0);
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 9999;
			Item.width = 20;
			Item.height = 28;
        }
		
		public override void AddRecipes()
		{
			if (ModContent.GetInstance<Config.MainConfig>().MurkyPaste_Enabled)
			{
				//Bezoar
				Recipe.Create(ItemID.Bezoar)
					.AddIngredient<Content.Items.MurkyPaste>(3)
					.AddIngredient(ItemID.Stinger, 5)
					.AddTile(TileID.Anvils)
                    .DisableDecraft()
                    .Register();
			}
		}
    }
}