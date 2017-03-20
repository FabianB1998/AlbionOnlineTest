// Decompiled with JetBrains decompiler
// Type: ahq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Xml;

public class ahq : ahp
{
  private kz s;
  private kz t;

  public ahq(aht A_0, int A_1)
    : base(A_0, A_1)
  {
  }

  public override ahm c8(aht A_0)
  {
    // ISSUE: reference to a compiler-generated method
    ahq ahq = new ahq(A_0, this.ac());
    ahq.s = this.s;
    ahq.t = this.t;
    ahq.l = this.l;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahq.y(this.ae());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahq.y(this.ad());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahq.y(this.af());
    return (ahm) ahq;
  }

  public override float c9()
  {
    return (float) Math.Sqrt((double) this.s.c0() * (double) this.s.c0() + (double) this.t.c0() * (double) this.t.c0()) / 2f;
  }

  public override ahm da(ace A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.y() == 0.0 || (double) this.z() == 0.0)
      return (ahm) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!new acd(new ahk((float) (-(double) this.y() / 2.0), (float) (-(double) this.z() / 2.0)), new ahk(this.y() / 2f, this.z() / 2f)).i(new ace(k2.a(new acf(A_0.a, 1f), this.c7().q()).n(), A_0.b)))
      return (ahm) null;
    return (ahm) this;
  }

  public override bool db(ab9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ((int) A_0.f(this.c7().i(), Math.Min(this.y(), this.z())) & 5) != 0;
  }

  public override void dd(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.z(this.s.c2(A_0));
    // ISSUE: reference to a compiler-generated method
    this.y(this.t.c2(A_0));
  }

  public override void dc(XmlElement A_0)
  {
    base.dc(A_0);
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.ab()))
    {
      // ISSUE: reference to a compiler-generated method
      this.y("SEA_RECT");
    }
    this.s = this.y(A_0, "width");
    this.t = this.y(A_0, "height");
  }
}
