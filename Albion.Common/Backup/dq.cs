// Decompiled with JetBrains decompiler
// Type: dq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dq : n
{
  public Dictionary<string, bv> ad = new Dictionary<string, bv>();
  public Dictionary<string, bw> ae = new Dictionary<string, bw>();

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "AudioInfos")
      return false;
    bt.a();
    bx.a();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "WwiseSwitchInfo":
            string key1 = aim.a(A_0_1, "name", "");
            if (!string.IsNullOrEmpty(key1))
            {
              if (!this.ad.ContainsKey(key1))
              {
                this.ad.Add(key1, bv.i(A_0_1));
                continue;
              }
              ab0.a("Duplicate Entry found in a audio.xml: " + key1 + " First one is used...");
              continue;
            }
            continue;
          case "WwiseGlobalEnvironmentEffect":
            bt.a(A_0_1);
            continue;
          case "WwiseEventInfo":
            string key2 = aim.a(A_0_1, "name", "");
            if (!string.IsNullOrEmpty(key2))
            {
              if (!this.ae.ContainsKey(key2))
              {
                this.ae.Add(key2, bw.c(A_0_1));
                continue;
              }
              ab0.a("Duplicate Entry found in a audio.xml: " + key2 + " First one is used...");
              continue;
            }
            continue;
          case "WwiseSpellEventDefaults":
            bx.a(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }
}
