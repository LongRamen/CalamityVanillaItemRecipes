using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items
{
    public class CoreofSunlight : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ItemNoGravity[Item.type] = true;
        }

        public override void SetDefaults()
        {
			Item.value = Item.sellPrice(0, 0, 40, 0);
			Item.rare = ItemRarityID.Yellow;
			Item.maxStack = 9999;
			Item.width = 26;
			Item.height = 26;
        }
		
		public override void AddRecipes()
		{
			if (ModContent.GetInstance<Config.MainConfig>().Essence_CoreofSunlight_Enabled)
			{
				CreateRecipe(3)
					.AddIngredient<Content.Items.EssenceofSunlight>()
					.AddIngredient(ItemID.Ectoplasm)
					.AddTile(TileID.MythrilAnvil)
					.Register();
				
				// Lihzahrd Power Cell
				Recipe.Create(ItemID.LihzahrdPowerCell)
					.AddIngredient(ItemID.LihzahrdBrick, 5)
					.AddIngredient<Content.Items.CoreofSunlight>()
					.AddTile(TileID.LihzahrdFurnace)
					.DisableDecraft()
                    .Register();
			}
		}

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = ModContent.Request<Texture2D>("CalamityVanillaItemRecipes/Content/Items/CoreofSunlight_Glowmask", AssetRequestMode.ImmediateLoad).Value;
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
                    Item.position.Y - Main.screenPosition.Y + Item.height - texture.Height * 0.5f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
    }
}