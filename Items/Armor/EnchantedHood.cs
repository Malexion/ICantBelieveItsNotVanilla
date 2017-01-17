using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Armor
{
    public class EnchantedHood : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
        {
            item.name = "Enchanted Hood";
            item.toolTip = "A simple infused cloth hood.";
            item.width = 18;
            item.height = 18;
            item.defense = 2;
            item.value = Item.buyPrice(0, 0, 0, 50);
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.FallenStar)
                .AddIngredient(ItemID.Cobweb, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(this);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("EnchantedRobe") && legs.type == mod.ItemType("EnchantedLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Constants.SET_BONUS_MAGE;
            player.statManaMax2 += 40;
            player.manaRegen += 2;
            player.statDefense += 1;
        }
    }
}
