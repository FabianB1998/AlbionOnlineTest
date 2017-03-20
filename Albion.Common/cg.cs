// Decompiled with JetBrains decompiler
// Type: cg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class cg
{
  public cg(da A_0, GameTimeStamp A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(Guid.NewGuid());
    // ISSUE: reference to a compiler-generated method
    this.m(A_0);
    // ISSUE: reference to a compiler-generated method
    this.m(A_1);
  }

  [SpecialName]
  public int r()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.n().ac();
  }

  [SpecialName]
  public GameTimeStamp s()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.b(this.o(), this.n().ar());
  }

  public virtual void m(ah6 A_0, int A_1, kx A_2, g8 A_3, kt A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_0);
    // ISSUE: reference to a compiler-generated method
    this.m(A_1);
    // ISSUE: reference to a compiler-generated method
    this.m(A_2);
    // ISSUE: reference to a compiler-generated method
    this.m(new Dictionary<string, ci.a>());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(new ci.a[this.n().au().Count]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.n().au().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ci ci = this.n().au()[index];
      ci.a a = ci.bo(A_0, A_3, A_4);
      // ISSUE: reference to a compiler-generated method
      this.u()[index] = a;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.t().Add(ci.m(), a);
    }
    this.z();
  }

  public virtual void m(Guid A_0, ah6 A_1, int A_2, kx A_3, g8 A_4, object[] A_5)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_0);
    // ISSUE: reference to a compiler-generated method
    this.m(A_1);
    // ISSUE: reference to a compiler-generated method
    this.m(A_2);
    // ISSUE: reference to a compiler-generated method
    this.m(A_3);
    // ISSUE: reference to a compiler-generated method
    this.m(new Dictionary<string, ci.a>());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(new ci.a[this.n().au().Count]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_5.Length && index < this.n().au().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ci ci = this.n().au()[index];
      ci.a a = ci.bp(A_5[index], A_4);
      // ISSUE: reference to a compiler-generated method
      this.u()[index] = a;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.t().Add(ci.m(), a);
    }
    this.z();
  }

  public bool y()
  {
    return GameTimeStamp.e(this.s(), GameTimeStamp.Now);
  }

  public string m(string A_0)
  {
    ci.a a = (ci.a) null;
    // ISSUE: reference to a compiler-generated method
    this.t().TryGetValue(A_0, out a);
    if (a != null)
      return a.bq();
    return A_0;
  }

  protected void z()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.n().av() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.m(new List<ch>(this.n().av().Count));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (c8 A_0 in this.n().av())
      {
        // ISSUE: reference to a compiler-generated method
        ch ch = new ch(this, A_0.g());
        ch.e(A_0);
        // ISSUE: reference to a compiler-generated method
        this.w().Add(ch);
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.n().aw() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(new ch(this, this.n().aw().g()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.x().e(this.n().aw());
  }

  public kx aa()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.n().ab(this.v());
  }

  public kx m(a7 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.n().ab(A_0, this.v());
  }

  public void n(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_0);
  }
}
