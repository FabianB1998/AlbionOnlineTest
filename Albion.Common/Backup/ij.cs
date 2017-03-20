// Decompiled with JetBrains decompiler
// Type: ij
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ij : fb
{
  public static readonly string hw = "reflectdamage";

  [SpecialName]
  public override string cl()
  {
    return ij.hw;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ij.DamageType>(A_0, "damagetype", ij.DamageType.All));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<aa5.EffectType>(A_0, "astype", aa5.EffectType.Magic));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "amountpercent", 0.0f));
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "amountpercent":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h3());
      case "damagetype":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h4());
      case "astype":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.h5());
      default:
        return base.ck(A_0);
    }
  }

  public enum DamageType
  {
    Physical,
    Magic,
    All,
  }
}
