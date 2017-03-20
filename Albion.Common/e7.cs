// Decompiled with JetBrains decompiler
// Type: e7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class e7 : e3
{
  public static readonly string bh = "castspellaftermoving";

  [SpecialName]
  public override string cl()
  {
    return e7.bh;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h7(ahy.l((double) aim.a(A_0, "time", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "spell", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.h5(ahy.l((double) aim.a(A_0, "movetimetocast", -1f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "standtimetoendspell", -1f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "damageresetstimetocast", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "cooldownafterdamage", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "minmovespeed", 0.0f));
    return true;
  }

  public override void cn(g8 A_0)
  {
    base.cn(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3(A_0.ao().h0(this.h3()));
  }
}
