// Decompiled with JetBrains decompiler
// Type: cw
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cw : a1
{
  public string[] ak;
  public string[] al;

  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.ItemReward;
  }

  [SpecialName]
  public override bool bt()
  {
    return true;
  }

  public override void az(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "itemid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.av(aim.b(A_0, "enchantmentlevel", 0));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "count", 0));
    this.ak = this.au(A_0, "activespell", 3).ToArray();
    this.al = this.au(A_0, "passivespell", 2).ToArray();
  }

  public void aw(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(A_0);
  }

  private List<string> au(XmlElement A_0, string A_1, int A_2)
  {
    List<string> stringList = new List<string>();
    for (int index = 0; index < A_2; ++index)
    {
      string str = aim.a(A_0, A_1 + (object) (index + 1), string.Empty);
      if (!string.IsNullOrEmpty(str))
        stringList.Add(str);
    }
    return stringList;
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    if (A_0 != null && A_0.an() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      b8 b8 = A_0.an().hz(this.au());
      if (b8 == null)
      {
        if (A_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          A_1.Add("Reward " + (object) this.ay() + ": ItemId '" + this.au() + "' does not exist!");
        }
        flag = true;
      }
      else
      {
        for (int index = 0; index < 4; ++index)
        {
          en en = b8.e()[index] as en;
          if (en != null)
          {
            // ISSUE: reference to a compiler-generated method
            if (!this.au<gs>(this.au(), this.ak, en.bt, en.cb, A_0, true, ref A_1))
              flag = true;
            // ISSUE: reference to a compiler-generated method
            if (!this.au<aba>(this.au(), this.al, en.bu, en.cc, A_0, false, ref A_1))
              flag = true;
          }
        }
      }
    }
    return !flag;
  }
}
