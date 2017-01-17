using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Weapons
{
    public class Pellet : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pellet";
            item.damage = 5;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.toolTip = "Crude pellets.";
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = Item.buyPrice(0, 0, 0, 1);
            item.rare = 0;
            item.shoot = mod.ProjectileType("Pellet");
            item.shootSpeed = 8f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.StoneBlock, 1)
                .AddTile(TileID.WorkBenches)
                .SetResult(this, 25);
        }
    }
}
