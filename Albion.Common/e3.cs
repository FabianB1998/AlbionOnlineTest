// Decompiled with JetBrains decompiler
// Type: e3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public abstract class e3 : et
{
  [SpecialName]
  public bool ip()
  {
    // ISSUE: reference to a compiler-generated method
    return (double) this.io() > 0.0;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h7(ahy.l((double) aim.a(A_0, "time", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "damagebreakseffect", false));
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.a(A_0, "attackingbreakseffect", false));
    // ISSUE: reference to a compiler-generated method
    this.h6(aim.a(A_0, "mountingbreakseffect", false));
    // ISSUE: reference to a compiler-generated method
    this.h7(aim.a(A_0, "worldinteractionbreakseffect", false));
    // ISSUE: reference to a compiler-generated method
    this.h8(aim.a(A_0, "castingbreakseffect", false));
    // ISSUE: reference to a compiler-generated method
    this.h9(aim.a(A_0, "persistsafterdeath", false));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ia(aim.a(A_0, "persistsafterknockdown", this.im()));
    // ISSUE: reference to a compiler-generated method
    this.ib(aim.a(A_0, "ignorecrowdcontrolresistance", false));
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.a(A_0, "targetcountdurationbonusfactor", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h6(aim.a(A_0, "expireafterdistance", 0.0f));
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "time":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.@if(), (et) this, A_0);
      default:
        return base.ck(A_0);
    }
  }
}
