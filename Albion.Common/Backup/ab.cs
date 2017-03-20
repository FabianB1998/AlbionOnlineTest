// Decompiled with JetBrains decompiler
// Type: ab
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ab : global::w
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.FarmHarvestFame;
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
    ab ab = new ab();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ab.cp(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ab.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ab.au(this.ct());
    return (s) ab;
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
        if (A_0 != null && A_0.an() != null)
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
            // ISSUE: reference to a compiler-generated method
            if (!(b8.f() is c7))
            {
              if (A_1 != null)
                A_1.Add("Mission " + (object) this.au() + ": ItemId '" + A_0_1 + "' is no farmable item!");
              flag1 = true;
            }
            bool flag2 = false;
            for (int index = 0; index < 4; ++index)
            {
              c7 c7 = b8.e()[index] as c7;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (c7 != null && c7.d9() != null && c7.d9().j().i() > 0L)
              {
                flag2 = true;
                break;
              }
            }
            if (!flag2)
            {
              if (A_1 != null)
                A_1.Add(A_0_1 + " gives no Fame on Harvest!");
              flag1 = true;
            }
          }
        }
      }
    }
    return !flag1;
  }
}
