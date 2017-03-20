// Decompiled with JetBrains decompiler
// Type: cs
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cs : cj
{
  [SpecialName]
  public override ci.VariableType bm()
  {
    return ci.VariableType.DynamicAgent;
  }

  public override void be(XmlElement A_0)
  {
    base.be(A_0);
    // ISSUE: reference to a compiler-generated method
    this.k(aim.a(A_0, "includingme", false));
  }

  public override bool bn(ah6 A_0, g8 A_1)
  {
    foreach (aie aie in this.k(A_0, A_1))
    {
      // ISSUE: reference to a compiler-generated method
      if (aie.a2() != null)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (ah6 A_0_1 in aie.a2())
        {
          if (this.k(A_0_1, A_0, A_1))
            return true;
        }
      }
    }
    return false;
  }

  public override ci.a bo(ah6 A_0, g8 A_1, kt A_2)
  {
    HashSet<aie> aieSet = this.k(A_0, A_1);
    List<ah6> ah6List = new List<ah6>();
    foreach (aie aie in aieSet)
    {
      // ISSUE: reference to a compiler-generated method
      if (aie.a2() != null)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (ah6 A_0_1 in aie.a2())
        {
          if (this.k(A_0_1, A_0, A_1))
            ah6List.Add(A_0_1);
        }
      }
    }
    if (ah6List.Count == 0)
      return (ci.a) null;
    int index = A_2.Next(ah6List.Count);
    return (ci.a) new cs.a((ci) this, ah6List[index]);
  }

  public override ci.a bp(object A_0, g8 A_1)
  {
    string str = A_0 as string;
    if (string.IsNullOrEmpty(str))
      return (ci.a) null;
    string[] strArray = str.Split(' ');
    if (strArray == null || strArray.Length != 2)
      return (ci.a) null;
    Guid A_0_1 = new Guid(strArray[0]);
    string A_0_2 = strArray[1];
    // ISSUE: reference to a compiler-generated method
    aie aie = A_1.ax().h1(A_0_2);
    if (aie == null)
      return (ci.a) null;
    ah6 A_1_1 = aie.ah(A_0_1);
    if (A_1_1 == null)
      return (ci.a) null;
    return (ci.a) new cs.a((ci) this, A_1_1);
  }

  protected bool k(ah6 A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (!this.k() && A_0 == A_1)
      return false;
    foreach (ck ck in this.l())
    {
      if (!ck.bl(A_0, A_1, A_2))
        return false;
    }
    return true;
  }

  public class a : ci.a
  {
    public a(ci A_0, ah6 A_1)
      : base(A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.j(A_1);
    }

    [SpecialName]
    public override string bq()
    {
      // ISSUE: reference to a compiler-generated method
      return this.j().t();
    }

    public override object br()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (object) (this.j().k().ToString() + " " + this.j().l().ah());
    }
  }
}
