// Decompiled with JetBrains decompiler
// Type: f
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;

public class f<a> where a : class
{
  private f<a>.a a = new f<a>.a();

  public void a(string A_0, a A_1)
  {
    int A_1_1 = 0;
    f<a>.a A_2 = this.a(A_0, out A_1_1);
    this.a(A_0, A_1, A_2, A_1_1);
  }

  public void b(string A_0, a A_1)
  {
    int A_1_1 = 0;
    f<a>.a A_2 = this.a(A_0, out A_1_1);
    int num = A_0 != null ? A_0.Length : 0;
    if (A_1_1 + 1 == num && (object) A_2.b != null)
      A_2.b = A_1;
    else
      this.a(A_0, A_1, A_2, A_1_1);
  }

  private void a(string A_0, a A_1, f<a>.a A_2, int A_3)
  {
    int num = A_0 != null ? A_0.Length : 0;
    if (A_3 + 1 == num)
    {
      if ((object) A_2.b != null)
        throw new ArgumentException(A_0 + " already exists!");
      A_2.b = A_1;
    }
    else
    {
      for (++A_3; A_3 < num; ++A_3)
      {
        f<a>.a a = new f<a>.a() { a = A_2, c = A_0[A_3] };
        if (A_3 + 1 == num)
          a.b = A_1;
        if (A_2.d == null)
          A_2.d = new Dictionary<char, f<a>.a>();
        A_2.d.Add(a.c, a);
        A_2 = a;
      }
    }
  }

  public bool a(string A_0, out a A_1)
  {
    A_1 = default (a);
    f<a>.a a = this.a(A_0);
    if (a != null)
      A_1 = a.b;
    return (object) A_1 != null;
  }

  public bool b(string A_0)
  {
    f<a>.a a = this.a(A_0);
    if (a != null)
      return (object) a.b != null;
    return false;
  }

  public bool c(string A_0)
  {
    return this.a(A_0) != null;
  }

  public List<a> d(string A_0)
  {
    if (this.a(A_0) == null)
      return (List<a>) null;
    List<a> A_1 = new List<a>();
    this.a(A_0, A_1);
    return A_1;
  }

  public void a(string A_0, List<a> A_1)
  {
    f<a>.a A_0_1 = this.a(A_0);
    if (A_0_1 == null)
      return;
    f<a>.a(A_0_1, A_1);
  }

  public bool e(string A_0)
  {
    bool flag = false;
    f<a>.a A_1 = this.a(A_0);
    if (A_1 != null && (object) A_1.b != null)
    {
      flag = true;
      A_1.b = default (a);
      f<a>.a(A_0, A_1);
    }
    return flag;
  }

  private static void a(string A_0, f<a>.a A_1)
  {
    if (string.IsNullOrEmpty(A_0))
      return;
    int A_1_1 = A_0.Length - 1;
    f<a>.a(A_0, A_1_1, A_1);
  }

  private static void a(string A_0, int A_1, f<a>.a A_2)
  {
    if (A_2 == null || A_2.a == null || string.IsNullOrEmpty(A_0))
      return;
    char ch = A_0[A_1];
    if ((int) A_2.c != (int) ch)
      throw new ArgumentException();
    f<a>.a a;
    for (; A_2 != null && A_2.a != null && (A_2.d == null && (object) A_2.b == null); A_2 = a)
    {
      a = A_2.a;
      A_2.a = (f<a>.a) null;
      if (a.d != null)
      {
        a.d.Remove(A_2.c);
        if (a.d.Count == 0)
          a.d = (Dictionary<char, f<a>.a>) null;
      }
    }
  }

  private static void a(f<a>.a A_0, List<a> A_1)
  {
    if ((object) A_0.b != null)
      A_1.Add(A_0.b);
    if (A_0.d == null)
      return;
    foreach (f<a>.a A_0_1 in A_0.d.Values)
      f<a>.a(A_0_1, A_1);
  }

  private f<a>.a a(string A_0)
  {
    int A_1 = -1;
    f<a>.a a = this.a(A_0, out A_1);
    int num = A_0 != null ? A_0.Length : 0;
    if (A_1 + 1 != num)
      return (f<a>.a) null;
    return a;
  }

  private f<a>.a a(string A_0, out int A_1)
  {
    f<a>.a a1 = this.a;
    A_1 = -1;
    if (A_0 != null)
    {
      for (int index = 0; index < A_0.Length && a1.d != null; ++index)
      {
        f<a>.a a2 = (f<a>.a) null;
        if (a1.d.TryGetValue(A_0[index], out a2))
        {
          ++A_1;
          a1 = a2;
        }
        else
          break;
      }
    }
    return a1;
  }

  private class a
  {
    public f<a>.a a;
    public a b;
    public char c;
    public Dictionary<char, f<a>.a> d;
  }
}
