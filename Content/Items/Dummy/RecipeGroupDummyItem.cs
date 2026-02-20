using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items.Dummy;

public abstract class RecipeGroupDummyItem : ModItem
{
    private const int TicksPerFrame = 40;
    protected abstract int FrameCount { get; }

    protected abstract int Width { get; }
    protected abstract int Height { get; }

    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(TicksPerFrame, FrameCount));
        ItemID.Sets.AnimatesAsSoul[Item.type] = true;
    }

    public override void SetDefaults()
    {
        Item.width = Width;
        Item.height = Height;
        Item.maxStack = Item.CommonMaxStack;
        Item.value = 0;
    }
}
