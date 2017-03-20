// Decompiled with JetBrains decompiler
// Type: h9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Xml;

public class h9
{
  public bool i(XmlElement A_0)
  {
    if (A_0.Name != "boss")
      throw new AlbionException("[WorldBossTypeInfo] ParseFromXml: XmlTag 'worldbosses' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "mob", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "title", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "description", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "worldmapprefab", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.k(aim.a(A_0, "minimapiconfull", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.j(aim.a(A_0, "minimapiconempty", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.i(new h5());
    // ISSUE: reference to a compiler-generated method
    return this.p().d(A_0);
  }
}
