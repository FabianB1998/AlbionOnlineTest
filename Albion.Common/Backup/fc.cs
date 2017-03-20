// Decompiled with JetBrains decompiler
// Type: fc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Runtime.CompilerServices;
using System.Xml;

public class fc : fb
{
  public static readonly string bw = "weightbonus";

  [SpecialName]
  public override string cl()
  {
    return fc.bw;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "item"));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "value", float.NaN));
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h4() != double.NaN)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.h3((float) (1.0 / (1.0 - (double) this.h4()) - 1.0));
    }
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "item":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h3(), A_0);
      case "value":
        // ISSUE: reference to a compiler-generated method
        return er.h3(PlayerAttribute.MaxLoadBonus, this.h4(), A_0, false);
      default:
        return base.ck(A_0);
    }
  }
}
