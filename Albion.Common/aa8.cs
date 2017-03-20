// Decompiled with JetBrains decompiler
// Type: aa8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class aa8 : bd, b0.a
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.b(A_0, "defaultcostfriends", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.b(A_0, "defaultcostusers", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a(A_0, "allowsstudy", true));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a(A_0, "craftanimation", "none"));
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("craftingitemlist");
    if (elementsByTagName != null && elementsByTagName.Count > 0)
    {
      XmlNode xmlNode = elementsByTagName[0];
      // ISSUE: reference to a compiler-generated method
      this.ba(new List<b0.b>(xmlNode.ChildNodes.Count));
      // ISSUE: reference to a compiler-generated method
      this.bb(new HashSet<string>());
      foreach (XmlNode childNode in xmlNode.ChildNodes)
      {
        XmlElement A_0_1 = childNode as XmlElement;
        if (A_0_1 != null)
        {
          b0.b b = new b0.b() { a = aim.h(A_0_1, "uniquename"), b = aim.a(A_0_1, "category", "none"), c = aim.b(A_0_1, "displaygroup", 0), d = aim.b(A_0_1, "stacksize", 1) };
          // ISSUE: reference to a compiler-generated method
          this.a6().Add(b);
          // ISSUE: reference to a compiler-generated method
          if (!this.ck().Contains(b.a))
          {
            // ISSUE: reference to a compiler-generated method
            this.ck().Add(b.a);
          }
          // ISSUE: reference to a compiler-generated method
          if (this.cm() && aim.a(A_0_1, "canstudy", true))
          {
            // ISSUE: reference to a compiler-generated method
            if (this.cl() == null)
            {
              // ISSUE: reference to a compiler-generated method
              this.ba(new HashSet<string>());
            }
            // ISSUE: reference to a compiler-generated method
            if (!this.cl().Contains(b.a))
            {
              // ISSUE: reference to a compiler-generated method
              this.cl().Add(b.a);
            }
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      this.ck().TrimExcess();
      // ISSUE: reference to a compiler-generated method
      if (this.cl() != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.cl().TrimExcess();
      }
    }
    return true;
  }

  public bool ba(b9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.ck().Contains(A_0.j);
  }

  public bool bb(b9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.cl().Contains(A_0.j);
  }

  public override void a9(g8 A_0)
  {
    base.a9(A_0);
    // ISSUE: reference to a compiler-generated method
    foreach (b0.b b in this.a6())
    {
      // ISSUE: reference to a compiler-generated method
      b.e = A_0.an().hz(b.a);
    }
  }
}
