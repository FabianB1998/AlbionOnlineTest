// Decompiled with JetBrains decompiler
// Type: ks
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public struct ks : IEquatable<ks>
{
  public ahk a;
  public ahk b;
  public float c;

  public ks(ahk A_0, ahk A_1, float A_2)
  {
    this.a = A_0;
    this.b = A_1;
    this.c = A_2;
  }

  [SpecialName]
  public static bool e(ks A_0, ks A_1)
  {
    if (ahk.b(A_0.a, A_1.a) && ahk.b(A_0.b, A_1.b))
      return (double) A_0.c == (double) A_1.c;
    return false;
  }

  [SpecialName]
  public static bool d(ks A_0, ks A_1)
  {
    if (!ahk.a(A_0.a, A_1.a) && !ahk.a(A_0.b, A_1.b))
      return (double) A_0.c != (double) A_1.c;
    return true;
  }

  public override bool Equals(object obj)
  {
    if (!(obj is ks))
      return false;
    return ks.e(this, (ks) obj);
  }

  public bool d(ahk A_0)
  {
    return (double) abh.a(this.a, this.b, A_0) <= (double) this.c;
  }

  public acd d()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_1 = Math.Min(this.a.g(), this.b.g()) - this.c;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_2 = Math.Max(this.a.g(), this.b.g()) + this.c;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_1 = Math.Min(this.a.h(), this.b.h()) - this.c;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_2 = Math.Max(this.a.h(), this.b.h()) + this.c;
    return new acd(new ahk(A_0_1, A_1_1), new ahk(A_0_2, A_1_2));
  }

  public bool Equals(ks other)
  {
    return ks.e(this, other);
  }

  public override int GetHashCode()
  {
    return this.a.GetHashCode() ^ this.b.GetHashCode();
  }
}
