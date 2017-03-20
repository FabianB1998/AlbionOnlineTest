// Decompiled with JetBrains decompiler
// Type: co
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class co : ck
{
  [SpecialName]
  public override ck.ConditionType bg()
  {
    return ck.ConditionType.PresentResource;
  }

  public override void bh(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.v(aim.a(A_0, "resourceid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.w(aim.b(A_0, "tier", -1));
    // ISSUE: reference to a compiler-generated method
    this.v(aim.b(A_0, "mincount", 1));
  }

  public override bool bi(aie A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.w() < 1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return A_0.aq().e(this.v()) >= this.x();
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.aq().d(this.v(), this.w(), this.w()) >= this.x();
  }

  public override bool bk(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.aw() == null || A_0.aw().h1(this.v()) != null)
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add(((int) this.bg()).ToString() + ": Resource '" + this.v() + "' not found!");
    }
    return false;
  }
}
