// Decompiled with JetBrains decompiler
// Type: cl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cl : ck
{
  [SpecialName]
  public override ck.ConditionType bg()
  {
    return ck.ConditionType.ClusterDistance;
  }

  public override void bh(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.w(aim.b(A_0, "mindistance", -1));
    // ISSUE: reference to a compiler-generated method
    this.v(aim.b(A_0, "maxdistance", -1));
  }

  public override bool bi(aie A_0, ah6 A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string A_0_1 = A_1.l().ah();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_2.ax().hz(A_0_1, this.v(), this.w()).Contains(A_0);
  }

  public override void bj(ah6 A_0, g8 A_1, ref HashSet<aie> A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string A_0_1 = A_0.l().ah();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    foreach (aie aie in A_1.ax().hz(A_0_1, this.v(), this.w()))
    {
      if (!A_2.Contains(aie))
        A_2.Add(aie);
    }
  }

  public override bool bk(g8 A_0, List<string> A_1)
  {
    return true;
  }
}
