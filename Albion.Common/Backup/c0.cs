// Decompiled with JetBrains decompiler
// Type: c0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class c0 : bd
{
  public override bool a4(XmlElement A_0, string A_1)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "farmableitems":
            this.ba(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return base.a4(A_0, A_1);
  }

  private void ba(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ba(new List<string>());
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "farmableitem")
      {
        // ISSUE: reference to a compiler-generated method
        this.ci().Add(aim.a(A_0_1, "uniquename", (string) null));
      }
    }
  }
}
