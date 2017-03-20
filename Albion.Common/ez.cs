// Decompiled with JetBrains decompiler
// Type: ez
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ez : et
{
  public static readonly string ak = "maketargettopthreat";

  [SpecialName]
  public override string cl()
  {
    return ez.ak;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "factor", 1.31f));
    return base.cj(A_0);
  }
}
