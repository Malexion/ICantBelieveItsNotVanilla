using Terraria;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla
{
	public class ICantBelieveItsNotVanilla : Mod
	{
        public ICantBelieveItsNotVanilla()
		{   
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
                AutoloadBackgrounds = true
			};
		}

        public override void Load()
        {
            if(!Main.dedServ)
            {
                AddEquipTexture(null, EquipType.Legs, "EnchantedRobe_Legs", "ICantBelieveItsNotVanilla/Items/Armor/EnchantedRobe_Legs");
                AddEquipTexture(null, EquipType.Legs, "OverGrownRobe_Legs", "ICantBelieveItsNotVanilla/Items/Armor/OverGrownRobe_Legs");
            }
        }

        public override void AddRecipes()
        {
            Recipes.RecipeBalances.Load(this);
        }
    }
}
