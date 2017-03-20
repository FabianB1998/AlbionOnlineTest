// Decompiled with JetBrains decompiler
// Type: ho
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ho : et
{
  public static readonly string f2 = "removeactiveeffects";

  [SpecialName]
  public override string cl()
  {
    return ho.f2;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    switch (this.h3())
    {
      case gs.SpellCategory.Heal:
        return es.a.c;
      case gs.SpellCategory.CrowdControl:
        return es.a.a;
      case gs.SpellCategory.Damage:
        return es.a.a;
      case gs.SpellCategory.Buff:
        return es.a.c;
      case gs.SpellCategory.Debuff:
        return es.a.a;
      default:
        return es.a.b;
    }
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<gs.SpellCategory>(A_0, "category", gs.SpellCategory.Debuff));
    return base.cj(A_0);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "category":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h3());
      default:
        return base.ck(A_0);
    }
  }
}
