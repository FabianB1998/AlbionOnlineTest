// Decompiled with JetBrains decompiler
// Type: abh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class abh
{
  public static float b(ahk A_0)
  {
    A_0.l();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num = (float) (Math.Atan2((double) A_0.g(), (double) A_0.h()) / 3.14159274101257 * 180.0);
    if ((double) num < 0.0)
      num += 360f;
    return num;
  }

  public static ahk g(float A_0)
  {
    float num1 = (float) (-(double) A_0 / 180.0 * 3.14159274101257);
    float num2 = (float) Math.Cos((double) num1);
    float num3 = (float) Math.Sin((double) num1);
    float num4 = 0.0f;
    float num5 = 1f;
    return new ahk((float) ((double) num4 * (double) num2 - (double) num5 * (double) num3), (float) ((double) num4 * (double) num3 + (double) num5 * (double) num2));
  }

  public static ahk b(ahk A_0, ahk A_1, float A_2)
  {
    float num1 = (float) (-3.14159274101257 * (double) A_2 / 180.0);
    float num2 = (float) Math.Cos((double) num1);
    float num3 = (float) Math.Sin((double) num1);
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
    return new ahk((float) ((double) num2 * ((double) A_0.g() - (double) A_1.g()) - (double) num3 * ((double) A_0.h() - (double) A_1.h())) + A_1.g(), (float) ((double) num3 * ((double) A_0.g() - (double) A_1.g()) + (double) num2 * ((double) A_0.h() - (double) A_1.h())) + A_1.h());
  }

  public static bool a(acf A_0, acf A_1, acf A_2, acf A_3, out float A_4, float A_5)
  {
    float num = A_2.b(A_0);
    A_4 = 0.0f;
    if ((double) Math.Abs(num) > (double) A_5)
    {
      A_4 = acf.c(A_3, A_1).b(A_2) / num;
      if ((double) A_4 >= 0.0)
        return true;
    }
    return false;
  }

  public static byte f(float A_0)
  {
    A_0 = (float) (((double) A_0 + 3600.0) % 360.0);
    return (byte) Math.Round((double) A_0 / 360.0 * 256.0);
  }

  public static float a(byte A_0)
  {
    return (float) ((double) A_0 / 256.0 * 360.0);
  }

  public static ahk a(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.h(), -A_0.g());
  }

  public static float e(float A_0)
  {
    return (float) (180.0 * (double) A_0 / 3.14159274101257);
  }

  public static float d(float A_0)
  {
    return (float) (3.14159274101257 * (double) A_0 / 180.0);
  }

  public static ahk a(ahk A_0, ahk A_1, float A_2)
  {
    int num = (int) Math.Round((double) A_2 / 90.0) % 4;
    if (num < 0)
      num = 4 + num;
    if (num == 0)
      return A_0;
    ahk A_0_1 = ahk.c(A_0, A_1);
    if (num < 4)
    {
      for (int index = 0; index < num; ++index)
        A_0_1 = abh.a(A_0_1);
    }
    return ahk.d(A_0_1, A_1);
  }

  public static abg a(abg A_0, ahk A_1, float A_2)
  {
    abg abg = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_1 = new ahk((float) abg.a.c(), (float) A_0.a.d());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_2 = new ahk((float) abg.b.c(), (float) A_0.b.d());
    ahk ahk1 = abh.a(A_0_1, A_1, A_2);
    ahk ahk2 = abh.a(A_0_2, A_1, A_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int A_0_3 = (int) ((double) Math.Min(ahk1.g(), ahk2.g()) + 0.5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int A_1_1 = (int) ((double) Math.Min(ahk1.h(), ahk2.h()) + 0.5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int A_0_4 = (int) ((double) Math.Max(ahk1.g(), ahk2.g()) + 0.5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int A_1_2 = (int) ((double) Math.Max(ahk1.h(), ahk2.h()) + 0.5);
    abg.a = new abf(A_0_3, A_1_1);
    abg.b = new abf(A_0_4, A_1_2);
    return abg;
  }

  public static acd a(acd A_0, ahk A_1, float A_2)
  {
    acd acd = A_0;
    acd.a = abh.a(acd.a, A_1, A_2);
    acd.b = abh.a(acd.b, A_1, A_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_1 = Math.Min(acd.a.g(), acd.b.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_1 = Math.Min(acd.a.h(), acd.b.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_2 = Math.Max(acd.a.g(), acd.b.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_2 = Math.Max(acd.a.h(), acd.b.h());
    acd.a = new ahk(A_0_1, A_1_1);
    acd.b = new ahk(A_0_2, A_1_2);
    return acd;
  }

  public static float c(float A_0)
  {
    float num = A_0;
    while ((double) num <= -1.0 * Math.PI)
      num += 6.283185f;
    while ((double) num > Math.PI)
      num -= 6.283185f;
    return num;
  }

  public static float b(float A_0)
  {
    float num = A_0;
    while ((double) num < 0.0)
      num += 360f;
    while ((double) num >= 360.0)
      num -= 360f;
    return num;
  }

  public static float e(float A_0, float A_1, float A_2)
  {
    if ((double) A_2 <= (double) A_0)
      return 0.0f;
    if ((double) A_2 >= (double) A_1)
      return 1f;
    return (float) (((double) A_2 - (double) A_0) / ((double) A_1 - (double) A_0));
  }

  public static float b(long A_0, long A_1, long A_2)
  {
    if (A_2 <= A_0)
      return 0.0f;
    if (A_2 >= A_1)
      return 1f;
    return (float) (A_2 - A_0) / (float) (A_1 - A_0);
  }

  public static float d(float A_0, float A_1, float A_2)
  {
    return A_0 + A_2 * (A_1 - A_0);
  }

  public static void a(ahk A_0, ahk A_1, ahk A_2, ahk A_3, float A_4, out ahk A_5, out ahk A_6)
  {
    float num = 1f - A_4;
    A_5 = ahk.d(ahk.d(ahk.d(ahk.a(num * num * num, A_0), ahk.a(3f * num * num * A_4, A_1)), ahk.a(3f * num * A_4 * A_4, A_2)), ahk.a(A_4 * A_4 * A_4, A_3));
    A_6 = ahk.d(ahk.d(ahk.c(ahk.c(ahk.d(ahk.a(-3f * num * num, A_0), ahk.a(3f * num * num, A_1)), ahk.a(6f * A_4 * num, A_1)), ahk.a(3f * A_4 * A_4, A_2)), ahk.a(6f * A_4 * num, A_2)), ahk.a(3f * A_4 * A_4, A_3));
  }

  public static void a(ahk A_0, ahk A_1, ahk A_2, ahk A_3, float A_4, float A_5, out ahk A_6, out ahk A_7)
  {
    float A_1_1 = ahk.c(A_0, A_2).k();
    ahk A_1_2 = ahk.d(A_0, ahk.b(ahk.b(A_1, A_1_1), A_4));
    ahk A_2_1 = ahk.c(A_2, ahk.b(ahk.b(A_3, A_1_1), A_4));
    abh.a(A_0, A_1_2, A_2_1, A_2, A_5, out A_6, out A_7);
  }

  public static float c(float A_0, float A_1, float A_2)
  {
    float num1 = A_1 - A_0;
    if ((double) num1 > 180.0)
      num1 -= 360f;
    else if ((double) num1 < -180.0)
      num1 += 360f;
    float num2 = A_0 + A_2 * num1;
    if ((double) num2 >= 360.0)
      num2 -= 360f;
    if ((double) num2 < 0.0)
      num2 += 360f;
    return num2;
  }

  public static float a(float A_0)
  {
    return (float) ((double) A_0 * (double) A_0 * (3.0 - 2.0 * (double) A_0));
  }

  public static a b<a>(a A_0, a A_1) where a : IComparable<a>
  {
    if (A_0.CompareTo(A_1) <= 0)
      return A_1;
    return A_0;
  }

  public static a a<a>(a A_0, a A_1) where a : IComparable<a>
  {
    if (A_0.CompareTo(A_1) >= 0)
      return A_1;
    return A_0;
  }

  public static float b(float A_0, float A_1, float A_2)
  {
    return Math.Min(A_2, Math.Max(A_1, A_0));
  }

  public static double a(double A_0, double A_1, double A_2)
  {
    return Math.Min(A_2, Math.Max(A_1, A_0));
  }

  public static float a(short A_0, short A_1, short A_2)
  {
    return (float) Math.Min(A_2, Math.Max(A_1, A_0));
  }

  public static int a(int A_0, int A_1, int A_2)
  {
    return Math.Min(A_2, Math.Max(A_1, A_0));
  }

  public static long a(long A_0, long A_1, long A_2)
  {
    return Math.Min(A_2, Math.Max(A_1, A_0));
  }

  public static a a<a>(a A_0, a A_1, a A_2) where a : IComparable<a>
  {
    return abh.a<a>(A_2, abh.b<a>(A_1, A_0));
  }

  public static double a(double A_0, double A_1)
  {
    A_0 = Math.Abs(A_0);
    A_1 = Math.Abs(A_1);
    double num1 = Math.Min(A_0, A_1);
    A_0 = Math.Max(A_0, A_1);
    double num2 = num1 / A_0;
    return A_0 * Math.Sqrt(1.0 + num2 * num2);
  }

  public static int a(kx[] A_0, kx A_1)
  {
    for (int index = 0; index < A_0.Length; ++index)
    {
      if (kx.m(A_0[index], A_1))
        return index;
    }
    return -1;
  }

  public static ahk b(ahk[] A_0)
  {
    float num1 = 0.0f;
    float num2 = 0.0f;
    foreach (ahk ahk in A_0)
    {
      // ISSUE: reference to a compiler-generated method
      num1 += ahk.g();
      // ISSUE: reference to a compiler-generated method
      num2 += ahk.h();
    }
    return new ahk(num1 / (float) A_0.Length, num2 / (float) A_0.Length);
  }

  public static acf a(acf[] A_0)
  {
    float num1 = 0.0f;
    float num2 = 0.0f;
    float num3 = 0.0f;
    foreach (acf acf in A_0)
    {
      // ISSUE: reference to a compiler-generated method
      num1 += acf.k();
      // ISSUE: reference to a compiler-generated method
      num2 += acf.l();
      // ISSUE: reference to a compiler-generated method
      num3 += acf.m();
    }
    return new acf(num1 / (float) A_0.Length, num2 / (float) A_0.Length, num3 / (float) A_0.Length);
  }

  public static acd a(ahk[] A_0)
  {
    float A_0_1 = float.MaxValue;
    float A_0_2 = float.MinValue;
    float A_1_1 = float.MaxValue;
    float A_1_2 = float.MinValue;
    for (int index = 0; index < A_0.Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0[index].g() < (double) A_0_1)
      {
        // ISSUE: reference to a compiler-generated method
        A_0_1 = A_0[index].g();
      }
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0[index].g() > (double) A_0_2)
      {
        // ISSUE: reference to a compiler-generated method
        A_0_2 = A_0[index].g();
      }
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0[index].h() < (double) A_1_1)
      {
        // ISSUE: reference to a compiler-generated method
        A_1_1 = A_0[index].h();
      }
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0[index].h() > (double) A_1_2)
      {
        // ISSUE: reference to a compiler-generated method
        A_1_2 = A_0[index].h();
      }
    }
    return new acd(new ahk(A_0_1, A_1_1), new ahk(A_0_2, A_1_2));
  }

  public static bool a(float A_0, float A_1, float A_2)
  {
    if ((double) A_0 == (double) A_1 || (double) A_0 == (double) A_1)
      return true;
    return (double) Math.Abs(A_0 - A_1) < (double) A_2;
  }

  public static float a(ahk A_0, ahk A_1, ahk A_2)
  {
    ahk ahk = ahk.c(A_1, A_0);
    float num = ahk.j();
    if ((double) num == 0.0)
      return ahk.c(A_0, A_2).k();
    float A_0_1 = Math.Max(0.0f, Math.Min(1f, ahk.c(A_2, A_0).b(ahk) / num));
    return ahk.c(ahk.d(A_0, ahk.a(A_0_1, ahk)), A_2).k();
  }

  public static long a(long A_0, int A_1)
  {
    if (A_1 == 0)
      return 1;
    if (A_1 < 0)
      return 0;
    long num = A_0;
    for (int index = 1; index < A_1; ++index)
      num *= A_0;
    return num;
  }
}
