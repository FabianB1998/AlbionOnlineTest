// Decompiled with JetBrains decompiler
// Type: ck
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class ck
{
  [SpecialName]
  public abstract ck.ConditionType bg();

  public static void v(List<ck> A_0, XmlElement A_1)
  {
    foreach (XmlNode childNode in A_1.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        ck ck = ck.v(A_0_1.Name);
        if (ck != null)
        {
          ck.bh(A_0_1);
          A_0.Add(ck);
        }
      }
    }
  }

  public abstract void bh(XmlElement A_0);

  public abstract bool bi(aie A_0, ah6 A_1, g8 A_2);

  public abstract bool bk(g8 A_0, List<string> A_1);

  public bool v(g8 A_0)
  {
    return this.bk(A_0, (List<string>) null);
  }

  public virtual bool bl(ah6 A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    return this.bi(A_0.l(), A_1, A_2);
  }

  public virtual void bj(ah6 A_0, g8 A_1, ref HashSet<aie> A_2)
  {
  }

  private static ck v(string A_0)
  {
    switch (A_0)
    {
      case "distancetocluster":
        return ck.v(ck.ConditionType.ClusterDistance);
      case "distancefromagent":
        return ck.v(ck.ConditionType.ClusterDistance);
      default:
        try
        {
          return ck.v((ck.ConditionType) Enum.Parse(typeof (ck.ConditionType), A_0, true));
        }
        catch (Exception ex)
        {
          ab0.a("VariableInfo.CreateByType: " + ex.Message);
          return (ck) null;
        }
    }
  }

  private static ck v(ck.ConditionType A_0)
  {
    switch (A_0)
    {
      case ck.ConditionType.And:
        return (ck) new cm(A_0);
      case ck.ConditionType.Or:
        return (ck) new cm(A_0);
      case ck.ConditionType.Not:
        return (ck) new cm(A_0);
      case ck.ConditionType.ClusterType:
        return (ck) new cq();
      case ck.ConditionType.ClusterDistance:
        return (ck) new cl();
      case ck.ConditionType.PresentMob:
        return (ck) new cp();
      case ck.ConditionType.PresentResource:
        return (ck) new co();
      case ck.ConditionType.PresentAgent:
        return (ck) new cn();
      default:
        return (ck) null;
    }
  }

  public enum ConditionType
  {
    And,
    Or,
    Not,
    ClusterType,
    ClusterDistance,
    PresentMob,
    PresentResource,
    PresentAgent,
  }
}
