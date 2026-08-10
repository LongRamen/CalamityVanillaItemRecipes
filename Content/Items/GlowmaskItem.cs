using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items;

public abstract class GlowmaskItem : ModItem
{
    protected virtual string GlowmaskAssetName => $"{GetType().FullName.Replace('.', '/')}_Glowmask";

    private Asset<Texture2D> _GlowmaskAsset;
    protected Asset<Texture2D> GlowmaskAsset => _GlowmaskAsset ??= RequestGlowmaskAsset();

    private Asset<Texture2D> RequestGlowmaskAsset()
    {
        return ModContent.Request<Texture2D>(GlowmaskAssetName);
    }

    public override void Load()
    {
        _GlowmaskAsset = RequestGlowmaskAsset();
    }

    public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
    {
        Texture2D glowmaskTexture = GlowmaskAsset.Value;

        Vector2 drawPosition = new
        (
            Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
            Item.position.Y - Main.screenPosition.Y + Item.height - glowmaskTexture.Height * 0.5f
        );

        spriteBatch.Draw
        (
            glowmaskTexture,
            drawPosition,
            new Rectangle(0, 0, glowmaskTexture.Width, glowmaskTexture.Height),
            Color.White,
            rotation,
            glowmaskTexture.Size() * 0.5f,
            scale,
            SpriteEffects.None,
            0f
        );
    }
}
