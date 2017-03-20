// Decompiled with JetBrains decompiler
// Type: a0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class a0 : t
{
  private s.MissionType co;

  public a0(s.MissionType A_0)
  {
    this.co = A_0;
  }

  [SpecialName]
  public override s.MissionType au()
  {
    return this.co;
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    a0 a0 = new a0(this.co);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    a0.cp(this.cu());
    return (s) a0;
  }
}
