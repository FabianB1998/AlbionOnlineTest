// Decompiled with JetBrains decompiler
// Type: aw
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class aw : s
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.HavePlayedGvgMatch;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "where", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "won", false));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "value", -1L));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    aw aw = new aw();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aw.au(this.cr());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aw.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aw.au(this.cq());
    return (s) aw;
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
