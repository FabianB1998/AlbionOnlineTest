// Decompiled with JetBrains decompiler
// Type: cz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class cz
{
  public string a = "";
  public string b = "";
  public Dictionary<string, string> c = new Dictionary<string, string>();

  public static cz e(XmlElement A_0)
  {
    cz cz = new cz();
    XmlNodeList xmlNodeList1 = A_0.SelectNodes("Default");
    XmlNodeList xmlNodeList2 = A_0.SelectNodes("MobDefault");
    XmlNodeList xmlNodeList3 = A_0.SelectNodes("Weapon");
    if (xmlNodeList1.Count > 1 || xmlNodeList2.Count > 1)
      ab0.a("Too many 'Default' Nodes defined in SpellAnimMappings.xml under " + aim.a(A_0, "uniquename", "NoUniqueNameDefined") + ". First is used.");
    IEnumerator enumerator1 = xmlNodeList1.GetEnumerator();
    try
    {
      if (enumerator1.MoveNext())
      {
        XmlElement current = (XmlElement) enumerator1.Current;
        cz.a = aim.a(current, "castanimation", "");
      }
    }
    finally
    {
      IDisposable disposable = enumerator1 as IDisposable;
      if (disposable != null)
        disposable.Dispose();
    }
    IEnumerator enumerator2 = xmlNodeList1.GetEnumerator();
    try
    {
      if (enumerator2.MoveNext())
      {
        XmlElement current = (XmlElement) enumerator2.Current;
        cz.a = aim.a(current, "castanimation", "");
      }
    }
    finally
    {
      IDisposable disposable = enumerator2 as IDisposable;
      if (disposable != null)
        disposable.Dispose();
    }
    foreach (XmlElement A_0_1 in xmlNodeList3)
    {
      string key = aim.a(A_0_1, "weaponanimationtype", "");
      string str = aim.a(A_0_1, "castanimation", "");
      if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(str))
        cz.c.Add(key, str);
    }
    return cz;
  }

  public static string d(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("AnimationMappingInfo");
    if (elementsByTagName.Count > 0)
    {
      if (elementsByTagName.Count > 1)
        ab0.a("Too many AnimMappingInfos defined in spells.xml: " + aim.a(A_0, "uniquename", A_0.Name) + " First is used.");
      string str = aim.a(elementsByTagName[0] as XmlElement, "name", "");
      if (!string.IsNullOrEmpty(str))
        return str;
    }
    return string.Empty;
  }
}
