// Decompiled with JetBrains decompiler
// Type: dd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData.WorldInfos;
using System;
using System.Collections.Generic;
using System.Xml;

public class dd : IEquatable<dd>
{
  public readonly Biome a;
  public readonly int b;

  public dd(ka.ClusterNameInformation A_0)
  {
    this.a = A_0.Biome;
    this.b = A_0.Tier;
  }

  public override int GetHashCode()
  {
    return (17 * 7 + this.a.GetHashCode()) * 23 + this.b.GetHashCode();
  }

  public bool Equals(dd other)
  {
    if (this.a == other.a)
      return this.b == other.b;
    return false;
  }

  public override string ToString()
  {
    return string.Format("[{0} T{1}]", (object) this.a, (object) this.b);
  }

  public static List<dd> c(XmlElement A_0)
  {
    List<dd> ddList = new List<dd>();
    char[] separator = new char[1]{ ',' };
    int num = aim.b(A_0, "tier", -1);
    if (num < 1 || num > 8)
      return ddList;
    foreach (string A_0_1 in aim.a(A_0, "biome", string.Empty).Replace(" ", "").Split(separator, StringSplitOptions.RemoveEmptyEntries))
    {
      Biome biome = ka.f(A_0_1);
      if (biome != Biome.Invalid)
      {
        try
        {
          dd dd = new dd(new ka.ClusterNameInformation() { Biome = biome, Tier = num });
          ddList.Add(dd);
        }
        catch (Exception ex)
        {
        }
      }
    }
    return ddList;
  }
}
