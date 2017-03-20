// Decompiled with JetBrains decompiler
// Type: aa6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class aa6<a> where a : aa2
{
  private float a;
  private aa6<a>.c b;
  private aa6<a>.d c;
  private float d;
  private ahy e;
  private float f;
  private GameTimeStamp g;
  private GameTimeStamp h;
  private a i;

  public aa6(long A_0, float A_1, aa6<a>.a A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.j(A_0);
    // ISSUE: reference to a compiler-generated method
    this.j(aa6<a>.b.b);
    // ISSUE: reference to a compiler-generated method
    this.k(A_1);
    // ISSUE: reference to a compiler-generated method
    this.j(A_2);
  }

  public aa6(long A_0, float A_1, aa6<a>.a A_2, aa6<a>.b A_3)
  {
    // ISSUE: reference to a compiler-generated method
    this.j(A_0);
    // ISSUE: reference to a compiler-generated method
    this.j(A_3);
    // ISSUE: reference to a compiler-generated method
    this.k(A_1);
    // ISSUE: reference to a compiler-generated method
    this.j(A_2);
  }

  [SpecialName]
  public float l()
  {
    return this.d;
  }

  [SpecialName]
  public void l(float A_0)
  {
    double num = (double) this.l(GameTimeStamp.Now);
    // ISSUE: reference to a compiler-generated method
    if (this.p() == aa6<a>.b.a)
    {
      this.d = A_0;
      this.a = Math.Min(this.a, this.d);
    }
    else if ((double) this.d != 0.0)
    {
      this.a = (float) Math.Ceiling((double) this.a / (double) this.d * (double) A_0);
      this.d = A_0;
      this.a = Math.Min(this.a, this.d);
    }
    else
    {
      this.d = A_0;
      this.a = Math.Min(this.a, this.d);
    }
  }

  [SpecialName]
  public GameTimeStamp n()
  {
    return GameTimeStamp.a(this.g, this.e);
  }

  [SpecialName]
  public void j(aa6<a>.c A_0)
  {
    this.b += A_0;
  }

  [SpecialName]
  public void k(aa6<a>.c A_0)
  {
    this.b -= A_0;
  }

  [SpecialName]
  public void j(aa6<a>.d A_0)
  {
    this.c += A_0;
  }

  [SpecialName]
  public void k(aa6<a>.d A_0)
  {
    this.c -= A_0;
  }

  public void j(float A_0, float A_1)
  {
    this.d = A_1;
    this.a = Math.Min(this.l(), A_0);
    // ISSUE: reference to a compiler-generated method
    this.a = Math.Max(this.k(), this.a);
  }

  public float r()
  {
    double num = (double) this.l(GameTimeStamp.Now);
    return this.a;
  }

  public ahy s()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.m() <= 0.0)
      return ahy.f;
    // ISSUE: reference to a compiler-generated method
    return ahy.l((double) (this.l() - this.r()) / (double) this.m());
  }

  public void j(a A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h = A_0.ad();
    this.i = A_0;
    // ISSUE: reference to a compiler-generated method
    if (this.o() == aa6<a>.a.b)
    {
      // ISSUE: reference to a compiler-generated method
      this.a = A_0.ab();
      // ISSUE: reference to a compiler-generated method
      this.g = this.j(A_0.ad());
      // ISSUE: reference to a compiler-generated method
      double num = (double) this.l(A_0.ad());
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      A_0.r(GameTimeStamp.Now);
      // ISSUE: reference to a compiler-generated method
      double num = (double) this.l(A_0.ad());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a += Math.Max(Math.Min(A_0.aa(), this.l() - this.a), this.k() - this.a);
    }
    if (this.c != null)
      this.c(this, A_0);
    if ((double) this.a > 0.0 || this.b == null)
      return;
    this.b(this, A_0);
  }

  public void t()
  {
    double num = (double) this.l(GameTimeStamp.Now);
    // ISSUE: reference to a compiler-generated method
    this.j(0.0f);
    this.f = 0.0f;
    // ISSUE: reference to a compiler-generated method
    this.k(new GameTimeStamp(0L));
    this.e = new ahy(0L);
    this.g = new GameTimeStamp(0L);
  }

  public void j(GameTimeStamp A_0, float A_1, float A_2)
  {
    this.a = Math.Min(this.d, A_2);
    // ISSUE: reference to a compiler-generated method
    this.a = Math.Max(this.k(), this.a);
    if ((double) A_1 == 0.0)
    {
      this.f = 0.0f;
      this.e = new ahy(0L);
    }
    else
    {
      this.e = ahy.k(1000.0 / (double) Math.Abs(A_1));
      this.f = (double) A_1 < 0.0 ? -1f : 1f;
      if (this.e.o == 0L)
        this.e = new ahy(1L);
    }
    // ISSUE: reference to a compiler-generated method
    this.k(A_0);
    // ISSUE: reference to a compiler-generated method
    this.j(A_1);
    this.g = GameTimeStamp.b(A_0, this.e);
  }

  private GameTimeStamp j(GameTimeStamp A_0)
  {
    if ((double) this.f == 0.0)
      return GameTimeStamp.MaxValue;
    // ISSUE: reference to a compiler-generated method
    if (GameTimeStamp.h(this.j(), A_0))
    {
      // ISSUE: reference to a compiler-generated method
      A_0 = this.j();
    }
    // ISSUE: reference to a compiler-generated method
    ahy A_1 = new ahy(GameTimeStamp.c(A_0, this.j()).o % this.e.o);
    return GameTimeStamp.a(GameTimeStamp.b(A_0, this.e), A_1);
  }

  public float l(GameTimeStamp A_0)
  {
    if (GameTimeStamp.h(this.g, A_0) || this.e.o <= 0L && (double) this.f == 0.0)
      return this.a;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.m() > 0.0 && (double) this.a >= (double) this.l() || (double) this.m() < 0.0 && (double) this.a <= 0.0)
    {
      this.g = this.j(A_0);
    }
    else
    {
      this.a = Math.Min(this.d, this.a + this.f * (float) (GameTimeStamp.c(A_0, this.g).o / this.e.o + 1L));
      // ISSUE: reference to a compiler-generated method
      this.a = Math.Max(this.k(), this.a);
      this.g = this.j(A_0);
    }
    return this.a;
  }

  public enum a
  {
    a,
    b,
  }

  public enum b
  {
    a,
    b,
  }

  public delegate void c(aa6<a> A_0, a A_1) where a : aa2;

  public delegate void d(aa6<a> A_0, a A_1) where a : aa2;
}
