using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ICantBelieveItsNotVanilla.Items
{
    public abstract class MetaItem : ModItem
    {
        public static Queue<TagCompound> DataQueue = new Queue<TagCompound>();

        public Item sourceItem = new Item();
        public override bool CloneNewInstances { get { return true; } }

        public override void PreReforge()
        {
            DataQueue.Enqueue(Save());
        }

        public override void PostReforge()
        {
            Load(DataQueue.Dequeue());
        }
    }
}
