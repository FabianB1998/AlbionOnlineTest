// Decompiled with JetBrains decompiler
// Type: hh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

public class hh
{
  private Hashtable a = new Hashtable();
  private static int b;

  public hh(string A_0, string A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(hh.b++);
    // ISSUE: reference to a compiler-generated method
    this.f(A_0);
    // ISSUE: reference to a compiler-generated method
    this.e(A_1);
    // ISSUE: reference to a compiler-generated method
    this.e(new hh.b[8]);
  }

  public static void e()
  {
    hh.b = 0;
  }

  public bool e(int A_0, int A_1, int A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 < 1 || A_0 > this.i().Length || this.i()[A_0 - 1] == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!this.i()[A_0 - 1].ak())
      return true;
    if (A_1 >= A_0 || A_1 + 1 >= A_0 && A_2 == 0)
      return (double) this.g(A_0, A_1) >= 0.0;
    return false;
  }

  public long e(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    hh.b b = this.i()[A_0];
    // ISSUE: reference to a compiler-generated method
    if (A_1 >= b.a2().Length)
      return 0;
    // ISSUE: reference to a compiler-generated method
    int num1 = Math.Min(A_1, b.ah());
    int num2 = A_1 - num1;
    long num3 = 0;
    for (int index = A_1; index > num2; --index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      num3 += (long) b.a2()[index].f();
    }
    return num3;
  }

  public long f(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    hh.b b = this.i()[A_0];
    // ISSUE: reference to a compiler-generated method
    if (A_1 >= b.a2().Length)
      return 0;
    long num = 0;
    for (int index = A_1; index > 0; --index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      num += (long) b.a2()[index].f();
    }
    return num;
  }

  public float g(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 < 1 || A_0 > this.i().Length || this.i()[A_0 - 1] == null)
      return -1f;
    float num1 = 1f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!this.i()[A_0 - 1].al())
    {
      if (A_1 == 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.i()[A_0 - 1].ak())
          return -1f;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        num1 = this.i()[A_0 - 1].am();
      }
      else
      {
        int num2 = A_1 - A_0;
        if (!this.a.ContainsKey((object) num2))
          return -1f;
        num1 = (float) this.a[(object) num2];
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.i()[A_0 - 1].aj() * num1;
  }

  private static ec e(XmlElement A_0, out float A_1)
  {
    ec ec = (ec) null;
    A_1 = 0.0f;
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("Loot");
    if (elementsByTagName.Count > 0)
    {
      XmlElement A_0_1 = elementsByTagName[0] as XmlElement;
      if (A_0_1 != null)
      {
        ec = new ec();
        ec.cb(A_0_1);
        A_1 = aim.a(A_0_1, "itemdropquality", A_1);
      }
    }
    return ec;
  }

  public void e(XmlElement A_0)
  {
    foreach (XmlElement xmlElement in A_0.GetElementsByTagName("ToolModifier"))
    {
      foreach (XmlElement A_0_1 in xmlElement.GetElementsByTagName("Modifier"))
        this.a.Add((object) aim.b(A_0_1, "tierdifference", 0), (object) aim.a(A_0_1, "timefactor", 1f));
    }
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Tier"))
    {
      int A_1_1 = aim.b(A_0_1, "tier", 0);
      XmlNodeList elementsByTagName1 = A_0_1.GetElementsByTagName("Charge");
      List<hh.a> aList1 = new List<hh.a>(elementsByTagName1.Count);
      foreach (XmlElement A_0_2 in elementsByTagName1)
      {
        string s = aim.a(A_0_2, "level", "0");
        int num1;
        int num2;
        if (s.Contains("-"))
        {
          string[] strArray = s.Split(new char[1]{ '-' }, StringSplitOptions.RemoveEmptyEntries);
          num1 = int.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
          num2 = int.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        }
        else
          num1 = num2 = int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
        while (aList1.Count < num2 + 1)
          aList1.Add((hh.a) null);
        hh.a a = new hh.a(aim.a(A_0_2, "yield", 0.0f), aim.a(A_0_2, "respawnfactormin", 1f), aim.a(A_0_2, "respawnfactormax", 1f), aim.b(A_0_2, "gfxstate", 0), aim.b(A_0_2, "respawncharges", 1));
        for (int index = num1; index <= num2; ++index)
          aList1[index] = a;
      }
      XmlNodeList elementsByTagName2 = A_0_1.GetElementsByTagName("RareState");
      List<hh.b.a> aList2 = new List<hh.b.a>(elementsByTagName2.Count);
      foreach (XmlElement A_0_2 in elementsByTagName2)
      {
        if (A_0_2 != null)
        {
          aim.b(A_0_2, "state", int.MinValue);
          string A_0_3 = aim.a(A_0_2, "item", (string) null);
          float A_1_2;
          ec A_1_3 = hh.e(A_0_2, out A_1_2);
          aList2.Add(new hh.b.a(A_0_3, A_1_3, A_1_2));
        }
      }
      float A_1_4;
      ec A_18 = hh.e(A_0_1, out A_1_4);
      GuildRole? A_17;
      try
      {
        string str = aim.a(A_0_1, "territoryrankcontraint", "");
        A_17 = !string.IsNullOrEmpty(str) ? new GuildRole?((GuildRole) Enum.Parse(typeof (GuildRole), str, true)) : new GuildRole?();
      }
      catch (Exception ex)
      {
        A_17 = new GuildRole?();
      }
      string str1 = aim.a(A_0_1, "tile", (string) null);
      string A_10 = aim.a(A_0_1, "tilepremium", str1);
      // ISSUE: reference to a compiler-generated method
      hh.b b = new hh.b(this.f(), A_1_1, aim.a(A_0_1, "item", "T1_ROCK"), aim.b(A_0_1, "maxchargesperharvest", 1), aim.a(A_0_1, "respawntimeseconds", 30f), aim.a(A_0_1, "harvesttimeseconds", 30f), aim.a(A_0_1, "requirestool", true), aim.a(A_0_1, "ignoretools", false), aim.a(A_0_1, "notooltimefactor", 1f), str1, A_10, aim.a(A_0_1, "decaytimeseconds", 0.0f), aim.a(A_0_1, "decaytimewhenexhaustedseconds", 0.0f), aList1.ToArray(), aim.b(A_0_1, "startcharges", 1), aList2.ToArray(), aim.a(A_0_1, "isscaled", true), A_17, A_18, A_1_4);
      // ISSUE: reference to a compiler-generated method
      this.i()[A_1_1 - 1] = b;
    }
  }

  public class a
  {
    public a(float A_0, float A_1, float A_2, int A_3, int A_4)
    {
      // ISSUE: reference to a compiler-generated method
      this.h(A_0);
      // ISSUE: reference to a compiler-generated method
      this.g(A_1);
      // ISSUE: reference to a compiler-generated method
      this.f(A_2);
      // ISSUE: reference to a compiler-generated method
      this.g(A_3);
      // ISSUE: reference to a compiler-generated method
      this.f(A_4);
    }
  }

  public class b
  {
    public b(string A_0, int A_1, string A_2, int A_3, float A_4, float A_5, bool A_6, bool A_7, float A_8, string A_9, string A_10, float A_11, float A_12, hh.a[] A_13, int A_14, hh.b.a[] A_15, bool A_16, GuildRole? A_17, ec A_18, float A_19)
    {
      // ISSUE: reference to a compiler-generated method
      this.ag("T" + (object) A_1 + "_" + A_0);
      // ISSUE: reference to a compiler-generated method
      this.af(A_1);
      // ISSUE: reference to a compiler-generated method
      this.af(A_2);
      // ISSUE: reference to a compiler-generated method
      this.ae(A_3);
      // ISSUE: reference to a compiler-generated method
      this.aj(A_4);
      // ISSUE: reference to a compiler-generated method
      this.ai(A_5);
      // ISSUE: reference to a compiler-generated method
      this.af(A_6);
      // ISSUE: reference to a compiler-generated method
      this.ae(A_7);
      // ISSUE: reference to a compiler-generated method
      this.ah(A_8);
      // ISSUE: reference to a compiler-generated method
      this.ae(A_9);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_10);
      // ISSUE: reference to a compiler-generated method
      this.ag(A_11);
      // ISSUE: reference to a compiler-generated method
      this.af(A_12);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_13);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_14);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_15);
      // ISSUE: reference to a compiler-generated method
      this.ag(-1);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_16);
      // ISSUE: reference to a compiler-generated method
      this.ae(0.0f);
      // ISSUE: reference to a compiler-generated method
      this.ad(ahy.h);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ad(new float[this.a2().Length]);
      // ISSUE: reference to a compiler-generated method
      for (int index = 0; index < this.a2().Length; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        if (!this.@as() && !this.a1() && index < this.a2().Length - 1)
        {
          hh.b b = this;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ahy A_0_1 = ahy.n(b.aw(), ahy.l((double) this.ai() * (((double) A_13[index].g() + (double) A_13[index].h()) / 2.0)));
          // ISSUE: reference to a compiler-generated method
          b.ad(A_0_1);
        }
        hh.b b1 = this;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        double num = (double) b1.au() + (double) A_13[index].f();
        // ISSUE: reference to a compiler-generated method
        b1.ae((float) num);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.av()[index] = this.au();
      }
      // ISSUE: reference to a compiler-generated method
      this.ad(A_17);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_18);
      // ISSUE: reference to a compiler-generated method
      this.ad(A_19);
    }

    [SpecialName]
    public bool ag()
    {
      // ISSUE: reference to a compiler-generated method
      return this.af() == "SILVERCOINS";
    }

    [SpecialName]
    public int an()
    {
      // ISSUE: reference to a compiler-generated method
      return this.a2().Length - 1;
    }

    [SpecialName]
    public bool @as()
    {
      // ISSUE: reference to a compiler-generated method
      return (double) this.aq() > 0.0;
    }

    [SpecialName]
    public int ay()
    {
      // ISSUE: reference to a compiler-generated method
      return this.ax().Length;
    }

    [SpecialName]
    public bool a1()
    {
      if (!this.@as())
      {
        // ISSUE: reference to a compiler-generated method
        return !string.IsNullOrEmpty(this.ao());
      }
      return true;
    }

    public sealed class a
    {
      public a(string A_0, ec A_1, float A_2)
      {
        // ISSUE: reference to a compiler-generated method
        this.d(A_0);
        // ISSUE: reference to a compiler-generated method
        this.d(A_1);
        // ISSUE: reference to a compiler-generated method
        this.d(A_2);
      }
    }
  }
}
