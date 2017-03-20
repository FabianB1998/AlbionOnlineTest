// Decompiled with JetBrains decompiler
// Type: cv
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cv : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.FamePoints;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "points", kx.j));
  }

  public void av(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(A_0);
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    return true;
  }
}
