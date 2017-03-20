// Decompiled with JetBrains decompiler
// Type: kw
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct kw : IEquatable<kw>
{
  private static readonly kw a = new kw(0.0f, 0.0f);
  private static readonly kw b = new kw(1f, 0.0f);
  private static readonly kw c = new kw(0.0f, 1f);
  private static readonly kw d = new kw(1f, 1f);

  public kw(ky A_0, ky A_1)
  {
    this = new kw();
    // ISSUE: reference to a compiler-generated method
    this.a(A_0);
    // ISSUE: reference to a compiler-generated method
    this.b(A_1);
  }

  public kw(float A_0, float A_1)
  {
    this = new kw();
    // ISSUE: reference to a compiler-generated method
    this.a(ky.a(A_0));
    // ISSUE: reference to a compiler-generated method
    this.b(ky.a(A_1));
  }

  [SpecialName]
  public static kw d()
  {
    return kw.a;
  }

  [SpecialName]
  public static kw c()
  {
    return kw.b;
  }

  [SpecialName]
  public static kw b()
  {
    return kw.c;
  }

  [SpecialName]
  public static kw a()
  {
    return kw.d;
  }

  [SpecialName]
  public static kw d(kw A_0, kw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.k(A_0.g(), A_1.g()), ky.k(A_0.h(), A_1.h()));
  }

  [SpecialName]
  public static kw c(kw A_0, kw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.j(A_0.g(), A_1.g()), ky.j(A_0.h(), A_1.h()));
  }

  [SpecialName]
  public static kw a(kw A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.b(A_0.g()), ky.b(A_0.h()));
  }

  [SpecialName]
  public static kw b(kw A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.h(A_0.g(), A_1), ky.h(A_0.h(), A_1));
  }

  [SpecialName]
  public static kw a(float A_0, kw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.h(A_1.g(), A_0), ky.h(A_1.h(), A_0));
  }

  [SpecialName]
  public static kw a(kw A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new kw(ky.g(A_0.g(), A_1), ky.g(A_0.h(), A_1));
  }

  [SpecialName]
  public static bool b(kw A_0, kw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (ky.f(A_0.g(), A_1.g()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ky.f(A_0.h(), A_1.h());
    }
    return false;
  }

  [SpecialName]
  public static bool a(kw A_0, kw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!ky.e(A_0.g(), A_1.g()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ky.e(A_0.h(), A_1.h());
    }
    return true;
  }

  public ky b(kw A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ky.k(ky.h(this.g(), A_0.g()), ky.h(this.h(), A_0.h()));
  }

  public ky[] i()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ky[2]{ this.g(), this.h() };
  }

  public static kw a(float[] A_0)
  {
    if (A_0.Length == 2)
      return new kw(A_0[0], A_0[1]);
    return kw.d();
  }

  public ky j()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ky.k(ky.h(this.g(), this.g()), ky.h(this.h(), this.h()));
  }

  public ky k()
  {
    return ky.a(this.j());
  }

  public bool a(kw A_0, ky A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (ky.d(ky.d(ky.j(A_0.g(), this.g())), A_1))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ky.d(ky.d(ky.j(A_0.h(), this.h())), A_1);
    }
    return false;
  }

  public void l()
  {
    ky ky = this.k();
    if (!ky.d(ky, 0))
      return;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    kw& local1 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    ky A_0_1 = ky.g((^local1).g(), ky);
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local1).a(A_0_1);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    kw& local2 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    ky A_0_2 = ky.g((^local2).h(), ky);
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local2).b(A_0_2);
  }

  public kw m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kw kw = new kw(this.g(), this.h());
    kw.l();
    return kw;
  }

  public bool Equals(kw other)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (ky.f(this.g(), other.g()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ky.f(this.h(), other.h());
    }
    return false;
  }

  public override bool Equals(object other)
  {
    if (other is kw)
      return this.Equals((kw) other);
    return false;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.g().GetHashCode() ^ this.h().GetHashCode();
  }

  public override string ToString()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0:F},{1:F}", new object[2]{ (object) this.g(), (object) this.h() });
  }
}
