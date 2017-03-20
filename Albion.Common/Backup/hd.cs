// Decompiled with JetBrains decompiler
// Type: hd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class hd : n
{
  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "hints")
      throw new AlbionException("[HintData] LoadDataFromXml: XmlTag 'hints' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<string>());
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement xmlElement = childNode as XmlElement;
      if (xmlElement != null && xmlElement.Name == "hint")
      {
        // ISSUE: reference to a compiler-generated method
        this.hz().Add(xmlElement.InnerText.Trim());
      }
    }
    return true;
  }
}
