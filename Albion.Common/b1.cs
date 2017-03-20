// Decompiled with JetBrains decompiler
// Type: b1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class b1 : bd, b0.a, bz.a
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.a(A_0, "craftanimation", "none"));
    XmlNodeList elementsByTagName1 = A_0.GetElementsByTagName("craftingitemlist");
    if (elementsByTagName1 != null && elementsByTagName1.Count > 0)
    {
      XmlNode xmlNode = elementsByTagName1[0];
      // ISSUE: reference to a compiler-generated method
      this.ba(new List<b0.b>(xmlNode.ChildNodes.Count));
      // ISSUE: reference to a compiler-generated method
      this.ba(new HashSet<string>());
      foreach (XmlNode childNode in xmlNode.ChildNodes)
      {
        XmlElement A_0_1 = childNode as XmlElement;
        if (A_0_1 != null)
        {
          b0.b b = new b0.b() { a = aim.h(A_0_1, "uniquename"), b = aim.a(A_0_1, "category", "none"), c = aim.b(A_0_1, "displaygroup", 0), d = aim.b(A_0_1, "stacksize", 1) };
          // ISSUE: reference to a compiler-generated method
          this.a6().Add(b);
          // ISSUE: reference to a compiler-generated method
          if (!this.ci().Contains(b.a))
          {
            // ISSUE: reference to a compiler-generated method
            this.ci().Add(b.a);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      this.ci().TrimExcess();
    }
    XmlNodeList elementsByTagName2 = A_0.GetElementsByTagName("meldingcombinations");
    if (elementsByTagName2 != null && elementsByTagName2.Count > 0)
    {
      XmlNode xmlNode = elementsByTagName2[0];
      // ISSUE: reference to a compiler-generated method
      this.ba(new Dictionary<string, bz.b>(xmlNode.ChildNodes.Count));
      foreach (XmlNode childNode1 in xmlNode.ChildNodes)
      {
        XmlElement A_0_1 = childNode1 as XmlElement;
        if (A_0_1 != null)
        {
          bz.b b = new bz.b() { a = aim.b(A_0_1, "tier", -1), b = aim.b(A_0_1, "powerlevel", -1), c = aim.a<bz.Aspect>(A_0_1, "aspect", bz.Aspect.Invalid), e = aim.b(A_0_1, "time", -1), d = aim.a(A_0_1, "lootlist", string.Empty), f = (List<bz.b.a>) null };
          foreach (object childNode2 in A_0_1.ChildNodes)
          {
            XmlElement A_0_2 = childNode2 as XmlElement;
            if (A_0_2 != null && A_0_2.Name == "neededitem")
            {
              bz.b.a a = new bz.b.a() { a = aim.a(A_0_2, "uniquename", (string) null), c = aim.b(A_0_2, "quantity", 0) };
              if (b.f == null)
                b.f = new List<bz.b.a>();
              b.f.Add(a);
            }
          }
          // ISSUE: reference to a compiler-generated method
          this.a8().Add(bz.a(b.a, b.b, b.c), b);
        }
      }
    }
    return true;
  }

  public bool ba(b9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ci() == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.ci().Contains(A_0.i.d());
  }

  public override void a9(g8 A_0)
  {
    base.a9(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.ci() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (b0.b b in this.a6())
      {
        // ISSUE: reference to a compiler-generated method
        b.e = A_0.an().hz(b.a);
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.a8() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (bz.b b in this.a8().Values)
    {
      if (b.f != null)
      {
        foreach (bz.b.a a in b.f)
        {
          // ISSUE: reference to a compiler-generated method
          a.b = A_0.an().hz(a.a);
        }
      }
    }
  }
}
