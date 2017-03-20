// Decompiled with JetBrains decompiler
// Type: ci
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class ci
{
  [SpecialName]
  public abstract ci.VariableType bm();

  public virtual void be(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    ab0.a(!string.IsNullOrEmpty(this.m()), "VariableInfo has missing name in xml: " + A_0.ToString());
  }

  public abstract bool bn(ah6 A_0, g8 A_1);

  public abstract ci.a bo(ah6 A_0, g8 A_1, kt A_2);

  public abstract ci.a bp(object A_0, g8 A_1);

  public abstract bool bf(g8 A_0, List<string> A_1);

  public bool k(g8 A_0)
  {
    return this.bf(A_0, (List<string>) null);
  }

  public static ci k(string A_0)
  {
    try
    {
      return ci.k((ci.VariableType) Enum.Parse(typeof (ci.VariableType), A_0, true));
    }
    catch (Exception ex)
    {
      ab0.a("VariableInfo.CreateByType: " + ex.Message);
      return (ci) null;
    }
  }

  public static ci k(ci.VariableType A_0)
  {
    switch (A_0)
    {
      case ci.VariableType.DynamicCluster:
        return (ci) new ct();
      case ci.VariableType.DynamicAgent:
        return (ci) new cs();
      case ci.VariableType.MissionItem:
        return (ci) new cr();
      default:
        return (ci) null;
    }
  }

  public abstract class a
  {
    public a(ci A_0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.j(A_0.m());
    }

    [SpecialName]
    public abstract string bq();

    public override string ToString()
    {
      return this.bq();
    }

    public abstract object br();
  }

  public enum VariableType
  {
    DynamicCluster,
    DynamicAgent,
    MissionItem,
  }
}
