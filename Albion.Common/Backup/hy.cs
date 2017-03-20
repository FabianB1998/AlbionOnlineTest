// Decompiled with JetBrains decompiler
// Type: hy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class hy : e3
{
  public static readonly string hd = "reflectdamageactive";

  [SpecialName]
  public override string cl()
  {
    return hy.hd;
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
    this.h3(aim.a<hy.DamageType>(A_0, "damagetype", hy.DamageType.All));
    if (aim.h(A_0, "astype") == "physical")
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(aa5.EffectType.Physical);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(aa5.EffectType.Magic);
    }
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "amountpercent", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h4(false);
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "amountpercent":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h3());
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
