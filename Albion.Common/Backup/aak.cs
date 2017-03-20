// Decompiled with JetBrains decompiler
// Type: aak
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class aak : IComparable<aak>, IDisposable
{
  public aak(aaq A_0, aal A_1, e3 A_2, int A_3, GameTimeStamp A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(A_1);
    // ISSUE: reference to a compiler-generated method
    this.l(A_0);
    // ISSUE: reference to a compiler-generated method
    this.l(A_2);
    // ISSUE: reference to a compiler-generated method
    this.l(A_3);
    // ISSUE: reference to a compiler-generated method
    this.l(A_4);
    // ISSUE: reference to a compiler-generated method
    this.m(1);
  }

  [SpecialName]
  public gs o()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.l().d();
  }

  [SpecialName]
  public GameTimeStamp q()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.l().f();
  }

  [SpecialName]
  public ahy s()
  {
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.c(this.r(), this.q());
  }

  [SpecialName]
  public bool t()
  {
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.f(this.q(), this.r());
  }

  public virtual void Dispose()
  {
  }

  public int CompareTo(aak pOther)
  {
    if (this.t())
    {
      if (pOther.t())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return this.r().Ticks.CompareTo(pOther.r().Ticks);
      }
      return -1;
    }
    return pOther.t() ? 1 : 0;
  }
}
