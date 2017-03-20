// Decompiled with JetBrains decompiler
// Type: cn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cn : ck
{
  [SpecialName]
  public override ck.ConditionType bg()
  {
    return ck.ConditionType.PresentAgent;
  }

  public override void bh(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.w(aim.a(A_0, "agentid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.v(aim.a(A_0, "faction", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.w(aim.b(A_0, "minlevel", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    this.v(aim.b(A_0, "maxlevel", int.MaxValue));
  }

  public override bool bi(aie A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.a2() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ah6 A_0_1 in A_0.a2())
      {
        if (this.bl(A_0_1, A_1, A_2))
          return true;
      }
    }
    return false;
  }

  public override bool bl(ah6 A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (!this.z() && A_0 == A_1)
      return false;
    // ISSUE: reference to a compiler-generated method
    bp bp = A_0.m();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return bp != null && (string.IsNullOrEmpty(this.v()) || !(bp.n() != this.v())) && ((string.IsNullOrEmpty(this.w()) || !(bp.q() != this.w())) && (bp.r() >= this.x() && bp.r() <= this.y()));
  }

  public override bool bk(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.v()) && A_0 != null && (A_0.a2() != null && A_0.a2().hz(this.v()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add(((int) this.bg()).ToString() + ": Agent '" + this.v() + "' not found!");
      }
      return false;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.w()) || A_0 == null || (A_0.a1() == null || A_0.a1().hz(this.w()) != null))
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add(((int) this.bg()).ToString() + ": Faction '" + this.w() + "' not found!");
    }
    return false;
  }
}
