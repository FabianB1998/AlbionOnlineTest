// Decompiled with JetBrains decompiler
// Type: dk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dk : n
{
  private Dictionary<de, df> ad = new Dictionary<de, df>();
  private hi ab;

  public dk(hi A_0)
  {
    this.ab = A_0;
  }

  public df hz(de A_0)
  {
    df df;
    if (this.ad.TryGetValue(A_0, out df))
      return df;
    return (df) null;
  }

  public bool hz(de A_0, df A_1)
  {
    if (this.ad.ContainsKey(A_0))
      return false;
    this.ad.Add(A_0, A_1);
    return true;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "presets")
    {
      ab0.a("ResourceDistributionPreset.xml doesn't contain the presets-RootNode | " + A_0.Name);
      return false;
    }
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("preset"))
    {
      string str = aim.a(A_0_1, "name", string.Empty);
      List<de> deList = de.g(A_0_1);
      if (deList.Count == 0)
        ab0.a("Invalid ResourceDistribution-Preset in xml. " + str);
      foreach (de key in deList)
      {
        df df1;
        if (!this.ad.TryGetValue(key, out df1))
        {
          df df2 = new df();
          df2.d(A_0_1, this.ab);
          this.ad.Add(key, df2);
        }
        else
          ab0.a("Distribution already defined: " + str + " (" + (object) key + ") under the name " + df1.a);
      }
    }
    return true;
  }
}
