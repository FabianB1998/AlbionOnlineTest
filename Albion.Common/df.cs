// Decompiled with JetBrains decompiler
// Type: df
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.ResourceDistribution;
using System;
using System.Collections.Generic;
using System.Xml;

public class df
{
  public string a = string.Empty;
  public Dictionary<ResourceNodeTypes, Dictionary<string, int>> b = new Dictionary<ResourceNodeTypes, Dictionary<string, int>>();
  public SortedDictionary<dh, dg> c = new SortedDictionary<dh, dg>((IComparer<dh>) new di());

  public void d(XmlElement A_0, hi A_1)
  {
    this.a = aim.a(A_0, "name", string.Empty);
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      ResourceNodeTypes A_0_1 = aab.b((childNode1 as XmlElement).Name);
      if (A_0_1 != ResourceNodeTypes.Invalid)
      {
        foreach (XmlNode childNode2 in childNode1.ChildNodes)
        {
          XmlElement A_0_2 = childNode2 as XmlElement;
          if (A_0_2 != null)
          {
            string upper = A_0_2.Name.ToUpper();
            if (A_1.h1().Contains(upper))
            {
              int A_2 = aim.b(A_0_2, "tier", -1);
              if (A_2 != -1)
              {
                dh dh = new dh(A_0_1, upper, A_2);
                if (!this.c.ContainsKey(dh))
                {
                  string A_0_3 = aim.a(A_0_2, "amount", string.Empty);
                  dg A_1_1;
                  if (!string.IsNullOrEmpty(A_0_3) && dg.c(A_0_3, out A_1_1))
                  {
                    if (A_1_1.a != 0 || A_1_1.b != 0)
                      this.d(dh, A_1_1);
                  }
                  else
                    ab0.a("Unable to Parse amount in " + dh.ToString());
                }
                else
                  ab0.a("Duplicate DistributionPreset found. " + dh.ToString());
              }
            }
          }
        }
      }
    }
  }

  public void d()
  {
    this.b.Clear();
    this.c.Clear();
  }

  public void d(dh A_0, dg A_1)
  {
    this.d(A_0.a, A_0.b, A_1.a + A_1.b);
    this.c.Add(A_0, A_1);
  }

  private void d(ResourceNodeTypes A_0, string A_1, int A_2)
  {
    Dictionary<string, int> dictionary1;
    if (this.b.TryGetValue(A_0, out dictionary1))
    {
      if (dictionary1.ContainsKey(A_1))
      {
        Dictionary<string, int> dictionary2;
        string index;
        (dictionary2 = dictionary1)[index = A_1] = dictionary2[index] + A_2;
      }
      else
        dictionary1.Add(A_1, A_2);
    }
    else
      this.b.Add(A_0, new Dictionary<string, int>()
      {
        {
          A_1,
          A_2
        }
      });
  }

  public override string ToString()
  {
    string str1 = string.Empty;
    dh dh = (dh) null;
    foreach (KeyValuePair<dh, dg> keyValuePair in this.c)
    {
      if (dh == null || keyValuePair.Key.a != dh.a || !keyValuePair.Key.b.Equals(dh.b))
      {
        str1 += string.Format("{0, -10}|{1, -15}| [Total: {2,-3}]", (object) keyValuePair.Key.a, (object) keyValuePair.Key.b, (object) this.b[keyValuePair.Key.a][keyValuePair.Key.b]);
        str1 += Environment.NewLine;
        dh = keyValuePair.Key;
      }
      string str2 = string.Format("{0, -10}|{1, -15}|{2, -3}|{3, 3}|{4, 3}", (object) keyValuePair.Key.a, (object) keyValuePair.Key.b, (object) keyValuePair.Key.c, (object) keyValuePair.Value.a, (object) keyValuePair.Value.b);
      str1 = str1 + str2 + Environment.NewLine;
    }
    return str1;
  }
}
