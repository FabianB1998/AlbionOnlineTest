// Decompiled with JetBrains decompiler
// Type: a5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class a5 : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.BonusDamageVsMobs;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "tier", -1));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "bonus", -1f));
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.av() >= 1 && this.av() <= 8)
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add("Reward " + (object) this.ay() + ": Tier is invalid: " + (object) this.av());
    }
    return false;
  }
}
