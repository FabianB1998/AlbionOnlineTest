// Decompiled with JetBrains decompiler
// Type: g6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;

public class g6
{
  public static int a = Enum.GetValues(typeof (g6.Language)).Length;
  public static int b = Enum.GetValues(typeof (g6.PlayStyle)).Length;
  public static int c = Enum.GetValues(typeof (g6.GuildSize)).Length;
  public static Dictionary<g6.GuildSize, int> d = new Dictionary<g6.GuildSize, int>();

  static g6()
  {
    foreach (string name in Enum.GetNames(typeof (g6.GuildSize)))
    {
      if (name != g6.GuildSize.ANY.ToString())
      {
        int int32 = Convert.ToInt32(name.ToUpper().Replace("S", ""));
        g6.d.Add((g6.GuildSize) Enum.Parse(typeof (g6.GuildSize), name), int32);
      }
    }
  }

  public enum Language
  {
    en,
    fr,
    it,
    de,
    es,
    ru,
    pl,
    tr,
    pt,
  }

  public enum PlayStyle
  {
    ANY,
    BEGINNER,
    NORMAL,
    EXPERT,
  }

  public enum GuildSize
  {
    ANY,
    S5,
    S20,
    S50,
    S100,
  }
}
