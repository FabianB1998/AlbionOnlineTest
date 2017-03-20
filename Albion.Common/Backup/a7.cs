// Decompiled with JetBrains decompiler
// Type: a7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class a7 : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.Silver;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.aw(aim.b(A_0, "absolute", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.av(aim.c(A_0, "percentage", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.c(A_0, "minimum", kx.g));
  }

  public void ax(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.aw(A_0);
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.av().i() != 0L || this.au().i() != 0L)
      return true;
    if (A_1 != null)
      A_1.Add("Reward " + (object) this.ay() + ": Silver has to be set!");
    return false;
  }
}
