// Decompiled with JetBrains decompiler
// Type: bf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class bf
{
  public virtual bool f(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(aim.b(A_0, "silver", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.b(A_0, "gold", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "time", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "swaptransaction", true));
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("upgraderesource");
    // ISSUE: reference to a compiler-generated method
    this.f(new List<bf.a>(elementsByTagName.Count));
    foreach (XmlNode xmlNode in elementsByTagName)
    {
      XmlElement A_0_1 = xmlNode as XmlElement;
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.i().Add(new bf.a()
        {
          a = aim.h(A_0_1, "uniquename"),
          b = aim.b(A_0_1, "enchantmentlevel", 0),
          c = aim.b(A_0_1, "count", 0)
        });
      }
    }
    return true;
  }

  public int f(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (bf.a a in this.i())
    {
      if (a.a == A_0)
        return a.c;
    }
    return 0;
  }

  public class a
  {
    public string a = string.Empty;
    public int c = 1;
    public int b;
  }
}
