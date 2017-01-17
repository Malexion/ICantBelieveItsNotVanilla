using ICantBelieveItsNotVanilla.Items.Accessories;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla
{
    public class ICantBelieveItsNotVanillaWorld : ModWorld
    {
        public override void TileCountsAvailable(int[] tileCounts)
        {
            int ArtOfWarType = mod.GetItem("TheArtOfWar").item.type;
            Player player = Main.player[Main.myPlayer];
            foreach(Item item in player.armor)
            {
                if(item.type == ArtOfWarType)
                {
                    TheArtOfWar aow = (TheArtOfWar)item.modItem;
                    foreach (KeyValuePair<int, bool> npc in aow.NpcBuffs)
                    {
                        if (npc.Value)
                        {
                            player.NPCBannerBuff[npc.Key] = true;
                            player.hasBanner = true;
                        }
                    }
                }
            }
        }

    }
}
