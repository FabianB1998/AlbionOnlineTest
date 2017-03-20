// Decompiled with JetBrains decompiler
// Type: g0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class g0 : et
{
  public static readonly string ff = "resurrect";

  [SpecialName]
  public override string cl()
  {
    return g0.ff;
  }

  public override es.a cm()
  {
    return es.a.a;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "restoration", 1f));
    return base.cj(A_0);
  }
}
