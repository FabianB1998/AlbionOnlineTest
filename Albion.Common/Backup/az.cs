﻿// Decompiled with JetBrains decompiler
// Type: az
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class az : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.AuctionOrder;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "minvalue", kx.j));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "sellorder", false));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    az az = new az();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    az.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    az.au(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    az.cp(this.cu());
    return (s) az;
  }
}
