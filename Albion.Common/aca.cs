// Decompiled with JetBrains decompiler
// Type: aca
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class aca : ix
{
  protected readonly HashSet<kd> d = new HashSet<kd>();
  protected readonly kq a;
  protected readonly ab9 b;
  protected readonly g8 c;
  protected abd<kd> e;

  public aca(kq A_0, ab9 A_1, g8 A_2)
    : base(A_0)
  {
    this.a = A_0;
    this.b = A_1;
    this.c = A_2;
  }

  public static ahk m(acb A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    ahk A_0_1 = ahk.d(A_1, A_0.w());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.a((float) (Math.Round(((double) A_0_1.g() - 5.0) / 10.0) * 10.0 + 5.0));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.b((float) (Math.Round(((double) A_0_1.h() - 5.0) / 10.0) * 10.0 + 5.0));
    // ISSUE: reference to a compiler-generated method
    return ahk.c(A_0_1, A_0.w());
  }

  public static ahk m(acb A_0, ahk A_1, kd.a A_2)
  {
    ahk A_1_1 = kd.p(A_0, ahk.d(), A_2);
    ahk A_0_1 = ahk.d(A_1, A_1_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.a((float) Math.Round((double) A_0_1.g()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.b((float) Math.Round((double) A_0_1.h()));
    return ahk.c(A_0_1, A_1_1);
  }

  [SpecialName]
  public acd u()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(this.p(), ahk.d(this.p(), this.q()));
  }

  [SpecialName]
  public IEnumerable v()
  {
    return (IEnumerable) this.d;
  }

  [SpecialName]
  public int w()
  {
    return this.d.Count;
  }

  [SpecialName]
  public kq x()
  {
    return this.a;
  }

  protected override void c5(ahk A_0, ahk A_1, float A_2, float A_3, float A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.n(A_0);
    // ISSUE: reference to a compiler-generated method
    this.m(A_1);
    // ISSUE: reference to a compiler-generated method
    this.o(A_2);
    // ISSUE: reference to a compiler-generated method
    this.n(A_3);
    // ISSUE: reference to a compiler-generated method
    this.m(A_4);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b.f((int) Math.Round((double) this.q().g()), (int) Math.Round((double) this.q().h()), this.p());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e = new abd<kd>(this.q().g(), this.q().h(), this.p(), 50, 50);
  }

  public virtual void y()
  {
    this.d.Clear();
  }

  public bool n(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.c.ap().hz(A_0) != null;
  }

  public bool o(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.c.ap().hz(A_0) is dv;
  }

  public bool p(string A_0)
  {
    return A_0.Contains("MiniMapMarker");
  }

  public bool q(string A_0)
  {
    return A_0.Contains("WorldMapMarker");
  }

  public acb r(string A_0)
  {
    return this.a.b(A_0);
  }

  public HashSet<kd> o(ahk A_0)
  {
    return this.e.b(A_0);
  }

  public HashSet<kd> m(acd A_0)
  {
    return this.e.c(A_0);
  }

  public float p(ahk A_0)
  {
    float val1 = float.MinValue;
    foreach (kd kd in this.o(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground || kd.u().x() == acb.TileType.Object)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float val2 = kd.q(A_0.g(), A_0.h());
        val1 = Math.Max(val1, val2);
      }
    }
    return val1;
  }

  public float q(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_1 = new ahk((float) (int) ((double) A_0.g() + 0.5), (float) (int) ((double) A_0.h() + 0.5));
    ahk ahk = ahk.c(A_0, ahk.d(A_0_1, new ahk(-0.5f, -0.5f)));
    // ISSUE: reference to a compiler-generated method
    float num1 = ahk.g();
    // ISSUE: reference to a compiler-generated method
    float num2 = ahk.h();
    float num3 = this.p(ahk.d(A_0_1, new ahk(-0.5f, -0.5f)));
    float num4 = this.p(ahk.d(A_0_1, new ahk(0.5f, -0.5f)));
    float num5 = this.p(ahk.d(A_0_1, new ahk(-0.5f, 0.5f)));
    float num6 = this.p(ahk.d(A_0_1, new ahk(0.5f, 0.5f)));
    return (float) ((double) num3 + ((double) num4 - (double) num3) * (double) num1 + ((double) num5 - (double) num3) * (double) num2 + ((double) num3 - (double) num4 - (double) num5 + (double) num6) * (double) num1 * (double) num2);
  }

  public kd r(ahk A_0)
  {
    float num1 = float.MinValue;
    kd kd1 = (kd) null;
    foreach (kd kd2 in this.o(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd2.u().x() == acb.TileType.Ground || kd2.u().x() == acb.TileType.Object)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float num2 = kd2.q(A_0.g(), A_0.h());
        if ((double) num2 > (double) num1)
        {
          num1 = num2;
          kd1 = kd2;
        }
      }
    }
    return kd1;
  }

  public kb m(bd A_0, ahk A_1)
  {
    ahk A_2;
    return this.m(A_0, A_1, out A_2);
  }

  public kb m(bd A_0, ahk A_1, out ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    acb A_1_1 = this.r(A_0.c9());
    if (A_1_1 != null)
      return this.m(A_0, A_1_1, A_1, out A_2);
    A_2 = ahk.d();
    return kb.b;
  }

  public kb m(bd A_0, acb A_1, ahk A_2, out ahk A_3)
  {
    ahk A_0_1 = aca.m(A_1, A_2);
    A_3 = A_0_1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acd A_0_2 = new acd(ahk.d(ahk.d(A_0_1, A_1.w()), new ahk(0.01f, 0.01f)), ahk.c(ahk.d(ahk.d(A_0_1, A_1.w()), new ahk((float) A_1.u(), (float) A_1.v())), new ahk(0.01f, 0.01f)));
    HashSet<kd> kdSet = this.e.c(A_0_2);
    float num1 = float.MaxValue;
    float num2 = 0.0f;
    foreach (kd kd in kdSet)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() != acb.TileType.Ground && kd.u().x() != acb.TileType.RealEstate && kd.u().o())
        return kb.c;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground && !A_0.ba(kd.u().y()))
        return kb.d;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground)
        num2 += A_0_2.l(kd.y()).n();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) num1 != 3.40282346638529E+38 && (double) kd.p().l() != (double) num1)
          return kb.e;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        num1 = kd.p().l();
      }
    }
    return (double) Math.Abs(A_0_2.n() - num2) >= 1.0 ? kb.d : kb.a;
  }

  public kb m(acb A_0, abc.Placeability A_1, ahk A_2, kd.a A_3, int A_4, bool A_5, out ahk A_6)
  {
    int A_7;
    return this.m(A_0, A_1, A_2, A_3, A_4, A_5, out A_6, out A_7);
  }

  public kb m(acb A_0, abc.Placeability A_1, ahk A_2, kd.a A_3, int A_4, bool A_5, out ahk A_6, out int A_7)
  {
    return this.m(A_0, A_1, A_2, A_3, A_4, (kd) null, A_5, out A_6, out A_7);
  }

  public virtual kb m(acb A_0, abc.Placeability A_1, ahk A_2, kd.a A_3, int A_4, kd A_5, bool A_6, out ahk A_7, out int A_8)
  {
    A_8 = 0;
    A_7 = aca.m(A_0, A_2, A_3);
    acd A_0_1 = kd.o(A_0, A_7, A_3);
    bool flag1 = A_6 ? (A_1 & abc.Placeability.Dungeons) != abc.Placeability.Nowhere : (A_1 & abc.Placeability.Outdoor) != abc.Placeability.Nowhere;
    bool flag2 = (A_1 & abc.Placeability.Indoor) != abc.Placeability.Nowhere;
    if (!flag1 && !flag2)
      return kb.f;
    bool flag3 = flag2 && !flag1;
    bool flag4 = this.n(A_0_1);
    if (flag3 && !flag4)
      return kb.f;
    if (flag4)
      A_4 = 0;
    A_8 = A_4;
    acd A_0_2 = A_0_1.l((float) -A_4);
    if (A_5 != null)
      this.m(A_5);
    if (((int) this.b.h(A_0_2) & 37) != 0)
    {
      if (A_5 != null)
        this.o(A_5);
      return kb.c;
    }
    if (A_5 != null)
      this.o(A_5);
    bool flag5 = flag1 && !flag2;
    bool flag6 = this.o(A_0_1);
    if (flag5 && !flag6)
      return kb.f;
    if (flag4 && flag6)
      return kb.c;
    HashSet<kd> kdSet = this.e.c(A_0_1);
    kdSet.Remove(A_5);
    float num = 0.0f;
    foreach (kd kd in kdSet)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground)
        num += A_0_1.l(kd.y()).n();
    }
    return (double) Math.Abs(A_0_1.n() - num) >= 1.0 ? kb.b : kb.a;
  }

  public void m(kd A_0)
  {
    acd A_0_1 = A_0.y();
    HashSet<kd> kdSet1 = this.m(A_0_1);
    kdSet1.Remove(A_0);
    foreach (kd A_0_2 in kdSet1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0_2.u().x() == acb.TileType.Ground)
      {
        this.b.f(A_0_2, ab9.a.a);
        A_0_1.m(A_0_2.y());
      }
    }
    HashSet<kd> kdSet2 = this.m(A_0_1);
    kdSet2.Remove(A_0);
    foreach (kd A_0_2 in kdSet2)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0_2.u().x() != acb.TileType.Ground)
        this.b.f(A_0_2, ab9.a.b);
    }
  }

  public bool n(acd A_0)
  {
    return ((int) this.b.f(A_0, (byte) 16) & 16) != 0;
  }

  public bool o(acd A_0)
  {
    return ((int) this.b.h(A_0) & 16) == 0;
  }

  public float p(acd A_0)
  {
    float num = 0.0f;
    foreach (kd kd in this.e.c(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground && kd.u().y() == acb.TileGroundType.BuildingArea)
        num += A_0.l(kd.y()).n();
    }
    return num;
  }

  public kd m(ahk A_0, float A_1, acb A_2)
  {
    A_0 = aca.m(A_2, A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acd acd = new acd(ahk.d(ahk.d(A_0, A_2.w()), new ahk(0.01f, 0.01f)), ahk.c(ahk.d(ahk.d(A_0, A_2.w()), new ahk((float) A_2.u(), (float) A_2.v())), new ahk(0.01f, 0.01f)));
    HashSet<kd> kdSet = this.e.b(A_0);
    float A_1_1 = 0.0f;
    foreach (kd kd in kdSet)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_1_1 = kd.p().l();
        break;
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kd A_0_1 = new kd(A_2, new acf(A_0.g(), A_1_1, A_0.h()), A_1);
    if (!this.q(A_0_1))
      return (kd) null;
    this.b.f(A_0_1, ab9.a.b);
    return A_0_1;
  }

  public kd n(ahk A_0, float A_1, acb A_2)
  {
    return this.m(A_0, A_1, A_2, true);
  }

  public kd m(ahk A_0, float A_1, acb A_2, bool A_3)
  {
    if (A_3)
      A_0 = aca.m(A_2, A_0, kd.o(A_1));
    float A_1_1 = this.p(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kd A_0_1 = new kd(A_2, new acf(A_0.g(), A_1_1, A_0.h()), A_1);
    if (!this.q(A_0_1))
      return (kd) null;
    this.b.f(A_0_1, ab9.a.b);
    return A_0_1;
  }

  public kd o(ahk A_0, float A_1, acb A_2)
  {
    A_0 = aca.m(A_2, A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    HashSet<kd> A_0_1 = this.e.c(new acd(ahk.d(ahk.d(A_0, A_2.w()), new ahk(0.01f, 0.01f)), ahk.c(ahk.d(ahk.d(A_0, A_2.w()), new ahk((float) A_2.u(), (float) A_2.v())), new ahk(0.01f, 0.01f))));
    float A_1_1 = this.p(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kd A_0_2 = new kd(A_2, new acf(A_0.g(), A_1_1, A_0.h()), A_1);
    // ISSUE: reference to a compiler-generated method
    A_0_2.o(A_0_1);
    foreach (kd A_0_3 in A_0_1)
      this.p(A_0_3);
    if (!this.q(A_0_2))
      return (kd) null;
    this.b.f(A_0_2, ab9.a.a);
    return A_0_2;
  }

  public void n(kd A_0)
  {
    this.p(A_0);
    // ISSUE: reference to a compiler-generated method
    if (A_0.x() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (kd A_0_1 in A_0.x())
        this.q(A_0_1);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!A_0.u().o())
      return;
    this.o(A_0);
  }

  public void o(kd A_0)
  {
    this.q(A_0.y());
  }

  public void z()
  {
    this.q(this.u());
  }

  public void q(acd A_0)
  {
    foreach (kd A_0_1 in this.m(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0_1.u().x() == acb.TileType.Ground)
      {
        this.b.f(A_0_1, ab9.a.a);
        A_0.m(A_0_1.y());
      }
    }
    foreach (kd A_0_1 in this.m(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0_1.u().x() != acb.TileType.Ground)
        this.b.f(A_0_1, ab9.a.b);
    }
  }

  public kd s(ahk A_0)
  {
    foreach (kd kd in this.e.b(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kd.u().x() == acb.TileType.Ground)
        return kd;
    }
    return (kd) null;
  }

  protected void p(kd A_0)
  {
    this.e.c(A_0, A_0.y());
    this.d.Remove(A_0);
    this.dj(A_0);
  }

  public bool q(kd A_0)
  {
    if (!this.e.b(A_0, A_0.y()))
      return false;
    this.d.Add(A_0);
    this.di(A_0);
    return true;
  }

  protected virtual void di(kd A_0)
  {
  }

  protected virtual void dj(kd A_0)
  {
  }

  protected override bool c6(kd A_0)
  {
    bool flag = base.c6(A_0);
    if (flag)
      this.q(A_0);
    return flag;
  }

  protected override void cu()
  {
    base.cu();
    this.b.l();
    this.z();
  }
}
