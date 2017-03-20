// Decompiled with JetBrains decompiler
// Type: dn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public class dn
{
  public List<@do> a = new List<@do>();
  public List<@do> b = new List<@do>();

  public void c(XmlElement A_0)
  {
    long A_0_3 = 0;
    long A_0_4 = 0;
    HashSet<@do> doSet1 = new HashSet<@do>();
    HashSet<@do> doSet2 = new HashSet<@do>();
    foreach (XmlNode xmlNode1 in A_0_1.GetElementsByTagName("prefabs"))
    {
      XmlElement xmlElement = xmlNode1 as XmlElement;
      if (xmlElement != null)
      {
        foreach (XmlNode xmlNode2 in xmlElement.GetElementsByTagName("prefab"))
        {
          string A_0_2 = aim.a(xmlNode2 as XmlElement, "name", string.Empty);
          if (!string.IsNullOrEmpty(A_0_2))
          {
            long A_1 = Math.Abs(aim.a(xmlNode2 as XmlElement, "weight", 1L));
            @do @do = new @do(A_0_2, A_1);
            if (doSet1.Add(@do))
              A_0_3 += A_1;
            else
              ab0.a("Given Prefab ist already defined in this RD_PrefabMapping: " + @do.b);
          }
          else
            ab0.a("PrefabName in resourceprefabsmappingsxml is empty.");
        }
      }
    }
    foreach (XmlNode xmlNode1 in A_0_1.GetElementsByTagName("fillerprefabs"))
    {
      XmlElement xmlElement = xmlNode1 as XmlElement;
      if (xmlElement != null)
      {
        foreach (XmlNode xmlNode2 in xmlElement.GetElementsByTagName("prefab"))
        {
          string A_0_2 = aim.a(xmlNode2 as XmlElement, "name", string.Empty);
          if (!string.IsNullOrEmpty(A_0_2))
          {
            long A_1 = Math.Abs(aim.a(xmlNode2 as XmlElement, "weight", 1L));
            @do @do = new @do(A_0_2, A_1);
            if (doSet2.Add(@do))
              A_0_4 += A_1;
            else
              ab0.a("Given FillerPrefab ist already defined in this RD_PrefabMapping: " + @do.b);
          }
          else
            ab0.a("fillerPrefabName in resourceprefabsmappingsxml is empty.");
        }
      }
    }
    foreach (@do @do in doSet1)
      @do.f(A_0_3);
    foreach (@do @do in doSet2)
      @do.f(A_0_4);
    this.a = new List<@do>((IEnumerable<@do>) doSet1);
    this.a.Sort((Comparison<@do>) ((A_0_2, A_1) => string.Compare(A_0_2.b, A_1.b, StringComparison.CurrentCultureIgnoreCase)));
    this.b = new List<@do>((IEnumerable<@do>) doSet2);
    this.b.Sort((Comparison<@do>) ((A_0_2, A_1) => string.Compare(A_0_2.b, A_1.b, StringComparison.CurrentCultureIgnoreCase)));
  }
}
