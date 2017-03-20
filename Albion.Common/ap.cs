// Decompiled with JetBrains decompiler
// Type: ap
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ap : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.Die;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "where", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "minvalue", kx.j));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    ap ap = new ap();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ap.au(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ap.cp(this.cu());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ap.au(this.cp());
    return (s) ap;
  }
}
