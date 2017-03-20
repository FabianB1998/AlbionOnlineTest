// Decompiled with JetBrains decompiler
// Type: bh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bh
{
  private static int a;

  [SpecialName]
  public string w()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.v());
  }

  public static void o()
  {
    bh.a = 0;
  }

  public static int n(bh.Group A_0)
  {
    switch (A_0)
    {
      case bh.Group.Standard:
        return 1;
      case bh.Group.Veteran:
        return 5;
      case bh.Group.Elite:
        return 2;
      default:
        return 0;
    }
  }

  public int ac()
  {
    // ISSUE: reference to a compiler-generated method
    return bh.n(this.s());
  }

  public bool n(XmlElement A_0)
  {
    if (A_0.Name != "expeditioncategory")
      throw new AlbionException("[ExpeditionCategoryInfo] ParseFromXml: XmlTag 'expeditioncategory' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.o(bh.a++);
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.b(A_0, "tier", -1));
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a<bh.Group>(A_0, "grouptype", bh.Group.Invalid));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "minitempoweraverage", -1f));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "unlockedtoregister", false));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "locatag", "@EXPEDITION_CATEGORY_" + this.q()));
    this.o(A_0);
    this.p(A_0);
    this.q(A_0);
    return true;
  }

  protected void o(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("neededitemroles");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement xmlElement = elementsByTagName[0] as XmlElement;
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.n(new List<bh.a>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.ab().Add(new bh.a()
        {
          a = aim.a(A_0_1, "itemroleid", string.Empty),
          c = aim.b(A_0_1, "min", 0),
          d = aim.b(A_0_1, "max", 0)
        });
      }
    }
  }

  protected void p(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("rewards");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement xmlElement = elementsByTagName[0] as XmlElement;
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.p(new List<a1>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        a1 a1 = a1.au(A_0_1.Name);
        a1.az(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.x().Add(a1);
      }
    }
  }

  protected void q(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("bonusrewards");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement xmlElement = elementsByTagName[0] as XmlElement;
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.o(new List<a1>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        a1 a1 = a1.au(A_0_1.Name);
        a1.az(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.y().Add(a1);
      }
    }
  }

  public void n(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(A_0.bi().h0(this.q()));
    // ISSUE: reference to a compiler-generated method
    if (this.ab() != null)
    {
      // ISSUE: reference to a compiler-generated method
      for (int index = 0; index < this.ab().Count; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        bh.a a = this.ab()[index];
        if (a != null)
        {
          // ISSUE: reference to a compiler-generated method
          bi bi = A_0.bk().hz(a.a);
          a.b = bi;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.n(this.n());
  }

  private List<a1> n()
  {
    Dictionary<a1.RewardType, a1> A_2 = new Dictionary<a1.RewardType, a1>();
    List<a1> A_1 = new List<a1>();
    // ISSUE: reference to a compiler-generated method
    this.n(this.x(), A_1, A_2);
    // ISSUE: reference to a compiler-generated method
    this.n(this.y(), A_1, A_2);
    if (A_2.Count > 0)
    {
      A_1.AddRange((IEnumerable<a1>) A_2.Values);
      return A_1;
    }
    if (A_1.Count > 0)
      return A_1;
    return (List<a1>) null;
  }

  private void n(List<a1> A_0, List<a1> A_1, Dictionary<a1.RewardType, a1> A_2)
  {
    for (int index = 0; index < A_0.Count; ++index)
    {
      a1 A_0_1 = A_0[index];
      if (this.n(A_0_1))
      {
        a1 A_1_1 = (a1) null;
        A_2.TryGetValue(A_0_1.ay(), out A_1_1);
        if (A_1_1 != null)
        {
          if (this.o(A_0_1, A_1_1))
            this.n(A_0_1, A_1_1);
          else
            A_1.Add(A_0_1);
        }
        else
        {
          a1 a1 = A_0_1.a0();
          A_2.Add(a1.ay(), a1);
        }
      }
      else
        A_1.Add(A_0_1);
    }
  }

  private bool n(a1 A_0)
  {
    switch (A_0.ay())
    {
      case a1.RewardType.ItemReward:
        return true;
      case a1.RewardType.FamePoints:
        return true;
      case a1.RewardType.Silver:
        return true;
      case a1.RewardType.CanLeaveStartArea:
        return true;
      default:
        return false;
    }
  }

  private bool o(a1 A_0, a1 A_1)
  {
    if (A_0.ay() == a1.RewardType.ItemReward)
      return this.o((cw) A_0, (cw) A_1);
    return this.n(A_0);
  }

  private bool o(cw A_0, cw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.au() == A_1.au())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return A_0.av() == A_0.av();
    }
    return false;
  }

  private void n(a1 A_0, a1 A_1)
  {
    if (A_0.ay() != A_1.ay())
      return;
    switch (A_0.ay())
    {
      case a1.RewardType.ItemReward:
        this.n((cw) A_0, (cw) A_1);
        break;
      case a1.RewardType.FamePoints:
        this.n((cv) A_0, (cv) A_1);
        break;
      case a1.RewardType.Silver:
        this.n((a7) A_0, (a7) A_1);
        break;
    }
  }

  private void n(cw A_0, cw A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1.aw(A_1.aw() + A_0.aw());
  }

  private void n(a7 A_0, a7 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1.ax(kx.q(A_1.au(), A_0.au()));
  }

  private void n(cv A_0, cv A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1.av(kx.q(A_1.au(), A_0.au()));
  }

  public enum Group
  {
    Invalid,
    Standard,
    Veteran,
    Elite,
  }

  public class a
  {
    public string a;
    public bi b;
    public int c;
    public int d;
  }
}
