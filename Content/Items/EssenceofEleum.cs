using CalamityVanillaItemRecipes.Config;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public class EssenceofEleum : ModItem
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.ItemNoGravity[Item.type] = true;
    }

    public override void SetDefaults()
    {
        Item.value = Item.sellPrice(0, 0, 4, 0);
        Item.rare = ItemRarityID.LightRed;
        Item.maxStack = 9999;
        Item.width = 28;
        Item.height = 24;
    }

    public override void AddRecipes()
    {
        #region Removed

        // Frozen Turtle Shell
        if (MainConfig.Instance.FrozenTurtleShell)
            Recipe.Create(ItemID.FrozenTurtleShell)
                .AddIngredient(ItemID.TurtleShell, 2)
                .AddIngredient<EssenceofEleum>(4)
                .AddTile(TileID.IceMachine)
                .DisableDecraft()
                .Register();

        #endregion
    }

    public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
    {
        Texture2D texture = ModContent.Request<Texture2D>("CalamityVanillaItemRecipes/Content/Items/EssenceofEleum_Glowmask", AssetRequestMode.ImmediateLoad).Value;
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
