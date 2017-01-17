using System.Collections.Generic;
using Terraria.ID;

namespace ICantBelieveItsNotVanilla
{
    public static class Constants
    {
        public static string SET_BONUS_WARRIOR = ModHelper.Tooltip(
            "[ICBINV]",
            "Melee Specialist",
            "+3 Defense",
            "+4 Melee Damage",
            "+20% Melee Attack Speed"
        );

        public static string SET_BONUS_SUMMONER = ModHelper.Tooltip(
            "[ICBINV]",
            "Summon Specialist",
            "+2 Defense",
            "+4 Summon Damage",
            "+2 Minions"
        );

        public static string SET_BONUS_RANGER = ModHelper.Tooltip(
            "[ICBINV]",
            "Ranged Specialist",
            "+1 Defense",
            "+4 Ranged Damage",
            "33% Chance not to consume ammo"
        );

        public static string SET_BONUS_MAGE = ModHelper.Tooltip(
            "[ICBINV]",
            "Magic Specialist",
            "+1 Defense",
            "+4 Magic Damage",
            "+2 Mana Regen",
            "+40 Mana"
        );

        public static Dictionary<int, int[]> BANNER_IDS = new Dictionary<int, int[]> 
        {
            #region Pre-Hardmode
            { ItemID.AngryBonesBanner, new int[] { NPCID.AngryBones, NPCID.AngryBonesBig, NPCID.AngryBonesBigHelmet, NPCID.AngryBonesBigMuscle } },
            { ItemID.AnomuraFungusBanner, new int[] { NPCID.AnomuraFungus } },
            { ItemID.AntlionBanner, new int[] { NPCID.Antlion } },
            { ItemID.WalkingAntlionBanner, new int[] { NPCID.WalkingAntlion } },
            { ItemID.FlyingAntlionBanner, new int[] { NPCID.FlyingAntlion } },
            { ItemID.BloodCrawlerBanner, new int[] { NPCID.BloodCrawler } },
            { ItemID.BloodZombieBanner, new int[] { NPCID.BloodZombie } },
            { ItemID.JellyfishBanner, new int[] { NPCID.BlueJellyfish } },
            { ItemID.BoneSerpentBanner, new int[] { NPCID.BoneSerpentBody, NPCID.BoneSerpentTail, NPCID.BoneSerpentHead } },
            { ItemID.BatBanner, new int[] { NPCID.CaveBat } },
            { ItemID.CochinealBeetleBanner, new int[] { NPCID.CochinealBeetle } },
            { ItemID.CrabBanner, new int[] { NPCID.Crab } },
            { ItemID.CrawdadBanner, new int[] { NPCID.Crawdad, NPCID.Crawdad2 } },
            { ItemID.CrimeraBanner, new int[] { NPCID.Crimera } },
            { ItemID.CursedSkullBanner, new int[] { NPCID.CursedSkull, NPCID.GiantCursedSkull } },
            { ItemID.CyanBeetleBanner, new int[] { NPCID.CyanBeetle } },
            { ItemID.SkeletonMageBanner, new int[] { NPCID.DarkCaster } },
            { ItemID.DemonBanner, new int[] { NPCID.Demon, NPCID.VoodooDemon } },
            { ItemID.DemonEyeBanner, new int[] { NPCID.DemonEye, NPCID.DemonEye2, NPCID.DemonEyeOwl, NPCID.DemonEyeSpaceship } },
            { ItemID.DevourerBanner, new int[] { NPCID.DevourerHead, NPCID.DevourerBody, NPCID.DevourerTail } },
            { ItemID.DoctorBonesBanner, new int[] { NPCID.DoctorBones } },
            { ItemID.DripplerBanner, new int[] { NPCID.Drippler } },
            { ItemID.EaterofSoulsBanner, new int[] { NPCID.EaterofSouls } },
            { ItemID.FaceMonsterBanner, new int[] { NPCID.FaceMonster } },
            { ItemID.FireImpBanner, new int[] { NPCID.FireImp } },
            { ItemID.FlyingFishBanner, new int[] { NPCID.FlyingFish } },
            { ItemID.FungiBulbBanner, new int[] { NPCID.FungiBulb } },
            { ItemID.GiantShellyBanner, new int[] { NPCID.GiantShelly, NPCID.GiantShelly2 } },
            { ItemID.GoblinScoutBanner, new int[] { NPCID.GoblinScout } },
            { ItemID.GraniteFlyerBanner, new int[] { NPCID.GraniteFlyer } },
            { ItemID.GraniteGolemBanner, new int[] { NPCID.GraniteGolem } },
            { ItemID.HarpyBanner, new int[] { NPCID.Harpy } },
            { ItemID.HellbatBanner, new int[] { NPCID.Hellbat } },
            { ItemID.GreekSkeletonBanner, new int[] { NPCID.GreekSkeleton } },
            { ItemID.HornetBanner, new int[] { NPCID.Hornet, NPCID.HornetFatty, NPCID.HornetHoney, NPCID.HornetLeafy, NPCID.HornetSpikey, NPCID.HornetStingy } },
            { ItemID.IceBatBanner, new int[] { NPCID.IceBat } },
            { ItemID.JungleBatBanner, new int[] { NPCID.JungleBat } },
            { ItemID.LacBeetleBanner, new int[] { NPCID.LacBeetle } },
            { ItemID.ManEaterBanner, new int[] { NPCID.ManEater } },
            { ItemID.MeteorHeadBanner, new int[] { NPCID.MeteorHead } },
            { ItemID.MushiLadybugBanner, new int[] { NPCID.MushiLadybug } },
            { ItemID.NypmhBanner, new int[] { NPCID.Nymph } },
            { ItemID.PinkJellyfishBanner, new int[] { NPCID.PinkJellyfish } },
            { ItemID.PiranhaBanner, new int[] { NPCID.Piranha } },
            { ItemID.RaincoatZombieBanner, new int[] { NPCID.ZombieRaincoat, NPCID.BigRainZombie, NPCID.SmallRainZombie } },
            { ItemID.RavenBanner, new int[] { NPCID.Raven } },
            { ItemID.SalamanderBanner, new int[] { NPCID.Salamander, NPCID.Salamander2, NPCID.Salamander3, NPCID.Salamander4, NPCID.Salamander5, NPCID.Salamander6, NPCID.Salamander7, NPCID.Salamander8, NPCID.Salamander9 } },
            { ItemID.SeaSnailBanner, new int[] { NPCID.SeaSnail } },
            { ItemID.SharkBanner, new int[] { NPCID.Shark } },
            { ItemID.SkeletonBanner, new int[] { NPCID.Skeleton } },
            { ItemID.SnatcherBanner, new int[] { NPCID.Snatcher } },
            { ItemID.SnowFlinxBanner, new int[] { NPCID.SnowFlinx } },
            { ItemID.SporeZombieBanner, new int[] { NPCID.ZombieMushroom, NPCID.ZombieMushroomHat } },
            { ItemID.SquidBanner, new int[] { NPCID.Squid } },
            { ItemID.TheGroomBanner, new int[] { NPCID.TheGroom } },
            { ItemID.TimBanner, new int[] { NPCID.Tim } },
            { ItemID.TombCrawlerBanner, new int[] { NPCID.TombCrawlerHead, NPCID.TombCrawlerBody, NPCID.TombCrawlerTail } },
            { ItemID.UndeadMinerBanner, new int[] { NPCID.UndeadMiner } },
            { ItemID.UndeadVikingBanner, new int[] { NPCID.UndeadViking } },
            { ItemID.VultureBanner, new int[] { NPCID.Vulture } },
            { ItemID.SpiderBanner, new int[] { NPCID.WallCreeper, NPCID.WallCreeperWall } },
            { ItemID.WormBanner, new int[] { NPCID.GiantWormHead, NPCID.GiantWormBody, NPCID.GiantWormTail } },
            { ItemID.ZombieBanner, new int[] { NPCID.Zombie, NPCID.BaldZombie, NPCID.PincushionZombie, NPCID.SlimedZombie, NPCID.SwampZombie, NPCID.TwiggyZombie, NPCID.FemaleZombie } },
            { ItemID.ZombieEskimoBanner, new int[] { NPCID.ZombieEskimo } },
            { ItemID.BlackSlimeBanner, new int[] { NPCID.BlackSlime } },
            { ItemID.SlimeBanner, new int[] { NPCID.BlueSlime } },
            { ItemID.DungeonSlimeBanner, new int[] { NPCID.DungeonSlime } },
            { ItemID.GreenSlimeBanner, new int[] { NPCID.GreenSlime } },
            { ItemID.IceSlimeBanner, new int[] { NPCID.IceSlime } },
            { ItemID.JungleSlimeBanner, new int[] { NPCID.JungleSlime } },
            { ItemID.LavaSlimeBanner, new int[] { NPCID.LavaSlime } },
            { ItemID.MotherSlimeBanner, new int[] { NPCID.MotherSlime } },
            { ItemID.PinkyBanner, new int[] { NPCID.Pinky } },
            { ItemID.PurpleSlimeBanner, new int[] { NPCID.PurpleSlime } },
            { ItemID.RedSlimeBanner, new int[] { NPCID.RedSlime } },
            { ItemID.SandSlimeBanner, new int[] { NPCID.SandSlime } },
            { ItemID.SpikedIceSlimeBanner, new int[] { NPCID.SpikedIceSlime } },
            { ItemID.SpikedJungleSlimeBanner, new int[] { NPCID.SpikedJungleSlime } },
            { ItemID.UmbrellaSlimeBanner, new int[] { NPCID.UmbrellaSlime } },
            { ItemID.YellowSlimeBanner, new int[] { NPCID.YellowSlime } },
            { ItemID.BunnyBanner, new int[] { NPCID.Bunny } },
            { ItemID.GoldfishBanner, new int[] { NPCID.Goldfish } },
            { ItemID.PenguinBanner, new int[] { NPCID.Penguin } },
            { ItemID.BirdBanner, new int[] { NPCID.Bird } },
            { ItemID.CorruptBunnyBanner, new int[] { NPCID.CorruptBunny } },
            { ItemID.CorruptGoldfishBanner, new int[] { NPCID.CorruptGoldfish } },
            { ItemID.CorruptPenguinBanner, new int[] { NPCID.CorruptPenguin } },
            #endregion
            
            #region Hardmode
            { ItemID.AnglerFishBanner, new int[] { NPCID.AnglerFish } },
            { ItemID.AngryNimbusBanner, new int[] { NPCID.AngryNimbus } },
            { ItemID.AngryTrapperBanner, new int[] { NPCID.AngryTrapper } },
            { ItemID.ArapaimaBanner, new int[] { NPCID.Arapaima } },
            { ItemID.ArmoredSkeletonBanner, new int[] { NPCID.ArmoredSkeleton } },
            { ItemID.ArmoredVikingBanner, new int[] { NPCID.ArmoredViking } },
            { ItemID.DesertBasiliskBanner, new int[] { NPCID.DesertBeast } },
            { ItemID.BlackRecluseBanner, new int[] { NPCID.BlackRecluse } },
            { ItemID.BloodFeederBanner, new int[] { NPCID.BloodFeeder } },
            { ItemID.BloodJellyBanner, new int[] { NPCID.BloodJelly } },
            { ItemID.BlueArmoredBonesBanner, new int[] { NPCID.BlueArmoredBones } },
            { ItemID.BoneLeeBanner, new int[] { NPCID.BoneLee } },
            { ItemID.ChaosElementalBanner, new int[] { NPCID.ChaosElemental } },
            { ItemID.ClingerBanner, new int[] { NPCID.Clinger } },
            { ItemID.ClownBanner, new int[] { NPCID.Clown } },
            { ItemID.CorruptorBanner, new int[] { NPCID.Corruptor } },
            { ItemID.CrimsonAxeBanner, new int[] { NPCID.CrimsonAxe } },
            { ItemID.CursedHammerBanner, new int[] { NPCID.CursedHammer } },
            { ItemID.DarkMummyBanner, new int[] { NPCID.DarkMummy } },
            { ItemID.DerplingBanner, new int[] { NPCID.Derpling } },
            { ItemID.DesertDjinnBanner, new int[] { NPCID.DesertDjinn } },
            { ItemID.DiablolistBanner, new int[] { NPCID.DiabolistRed, NPCID.DiabolistWhite } },
            { ItemID.DuneSplicerBanner, new int[] { NPCID.DuneSplicerHead, NPCID.DuneSplicerBody, NPCID.DuneSplicerTail } },
            { ItemID.DungeonSpiritBanner, new int[] { NPCID.DungeonSpirit } },
            { ItemID.EnchantedSwordBanner, new int[] { NPCID.EnchantedSword } },
            { ItemID.FloatyGrossBanner, new int[] { NPCID.FloatyGross } },
            { ItemID.FlyingSnakeBanner, new int[] { NPCID.FlyingSnake } },
            { ItemID.FungoFishBanner, new int[] { NPCID.FungoFish } },
            { ItemID.GhostBanner, new int[] { NPCID.Ghost } },
            { ItemID.DesertGhoulBanner, new int[] { NPCID.DesertGhoul, NPCID.DesertGhoulCorruption, NPCID.DesertGhoulCrimson, NPCID.DesertGhoulHallow } },
            { ItemID.GiantBatBanner, new int[] { NPCID.GiantBat } },
            { ItemID.GiantCursedSkullBanner, new int[] { NPCID.GiantCursedSkull } },
            { ItemID.GiantFlyingFoxBanner, new int[] { NPCID.GiantFlyingFox } },
            { ItemID.TortoiseBanner, new int[] { NPCID.GiantTortoise } },
            { ItemID.GreenJellyfishBanner, new int[] { NPCID.GreenJellyfish } },
            { ItemID.HellArmoredBonesBanner, new int[] { NPCID.HellArmoredBones, NPCID.HellArmoredBonesMace, NPCID.HellArmoredBonesSpikeShield, NPCID.HellArmoredBonesSword } },
            { ItemID.HerplingBanner, new int[] { NPCID.Herpling } },
            { ItemID.IceElementalBanner, new int[] { NPCID.IceElemental } },
            { ItemID.IceGolemBanner, new int[] { NPCID.IceGolem } },
            { ItemID.IceTortoiseBanner, new int[] { NPCID.IceTortoise } },
            { ItemID.IchorStickerBanner, new int[] { NPCID.IchorSticker } },
            { ItemID.IlluminantBatBanner, new int[] { NPCID.IlluminantBat } },
            { ItemID.IcyMermanBanner, new int[] { NPCID.IcyMerman } },
            { ItemID.JungleCreeperBanner, new int[] { NPCID.JungleCreeper, NPCID.JungleCreeperWall } },
            { ItemID.DesertLamiaBanner, new int[] { NPCID.DesertLamiaDark, NPCID.DesertLamiaLight } },
            { ItemID.LavaBatBanner, new int[] { NPCID.Lavabat } },
            { ItemID.LightMummyBanner, new int[] { NPCID.LightMummy } },
            { ItemID.LihzahrdBanner, new int[] { NPCID.Lihzahrd, NPCID.LihzahrdCrawler } },
            { ItemID.MedusaBanner, new int[] { NPCID.Medusa } },
            { ItemID.MimicBanner, new int[] { NPCID.Mimic } },
            { ItemID.MothBanner, new int[] { NPCID.Moth } },
            { ItemID.MummyBanner, new int[] { NPCID.Mummy } },
            { ItemID.NecromancerBanner, new int[] { NPCID.Necromancer, NPCID.NecromancerArmored } },
            { ItemID.PaladinBanner, new int[] { NPCID.Paladin } },
            { ItemID.PigronBanner, new int[] { NPCID.PigronCorruption, NPCID.PigronCrimson, NPCID.PigronHallow } },
            { ItemID.PixieBanner, new int[] { NPCID.Pixie } },
            { ItemID.PossessedArmorBanner, new int[] { NPCID.PossessedArmor } },
            { ItemID.RaggedCasterBanner, new int[] { NPCID.RaggedCaster } },
            { ItemID.RavagerScorpionBanner, new int[] { NPCID.DesertScorpionWalk, NPCID.DesertScorpionWall } },
            { ItemID.RedDevilBanner, new int[] { NPCID.RedDevil } },
            { ItemID.RuneWizardBanner, new int[] { NPCID.RuneWizard } },
            { ItemID.RustyArmoredBonesBanner, new int[] { NPCID.RustyArmoredBonesAxe, NPCID.RustyArmoredBonesFlail, NPCID.RustyArmoredBonesSword, NPCID.RustyArmoredBonesSwordNoArmor } },
            { ItemID.SkeletonArcherBanner, new int[] { NPCID.SkeletonArcher } },
            { ItemID.SkeletonCommandoBanner, new int[] { NPCID.SkeletonCommando } },
            { ItemID.SkeletonSniperBanner, new int[] { NPCID.SkeletonSniper } },
            { ItemID.TacticalSkeletonBanner, new int[] { NPCID.TacticalSkeleton } },
            { ItemID.UnicornBanner, new int[] { NPCID.Unicorn } },
            { ItemID.WerewolfBanner, new int[] { NPCID.Werewolf } },
            { ItemID.WolfBanner, new int[] { NPCID.Wolf } },
            { ItemID.WorldFeederBanner, new int[] { NPCID.SeekerHead, NPCID.SeekerBody, NPCID.SeekerTail } },
            { ItemID.WraithBanner, new int[] { NPCID.Wraith } },
            { ItemID.WyvernBanner, new int[] { NPCID.WyvernHead, NPCID.WyvernLegs, NPCID.WyvernTail, NPCID.WyvernBody, NPCID.WyvernBody2, NPCID.WyvernBody3 } },
            { ItemID.CorruptSlimeBanner, new int[] { NPCID.CorruptSlime } },
            { ItemID.CrimslimeBanner, new int[] { NPCID.Crimslime } },
            { ItemID.GastropodBanner, new int[] { NPCID.Gastropod } },
            { ItemID.HoppinJackBanner, new int[] { NPCID.HoppinJack } },
            { ItemID.IlluminantSlimeBanner, new int[] { NPCID.IlluminantSlime } },
            { ItemID.RainbowSlimeBanner, new int[] { NPCID.RainbowSlime } },
            { ItemID.SlimerBanner, new int[] { NPCID.Slimer, NPCID.Slimer2 } },
            { ItemID.ToxicSludgeBanner, new int[] { NPCID.ToxicSludge } },
            #endregion

            #region SandStorm
            { ItemID.TumbleweedBanner, new int[] { NPCID.Tumbleweed } },
            { ItemID.SandElementalBanner, new int[] { NPCID.SandElemental } },
            { ItemID.SandsharkBanner, new int[] { NPCID.SandShark } },
            { ItemID.SandsharkCorruptBanner, new int[] { NPCID.SandsharkCorrupt } },
            { ItemID.SandsharkCrimsonBanner, new int[] { NPCID.SandsharkCrimson } },
            { ItemID.SandsharkHallowedBanner, new int[] { NPCID.SandsharkHallow } },
	        #endregion

            #region GoblinArmy
            { ItemID.GoblinArcherBanner, new int[] { NPCID.GoblinArcher } },
            { ItemID.GoblinPeonBanner, new int[] { NPCID.GoblinPeon } },
            { ItemID.GoblinSorcererBanner, new int[] { NPCID.GoblinSorcerer } },
            { ItemID.GoblinSummonerBanner, new int[] { NPCID.GoblinSummoner } },
            { ItemID.GoblinThiefBanner, new int[] { NPCID.GoblinThief } },
            { ItemID.GoblinWarriorBanner, new int[] { NPCID.GoblinWarrior } },
	        #endregion

            #region PirateInvasion
            { ItemID.ParrotBanner, new int[] { NPCID.Parrot } },
            { ItemID.PirateCaptainBanner, new int[] { NPCID.PirateCaptain } },
            { ItemID.PirateCorsairBanner, new int[] { NPCID.PirateCorsair } },
            { ItemID.PirateCrossbowerBanner, new int[] { NPCID.PirateCrossbower } },
            { ItemID.PirateDeadeyeBanner, new int[] { NPCID.PirateDeadeye } },
            { ItemID.PirateBanner, new int[] { NPCID.PirateDeckhand } },
	        #endregion

            #region SolarEclipse
            { ItemID.ButcherBanner, new int[] { NPCID.Butcher } },
            { ItemID.CreatureFromTheDeepBanner, new int[] { NPCID.CreatureFromTheDeep } },
            { ItemID.DeadlySphereBanner, new int[] { NPCID.DeadlySphere } },
            { ItemID.DrManFlyBanner, new int[] { NPCID.DrManFly } },
            { ItemID.EyezorBanner, new int[] { NPCID.Eyezor } },
            { ItemID.FrankensteinBanner, new int[] { NPCID.Frankenstein } },
            { ItemID.FritzBanner, new int[] { NPCID.Fritz } },
            { ItemID.MothronBanner, new int[] { NPCID.Mothron, NPCID.MothronEgg } },
            { ItemID.NailheadBanner, new int[] { NPCID.Nailhead } },
            { ItemID.PsychoBanner, new int[] { NPCID.Psycho } },
            { ItemID.ReaperBanner, new int[] { NPCID.Reaper } },
            { ItemID.SwampThingBanner, new int[] { NPCID.SwampThing } },
            { ItemID.ThePossessedBanner, new int[] { NPCID.ThePossessed } },
            { ItemID.VampireBanner, new int[] { NPCID.Vampire, NPCID.VampireBat } },
	        #endregion

            #region FrostLegion
            { ItemID.MisterStabbyBanner, new int[] { NPCID.MisterStabby } },
            { ItemID.SnowBallaBanner, new int[] { NPCID.SnowBalla } },
            { ItemID.SnowmanGangstaBanner, new int[] { NPCID.SnowmanGangsta } },
	        #endregion

            #region MartianMadness
            { ItemID.MartianBrainscramblerBanner, new int[] { NPCID.BrainScrambler } },
            { ItemID.MartianDroneBanner, new int[] { NPCID.MartianDrone } },
            { ItemID.MartianEngineerBanner, new int[] { NPCID.MartianEngineer } },
            { ItemID.MartianGigazapperBanner, new int[] { NPCID.GigaZapper } },
            { ItemID.MartianGreyGruntBanner, new int[] { NPCID.GrayGrunt } },
            { ItemID.MartianOfficerBanner, new int[] { NPCID.MartianOfficer } },
            { ItemID.MartianRaygunnerBanner, new int[] { NPCID.RayGunner } },
            { ItemID.MartianScutlixGunnerBanner, new int[] { NPCID.ScutlixRider } },
            { ItemID.MartianTeslaTurretBanner, new int[] { NPCID.MartianTurret } },
            { ItemID.MartianWalkerBanner, new int[] { NPCID.MartianWalker } },
            { ItemID.ScutlixBanner, new int[] { NPCID.Scutlix } },
	        #endregion

            #region PumpkinMoon
            { ItemID.HeadlessHorsemanBanner, new int[] { NPCID.HeadlessHorseman } },
            { ItemID.HellhoundBanner, new int[] { NPCID.Hellhound } },
            { ItemID.PoltergeistBanner, new int[] { NPCID.Poltergeist } },
            { ItemID.ScarecrowBanner, new int[] { NPCID.Scarecrow1, NPCID.Scarecrow2, NPCID.Scarecrow3, NPCID.Scarecrow4, NPCID.Scarecrow5, NPCID.Scarecrow6, NPCID.Scarecrow7, NPCID.Scarecrow8, NPCID.Scarecrow9, NPCID.Scarecrow10 } },
            { ItemID.SplinterlingBanner, new int[] { NPCID.Splinterling } },
	        #endregion

            #region FrostMoon
            { ItemID.ElfArcherBanner, new int[] { NPCID.ElfArcher } },
            { ItemID.ElfCopterBanner, new int[] { NPCID.ElfCopter } },
            { ItemID.FlockoBanner, new int[] { NPCID.Flocko } },
            { ItemID.GingerbreadManBanner, new int[] { NPCID.GingerbreadMan } },
            { ItemID.KrampusBanner, new int[] { NPCID.Krampus } },
            { ItemID.NutcrackerBanner, new int[] { NPCID.Nutcracker, NPCID.NutcrackerSpinning } },
            { ItemID.PresentMimicBanner, new int[] { NPCID.PresentMimic } },
            { ItemID.YetiBanner, new int[] { NPCID.Yeti } },
            { ItemID.ZombieElfBanner, new int[] { NPCID.ZombieElf } },
	        #endregion

            #region LunarEvents
            { ItemID.BlueCultistArcherBanner, new int[] { NPCID.CultistArcherBlue } },

            { ItemID.VortexHornetBanner, new int[] { NPCID.VortexHornet } },
            { ItemID.VortexLarvaBanner, new int[] { NPCID.VortexLarva } },
            { ItemID.VortexHornetQueenBanner, new int[] { NPCID.VortexHornetQueen } },
            { ItemID.VortexSoldierBanner, new int[] { NPCID.VortexSoldier } },
            { ItemID.VortexRiflemanBanner, new int[] { NPCID.VortexRifleman } },

            { ItemID.NebulaHeadcrabBanner, new int[] { NPCID.NebulaHeadcrab } },
            { ItemID.NebulaBeastBanner, new int[] { NPCID.NebulaBeast } },
            { ItemID.NebulaBrainBanner, new int[] { NPCID.NebulaBrain } },
            { ItemID.NebulaSoldierBanner, new int[] { NPCID.NebulaSoldier } },

            { ItemID.StardustJellyfishBanner, new int[] { NPCID.StardustJellyfishBig, NPCID.StardustJellyfishSmall } },
            { ItemID.StardustWormBanner, new int[] { NPCID.StardustWormHead, NPCID.StardustWormBody, NPCID.StardustWormTail } },
            { ItemID.StardustLargeCellBanner, new int[] { NPCID.StardustCellBig, NPCID.StardustCellSmall } },
            { ItemID.StardustSoldierBanner, new int[] { NPCID.StardustSoldier } },
            { ItemID.StardustSpiderBanner, new int[] { NPCID.StardustSpiderBig, NPCID.StardustSpiderSmall } },

            { ItemID.SolarCoriteBanner, new int[] { NPCID.SolarCorite } },
            { ItemID.SolarCrawltipedeBanner, new int[] { NPCID.SolarCrawltipedeHead, NPCID.SolarCrawltipedeBody, NPCID.SolarCrawltipedeTail } },
            { ItemID.SolarDrakomireBanner, new int[] { NPCID.SolarDrakomire } },
            { ItemID.SolarDrakomireRiderBanner, new int[] { NPCID.SolarDrakomireRider } },
            { ItemID.SolarSolenianBanner, new int[] { NPCID.SolarSolenian } },
            { ItemID.SolarSrollerBanner, new int[] { NPCID.SolarSroller } }
	        #endregion
        };
    }
}
