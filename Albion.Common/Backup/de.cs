// Decompiled with JetBrains decompiler
// Type: de
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData.WorldInfos;
using System;
using System.Collections.Generic;
using System.Xml;

public class de : IEquatable<de>
{
  public readonly Biome a;
  public readonly int b;
  public readonly ClusterTypes c;
  public readonly it.PvpRules d;
  public readonly Continents e;
  public readonly ClusterQualities f;

  public de(ka.ClusterNameInformation A_0, it.PvpRules A_1)
  {
    this.a = A_0.Biome;
    this.b = A_0.Tier;
    this.c = A_0.ClusterType;
    this.e = A_0.Continent;
    this.f = A_0.ClusterQuality;
    this.d = A_1;
  }

  public override int GetHashCode()
  {
    return (((((17 * 7 + this.a.GetHashCode()) * 23 + this.b.GetHashCode()) * 19 + this.c.GetHashCode()) * 61 + this.d.GetHashCode()) * 83 + this.e.GetHashCode()) * 97 + this.f.GetHashCode();
  }

  public bool Equals(de other)
  {
    if (this.a == other.a && this.b == other.b && (this.c == other.c && this.d == other.d) && this.e == other.e)
      return this.f == other.f;
    return false;
  }

  public override string ToString()
  {
    return string.Format("[{0} T{1} {2} {3} {4} {5}]", (object) this.a, (object) this.b, (object) this.c, (object) this.d, (object) this.e, (object) this.f);
  }

  public static List<de> g(XmlElement A_0)
  {
    List<de> deList = new List<de>();
    char[] separator = new char[1]{ ',' };
    int num = aim.b(A_0, "tier", -1);
    if (num < 1 || num > 8)
      return deList;
    string[] strArray1 = aim.a(A_0, "biome", string.Empty).Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries);
    string[] strArray2 = aim.a(A_0, "type", "World").Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries);
    string[] strArray3 = aim.a(A_0, "pvprules", "PvpDisabled,PvpForced,PvpAllowed").Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries);
    string[] strArray4 = aim.a(A_0, "continent", "Royal,Outlands").Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries);
    string[] strArray5 = aim.a(A_0, "clusterquality", "None,High,Medium,Low").Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries);
    foreach (string A_0_1 in strArray1)
    {
      Biome biome = ka.f(A_0_1);
      if (biome != Biome.Invalid)
      {
        foreach (string A_0_2 in strArray2)
        {
          ClusterTypes clusterTypes = ka.c(A_0_2);
          if (clusterTypes != ClusterTypes.Invalid)
          {
            foreach (string A_0_3 in strArray4)
            {
              Continents continents = ka.b(A_0_3);
              if (continents != Continents.None)
              {
                foreach (string A_0_4 in strArray5)
                {
                  ClusterQualities clusterQualities = ka.a(A_0_4);
                  foreach (string str in strArray3)
                  {
                    try
                    {
                      de de = new de(new ka.ClusterNameInformation() { Biome = biome, Tier = num, ClusterType = clusterTypes, Continent = continents, ClusterQuality = clusterQualities }, (it.PvpRules) Enum.Parse(typeof (it.PvpRules), str, true));
                      deList.Add(de);
                    }
                    catch (Exception ex)
                    {
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
    return deList;
  }
}
