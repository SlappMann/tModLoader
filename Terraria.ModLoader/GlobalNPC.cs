﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria.ModLoader {
public class GlobalNPC
{
    public Mod mod
    {
        get;
        internal set;
    }
    public string Name
    {
        get;
        internal set;
    }

    public virtual bool Autoload(ref string name)
    {
        return mod.Properties.Autoload;
    }

    public virtual void SetDefaults(NPC npc) { }

    public virtual bool PreNPCLoot(NPC npc)
    {
        return true;
    }

    public virtual void NPCLoot(NPC npc) { }
}}
