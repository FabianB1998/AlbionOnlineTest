// Decompiled with JetBrains decompiler
// Type: aig
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;

public class aig : aca
{
  public List<aia.a> j = new List<aia.a>();

  public aig(kq A_0, ab9 A_1, g8 A_2, string A_3, aia A_4)
    : base(A_0, A_1, A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_3);
    // ISSUE: reference to a compiler-generated method
    this.m(A_4);
  }

  protected override bool de(kd A_0)
  {
    ahk A_0_1 = A_0.o("realestate", "size", new ahk(0.0f, 0.0f));
    kx A_0_2 = kx.f((double) A_0.o("realestate", "overridesaleprice", -1f));
    string A_0_3 = A_0.p("realestate", "locationquality", "");
    Guid A_0_4 = new Guid(A_0.p("realestate", "guid", ""));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acd A_0_5 = new acd(A_0.p().k() - A_0_1.g() / 2f, A_0.p().m() + A_0_1.h() / 2f, A_0.p().k() + A_0_1.g() / 2f, A_0.p().m() - A_0_1.h() / 2f);
    aia.a a = new aia.a();
    // ISSUE: reference to a compiler-generated method
    a.h(A_0_1);
    // ISSUE: reference to a compiler-generated method
    a.h(A_0_2);
    // ISSUE: reference to a compiler-generated method
    a.i(A_0_3);
    // ISSUE: reference to a compiler-generated method
    a.h(A_0_4);
    // ISSUE: reference to a compiler-generated method
    a.h(A_0_5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    a.h(this.m());
    this.j.Add(a);
    return false;
  }

  public void o()
  {
    foreach (aia.a a in this.j)
    {
      // ISSUE: reference to a compiler-generated method
      this.n().b.Add(a.l(), a);
    }
  }
}
