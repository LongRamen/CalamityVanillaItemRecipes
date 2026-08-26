using RamenLib.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityVanillaItemRecipes.Content.Items.Dummy;

public abstract class RecipeGroupDummyItem : AnimatedItem
{
    private const int RGDummy_TicksPerFrame = 40;
    protected override int TicksPerFrame => RGDummy_TicksPerFrame;

    protected abstract int Width { get; }
    protected abstract int Height { get; }

    public override void SetDefaults()
    {
        Item.width = Width;
        Item.height = Height;
        Item.maxStack = Item.CommonMaxStack;
        Item.value = 0;
    }
}
