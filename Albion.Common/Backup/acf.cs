// Decompiled with JetBrains decompiler
// Type: acf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct acf
{
  private static readonly acf a = new acf(0.0f, 0.0f, 0.0f);
  private static readonly acf b = new acf(1f, 0.0f, 0.0f);
  private static readonly acf c = new acf(0.0f, 1f, 0.0f);
  private static readonly acf d = new acf(0.0f, 0.0f, 1f);
  private static readonly acf e = new acf(1f, 1f, 1f);

  public acf(float A_0, float A_1, float A_2)
  {
    this = new acf();
    // ISSUE: reference to a compiler-generated method
    this.a(A_0);
    // ISSUE: reference to a compiler-generated method
    this.b(A_1);
    // ISSUE: reference to a compiler-generated method
    this.c(A_2);
  }

  public acf(ahk A_0, float A_1)
  {
    this = new acf();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(A_0.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(A_0.h());
    // ISSUE: reference to a compiler-generated method
    this.c(A_1);
  }

  [SpecialName]
  public static acf e()
  {
    return acf.a;
  }

  [SpecialName]
  public static acf d()
  {
    return acf.b;
  }

  [SpecialName]
  public static acf c()
  {
    return acf.c;
  }

  [SpecialName]
  public static acf b()
  {
    return acf.d;
  }

  [SpecialName]
  public static acf a()
  {
    return acf.e;
  }

  [SpecialName]
  public void a(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(A_0.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(A_0.h());
  }

  [SpecialName]
  public ahk n()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(this.k(), this.l());
  }

  [SpecialName]
  public void b(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(A_0.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c(A_0.h());
  }

  [SpecialName]
  public ahk o()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(this.k(), this.m());
  }

  public override bool Equals(object pOther)
  {
    if (!(pOther is acf))
      return false;
    acf acf = (acf) pOther;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.k() == (double) acf.k() && (double) this.l() == (double) acf.l())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) this.m() == (double) acf.m();
    }
    return false;
  }

  [SpecialName]
  public static acf d(acf A_0, acf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(A_0.k() + A_1.k(), A_0.l() + A_1.l(), A_0.m() + A_1.m());
  }

  [SpecialName]
  public static acf c(acf A_0, acf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(A_0.k() - A_1.k(), A_0.l() - A_1.l(), A_0.m() - A_1.m());
  }

  [SpecialName]
  public static acf a(acf A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(-A_0.k(), -A_0.l(), -A_0.m());
  }

  [SpecialName]
  public static acf b(acf A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(A_0.k() * A_1, A_0.l() * A_1, A_0.m() * A_1);
  }

  [SpecialName]
  public static acf a(float A_0, acf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(A_1.k() * A_0, A_1.l() * A_0, A_1.m() * A_0);
  }

  [SpecialName]
  public static acf a(acf A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf(A_0.k() / A_1, A_0.l() / A_1, A_0.m() / A_1);
  }

  [SpecialName]
  public static bool b(acf A_0, acf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.k() == (double) A_1.k() && (double) A_0.l() == (double) A_1.l())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.m() == (double) A_1.m();
    }
    return false;
  }

  [SpecialName]
  public static bool a(acf A_0, acf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.k() == (double) A_1.k() && (double) A_0.l() == (double) A_1.l())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.m() != (double) A_1.m();
    }
    return true;
  }

  public float b(acf A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) ((double) this.k() * (double) A_0.l() + (double) this.l() * (double) A_0.l() + (double) this.m() * (double) A_0.m());
  }

  public acf c(acf A_0)
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
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acf((float) ((double) this.l() * (double) A_0.m() - (double) this.m() * (double) A_0.l()), (float) ((double) this.m() * (double) A_0.k() - (double) this.k() * (double) A_0.m()), (float) ((double) this.k() * (double) A_0.l() - (double) this.l() * (double) A_0.k()));
  }

  public float[] p()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new float[3]{ this.k(), this.l(), this.m() };
  }

  public static acf a(float[] A_0)
  {
    return new acf(A_0[0], A_0[1], A_0[2]);
  }

  public override string ToString()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0:F},{1:F},{2:F}", (object) this.k(), (object) this.l(), (object) this.m());
  }

  public float q()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) ((double) this.k() * (double) this.k() + (double) this.l() * (double) this.l() + (double) this.m() * (double) this.m());
  }

  public float r()
  {
    return (float) Math.Sqrt((double) this.q());
  }

  public bool c(acf A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) Math.Abs(A_0.k() - this.k()) < (double) A_1 && (double) Math.Abs(A_0.l() - this.l()) < (double) A_1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) Math.Abs(A_0.m() - this.m()) < (double) A_1;
    }
    return false;
  }

  public void s()
  {
    float num1 = this.r();
    if ((double) num1 <= 0.0)
      return;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    acf& local1 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num2 = (double) (^local1).k() / (double) num1;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local1).a((float) num2);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    acf& local2 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num3 = (double) (^local2).l() / (double) num1;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local2).b((float) num3);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    acf& local3 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num4 = (double) (^local3).m() / (double) num1;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local3).c((float) num4);
  }

  public acf t()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf acf = new acf(this.k(), this.l(), this.m());
    acf.s();
    return acf;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.k().GetHashCode() ^ this.l().GetHashCode() ^ this.m().GetHashCode();
  }

  public static acf a(acf A_0, acf A_1, float A_2)
  {
    return acf.d(A_0, acf.a(A_2, acf.c(A_1, A_0)));
  }
}
