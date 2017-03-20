// Decompiled with JetBrains decompiler
// Type: dj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dj : n
{
  public Dictionary<dd, dl> ac = new Dictionary<dd, dl>();
  private hi ab;

  public dj(hi A_0)
  {
    this.ab = A_0;
  }

  public dl hz(dd A_0)
  {
    dl dl;
    if (this.ac.TryGetValue(A_0, out dl))
      return dl;
    return (dl) null;
  }

  public bool hz(dd A_0, dl A_1)
  {
    if (this.ac.ContainsKey(A_0))
      return false;
    this.ac.Add(A_0, A_1);
    return true;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "mappings")
    {
      ab0.a("resourceprefabmappings.xml doesn't contain the mappings-RootNode | " + A_0.Name);
      return false;
    }
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("mapping"))
    {
      string str = aim.a(A_0_1, "name", string.Empty);
      List<dd> ddList = dd.c(A_0_1);
      if (ddList.Count == 0)
        ab0.a("Invalid ResourceDistribution-Preset in xml. " + str);
      foreach (dd key in ddList)
      {
        dl dl1;
        if (!this.ac.TryGetValue(key, out dl1))
        {
          dl dl2 = new dl();
          dl2.c(A_0_1, this.ab);
          this.ac.Add(key, dl2);
        }
        else
          ab0.a("Prefab Mapping was already defined " + str + " (" + (object) key + ") und the name " + dl1.a);
      }
    }
    return true;
  }
}
