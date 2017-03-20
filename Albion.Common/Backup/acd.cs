// Decompiled with JetBrains decompiler
// Type: acd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public struct acd : IEquatable<acd>
{
  public ahk a;
  public ahk b;

  public acd(ahk A_0, ahk A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public acd(float A_0, float A_1, float A_2, float A_3)
  {
    this.a = new ahk(A_0, A_3);
    this.b = new ahk(A_2, A_1);
  }

  [SpecialName]
  public static bool j(acd A_0, acd A_1)
  {
    if (ahk.b(A_0.a, A_1.a))
      return ahk.b(A_0.b, A_1.b);
    return false;
  }

  [SpecialName]
  public static bool i(acd A_0, acd A_1)
  {
    if (!ahk.a(A_0.a, A_1.a))
      return ahk.a(A_0.b, A_1.b);
    return true;
  }

  [SpecialName]
  public static acd j(acd A_0, ahk A_1)
  {
    return new acd(ahk.c(A_0.a, A_1), ahk.c(A_0.b, A_1));
  }

  [SpecialName]
  public static acd i(acd A_0, ahk A_1)
  {
    return new acd(ahk.d(A_0.a, A_1), ahk.d(A_0.b, A_1));
  }

  [SpecialName]
  public bool i()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.a.g() < (double) this.b.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) this.a.h() >= (double) this.b.h();
    }
    return true;
  }

  [SpecialName]
  public ahk j()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk((float) (((double) this.a.g() + (double) this.b.g()) / 2.0), (float) (((double) this.a.h() + (double) this.b.h()) / 2.0));
  }

  [SpecialName]
  public ahk k()
  {
    return ahk.c(this.b, this.a);
  }

  [SpecialName]
  public float l()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.b.g() - this.a.g();
  }

  [SpecialName]
  public float m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.b.h() - this.a.h();
  }

  [SpecialName]
  public float n()
  {
    return this.l() * this.m();
  }

  public bool i(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.g() >= (double) this.a.g() && (double) A_0.g() < (double) this.b.g() && (double) A_0.h() >= (double) this.a.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.h() < (double) this.b.h();
    }
    return false;
  }

  public bool i(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.g() >= (double) this.a.g() - (double) A_1 && (double) A_0.g() < (double) this.b.g() + (double) A_1 && (double) A_0.h() >= (double) this.a.h() - (double) A_1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.h() < (double) this.b.h() + (double) A_1;
    }
    return false;
  }

  public ahk j(ahk A_0)
  {
    ahk ahk = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.g() <= (double) this.a.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ahk.a(this.a.g());
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() >= (double) this.b.g())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ahk.a(this.b.g());
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.h() <= (double) this.a.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ahk.b(this.a.h());
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.h() >= (double) this.b.h())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ahk.b(this.b.h());
      }
    }
    return ahk;
  }

  public ahk k(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(Math.Max(this.a.g(), Math.Min(A_0.g(), this.b.g())), Math.Max(this.a.h(), Math.Min(A_0.h(), this.b.h())));
  }

  public ahk l(ahk A_0)
  {
    ahk ahk = this.j();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk((double) A_0.g() <= (double) ahk.g() ? Math.Min(A_0.g(), this.a.g()) : Math.Max(A_0.g(), this.b.g()), (double) A_0.h() <= (double) ahk.h() ? Math.Min(A_0.h(), this.a.h()) : Math.Max(A_0.h(), this.b.h()));
  }

  public bool i(acd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.b.g() > (double) A_0.a.g() && (double) A_0.b.g() > (double) this.a.g() && (double) this.b.h() > (double) A_0.a.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.b.h() > (double) this.a.h();
    }
    return false;
  }

  public bool j(acd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.a.h() >= (double) this.a.h() && (double) A_0.b.h() <= (double) this.b.h() && (double) A_0.a.g() >= (double) this.a.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.b.g() <= (double) this.b.g();
    }
    return false;
  }

  public void k(acd A_0)
  {
    if (!this.i(A_0))
    {
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ahk& local1 = @this.a;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ahk& local2 = @this.a;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ahk& local3 = @this.b;
      float num1;
      // ISSUE: reference to a compiler-generated method
      this.b.b(num1 = 0.0f);
      double num2;
      float num3 = (float) (num2 = (double) num1);
      // ISSUE: explicit reference operation
      // ISSUE: reference to a compiler-generated method
      (^local3).a((float) num2);
      double num4;
      float num5 = (float) (num4 = (double) num3);
      // ISSUE: explicit reference operation
      // ISSUE: reference to a compiler-generated method
      (^local2).b((float) num4);
      double num6 = (double) num5;
      // ISSUE: explicit reference operation
      // ISSUE: reference to a compiler-generated method
      (^local1).a((float) num6);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.a(Math.Max(this.a.g(), A_0.a.g()));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.b(Math.Max(this.a.h(), A_0.a.h()));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b.a(Math.Min(this.b.g(), A_0.b.g()));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b.b(Math.Min(this.b.h(), A_0.b.h()));
    }
  }

  public acd j(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(new ahk(this.a.g() - A_0, this.a.h() - A_0), new ahk(this.b.g() + A_0, this.b.h() + A_0));
  }

  public void k(float A_0)
  {
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local1 = @this.a;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num1 = (double) (^local1).g() + (double) A_0;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local1).a((float) num1);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local2 = @this.a;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num2 = (double) (^local2).h() + (double) A_0;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local2).b((float) num2);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local3 = @this.b;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num3 = (double) (^local3).g() - (double) A_0;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local3).a((float) num3);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local4 = @this.b;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num4 = (double) (^local4).h() - (double) A_0;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local4).b((float) num4);
  }

  public acd l(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(new ahk(this.a.g() + A_0, this.a.h() + A_0), new ahk(this.b.g() - A_0, this.b.h() - A_0));
  }

  public acd l(acd A_0)
  {
    if (!this.i(A_0))
      return new acd(0.0f, 0.0f, 0.0f, 0.0f);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(Math.Max(this.a.g(), A_0.a.g()), Math.Min(this.b.h(), A_0.b.h()), Math.Min(this.b.g(), A_0.b.g()), Math.Max(this.a.h(), A_0.a.h()));
  }

  public void o()
  {
    // ISSUE: reference to a compiler-generated method
    this.a.a(float.MaxValue);
    // ISSUE: reference to a compiler-generated method
    this.a.b(float.MaxValue);
    // ISSUE: reference to a compiler-generated method
    this.b.a(float.MinValue);
    // ISSUE: reference to a compiler-generated method
    this.b.b(float.MinValue);
  }

  public void m(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.a.g() > (double) A_0.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.a(A_0.g());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.b.g() < (double) A_0.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b.a(A_0.g());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.a.h() > (double) A_0.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.b(A_0.h());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.b.h() >= (double) A_0.h())
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b.b(A_0.h());
  }

  public void m(acd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.a.g() > (double) A_0.a.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.a(A_0.a.g());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.a.h() > (double) A_0.a.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a.b(A_0.a.h());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.b.g() < (double) A_0.b.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b.a(A_0.b.g());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.b.h() >= (double) A_0.b.h())
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b.b(A_0.b.h());
  }

  public bool i(ace A_0)
  {
    ahk ahk1 = ahk.c(A_0.a, this.j());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk1.a(Math.Abs(ahk1.g()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk1.b(Math.Abs(ahk1.h()));
    ahk ahk2 = ahk.a(this.k(), 2f);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) ahk1.g() > (double) ahk2.g() + (double) A_0.b || (double) ahk1.h() > (double) ahk2.h() + (double) A_0.b)
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) ahk1.g() <= (double) ahk2.g() || (double) ahk1.h() <= (double) ahk2.h())
      return true;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (double) (acd.i(ahk1.g() - ahk2.g()) + acd.i(ahk1.h() - ahk2.h())) <= (double) acd.i(A_0.b);
  }

  private static float i(float A_0)
  {
    return A_0 * A_0;
  }

  public bool j(ace A_0)
  {
    return this.j(new acd(ahk.c(A_0.a, new ahk(A_0.b, A_0.b)), ahk.d(A_0.a, new ahk(A_0.b, A_0.b))));
  }

  public override bool Equals(object o)
  {
    return false;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (int) this.a.g() ^ (int) this.a.h();
  }

  public override string ToString()
  {
    return "[" + this.a.ToString() + ", " + this.b.ToString() + "]";
  }

  public bool Equals(acd other)
  {
    if (this.a.Equals((object) other.a))
      return this.b.Equals((object) other.b);
    return false;
  }
}
