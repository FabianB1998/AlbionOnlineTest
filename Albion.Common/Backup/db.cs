// Decompiled with JetBrains decompiler
// Type: db
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class db : n
{
  private Dictionary<string, Dictionary<int, dc>> aa = new Dictionary<string, Dictionary<int, dc>>();

  [SpecialName]
  public IEnumerable<string> hz()
  {
    return (IEnumerable<string>) this.aa.Keys;
  }

  public dc hz(string A_0, int A_1)
  {
    Dictionary<int, dc> dictionary;
    dc dc;
    if (this.aa.TryGetValue(A_0, out dictionary) && dictionary != null && (dictionary.TryGetValue(A_1, out dc) || dictionary.TryGetValue(0, out dc)))
      return dc;
    return (dc) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "randomspawnbehaviors")
      throw new AlbionException("[RandomSpawnBehaviorData] ParseDataFromXml: XmlTag 'randomspawnbehaviors' not found! Invalid Xml File?");
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode1 as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "spawnbehavior")
      {
        string sBehaviorName = aim.a(A_0_1, "name", "");
        Dictionary<int, dc> dictionary = new Dictionary<int, dc>();
        this.aa[sBehaviorName] = dictionary;
        foreach (XmlNode childNode2 in A_0_1.ChildNodes)
        {
          XmlElement xmlElement = childNode2 as XmlElement;
          if (xmlElement != null)
          {
            int index;
            if (xmlElement.Name == "clustertype")
              index = aim.b(xmlElement, "tier", 1);
            else if (xmlElement.Name == "default")
              index = 0;
            else
              continue;
            dc dc = new dc();
            if (dc.ParseFromXmlElement(sBehaviorName, xmlElement))
              dictionary[index] = dc;
          }
        }
      }
    }
    return true;
  }
}
