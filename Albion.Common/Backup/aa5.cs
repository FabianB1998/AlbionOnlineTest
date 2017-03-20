// Decompiled with JetBrains decompiler
// Type: aa5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System.Runtime.CompilerServices;

public class aa5 : aa2
{
  public aa5(float A_0, int A_1, aa5.EffectType A_2, aa5.a A_3, long A_4)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(A_1);
    // ISSUE: reference to a compiler-generated method
    this.r(A_2);
    // ISSUE: reference to a compiler-generated method
    this.r(A_3);
    // ISSUE: reference to a compiler-generated method
    this.r(A_4);
    // ISSUE: reference to a compiler-generated method
    this.r(false);
    // ISSUE: reference to a compiler-generated method
    this.r(global::l.a);
  }

  public aa5(float A_0, int A_1, aa5.EffectType A_2, aa5.a A_3, long A_4, GameTimeStamp A_5, float A_6)
    : base(A_0, A_5, A_6)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(A_1);
    // ISSUE: reference to a compiler-generated method
    this.r(A_4);
    // ISSUE: reference to a compiler-generated method
    this.r(A_2);
    // ISSUE: reference to a compiler-generated method
    this.r(A_3);
    // ISSUE: reference to a compiler-generated method
    this.r(false);
    // ISSUE: reference to a compiler-generated method
    this.r(global::l.a);
  }

  [SpecialName]
  public bool y()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.x() != global::l.c)
    {
      // ISSUE: reference to a compiler-generated method
      return this.x() == global::l.d;
    }
    return true;
  }

  public enum EffectType
  {
    None,
    Physical,
    Magic,
  }

  public enum a
  {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
  }

  public enum ReflectDamageBehavior
  {
    BasedOnOrigin,
    Always,
    Never,
  }
}
