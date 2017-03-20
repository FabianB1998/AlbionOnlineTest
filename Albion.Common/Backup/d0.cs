// Decompiled with JetBrains decompiler
// Type: d0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class d0 : bd
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.b(A_0, "furniturelimit", 1));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.b(A_0, "residentslimit", 1));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.b(A_0, "laborerslimit", 1));
    this.ba(A_0);
    return base.a4(A_0, A_1);
  }

  private void ba(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("placelaborer");
    if (elementsByTagName == null || elementsByTagName.Count <= 0)
      return;
    XmlNode xmlNode = elementsByTagName[0];
    // ISSUE: reference to a compiler-generated method
    this.ba(new List<string>(xmlNode.ChildNodes.Count));
    foreach (XmlNode childNode in xmlNode.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.cl().Add(aim.h(A_0_1, "uniquename"));
      }
    }
  }
}
