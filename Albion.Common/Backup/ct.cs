// Decompiled with JetBrains decompiler
// Type: ct
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ct : cj
{
  [SpecialName]
  public override ci.VariableType bm()
  {
    return ci.VariableType.DynamicCluster;
  }

  public override void be(XmlElement A_0)
  {
    base.be(A_0);
  }

  public override bool bn(ah6 A_0, g8 A_1)
  {
    foreach (aie A_0_1 in this.k(A_0, A_1))
    {
      if (this.k(A_0_1, A_0, A_1))
        return true;
    }
    return false;
  }

  public override ci.a bo(ah6 A_0, g8 A_1, kt A_2)
  {
    HashSet<aie> aieSet = this.k(A_0, A_1);
    List<aie> aieList = new List<aie>();
    foreach (aie A_0_1 in aieSet)
    {
      if (this.k(A_0_1, A_0, A_1))
        aieList.Add(A_0_1);
    }
    if (aieList.Count == 0)
      return (ci.a) null;
    int index = A_2.Next(aieList.Count);
    return (ci.a) new ct.a((ci) this, aieList[index]);
  }

  public override ci.a bp(object A_0, g8 A_1)
  {
    string A_0_1 = A_0 as string;
    if (string.IsNullOrEmpty(A_0_1))
      return (ci.a) null;
    // ISSUE: reference to a compiler-generated method
    aie A_1_1 = A_1.ax().h1(A_0_1);
    if (A_1_1 == null)
      return (ci.a) null;
    return (ci.a) new ct.a((ci) this, A_1_1);
  }

  protected bool k(aie A_0, ah6 A_1, g8 A_2)
  {
    foreach (ck ck in this.l())
    {
      if (!ck.bi(A_0, A_1, A_2))
        return false;
    }
    return true;
  }

  public class a : ci.a
  {
    public a(ci A_0, aie A_1)
      : base(A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.j(A_1);
    }

    [SpecialName]
    public override string bq()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.j().ak();
    }

    public override object br()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (object) this.j().ah();
    }
  }
}
