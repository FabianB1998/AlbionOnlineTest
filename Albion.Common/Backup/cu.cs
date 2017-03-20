// Decompiled with JetBrains decompiler
// Type: cu
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cu : a1
{
  private a1.RewardType ag;

  public cu(a1.RewardType A_0)
  {
    this.ag = A_0;
  }

  [SpecialName]
  public override a1.RewardType ay()
  {
    return this.ag;
  }

  public override void az(XmlElement A_0)
  {
    if (!A_0.HasChildNodes)
      return;
    this.au(A_0);
  }

  public override bool bs(bc.a A_0, bc A_1, int A_2, g8 A_3)
  {
    bc.c c = A_0 as bc.c;
    if (c == null)
      return false;
    if (this.ay() == a1.RewardType.SpellUse)
    {
      // ISSUE: reference to a compiler-generated method
      if (!A_1.i().d(A_2, bb.DataType.UnlockSpells))
        return false;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.au(cu.au(bc.h(A_3.an(), (IList<string>) c.l, c.m, c.n), A_1.i().e(A_2, bb.DataType.UnlockSpells), A_3));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (!A_1.i().d(A_2, bb.DataType.UnlockTier))
        return false;
      // ISSUE: reference to a compiler-generated method
      int num = A_1.i().h(A_2, bb.DataType.UnlockTier);
      if (this.ay() == a1.RewardType.ItemUse || this.ay() == a1.RewardType.ItemCraft)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.au(bc.h(A_3.an(), (IList<string>) c.l, num, num));
      }
      else if (this.ay() == a1.RewardType.BuildingBuild || this.ay() == a1.RewardType.FarmableUse)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.au(bc.h(A_3.ap(), (IList<string>) c.l, num, num));
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.au() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.au().Length > 0;
    }
    return false;
  }

  public override bool a2(bc.a A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    return true;
  }

  public override bool a3(bc.a A_0, bc A_1, int A_2, g8 A_3, List<string> A_4, HashSet<string> A_5)
  {
    if (A_0 is bc.c)
      return true;
    if (A_4 != null)
      A_4.Add("unlockinfo: internal error!");
    return false;
  }

  private static string[] au(string[] A_0, string[] A_1, g8 A_2)
  {
    if (A_0 == null || A_0.Length == 0 || (A_1 == null || A_1.Length == 0))
      return (string[]) null;
    List<string> A_0_1 = new List<string>(A_0.Length * A_1.Length);
    for (int index = 0; index < A_0.Length; ++index)
    {
      string A_0_2 = A_0[index];
      for (int A_1_1 = 0; A_1_1 <= 3; ++A_1_1)
      {
        // ISSUE: reference to a compiler-generated method
        en A_1_2 = A_2.an().h0(A_0_2, A_1_1);
        if (A_1_2 != null)
          cu.au(A_0_1, A_1_2, A_1);
      }
    }
    return A_0_1.ToArray();
  }

  private static void au(List<string> A_0, en A_1, string[] A_2)
  {
    if (A_1.cd == null)
      return;
    List<string>[] stringListArray = A_1.fq();
    if (stringListArray != null)
    {
      cu.au((Array) stringListArray, A_0, A_1, A_2);
    }
    else
    {
      cu.au((Array) A_1.cb, A_0, A_1, A_2);
      cu.au((Array) A_1.cc, A_0, A_1, A_2);
    }
  }

  private static void au(Array A_0, List<string> A_1, en A_2, string[] A_3)
  {
    if (A_0 == null)
      return;
    for (int index1 = 0; index1 < A_0.Length; ++index1)
    {
      IList list = A_0.GetValue(index1) as IList;
      if (list != null)
      {
        for (int index2 = 0; index2 < list.Count; ++index2)
        {
          string key = list[index2] as string;
          if (key == null)
          {
            gr gr = list[index2] as gr;
            if (gr != null)
            {
              // ISSUE: reference to a compiler-generated method
              key = gr.jp();
            }
          }
          string empty = string.Empty;
          if (A_2.cd.TryGetValue(key, out empty) && Array.IndexOf<string>(A_3, empty) >= 0 && !A_1.Contains(key))
            A_1.Add(key);
        }
      }
    }
  }

  private void au(XmlElement A_0)
  {
    List<string> stringList = new List<string>(A_0.ChildNodes.Count);
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "entry")
      {
        string str = aim.a(A_0_1, "id", string.Empty);
        if (!string.IsNullOrEmpty(str))
          stringList.Add(str);
      }
    }
    if (stringList.Count <= 0)
      return;
    // ISSUE: reference to a compiler-generated method
    this.au(stringList.ToArray());
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.au() == null || this.au().Length == 0)
    {
      if (A_1 != null)
        A_1.Add("Reward " + (object) this.ay() + " has no Id set");
      return false;
    }
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    foreach (string A_0_1 in this.au())
    {
      if (string.IsNullOrEmpty(A_0_1.Trim()))
      {
        if (A_1 != null)
          A_1.Add("Reward " + (object) this.ay() + " has an empty Id set");
        flag = true;
      }
      else if (A_0 != null)
      {
        switch (this.ay())
        {
          case a1.RewardType.Avatar:
            // ISSUE: reference to a compiler-generated method
            if (A_0.az() != null)
            {
              // ISSUE: reference to a compiler-generated method
              ds ds = A_0.az().hz(A_0_1);
              if (ds == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Avatar '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (!ds.k())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Avatar '" + A_0_1 + "' isn't set to be locked in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.AvatarRing:
            // ISSUE: reference to a compiler-generated method
            if (A_0.az() != null)
            {
              // ISSUE: reference to a compiler-generated method
              dt dt = A_0.az().h0(A_0_1);
              if (dt == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": AvatarRing '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (!dt.j())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": AvatarRing '" + A_0_1 + "' isn't set to be locked in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.ItemUse:
            // ISSUE: reference to a compiler-generated method
            if (A_0.an() != null)
            {
              // ISSUE: reference to a compiler-generated method
              b8 b8 = A_0.an().hz(A_0_1);
              if (b8 == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Item '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              c4 c4 = b8.f() as c4;
              if (c4 == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Item '" + A_0_1 + "' is not equipable (ie. no equipment or consumable item)!");
                flag = true;
                continue;
              }
              if (c4.bz())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Equip Item '" + A_0_1 + "' isn't set to be locked for use (equip) in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.ItemCraft:
            // ISSUE: reference to a compiler-generated method
            if (A_0.an() != null)
            {
              // ISSUE: reference to a compiler-generated method
              b8 b8 = A_0.an().hz(A_0_1);
              if (b8 == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Item '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (b8.f().y)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Equip Item '" + A_0_1 + "' isn't set to be locked for crafting in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.BuildingBuild:
            // ISSUE: reference to a compiler-generated method
            if (A_0.ap() != null)
            {
              // ISSUE: reference to a compiler-generated method
              bd bd = A_0.ap().hz(A_0_1);
              if (bd == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Building '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (bd.dc())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Building '" + A_0_1 + "' isn't set to be locked in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.SpellUse:
            // ISSUE: reference to a compiler-generated method
            if (A_0.ao() != null)
            {
              // ISSUE: reference to a compiler-generated method
              gr gr = A_0.ao().hz(A_0_1);
              if (gr == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Spell '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (gr.js())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Spell '" + A_0_1 + "' isn't set to be locked for use (equip) in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.FarmableUse:
            // ISSUE: reference to a compiler-generated method
            if (A_0.an() != null)
            {
              // ISSUE: reference to a compiler-generated method
              b8 b8 = A_0.an().hz(A_0_1);
              if (b8 == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Item '" + A_0_1 + "' didn't exist in data!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              c7 c7 = b8.f() as c7;
              if (c7 == null)
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Item '" + A_0_1 + "' is not set to be an farmable in xmls!");
                flag = true;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (c7.d5())
              {
                if (A_1 != null)
                  A_1.Add("Reward " + (object) this.ay() + ": Farmable Item '" + A_0_1 + "' isn't set to be locked for placement in xmls!");
                flag = true;
                continue;
              }
              continue;
            }
            continue;
          case a1.RewardType.ExpeditionCategory:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (A_0.bh() != null && A_0.bh().hz(A_0_1) == null)
            {
              if (A_1 != null)
                A_1.Add("Reward " + (object) this.ay() + ": Category '" + A_0_1 + "' didn't exist in data!");
              flag = true;
              continue;
            }
            continue;
          default:
            if (A_1 != null)
              A_1.Add("RewardType missing validation in Unlock: " + this.ay().ToString());
            flag = true;
            continue;
        }
      }
    }
    return !flag;
  }
}
