using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Items.Weapons
{
    public class Eoka : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Eoka";
            item.damage = 4;
            item.crit = 20;
            item.ranged = true;
            item.width = 30;
            item.height = 20;
            item.toolTip = "Cheap primitive gun.";
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = false;
            item.knockBack = 4;
            item.value = Item.buyPrice(0, 0, 0, 75);
            item.rare = 0;
            item.UseSound = SoundID.Item11;
            item.shoot = 10;
            item.shootSpeed = 4f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.IronBar, 2)
                .AddIngredient(ItemID.Wood, 25)
                .AddTile(TileID.WorkBenches)
                .SetResult(this);
        }
    }
}
