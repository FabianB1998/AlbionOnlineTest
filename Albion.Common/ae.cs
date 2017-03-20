// Decompiled with JetBrains decompiler
// Type: ae
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ae : s
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.GotoAgent;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "agent", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au((List<ae.a>) null);
    if (!A_0.HasChildNodes)
      return;
    this.au(A_0);
  }

  private void au(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.au(new List<ae.a>(A_0.ChildNodes.Count));
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "item")
      {
        // ISSUE: reference to a compiler-generated method
        this.cp().Add(new ae.a()
        {
          a = aim.a(A_0_1, "itemid", string.Empty),
          b = aim.b(A_0_1, "enchantmentlevel", 0),
          c = aim.b(A_0_1, "count", 1),
          d = aim.a(A_0_1, "missionitem", string.Empty)
        });
      }
    }
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    ah6 A_0_1 = (ah6) null;
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cq()))
    {
      ci.a a1;
      // ISSUE: reference to a compiler-generated method
      A_0.TryGetValue(this.cq(), out a1);
      if (a1 != null)
      {
        cs.a a2 = a1 as cs.a;
        if (a2 != null)
        {
          // ISSUE: reference to a compiler-generated method
          A_0_1 = a2.j();
        }
      }
    }
    bool A_0_2 = false;
    if (A_0_1 == null)
    {
      A_0_2 = true;
      A_0_1 = A_1;
    }
    List<ae.a> A_0_3 = this.au(A_0);
    ae ae = new ae();
    // ISSUE: reference to a compiler-generated method
    ae.au(A_0_1);
    // ISSUE: reference to a compiler-generated method
    ae.au(A_0_2);
    // ISSUE: reference to a compiler-generated method
    ae.au(A_0_3);
    return (s) ae;
  }

  public override bool @as(List<ci> A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cq()) && !s.au(this.cq(), ci.VariableType.DynamicAgent, A_0))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Agent Variable '" + this.cq() + "' not found in mission!");
      }
      flag = true;
    }
    // ISSUE: reference to a compiler-generated method
    if (this.cp() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ae.a a in this.cp())
      {
        if (!string.IsNullOrEmpty(a.d) && !s.au(a.d, ci.VariableType.MissionItem, A_0))
        {
          if (A_1 != null)
            A_1.Add("Mission " + (object) this.au() + ": missionitem '" + a.d + "' not found in variables!");
          flag = true;
        }
      }
    }
    return !flag;
  }

  private List<ae.a> au(Dictionary<string, ci.a> A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.cp() == null || this.cp().Count == 0)
    {
      // ISSUE: reference to a compiler-generated method
      return this.cp();
    }
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    foreach (ae.a a in this.cp())
    {
      if (!string.IsNullOrEmpty(a.d))
      {
        flag = true;
        break;
      }
    }
    if (!flag)
    {
      // ISSUE: reference to a compiler-generated method
      return this.cp();
    }
    // ISSUE: reference to a compiler-generated method
    List<ae.a> aList = new List<ae.a>(this.cp().Count);
    // ISSUE: reference to a compiler-generated method
    foreach (ae.a a1 in this.cp())
    {
      ae.a a2 = new ae.a() { c = a1.c, a = a1.a, b = a1.b, d = a1.d };
      aList.Add(a2);
      if (!string.IsNullOrEmpty(a2.d))
      {
        ci.a a3;
        A_0.TryGetValue(a2.d, out a3);
        if (a3 != null)
        {
          cr.a a4 = a3 as cr.a;
          // ISSUE: reference to a compiler-generated method
          if (a4 != null && a4.j() != null)
          {
            // ISSUE: reference to a compiler-generated method
            a2.a = a4.j().d;
            // ISSUE: reference to a compiler-generated method
            a2.b = a4.j().h;
            // ISSUE: reference to a compiler-generated method
            a2.c = a4.k();
          }
          else
            aList.Remove(a2);
        }
      }
    }
    return aList;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 != null && A_0.an() != null && this.cp() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ae.a a in this.cp())
      {
        if (string.IsNullOrEmpty(a.a))
        {
          if (string.IsNullOrEmpty(a.d))
          {
            if (A_1 != null)
              A_1.Add("Mission " + (object) this.au() + ": itemid and missionitem is empty!");
            flag = true;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          if (A_0.an().hz(a.a, a.b) == null)
          {
            if (A_1 != null)
              A_1.Add("Mission " + (object) this.au() + ": ItemId '" + a.a + "' EnchantmentLevel: " + (object) a.b + " does not exists!");
            flag = true;
          }
        }
      }
    }
    return !flag;
  }

  public class a
  {
    public string a;
    public int b;
    public int c;
    public string d;
  }
}
