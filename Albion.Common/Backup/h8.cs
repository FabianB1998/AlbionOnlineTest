// Decompiled with JetBrains decompiler
// Type: h8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class h8 : n
{
  public Dictionary<string, h9> bq;

  public h8()
  {
    this.bq = new Dictionary<string, h9>();
  }

  public h9 hz(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (h9) null;
    h9 h9 = (h9) null;
    this.bq.TryGetValue(A_0, out h9);
    return h9;
  }

  public void hz(g8 A_0)
  {
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "worldbosses")
      throw new AlbionException("[WorldBossTypeData] LoadDataFromXml: XmlTag 'worldbosses' not found! Invalid Xml File?");
    this.bq.Clear();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        h9 h9 = new h9();
        h9.i(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.bq[h9.i()] = h9;
      }
    }
    return true;
  }
}
