using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ICantBelieveItsNotVanilla.Items.Accessories
{
    public class TheArtOfWar : MetaItem
    {
        public static string ToolTipTemplate = ModHelper.Tooltip(
            "''Knowing the enemy enables you to take",
            "the offensive, knowing yourself enables",
            "you to stand on the defensive.''",
            "- Sun Tzu, The Art of War",
            "",
            "Enemies understood: {0}"
        );
        
        public Dictionary<int, bool> NpcBuffs = new Dictionary<int, bool>();

        public override void SetDefaults()
        {
            item.name = "The Art of War";
            item.width = 32;
            item.height = 28;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 0, 75, 0);
            item.accessory = true;
            item.rare = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if(player != null && player.inventory.Length > 0)
            {
                // Consume Banners
                Item item = null;
                int[] npcids = null;
                for (int i = 0; i < player.inventory.Length; i++)
                {
                    item = player.inventory[i];
                    if (item != null && Constants.BANNER_IDS.ContainsKey(item.type))
                    {
                        npcids = Constants.BANNER_IDS[item.type];
                        foreach (int npc in npcids)
                            NpcBuffs[Item.NPCtoBanner(npc)] = true;
                        player.inventory[i].TurnToAir();
                    }
                }
            }
        }

        public override TagCompound Save()
        {
            return new TagCompound
            {
                { "npcs", NpcBuffs.Select(x => x.Key).ToArray() }
            };
        }

        public override void Load(TagCompound tag)
        {
            NpcBuffs = tag.GetTag<int[]>("npcs").ToDictionary(x => x, x => true);
        }

        public override ModItem Clone(Item item)
        {
            TheArtOfWar clone = new TheArtOfWar();
            clone.sourceItem = sourceItem.Clone();
            clone.NpcBuffs = new Dictionary<int, bool>(NpcBuffs);
            return clone;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach(TooltipLine line in tooltips)
            {
                if(line.Name == "Tooltip")
                {
                    line.text = string.Format(ToolTipTemplate, NpcBuffs.Where(x => x.Value).Count());
                }
            }
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            //equips.Add(EquipType.Shield);
            return true;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Book)
                .AddTile(ItemID.Bookcase)
                .SetResult(this);
        }
    }
}
