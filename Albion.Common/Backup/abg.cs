// Decompiled with JetBrains decompiler
// Type: abg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;

public struct abg
{
  public abf a;
  public abf b;

  public abg(abf A_0, abf A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public abg(int A_0, int A_1, int A_2, int A_3)
  {
    this.a = new abf(A_0, A_1);
    this.b = new abf(A_2, A_3);
  }

  [SpecialName]
  public int i()
  {
    // ISSUE: reference to a compiler-generated method
    return this.a.d();
  }

  [SpecialName]
  public void i(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a.d(A_0);
  }

  [SpecialName]
  public int j()
  {
    // ISSUE: reference to a compiler-generated method
    return this.b.d();
  }

  [SpecialName]
  public void j(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.b.d(A_0);
  }

  [SpecialName]
  public int k()
  {
    // ISSUE: reference to a compiler-generated method
    return this.a.c();
  }

  [SpecialName]
  public void k(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a.c(A_0);
  }

  [SpecialName]
  public int l()
  {
    // ISSUE: reference to a compiler-generated method
    return this.b.c();
  }

  [SpecialName]
  public void l(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.b.c(A_0);
  }

  [SpecialName]
  public static bool j(abg A_0, abg A_1)
  {
    if (abf.d(A_0.a, A_1.a))
      return abf.d(A_0.b, A_1.b);
    return false;
  }

  [SpecialName]
  public static bool i(abg A_0, abg A_1)
  {
    if (!abf.c(A_0.a, A_1.a))
      return abf.c(A_0.b, A_1.b);
    return true;
  }

  [SpecialName]
  public static abg j(abg A_0, abf A_1)
  {
    return new abg(abf.e(A_0.a, A_1), abf.e(A_0.b, A_1));
  }

  [SpecialName]
  public static abg i(abg A_0, abf A_1)
  {
    return new abg(abf.f(A_0.a, A_1), abf.f(A_0.b, A_1));
  }

  [SpecialName]
  public int m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.b.c() - this.a.c();
  }

  [SpecialName]
  public int n()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.b.d() - this.a.d();
  }

  public override bool Equals(object o)
  {
    return false;
  }

  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.a.c() ^ this.a.d();
  }

  public override string ToString()
  {
    return "[" + this.a.ToString() + ", " + this.b.ToString() + "]";
  }
}
