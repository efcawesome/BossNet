using BossNet.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BossNet
{
    class NetGlobalNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            switch(npc.type)
            {
                case NPCID.KingSlime:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<KSItem>();
                    break;
                case NPCID.EyeofCthulhu:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<EoCItem>();
                    break;
                case NPCID.BrainofCthulhu:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<BoCItem>();
                    break;
                case NPCID.EaterofWorldsHead:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<EoWItem>();
                    break;
                case NPCID.EaterofWorldsBody:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<EoWItem>();
                    break;
                case NPCID.EaterofWorldsTail:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<EoWItem>();
                    break;
                case NPCID.SkeletronHead:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<SKItem>();
                    break;
                case NPCID.WallofFlesh:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<WoFItem>();
                    break;
                case NPCID.SkeletronPrime:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<SKPItem>();
                    break;
                case NPCID.TheDestroyer:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<DSItem>();
                    break;
                case NPCID.Spazmatism:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<STItem>();
                    break;
                case NPCID.Retinazer:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<RTItem>();
                    break;
                case NPCID.Plantera:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<PTItem>();
                    break;
                case NPCID.Golem:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<GLItem>();
                    break;
                case NPCID.CultistBoss:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<LCItem>();
                    break;
                case NPCID.LunarTowerSolar:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<SPItem>();
                    break;
                case NPCID.LunarTowerNebula:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<NPItem>();
                    break;
                case NPCID.LunarTowerStardust:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<DPItem>();
                    break;
                case NPCID.LunarTowerVortex:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<VPItem>();
                    break;
                case NPCID.MoonLordCore:
                    Main.npcCatchable[npc.type] = true;
                    npc.catchItem = (short)ModContent.ItemType<MLItem>();
                    break;
            }
        }
        public override void AI(NPC npc)
        {
            if(npc.type == NPCID.TheDestroyerBody || npc.type == NPCID.TheDestroyerTail)
            {
                if(!NPC.AnyNPCs(NPCID.TheDestroyer))
                {
                    npc.active = false;
                }
            }
        }
    }
}
