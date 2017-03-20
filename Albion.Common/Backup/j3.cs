// Decompiled with JetBrains decompiler
// Type: j3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class j3
{
  public bool e(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.b(A_0, "weight", 1));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.b(A_0, "tier", 1));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "faction", "ANY"));
    return true;
  }
}
