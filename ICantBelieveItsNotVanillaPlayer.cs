
using Terraria;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla
{
    public class ICantBelieveItsNotVanillaPlayer : ModPlayer
    {
        public override void GetWeaponDamage(Item item, ref int damage)
        {
            if (item.melee && player.setBonus == Constants.SET_BONUS_WARRIOR)
                damage += 4;
            else if (item.ranged && player.setBonus == Constants.SET_BONUS_RANGER)
                damage += 4;
            else if (item.magic && player.setBonus == Constants.SET_BONUS_MAGE)
                damage += 4;
            else if ((item.summon || item.DD2Summon) && player.setBonus == Constants.SET_BONUS_SUMMONER)
                damage += 4;
        }

        public override bool ConsumeAmmo(Item weapon, Item ammo)
        {
            if(weapon.ranged)
            {
                if (player.setBonus == Constants.SET_BONUS_RANGER)
                    return Main.rand.NextFloat() > .33f;
            }
            return base.ConsumeAmmo(weapon, ammo);
        }
    }
}
