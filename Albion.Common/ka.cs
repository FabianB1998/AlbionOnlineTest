// Decompiled with JetBrains decompiler
// Type: ka
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData.WorldInfos;
using System;
using System.Collections.Generic;
using System.Globalization;

public class ka
{
  private static Dictionary<Biome, string[]> a = new Dictionary<Biome, string[]>() { { Biome.Steppe, new string[2]{ "Steppe", "ST" } }, { Biome.Swamp, new string[2]{ "Swamp", "SW" } }, { Biome.Highlands, new string[2]{ "Highlands", "HL" } }, { Biome.Mountains, new string[2]{ "Mountains", "MN" } }, { Biome.Forest, new string[2]{ "Forest", "FR" } }, { Biome.Default, new string[2]{ "Default", "DL" } } };
  private static Dictionary<Faction, string[]> b = new Dictionary<Faction, string[]>() { { Faction.None, new string[2]{ "None", "NON" } }, { Faction.Heretic, new string[2]{ "Heretic", "HER" } }, { Faction.Keeper, new string[2]{ "Keeper", "KPR" } }, { Faction.Morgana, new string[2]{ "Morgana", "MOR" } }, { Faction.Undead, new string[2]{ "Undead", "UND" } } };
  private static Dictionary<ClusterTypes, string[]> c = new Dictionary<ClusterTypes, string[]>() { { ClusterTypes.World, new string[2]{ "World", "WRL" } }, { ClusterTypes.Dungeon, new string[2]{ "Dungeon", "DNG" } }, { ClusterTypes.Expedition, new string[2]{ "Expedition", "EXP" } }, { ClusterTypes.Island, new string[2]{ "Island", "ISL" } }, { ClusterTypes.Hellgate, new string[2]{ "Hellgate", "HEL" } }, { ClusterTypes.City, new string[2]{ "City", "CTY" } }, { ClusterTypes.StartArea, new string[2]{ "StartArea", "STA" } }, { ClusterTypes.StartTown, new string[2]{ "StartTown", "STT" } }, { ClusterTypes.Harbor, new string[2]{ "Harbor", "HRB" } }, { ClusterTypes.HomeBase, new string[2]{ "HomeBase", "HBS" } }, { ClusterTypes.Test, new string[2]{ "Test", "TST" } }, { ClusterTypes.Debug, new string[2]{ "Debug", "DBG" } }, { ClusterTypes.PassageOverground, new string[2]{ "PassageOverground", "PGO" } }, { ClusterTypes.PassageUnderground, new string[2]{ "PassageUnderground", "PGU" } }, { ClusterTypes.CharacterSelectArea, new string[2]{ "CharacterSelectArea", "CHA" } } };
  private static Dictionary<SubBiome, string[]> d = new Dictionary<SubBiome, string[]>() { { SubBiome.Green, new string[2]{ "Green", "GRN" } }, { SubBiome.Red, new string[2]{ "Red", "RED" } }, { SubBiome.Dead, new string[2]{ "Dead", "DED" } }, { SubBiome.Invalid, new string[2]{ "None", "NON" } } };
  private static Dictionary<Continents, string[]> e = new Dictionary<Continents, string[]>() { { Continents.Royal, new string[2]{ "Royal", "ROY" } }, { Continents.Outlands, new string[2]{ "Outlands", "OUT" } } };
  private static Dictionary<ClusterQualities, string[]> f = new Dictionary<ClusterQualities, string[]>() { { ClusterQualities.High, new string[2]{ "High", "HIG" } }, { ClusterQualities.Medium, new string[2]{ "Medium", "MED" } }, { ClusterQualities.Low, new string[2]{ "Low", "LOW" } } };

  public static string g(string A_0)
  {
    int length = A_0.IndexOf("_");
    if (length >= 0)
      A_0 = A_0.Substring(0, length);
    return A_0;
  }

  public static bool b(string A_0, out ka.ClusterNameInformation A_1)
  {
    A_1 = new ka.ClusterNameInformation();
    string[] strArray = A_0.Split(new char[2]{ '_', '.' }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.Length < 5)
      return false;
    A_1.ClusterType = ka.c(strArray[1]);
    if (A_1.ClusterType == ClusterTypes.Invalid)
      return false;
    A_1.Biome = ka.f(strArray[2]);
    if (A_1.Biome == Biome.Invalid || !ka.a(strArray[3], out A_1.Tier))
      return false;
    A_1.Faction = ka.d(strArray[4]);
    A_1.SubBiome = ka.a(A_1.Tier);
    if (A_1.ClusterType == ClusterTypes.World || A_1.ClusterType == ClusterTypes.HomeBase)
    {
      if (strArray.Length < 6)
        return false;
      A_1.Continent = ka.b(strArray[5]);
      if (A_1.Continent == Continents.None)
        return false;
      if (A_1.Continent == Continents.Outlands)
      {
        if (strArray.Length < 7)
          return false;
        A_1.ClusterQuality = ka.a(strArray[6]);
        if (A_1.ClusterQuality == ClusterQualities.None)
          return false;
      }
    }
    return true;
  }

