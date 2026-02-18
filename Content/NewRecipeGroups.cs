using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityVanillaItemRecipes.Content;

public class NewRecipeGroups : ModSystem
{
    public override void AddRecipeGroups()
    {
        RecipeGroup group;

        // Any Copper Bar
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperBar)}", ItemID.CopperBar, ItemID.TinBar);
        RecipeGroup.RegisterGroup(nameof(ItemID.CopperBar), group);

        // Any Gold Bar
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}", ItemID.GoldBar, ItemID.PlatinumBar);
        RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar), group);
        
        // Any Cobalt Bar
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltBar)}", ItemID.CobaltBar, ItemID.PalladiumBar);
        RecipeGroup.RegisterGroup(nameof(ItemID.CobaltBar), group);
        
        // Any Stone Block
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.StoneBlock)}", ItemID.StoneBlock, ItemID.EbonstoneBlock, ItemID.CrimstoneBlock, ItemID.PearlstoneBlock);
        RecipeGroup.RegisterGroup(nameof(ItemID.StoneBlock), group);
        
        // Any Ice Block
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.IceBlock)}", ItemID.IceBlock, ItemID.PurpleIceBlock, ItemID.RedIceBlock, ItemID.PinkIceBlock);
        RecipeGroup.RegisterGroup(nameof(ItemID.IceBlock), group);
        
        // Any Vile Powder
        group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.VilePowder)}", ItemID.VilePowder, ItemID.ViciousPowder);
        RecipeGroup.RegisterGroup(nameof(ItemID.VilePowder), group);
    }
}
