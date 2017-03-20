// Decompiled with JetBrains decompiler
// Type: cy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class cy : n
{
  public Dictionary<string, cz> u = new Dictionary<string, cz>();

  protected override bool aq(XmlElement A_0)
  {
    return this.hz(A_0, false);
  }

  protected bool hz(XmlElement A_0, bool A_1)
  {
    if (A_0.Name != "SpellAnimationMappingInfos")
      return false;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "MappingInfo":
            string key = aim.a(A_0_1, "uniquename", "");
            if (!string.IsNullOrEmpty(key))
            {
              if (!this.u.ContainsKey(key))
              {
                this.u.Add(key, cz.e(A_0_1));
                continue;
              }
              if (A_1)
              {
                this.u[key] = cz.e(A_0_1);
                continue;
              }
              ab0.a("Duplicate Entry found in a SpellAnimMappings.xml: " + key + " First one is used...");
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  protected override bool bu(XmlElement A_0)
  {
    return this.hz(A_0, true);
  }
}
