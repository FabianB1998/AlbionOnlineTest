// Decompiled with JetBrains decompiler
// Type: ace
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public struct ace : IEquatable<ace>
{
  public ahk a;
  public float b;

  public ace(ahk A_0, float A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  [SpecialName]
  public static bool d(ace A_0, ace A_1)
  {
    if (ahk.b(A_0.a, A_1.a))
      return (double) A_0.b == (double) A_1.b;
    return false;
  }

  [SpecialName]
  public static bool c(ace A_0, ace A_1)
  {
    if (!ahk.a(A_0.a, A_1.a))
      return (double) A_0.b != (double) A_1.b;
    return true;
  }

  public bool c(ace A_0)
  {
    float num = this.b + A_0.b;
    return (double) ahk.c(this.a, A_0.a).j() < (double) (num * num);
  }

  public bool c(ace A_0, float A_1)
  {
    float num = this.b + A_0.b - A_1;
    return (double) ahk.c(this.a, A_0.a).j() < (double) (num * num);
  }

  public bool d(ace A_0)
  {
    if ((double) A_0.b > (double) this.b)
      return false;
    ahk ahk = ahk.c(this.a, A_0.a);
    float num = this.b - A_0.b;
    return (double) ahk.j() <= (double) num * (double) num;
  }

  public acd c()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(new ahk(this.a.g() - this.b, this.a.h() - this.b), new ahk(this.a.g() + this.b, this.a.h() + this.b));
  }

  public bool c(ahk A_0)
  {
    return (double) ahk.c(this.a, A_0).j() < (double) this.b * (double) this.b;
  }

  private static float c(float A_0)
  {
    return (double) A_0 < 0.0 ? -1f : 1f;
  }

  public int c(ahk A_0, ahk A_1, out ahk A_2, out ahk A_3)
  {
    A_0 = ahk.c(A_0, this.a);
    A_1 = ahk.c(A_1, this.a);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num1 = A_1.g() - A_0.g();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_1 = A_1.h() - A_0.h();
    float num2 = (float) Math.Sqrt((double) num1 * (double) num1 + (double) A_0_1 * (double) A_0_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num3 = (float) ((double) A_0.g() * (double) A_1.h() - (double) A_1.g() * (double) A_0.h());
    float num4 = (float) ((double) this.b * (double) this.b * (double) num2 * (double) num2 - (double) num3 * (double) num3);
    if ((double) num4 < 0.0)
    {
      A_2 = ahk.d();
      A_3 = ahk.d();
      return 0;
    }
    float num5 = (float) Math.Sqrt((double) num4);
    A_2 = ahk.d(new ahk((float) (((double) num3 * (double) A_0_1 + (double) ace.c(A_0_1) * (double) num1 * (double) num5) / ((double) num2 * (double) num2)), (float) ((-(double) num3 * (double) num1 + (double) Math.Abs(A_0_1) * (double) num5) / ((double) num2 * (double) num2))), this.a);
    if ((double) num4 == 0.0)
    {
      A_3 = ahk.d();
      return 1;
    }
    A_3 = ahk.d(new ahk((float) (((double) num3 * (double) A_0_1 - (double) ace.c(A_0_1) * (double) num1 * (double) num5) / ((double) num2 * (double) num2)), (float) ((-(double) num3 * (double) num1 - (double) Math.Abs(A_0_1) * (double) num5) / ((double) num2 * (double) num2))), this.a);
    return 2;
  }

  public int c(ace A_0, out ahk A_1, out ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    double A_0_1 = (double) A_0.a.g() - (double) this.a.g();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    double A_1_1 = (double) A_0.a.h() - (double) this.a.h();
    if (Math.Abs(A_0_1) < 1E-06 && Math.Abs(A_1_1) < 1E-06)
    {
      A_1 = ahk.d();
      A_2 = ahk.d();
      return 0;
    }
    double num1 = abh.a(A_0_1, A_1_1);
    if (num1 > (double) this.b + (double) A_0.b || num1 < (double) Math.Abs(this.b - A_0.b))
    {
      A_1 = ahk.d();
      A_2 = ahk.d();
      return 0;
    }
    double num2 = ((double) this.b * (double) this.b - (double) A_0.b * (double) A_0.b + num1 * num1) / (2.0 * num1);
    // ISSUE: reference to a compiler-generated method
    double num3 = (double) this.a.g() + A_0_1 * num2 / num1;
    // ISSUE: reference to a compiler-generated method
    double num4 = (double) this.a.h() + A_1_1 * num2 / num1;
    double num5 = Math.Sqrt((double) this.b * (double) this.b - num2 * num2);
    double num6 = -A_1_1 * (num5 / num1);
    double num7 = A_0_1 * (num5 / num1);
    A_1 = new ahk((float) (num3 + num6), (float) (num4 + num7));
    A_2 = new ahk((float) (num3 - num6), (float) (num4 - num7));
    return num6 == 0.0 && num7 == 0.0 ? 1 : 2;
  }

  public float d(ahk A_0)
  {
    ahk ahk = ahk.c(this.a, A_0);
    ahk.l();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) Math.Atan2(-(double) ahk.h(), -(double) ahk.g());
  }

  public ahk d(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(this.a.g() + this.b * (float) Math.Cos((double) A_0), this.a.h() + this.b * (float) Math.Sin((double) A_0));
  }

  public override bool Equals(object o)
  {
    if (o is ace)
      return ace.d((ace) o, this);
    return false;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (int) this.a.g() ^ (int) this.a.h();
  }

  public bool Equals(ace other)
  {
    return ace.d(this, other);
  }
}
