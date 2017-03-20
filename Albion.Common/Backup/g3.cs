// Decompiled with JetBrains decompiler
// Type: g3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class g3 : e3
{
  public static readonly string fk = "spellimmunity";

  [SpecialName]
  public override string cl()
  {
    return g3.fk;
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
    this.h3(aim.a(A_0, "spellname", ""));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<gs.SpellCategory>(A_0, "category", gs.SpellCategory.None));
    // ISSUE: reference to a compiler-generated method
    this.h4(false);
    return true;
  }
}
