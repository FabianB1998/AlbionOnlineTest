// Decompiled with JetBrains decompiler
// Type: s
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class s
{
  [SpecialName]
  public abstract s.MissionType au();

  public abstract s av(Dictionary<string, ci.a> A_0, ah6 A_1);

  public abstract bool @as(List<ci> A_0, List<string> A_1);

  public abstract bool at(g8 A_0, List<string> A_1);

  public virtual void ar(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "textloca", string.Empty));
  }

  public virtual bool aw(bc A_0, int A_1, g8 A_2)
  {
    return bc.h(this.au());
  }

  public virtual bool ax(bc A_0, int A_1, g8 A_2, List<string> A_3, HashSet<string> A_4)
  {
    // ISSUE: reference to a compiler-generated method
    if (bc.h(A_0.j()))
      return true;
    A_3.Add("MissionType does not support Templates! type: " + (object) this.au());
    return false;
  }

  public bool au(List<ci> A_0)
  {
    return this.@as(A_0, (List<string>) null);
  }

  public bool au(g8 A_0)
  {
    return this.at(A_0, (List<string>) null);
  }

  public s cp(ch A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    s s = this.av(A_0.f().t(), A_0.f().p());
    if (s != null)
    {
      // ISSUE: reference to a compiler-generated method
      s.au(A_0);
    }
    return s;
  }

  public static s au(string A_0, b5 A_1)
  {
    s s = s.au(A_0);
    if (s != null)
    {
      // ISSUE: reference to a compiler-generated method
      s.au(A_1);
    }
    return s;
  }

  public static s au(string A_0, cb A_1)
  {
    return s.au(A_0);
  }

  public static s au(string A_0, c8 A_1)
  {
    return s.au(A_0);
  }

  public static s au(string A_0, r A_1, int A_2)
  {
    s s = s.au(A_0);
    if (s != null)
    {
      // ISSUE: reference to a compiler-generated method
      s.au(A_1);
      // ISSUE: reference to a compiler-generated method
      s.au(A_2);
    }
    return s;
  }

  protected static s au(string A_0)
  {
    switch (A_0)
    {
      case "gotocluster":
        return s.au(s.MissionType.EnterCluster);
      default:
        try
        {
          return s.au((s.MissionType) Enum.Parse(typeof (s.MissionType), A_0, true));
        }
        catch (Exception ex)
        {
          ab0.a("MissionInfo.CreateByType: " + ex.Message);
          return (s) null;
        }
    }
  }

  public static s au(s.MissionType A_0, r A_1, int A_2)
  {
    s s = s.au(A_0);
    if (s != null)
    {
      // ISSUE: reference to a compiler-generated method
      s.au(A_1);
      // ISSUE: reference to a compiler-generated method
      s.au(A_2);
    }
    return s;
  }

  public static s cp(s.MissionType A_0)
  {
    return s.au(A_0);
  }

  protected static s au(s.MissionType A_0)
  {
    switch (A_0)
    {
      case s.MissionType.AuctionOrder:
        return (s) new az();
      case s.MissionType.BuyOrderSilver:
        return (s) new ag(A_0);
      case s.MissionType.ClaimOrb:
        return (s) new u();
      case s.MissionType.CraftItem:
        return (s) new ax();
      case s.MissionType.CraftItemsSv:
        return (s) new ag(A_0);
      case s.MissionType.CraftItemFame:
        return (s) new x();
      case s.MissionType.Die:
        return (s) new ap();
      case s.MissionType.DieSv:
        return (s) new ai();
      case s.MissionType.EnterCluster:
        return (s) new aj();
      case s.MissionType.EquipItem:
        return (s) new ak();
      case s.MissionType.SelectSpell:
        return (s) new z();
      case s.MissionType.FindObject:
        return (s) new al();
      case s.MissionType.Gather:
        return (s) new an();
      case s.MissionType.GatherFame:
        return (s) new am();
      case s.MissionType.GatherSilver:
        return (s) new ag(A_0);
      case s.MissionType.GrabLoot:
        return (s) new ao();
      case s.MissionType.GrabLootSv:
        return (s) new aq();
      case s.MissionType.HavePlayedGvgMatch:
        return (s) new aw();
      case s.MissionType.HaveFame:
        return (s) new ar();
      case s.MissionType.InstallSv:
        return (s) new af();
      case s.MissionType.KillMob:
        return (s) new ay();
      case s.MissionType.KillMobFame:
        return (s) new ah();
      case s.MissionType.KillPlayer:
        return (s) new at();
      case s.MissionType.KillPlayerFame:
        return (s) new @as();
      case s.MissionType.PlayGvgMatch:
        return (s) new av();
      case s.MissionType.FameEarned:
        return (s) new ag(A_0);
      case s.MissionType.SellOrderSilver:
        return (s) new ag(A_0);
      case s.MissionType.Survive:
        return (s) new au();
      case s.MissionType.FarmHarvest:
        return (s) new ad();
      case s.MissionType.FarmHarvestFame:
        return (s) new ab();
      case s.MissionType.FarmRaise:
        return (s) new ac();
      case s.MissionType.FarmRaiseFame:
        return (s) new aa();
      case s.MissionType.GotoAgent:
        return (s) new ae();
      case s.MissionType.EnterNonStartArea:
        return (s) new y();
      default:
        return (s) null;
    }
  }

  public static bool au(string A_0, ci.VariableType A_1, List<ci> A_2)
  {
    bool flag = false;
    foreach (ci ci in A_2)
    {
      // ISSUE: reference to a compiler-generated method
      if (ci.m() == A_0 && ci.bm() == A_1)
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  public enum MissionType
  {
    AuctionOrder = 0,
    BuyOrderSilver = 1,
    ClaimOrb = 2,
    CraftItem = 3,
    CraftItemsSv = 4,
    CraftItemFame = 5,
    Die = 6,
    DieSv = 7,
    EnterCluster = 8,
    EquipItem = 9,
    SelectSpell = 10,
    FindObject = 11,
    Gather = 12,
    GatherFame = 13,
    GatherSilver = 14,
    GrabLoot = 15,
    GrabLootSv = 16,
    HavePlayedGvgMatch = 17,
    HaveFame = 18,
    InstallSv = 19,
    KillMob = 20,
    KillMobFame = 21,
    KillPlayer = 22,
    KillPlayerFame = 23,
    PlayGvgMatch = 24,
    FameEarned = 25,
    SellOrderSilver = 26,
    Survive = 27,
    FarmHarvest = 28,
    FarmHarvestFame = 29,
    FarmRaise = 30,
    FarmRaiseFame = 31,
    GotoAgent = 32,
    EnterNonStartArea = 33,
    Invalid = 34,
    Num = 34,
  }

  public enum FightMode
  {
    all,
    pve,
    pvp,
    merc,
    gvg,
  }

  public enum FightModeGvg
  {
    gvg,
    merc,
  }

  public enum FightModePvp
  {
    pvp,
    gvg,
    merc,
  }
}
