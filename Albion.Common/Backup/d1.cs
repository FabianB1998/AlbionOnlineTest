// Decompiled with JetBrains decompiler
// Type: d1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class d1
{
  private static readonly d1 a = new d1(string.Empty, string.Empty);
  public string b;
  public string c;
  public acf d;
  public acf e;
  public float f;

  public d1(string A_0, string A_1)
  {
    this.b = A_0;
    this.c = A_1;
    this.d = acf.e();
    this.e = acf.e();
    this.f = 1f;
  }

  public d1(string A_0, string A_1, acf A_2, acf A_3, float A_4)
  {
    this.b = A_0;
    this.c = A_1;
    this.d = A_2;
    this.e = A_3;
    this.f = A_4;
  }

  [SpecialName]
  public static d1 a()
  {
    return d1.a;
  }

  public static Dictionary<string, d1> g(XmlElement A_0)
  {
    Dictionary<string, d1> dictionary = new Dictionary<string, d1>();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode is XmlElement)
      {
        XmlElement A_0_1 = (XmlElement) childNode;
        if (A_0_1.Name == "Socket")
        {
          string str = aim.a(A_0_1, "socketname", string.Empty);
          string A_1 = aim.a(A_0_1, "bonename", string.Empty);
          acf A_2 = aim.a(A_0_1, "positionOffset", acf.e());
          acf A_3 = aim.a(A_0_1, "rotationOffset", acf.e());
          float A_4 = aim.a(A_0_1, "scaling", 1f);
          if (!string.IsNullOrEmpty(str))
          {
            d1 d1 = new d1(str, A_1, A_2, A_3, A_4);
            if (!dictionary.ContainsKey(str))
              dictionary.Add(str, d1);
            else
              ab0.a("Socket duplicate Entry: " + str);
          }
        }
      }
    }
    return dictionary;
  }

  public static string a(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "SocketPreset");
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      if (xmlElementList.Count > 1)
        ab0.a("Too many SocketTypes Tags defined : " + aim.a(A_0, "uniquename", string.Empty) + " First is used.");
      string str = aim.a(xmlElementList[0], "name", string.Empty);
      if (!string.IsNullOrEmpty(str))
        return str;
    }
    return string.Empty;
  }
}
