// Decompiled with JetBrains decompiler
// Type: cr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cr : ci
{
  public string d;
  public int e;
  public int f;

  [SpecialName]
  public override ci.VariableType bm()
  {
    return ci.VariableType.MissionItem;
  }

  public override void be(XmlElement A_0)
  {
    base.be(A_0);
    this.d = aim.a(A_0, "itemid", string.Empty);
    this.e = aim.b(A_0, "enchantmentlevel", 0);
    this.f = aim.b(A_0, "count", 1);
  }

  public override bool bf(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.an() == null || A_0.an().hz(this.d) != null)
      return true;
    if (A_1 != null)
      A_1.Add(((int) this.bm()).ToString() + ": ItemId '" + this.d + "' not found!");
    return false;
  }

  public override bool bn(ah6 A_0, g8 A_1)
  {
    return true;
  }

  public override ci.a bo(ah6 A_0, g8 A_1, kt A_2)
  {
    return (ci.a) new cr.a(this, A_1);
  }

  public override ci.a bp(object A_0, g8 A_1)
  {
    return (ci.a) new cr.a(this, A_1);
  }

  public class a : ci.a
  {
    public a(cr A_0, g8 A_1)
      : base((ci) A_0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.j(A_1.an().hz(A_0.d, A_0.e));
      // ISSUE: reference to a compiler-generated method
      this.j(A_0.f);
    }

    [SpecialName]
    public override string bq()
    {
      // ISSUE: reference to a compiler-generated method
      if (this.k() == 1)
      {
        // ISSUE: reference to a compiler-generated method
        return this.j().e;
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.k().ToString() + "x " + this.j().e;
    }

    public override object br()
    {
      return (object) 0;
    }
  }
}
