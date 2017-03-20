// Decompiled with JetBrains decompiler
// Type: dc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dc
{
  public readonly List<dc.a> a = new List<dc.a>();

  public bool ParseFromXmlElement(string sBehaviorName, XmlElement pXmlRootElement)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(sBehaviorName);
    // ISSUE: reference to a compiler-generated method
    this.h(ahy.l((double) aim.a(pXmlRootElement, "respawntimesecondsmin", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.g(ahy.l((double) aim.a(pXmlRootElement, "respawntimesecondsmax", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.b(pXmlRootElement, "charges", 1));
    foreach (XmlNode childNode in pXmlRootElement.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "mob")
      {
        string A_0_2 = aim.h(A_0_1, "name");
        float A_0_3 = aim.a(A_0_1, "weight", 1f);
        dc dc = this;
        // ISSUE: reference to a compiler-generated method
        double num = (double) dc.k() + (double) A_0_3;
        // ISSUE: reference to a compiler-generated method
        dc.g((float) num);
        List<dc.a> a1 = this.a;
        dc.a a2 = new dc.a();
        // ISSUE: reference to a compiler-generated method
        a2.c(A_0_2);
        // ISSUE: reference to a compiler-generated method
        a2.c(A_0_3);
        dc.a a3 = a2;
        a1.Add(a3);
      }
    }
    return true;
  }

  public class a
  {
  }
}
