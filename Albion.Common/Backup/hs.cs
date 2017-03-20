// Decompiled with JetBrains decompiler
// Type: hs
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class hs : e3
{
  public static readonly string gr = "attributechangeovertime";

  [SpecialName]
  public override string cl()
  {
    return hs.gr;
  }

  [SpecialName]
  public bool ib()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hs.Attribute.Health;
  }

  [SpecialName]
  public bool ic()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hs.Attribute.Energy;
  }

  [SpecialName]
  public bool id()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hs.Attribute.CraftingFocus;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h6() > 0.0)
      return es.a.a;
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h6() < 0.0)
      return es.a.c;
    // ISSUE: reference to a compiler-generated method
    if ((double) this.iw() > 0.0)
      return es.a.a;
    // ISSUE: reference to a compiler-generated method
    return (double) this.iw() < 0.0 ? es.a.c : es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hs.Attribute>(A_0, "attribute", hs.Attribute.Health));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "interval", 3f)));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "initialinterval", (float) this.h4().t())));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "change", 1f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "count", 10));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<aa5.EffectType>(A_0, "effecttype", aa5.EffectType.Magic));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<aa5.ReflectDamageBehavior>(A_0, "reflectdamage", aa5.ReflectDamageBehavior.BasedOnOrigin));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "ignorearmor", false));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h7(ahy.v(ahy.k(1L), ahy.n(this.h5(), ahy.k((float) Math.Max(this.h7() - 1, 0), this.h4()))));
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "attribute":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h3());
      case "count":
        // ISSUE: reference to a compiler-generated method
        return string.Format("{0:0}", (object) this.h7());
      case "interval":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h4());
      case "change":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h6(), A_0, false, this.ib(), this.ic(), this.id(), this.i3());
      case "effecttype":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h8());
      case "totalduration":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.@if());
      case "totalchange":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h3((float) this.h7() * this.h6(), A_0, false, this.ib(), this.ic(), this.id(), this.i3());
      default:
        return base.ck(A_0);
    }
  }

  public enum Attribute
  {
    Health,
    Energy,
    CraftingFocus,
  }
}
