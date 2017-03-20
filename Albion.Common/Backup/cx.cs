// Decompiled with JetBrains decompiler
// Type: cx
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cx : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.PassiveBonus;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a<PlayerAttribute>(A_0, "attribute", PlayerAttribute.NumAttributes));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "bonus", -1f));
  }

  public override bool a1(bc.a A_0, g8 A_1)
  {
    bc.b b = A_0 as bc.b;
    if (b == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    this.au(b.e);
    // ISSUE: reference to a compiler-generated method
    this.au(b.c);
    // ISSUE: reference to a compiler-generated method
    return this.au() != PlayerAttribute.NumAttributes;
  }

  public override bool a2(bc.a A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    bc.b b = A_0 as bc.b;
    if (b == null)
    {
      A_2.Add(string.Format("Reward '{0}' has invalid template data!", (object) this.ay().ToString()));
      return false;
    }
    bool flag = false;
    if ((double) b.e == 0.0)
    {
      A_2.Add(string.Format("Reward '{0}' has no bonus set!", (object) this.ay().ToString()));
      flag = true;
    }
    if (b.c == PlayerAttribute.NumAttributes)
    {
      A_2.Add(string.Format("Reward '{0}' has no or invalid attribute set!", (object) this.ay().ToString()));
      flag = true;
    }
    return !flag;
  }

  public override bool a3(bc.a A_0, bc A_1, int A_2, g8 A_3, List<string> A_4, HashSet<string> A_5)
  {
    return true;
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.au() != PlayerAttribute.NumAttributes)
      return true;
    if (A_1 != null)
      A_1.Add("Reward " + (object) this.ay() + ": Attribute not set or invalid!");
    return false;
  }
}
