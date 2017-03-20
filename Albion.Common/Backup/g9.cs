// Decompiled with JetBrains decompiler
// Type: g9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;

public class g9
{
  public void h(ha A_0)
  {
    hb A_1 = A_0.h2(0);
    hc A_2 = A_0.h3(0);
    this.h(A_0, A_1, A_2, 0, 0, 0, 1f, 0.0f);
  }

  public void h(ha A_0, int A_1, int A_2, int A_3, int A_4, int A_5, float A_6, float A_7)
  {
    hb A_1_1 = A_0.h2(A_1);
    hc A_2_1 = A_0.h3(A_2);
    this.h(A_0, A_1_1, A_2_1, A_3, A_4, A_5, A_6, A_7);
  }

  public void h(ha A_0, string A_1, string A_2, int A_3, int A_4, int A_5, float A_6, float A_7)
  {
    hb A_1_1 = A_0.hz(A_1);
    hc A_2_1 = A_0.h0(A_2);
    this.h(A_0, A_1_1, A_2_1, A_3, A_4, A_5, A_6, A_7);
  }

  public void h(ha A_0, hb A_1, hc A_2, int A_3, int A_4, int A_5, float A_6, float A_7)
  {
    if (A_0 == null)
      return;
    if (A_1 == null)
      A_1 = A_0.h2(0);
    if (A_2 == null)
      A_2 = A_0.h3(0);
    // ISSUE: reference to a compiler-generated method
    this.h(A_1);
    // ISSUE: reference to a compiler-generated method
    this.h(A_2);
    // ISSUE: reference to a compiler-generated method
    A_3 = abh.a<int>(abh.b<int>(A_3, 0), A_0.h5() - 1);
    // ISSUE: reference to a compiler-generated method
    A_4 = abh.a<int>(abh.b<int>(A_4, 0), A_0.h5() - 1);
    if (!A_0.h3().Contains(A_5))
      A_5 = A_0.ic();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_6 = abh.a<float>(abh.b<float>(A_6, A_0.h7()), A_0.h8());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_7 = abh.a<float>(abh.b<float>(A_7, A_0.h9()), A_0.ia());
    // ISSUE: reference to a compiler-generated method
    this.j(A_3);
    // ISSUE: reference to a compiler-generated method
    this.i(A_4);
    // ISSUE: reference to a compiler-generated method
    this.h(A_5);
    // ISSUE: reference to a compiler-generated method
    this.i(A_6);
    // ISSUE: reference to a compiler-generated method
    this.h(A_7);
  }

  private int h(Random A_0, int A_1)
  {
    return A_0.Next(A_1 * 9999) / 9999;
  }

  public void h(ha A_0, List<string> A_1)
  {
    this.h(A_0, (Random) null, A_1);
  }

  public void h(ha A_0, Random A_1, List<string> A_2)
  {
    if (A_1 == null)
      A_1 = new Random();
    List<hc> hcList;
    if (A_2 == null || A_2.Count == 0)
    {
      hcList = A_0.ib();
    }
    else
    {
      hcList = new List<hc>((IEnumerable<hc>) A_0.ib());
      foreach (string A_0_1 in A_2)
      {
        hc hc = A_0.h0(A_0_1);
        if (hc != null)
          hcList.Add(hc);
      }
    }
    int index1 = this.h(A_1, hcList.Count);
    // ISSUE: reference to a compiler-generated method
    int A_0_2 = hcList[index1].f();
    int A_0_3 = this.h(A_1, A_0.hz().Count);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.j(this.h(A_1, A_0.h5()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(this.h(A_1, A_0.h5()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    while (this.k() == this.j())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.i(this.h(A_1, A_0.h5()));
    }
    int index2 = this.h(A_1, A_0.h3().Count);
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.h3()[index2]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i((float) A_1.NextDouble() * (A_0.h8() - A_0.h7()) + A_0.h7());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h((float) A_1.NextDouble() * (A_0.ia() - A_0.h9()) + A_0.h9());
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.h2(A_0_3));
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.h3(A_0_2));
  }

  public string o()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.h().g().ToString() + "_" + (object) this.i().f() + "_" + (object) this.j() + "_" + (object) this.k() + "_" + (object) this.l() + "_" + (object) this.m() + "_" + (object) this.n();
  }
}