  public static bool a(string A_0, out ka.ClusterNameInformation A_1)
  {
    A_1 = new ka.ClusterNameInformation();
    string[] strArray = A_0.Split(new char[2]{ '_', '.' }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.Length < 5)
      return false;
    A_1.ClusterType = ka.c(strArray[1]);
    if (A_1.ClusterType == ClusterTypes.Invalid)
      return false;
    A_1.Faction = ka.d(strArray[2]);
    A_1.Biome = ka.f(strArray[3]);
    if (A_1.Biome == Biome.Invalid)
      return false;
    A_1.SubBiome = ka.e(strArray[4]);
    return true;
  }

  public static bool a(ClusterTypes A_0, ClusterTypes A_1)
  {
    if (A_1 == ClusterTypes.Test || A_1 == ClusterTypes.Debug)
      return true;
    if (A_1 == ClusterTypes.Expedition)
    {
      if (A_0 != ClusterTypes.Dungeon && A_0 != ClusterTypes.World)
        return A_0 == ClusterTypes.Expedition;
      return true;
    }
    if (A_0 == ClusterTypes.Dungeon)
    {
      if (A_1 != ClusterTypes.Dungeon)
        return A_1 == ClusterTypes.PassageUnderground;
      return true;
    }
    if (A_0 != ClusterTypes.World)
      return A_0 == A_1;
    if (A_1 != ClusterTypes.World && A_1 != ClusterTypes.Island && (A_1 != ClusterTypes.City && A_1 != ClusterTypes.StartArea) && (A_1 != ClusterTypes.StartTown && A_1 != ClusterTypes.HomeBase && A_1 != ClusterTypes.Harbor))
      return A_1 == ClusterTypes.PassageOverground;
    return true;
  }

  protected static a a<a>(Dictionary<a, string[]> A_0, string A_1, a A_2)
  {
    if (string.IsNullOrEmpty(A_1))
      return A_2;
    foreach (KeyValuePair<a, string[]> keyValuePair in A_0)
    {
      foreach (string str in keyValuePair.Value)
      {
        if (A_1.Equals(str, StringComparison.CurrentCultureIgnoreCase))
          return keyValuePair.Key;
      }
    }
    return A_2;
  }

  public static Biome f(string A_0)
  {
    return ka.a<Biome>(ka.a, A_0, Biome.Invalid);
  }

  public static SubBiome a(int A_0)
  {
    if (A_0 < 5)
      return SubBiome.Green;
    return A_0 > 6 ? SubBiome.Dead : SubBiome.Red;
  }

  public static SubBiome e(string A_0)
  {
    return ka.a<SubBiome>(ka.d, A_0, SubBiome.Invalid);
  }

  public static Faction d(string A_0)
  {
    return ka.a<Faction>(ka.b, A_0, Faction.None);
  }

  public static bool a(string A_0, out int A_1)
  {
    A_1 = 0;
    if (!A_0.StartsWith("T"))
      return false;
    A_0 = A_0.Replace("T", "");
    return int.TryParse(A_0, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out A_1);
  }

  public static ClusterTypes c(string A_0)
  {
    return ka.a<ClusterTypes>(ka.c, A_0, ClusterTypes.Invalid);
  }

  public static Continents b(string A_0)
  {
    return ka.a<Continents>(ka.e, A_0, Continents.None);
  }

  public static ClusterQualities a(string A_0)
  {
    return ka.a<ClusterQualities>(ka.f, A_0, ClusterQualities.None);
  }

  [Serializable]
  public class ClusterNameInformation
  {
    public Biome Biome = Biome.Invalid;
    public SubBiome SubBiome = SubBiome.Invalid;
    public ClusterTypes ClusterType = ClusterTypes.Invalid;
    public Faction Faction;
    public int Tier;
    public Continents Continent;
    public ClusterQualities ClusterQuality;

    public override string ToString()
    {
      return string.Format("[{0} T{1} {2} {3} {4}]", (object) this.Biome, (object) this.Tier, (object) this.ClusterType, (object) this.Continent, (object) this.ClusterQuality);
    }
  }
}
