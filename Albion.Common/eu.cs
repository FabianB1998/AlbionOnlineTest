// Decompiled with JetBrains decompiler
// Type: eu
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class eu : et
{
  public static readonly string s = "escapedungeon";

  [SpecialName]
  public override string cl()
  {
    return eu.s;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h3(et.EffectTarget.Self);
    return true;
  }
}
