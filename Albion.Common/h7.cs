// Decompiled with JetBrains decompiler
// Type: h7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Xml;

public class h7
{
  public bool m(XmlElement A_0)
  {
    if (A_0.Name != "treasure")
      throw new AlbionException("[TreasureChestInfo] ParseFromXml: XmlTag 'treasure' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.s(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a(A_0, "title", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.q(aim.a(A_0, "description", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "lootlist", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.m(ahy.l(aim.b(A_0, "openingtimeinsec", 5)));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "requirescastleownership", false));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.b(A_0, "minsilverreward", 0));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.b(A_0, "maxsilverreward", 0));
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "worldmapprefab", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "minimapiconfull", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "minimapiconempty", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.m(new h5());
    // ISSUE: reference to a compiler-generated method
    return this.x().d(A_0);
  }
}
