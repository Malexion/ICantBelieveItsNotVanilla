using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Armor
{
    public class StoneLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
        {
            item.name = "Stone Leggings";
            item.toolTip = "A crude pair of stone leggings.";
            item.width = 18;
            item.height = 18;
            item.defense = 2;
            item.value = Item.buyPrice(0, 0, 0, 75);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.StoneBlock, 25)
                .AddTile(TileID.WorkBenches)
                .SetResult(this);
        }
    }
}
