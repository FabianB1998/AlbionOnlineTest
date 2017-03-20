// Decompiled with JetBrains decompiler
// Type: ahk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct ahk
{
  private static readonly ahk a = new ahk(0.0f, 0.0f);
  private static readonly ahk b = new ahk(1f, 0.0f);
  private static readonly ahk c = new ahk(0.0f, 1f);
  private static readonly ahk d = new ahk(1f, 1f);

  public ahk(float A_0, float A_1)
  {
    this = new ahk();
    // ISSUE: reference to a compiler-generated method
    this.a(A_0);
    // ISSUE: reference to a compiler-generated method
    this.b(A_1);
  }

  [SpecialName]
  public static ahk d()
  {
    return ahk.a;
  }

  [SpecialName]
  public static ahk c()
  {
    return ahk.b;
  }

  [SpecialName]
  public static ahk b()
  {
    return ahk.c;
  }

  [SpecialName]
  public static ahk a()
  {
    return ahk.d;
  }

  public override bool Equals(object pOther)
  {
    if (!(pOther is ahk))
      return false;
    ahk ahk = (ahk) pOther;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.g() == (double) ahk.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) this.h() == (double) ahk.h();
    }
    return false;
  }

  [SpecialName]
  public static ahk d(ahk A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() + A_1.g(), A_0.h() + A_1.h());
  }

  [SpecialName]
  public static ahk c(ahk A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() - A_1.g(), A_0.h() - A_1.h());
  }

  [SpecialName]
  public static ahk a(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(-A_0.g(), -A_0.h());
  }

  [SpecialName]
  public static ahk b(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() * A_1, A_0.h() * A_1);
  }

  [SpecialName]
  public static ahk a(float A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_1.g() * A_0, A_1.h() * A_0);
  }

  [SpecialName]
  public static ahk a(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() / A_1, A_0.h() / A_1);
  }

  [SpecialName]
  public static bool b(ahk A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.g() == (double) A_1.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.h() == (double) A_1.h();
    }
    return false;
  }

  [SpecialName]
  public static bool a(ahk A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0.g() == (double) A_1.g())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) A_0.h() != (double) A_1.h();
    }
    return true;
  }

  public float b(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) ((double) this.g() * (double) A_0.g() + (double) this.h() * (double) A_0.h());
  }

  public float[] i()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new float[2]{ this.g(), this.h() };
  }

  public static ahk a(float[] A_0)
  {
    if (A_0.Length == 2)
      return new ahk(A_0[0], A_0[1]);
    return ahk.d();
  }

  public static ahk a(string A_0)
  {
    string[] strArray = A_0.Split(',');
    float result1;
    float result2;
    if (strArray.Length == 2 && float.TryParse(strArray[0], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result1) && float.TryParse(strArray[1], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result2))
      return new ahk(result1, result2);
    return ahk.d();
  }

  public override string ToString()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0:F},{1:F}", new object[2]{ (object) this.g(), (object) this.h() });
  }

  public float j()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) ((double) this.g() * (double) this.g() + (double) this.h() * (double) this.h());
  }

  public float k()
  {
    return (float) Math.Sqrt((double) this.j());
  }

  public bool c(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) Math.Abs(A_0.g() - this.g()) < (double) A_1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) Math.Abs(A_0.h() - this.h()) < (double) A_1;
    }
    return false;
  }

  public void l()
  {
    float num1 = this.k();
    if ((double) num1 <= 0.0)
      return;
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local1 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num2 = (double) (^local1).g() / (double) num1;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local1).a((float) num2);
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    ahk& local2 = @this;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    double num3 = (double) (^local2).h() / (double) num1;
    // ISSUE: explicit reference operation
    // ISSUE: reference to a compiler-generated method
    (^local2).b((float) num3);
  }

  public ahk m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk ahk = new ahk(this.g(), this.h());
    ahk.l();
    return ahk;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.g().GetHashCode() ^ this.h().GetHashCode();
  }

  public static ahk a(ahk A_0, ahk A_1, float A_2)
  {
    return ahk.d(A_0, ahk.a(A_2, ahk.c(A_1, A_0)));
  }
}
