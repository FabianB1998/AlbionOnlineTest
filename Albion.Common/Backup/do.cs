// Decompiled with JetBrains decompiler
// Type: do
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class @do : IEquatable<@do>, IEqualityComparer<@do>
{
  public const int a = 4;
  public readonly string b;

  public @do(string A_0, long A_1)
  {
    this.b = A_0;
    // ISSUE: reference to a compiler-generated method
    this.e(A_1 * @do.d());
    // ISSUE: reference to a compiler-generated method
    this.d(A_1);
  }

  [SpecialName]
  public static long d()
  {
    return abh.a(10L, 4);
  }

  public void f(long A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e(this.e() / A_0);
  }

  public bool Equals(@do other)
  {
    return this.b.Equals(other.b, StringComparison.CurrentCultureIgnoreCase);
  }

  public bool Equals(@do x, @do y)
  {
    return x.b.Equals(y.b, StringComparison.CurrentCultureIgnoreCase);
  }

  public int GetHashCode(@do obj)
  {
    return obj.b.GetHashCode();
  }

  public override int GetHashCode()
  {
    return this.b.GetHashCode();
  }
}
