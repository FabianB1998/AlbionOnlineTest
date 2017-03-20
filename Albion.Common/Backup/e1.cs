// Decompiled with JetBrains decompiler
// Type: e1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class e1 : et
{
  public static readonly string ap = "removeactivespell";

  [SpecialName]
  public override string cl()
  {
    return e1.ap;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    return this.h6() ? es.a.b : es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "spell", ""));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "charges", 999));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "casterchargesonly", false));
    return base.cj(A_0);
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
