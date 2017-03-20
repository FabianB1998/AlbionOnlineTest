// Decompiled with JetBrains decompiler
// Type: ahr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Xml;

public class ahr : ahp
{
  private kz u;
  private kz v;
  private kz w;

  public ahr(aht A_0, int A_1)
    : base(A_0, A_1)
  {
  }

  public override ahm c8(aht A_0)
  {
    // ISSUE: reference to a compiler-generated method
    ahr ahr = new ahr(A_0, this.ac());
    ahr.u = this.u;
    ahr.v = this.v;
    ahr.w = this.w;
    ahr.l = this.l;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahr.y(this.ae());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahr.y(this.ad());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahr.y(this.af());
    return (ahm) ahr;
  }

  public override float c9()
  {
    return this.v.c0();
  }

  public override ahm da(ace A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.z() == 0.0 || (double) this.aa() <= 0.0)
      return (ahm) null;
    float num1 = ahk.c(this.c7().i(), A_0.a).j();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) num1 > ((double) this.z() + (double) A_0.b) * ((double) this.z() + (double) A_0.b))
      return (ahm) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.b <= (double) this.y() && (double) num1 < ((double) this.y() - (double) A_0.b) * ((double) this.y() - (double) A_0.b))
      return (ahm) null;
    if (A_0.a.c(this.c7().i(), 0.01f))
      return (ahm) this;
    // ISSUE: reference to a compiler-generated method
    float num2 = (float) ((double) this.c7().k() - (double) abh.d(this.aa()) / 2.0 + 1.57079637050629);
    ahk A_0_1 = new ahk((float) Math.Cos((double) num2), (float) Math.Sin((double) num2)).m();
    float val1_1 = ahk.c(A_0.a, this.c7().i()).b(A_0_1);
    if ((double) val1_1 > -(double) A_0.b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      float A_1_1 = Math.Min(Math.Max(val1_1, this.y()), this.z());
      ahk A_1_2 = ahk.d(this.c7().i(), ahk.b(A_0_1, A_1_1));
      if ((double) ahk.c(A_0.a, A_1_2).j() < (double) A_0.b * (double) A_0.b)
        return (ahm) this;
    }
    // ISSUE: reference to a compiler-generated method
    float num3 = (float) ((double) this.c7().k() + (double) abh.d(this.aa()) / 2.0 + 1.57079637050629);
    ahk A_0_2 = new ahk((float) Math.Cos((double) num3), (float) Math.Sin((double) num3)).m();
    float val1_2 = ahk.c(A_0.a, this.c7().i()).b(A_0_2);
    if ((double) val1_2 > -(double) A_0.b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      float A_1_1 = Math.Min(Math.Max(val1_2, this.y()), this.z());
      ahk A_1_2 = ahk.d(this.c7().i(), ahk.b(A_0_2, A_1_1));
      if ((double) ahk.c(A_0.a, A_1_2).j() < (double) A_0.b * (double) A_0.b)
        return (ahm) this;
    }
    ahk ahk = ahk.c(A_0.a, this.c7().i()).m();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num4 = abh.c((float) (Math.Atan2((double) ahk.h(), (double) ahk.g()) - Math.Atan2(1.0, 0.0)));
    // ISSUE: reference to a compiler-generated method
    float num5 = abh.d(this.aa());
    float num6 = this.c7().k();
    float num7 = abh.c(num6 - num5 / 2f);
    float num8 = abh.c(num6 + num5 / 2f);
    if ((double) num7 < (double) num8 && (double) num4 > (double) num7 && (double) num4 < (double) num8)
      return (ahm) this;
    if ((double) num7 > (double) num8 && ((double) num4 > (double) num7 || (double) num4 < (double) num8))
      return (ahm) this;
    return (ahm) null;
  }

  public override bool db(ab9 A_0)
  {
    return false;
  }

  public override void dd(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.aa(this.u.c2(A_0));
    // ISSUE: reference to a compiler-generated method
    this.z(this.v.c2(A_0));
    // ISSUE: reference to a compiler-generated method
    this.y(this.w.c2(A_0));
  }

  public override void dc(XmlElement A_0)
  {
    base.dc(A_0);
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.ab()))
    {
      // ISSUE: reference to a compiler-generated method
      this.y("SEA_ARC");
    }
    this.u = this.y(A_0, "innerradius");
    this.v = this.y(A_0, "outerradius");
    this.w = this.y(A_0, "angle");
  }
}
