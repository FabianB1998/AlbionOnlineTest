// Decompiled with JetBrains decompiler
// Type: dy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class dy : bd
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.b(A_0, "defaultcostfriends", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.b(A_0, "defaultcostother", kx.g));
    return true;
  }
}
