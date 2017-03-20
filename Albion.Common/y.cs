// Decompiled with JetBrains decompiler
// Type: y
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class y : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.EnterNonStartArea;
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    y y = new y();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    y.cp(this.cu());
    return (s) y;
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
