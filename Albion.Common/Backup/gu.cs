// Decompiled with JetBrains decompiler
// Type: gu
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class gu : gs
{
  public gu(gt A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(A_0);
  }

  [SpecialName]
  public ahy ia()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ahy.n(this.h4(), ahy.k((float) Math.Max(0, this.h6() - 1), this.h5()));
  }

  public override bool cq(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "initialeffectinterval", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "effectinterval", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "effectcount", 1));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "channelinganimation", "").ToLower());
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "upperbodychannelinganim", false));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "allowcancel", true));
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.a(A_0, "allowmovement", false));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h7(this.h3().jp() + "_CHANNELING");
    // ISSUE: reference to a compiler-generated method
    this.d6 = this.h3().d6;
    // ISSUE: reference to a compiler-generated method
    this.dx = this.h3().dx;
    if (!base.cq(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h7(this.h3().jp() + "_CHANNELING");
    // ISSUE: reference to a compiler-generated method
    this.dy = this.h3().dy;
    // ISSUE: reference to a compiler-generated method
    this.d0 = this.h3().d0;
    // ISSUE: reference to a compiler-generated method
    this.d1 = this.h3().d1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h8(this.h3().ju());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h9(this.h3().jv());
    // ISSUE: reference to a compiler-generated method
    this.d9 = this.h3().d9;
    // ISSUE: reference to a compiler-generated method
    this.dx = this.h3().dx;
    // ISSUE: reference to a compiler-generated method
    this.h6(false);
    if (this.dk != null && this.dk.Count > 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.h6(true);
    }
    if (this.dn != null && this.dn.Count > 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.h6(true);
    }
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "effectcount":
        // ISSUE: reference to a compiler-generated method
        return string.Format("{0:0}", (object) this.h6());
      case "effectintervall":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h5());
      case "totalenergycost":
        // ISSUE: reference to a compiler-generated method
        return gs.h3(this.h6() * this.ds, A_0);
      case "totalduration":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h3(ahy.k(this.h5(), (float) this.h6()));
      case "totaldirectattributechange":
        return this.h3(A_0);
      case "totalattributechangeovertime":
        return this.h4(A_0);
      default:
        return base.ck(A_0);
    }
  }

  protected string h3(er.a A_0)
  {
    hn hn = this.h8<hn>(A_0.b);
    if (hn != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return er.h3(hn.h7() * (float) this.h6(), A_0, false, hn.h9(), hn.ia(), hn.ib(), hn.i3());
    }
    return (string) null;
  }

  protected string h4(er.a A_0)
  {
    hs hs = this.h8<hs>(A_0.b);
    if (hs != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return er.h3(hs.h6() * (float) this.h6(), A_0, false, hs.ib(), hs.ic(), hs.id(), hs.i3());
    }
    return (string) null;
  }
}
