// Decompiled with JetBrains decompiler
// Type: h6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class h6 : n
{
  public Dictionary<string, h7> bp;

  public h6()
  {
    this.bp = new Dictionary<string, h7>();
  }

  public h7 hz(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (h7) null;
    h7 h7 = (h7) null;
    this.bp.TryGetValue(A_0, out h7);
    return h7;
  }

  public void hz(g8 A_0)
  {
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "treasures")
      throw new AlbionException("[TreasureChestData] LoadDataFromXml: XmlTag 'treasures' not found! Invalid Xml File?");
    this.bp.Clear();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        h7 h7 = new h7();
        h7.m(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.bp[h7.m()] = h7;
      }
    }
    return true;
  }
}
