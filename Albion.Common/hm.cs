// Decompiled with JetBrains decompiler
// Type: hm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class hm : et
{
  public static readonly string fq = "changeequipment";

  [SpecialName]
  public override string cl()
  {
    return hm.fq;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hm.TargetItems>(A_0, "targetitem", hm.TargetItems.Weapon));
    return base.cj(A_0);
  }

  public enum TargetItems
  {
    Weapon,
    Tool,
  }
}
