// Decompiled with JetBrains decompiler
// Type: a1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class a1
{
  [SpecialName]
  public abstract a1.RewardType ay();

  [SpecialName]
  public virtual bool bt()
  {
    return false;
  }

  public abstract void az(XmlElement A_0);

  public abstract bool a0(g8 A_0, List<string> A_1);

  public virtual bool bs(bc.a A_0, bc A_1, int A_2, g8 A_3)
  {
    return this.a1(A_0, A_3);
  }

  public virtual bool a1(bc.a A_0, g8 A_1)
  {
    return false;
  }

  public bool au(g8 A_0)
  {
    return this.a0(A_0, (List<string>) null);
  }

  public virtual bool a2(bc.a A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    A_2.Add(string.Format("Reward '{0}' not supported!", (object) this.ay().ToString()));
    return false;
  }

  public virtual bool a3(bc.a A_0, bc A_1, int A_2, g8 A_3, List<string> A_4, HashSet<string> A_5)
  {
    A_4.Add(string.Format("Reward '{0}' not supported!", (object) this.ay().ToString()));
    return false;
  }

  public virtual a1 a0()
  {
    return (a1) this.MemberwiseClone();
  }

  public static a1 au(string A_0)
  {
    try
    {
      return a1.au((a1.RewardType) Enum.Parse(typeof (a1.RewardType), A_0, true));
    }
    catch (Exception ex)
    {
      ab0.a("RewardInfo.CreateByType: " + ex.Message);
      return (a1) null;
    }
  }

  public static a1 au(a1.RewardType A_0)
  {
    switch (A_0)
    {
      case a1.RewardType.Avatar:
        return (a1) new cu(a1.RewardType.Avatar);
      case a1.RewardType.AvatarRing:
        return (a1) new cu(a1.RewardType.AvatarRing);
      case a1.RewardType.ItemUse:
        return (a1) new cu(a1.RewardType.ItemUse);
      case a1.RewardType.ItemCraft:
        return (a1) new cu(a1.RewardType.ItemCraft);
      case a1.RewardType.BuildingBuild:
        return (a1) new cu(a1.RewardType.BuildingBuild);
      case a1.RewardType.SpellUse:
        return (a1) new cu(a1.RewardType.SpellUse);
      case a1.RewardType.ItemReward:
        return (a1) new cw();
      case a1.RewardType.PassiveBonus:
        return (a1) new cx();
      case a1.RewardType.ItemWearBonus:
        return (a1) new ba();
      case a1.RewardType.ItemCraftQuality:
        return (a1) new a9();
      case a1.RewardType.CraftingFocusCostReduction:
        return (a1) new a8();
      case a1.RewardType.FarmingFocusCostReduction:
        return (a1) new a4();
      case a1.RewardType.FamePoints:
        return (a1) new cv();
      case a1.RewardType.FarmableUse:
        return (a1) new cu(a1.RewardType.FarmableUse);
      case a1.RewardType.Silver:
        return (a1) new a7();
      case a1.RewardType.CanLeaveStartArea:
        return (a1) new a3();
      case a1.RewardType.ExpeditionCategory:
        return (a1) new cu(a1.RewardType.ExpeditionCategory);
      case a1.RewardType.ResourceGatherBonus:
        return (a1) new a6();
      case a1.RewardType.BonusDamageVsMobs:
        return (a1) new a5();
      case a1.RewardType.BonusDefenseVsMobs:
        return (a1) new a2();
      default:
        return (a1) null;
    }
  }

  protected bool au<a>(string A_0, string[] A_1, int A_2, List<a>[] A_3, g8 A_4, bool A_5, ref List<string> A_6) where a : gr
  {
    // ISSUE: reference to a compiler-generated method
    if (A_4.ao() == null)
      return true;
    bool flag1 = false;
    string str = A_5 ? "active spell" : "passive spell";
    if (A_1.Length != A_2)
    {
      if (A_6 != null)
        A_6.Add("Reward " + (object) this.ay() + ": ItemId '" + A_0 + "' " + str + " slot count is invalid!");
      return false;
    }
    for (int index = 0; index < A_1.Length; ++index)
    {
      string A_0_1 = A_1[index];
      // ISSUE: reference to a compiler-generated method
      if (A_4.ao().hz(A_0_1) == null)
      {
        if (A_6 != null)
          A_6.Add("Reward " + (object) this.ay() + ": ItemId '" + A_0 + "' " + str + " '" + A_0_1 + "' in slot " + (object) index + " not found!");
        flag1 = true;
      }
      else
      {
        bool flag2 = false;
        foreach (a a in A_3[index])
        {
          // ISSUE: reference to a compiler-generated method
          if (a.jp() == A_0_1)
          {
            flag2 = true;
            break;
          }
        }
        if (!flag2)
        {
          if (A_6 != null)
            A_6.Add("Reward " + (object) this.ay() + ": ItemId '" + A_0 + "' " + str + " '" + A_0_1 + "' in slot " + (object) index + " is not valid in this slot!");
          flag1 = true;
        }
      }
    }
    return !flag1;
  }

  public enum RewardType
  {
    Avatar = 0,
    AvatarRing = 1,
    ItemUse = 2,
    ItemCraft = 3,
    BuildingBuild = 4,
    SpellUse = 5,
    ItemReward = 6,
    PassiveBonus = 7,
    ItemWearBonus = 8,
    ItemCraftQuality = 9,
    CraftingFocusCostReduction = 10,
    FarmingFocusCostReduction = 11,
    FamePoints = 12,
    FarmableUse = 13,
    Silver = 14,
    CanLeaveStartArea = 15,
    ExpeditionCategory = 16,
    ResourceGatherBonus = 17,
    BonusDamageVsMobs = 18,
    BonusDefenseVsMobs = 19,
    Invalid = 20,
    Num = 20,
  }
}
