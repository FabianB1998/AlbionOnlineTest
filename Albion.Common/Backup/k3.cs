// Decompiled with JetBrains decompiler
// Type: k3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public class k3 : kt
{
  private uint[] g = new uint[2]{ 0U, 2567483615U };
  private uint[] h = new uint[624];
  private int i = 625;
  private const int a = 624;
  private const int b = 397;
  private const uint c = 2567483615;
  private const uint d = 2147483648;
  private const uint e = 2147483647;
  private const int f = 2147483647;

  public k3()
  {
    this.a((uint) DateTime.Now.Millisecond);
  }

  public k3(int A_0)
  {
    this.a((uint) A_0);
  }

  public k3(int[] A_0)
  {
    uint[] A_0_1 = new uint[A_0.Length];
    for (int index = 0; index < A_0.Length; ++index)
      A_0_1[index] = (uint) A_0[index];
    this.a(A_0_1, (uint) A_0_1.Length);
  }

  [SpecialName]
  public static int g()
  {
    return int.MaxValue;
  }

  public int cy(float A_0)
  {
    double num = (double) A_0 - Math.Floor((double) A_0);
    if ((double) A_0 < 0.0)
      num = 1.0 - num;
    if (this.j() > num)
      return (int) Math.Floor((double) A_0);
    return (int) Math.Ceiling((double) A_0);
  }

  public bool cz(float A_0)
  {
    if ((double) A_0 <= 0.0)
      return false;
    if ((double) A_0 >= 1.0)
      return true;
    return (double) this.h() <= (double) A_0;
  }

  public double cw(double A_0, double A_1)
  {
    return A_0 + this.j() * (A_1 - A_0);
  }

  public int Next()
  {
    return this.e();
  }

  public int Next(int maxValue)
  {
    return this.Next(0, maxValue);
  }

  public int Next(int minValue, int maxValue)
  {
    if (minValue > maxValue)
    {
      int num = maxValue;
      maxValue = minValue;
      minValue = num;
    }
    return (int) Math.Floor((double) (maxValue - minValue) * this.d() + (double) minValue);
  }

  public float h()
  {
    return (float) this.c();
  }

  public float a(bool A_0)
  {
    if (A_0)
      return (float) this.d();
    return (float) this.c();
  }

  public float i()
  {
    return (float) this.b();
  }

  public double j()
  {
    return this.c();
  }

  public double b(bool A_0)
  {
    if (A_0)
      return this.d();
    return this.c();
  }

  public double k()
  {
    return this.b();
  }

  public double l()
  {
    return this.a();
  }

  public ahk cx()
  {
    return new k4(1f, (float) this.cw(0.0, 2.0 * Math.PI)).c();
  }

  public void m()
  {
    this.a((uint) DateTime.Now.Millisecond);
  }

  public void a(int A_0)
  {
    this.a((uint) A_0);
  }

  public void a(int[] A_0)
  {
    uint[] A_0_1 = new uint[A_0.Length];
    for (int index = 0; index < A_0.Length; ++index)
      A_0_1[index] = (uint) A_0[index];
    this.a(A_0_1, (uint) A_0_1.Length);
  }

  private void a(uint A_0)
  {
    this.h[0] = A_0 & uint.MaxValue;
    for (this.i = 1; this.i < 624; ++this.i)
    {
      this.h[this.i] = (uint) ((ulong) (uint) (1812433253 * ((int) this.h[this.i - 1] ^ (int) (this.h[this.i - 1] >> 30))) + (ulong) this.i);
      this.h[this.i] &= uint.MaxValue;
    }
  }

  private void a(uint[] A_0, uint A_1)
  {
    this.a(19650218U);
    int index1 = 1;
    int index2 = 0;
    for (int index3 = 624U > A_1 ? 624 : (int) A_1; index3 > 0; --index3)
    {
      this.h[index1] = (uint) ((ulong) ((this.h[index1] ^ (uint) (((int) this.h[index1 - 1] ^ (int) (this.h[index1 - 1] >> 30)) * 1664525)) + A_0[index2]) + (ulong) index2);
      this.h[index1] &= uint.MaxValue;
      ++index1;
      ++index2;
      if (index1 >= 624)
      {
        this.h[0] = this.h[623];
        index1 = 1;
      }
      if ((long) index2 >= (long) A_1)
        index2 = 0;
    }
    for (int index3 = 623; index3 > 0; --index3)
    {
      this.h[index1] = (uint) ((ulong) (this.h[index1] ^ (uint) (((int) this.h[index1 - 1] ^ (int) (this.h[index1 - 1] >> 30)) * 1566083941)) - (ulong) index1);
      this.h[index1] &= uint.MaxValue;
      ++index1;
      if (index1 >= 624)
      {
        this.h[0] = this.h[623];
        index1 = 1;
      }
    }
    this.h[0] = 2147483648U;
  }

  private uint f()
  {
    if (this.i >= 624)
    {
      if (this.i == 625)
        this.a(5489U);
      int index;
      for (index = 0; index < 227; ++index)
      {
        uint num = (uint) ((int) this.h[index] & int.MinValue | (int) this.h[index + 1] & int.MaxValue);
        this.h[index] = this.h[index + 397] ^ num >> 1 ^ this.g[(IntPtr) (num & 1U)];
      }
      for (; index < 623; ++index)
      {
        uint num = (uint) ((int) this.h[index] & int.MinValue | (int) this.h[index + 1] & int.MaxValue);
        this.h[index] = this.h[index - 227] ^ num >> 1 ^ this.g[(IntPtr) (num & 1U)];
      }
      uint num1 = (uint) ((int) this.h[623] & int.MinValue | (int) this.h[0] & int.MaxValue);
      this.h[623] = this.h[396] ^ num1 >> 1 ^ this.g[(IntPtr) (num1 & 1U)];
      this.i = 0;
    }
    uint num2 = this.h[this.i++];
    uint num3 = num2 ^ num2 >> 11;
    uint num4 = num3 ^ (uint) ((int) num3 << 7 & -1658038656);
    uint num5 = num4 ^ (uint) ((int) num4 << 15 & -272236544);
    return num5 ^ num5 >> 18;
  }

  private int e()
  {
    return (int) (this.f() >> 1);
  }

  private double d()
  {
    return (double) this.f() * 2.3283064370808E-10;
  }

  private double c()
  {
    return (double) this.f() * 2.3283064365387E-10;
  }

  private double b()
  {
    return ((double) this.f() + 0.5) * 2.3283064365387E-10;
  }

  private double a()
  {
    return ((double) (this.f() >> 5) * 67108864.0 + (double) (this.f() >> 6)) * 1.11022302462516E-16;
  }
}
