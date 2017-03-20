// Decompiled with JetBrains decompiler
// Type: k2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public struct k2
{
  private static k2 a = new k2();
  private static k2 b = new k2(new acf(1f, 0.0f, 0.0f), new acf(0.0f, 1f, 0.0f), new acf(0.0f, 0.0f, 1f));
  public acf c;
  public acf d;
  public acf e;

  public k2(acf A_0, acf A_1, acf A_2)
  {
    this.c = A_0;
    this.d = A_1;
    this.e = A_2;
  }

  public k2(k2 A_0)
  {
    this.c = A_0.c;
    this.d = A_0.d;
    this.e = A_0.e;
  }

  [SpecialName]
  public static k2 b()
  {
    return k2.a;
  }

  [SpecialName]
  public static k2 a()
  {
    return k2.b;
  }

  [SpecialName]
  public ahk i()
  {
    return this.e.n();
  }

  [SpecialName]
  public void i(ahk A_0)
  {
    this.e.a(A_0);
  }

  [SpecialName]
  public ahk j()
  {
    return new ahk(this.c.n().k(), this.d.n().k());
  }

  [SpecialName]
  public float k()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) Math.Atan2((double) this.c.l(), (double) this.c.k());
  }

  public override bool Equals(object pOther)
  {
    if (!(pOther is k2))
      return false;
    k2 k2 = (k2) pOther;
    if (acf.b(this.c, k2.c) && acf.b(this.d, k2.d))
      return acf.b(this.e, k2.e);
    return false;
  }

  public override int GetHashCode()
  {
    return this.c.GetHashCode() ^ this.d.GetHashCode() ^ this.e.GetHashCode();
  }

  [SpecialName]
  public static bool i(k2 A_0, k2 A_1)
  {
    if (acf.b(A_0.c, A_1.c) && acf.b(A_0.d, A_1.d))
      return acf.b(A_0.e, A_1.e);
    return false;
  }

  [SpecialName]
  public static bool b(k2 A_0, k2 A_1)
  {
    if (!acf.a(A_0.c, A_1.c) && !acf.a(A_0.d, A_1.d))
      return acf.a(A_0.e, A_1.e);
    return true;
  }

  public bool l()
  {
    return k2.i(this, k2.a());
  }

  public k2 m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new k2(new acf(this.c.k(), this.d.k(), this.e.k()), new acf(this.c.l(), this.d.l(), this.e.l()), new acf(this.c.m(), this.d.m(), this.e.m()));
  }

  [SpecialName]
  public static k2 a(k2 A_0, k2 A_1)
  {
    k2 k2 = new k2();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.a((float) ((double) A_0.c.k() * (double) A_1.c.k() + (double) A_0.c.l() * (double) A_1.d.k() + (double) A_0.c.m() * (double) A_1.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.b((float) ((double) A_0.c.k() * (double) A_1.c.l() + (double) A_0.c.l() * (double) A_1.d.l() + (double) A_0.c.m() * (double) A_1.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.c((float) ((double) A_0.c.k() * (double) A_1.c.m() + (double) A_0.c.l() * (double) A_1.d.m() + (double) A_0.c.m() * (double) A_1.e.m()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.a((float) ((double) A_0.d.k() * (double) A_1.c.k() + (double) A_0.d.l() * (double) A_1.d.k() + (double) A_0.d.m() * (double) A_1.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.b((float) ((double) A_0.d.k() * (double) A_1.c.l() + (double) A_0.d.l() * (double) A_1.d.l() + (double) A_0.d.m() * (double) A_1.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.c((float) ((double) A_0.d.k() * (double) A_1.c.m() + (double) A_0.d.l() * (double) A_1.d.m() + (double) A_0.d.m() * (double) A_1.e.m()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.a((float) ((double) A_0.e.k() * (double) A_1.c.k() + (double) A_0.e.l() * (double) A_1.d.k() + (double) A_0.e.m() * (double) A_1.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.b((float) ((double) A_0.e.k() * (double) A_1.c.l() + (double) A_0.e.l() * (double) A_1.d.l() + (double) A_0.e.m() * (double) A_1.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.c((float) ((double) A_0.e.k() * (double) A_1.c.m() + (double) A_0.e.l() * (double) A_1.d.m() + (double) A_0.e.m() * (double) A_1.e.m()));
    return k2;
  }

  [SpecialName]
  public static acf a(acf A_0, k2 A_1)
  {
    acf acf = new acf();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf.a((float) ((double) A_0.k() * (double) A_1.c.k() + (double) A_0.l() * (double) A_1.d.k() + (double) A_0.m() * (double) A_1.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf.b((float) ((double) A_0.k() * (double) A_1.c.l() + (double) A_0.l() * (double) A_1.d.l() + (double) A_0.m() * (double) A_1.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf.c((float) ((double) A_0.k() * (double) A_1.c.m() + (double) A_0.l() * (double) A_1.d.m() + (double) A_0.m() * (double) A_1.e.m()));
    return acf;
  }

  public void n()
  {
    this.e = this.c.c(this.d);
    this.c = this.d.c(this.e);
    this.c.s();
    this.d.s();
    this.e.s();
  }

  public void o()
  {
    // ISSUE: reference to a compiler-generated method
    float A_0_1 = this.c.l();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c.b(this.d.k());
    // ISSUE: reference to a compiler-generated method
    this.d.a(A_0_1);
    // ISSUE: reference to a compiler-generated method
    float A_0_2 = this.c.m();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c.c(this.e.k());
    // ISSUE: reference to a compiler-generated method
    this.e.a(A_0_2);
    // ISSUE: reference to a compiler-generated method
    float A_0_3 = this.d.m();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d.c(this.e.l());
    // ISSUE: reference to a compiler-generated method
    this.e.b(A_0_3);
  }

  public void p()
  {
    this = this.q();
  }

  public k2 q()
  {
    k2 k2 = new k2();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.a((float) ((double) this.d.l() * (double) this.e.m() - (double) this.d.m() * (double) this.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.b((float) ((double) this.c.m() * (double) this.e.l() - (double) this.c.l() * (double) this.e.m()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.c.c((float) ((double) this.c.l() * (double) this.d.m() - (double) this.c.m() * (double) this.d.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.a((float) ((double) this.d.m() * (double) this.e.k() - (double) this.d.k() * (double) this.e.m()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.b((float) ((double) this.c.k() * (double) this.e.m() - (double) this.c.m() * (double) this.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.d.c((float) ((double) this.c.m() * (double) this.d.k() - (double) this.c.k() * (double) this.d.m()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.a((float) ((double) this.d.k() * (double) this.e.l() - (double) this.d.l() * (double) this.e.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.b((float) ((double) this.c.l() * (double) this.e.k() - (double) this.c.k() * (double) this.e.l()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    k2.e.c((float) ((double) this.c.k() * (double) this.d.l() - (double) this.c.l() * (double) this.d.k()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num = (float) ((double) this.c.k() * (double) k2.c.k() + (double) this.c.l() * (double) k2.d.k() + (double) this.c.m() * (double) k2.e.k());
    if ((double) Math.Abs(num) <= 9.99999974737875E-05)
      return this;
    float A_1 = 1f / num;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    k2& local1 = @k2;
    // ISSUE: explicit reference operation
    acf acf1 = acf.b((^local1).c, A_1);
    // ISSUE: explicit reference operation
    (^local1).c = acf1;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    k2& local2 = @k2;
    // ISSUE: explicit reference operation
    acf acf2 = acf.b((^local2).d, A_1);
    // ISSUE: explicit reference operation
    (^local2).d = acf2;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    k2& local3 = @k2;
    // ISSUE: explicit reference operation
    acf acf3 = acf.b((^local3).e, A_1);
    // ISSUE: explicit reference operation
    (^local3).e = acf3;
    return k2;
  }

  public static k2 b(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new k2(new acf(A_0.g(), 0.0f, 0.0f), new acf(0.0f, A_0.h(), 0.0f), acf.b());
  }

  public static k2 a(float A_0)
  {
    float A_0_1 = (float) Math.Sin((double) A_0);
    float num = (float) Math.Cos((double) A_0);
    return new k2(new acf(num, -A_0_1, 0.0f), new acf(A_0_1, num, 0.0f), acf.b());
  }

  public static k2 a(ahk A_0)
  {
    return new k2(acf.d(), acf.c(), new acf(A_0, 1f));
  }

  public static k2 a(float A_0, ahk A_1)
  {
    float A_0_1 = (float) Math.Sin((double) A_0);
    float num = (float) Math.Cos((double) A_0);
    return new k2(new acf(num, -A_0_1, 0.0f), new acf(A_0_1, num, 0.0f), new acf(A_1, 1f));
  }

  public static k2 a(ahk A_0, float A_1, ahk A_2)
  {
    float A_0_1 = (float) Math.Sin((double) A_1);
    float num = (float) Math.Cos((double) A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new k2(acf.a(A_0.g(), new acf(num, -A_0_1, 0.0f)), acf.a(A_0.h(), new acf(A_0_1, num, 0.0f)), new acf(A_2, 1f));
  }
}
