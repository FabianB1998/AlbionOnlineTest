// Decompiled with JetBrains decompiler
// Type: e0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class e0 : et
{
  public static readonly string am = "applyspell";

  [SpecialName]
  public override string cl()
  {
    return e0.am;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "spell"));
    return base.cj(A_0);
  }

  public override void cn(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3(A_0.ao().h0(this.h3()));
    base.cn(A_0);
  }
}
