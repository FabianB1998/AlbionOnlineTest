// Decompiled with JetBrains decompiler
// Type: fe
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fe : fb
{
  public static readonly string b6 = "resourcegatheringbuff";

  [SpecialName]
  public override string cl()
  {
    return fe.b6;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "resourcetype"));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "tier", 1));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "value", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fe.ResourceGatheringBuffTypes>(A_0, "bufftype", fe.ResourceGatheringBuffTypes.GatheringYield));
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "resourcetype":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return kr.b("@ITEMS_T" + (object) this.h5() + "_" + this.h4());
      case "tier":
        // ISSUE: reference to a compiler-generated method
        return this.h5().ToString();
      case "value":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h3());
      default:
        return base.ck(A_0);
    }
  }

  public enum ResourceGatheringBuffTypes
  {
    GatheringYield,
    GatheringSpeed,
  }
}
