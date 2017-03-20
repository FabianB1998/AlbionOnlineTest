// Decompiled with JetBrains decompiler
// Type: ky
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public struct ky : IComparable<ky>, IEquatable<ky>
{
  public const int a = 12;
  private const int b = 4096;
  private const int c = 2048;
  private const int d = 32;
  private const int e = -2147483648;
  private const int f = 2147483647;
  private const int g = 4095;
  private const int h = -4096;
  public int i;

  private ky(int A_0)
  {
    this.i = A_0;
  }

  [SpecialName]
  public static ky d()
  {
    return new ky(0);
  }

  [SpecialName]
  public static ky c()
  {
    return new ky(4096);
  }

  [SpecialName]
  public static ky b()
  {
    return new ky(int.MinValue);
  }

  [SpecialName]
  public static ky a()
  {
    return new ky(int.MaxValue);
  }

  public static ky b(int A_0)
  {
    return new ky(A_0);
  }

  public static ky a(int A_0)
  {
    return new ky(A_0 << 12);
  }

  public static ky a(float A_0)
  {
    if ((double) A_0 > 0.0)
      return new ky((int) ((double) A_0 * 4096.0 + 0.5));
    return new ky((int) ((double) A_0 * 4096.0 - 0.5));
  }

  public float e()
  {
    if (this.i > 0)
      return (float) (this.i >> 12);
    return (float) (this.i + 4095 >> 12);
  }

  public float f()
  {
    return (float) this.g();
  }

  public double g()
  {
    return 1.0 * (double) this.i / 4096.0;
  }

  public static ky d(ky A_0)
  {
    if (!ky.d(A_0, ky.d()))
      return A_0;
    return ky.b(A_0);
  }

  public int CompareTo(ky other)
  {
    return this.i.CompareTo(other.i);
  }

  public bool Equals(ky other)
  {
    return this.i.Equals(other.i);
  }

  public override bool Equals(object other)
  {
    if (other is ky)
      return this.Equals((ky) other);
    return false;
  }

  public override int GetHashCode()
  {
    return this.i.GetHashCode();
  }

  [SpecialName]
  public static ky c(ky A_0)
  {
    return A_0;
  }

  [SpecialName]
  public static ky b(ky A_0)
  {
    return new ky(-A_0.i);
  }

  [SpecialName]
  public static ky k(ky A_0, ky A_1)
  {
    return new ky(A_0.i + A_1.i);
  }

  [SpecialName]
  public static ky k(int A_0, ky A_1)
  {
    return new ky(ky.a(A_0).i + A_1.i);
  }

  [SpecialName]
  public static ky l(ky A_0, int A_1)
  {
    return new ky(A_0.i + ky.a(A_1).i);
  }

  [SpecialName]
  public static ky k(float A_0, ky A_1)
  {
    return new ky(ky.a(A_0).i + A_1.i);
  }

  [SpecialName]
  public static ky k(ky A_0, float A_1)
  {
    return new ky(A_0.i + ky.a(A_1).i);
  }

  [SpecialName]
  public static ky j(ky A_0, ky A_1)
  {
    return new ky(A_0.i - A_1.i);
  }

  [SpecialName]
  public static ky j(int A_0, ky A_1)
  {
    return new ky(ky.a(A_0).i - A_1.i);
  }

  [SpecialName]
  public static ky k(ky A_0, int A_1)
  {
    return new ky(A_0.i - ky.a(A_1).i);
  }

  [SpecialName]
  public static ky j(float A_0, ky A_1)
  {
    return new ky(ky.a(A_0).i - A_1.i);
  }

  [SpecialName]
  public static ky j(ky A_0, float A_1)
  {
    return new ky(A_0.i - ky.a(A_1).i);
  }

  [SpecialName]
  public static ky h(ky A_0, ky A_1)
  {
    return new ky((int) ((long) A_0.i * (long) A_1.i + 2048L >> 12));
  }

  [SpecialName]
  public static ky j(ky A_0, int A_1)
  {
    return ky.h(A_0, ky.a(A_1));
  }

  [SpecialName]
  public static ky h(int A_0, ky A_1)
  {
    return ky.h(ky.a(A_0), A_1);
  }

  [SpecialName]
  public static ky h(ky A_0, float A_1)
  {
    return ky.h(A_0, ky.a(A_1));
  }

  [SpecialName]
  public static ky h(float A_0, ky A_1)
  {
    return ky.h(ky.a(A_0), A_1);
  }

  [SpecialName]
  public static ky g(ky A_0, ky A_1)
  {
    if (A_0.i > 0)
      return new ky((int) ((((long) A_0.i << 12) + 2048L) / (long) A_1.i));
    return new ky((int) (((long) (A_0.i << 12) - 2048L) / (long) A_1.i));
  }

  [SpecialName]
  public static ky h(ky A_0, int A_1)
  {
    return ky.g(A_0, ky.a(A_1));
  }

  [SpecialName]
  public static ky g(int A_0, ky A_1)
  {
    return ky.g(ky.a(A_0), A_1);
  }

  [SpecialName]
  public static ky g(ky A_0, float A_1)
  {
    return ky.g(A_0, ky.a(A_1));
  }

  [SpecialName]
  public static ky g(float A_0, ky A_1)
  {
    return ky.g(ky.a(A_0), A_1);
  }

  [SpecialName]
  public static bool f(ky A_0, ky A_1)
  {
    return A_0.i == A_1.i;
  }

  [SpecialName]
  public static bool g(ky A_0, int A_1)
  {
    return A_0.i == ky.a(A_1).i;
  }

  [SpecialName]
  public static bool f(int A_0, ky A_1)
  {
    return ky.a(A_0).i == A_1.i;
  }

  [SpecialName]
  public static bool f(ky A_0, float A_1)
  {
    return A_0.i == ky.a(A_1).i;
  }

  [SpecialName]
  public static bool f(float A_0, ky A_1)
  {
    return ky.a(A_0).i == A_1.i;
  }

  [SpecialName]
  public static bool e(ky A_0, ky A_1)
  {
    return A_0.i != A_1.i;
  }

  [SpecialName]
  public static bool f(ky A_0, int A_1)
  {
    return A_0.i != ky.a(A_1).i;
  }

  [SpecialName]
  public static bool e(int A_0, ky A_1)
  {
    return ky.a(A_0).i != A_1.i;
  }

  [SpecialName]
  public static bool e(ky A_0, float A_1)
  {
    return A_0.i != ky.a(A_1).i;
  }

  [SpecialName]
  public static bool e(float A_0, ky A_1)
  {
    return ky.a(A_0).i != A_1.i;
  }

  [SpecialName]
  public static bool d(ky A_0, ky A_1)
  {
    return A_0.i < A_1.i;
  }

  [SpecialName]
  public static bool e(ky A_0, int A_1)
  {
    return A_0.i < ky.a(A_1).i;
  }

  [SpecialName]
  public static bool d(int A_0, ky A_1)
  {
    return ky.a(A_0).i < A_1.i;
  }

  [SpecialName]
  public static bool d(ky A_0, float A_1)
  {
    return A_0.i < ky.a(A_1).i;
  }

  [SpecialName]
  public static bool d(float A_0, ky A_1)
  {
    return ky.a(A_0).i < A_1.i;
  }

  [SpecialName]
  public static bool c(ky A_0, ky A_1)
  {
    return A_0.i > A_1.i;
  }

  [SpecialName]
  public static bool d(ky A_0, int A_1)
  {
    return A_0.i > ky.a(A_1).i;
  }

  [SpecialName]
  public static bool c(int A_0, ky A_1)
  {
    return ky.a(A_0).i > A_1.i;
  }

  [SpecialName]
  public static bool c(ky A_0, float A_1)
  {
    return A_0.i > ky.a(A_1).i;
  }

  [SpecialName]
  public static bool c(float A_0, ky A_1)
  {
    return ky.a(A_0).i > A_1.i;
  }

  [SpecialName]
  public static bool b(ky A_0, ky A_1)
  {
    return A_0.i <= A_1.i;
  }

  [SpecialName]
  public static bool c(ky A_0, int A_1)
  {
    return A_0.i <= ky.a(A_1).i;
  }

  [SpecialName]
  public static bool b(int A_0, ky A_1)
  {
    return ky.a(A_0).i <= A_1.i;
  }

  [SpecialName]
  public static bool b(ky A_0, float A_1)
  {
    return A_0.i <= ky.a(A_1).i;
  }

  [SpecialName]
  public static bool b(float A_0, ky A_1)
  {
    return ky.a(A_0).i <= A_1.i;
  }

  [SpecialName]
  public static bool a(ky A_0, ky A_1)
  {
    return A_0.i >= A_1.i;
  }

  [SpecialName]
  public static bool b(ky A_0, int A_1)
  {
    return A_0.i >= ky.a(A_1).i;
  }

  [SpecialName]
  public static bool a(int A_0, ky A_1)
  {
    return ky.a(A_0).i >= A_1.i;
  }

  [SpecialName]
  public static bool a(ky A_0, float A_1)
  {
    return A_0.i >= ky.a(A_1).i;
  }

  [SpecialName]
  public static bool a(float A_0, ky A_1)
  {
    return ky.a(A_0).i >= A_1.i;
  }

  public static ky a(ky A_0, int A_1)
  {
    if (A_0.i < 0)
      throw new ArithmeticException("Input Error");
    if (A_0.i == 0)
      return ky.d();
    ky ky = ky.k(A_0, new ky(2048));
    for (int index = 0; index < A_1; ++index)
      ky = new ky(ky.k(ky, ky.g(A_0, ky)).i >> 1);
    if (ky.i < 0)
      throw new ArithmeticException("Overflow");
    return ky;
  }

  public static ky a(ky A_0)
  {
    int A_1 = 8;
    if (A_0.i > 409600)
      A_1 = 12;
    if (A_0.i > 4096000)
      A_1 = 16;
    return ky.a(A_0, A_1);
  }

  public override string ToString()
  {
    return this.f().ToString();
  }
}
