using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Materials
{
    public class Paper : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Paper";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.toolTip = "Rough paper.";
            item.value = Item.buyPrice(0, 0, 0, 10);
            item.rare = 0;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Wood, 5)
                .AddTile(TileID.Sawmill)
                .SetResult(this)

                .AddIngredient(this, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddIngredient(ItemID.Silk, 2)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Book);
        }
    }
}
