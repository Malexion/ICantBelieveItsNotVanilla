using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Armor
{
    public class OverGrownHood : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
        {
            item.name = "Overgrown Hood";
            item.toolTip = "An old hood infused with nature.";
            item.width = 18;
            item.height = 18;
            item.defense = 2;
            item.value = Item.buyPrice(0, 0, 0, 50);
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

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OverGrownRobe") && legs.type == mod.ItemType("OverGrownLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Constants.SET_BONUS_SUMMONER;
            player.maxMinions += 2;
            player.statDefense += 2;
        }
    }
}
