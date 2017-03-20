// Decompiled with JetBrains decompiler
// Type: w
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public abstract class w : s
{
  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "value", kx.j));
    // ISSUE: reference to a compiler-generated method
    if (!kx.m(this.ct(), kx.j))
      return;
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "count", kx.j));
  }

  public override bool @as(List<ci> A_0, List<string> A_1)
  {
    return true;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    return true;
  }
}
