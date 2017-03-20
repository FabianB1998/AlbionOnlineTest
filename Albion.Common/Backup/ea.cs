// Decompiled with JetBrains decompiler
// Type: ea
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public abstract class ea : d5
{
  public override void cb(XmlElement A_0)
  {
    base.cb(A_0);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode is XmlElement)
      {
        XmlElement A_0_1 = (XmlElement) childNode;
        d5 d5 = (d5) null;
        switch (A_0_1.Name.ToLower())
        {
          case "harvestable":
            d5 = (d5) new d6();
            break;
          case "item":
            d5 = (d5) new d8();
            break;
          case "hellgate":
            d5 = (d5) new d7();
            break;
          case "lootlistreference":
            d5 = (d5) new d9();
            break;
          case "or":
            d5 = (d5) new eb();
            break;
          case "and":
            d5 = (d5) new ec();
            break;
        }
        if (d5 != null)
        {
          d5.cb(A_0_1);
          // ISSUE: reference to a compiler-generated method
          if (this.o() == null)
          {
            // ISSUE: reference to a compiler-generated method
            this.n(new List<d5>());
          }
          // ISSUE: reference to a compiler-generated method
          this.o().Add(d5);
        }
      }
    }
  }

  public void n(List<d5> A_0, float A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.o(A_1);
    // ISSUE: reference to a compiler-generated method
    this.p(A_2);
    // ISSUE: reference to a compiler-generated method
    this.n(A_0);
  }

  public a p<a>() where a : d5
  {
    return this.n<a>(this);
  }

  private a n<a>(ea A_0) where a : d5
  {
    // ISSUE: reference to a compiler-generated method
    if (this.o() == null)
      return default (a);
    // ISSUE: reference to a compiler-generated method
    foreach (d5 d5 in A_0.o())
    {
      if (d5 is a)
        return (a) d5;
      if (d5 is ea)
      {
        a a = this.n<a>((ea) d5);
        if ((object) a != null)
          return a;
      }
    }
    return default (a);
  }
}
