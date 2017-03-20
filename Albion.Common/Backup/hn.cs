// Decompiled with JetBrains decompiler
// Type: hn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class hn : et
{
  public static readonly string fs = "directattributechange";

  [SpecialName]
  public override string cl()
  {
    return hn.fs;
  }

  [SpecialName]
  public bool h9()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hn.Attribute.Health;
  }

  [SpecialName]
  public bool ia()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hn.Attribute.Energy;
  }

  [SpecialName]
  public bool ib()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h3() == hn.Attribute.CraftingFocus;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h7() > 0.0)
      return es.a.a;
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h7() < 0.0)
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
    this.h3(aim.a<hn.Attribute>(A_0, "attribute", hn.Attribute.Health));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hn.ChangeTypes>(A_0, "changetype", hn.ChangeTypes.Absolute));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "change", 1f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<aa5.EffectType>(A_0, "effecttype", aa5.EffectType.Magic));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<aa5.ReflectDamageBehavior>(A_0, "reflectdamage", aa5.ReflectDamageBehavior.BasedOnOrigin));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "ignorearmor", false));
    return base.cj(A_0);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "attribute":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h3());
      case "effecttype":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h5());
      case "change":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h7(), A_0, this.h4() == hn.ChangeTypes.Relative, this.h9(), this.ia(), this.ib(), this.i3());
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

  public enum ChangeTypes
  {
    Absolute,
    Relative,
  }
}
