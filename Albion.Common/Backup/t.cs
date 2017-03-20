// Decompiled with JetBrains decompiler
// Type: t
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public abstract class t : s
{
  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "value", long.MinValue));
    // ISSUE: reference to a compiler-generated method
    if (this.cu() != long.MinValue)
      return;
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "count", long.MinValue));
  }

  public override bool @as(List<ci> A_0, List<string> A_1)
  {
    return true;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.cu() != long.MinValue;
  }
}
