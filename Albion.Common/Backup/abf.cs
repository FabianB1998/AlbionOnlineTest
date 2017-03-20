// Decompiled with JetBrains decompiler
// Type: abf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct abf
{
  public abf(int A_0, int A_1)
  {
    this = new abf();
    // ISSUE: reference to a compiler-generated method
    this.c(A_0);
    // ISSUE: reference to a compiler-generated method
    this.d(A_1);
  }

  public override bool Equals(object pOther)
  {
    if (!(pOther is abf))
      return false;
    abf abf = (abf) pOther;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.c() == abf.c())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.d() == abf.d();
    }
    return false;
  }

  [SpecialName]
  public static abf f(abf A_0, abf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new abf(A_0.c() + A_1.c(), A_0.d() + A_1.d());
  }

  [SpecialName]
  public static abf e(abf A_0, abf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new abf(A_0.c() - A_1.c(), A_0.d() - A_1.d());
  }

  [SpecialName]
  public static bool d(abf A_0, abf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.c() == A_1.c())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return A_0.d() == A_1.d();
    }
    return false;
  }

  [SpecialName]
  public static bool c(abf A_0, abf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.c() == A_1.c())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return A_0.d() != A_1.d();
    }
    return true;
  }

  public override string ToString()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0},{1}", new object[2]{ (object) this.c(), (object) this.d() });
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.c() ^ this.d();
  }
}
