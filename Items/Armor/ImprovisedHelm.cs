using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Armor
{
    public class ImprovisedHelm : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
		{
			item.name = "Improvised Helm";
            item.toolTip = "A rough improvised helmet.";
            item.width = 18;
            item.height = 18;
            item.defense = 2;
			item.value = Item.buyPrice(0, 0, 0, 50);
			item.rare = 1;
		}

        public override void AddRecipes()
		{
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Wood, 10)
                .AddIngredient(ItemID.ClayBlock, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(this);
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ImprovisedBreastplate") && legs.type == mod.ItemType("ImprovisedLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Constants.SET_BONUS_RANGER;
            player.statDefense += 1;
        }
    }
}
