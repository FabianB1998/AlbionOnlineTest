// Decompiled with JetBrains decompiler
// Type: av
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class av : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.PlayGvgMatch;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "where", ""));
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "won", false));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "consecutively", false));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    av av = new av();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    av.au(this.cr());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    av.cp(this.cu());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    av.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    av.cp(this.cq());
    return (s) av;
  }
}
