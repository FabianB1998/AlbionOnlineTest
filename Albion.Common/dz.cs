// Decompiled with JetBrains decompiler
// Type: dz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class dz : bd
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a(A_0, "local", false));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.b(A_0, "range", 1));
    return true;
  }
}
