// Decompiled with JetBrains decompiler
// Type: kk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class kk : kh
{
  private static kk.a[] a = new kk.a[8]{ new kk.a() { a = new abf(0, -1), c = 1f, b = 1U }, new kk.a() { a = new abf(1, -1), c = 1.41f, b = 7U }, new kk.a() { a = new abf(1, 0), c = 1f, b = 4U }, new kk.a() { a = new abf(1, 1), c = 1.41f, b = 28U }, new kk.a() { a = new abf(0, 1), c = 1f, b = 16U }, new kk.a() { a = new abf(-1, 1), c = 1.41f, b = 112U }, new kk.a() { a = new abf(-1, 0), c = 1f, b = 64U }, new kk.a() { a = new abf(-1, -1), c = 1.41f, b = 448U } };

  public bool a(kl A_0, abf A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    abf abf = new abf(A_1.c() + A_2, A_1.d() + A_3);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (abf.c() < 0 || abf.d() < 0 || (abf.c() >= A_0.g() || abf.d() >= A_0.h()))
      return true;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (int) A_0.e(abf.c(), abf.d()) != 0;
  }

  public void a(kl A_0, kh.c A_1, ref List<abf> A_2)
  {
    A_2.Clear();
    // ISSUE: reference to a compiler-generated method
    if (A_1.k() == null)
    {
      foreach (kk.a a in kk.a)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), a.a.c(), a.a.d()))
        {
          // ISSUE: reference to a compiler-generated method
          A_2.Add(abf.f(A_1.l(), a.a));
        }
      }
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      int A_2_1 = Math.Min(Math.Max(-1, A_1.l().c() - A_1.k().l().c()), 1);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      int A_3 = Math.Min(Math.Max(-1, A_1.l().d() - A_1.k().l().d()), 1);
      if (A_2_1 != 0 && A_3 != 0)
      {
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), 0, A_3))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c(), A_1.l().d() + A_3));
        }
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), A_2_1, 0))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d()));
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), 0, A_3) || !this.a(A_0, A_1.l(), A_2_1, 0))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d() + A_3));
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.a(A_0, A_1.l(), -A_2_1, 0) && !this.a(A_0, A_1.l(), 0, A_3))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() - A_2_1, A_1.l().d() + A_3));
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), 0, -A_3) || this.a(A_0, A_1.l(), A_2_1, 0))
          return;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d() - A_3));
      }
      else if (A_2_1 == 0)
      {
        // ISSUE: reference to a compiler-generated method
        if (this.a(A_0, A_1.l(), 0, A_3))
          return;
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), 0, A_3))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c(), A_1.l().d() + A_3));
        }
        // ISSUE: reference to a compiler-generated method
        if (this.a(A_0, A_1.l(), 1, 0))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() + 1, A_1.l().d() + A_3));
        }
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), -1, 0))
          return;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(new abf(A_1.l().c() - 1, A_1.l().d() + A_3));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        if (this.a(A_0, A_1.l(), A_2_1, 0))
          return;
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), A_2_1, 0))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d()));
        }
        // ISSUE: reference to a compiler-generated method
        if (this.a(A_0, A_1.l(), 0, 1))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d() + 1));
        }
        // ISSUE: reference to a compiler-generated method
        if (!this.a(A_0, A_1.l(), 0, -1))
          return;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(new abf(A_1.l().c() + A_2_1, A_1.l().d() - 1));
      }
    }
  }

  private bool a(kl A_0, abf A_1, int A_2, int A_3, abf A_4, abf A_5, out abf A_6)
  {
    A_6 = A_1;
    if (this.a(A_0, A_1, A_2, A_3))
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    abf A_0_1 = new abf(A_1.c() + A_2, A_1.d() + A_3);
    if (abf.d(A_0_1, A_5))
    {
      A_6 = A_0_1;
      return true;
    }
    abf abf = A_0_1;
    if (A_2 != 0 && A_3 != 0)
    {
      while ((this.a(A_0, abf, -A_2, A_3) || !this.a(A_0, abf, -A_2, 0)) && (this.a(A_0, abf, A_2, -A_3) || !this.a(A_0, abf, 0, -A_3)))
      {
        abf A_6_1;
        if (this.a(A_0, abf, A_2, 0, A_4, A_5, out A_6_1) || this.a(A_0, abf, 0, A_3, A_4, A_5, out A_6_1))
        {
          A_6 = abf;
          return true;
        }
        if (this.a(A_0, abf, A_2, A_3))
          return false;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        abf.c(abf.c() + A_2);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        abf.d(abf.d() + A_3);
        if (abf.d(abf, A_5))
        {
          A_6 = abf;
          return true;
        }
      }
      A_6 = abf;
      return true;
    }
    if (A_2 != 0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      do
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        abf A_1_1 = new abf(abf.c(), A_0_1.d());
        if (!this.a(A_0, A_1_1, A_2, 1) && this.a(A_0, A_1_1, 0, 1) || !this.a(A_0, A_1_1, A_2, -1) && this.a(A_0, A_1_1, 0, -1))
        {
          A_6 = A_1_1;
          return true;
        }
        if (this.a(A_0, A_1_1, A_2, 0))
          return false;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        abf.c(abf.c() + A_2);
      }
      while (abf.c() != A_5.c() || A_0_1.d() != A_5.d());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_6 = new abf(abf.c(), A_0_1.d());
      return true;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    do
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      abf A_1_1 = new abf(A_0_1.c(), abf.d());
      if (!this.a(A_0, A_1_1, 1, A_3) && this.a(A_0, A_1_1, 1, 0) || !this.a(A_0, A_1_1, -1, A_3) && this.a(A_0, A_1_1, -1, 0))
      {
        A_6 = A_1_1;
        return true;
      }
      if (this.a(A_0, A_1_1, 0, A_3))
        return false;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      abf.d(abf.d() + A_3);
    }
    while (A_0_1.c() != A_5.c() || abf.d() != A_5.d());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_6 = new abf(A_0_1.c(), abf.d());
    return true;
  }

  protected override List<abf> cv(ab9 A_0, float A_1, float A_2, abf A_3, abf A_4, float A_5, float A_6, long A_7, TimeSpan A_8, out Dictionary<abf, kh.c> A_9, out TimeSpan A_10)
  {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    kl A_0_1 = A_0.f(A_1, A_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_4.c() < 0 || A_4.d() < 0 || (A_4.c() >= A_0_1.g() || A_4.d() >= A_0_1.h()) || (int) A_0_1.e(A_4.c(), A_4.d()) != 0)
    {
      A_9 = (Dictionary<abf, kh.c>) null;
      A_10 = TimeSpan.FromSeconds(0.0);
      return (List<abf>) null;
    }
    List<abf> A_2_1 = new List<abf>(8);
    g<kh.c, float> g = new g<kh.c, float>();
    Dictionary<abf, kh.c> dictionary = new Dictionary<abf, kh.c>(1000);
    A_9 = dictionary;
    kh.c A_0_2 = new kh.c(A_3);
    // ISSUE: reference to a compiler-generated method
    A_0_2.h(this.a(A_3, A_4));
    g.c(A_0_2, -A_0_2.i());
    // ISSUE: reference to a compiler-generated method
    dictionary.Add(A_0_2.l(), A_0_2);
    while (!g.e() && ((long) dictionary.Count <= A_7 && !(stopwatch.Elapsed > A_8)))
    {
      kh.c c = g.g();
      // ISSUE: reference to a compiler-generated method
      if (abf.d(c.l(), A_4))
      {
        stopwatch.Stop();
        A_10 = stopwatch.Elapsed;
        return this.a(A_0, A_2, A_1, c);
      }
      this.a(A_0_1, c, ref A_2_1);
      for (int index = 0; index < A_2_1.Count; ++index)
      {
        abf A_1_1 = A_2_1[index];
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int A_2_2 = Math.Min(Math.Max(-1, A_1_1.c() - c.l().c()), 1);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int A_3_1 = Math.Min(Math.Max(-1, A_1_1.d() - c.l().d()), 1);
        abf A_6_1;
        if (this.a(A_0_1, A_1_1, A_2_2, A_3_1, A_3, A_4, out A_6_1))
        {
          abf abf = A_6_1;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          float A_0_3 = c.g() + this.a(c.l(), abf);
          kh.c A_0_4 = (kh.c) null;
          bool flag = false;
          if (dictionary.TryGetValue(abf, out A_0_4))
          {
            // ISSUE: reference to a compiler-generated method
            if ((double) A_0_4.g() > (double) A_0_3)
            {
              flag = true;
              // ISSUE: reference to a compiler-generated method
              if (!A_0_4.j())
                g.d(A_0_4, -A_0_4.i());
            }
            else
              continue;
          }
          else
            A_0_4 = new kh.c(abf);
          // ISSUE: reference to a compiler-generated method
          A_0_4.g(c);
          // ISSUE: reference to a compiler-generated method
          A_0_4.g(A_0_3);
          // ISSUE: reference to a compiler-generated method
          A_0_4.h(this.a(abf, A_4));
          // ISSUE: reference to a compiler-generated method
          A_0_4.g(false);
          g.c(A_0_4, -A_0_4.i());
          if (!flag)
          {
            // ISSUE: reference to a compiler-generated method
            dictionary.Add(A_0_4.l(), A_0_4);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      c.g(true);
    }
    stopwatch.Stop();
    A_10 = stopwatch.Elapsed;
    return (List<abf>) null;
  }

  protected float a(abf A_0, abf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int val1 = Math.Abs(A_0.c() - A_1.c());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int val2 = Math.Abs(A_0.d() - A_1.d());
    int num1 = Math.Min(val1, val2);
    int num2 = Math.Max(val1, val2) - num1;
    return (float) num1 * 1.41f + (float) num2;
  }

  private struct a
  {
    public abf a;
    public uint b;
    public float c;
  }
}
