// Decompiled with JetBrains decompiler
// Type: x
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class x : w
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.CraftItemFame;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.b(A_0, "mintier", 0));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "maxtier", 8));
    if (!A_0.HasChildNodes)
      return;
    this.au(A_0);
  }

  private void au(XmlElement A_0)
  {
    List<string> stringList = new List<string>(A_0.ChildNodes.Count);
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "validitem")
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

  public override bool aw(bc A_0, int A_1, g8 A_2)
  {
    if (!base.aw(A_0, A_1, A_2))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.au(A_0.i(A_1));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cp(A_0.i().h(A_1, bb.DataType.MissionTargetMinTier));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.au(A_0.i().h(A_1, bb.DataType.MissionTargetMaxTier));
    // ISSUE: reference to a compiler-generated method
    int A_2_1 = A_0.i().h(A_1, bb.DataType.MissionItemMinTier);
    // ISSUE: reference to a compiler-generated method
    int A_3 = A_0.i().h(A_1, bb.DataType.MissionItemMaxTier);
    string[] strArray = A_0.h(A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.au(bc.h(A_2.an(), (IList<string>) strArray, A_2_1, A_3));
    // ISSUE: reference to a compiler-generated method
    if (this.cp() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.cp().Length > 0;
    }
    return false;
  }

  public override bool ax(bc A_0, int A_1, g8 A_2, List<string> A_3, HashSet<string> A_4)
  {
    bool flag = !base.ax(A_0, A_1, A_2, A_3, A_4);
    if (!A_0.h(A_1, A_2, A_3, A_4))
      flag = true;
    return !flag;
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    x x = new x();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    x.cp(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    x.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    x.au(this.ct());
    return (s) x;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag1 = false;
    // ISSUE: reference to a compiler-generated method
    if (this.cp() == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    foreach (string A_0_1 in this.cp())
    {
      if (string.IsNullOrEmpty(A_0_1))
      {
        if (A_1 != null)
          A_1.Add("Mission " + (object) this.au() + ": ItemId is Empty!");
        flag1 = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        b8 b8 = A_0.an().hz(A_0_1);
        if (b8 == null)
        {
          if (A_1 != null)
            A_1.Add("Mission " + (object) this.au() + ": ItemId '" + A_0_1 + "' does not exist!");
          flag1 = true;
        }
        else
        {
          bool flag2 = false;
          for (int index = 0; index < 4; ++index)
          {
            b9 b9 = b8.e()[index];
            // ISSUE: reference to a compiler-generated method
            if (b9 != null && b9.k != null && b9.k.p().Count > 0)
            {
              flag2 = true;
              break;
            }
          }
          if (!flag2)
          {
            if (A_1 != null)
              A_1.Add("Mission " + (object) this.au() + ": ItemId " + A_0_1 + " can not be crafted because it has no CraftRequirements!");
            flag1 = true;
          }
          else
          {
            bool flag3 = false;
            for (int index = 0; index < 4; ++index)
            {
              b9 A_0_2 = b8.e()[index];
              if (A_0_2 != null)
              {
                kx A_1_1 = A_0_2.d1(A_0);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (A_0.ar().je().h(A_0_2, A_1_1, 1).i() > 0L)
                {
                  flag3 = true;
                  break;
                }
              }
            }
            if (!flag3)
            {
              if (A_1 != null)
                A_1.Add("Mission " + (object) this.au() + ": ItemId " + A_0_1 + " gives no Fame on Craft! (on receipe 1)");
              flag1 = true;
            }
          }
        }
      }
    }
    return !flag1;
  }

  public bool au(b9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (this.cq() <= 0 || A_0.f >= this.cq()) && (this.cp() == null || this.cp().Length <= 0 || Array.IndexOf<string>(this.cp(), A_0.j) >= 0);
  }
}
