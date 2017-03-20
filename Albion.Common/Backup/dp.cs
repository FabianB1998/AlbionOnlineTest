// Decompiled with JetBrains decompiler
// Type: dp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dp : n
{
  public Dictionary<string, Dictionary<string, d1>> ab = new Dictionary<string, Dictionary<string, d1>>();

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "SocketInfos")
      return false;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "SocketInfo":
            string key = aim.a(A_0_1, "name", "");
            if (!string.IsNullOrEmpty(key))
            {
              if (!this.ab.ContainsKey(key))
              {
                this.ab.Add(key, d1.g(A_0_1));
                continue;
              }
              ab0.a("Duplicate Entry found in a sockets.xml: " + key + " First one is used...");
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
}
