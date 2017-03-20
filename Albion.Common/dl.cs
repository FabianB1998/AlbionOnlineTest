// Decompiled with JetBrains decompiler
// Type: dl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class dl
{
  public string a = string.Empty;
  public Dictionary<dm, dn> b = new Dictionary<dm, dn>();

  public void c(XmlElement A_0, hi A_1)
  {
    this.a = aim.a(A_0, "name", string.Empty);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        string upper = A_0_1.Name.ToUpper();
        if (A_1.h1().Contains(upper))
        {
          int A_1_1 = aim.b(A_0_1, "tier", -1);
          if (A_1_1 != -1)
          {
            dm key = new dm(upper, A_1_1);
            if (!this.b.ContainsKey(key))
            {
              dn dn = new dn();
              dn.c(A_0_1);
              this.b.Add(key, dn);
            }
            else
              ab0.a("Duplicate ResourcePrefabMapping found. " + key.ToString());
          }
        }
      }
    }
  }

  public void c()
  {
    this.b.Clear();
  }
}
