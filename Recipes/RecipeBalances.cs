using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla.Recipes
{
    public static class RecipeBalances
    {
        public static void Load(Mod mod)
        {
            #region Misc
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Acorn)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ChristmasTree)
                
                .AddIngredient(ItemID.StoneBlock)
                .AddIngredient(ItemID.DirtBlock)
                .AddTile(TileID.Extractinator)
                .SetResult(ItemID.SiltBlock, 2)

                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.PinkVase)

                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ObsidianVase)

                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.PinkDungeonVase)

                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.GreenDungeonVase)

                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.BlueDungeonVase)

                .AddIngredient(ItemID.CookingPot)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.AlchemyTable)
                .SetResult(ItemID.Cauldron)

                .AddIngredient(ItemID.SunplateBlock, 50)
                .AddIngredient(ItemID.Wood, 25)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.AlchemyTable)
                .SetResult(ItemID.Sundial)

                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.Wood, 5)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.MinecartTrack, 25)

                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.IronAnvil)
                .AddIngredient(ItemID.Barrel)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.Extractinator)

                .AddIngredient(ItemID.IronBar, 50)
                .AddIngredient(mod.GetItem("Pellet"), 999)
                .AddIngredient(ItemID.WoodenArrow, 999)
                .AddIngredient(ItemID.Dynamite, 10)
                .AddIngredient(ItemID.Grenade, 10)
                .AddIngredient(ItemID.IllegalGunParts)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.AmmoBox)

                .AddIngredient(ItemID.StoneBlock, 100)
                .AddIngredient(ItemID.Wood, 100)
                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.Chain, 10)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.SharpeningStation)

                .AddIngredient(ItemID.Bone, 50)
                .AddIngredient(ItemID.SummoningPotion)
                .AddIngredient(ItemID.Book)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.DemonTorch, 2)
                .AddTile(TileID.DemonAltar)
                .SetResult(ItemID.BewitchingTable)

                .AddIngredient(ItemID.WoodenTable)
                .AddIngredient(ItemID.Book, 2)
                .AddIngredient(ItemID.Bottle, 10)
                .AddIngredient(ItemID.Feather)
                .AddIngredient(ItemID.FireflyinaBottle)
                .AddIngredient(ItemID.MagmaStone)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.AlchemyTable);

            RecipeBuilder.Transmute(mod, ItemID.RottenChunk, ItemID.Vertebrae, TileID.DemonAltar);
            RecipeBuilder.Transmute(mod, ItemID.CrimstoneBlock, ItemID.EbonstoneBlock);
            #endregion

            #region Weapons
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.Torch, 5)
                .AddIngredient(ItemID.Wood, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.WandofSparking)

                .AddIngredient(ItemID.Gel, 5)
                .AddIngredient(ItemID.Wood, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.SlimeStaff);
            #endregion

            #region Armor
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.IronBar, 2)
                .AddIngredient(ItemID.Leather, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.MiningShirt)

                .AddIngredient(ItemID.IronBar, 2)
                .AddIngredient(ItemID.Leather, 3)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.MiningPants);
            #endregion

            #region Vanity
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.Silk, 100)
                .AddTile(TileID.Loom)
                .SetResult(ItemID.WinterCape)

                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.Silk, 100)
                .AddTile(TileID.Loom)
                .SetResult(ItemID.RedCape)

                .AddIngredient(ItemID.Silk, 100)
                .AddTile(TileID.Loom)
                .SetResult(ItemID.MysteriousCape)

                .AddIngredient(ItemID.Silk, 100)
                .AddTile(TileID.Loom)
                .SetResult(ItemID.CrimsonCloak)

                .AddIngredient(ItemID.GoldBar, 40)
                .AddIngredient(ItemID.Diamond, 10)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.DiamondRing)

                .AddIngredient(ItemID.GoldBar, 60)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.AngelHalo);
            #endregion

            #region Emblems
            RecipeBuilder.Exchange(mod, new List<int>
            {
                ItemID.WarriorEmblem,
                ItemID.SummonerEmblem,
                ItemID.RangerEmblem,
                ItemID.SorcererEmblem
            }, 
                TileID.DemonAltar
            );
            #endregion

            #region Accessories
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.CobaltBar, 5)
                .AddIngredient(ItemID.ManaCrystal, 3)
                .AddTile(TileID.Anvils)
                .SetResult(ItemID.CelestialMagnet)

                .AddIngredient(ItemID.GlassLantern)
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.Chain, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.MagicLantern)

                .AddIngredient(ItemID.IronBar, 2)
                .AddTile(TileID.Anvils)
                .SetResult(ItemID.Shackle)

                .AddIngredient(ItemID.Book)
                .AddIngredient(ItemID.Daybloom, 5)
                .AddTile(TileID.Tables)
                .SetResult(ItemID.CordageGuide)

                .AddIngredient(ItemID.HermesBoots)
                .AddIngredient(ItemID.Vine, 6)
                .AddIngredient(ItemID.JungleSpores, 6)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.FlowerBoots)

                .AddIngredient(ItemID.GoldHammer)
                .AddIngredient(ItemID.IronBar, 20)
                .AddTile(TileID.HeavyWorkBench)
                .SetResult(ItemID.BrickLayer)

                .AddIngredient(ItemID.Wrench)
                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ActuationAccessory)

                .AddIngredient(ItemID.Barrel)
                .AddIngredient(ItemID.IronBar, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.PortableCementMixer)

                .AddIngredient(ItemID.Hook)
                .AddIngredient(ItemID.Lever)
                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ExtendoGrip)

                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.WaterGun)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.PaintSprayer)

                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.Wrench)
                .AddIngredient(ItemID.WoodenHammer)
                .AddIngredient(ItemID.Ruler)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Toolbox)

                .AddIngredient(ItemID.Vine, 5)
                .AddIngredient(ItemID.ClimbingClaws)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.FeralClaws)

                .AddIngredient(ItemID.CobaltBar, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.CobaltShield)

                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ClimbingClaws)

                .AddIngredient(ItemID.IronBar, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.ShoeSpikes)

                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.SharkFin, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Flipper)

                .AddIngredient(ItemID.Silk, 100)
                .AddIngredient(ItemID.ManaCrystal, 4)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.FlyingCarpet)

                .AddIngredient(ItemID.Coral, 20)
                .AddIngredient(ItemID.Waterleaf, 10)
                .AddIngredient(ItemID.SharkFin, 4)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.WaterWalkingBoots)

                .AddIngredient(ItemID.IronBar, 20)
                .AddIngredient(ItemID.Leather, 2)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.IceSkates)

                .AddIngredient(ItemID.HellstoneBar, 10)
                .AddIngredient(ItemID.Fireblossom, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.LavaCharm)

                .AddIngredient(ItemID.Silk, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Aglet)

                .AddIngredient(ItemID.Aglet)
                .AddIngredient(ItemID.Vine, 5)
                .AddIngredient(ItemID.JungleSpores, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.AnkletoftheWind)

                .AddIngredient(ItemID.IronBar, 10)
                .AddIngredient(ItemID.LifeCrystal, 2)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.BandofRegeneration)

                .AddIngredient(ItemID.IronBar, 10)
                .AddIngredient(ItemID.ManaCrystal, 2)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.BandofStarpower)

                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.Silk, 20)
                .AddIngredient(ItemID.Feather, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.FlurryBoots)

                .AddIngredient(ItemID.GoldBar, 10)
                .AddIngredient(ItemID.Silk, 20)
                .AddIngredient(ItemID.Feather, 10)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.HermesBoots)

                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.Cloud, 50)
                .AddIngredient(ItemID.RainCloud, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.CloudinaBottle)

                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.SnowBlock, 50)
                .AddIngredient(ItemID.IceBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.BlizzardinaBottle)

                .AddIngredient(ItemID.Bottle)
                .AddIngredient(ItemID.SnowBlock, 50)
                .AddIngredient(ItemID.IceBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.SandstorminaBottle);
            #endregion

            #region Trinkets
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.IronBar, 10)
                .AddIngredient(ItemID.Wire, 10)
                .AddIngredient(ItemID.Glass, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Radar)

                .AddIngredient(ItemID.Radar)
                .AddIngredient(ItemID.MechanicalLens)
                .AddIngredient(ItemID.LifeCrystal)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.LifeformAnalyzer)

                .AddIngredient(ItemID.IronBar, 10)
                .AddIngredient(ItemID.Lever, 2)
                .AddIngredient(ItemID.Timer1Second)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Stopwatch)

                .AddIngredient(ItemID.IronBar, 10)
                .AddIngredient(ItemID.MechanicalLens)
                .AddIngredient(ItemID.Timer1Second)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.DPSMeter)

                .AddIngredient(ItemID.GoldBar, 15)
                .AddIngredient(ItemID.Lens, 5)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.Sextant)

                .AddIngredient(ItemID.GoldBar, 8)
                .AddIngredient(ItemID.IronBar, 15)
                .AddIngredient(ItemID.Wire, 15)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.WeatherRadio)

                .AddIngredient(ItemID.Book)
                .AddIngredient(ItemID.ArmoredCavefish)
                .AddIngredient(ItemID.SpecularFish)
                .AddIngredient(ItemID.NeonTetra)
                .AddIngredient(ItemID.Bass)
                .AddIngredient(ItemID.Trout)
                .AddIngredient(ItemID.AtlanticCod)
                .AddTile(TileID.Bookcases)
                .SetResult(ItemID.FishermansGuide);
            #endregion

            #region Statues
            RecipeBuilder.CreateFor(mod)
                .AddIngredient(ItemID.ManaCrystal, 3)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.StarStatue)

                .AddIngredient(ItemID.LifeCrystal, 3)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.HeartStatue)

                .AddIngredient(ItemID.GoldCrown)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.QueenStatue)

                .AddIngredient(ItemID.PlatinumCrown)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.QueenStatue)

                .AddIngredient(ItemID.GoldCrown)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.KingStatue)

                .AddIngredient(ItemID.PlatinumCrown)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.WorkBenches)
                .SetResult(ItemID.KingStatue);
            #endregion

            #region Ore
            RecipeBuilder.Transmute(mod, ItemID.CopperOre, ItemID.TinOre);
            RecipeBuilder.Transmute(mod, ItemID.IronOre, ItemID.LeadOre);
            RecipeBuilder.Transmute(mod, ItemID.GoldOre, ItemID.PlatinumOre);
            RecipeBuilder.Transmute(mod, ItemID.DemoniteOre, ItemID.CrimtaneOre);
            RecipeBuilder.Transmute(mod, ItemID.CobaltOre, ItemID.PalladiumOre);
            RecipeBuilder.Transmute(mod, ItemID.MythrilOre, ItemID.OrichalcumOre);
            RecipeBuilder.Transmute(mod, ItemID.AdamantiteOre, ItemID.TitaniumOre);
            #endregion

            #region Ingot
            RecipeBuilder.Transmute(mod, ItemID.CopperBar, ItemID.TinBar);
            RecipeBuilder.Transmute(mod, ItemID.IronBar, ItemID.LeadBar);
            RecipeBuilder.Transmute(mod, ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeBuilder.Transmute(mod, ItemID.DemoniteBar, ItemID.CrimtaneBar);
            RecipeBuilder.Transmute(mod, ItemID.CobaltBar, ItemID.PalladiumBar);
            RecipeBuilder.Transmute(mod, ItemID.MythrilBar, ItemID.OrichalcumBar);
            RecipeBuilder.Transmute(mod, ItemID.AdamantiteBar, ItemID.TitaniumBar);
            #endregion

            #region Wood
            RecipeBuilder.Exchange(mod, new List<int>
            {
                ItemID.Wood,
                ItemID.RichMahogany,
                ItemID.Ebonwood,
                ItemID.Shadewood,
                ItemID.Pearlwood,
                ItemID.BorealWood,
                ItemID.PalmWood,
                ItemID.DynastyWood
            });
            #endregion
        }
    }
}
