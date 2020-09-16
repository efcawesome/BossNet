using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace BossNet.Items
{
    public class KSItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Slime");
        }

        public override void SetDefaults()
        {
            item.width = 162;
            item.height = 144;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 1);
            item.makeNPC = NPCID.KingSlime;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
        }
    }
    public class EoCItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Cthulhu");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
        }

        public override void SetDefaults()
        {
            item.width = 110;
            item.height = 166;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 1, silver: 50);
            item.makeNPC = NPCID.EyeofCthulhu;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
        }
    }
    public class BoCItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain of Cthulhu");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 8));
        }

        public override void SetDefaults()
        {
            item.width = 200;
            item.height = 182;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 2);
            item.makeNPC = NPCID.BrainofCthulhu;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Green;
        }
    }
    public class EoWItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eater of Worlds");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 178;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 2);
            item.makeNPC = NPCID.EaterofWorldsHead;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Green;
        }
    }
    public class SKItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 178;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 5);
            item.makeNPC = NPCID.SkeletronHead;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Orange;
        }
    }
    public class WoFItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall of Flesh");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 2));
        }

        public override void SetDefaults()
        {
            item.width = 142;
            item.height = 106;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 7);
            item.makeNPC = NPCID.WallofFlesh;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class SKPItem : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron Prime");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 3));
        }

        public override void SetDefaults()
        {
            item.width = 140;
            item.height = 156;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 10);
            item.makeNPC = NPCID.SkeletronPrime;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Pink;
        }
    }
    public class DSItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Destroyer");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 184;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 10);
            item.makeNPC = NPCID.TheDestroyer;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Pink;
        }
    }
    public class STItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spazmatism");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
        }

        public override void SetDefaults()
        {
            item.width = 110;
            item.height = 200;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 10);
            item.makeNPC = NPCID.Spazmatism;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Pink;
        }
    }
    public class RTItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Retinazer");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
        }

        public override void SetDefaults()
        {
            item.width = 110;
            item.height = 200;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 10);
            item.makeNPC = NPCID.Retinazer;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Pink;
        }
    }
    public class PTItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plantera");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 8));
        }

        public override void SetDefaults()
        {
            item.width = 116;
            item.height = 154;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 15);
            item.makeNPC = NPCID.Plantera;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightPurple;
        }
    }
    public class GLItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golem");
        }

        public override void SetDefaults()
        {
            item.width = 212;
            item.height = 208;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 15);
            item.makeNPC = NPCID.Golem;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Lime;
        }
    }
    public class LCItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunatic Cultist");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 16));
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 64;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.CultistBoss;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Yellow;
        }
    }
    public class SPItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Pillar");
        }

        public override void SetDefaults()
        {
            item.width = 174;
            item.height = 364;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.LunarTowerSolar;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Red;
        }
    }
    public class NPItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nebula Pillar");
        }

        public override void SetDefaults()
        {
            item.width = 174;
            item.height = 364;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.LunarTowerNebula;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Red;
        }
    }
    public class DPItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stardust Pillar");
        }

        public override void SetDefaults()
        {
            item.width = 174;
            item.height = 364;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.LunarTowerStardust;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Red;
        }
    }
    public class VPItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vortex Pillar");
        }

        public override void SetDefaults()
        {
            item.width = 174;
            item.height = 364;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.LunarTowerVortex;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Red;
        }
    }
    public class MLItem : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Lord");
        }

        public override void SetDefaults()
        {
            item.width = 250;
            item.height = 217;
            item.useTime = 20;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.value = Item.buyPrice(gold: 20);
            item.makeNPC = NPCID.MoonLordCore;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = ItemRarityID.Purple;
        }
    }
}