using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ICantBelieveItsNotVanilla.Items.Armor
{
    public class OverGrownRobe : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
        {
            item.name = "Overgrown Robe";
            item.toolTip = "An old robe infused with nature.";
            item.width = 18;
            item.height = 18;
            item.defense = 2;
            item.value = Item.buyPrice(0, 0, 0, 75);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Cobweb, 10)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(this);
        }

        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            robes = true;
            equipSlot = mod.GetEquipSlot("OverGrownRobe_Legs");
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }
    }
}
