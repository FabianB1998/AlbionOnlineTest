// Decompiled with JetBrains decompiler
// Type: bt
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData.WorldInfos;
using System;
using System.Collections.Generic;
using System.Xml;

public class bt
{
  private static Dictionary<ulong, bu> b = new Dictionary<ulong, bu>();
  public static bu a;

  public static void a()
  {
    bt.b.Clear();
  }

  public static bool a(string A_0)
  {
    ka.ClusterNameInformation A_1;
    if (!ka.b(A_0, out A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    bt.e(new bu(bu.a.b, "Environment", A_1.ClusterType.ToString()));
    // ISSUE: reference to a compiler-generated method
    bt.d(new bu(bu.a.b, "Music", A_1.ClusterType.ToString()));
    // ISSUE: reference to a compiler-generated method
    bt.b(new bu(bu.a.b, "Biom", A_1.Biome.ToString()));
    // ISSUE: reference to a compiler-generated method
    bt.a(new bu(bu.a.b, "Sub_Biom", A_1.SubBiome.ToString()));
    if (A_1.Faction != Faction.None)
    {
      // ISSUE: reference to a compiler-generated method
      bt.c(new bu(bu.a.b, "Env_Faction", A_1.Faction.ToString()));
    }
    bt.a(A_1, out bt.a);
    return true;
  }

  public static void a(XmlElement A_0)
  {
    XmlElement A_0_1 = A_0;
    if (A_0_1 == null || !(A_0_1.Name == "WwiseGlobalEnvironmentEffect"))
      return;
    bu bu = new bu(bu.a.b, "GlobalEnvironmentEffect", aim.a(A_0_1, "name", ""));
    ka.ClusterNameInformation A_0_2 = new ka.ClusterNameInformation();
    XmlNodeList elementsByTagName1 = A_0_1.GetElementsByTagName("ClusterTypes");
    if (elementsByTagName1.Count == 1)
    {
      string A_0_3 = aim.a(elementsByTagName1[0] as XmlElement, "name", "");
      A_0_2.ClusterType = ka.c(A_0_3);
    }
    XmlNodeList elementsByTagName2 = A_0_1.GetElementsByTagName("Biom");
    if (elementsByTagName2.Count == 1)
    {
      string A_0_3 = aim.a(elementsByTagName2[0] as XmlElement, "name", "");
      A_0_2.Biome = ka.f(A_0_3);
    }
    XmlNodeList elementsByTagName3 = A_0_1.GetElementsByTagName("SubBiom");
    if (elementsByTagName3.Count == 1)
    {
      string str = aim.a(elementsByTagName3[0] as XmlElement, "name", "");
      A_0_2.SubBiome = (SubBiome) Enum.Parse(typeof (SubBiome), str);
    }
    XmlNodeList elementsByTagName4 = A_0_1.GetElementsByTagName("MobFaction");
    if (elementsByTagName4.Count == 1)
    {
      string A_0_3 = aim.a(elementsByTagName4[0] as XmlElement, "name", "");
      A_0_2.Faction = ka.d(A_0_3);
    }
    ulong key = bt.a(A_0_2);
    bt.b.Add(key, bu);
  }

  public static bool a(ka.ClusterNameInformation A_0, out bu A_1)
  {
    ulong num = bt.a(A_0);
    ulong index = 0;
    foreach (KeyValuePair<ulong, bu> keyValuePair in bt.b)
    {
      ulong key = keyValuePair.Key;
      if ((long) (num & key) == (long) key && key > index)
        index = key;
    }
    if ((long) index != 0L)
    {
      A_1 = bt.b[index];
      return true;
    }
    A_1 = (bu) null;
    return false;
  }

  private static ulong a(ka.ClusterNameInformation A_0)
  {
    ulong num1 = 0;
    int num2 = 0;
    if (A_0.ClusterType > ClusterTypes.Invalid)
      num1 |= (ulong) (1U << (int) (A_0.ClusterType & (ClusterTypes) 31));
    int num3 = num2 + 18;
    if (A_0.Biome > Biome.Invalid)
      num1 |= (ulong) (1U << (int) (A_0.Biome + num3 & (Biome) 31));
    int num4 = num3 + 6;
    if (A_0.SubBiome > SubBiome.Invalid)
      num1 |= (ulong) (1U << (int) (A_0.SubBiome + num4 & (SubBiome) 31));
    int num5 = num4 + 3;
    return num1 | (ulong) (1U << (int) (A_0.Faction + num5 & (Faction) 31));
  }
}
