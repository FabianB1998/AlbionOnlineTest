// Decompiled with JetBrains decompiler
// Type: eh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class eh : n
{
  public string ar = string.Empty;

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "clustertexts")
      throw new AlbionException("[ClusterTextData] LoadDataFromXml: XmlTag 'clustertexts' not found! Invalid Xml File?");
    this.ar = aim.a(A_0, "defaultimage", string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.hz(new Dictionary<string, ei>());
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<ei>());
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "clustertext")
      {
        ei ei = new ei();
        // ISSUE: reference to a compiler-generated method
        ei.g(aim.a(A_0_1, "tag", string.Empty));
        // ISSUE: reference to a compiler-generated method
        ei.g(aim.a(A_0_1, "showrandomly", false));
        // ISSUE: reference to a compiler-generated method
        ei.h(aim.a(A_0_1, "image", string.Empty));
        // ISSUE: reference to a compiler-generated method
        ei.i(aim.a(A_0_1, "locatag", (string) null));
        // ISSUE: reference to a compiler-generated method
        ei.j(A_0_1.InnerText.Trim());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.hz().Add(ei.g(), ei);
        // ISSUE: reference to a compiler-generated method
        if (ei.h())
        {
          // ISSUE: reference to a compiler-generated method
          this.h0().Add(ei);
        }
      }
    }
    return true;
  }
}
