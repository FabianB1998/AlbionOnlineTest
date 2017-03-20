// Decompiled with JetBrains decompiler
// Type: h4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Xml;

public class h4
{
  public h4()
  {
    // ISSUE: reference to a compiler-generated method
    this.f(new il());
    // ISSUE: reference to a compiler-generated method
    this.e(new il());
    // ISSUE: reference to a compiler-generated method
    this.d(new il());
  }

  public bool d(XmlElement A_0)
  {
    if (A_0.Name != "UserTaxValues")
      throw new AlbionException("[UserTaxInfo] LoadDataFromXml: XmlTag 'UserTaxValues' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Guild":
            // ISSUE: reference to a compiler-generated method
            if (!this.d().d(A_0_1))
              return false;
            continue;
          case "Cluster":
            // ISSUE: reference to a compiler-generated method
            if (!this.e().d(A_0_1))
              return false;
            continue;
          case "City":
            // ISSUE: reference to a compiler-generated method
            if (!this.f().d(A_0_1))
              return false;
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }
}
