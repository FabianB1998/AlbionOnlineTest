// Decompiled with JetBrains decompiler
// Type: dv
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class dv : bd
{
  [SpecialName]
  public override bool ba()
  {
    return false;
  }

  public override bool a4(XmlElement A_0, string A_1)
  {
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.ba(ahy.l((double) aim.a(A_0, "recoverytime", -1f)));
    return true;
  }
}
