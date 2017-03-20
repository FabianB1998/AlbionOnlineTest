// Decompiled with JetBrains decompiler
// Type: kh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class kh
{
  public abf a(ab9 A_0, float A_1, ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new abf((int) Math.Round(((double) A_2.g() - (double) A_0.h().g()) * (double) A_1), (int) Math.Round(((double) A_2.h() - (double) A_0.h().h()) * (double) A_1));
  }

  public ahk a(ab9 A_0, float A_1, abf A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.h().g() + (float) A_2.c() / A_1, A_0.h().h() + (float) A_2.d() / A_1);
  }

  public abf a(ahk A_0, ab9 A_1, float A_2, float A_3)
  {
    abf A_1_1 = this.a(A_1, A_2, A_0);
    kl kl = A_1.f(A_2, A_3);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((int) kl.e(A_1_1.c(), A_1_1.d()) == 0)
      return A_1_1;
    float num1 = float.MaxValue;
    abf A_0_1 = A_1_1;
    for (int index1 = -2; index1 <= 2; ++index1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_1_1.d() + index1 >= 0 && A_1_1.d() + index1 < kl.h())
      {
        for (int index2 = -2; index2 <= 2; ++index2)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (A_1_1.c() + index2 >= 0 && A_1_1.c() + index2 < kl.g() && (int) kl.e(A_1_1.c() + index2, A_1_1.d() + index1) == 0)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            abf A_2_1 = new abf(A_1_1.c() + index2, A_1_1.d() + index1);
            float num2 = ahk.c(this.a(A_1, A_2, A_2_1), A_0).j();
            if ((double) num2 < (double) num1)
            {
              A_0_1 = A_2_1;
              num1 = num2;
            }
          }
        }
      }
    }
    abf.d(A_0_1, A_1_1);
    return A_0_1;
  }

  public kh.b a(kh.a A_0)
  {
    kh.b b = new kh.b();
    // ISSUE: reference to a compiler-generated method
    b.h(A_0);
    // ISSUE: reference to a compiler-generated method
    b.h(false);
    // ISSUE: reference to a compiler-generated method
    b.h((km) null);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!A_0.l().i().i(A_0.o()) || !A_0.l().i().i(A_0.p()))
      return b;
    abf A_3;
    abf A_4;
    // ISSUE: reference to a compiler-generated method
    if (A_0.r())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_3 = this.a(A_0.o(), A_0.l(), A_0.m(), A_0.n());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_4 = this.a(A_0.p(), A_0.l(), A_0.m(), A_0.n());
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_3 = this.a(A_0.l(), A_0.m(), A_0.o());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_4 = this.a(A_0.l(), A_0.m(), A_0.p());
    }
    Dictionary<abf, kh.c> A_9;
    TimeSpan A_10;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    List<abf> A_0_1 = this.cv(A_0.l(), A_0.m(), A_0.n(), A_3, A_4, A_0.q(), A_0.s() * A_0.m(), A_0.t(), A_0.u(), out A_9, out A_10);
    // ISSUE: reference to a compiler-generated method
    b.h(A_10);
    // ISSUE: reference to a compiler-generated method
    b.h(A_9 != null ? (long) A_9.Count : 0L);
    // ISSUE: reference to a compiler-generated method
    if (A_0.v())
    {
      // ISSUE: reference to a compiler-generated method
      b.h(A_9);
      // ISSUE: reference to a compiler-generated method
      b.h(A_0_1);
    }
    if (A_0_1 != null)
    {
      ahk[] A_0_2 = new ahk[A_0_1.Count];
      for (int index = 0; index < A_0_1.Count; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_2[index] = this.a(A_0.l(), A_0.m(), A_0_1[index]);
      }
      // ISSUE: reference to a compiler-generated method
      b.h(true);
      // ISSUE: reference to a compiler-generated method
      b.h(new km(A_0_2));
    }
    return b;
  }

  protected abstract List<abf> cv(ab9 A_0, float A_1, float A_2, abf A_3, abf A_4, float A_5, float A_6, long A_7, TimeSpan A_8, out Dictionary<abf, kh.c> A_9, out TimeSpan A_10);

  protected List<abf> a(ab9 A_0, float A_1, float A_2, kh.c A_3)
  {
    return this.a(A_0, A_1, A_2, A_3, true, true);
  }

  protected List<abf> a(ab9 A_0, float A_1, float A_2, kh.c A_3, bool A_4, bool A_5)
  {
    if (A_5)
      A_4 = true;
    List<abf> A_3_1 = new List<abf>();
    abf A_0_1 = new abf(666, 666);
    // ISSUE: reference to a compiler-generated method
    abf A_0_2 = A_3.l();
    // ISSUE: reference to a compiler-generated method
    for (kh.c c = A_3; c != null; c = c.k())
    {
      // ISSUE: reference to a compiler-generated method
      abf A_1_1 = abf.e(A_0_2, c.l());
      if (A_4 && abf.d(A_0_1, A_1_1))
      {
        // ISSUE: reference to a compiler-generated method
        A_3_1[A_3_1.Count - 1] = c.l();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        A_3_1.Add(c.l());
      }
      A_0_1 = A_1_1;
      // ISSUE: reference to a compiler-generated method
      A_0_2 = c.l();
    }
    A_3_1.Reverse();
    if (A_5)
      this.a(A_0, A_1, A_2, A_3_1);
    return A_3_1;
  }

  protected void a(ab9 A_0, float A_1, float A_2, List<abf> A_3)
  {
    int index = 0;
    while (index < A_3.Count - 2)
    {
      ahk A_0_1 = this.a(A_0, A_2, A_3[index]);
      ahk ahk = this.a(A_0, A_2, A_3[index + 2]);
      ahk A_2_1;
      if (!A_0.f(A_0_1, ahk, out A_2_1, byte.MaxValue) && A_0.f(A_0_1, ahk, A_1, 0).c(ahk, 0.1f))
        A_3.RemoveAt(index + 1);
      else
        ++index;
    }
  }

  public class a
  {
    public a()
    {
      // ISSUE: reference to a compiler-generated method
      this.l(true);
      // ISSUE: reference to a compiler-generated method
      this.l(long.MaxValue);
      // ISSUE: reference to a compiler-generated method
      this.o(float.MaxValue);
      // ISSUE: reference to a compiler-generated method
      this.l(TimeSpan.MaxValue);
      // ISSUE: reference to a compiler-generated method
      this.m(false);
    }
  }

  public class b
  {
  }

  public class c : IComparable<kh.c>, IEqualityComparer<kh.c>
  {
    public c(abf A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.g(A_0);
      // ISSUE: reference to a compiler-generated method
      this.g(false);
    }

    [SpecialName]
    public float i()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.g() + this.h();
    }

    public kh.c h(abf A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.g(A_0);
      // ISSUE: reference to a compiler-generated method
      this.g(false);
      return this;
    }

    public int CompareTo(kh.c other)
    {
      if ((double) this.i() > (double) other.i())
        return 1;
      return (double) this.i() == (double) other.i() ? 0 : -1;
    }

    public bool Equals(kh.c a, kh.c b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return a.l().Equals((object) b.l());
    }

    public int GetHashCode(kh.c obj)
    {
      // ISSUE: reference to a compiler-generated method
      return this.l().GetHashCode();
    }
  }
}
