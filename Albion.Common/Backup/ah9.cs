// Decompiled with JetBrains decompiler
// Type: ah9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ah9
{
  public ah9(XmlElement A_0, aie A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(A_1);
    string g = aim.h(A_0, "id");
    // ISSUE: reference to a compiler-generated method
    this.e(new Guid(g));
    // ISSUE: reference to a compiler-generated method
    this.e(new List<ah7>());
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("connections");
    if (elementsByTagName.Count <= 0)
      return;
    foreach (XmlElement A_0_1 in ((XmlElement) elementsByTagName[0]).GetElementsByTagName("connection"))
    {
      string A_0_2 = aim.h(A_0_1, "to");
      if (!string.IsNullOrEmpty(g) && A_0_2.Contains("@"))
      {
        float A_1_1 = aim.a(A_0_1, "costmodifier", 1f);
        bool A_2 = aim.a(A_0_1, "noluggage", false);
        // ISSUE: reference to a compiler-generated method
        this.h().Add(new ah7(A_0_2, A_1_1, A_2));
      }
    }
  }

  [SpecialName]
  public string e()
  {
    // ISSUE: reference to a compiler-generated method
    if (!(this.f() == Guid.Empty))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.f().ToString() + "@" + this.g().ah();
    }
    return string.Empty;
  }

  public void e(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (ah7 ah7 in this.h())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ah7.e(A_0.ax().h6(ah7.e()));
    }
  }
}
