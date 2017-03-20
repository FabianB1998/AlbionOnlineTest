// Decompiled with JetBrains decompiler
// Type: kx
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct kx : IComparable<kx>, IEquatable<kx>
{
  public static readonly kx g = new kx();
  public static readonly kx h = new kx(10000L);
  public static readonly kx i = new kx(long.MaxValue);
  public static readonly kx j = new kx(long.MinValue);
  public static readonly kx k = new kx(1L);
  public const long a = 10000;
  public const long b = 5000;
  private const long c = 9223372036854775807;
  private const long d = -9223372036854775808;
  public const long e = 922337203685477;
  public const long f = -922337203685477;

  private kx(long A_0)
  {
    this = new kx();
    // ISSUE: reference to a compiler-generated method
    this.h(A_0);
  }

  [SpecialName]
  public long j()
  {
    // ISSUE: reference to a compiler-generated method
    return this.i() / 10000L;
  }

  [SpecialName]
  public long k()
  {
    // ISSUE: reference to a compiler-generated method
    return this.i() % 10000L;
  }

  [SpecialName]
  public double l()
  {
    return this.m() - (double) this.j();
  }

  [SpecialName]
  public double m()
  {
    // ISSUE: reference to a compiler-generated method
    return (double) this.i() / 10000.0;
  }

  public static kx f(double A_0)
  {
    if (A_0 > 922337203685477.0)
      A_0 = 922337203685477.0;
    if (A_0 < -922337203685477.0)
      A_0 = -922337203685477.0;
    return new kx((long) Math.Round(A_0 * 10000.0));
  }

  public static kx g(long A_0)
  {
    if (A_0 > 922337203685477L)
      A_0 = 922337203685477L;
    if (A_0 < -922337203685477L)
      A_0 = -922337203685477L;
    return new kx(A_0 * 10000L);
  }

  public static bool g(string A_0, out kx A_1)
  {
    long result;
    if (long.TryParse(A_0, NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result) && result >= -922337203685477L && result <= 922337203685477L)
    {
      A_1 = kx.g(result);
      return true;
    }
    A_1 = kx.g;
    return false;
  }

  public static bool f(string A_0, out kx A_1)
  {
    long result;
    if (long.TryParse(A_0, NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result) && result >= long.MinValue && result <= long.MaxValue)
    {
      A_1 = kx.f(result);
      return true;
    }
    A_1 = kx.g;
    return false;
  }

  public static kx f(long A_0)
  {
    return new kx(A_0);
  }

  public static kx h()
  {
    return kx.i;
  }

  public static kx g()
  {
    return kx.j;
  }

  public static kx f()
  {
    return kx.g;
  }

  public long n()
  {
    if (this.k() == 5000L)
    {
      if (this.j() % 2L == 0L)
        return this.j();
      return this.j() + 1L;
    }
    // ISSUE: reference to a compiler-generated method
    if (this.i() >= 0L)
    {
      if (this.k() > 5000L)
        return this.j() + 1L;
    }
    else if (this.k() < -5000L)
      return this.j() - 1L;
    return this.j();
  }

  public kx o()
  {
    return kx.g(this.n());
  }

  public long p()
  {
    if (this.k() > 0L)
      return this.j() + 1L;
    return this.j();
  }

  public kx q()
  {
    return new kx(this.p() * 10000L);
  }

  public kx r()
  {
    return new kx(this.j() * 10000L);
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    return this.i().GetHashCode();
  }

  public int CompareTo(kx other)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i() == other.i())
      return 0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.i() > other.i() ? 1 : -1;
  }

  public bool Equals(kx other)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return other.i() == this.i();
  }

  public override bool Equals(object obj)
  {
    if (!(obj is kx))
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ((kx) obj).i() == this.i();
  }

  public override string ToString()
  {
    return string.Format("{0}.{1:0000}", (object) this.j(), (object) Math.Abs(this.k()));
  }

  [SpecialName]
  public static kx q(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    long A_0_1 = A_0.i() + A_1.i();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() > 0L && A_1.i() > 0L && A_0_1 < 0L)
      return kx.i;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() < 0L && A_1.i() < 0L && A_0_1 > 0L)
      return kx.j;
    return new kx(A_0_1);
  }

  [SpecialName]
  public static kx p(kx A_0, kx A_1)
  {
    return kx.q(A_0, kx.g(A_1));
  }

  [SpecialName]
  public static kx g(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return new kx(-A_0.i());
  }

  [SpecialName]
  public static kx o(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    long num = A_0.i() * A_1.i();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() == 0L || num / A_0.i() == A_1.i())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new kx(A_0.i() * A_1.i() / 10000L);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() > 0L && A_1.i() > 0L || A_0.i() < 0L && A_1.i() < 0L)
      return kx.i;
    return kx.j;
  }

  [SpecialName]
  public static kx f(kx A_0, int A_1)
  {
    return kx.o(A_0, kx.g((long) A_1));
  }

  [SpecialName]
  public static kx f(int A_0, kx A_1)
  {
    return kx.o(A_1, kx.g((long) A_0));
  }

  [SpecialName]
  public static kx f(kx A_0, long A_1)
  {
    return kx.o(A_0, kx.g(A_1));
  }

  [SpecialName]
  public static kx f(long A_0, kx A_1)
  {
    return kx.o(A_1, kx.g(A_0));
  }

  public static kx n(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 0L)
      return kx.i;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() <= long.MaxValue && A_0.i() >= long.MinValue)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new kx(A_0.i() * 10000L / A_1.i());
    }
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() > 100000000L)
    {
      // ISSUE: reference to a compiler-generated method
      return new kx(A_0.i() / A_1.j());
    }
    return kx.g;
  }

  [SpecialName]
  public static bool m(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() == A_1.i();
  }

  [SpecialName]
  public static bool l(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() != A_1.i();
  }

  [SpecialName]
  public static bool k(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() > A_1.i();
  }

  [SpecialName]
  public static bool j(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() < A_1.i();
  }

  [SpecialName]
  public static bool i(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() >= A_1.i();
  }

  [SpecialName]
  public static bool h(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.i() <= A_1.i();
  }

  public static kx g(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() < A_1.i())
      return A_0;
    return A_1;
  }

  public static kx f(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() > A_1.i())
      return A_0;
    return A_1;
  }

  public static kx f(kx A_0, kx A_1, kx A_2)
  {
    return kx.g(A_2, kx.f(A_0, A_1));
  }

  public static kx f(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() < 0L)
    {
      // ISSUE: reference to a compiler-generated method
      return kx.f(-A_0.i());
    }
    return A_0;
  }
}
