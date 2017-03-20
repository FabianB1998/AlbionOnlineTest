﻿// Decompiled with JetBrains decompiler
// Type: ba
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ba : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.ItemWearBonus;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(new string[1]);
    // ISSUE: reference to a compiler-generated method
    this.au()[0] = aim.a(A_0, "item", string.Empty);
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
    this.au(b.f);
    // ISSUE: reference to a compiler-generated method
    if (this.au() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.au().Length > 0;
    }
    return false;
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
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    if (A_0 != null && A_0.an() != null)
    {
      // ISSUE: reference to a compiler-generated method
      for (int index = 0; index < this.au().Length; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        string A_0_1 = this.au()[index];
        // ISSUE: reference to a compiler-generated method
        b8 b8 = A_0.an().hz(A_0_1);
        // ISSUE: reference to a compiler-generated method
        if (b8 == null || !(b8.f() is en))
        {
          if (A_1 != null)
            A_1.Add("Reward " + (object) this.ay() + ": ItemId '" + A_0_1 + "' does not exist or is no equipmentitem!");
          flag = true;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.av() != PlayerAttribute.NumAttributes)
      return !flag;
    if (A_1 != null)
      A_1.Add("Reward " + (object) this.ay() + ": Attribute not set or invalid!");
    return false;
  }
}
