// Decompiled with JetBrains decompiler
// Type: ki
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ki : kh
{
  private static ki.a[] a = new ki.a[8]{ new ki.a() { a = new abf(0, -1), c = 1f, b = 1U }, new ki.a() { a = new abf(1, -1), c = 1.41f, b = 7U }, new ki.a() { a = new abf(1, 0), c = 1f, b = 4U }, new ki.a() { a = new abf(1, 1), c = 1.41f, b = 28U }, new ki.a() { a = new abf(0, 1), c = 1f, b = 16U }, new ki.a() { a = new abf(-1, 1), c = 1.41f, b = 112U }, new ki.a() { a = new abf(-1, 0), c = 1f, b = 64U }, new ki.a() { a = new abf(-1, -1), c = 1.41f, b = 448U } };

  protected override List<abf> cv(ab9 A_0, float A_1, float A_2, abf A_3, abf A_4, float A_5, float A_6, long A_7, TimeSpan A_8, out Dictionary<abf, kh.c> A_9, out TimeSpan A_10)
  {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    kl kl = A_0.f(A_1, A_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_5 <= 0.0 && (A_4.c() < 0 || A_4.d() < 0 || (A_4.c() >= kl.g() || A_4.d() >= kl.h()) || (int) kl.e(A_4.c(), A_4.d()) != 0))
    {
      A_9 = (Dictionary<abf, kh.c>) null;
      A_10 = TimeSpan.FromSeconds(0.0);
      return (List<abf>) null;
    }
    g<kh.c, float> g = new g<kh.c, float>();
    Dictionary<abf, kh.c> dictionary = new Dictionary<abf, kh.c>(1000);
    A_9 = dictionary;
    kh.c A_0_1 = new kh.c(A_3);
    // ISSUE: reference to a compiler-generated method
    A_0_1.h(this.a(A_3, A_4));
    g.c(A_0_1, -A_0_1.i());
    // ISSUE: reference to a compiler-generated method
    dictionary.Add(A_0_1.l(), A_0_1);
    while (!g.e() && ((long) dictionary.Count <= A_7 && !(stopwatch.Elapsed > A_8)))
    {
      kh.c c = g.g();
      // ISSUE: reference to a compiler-generated method
      if ((double) c.h() <= (double) A_5)
      {
        stopwatch.Stop();
        A_10 = stopwatch.Elapsed;
        return this.a(A_0, A_2, A_1, c);
      }
      int num = 0;
      for (int index = 0; index < ki.a.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        abf abf = abf.f(c.l(), ki.a[index].a);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (abf.c() < 0 || abf.d() < 0 || (abf.c() >= kl.g() || abf.d() >= kl.h()) || (int) kl.e(abf.c(), abf.d()) != 0)
          num |= 1 << index;
      }
      foreach (ki.a a in ki.a)
      {
        // ISSUE: reference to a compiler-generated method
        abf abf = abf.f(c.l(), a.a);
        if (((long) num & (long) a.b) == 0L)
        {
          // ISSUE: reference to a compiler-generated method
          float A_0_2 = c.g() + a.c;
          if ((double) A_0_2 <= (double) A_6)
          {
            kh.c A_0_3 = (kh.c) null;
            bool flag = false;
            if (dictionary.TryGetValue(abf, out A_0_3))
            {
              // ISSUE: reference to a compiler-generated method
              if ((double) A_0_3.g() > (double) A_0_2)
              {
                flag = true;
                // ISSUE: reference to a compiler-generated method
                if (!A_0_3.j())
                  g.d(A_0_3, -A_0_3.i());
              }
              else
                continue;
            }
            else
              A_0_3 = new kh.c(abf);
            // ISSUE: reference to a compiler-generated method
            A_0_3.g(c);
            // ISSUE: reference to a compiler-generated method
            A_0_3.g(A_0_2);
            // ISSUE: reference to a compiler-generated method
            A_0_3.h(this.a(abf, A_4));
            // ISSUE: reference to a compiler-generated method
            A_0_3.g(false);
            g.c(A_0_3, -A_0_3.i());
            if (!flag)
            {
              // ISSUE: reference to a compiler-generated method
              dictionary.Add(A_0_3.l(), A_0_3);
            }
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
