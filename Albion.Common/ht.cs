﻿// Decompiled with JetBrains decompiler
// Type: ht
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ht : e3
{
  public static readonly string g3 = "buffovertime";

  [SpecialName]
  public override string cl()
  {
    return ht.g3;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h3() > 0.0)
      return es.a.a;
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h3() < 0.0)
      return es.a.c;
    // ISSUE: reference to a compiler-generated method
    if ((double) this.iw() > 0.0)
      return es.a.a;
    // ISSUE: reference to a compiler-generated method
    return (double) this.iw() < 0.0 ? es.a.c : es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(g8.am(aim.h(A_0, "type")));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "value", 0.0f));
    // ISSUE: reference to a compiler-generated method
    if (this.h4() == PlayerAttribute.MagicCastTimeReductionRaw)
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(PlayerAttribute.MagicCastTimeReductionAdjusted);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.h3((float) (1.0 / (1.0 - (double) this.h3()) - 1.0));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (this.h4() == PlayerAttribute.MagicCoolDownReductionRaw)
      {
        // ISSUE: reference to a compiler-generated method
        this.h3(PlayerAttribute.MagicCoolDownReductionAdjusted);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.h3((float) (1.0 / (1.0 - (double) this.h3()) - 1.0));
      }
    }
    return base.cj(A_0);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "type":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h4());
      case "value":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h4(), this.h3(), A_0, this.i3());
      default:
        return base.ck(A_0);
    }
  }
}
