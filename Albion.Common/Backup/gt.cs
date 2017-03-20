// Decompiled with JetBrains decompiler
// Type: gt
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class gt : gs
{
  [SpecialName]
  public bool h4()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h3().o == 0L)
    {
      // ISSUE: reference to a compiler-generated method
      return this.h9().o == 0L;
    }
    return false;
  }

  [SpecialName]
  public bool @if()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ie();
  }

  public override bool cq(XmlElement A_0)
  {
    if (!base.cq(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h5(ahy.l((double) aim.a(A_0, "castingtime", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "recastdelay", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "castrange", 1f));
    // ISSUE: reference to a compiler-generated method
    this.ia(aim.a(A_0, "showrange", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "castrangetolerance", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "standtime", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h9(aim.a(A_0, "cancelautoattackaftercasting", false));
    // ISSUE: reference to a compiler-generated method
    this.h3((gu) null);
    // ISSUE: reference to a compiler-generated method
    this.h8(aim.a(A_0, "usableincombat", true));
    // ISSUE: reference to a compiler-generated method
    this.h7(aim.a(A_0, "castablewhensilenced", false));
    // ISSUE: reference to a compiler-generated method
    this.ib(aim.a(A_0, "castablewhenstunned", false));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "triggerautoattackcooldown", true));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "ignorecasttimereductionbonus", false));
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode is XmlElement)
      {
        XmlElement A_0_1 = (XmlElement) childNode;
        if (A_0_1 != null)
        {
          switch (A_0_1.Name)
          {
            case "channelingspell":
              // ISSUE: reference to a compiler-generated method
              this.h3(new gu(this));
              // ISSUE: reference to a compiler-generated method
              this.ij().cq(A_0_1);
              continue;
            default:
              continue;
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.h6(false);
    if (this.h3(typeof (hr)) && (this.dn == null || this.dn.Count == 0))
    {
      // ISSUE: reference to a compiler-generated method
      this.h6(true);
    }
    // ISSUE: reference to a compiler-generated method
    this.h5(false);
    if (this.dk != null && this.dk.Count > 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.h5(true);
    }
    if (this.dn != null && this.dn.Count > 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.h5(true);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ij() != null && this.ij().h7())
    {
      // ISSUE: reference to a compiler-generated method
      this.h5(true);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.a(A_0, "requireslineofsight", this.ig()));
    return true;
  }

  public override void cr(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ij() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ij().cr(A_0);
    }
    base.cr(A_0);
  }

  protected override string ck(global::er.a A_0)
  {
    switch (A_0.a)
    {
      case "castingtime":
        // ISSUE: reference to a compiler-generated method
        return global::er.h3(ahy.k(this.h3(), A_0.f.br()));
      case "standtime":
        // ISSUE: reference to a compiler-generated method
        return global::er.h3(this.h9());
      case "recastdelay":
        // ISSUE: reference to a compiler-generated method
        return global::er.h3(ahy.k(this.h5(), A_0.f.bt()));
      case "castrange":
        // ISSUE: reference to a compiler-generated method
        return global::er.h4(this.h6());
      case "channeling":
        // ISSUE: reference to a compiler-generated method
        if (this.ij() != null)
        {
          // ISSUE: reference to a compiler-generated method
          return this.ij().h6(A_0);
        }
        // ISSUE: reference to a compiler-generated method
        ab0.a("Spell '" + this.jp() + "' has no channelling! Please remove the loca tag or add channeling to the spell! Spell Attribute : " + A_0.a);
        return string.Empty;
      default:
        return base.ck(A_0);
    }
  }
}
