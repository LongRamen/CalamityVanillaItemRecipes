using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items
{
    public class AncientBoneDust : ModItem
    {
        public override void SetDefaults()
        {
			Item.value = Item.sellPrice(0, 0, 1, 0);
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 9999;
			Item.width = 36;
			Item.height = 22;
        }
		
		public override void AddRecipes()
		{
			if (ModContent.GetInstance<Config.MainConfig>().AncientBoneDust_Enabled)
			{
				// Armor Polish
				Recipe.Create(ItemID.ArmorPolish)
					.AddIngredient(ItemID.Bone, 10)
					.AddIngredient<Content.Items.AncientBoneDust>(3)
					.AddTile(TileID.Anvils)
					.DisableDecraft()
                    .Register();
			}
		}
    }
}