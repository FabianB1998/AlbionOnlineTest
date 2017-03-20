// Decompiled with JetBrains decompiler
// Type: abd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class abd<a>
{
  private List<abd<a>.a>[] a;
  private ahk b;
  private float c;
  private float d;
  private int e;
  private int f;
  private bool g;

  public abd(float A_0, float A_1, ahk A_2, int A_3, int A_4)
  {
    this.g = typeof (a).IsValueType;
    this.b = A_2;
    this.c = A_0 / (float) A_3;
    this.d = A_1 / (float) A_4;
    this.e = A_3 + 1;
    this.f = A_4 + 1;
    this.a = new List<abd<a>.a>[this.e * this.f];
    for (int index = 0; index < this.e * this.f; ++index)
      this.a[index] = new List<abd<a>.a>();
  }

  [SpecialName]
  public acd b()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(this.b, new ahk(this.b.g() + (float) this.e * this.c, this.b.h() + (float) this.f * this.d));
  }

  public void c()
  {
    foreach (List<abd<a>.a> aList in this.a)
      aList.Clear();
  }

  public bool b(a A_0, acd A_1)
  {
    abg A_1_1;
    if (!this.b(A_1, out A_1_1))
      return false;
    abd<a>.a a = new abd<a>.a();
    a.a = (object) A_0;
    a.b = A_1;
    for (int index1 = A_1_1.i(); index1 <= A_1_1.j(); ++index1)
    {
      for (int index2 = A_1_1.k(); index2 <= A_1_1.l(); ++index2)
        this.a[index1 * this.e + index2].Add(a);
    }
    return true;
  }

  public void b(a A_0, ahk A_1)
  {
    abd<a>.a a = new abd<a>.a();
    a.a = (object) A_0;
    a.b = new acd(A_1, ahk.d(A_1, new ahk(0.0001f, 0.0001f)));
    int index = this.d(A_1);
    if (index <= 0 || index >= this.a.Length)
      return;
    this.a[index].Add(a);
  }

  public bool c(a A_0, acd A_1)
  {
    abg A_1_1;
    if (!this.b(A_1, out A_1_1))
      return false;
    for (int index1 = A_1_1.i(); index1 <= A_1_1.j(); ++index1)
    {
      for (int index2 = A_1_1.k(); index2 <= A_1_1.l(); ++index2)
      {
        List<abd<a>.a> aList = this.a[index1 * this.e + index2];
        for (int index3 = 0; index3 < aList.Count; ++index3)
        {
          if ((!this.g ? (object.ReferenceEquals(aList[index3].a, (object) A_0) ? 1 : 0) : (aList[index3].a.Equals((object) A_0) ? 1 : 0)) != 0)
          {
            aList.RemoveAt(index3);
            break;
          }
        }
      }
    }
    return false;
  }

  public void c(a A_0, ahk A_1)
  {
    int A_1_1 = this.d(A_1);
    this.b(A_0, A_1_1);
  }

  public void b(a A_0, int A_1)
  {
    if (A_1 <= 0 || A_1 >= this.a.Length)
      return;
    List<abd<a>.a> aList = this.a[A_1];
    for (int index = 0; index < aList.Count; ++index)
    {
      if ((!this.g ? (object.ReferenceEquals(aList[index].a, (object) A_0) ? 1 : 0) : (aList[index].a.Equals((object) A_0) ? 1 : 0)) != 0)
      {
        aList.RemoveAt(index);
        break;
      }
    }
  }

  public void b(acd A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    abd<a>.c c = new abd<a>.c();
    // ISSUE: reference to a compiler-generated field
    c.a = A_0;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    this.b(c.a, new abd<a>.b(c.b));
  }

  public void b(ace A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    abd<a>.d d = new abd<a>.d();
    // ISSUE: reference to a compiler-generated field
    d.a = A_0;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    this.b(d.a.c(), new abd<a>.b(d.b));
  }

  public void b(ks A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    abd<a>.e e = new abd<a>.e();
    // ISSUE: reference to a compiler-generated field
    e.a = A_0;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    this.b(e.a.d(), new abd<a>.b(e.b));
  }

  private void b(acd A_0, abd<a>.b A_1)
  {
    A_0.k(this.b());
    abg A_1_1;
    if (!this.b(A_0, out A_1_1))
      return;
    HashSet<abd<a>.a> aSet = new HashSet<abd<a>.a>();
    for (int index1 = A_1_1.i(); index1 <= A_1_1.j(); ++index1)
    {
      for (int index2 = A_1_1.k(); index2 <= A_1_1.l(); ++index2)
      {
        int index3 = index1 * this.e + index2;
        int index4 = 0;
        for (int count = this.a[index3].Count; index4 < count; ++index4)
          aSet.Add(this.a[index3][index4]);
      }
    }
    foreach (abd<a>.a A_0_1 in aSet)
    {
      if (A_0_1 != null && A_1(A_0_1))
        this.c((a) A_0_1.a, A_0_1.b);
    }
  }

  public HashSet<a> b(ahk A_0)
  {
    HashSet<a> aSet = new HashSet<a>();
    int index = this.d(A_0);
    if (index >= 0 && index < this.a.Length)
    {
      foreach (abd<a>.a a in this.a[index])
      {
        if (a.b.i(A_0))
          aSet.Add((a) a.a);
      }
    }
    return aSet;
  }

  public List<abd<a>.a> c(ahk A_0)
  {
    int index = this.d(A_0);
    if (index >= 0 && index < this.a.Length)
      return this.a[index];
    return (List<abd<a>.a>) null;
  }

  public List<abd<a>.a> b(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.a.Length)
      return this.a[A_0];
    return (List<abd<a>.a>) null;
  }

  public HashSet<a> c(acd A_0)
  {
    HashSet<a> aSet = new HashSet<a>();
    abg A_1;
    if (this.b(A_0, out A_1))
    {
      for (int index1 = A_1.i(); index1 <= A_1.j(); ++index1)
      {
        for (int index2 = A_1.k(); index2 <= A_1.l(); ++index2)
        {
          foreach (abd<a>.a a in this.a[index1 * this.e + index2])
          {
            if (a.b.i(A_0))
              aSet.Add((a) a.a);
          }
        }
      }
    }
    return aSet;
  }

  public HashSet<a> c(ace A_0)
  {
    acd A_0_1 = A_0.c();
    HashSet<a> aSet = new HashSet<a>();
    abg A_1;
    if (this.b(A_0_1, out A_1))
    {
      for (int index1 = A_1.i(); index1 <= A_1.j(); ++index1)
      {
        for (int index2 = A_1.k(); index2 <= A_1.l(); ++index2)
        {
          foreach (abd<a>.a a in this.a[index1 * this.e + index2])
          {
            if (A_0.c(a.b.j()))
              aSet.Add((a) a.a);
          }
        }
      }
    }
    return aSet;
  }

  public int d(ahk A_0)
  {
    ahk ahk = ahk.c(A_0, this.b);
    // ISSUE: reference to a compiler-generated method
    int num = (int) Math.Floor((double) ahk.g() / (double) this.c);
    // ISSUE: reference to a compiler-generated method
    return (int) Math.Floor((double) ahk.h() / (double) this.d) * this.e + num;
  }

  protected bool b(acd A_0, out abg A_1)
  {
    acd acd = new acd(ahk.c(A_0.a, this.b), ahk.c(A_0.b, this.b));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1 = new abg((int) Math.Floor((double) acd.a.g() / (double) this.c), (int) Math.Floor((double) acd.a.h() / (double) this.d), (int) Math.Floor((double) acd.b.g() / (double) this.c), (int) Math.Floor((double) acd.b.h() / (double) this.d));
    if (A_1.k() >= 0 && A_1.i() >= 0 && A_1.l() < this.e)
      return A_1.j() < this.f;
    return false;
  }

  public int b(ahk A_0, int A_1, int[] A_2)
  {
    int num1 = this.d(A_0);
    int num2 = 0;
    for (int index1 = -A_1; index1 <= A_1; ++index1)
    {
      for (int index2 = -A_1; index2 <= A_1; ++index2)
      {
        if (index2 != 0 || index1 != 0)
        {
          int num3 = num1 + index1 * this.e + index2;
          if (num3 > 0 && num3 < this.a.Length)
            A_2[num2++] = num3;
        }
      }
    }
    return num2;
  }

  public class a : IEquatable<abd<a>.a>
  {
    public object a;
    public acd b;

    public bool Equals(abd<a>.a other)
    {
      if (this.a.Equals(other.a))
        return this.b.Equals(other.b);
      return false;
    }
  }

  private delegate bool b(abd<a>.a A_0);
}
