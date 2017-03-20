// Decompiled with JetBrains decompiler
// Type: ic
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class ic
{
  public Dictionary<string, ic.b> a = new Dictionary<string, ic.b>();
  public Dictionary<int, Dictionary<string, ic.a>> b = new Dictionary<int, Dictionary<string, ic.a>>();

  public static ic d(XmlElement A_0)
  {
    ic A_0_1 = new ic();
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      XmlElement A_0_2 = childNode1 as XmlElement;
      if (A_0_2 != null)
      {
        switch (A_0_2.Name)
        {
          case "AssetVfx":
            string key = aim.h(A_0_2, "socketname");
            if (!string.IsNullOrEmpty(key))
            {
              ic.b b = new ic.b();
              b.a = key;
              foreach (XmlNode childNode2 in childNode1.ChildNodes)
              {
                XmlElement A_0_3 = childNode2 as XmlElement;
                if (A_0_3 != null)
                {
                  switch (A_0_3.Name)
                  {
                    case "Vfx":
                      string str = aim.h(A_0_3, "prefabName");
                      hk hk = hk.a(A_0_3, hk.d());
                      if (!string.IsNullOrEmpty(str))
                      {
                        b.b.Add(new ic.a()
                        {
                          a = str,
                          b = hk
                        });
                        continue;
                      }
                      continue;
                    default:
                      continue;
                  }
                }
              }
              A_0_1.a.Add(key, b);
              continue;
            }
            continue;
          case "RareResourceFx":
            IEnumerator enumerator = A_0_2.GetElementsByTagName("RareState").GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                XmlElement current = (XmlElement) enumerator.Current;
                int num = aim.b(current, "stateid", -1);
                if (num == -1 || A_0_1.b.ContainsKey(num))
                {
                  ab0.a("RareResourceState with state id " + (object) num + " already defined (skipped)");
                }
                else
                {
                  foreach (XmlElement A_0_3 in current.GetElementsByTagName("Vfx"))
                  {
                    ic.a A_3 = new ic.a();
                    string A_2 = aim.a(A_0_3, "socket", string.Empty);
                    A_3.a = aim.a(A_0_3, "prefabName", string.Empty);
                    A_3.b = hk.a(A_0_3, hk.d());
                    ic.c(A_0_1, num, A_2, A_3);
                  }
                }
              }
              continue;
            }
            finally
            {
              IDisposable disposable = enumerator as IDisposable;
              if (disposable != null)
                disposable.Dispose();
            }
          default:
            continue;
        }
      }
    }
    return A_0_1;
  }

  private static void c(ic A_0, int A_1, string A_2, ic.a A_3)
  {
    Dictionary<string, ic.a> dictionary;
    if (A_0.b.TryGetValue(A_1, out dictionary))
      dictionary.Add(A_2, A_3);
    else
      A_0.b.Add(A_1, new Dictionary<string, ic.a>()
      {
        {
          A_2,
          A_3
        }
      });
  }

  public static string c(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "AssetVfxPreset");
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      if (xmlElementList.Count > 1)
        ab0.a("Too many AssetVfxPresets Tags defined in: " + aim.a(A_0, "uniquename", string.Empty) + " First is used.");
      string str = aim.h(xmlElementList[0], "name");
      if (!string.IsNullOrEmpty(str))
        return str;
    }
    return string.Empty;
  }

  public class a
  {
    public string a = string.Empty;
    public hk b = hk.d();
  }

  public class b
  {
    public string a = string.Empty;
    public List<ic.a> b = new List<ic.a>();
  }
}
