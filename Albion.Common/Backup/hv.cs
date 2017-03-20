// Decompiled with JetBrains decompiler
// Type: hv
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class hv : e3
{
  public static readonly string g7 = "damageshield";

  [SpecialName]
  public override string cl()
  {
    return hv.g7;
  }

  public override es.a cm()
  {
    return es.a.a;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "damageabsorbed", 100f));
    // ISSUE: reference to a compiler-generated method
    this.h4(false);
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hv.DamageType>(A_0, "effecttype", hv.DamageType.All));
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "damageabsorbed":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return Math.Round((double) this.h3() * (double) (A_0.e / A_0.d.ar().jj()) * (double) A_0.f.bx()).ToString();
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
