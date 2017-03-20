// Decompiled with JetBrains decompiler
// Type: ab8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.GameData;
using Albion.Common.LandScape.RealEstate;
using Albion.Common.Time;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ab8 : n
{
  public static int fe = 150;
  public static int ff = 30;
  public static int fg = 15;
  public static ab8.c fh = new ab8.c();
  private static ahy g4 = ahy.l(3600);
  private static ahy g5 = ahy.l(600);
  private static ahy g6 = ahy.l(600);
  public kx c0 = kx.f(1000.0);
  public ab8.b c3 = new ab8.b();
  public ab8.b c4 = new ab8.b();
  public ab8.b c5 = new ab8.b();
  public ab8.b c6 = new ab8.b();
  public int c7 = 30;
  public float c8 = 8.6f;
  public float c9 = 2.5f;
  public float da = 4.5f;
  public float db = 7f;
  public float dc = 4f;
  public float dd = 5f;
  public kx de = kx.h;
  public kx df = kx.h;
  public kx dg = kx.h;
  public Dictionary<string, kx> dh = new Dictionary<string, kx>();
  public kx di = kx.h;
  public kx dj = kx.h;
  public kx dk = kx.h;
  public Dictionary<string, kx> dl = new Dictionary<string, kx>();
  public int dm = 2;
  public int dn = 1;
  public int @do = 2;
  public int dp = 1;
  public int dq = 2;
  public int dr = 1;
  public int ds = 120;
  public int dt = 30;
  public float du = 50f;
  public float dv = 50f;
  public float dw = 50f;
  public float d6 = 1f;
  public float d7 = 7f;
  public kx ea = kx.g(100L);
  public kx[] eb = new kx[8];
  public kx ec = kx.g;
  public kx ed = kx.g(15L);
  public kx ee = kx.g(14L);
  public int ef = 60;
  public int eg = 10;
  public int eh = 64;
  public int ei = 64;
  public float ej = float.NaN;
  public int ek = 10;
  public kx el = kx.h;
  public int em = 1440;
  public int en = 24;
  public ahy eu = ahy.h;
  public ahy ex = ahy.h;
  public ahy ey = ahy.h;
  public ahy ez = ahy.h;
  public string e0 = string.Empty;
  public string e1 = string.Empty;
  public float e2 = 1f;
  public ahy e4 = ahy.h;
  public string e5 = string.Empty;
  public float e6 = 1f;
  public float e7 = 1f;
  public int fc = 2;
  public int fd = 29;
  public Dictionary<string, ab8.c> fi = new Dictionary<string, ab8.c>();
  public ahy fj = ahy.l(120);
  public ahy fk = ahy.l(10);
  public List<ab8.d> fp = new List<ab8.d>();
  public float fq = -1f;
  public float fr = -1f;
  public float fs = -1f;
  public kx ft = kx.j;
  public int fu = -1;
  public int fv = -1;
  public int fw = -1;
  public float fx = -1f;
  public ahy fy = ahy.g;
  public List<ahy> f4 = new List<ahy>();
  public string gh = "invalid";
  public string gi = "invalid";
  public List<ab8.e> gl = new List<ab8.e>();
  public List<ab8.f> gm = new List<ab8.f>();
  private Dictionary<string, kx> go = new Dictionary<string, kx>();
  private List<global::io> gp = new List<global::io>();
  private int[] gr = new int[8];
  private float[] gs = new float[8];
  private int[] gt = new int[8];
  private float[] gu = new float[8];
  private kx[] gv = new kx[8];
  private kx[] gw = new kx[8];
  private kx[] gx = new kx[8];
  private float[] gy = new float[5];
  private List<int> gz = new List<int>();
  private float[] g0 = new float[5];
  private List<ab8.h> g1 = new List<ab8.h>();
  private Dictionary<OutlineType, int> g2 = new Dictionary<OutlineType, int>();
  public const int ca = 1;
  public const int cb = 8;
  public const int cc = 8;
  public const int cd = 1;
  public const int ce = 5;
  public const int cf = 5;
  public const int cg = 0;
  public const int ch = 3;
  public const int ci = 4;
  public const int cj = 300;
  public const float ck = 3f;
  public const float cl = 2.5f;
  public const int cm = 2;
  public const int cn = 180;
  public const int co = 120;
  public const int cp = 120;
  public const int cq = 3;
  public const int cr = 10;
  public const string cs = "TERRITORY_MATCH_WARCAMP";
  public const string ct = "GUILD_TERRITORY_BUFF";
  public const string cu = "CRIME_PROTECTION_BUFF";
  public const string cv = "OUTLAW";
  public const string cw = "CANNOTDISABLEPVP";
  public const string cx = "@DELETED_PLAYER";
  public const string cy = "PLAYER_ISLAND";
  public const string cz = "GUILD_ISLAND";
  public ahy c1;
  public ahy c2;
  public string dx;
  public string dy;
  public ahy dz;
  public float d0;
  public ahy d1;
  public ahy d2;
  public ahy d3;
  public ahy d4;
  public string d5;
  public int d8;
  public int d9;
  public int eo;
  public int ep;
  public int eq;
  public float er;
  public ahy es;
  public ahy et;
  public float ev;
  public float ew;
  public string e3;
  public DateTime e8;
  public TimeSpan e9;
  public TimeSpan fa;
  public TimeSpan fb;
  public float fl;
  public float fm;
  public float fn;
  public float fo;
  public ahy fz;
  public ahy f0;
  public ahy f1;
  public ahy f2;
  public ahy f3;
  public ahy f5;
  public ahy f6;
  public ahy f7;
  public ahy f8;
  public ahy f9;
  public ahy ga;
  public ahy gb;
  public ahy gc;
  public ahy gd;
  public string ge;
  public string gf;
  public string gg;
  public float gj;
  public float gk;
  private ab8.g[] gn;
  private string gq;
  public kx g3;

  [SpecialName]
  public Dictionary<string, kx> i4()
  {
    return this.go;
  }

  [SpecialName]
  public string jx()
  {
    return kr.b(this.gq);
  }

  public bool hz(GameTimeStamp A_0, GameTimeStamp A_1)
  {
    return ahy.s(this.h0(A_0, A_1), ahy.h);
  }

  public ahy h0(GameTimeStamp A_0, GameTimeStamp A_1)
  {
    ahy A_0_1 = ahy.f;
    GameTimeStamp A_0_2 = A_1.k();
    for (int index = 0; index < this.f4.Count; ++index)
    {
      ahy A_1_1 = this.f4[index];
      GameTimeStamp A_0_3 = GameTimeStamp.b(A_0_2, A_1_1);
      if (GameTimeStamp.i(A_0_3, A_1))
        A_0_3 = GameTimeStamp.b(A_0_3, ahy.n);
      if (!GameTimeStamp.d(A_0_3, A_0))
        return ahy.h;
      A_0_1 = ahy.w(A_0_1, GameTimeStamp.c(A_0_3, A_0));
    }
    return A_0_1;
  }

  public kx h8(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gw.Length)
      return kx.g;
    return this.gw[A_0 - 1];
  }

  public kx h9(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gv.Length)
      return kx.g;
    return this.gv[A_0 - 1];
  }

  public kx ia(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gx.Length)
      return kx.g;
    return this.gx[A_0 - 1];
  }

  public float ib(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gs.Length)
      return 0.0f;
    return this.gs[A_0 - 1];
  }

  public int ic(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gr.Length)
      return 0;
    return this.gr[A_0 - 1];
  }

  public float id(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gu.Length)
      return 0.0f;
    return this.gu[A_0 - 1];
  }

  public int ie(int A_0)
  {
    if (A_0 <= 0 || A_0 > this.gt.Length)
      return 0;
    return this.gt[A_0 - 1];
  }

  public kx ia(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i7().i() == 10000L)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i7().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.n(A_0, this.i7());
  }

  public kx ib(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i7().i() == 10000L)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i7().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(A_0, this.i7());
  }

  public kx ic(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i9().i() == 10000L)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i9().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(A_0, this.i9());
  }

  public kx id(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ja().i() == 10000L)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ja().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(A_0, this.ja());
  }

  public kx ie(kx A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.jb().i() == 10000L)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.jb().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(A_0, this.jb());
  }

  public int hz(OutlineType A_0)
  {
    int num = 0;
    this.g2.TryGetValue(A_0, out num);
    return num;
  }

  public kx hz(aie A_0, string A_1, kx A_2, kx A_3)
  {
    // ISSUE: reference to a compiler-generated method
    j7 j7 = A_0.an();
    kx de = this.de;
    kx df = this.df;
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = j7.a7();
    kx dg = this.dg;
    kx h;
    this.dh.TryGetValue(A_1, out h);
    if (kx.h(h, kx.g))
      h = kx.h;
    return kx.o(kx.o(kx.o(kx.q(kx.o(df, A_3), kx.o(de, A_2)), h), A_1_1), dg).q();
  }

  public int hz(float A_0, b9 A_1, ku A_2)
  {
    global::en en = A_1 as global::en;
    if (en == null || !en.fp())
      return 1;
    float A_0_1 = A_0 / 100f;
    int num1 = A_2.cy(A_0_1) + 1;
    int A_0_2 = 1;
    for (int index = 0; index < num1; ++index)
    {
      int num2 = this.hz((float) A_2.NextDouble());
      if (num2 > A_0_2)
        A_0_2 = num2;
    }
    return en.d1(A_0_2);
  }

  private int hz(float A_0)
  {
    for (int index = 5; index >= 1; --index)
    {
      if ((double) A_0 < (double) this.gy[index - 1])
        return index;
    }
    return 1;
  }

  public float @if(int A_0)
  {
    if (A_0 < 1 || A_0 > 5)
      return 0.0f;
    return this.g0[A_0 - 1];
  }

  public int hz(global::hh.b A_0, ku A_1)
  {
    return this.hz(A_0.ay(), A_1);
  }

  public int hz(int A_0, ku A_1)
  {
    int num1 = A_0 + 1;
    if (num1 <= 1)
      return 0;
    if (num1 > this.gz.Count)
      num1 = this.gz.Count;
    int num2 = 0;
    for (int index = 0; index < num1; ++index)
      num2 += this.gz[index];
    int num3 = 0;
    double num4 = A_1.NextDouble();
    int num5 = (int) Math.Round((double) num2 * num4);
    for (int index = 0; index < num1; ++index)
    {
      num3 += this.gz[index];
      if (num5 <= num3)
        return index;
    }
    return 0;
  }

  public ab8.g hz(PlayerAttribute A_0)
  {
    return this.gn[(int) A_0];
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "AO-GameData")
      throw new AlbionException("[GameData] LoadDataFromXml: XmlTag AO-GameData not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "ServerSettings":
            this.ib(A_0_1);
            continue;
          case "Items":
            this.h9(A_0_1);
            continue;
          case "RealEstateSettings":
            this.@if(A_0_1);
            continue;
          case "MailSettings":
            this.ie(A_0_1);
            continue;
          case "MountSettings":
            this.id(A_0_1);
            continue;
          case "VfxSettings":
            this.ic(A_0_1);
            continue;
          case "ClientSettings":
            this.ia(A_0_1);
            continue;
          case "TaxValues":
            this.h6(A_0_1);
            continue;
          case "DuelSettings":
            this.h7(A_0_1);
            continue;
          case "ChatSettings":
            this.h8(A_0_1);
            continue;
          case "MarketPlace":
            this.h5(A_0_1);
            continue;
          case "WeightLimits":
            this.h4(A_0_1);
            continue;
          case "DurabilityData":
            this.h3(A_0_1);
            continue;
          case "BuildBuilding":
            this.h1(A_0_1);
            continue;
          case "RepairBuilding":
            this.h0(A_0_1);
            continue;
          case "UserTaxValues":
            this.h2(A_0_1);
            continue;
          case "FameGainFactors":
            this.iv(A_0_1);
            continue;
          case "StudyFame":
            this.i3(A_0_1);
            continue;
          case "SilverToItemValue":
            this.i2(A_0_1);
            continue;
          case "SilverDropFromPvp":
            this.i1(A_0_1);
            continue;
          case "ResourceValueToItemValue":
            this.i0(A_0_1);
            continue;
          case "MobFocusFire":
            this.ij(A_0_1);
            continue;
          case "PlayerFocusFire":
            this.ii(A_0_1);
            continue;
          case "PlayerHealingSickness":
            this.ih(A_0_1);
            continue;
          case "CastleFight":
            this.ig(A_0_1);
            continue;
          case "TravelSettings":
            this.i4(A_0_1);
            continue;
          case "Loot":
            this.i5(A_0_1);
            continue;
          case "CraftingQualityChances":
            this.i6(A_0_1);
            continue;
          case "CraftingQualityBonusIncreaseByRequirement":
            this.i7(A_0_1);
            continue;
          case "NutritionConsumption":
            this.i9(A_0_1);
            continue;
          case "CraftNutrition":
            this.i8(A_0_1);
            continue;
          case "ItemValueToNutrition":
            this.iz(A_0_1);
            continue;
          case "ItemValueToBuildingCapacityFactor":
            this.iw(A_0_1);
            continue;
          case "RareResources":
            this.ja(A_0_1);
            continue;
          case "SilverFreeCrafting":
            this.iy(A_0_1);
            continue;
          case "CraftCapacityFreeCrafting":
            this.ix(A_0_1);
            continue;
          case "ActionFocus":
            this.iu(A_0_1);
            continue;
          case "LabourerSettings":
            this.io(A_0_1);
            continue;
          case "ActiveBuffScaling":
            this.@in(A_0_1);
            continue;
          case "PremiumPackages":
            this.im(A_0_1);
            continue;
          case "PremiumLifeTimeRewards":
            this.il(A_0_1);
            continue;
          case "ClusterDangerBonusTypes":
            this.ik(A_0_1);
            continue;
          case "AchievementHud":
            this.it(A_0_1);
            continue;
          case "SilverDropSettings":
            this.@is(A_0_1);
            continue;
          case "buildingrenovationsettings":
            this.ir(A_0_1);
            continue;
          case "Expedition":
            this.iq(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private void ja(XmlElement A_0)
  {
    if (A_0.Name != "RareResources")
      throw new AlbionException("[GameData] LoadDataFromXml: XmlTag RareResources not found! Invalid Xml File?");
    this.eo = aim.b(A_0, "checkintervall", int.MinValue);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "RareState")
      {
        aim.b(A_0_1, "state", int.MinValue);
        int num = aim.b(A_0_1, "weight", int.MinValue);
        if (num > 0)
          this.gz.Add(num);
      }
    }
  }

  private void i9(XmlElement A_0)
  {
    if (A_0.Name != "NutritionConsumption")
      throw new AlbionException("[GameData] LoadDataFromXml: XmlTag NutritionConsumption not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "PerTimeBuilding":
            aim.b(A_0_1, "secondsperpoint", ref this.gv);
            continue;
          case "BuildingOnCraftedItem":
            aim.b(A_0_1, "itemvaluefactor", ref this.gw);
            continue;
          case "NutritionStorage":
            aim.b(A_0_1, "storage", ref this.gx);
            continue;
          default:
            continue;
        }
      }
    }
  }

  private void i8(XmlElement A_0)
  {
    this.ec = aim.c(A_0, "minimumpercent", kx.j);
  }

  private void i7(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Item"))
    {
      float num1 = aim.a(A_0_1, "bonus", -1f);
      int num2 = aim.b(A_0_1, "level", -1);
      if (num2 >= 1 && num2 <= 5 && (double) num1 > 0.0)
        this.g0[num2 - 1] = num1;
    }
  }

  private void i6(XmlElement A_0)
  {
    int num1 = 0;
    int[] numArray = new int[5];
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("QualityLevel"))
    {
      int num2 = aim.b(A_0_1, "weight", -1);
      int num3 = aim.b(A_0_1, "level", -1);
      if (num3 >= 1 && num3 <= 5 && num2 >= 0)
      {
        numArray[num3 - 1] = num2;
        num1 += num2;
      }
    }
    float num4 = 0.0f;
    for (int index1 = 5; index1 >= 1; --index1)
    {
      int index2 = index1 - 1;
      float num2 = (float) numArray[index2] / (float) num1;
      this.gy[index2] = num4 + num2;
      num4 = this.gy[index2];
    }
    if ((double) this.gy[0] == 1.0)
      return;
    this.gy[0] = 1f;
  }

  private void i5(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ie(aim.a(A_0, "vanishtime", ab8.g4));
    // ISSUE: reference to a compiler-generated method
    this.id(aim.a(A_0, "corpseprotection", ab8.g5));
    // ISSUE: reference to a compiler-generated method
    this.ic(aim.a(A_0, "mobprotection", ab8.g6));
  }

  private void i4(XmlElement A_0)
  {
    this.ea = aim.c(A_0, "basetravelcost", kx.j);
    SortedDictionary<int, kx> sortedDictionary = new SortedDictionary<int, kx>();
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("TierModifier"))
    {
      int key = aim.b(A_0_1, "tier", 1);
      kx kx = aim.c(A_0_1, "modifier", kx.j);
      sortedDictionary.Add(key, kx);
    }
    int index = 0;
    foreach (kx kx in sortedDictionary.Values)
    {
      this.eb[index] = kx;
      ++index;
      if (index > 8)
        break;
    }
  }

  private void i3(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.c(A_0, "factor", kx.j));
  }

  private void i2(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.c(A_0, "factor", kx.j));
  }

  private void i1(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h2(aim.c(A_0, "factor", kx.g));
  }

  private void i0(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h1(aim.c(A_0, "factor", kx.j));
  }

  private void iz(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.c(A_0, "factor", kx.j));
  }

  private void iy(XmlElement A_0)
  {
    this.ep = aim.b(A_0, "maxTier", 0);
  }

  private void ix(XmlElement A_0)
  {
    this.eq = aim.b(A_0, "maxTier", 0);
  }

  private void iw(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.c(A_0, "factor", kx.j));
  }

  private void iv(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new global::g7());
    // ISSUE: reference to a compiler-generated method
    this.je().h(A_0);
  }

  private void iu(XmlElement A_0)
  {
    this.fs = aim.a(A_0, "costreductionconstant", -1f);
    this.fq = -1f;
    XmlNodeList elementsByTagName1 = A_0.GetElementsByTagName("CraftingEfficiency");
    if (elementsByTagName1 != null && elementsByTagName1.Count > 0)
    {
      XmlElement A_0_1 = elementsByTagName1[0] as XmlElement;
      if (A_0_1 != null)
        this.fq = aim.a(A_0_1, "bonus", -1f);
    }
    this.fr = -1f;
    XmlNodeList elementsByTagName2 = A_0.GetElementsByTagName("CraftingQuality");
    if (elementsByTagName2 == null || elementsByTagName2.Count <= 0)
      return;
    XmlElement A_0_2 = elementsByTagName2[0] as XmlElement;
    if (A_0_2 == null)
      return;
    this.fr = aim.a(A_0_2, "bonus", -1f);
  }

  private void it(XmlElement A_0)
  {
    this.fy = aim.a(A_0, "tutorial_idletime_till_highlight", this.fy);
  }

  private void @is(XmlElement A_0)
  {
    this.gh = aim.a(A_0, "silver", this.gh);
    this.gi = aim.a(A_0, "silverpremium", this.gi);
    this.gj = aim.a(A_0, "decaytimemob", this.gj);
    this.gk = aim.a(A_0, "decaytimeplayer", this.gk);
  }

  private void ir(XmlElement A_0)
  {
    this.fz = aim.a(A_0, "destroydelay", this.fz);
    this.f0 = aim.a(A_0, "downgradedelay", this.f0);
    this.f2 = aim.a(A_0, "lootprotection", this.f2);
    this.f3 = aim.a(A_0, "lootlifetime", this.f3);
    this.f1 = aim.a(A_0, "ownerdowngradedestroydelay", this.f1);
  }

  private void iq(XmlElement A_0)
  {
    this.f5 = aim.a(A_0, "useexittimeinsec", ahy.l(30));
    this.f6 = aim.a(A_0, "timekickvoteisblockedafterjoininsec", ahy.l(30));
    this.f7 = aim.a(A_0, "kickvotecooldowninsec", ahy.l(30));
    this.f8 = aim.a(A_0, "abandonvotecooldowninsec", ahy.l(30));
    this.f9 = aim.a(A_0, "abandonvoteinitialcooldowninsec", ahy.l(30));
    this.ga = aim.a(A_0, "invitationrequesttimeout", ahy.l(10));
    this.gb = aim.a(A_0, "startrequesttimeout", ahy.l(10));
    this.gc = aim.a(A_0, "enteringduration", ahy.l(5));
    this.ge = aim.a(A_0, "enteringeffectprefab", string.Empty);
    this.gf = aim.a(A_0, "enteringeffectsuccessprefab", string.Empty);
    this.gg = aim.a(A_0, "arrivingeffectprefab", string.Empty);
    this.gd = aim.a(A_0, "penaltyduration", ahy.l(60));
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("ExpeditionBonusRewardTimer"))
    {
      if (A_0_1.Name == "ExpeditionBonusRewardTimer")
        this.ip(A_0_1);
    }
  }

  private void ip(XmlElement A_0)
  {
    this.f4.Clear();
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "ResetTimer")
      {
        TimeSpan A_0_2 = aim.a(A_0_1, "utctime", TimeSpan.Zero);
        if (A_0_2.Ticks < 0L)
          A_0_2 = TimeSpan.Zero;
        this.f4.Add(ahy.k(A_0_2));
      }
    }
  }

  private void io(XmlElement A_0)
  {
    this.ft = aim.c(A_0, "happinessperbarsegment", kx.j);
    this.fu = aim.b(A_0, "maxsafedistancefromhouse", -1);
    this.fv = aim.b(A_0, "maxsafedistancetimeout", -1);
    this.fw = aim.b(A_0, "maxbarsegments", -1);
    this.fx = aim.a(A_0, "maxyield", -1f);
  }

  private void @in(XmlElement A_0)
  {
    this.gn = new ab8.g[57];
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("attribute"))
    {
      PlayerAttribute playerAttribute = aim.a<PlayerAttribute>(A_0_1, "name", PlayerAttribute.NumAttributes);
      if (playerAttribute != PlayerAttribute.NumAttributes)
      {
        ab8.g[] gn = this.gn;
        int index = (int) playerAttribute;
        ab8.g g1 = new ab8.g();
        // ISSUE: reference to a compiler-generated method
        g1.d(aim.a(A_0_1, "absolutemin", float.MinValue));
        // ISSUE: reference to a compiler-generated method
        g1.e(aim.a(A_0_1, "min", float.MinValue));
        // ISSUE: reference to a compiler-generated method
        g1.f(aim.a(A_0_1, "max", float.MaxValue));
        ab8.g g2 = g1;
        gn[index] = g2;
      }
    }
    for (int index1 = 0; index1 < this.gn.Length; ++index1)
    {
      if (this.gn[index1] == null)
      {
        ab8.g[] gn = this.gn;
        int index2 = index1;
        ab8.g g1 = new ab8.g();
        // ISSUE: reference to a compiler-generated method
        g1.e(float.MinValue);
        // ISSUE: reference to a compiler-generated method
        g1.f(float.MaxValue);
        ab8.g g2 = g1;
        gn[index2] = g2;
      }
    }
  }

  private void im(XmlElement A_0)
  {
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "PremiumPackage":
          this.gl.Add(new ab8.e(aim.a(childNode, "name", string.Empty), aim.b(childNode, "days", 1), aim.b(childNode, "goldcost", kx.h)));
          continue;
        default:
          continue;
      }
    }
  }

  private void il(XmlElement A_0)
  {
    foreach (XmlElement childNode1 in A_0_1.ChildNodes)
    {
      if (childNode1 != null && childNode1.Name == "Reward")
      {
        ab8.f f = new ab8.f() { b = aim.b(childNode1, "days", -1), a = aim.a(childNode1, "title", string.Empty) };
        foreach (XmlElement childNode2 in childNode1.ChildNodes)
        {
          if (childNode2 != null && childNode2.Name == "StatBonus")
          {
            switch (aim.a(childNode2, "attribute", string.Empty))
            {
              case "craftingfocus":
                f.d = aim.a(childNode2, "change", 0.0f);
                continue;
              case "learningpoints":
                f.c = aim.c(childNode2, "change", kx.g);
                continue;
              default:
                continue;
            }
          }
        }
        this.gm.Add(f);
      }
    }
    this.gm.Sort((Comparison<ab8.f>) ((A_0_2, A_1) => A_0_2.b.CompareTo(A_1.b)));
  }

  private void ik(XmlElement A_0)
  {
    this.fi.Clear();
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      if (childNode != null && childNode.Name == "ClusterDangerBonus")
      {
        ab8.c c = new ab8.c() { a = aim.a(childNode, "type", ab8.fh.a), b = aim.a(childNode, "icon", ab8.fh.b), c = aim.a(childNode, "moblootfactor", ab8.fh.c), d = aim.c(childNode, "mobsilverlootfactor", ab8.fh.d), e = aim.c(childNode, "famefactor", ab8.fh.e) };
        if (!this.fi.ContainsKey(c.a))
          this.fi.Add(c.a, c);
      }
    }
  }

  private void ij(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.b(A_0, "maxlevel", 10));
    // ISSUE: reference to a compiler-generated method
    this.hz(new Dictionary<global::eg.MobDangerState, int>());
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("dangerstate"))
    {
      // ISSUE: reference to a compiler-generated method
      this.jg()[aim.a<global::eg.MobDangerState>(A_0_1, "dangerstate", global::eg.MobDangerState.Normal)] = aim.b(A_0_1, "attackerthreshold", 99);
    }
  }

  private void ii(XmlElement A_0)
  {
    this.c1 = ahy.l((double) aim.a(A_0_1, "lookbackseconds", 15f));
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<ab8.a>());
    foreach (XmlElement A_0 in A_0_1.GetElementsByTagName("attackers"))
    {
      int num = aim.b(A_0, "numbergreaterorequal", 1);
      string str1 = aim.a(A_0, "meleebuff", "");
      string str2 = aim.a(A_0, "rangedbuff", "");
      // ISSUE: reference to a compiler-generated method
      this.jh().Add(new ab8.a()
      {
        a = num,
        b = str1,
        c = str2
      });
    }
    // ISSUE: reference to a compiler-generated method
    this.jh().Sort((Comparison<ab8.a>) ((A_0_2, A_1) => A_0_2.a - A_1.a));
  }

  private void ih(XmlElement A_0)
  {
    this.c2 = ahy.l((double) aim.a(A_0_1, "lookbackseconds", 15f));
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<KeyValuePair<int, string>>());
    foreach (XmlElement A_0 in A_0_1.GetElementsByTagName("attackers"))
    {
      // ISSUE: reference to a compiler-generated method
      this.ji().Add(new KeyValuePair<int, string>(aim.b(A_0, "numbergreaterorequal", 1), aim.a(A_0, "buff", "")));
    }
    // ISSUE: reference to a compiler-generated method
    this.ji().Sort((Comparison<KeyValuePair<int, string>>) ((A_0_2, A_1) => A_0_2.Key - A_1.Key));
  }

  private void ig(XmlElement A_0)
  {
    this.dm = aim.b(A_0, "eliteguardarrivalinmin", 13);
    this.dn = aim.b(A_0, "eliteguardarrivalwarninginmin", 12);
    this.@do = aim.b(A_0, "castlelordarrivalinmin", 13);
    this.dp = aim.b(A_0, "castlelordarrivalwarninginmin", 12);
    this.dq = aim.b(A_0, "castlephasetimeoutinmin", 20);
    this.dr = aim.b(A_0, "castlephasetimeoutwarninginmin", 15);
  }

  private void @if(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Sale"))
    {
      this.de = aim.c(A_0_1, "squaremeterpricenormal", kx.h);
      this.df = aim.c(A_0_1, "squaremeterpricebuildingarea", kx.h);
      this.dg = aim.c(A_0_1, "overallpricefactor", kx.h);
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("LocationQuality"))
      {
        string str = aim.a(A_0_2, "locationType", "");
        kx kx = aim.c(A_0_2, "factor", kx.h);
        string upper = str.Trim().ToUpper();
        if (upper.Length > 0)
          this.dh.Add(upper, kx);
      }
    }
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Upkeep"))
    {
      this.di = aim.c(A_0_1, "squaremeterpricenormal", kx.h);
      this.dj = aim.c(A_0_1, "squaremeterpricebuildingarea", kx.h);
      this.dk = aim.c(A_0_1, "overallpricefactor", kx.h);
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("LocationQuality"))
      {
        string str = aim.a(A_0_2, "locationType", "");
        kx kx = aim.c(A_0_2, "factor", kx.h);
        string upper = str.Trim().ToUpper();
        if (upper.Length > 0)
          this.dl.Add(upper, kx);
      }
    }
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("OutlineType"))
      this.g2.Add((OutlineType) Enum.Parse(typeof (OutlineType), aim.a(A_0_1, "name", (string) null)), aim.b(A_0_1, "cost", 0));
  }

  private void ie(XmlElement A_0)
  {
    this.g3 = aim.b(A_0, "postage", kx.g);
    this.fd = aim.b(A_0, "sendmaillimitperday", 29);
  }

  private void id(XmlElement A_0)
  {
    this.e5 = aim.a(A_0, "halfmountvfx", string.Empty);
    this.e6 = aim.a(A_0, "halfmountvfx_originalSize", 1f);
    // ISSUE: reference to a compiler-generated method
    this.h0(ahy.l(aim.b(A_0, "combatmountcooldown", 6)));
  }

  private void ic(XmlElement A_0)
  {
    this.e7 = aim.a(A_0, "fadeouttime", this.e7);
  }

  private void ib(XmlElement A_0)
  {
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode1 as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "MiniMap":
            // ISSUE: reference to a compiler-generated method
            this.id(aim.a(A_0_1, "zergcellsize", 80f));
            // ISSUE: reference to a compiler-generated method
            this.h4(aim.b(A_0_1, "zergmingroupsize", 6));
            // ISSUE: reference to a compiler-generated method
            this.h3(aim.b(A_0_1, "maxplayerspermsg", 30));
            continue;
          case "ClientUpdate":
            // ISSUE: reference to a compiler-generated method
            this.h6(aim.b(A_0_1, "moveupdateinms", 0));
            continue;
          case "Items":
            // ISSUE: reference to a compiler-generated method
            this.h5(aim.b(A_0_1, "vanishtimeforunuseditems", 3600));
            continue;
          case "Guild":
            // ISSUE: reference to a compiler-generated method
            this.h9(aim.b(A_0_1, "cost", kx.g));
            // ISSUE: reference to a compiler-generated method
            this.h2(aim.b(A_0_1, "guildinvitationdelayinseconds", 70));
            // ISSUE: reference to a compiler-generated method
            this.h8(aim.b(A_0_1, "initialclaimterritoryguildfamerequirement", kx.g));
            // ISSUE: reference to a compiler-generated method
            this.h7(aim.b(A_0_1, "claimterritoryguildfamerequirement", kx.g));
            // ISSUE: reference to a compiler-generated method
            this.hz(aim.h(A_0_1, "territorybuff"));
            continue;
          case "SiegeCamp":
            this.eg = aim.b(A_0_1, "siegecampclaimtimeinsec", 11);
            this.eh = aim.b(A_0_1, "vaultsize", 65);
            this.ei = aim.b(A_0_1, "battlevaultsize", 65);
            this.ek = aim.b(A_0_1, "cooldowninmin", 11);
            this.ej = aim.a(A_0_1, "weightlimit", float.NaN);
            this.el = aim.c(A_0_1, "costfactor", kx.h);
            continue;
          case "Alliance":
            // ISSUE: reference to a compiler-generated method
            this.h6(aim.b(A_0_1, "cost", kx.g));
            // ISSUE: reference to a compiler-generated method
            this.h5(aim.b(A_0_1, "upkeepcostperguild", kx.g));
            // ISSUE: reference to a compiler-generated method
            this.h7(aim.b(A_0_1, "upkeeptimerinmin", 10020));
            continue;
          case "GoldMarket":
            this.ed = aim.b(A_0_1, "setupsellordercost", kx.g(15L));
            this.ee = aim.b(A_0_1, "setupbuyordercost", kx.g(15L));
            this.ef = aim.b(A_0_1, "swaptransactiongoldpurchaseinterval", 60);
            continue;
          case "Respawn":
            this.ds = aim.b(A_0_1, "autorespawntimerinsecs", 300);
            continue;
          case "Fame":
            this.dv = (float) aim.b(A_0_1, "pvpfamesharingradius", 51);
            this.dw = (float) aim.b(A_0_1, "pvefamesharingradius", 51);
            this.hz(A_0_1);
            continue;
          case "DeathSettings":
            this.dx = aim.a(A_0_1, "playerexecutionspell", "PLAYER_COUPDEGRACE");
            this.dy = aim.a(A_0_1, "mobexecutionspell", "MOB_COUPDEGRACE");
            this.dz = ahy.l(aim.b(A_0_1, "getuptimeseconds", 6));
            this.d0 = (float) aim.b(A_0_1, "knockdownhealthregentopercent", 1);
            this.d1 = ahy.l(aim.b(A_0_1, "knockdowngetuptimeseconds_pve", 600));
            this.d2 = ahy.l(aim.b(A_0_1, "knockdowngetuptimeseconds_duel", 6));
            this.d3 = ahy.l(aim.b(A_0_1, "knockdowngetuptimeseconds_pvp", 180));
            this.d4 = ahy.l(aim.b(A_0_1, "knockdowngetuptimeseconds_combatover", 18));
            this.d5 = aim.a(A_0_1, "knockdownbuffaftergetup", "SPAWN_KNOCKDOWN");
            continue;
          case "Casting":
            this.d6 = aim.a(A_0_1, "globaldisruptionfactor", 1f);
            this.d7 = aim.a(A_0_1, "globalcastrangetolerance", 7f);
            continue;
          case "AoeEscalation":
            this.d8 = aim.b(A_0_1, "defaulttargetcountthresholdmin", 2);
            this.d9 = aim.b(A_0_1, "defaulttargetcountthresholdmax", 12);
            continue;
          case "StuckCommand":
            // ISSUE: reference to a compiler-generated method
            this.ib(ahy.l((double) aim.a(A_0_1, "cooldownseconds", 600f)));
            // ISSUE: reference to a compiler-generated method
            this.ia(ahy.l((double) aim.a(A_0_1, "delayseconds", 20f)));
            continue;
          case "ClusterChange":
            // ISSUE: reference to a compiler-generated method
            this.h9(ahy.l((double) aim.a(A_0_1, "cooldownseconds", 10f)));
            continue;
          case "SpawnBuff":
            // ISSUE: reference to a compiler-generated method
            this.h1(aim.a(A_0_1, "buff_always", "SPAWN_INVULNERABILITY"));
            // ISSUE: reference to a compiler-generated method
            this.h0(aim.a(A_0_1, "buf_nonlogin", "SPAWN_SPEED"));
            continue;
          case "Logout":
            // ISSUE: reference to a compiler-generated method
            this.h8(ahy.l((double) aim.a(A_0_1, "timeseconds", 10f)));
            // ISSUE: reference to a compiler-generated method
            this.h6(ahy.m((double) aim.a(A_0_1, "inactivitylogoutminutes", 15f)));
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.h7(ahy.n(this.ib(), ahy.m(5)));
            continue;
          case "InCombat":
            // ISSUE: reference to a compiler-generated method
            this.h5(ahy.l((double) aim.a(A_0_1, "activetimeoutseconds", 10f)));
            // ISSUE: reference to a compiler-generated method
            this.h4(ahy.l((double) aim.a(A_0_1, "passivetimeoutseconds", 10f)));
            continue;
          case "FurnitureObjects":
            // ISSUE: reference to a compiler-generated method
            this.h3(ahy.l((double) aim.a(A_0_1, "placetimeseconds", 10f)));
            continue;
          case "SpellCooldowns":
            // ISSUE: reference to a compiler-generated method
            this.h2(ahy.l((double) aim.a(A_0_1, "onequipmentchange", 2f)));
            // ISSUE: reference to a compiler-generated method
            this.h1(ahy.l((double) aim.a(A_0_1, "onmount", 2f)));
            continue;
          case "CrowdControlDiminishingReturns":
            // ISSUE: reference to a compiler-generated method
            this.im(aim.a(A_0_1, "breaksondamagefactor", 0.5f));
            // ISSUE: reference to a compiler-generated method
            this.il(aim.a(A_0_1, "diminishingreturnmax", 0.75f));
            // ISSUE: reference to a compiler-generated method
            this.ik(aim.a(A_0_1, "diminishingreturnsduration", 5f));
            // ISSUE: reference to a compiler-generated method
            this.ij(aim.a(A_0_1, "typefactorstun", 5f));
            // ISSUE: reference to a compiler-generated method
            this.ii(aim.a(A_0_1, "typefactorroot", 5f));
            // ISSUE: reference to a compiler-generated method
            this.ih(aim.a(A_0_1, "typefactorknockback", 5f));
            // ISSUE: reference to a compiler-generated method
            this.ig(aim.a(A_0_1, "typefactorsilence", 5f));
            // ISSUE: reference to a compiler-generated method
            this.@if(aim.a(A_0_1, "typefactorslow", 5f));
            // ISSUE: reference to a compiler-generated method
            this.ie(aim.a(A_0_1, "typefactorforcedmovement", 5f));
            continue;
          case "RealEstateAuctionSettings":
            this.e8 = aim.a(A_0_1, "auctioncyclereferencetimestamp", DateTime.MinValue);
            this.e9 = TimeSpan.FromDays((double) aim.b(A_0_1, "auctioncycledurationdays", 10));
            this.fa = TimeSpan.FromDays((double) aim.b(A_0_1, "auctionlengthdays", 6));
            this.fb = TimeSpan.FromMinutes((double) aim.b(A_0_1, "ownerexclusivebidtimeinmin", 60));
            this.fc = aim.b(A_0_1, "ownerbidmultiplier", 2);
            continue;
          case "Reputation":
            this.fj = ahy.l((double) aim.a(A_0_1, "attacktimeoutseconds", 120f));
            this.fk = ahy.l((double) aim.a(A_0_1, "supporttimeoutseconds", 10f));
            this.fl = aim.a(A_0_1, "minreputation", -20000f);
            this.fm = aim.a(A_0_1, "maxreputation", 20000f);
            this.fn = aim.a(A_0_1, "startreputation", 0.0f);
            this.fo = aim.a(A_0_1, "reputationafterflagginghostile", -1f);
            foreach (XmlNode childNode2 in A_0_1.ChildNodes)
            {
              XmlElement A_0_2 = childNode2 as XmlElement;
              if (A_0_2 != null && A_0_2.Name.ToLower() == "level")
                this.fp.Add(new ab8.d(A_0_2));
            }
            this.fp.Sort();
            continue;
          default:
            continue;
        }
      }
    }
  }

  private void ia(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "MiniMap":
            // ISSUE: reference to a compiler-generated method
            this.hz(ahy.l((double) aim.a(A_0_1, "showgraveseconds", 300f)));
            continue;
          default:
            continue;
        }
      }
    }
  }

  private void h9(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "AbilityPowerProgression":
            // ISSUE: reference to a compiler-generated method
            this.ic(aim.a(A_0_1, "basedamage", 100f));
            // ISSUE: reference to a compiler-generated method
            this.ib(aim.a(A_0_1, "baseload", 100f));
            // ISSUE: reference to a compiler-generated method
            this.ia(aim.a(A_0_1, "hitpointprogression", 0.6614f));
            // ISSUE: reference to a compiler-generated method
            this.h9(aim.a(A_0_1, "resistanceprogression", 0.3386f));
            // ISSUE: reference to a compiler-generated method
            this.h8(aim.a(A_0_1, "loadprogression", 1.2648f));
            continue;
          case "ItemPowerProgression":
            // ISSUE: reference to a compiler-generated method
            this.h7(aim.a(A_0_1, "armorbase", 100f));
            // ISSUE: reference to a compiler-generated method
            this.h6(aim.a(A_0_1, "ccrbase", 0.0f));
            // ISSUE: reference to a compiler-generated method
            this.h5(aim.a(A_0_1, "attackdamageprogression", 1.1128f));
            // ISSUE: reference to a compiler-generated method
            this.h4(aim.a(A_0_1, "abilitypowerprogression", 1.1128f));
            // ISSUE: reference to a compiler-generated method
            this.h3(aim.a(A_0_1, "hitpointsprogression", 1.07f));
            // ISSUE: reference to a compiler-generated method
            this.h2(aim.a(A_0_1, "energyprogression", 1.1128f));
            // ISSUE: reference to a compiler-generated method
            this.h1(aim.a(A_0_1, "armorprogression", 1.04f));
            // ISSUE: reference to a compiler-generated method
            this.h0(aim.a(A_0_1, "crowdcontrolresistanceprogression", 1.1128f));
            IEnumerator enumerator1 = A_0_1.ChildNodes.GetEnumerator();
            try
            {
              while (enumerator1.MoveNext())
              {
                XmlElement current = (XmlNode) enumerator1.Current as XmlElement;
                if (current != null)
                {
                  ab8.b b = (ab8.b) null;
                  switch (current.Name)
                  {
                    case "armorshare":
                      b = this.c3;
                      break;
                    case "ccrshare":
                      b = this.c4;
                      break;
                    case "hitpointsshare":
                      b = this.c5;
                      break;
                    case "energyshare":
                      b = this.c6;
                      break;
                  }
                  if (b != null)
                  {
                    foreach (ItemPowerProgressionType powerProgressionType in Enum.GetValues(typeof (ItemPowerProgressionType)))
                    {
                      if (powerProgressionType >= ItemPowerProgressionType.MainHand && powerProgressionType < (ItemPowerProgressionType) b.a.Length)
                        b.a[(int) powerProgressionType] = aim.a(current, powerProgressionType.ToString().ToLower(), 0.0f);
                    }
                  }
                }
              }
              continue;
            }
            finally
            {
              IDisposable disposable = enumerator1 as IDisposable;
              if (disposable != null)
                disposable.Dispose();
            }
          case "QualityLevels":
            // ISSUE: reference to a compiler-generated method
            this.hz(new float[5]);
            XmlNodeList elementsByTagName = A_0_1.GetElementsByTagName("qualitylevel");
            if (elementsByTagName.Count > 0)
            {
              IEnumerator enumerator2 = elementsByTagName.GetEnumerator();
              try
              {
                while (enumerator2.MoveNext())
                {
                  XmlElement current = (XmlElement) enumerator2.Current;
                  int num = aim.b(current, "level", -1);
                  if (num >= 1 && num <= 5)
                  {
                    // ISSUE: reference to a compiler-generated method
                    this.jw()[num - 1] = aim.a(current, "itempowerbonus", 0.0f);
                  }
                }
                continue;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                if (disposable != null)
                  disposable.Dispose();
              }
            }
            else
              continue;
          default:
            continue;
        }
      }
    }
  }

  private void h8(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "SayRadius":
          this.er = aim.a(childNode as XmlElement, "value", 30f);
          continue;
        case "GlobalMessageCooldownInMs":
          this.es = ahy.k(aim.b(childNode as XmlElement, "value", 2001));
          continue;
        case "WhisperCooldownInMs":
          this.et = ahy.k(aim.b(childNode as XmlElement, "value", 501));
          continue;
        default:
          continue;
      }
    }
  }

  private void h7(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "DuelAreaRadius":
          this.ev = aim.a(childNode as XmlElement, "value", 25f);
          continue;
        case "DuelNotificationRadius":
          this.ew = aim.a(childNode as XmlElement, "value", 30f);
          continue;
        case "AcceptDuelCountDownInSeconds":
          this.ex = aim.a(childNode as XmlElement, "value", ahy.l(10.0));
          continue;
        case "DuelAreaLeftTimerInSeconds":
          this.eu = aim.a(childNode as XmlElement, "value", ahy.l(3.0));
          continue;
        case "AcceptButtonDelayInSeconds":
          this.ey = aim.a(childNode as XmlElement, "value", ahy.l(3.0));
          continue;
        case "DuelPreparationTimeInSeconds":
          this.ez = aim.a(childNode as XmlElement, "value", ahy.l(10.0));
          continue;
        case "DuelFlagPrefab":
          this.e0 = aim.a(childNode as XmlElement, "name", string.Empty);
          continue;
        case "DuelRingPrefab":
          this.e1 = aim.a(childNode as XmlElement, "name", string.Empty);
          this.e2 = aim.a(childNode as XmlElement, "originalSize", 1f);
          continue;
        case "DuelKnockDownGetUpBuff":
          this.e3 = aim.a(childNode as XmlElement, "name", string.Empty);
          continue;
        case "IssueDuelIntervalTimeInSeconds":
          this.e4 = aim.a(childNode as XmlElement, "value", ahy.l(10));
          continue;
        default:
          continue;
      }
    }
  }

  private void h6(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Tax"))
    {
      string index = aim.a(A_0_1, "name", "");
      kx kx = aim.c(A_0_1, "value", kx.h);
      if (string.IsNullOrEmpty(index))
        throw new AlbionException("[GameData] couldn't parse Tax element " + A_0_1.Name);
      this.go[index] = kx;
    }
  }

  private void h5(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new global::eq());
    // ISSUE: reference to a compiler-generated method
    this.i2().k(A_0);
  }

  private void h4(XmlElement A_0)
  {
    this.gq = aim.a(A_0, "normalmessage", string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.b(A_0, "repeatdelay", 0));
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Limit"))
      this.gp.Add(new global::io(aim.a(A_0_1, "aboveweightpercent", 1000f), aim.a(A_0_1, "speedfactor", 1f), aim.a(A_0_1, "message", string.Empty)));
    this.gp.Sort();
  }

  private void h3(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new global::im());
    // ISSUE: reference to a compiler-generated method
    this.jc().y(A_0);
  }

  private void h2(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new global::h4());
    // ISSUE: reference to a compiler-generated method
    this.jd().d(A_0);
  }

  private void h1(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Resource")
      {
        int num1 = aim.b(A_0_1, "tier", 0);
        float num2 = aim.a(A_0_1, "time", 0.0f);
        int num3 = aim.b(A_0_1, "maxstack", 1);
        this.gr[num1 - 1] = num3;
        this.gs[num1 - 1] = num2;
      }
    }
  }

  private void h0(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Resource")
      {
        int num1 = aim.b(A_0_1, "tier", 0);
        float num2 = aim.a(A_0_1, "time", 0.0f);
        int num3 = aim.b(A_0_1, "maxstack", 1);
        this.gt[num1 - 1] = num3;
        this.gu[num1 - 1] = num2;
      }
    }
  }

  public float @in(float A_0)
  {
    for (int index = 0; index < this.gp.Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0 > (double) this.gp[index].e())
      {
        // ISSUE: reference to a compiler-generated method
        return this.gp[index].f();
      }
    }
    return 1f;
  }

  public float jz()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.gp.Count > 0 && (double) this.gp[0].f() == 0.0)
    {
      // ISSUE: reference to a compiler-generated method
      return this.gp[0].e();
    }
    return float.MaxValue;
  }

  public string io(float A_0)
  {
    for (int index = 0; index < this.gp.Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0 > (double) this.gp[index].e())
        return this.gp[index].h();
    }
    return this.jx();
  }

  public kx hz(global::en A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.jc().i(A_0, this).q();
  }

  public kx hz(global::ca A_0, kx A_1, kx A_2)
  {
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = this.jc().i(A_0, A_1, this);
    // ISSUE: reference to a compiler-generated method
    if (A_2.i() == 10000L)
      return A_0_1;
    return kx.o(A_0_1, A_2).q();
  }

  public kx hz(global::ca A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.jc().j(A_0, A_1, this);
  }

  public kx h0(global::ca A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.jc().k(A_0, A_1, this);
  }

  public kx h1(global::ca A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.jc().l(A_0, A_1, this);
  }

  public kx h2(global::ca A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.ia(this.jc().m(A_0, A_1, this));
  }

  public kx hz(b9 A_0, kx A_1)
  {
    return kx.o(A_0.s, A_1);
  }

  public kx hz(b9 A_0, kx A_1, abc A_2)
  {
    if (A_0.k == null)
      return kx.g;
    kx A_0_1 = kx.g;
    // ISSUE: reference to a compiler-generated method
    foreach (aa9.a a in A_0.k.p())
    {
      // ISSUE: reference to a compiler-generated method
      int A_1_1 = (int) Math.Ceiling((double) this.jc().i((float) a.c, A_1));
      if (A_1_1 != 0)
      {
        b9 b9 = A_2.hz(a.a, a.b);
        if (b9 != null)
          A_0_1 = kx.q(A_0_1, kx.f(b9.t, A_1_1));
      }
    }
    return A_0_1;
  }

  public kx h0(b9 A_0, kx A_1, abc A_2)
  {
    if (A_0.k == null)
      return kx.g;
    kx A_0_1 = kx.g;
    // ISSUE: reference to a compiler-generated method
    foreach (aa9.a a in A_0.k.p())
    {
      // ISSUE: reference to a compiler-generated method
      int A_1_1 = (int) Math.Ceiling((double) this.jc().i((float) a.c, A_1));
      if (A_1_1 != 0)
      {
        b9 b9 = A_2.hz(a.a, a.b);
        if (b9 != null)
          A_0_1 = kx.q(A_0_1, kx.f(b9.u, A_1_1));
      }
    }
    return A_0_1;
  }

  public kx hz(kx A_0, kx A_1)
  {
    if (kx.k(A_0, kx.g) && kx.j(A_1, this.c0))
      return kx.p(A_0, kx.o(kx.n(A_1, this.c0), A_0).r());
    return kx.g;
  }

  private kx hz(b9 A_0, int A_1, int A_2, kx A_3)
  {
    if (A_0.l.Length <= A_1)
      return kx.g;
    aa9 aa9 = A_0.l[A_1];
    // ISSUE: reference to a compiler-generated method
    if (aa9 == null || A_0.s.i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    int A_1_1 = (int) Math.Ceiling((double) A_2 / (double) aa9.q());
    return kx.f(kx.o(this.ia(A_0.s), A_3), A_1_1).q();
  }

  public kx hz(b9 A_0, int A_1, int A_2)
  {
    if (A_0.l.Length <= A_1)
      return kx.g;
    aa9 aa9 = A_0.l[A_1];
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (aa9.m().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    int A_1_1 = (int) Math.Ceiling((double) A_2 / (double) aa9.q());
    // ISSUE: reference to a compiler-generated method
    return kx.f(aa9.m(), A_1_1).q();
  }

  public kx h0(b9 A_0, int A_1, int A_2, kx A_3)
  {
    if (A_0.f <= this.ep)
      return kx.g;
    return this.hz(A_0, A_1, A_2, A_3);
  }

  public kx hz(b9 A_0, int A_1, kx A_2)
  {
    return this.hz(A_0, 0, A_1, A_2);
  }

  public kx h0(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 10000L)
      return A_0;
    return kx.o(A_0, A_1).q();
  }

  public kx h1(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 10000L)
      return A_0;
    return kx.o(A_0, A_1).q();
  }

  public kx h0(b9 A_0, kx A_1)
  {
    return kx.o(this.ia(A_0.s), A_1).q();
  }

  public kx hz(b9 A_0)
  {
    return A_0.t;
  }

  public kx h0(b9 A_0)
  {
    kx A_1 = this.h8(A_0.f);
    return kx.o(A_0.u, A_1);
  }

  public kx h1(b9 A_0)
  {
    if (A_0.f <= this.eq)
      return kx.g;
    return this.ie(A_0.s);
  }

  public kx h2(b9 A_0)
  {
    return this.h1(A_0);
  }

  public float hz(bool A_0, float A_1, float A_2, float A_3, b9 A_4, int A_5, int A_6, out float A_7, out float A_8)
  {
    A_7 = 0.0f;
    A_8 = 0.0f;
    if (A_4.l == null || A_6 < 0 || A_6 >= A_4.l.Length)
      return 0.0f;
    aa9 aa9 = A_4.l[A_6];
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (aa9 == null || !aa9.v() || aa9.u() == 0)
      return 0.0f;
    // ISSUE: reference to a compiler-generated method
    return this.hz(A_0, A_1, A_2, A_3, aa9.u(), A_5, out A_7, out A_8);
  }

  public float hz(bool A_0, float A_1, float A_2, float A_3, int A_4, int A_5, out float A_6, out float A_7)
  {
    A_6 = 0.0f;
    A_7 = 0.0f;
    A_7 = 0.0f;
    A_6 = 0.0f;
    if (A_0)
    {
      A_7 = this.hz((float) A_4, A_5, A_2);
      A_6 = this.hz(A_7, A_1);
      if ((double) A_7 >= (double) A_1)
        A_7 = A_1;
    }
    float num1 = 1f - A_3;
    if ((double) A_6 > 0.0)
      num1 *= 1f - this.ip(A_6);
    float val2 = 1f - num1;
    double num2 = (double) Math.Min(1f, Math.Max(0.0f, val2));
    return val2;
  }

  public float hz(float A_0, int A_1, float A_2)
  {
    if ((double) A_0 <= 0.0)
      return 0.0f;
    return (float) Math.Max(1.0, Math.Round((double) (A_0 * (float) A_1) * (1.0 / Math.Pow((double) this.fs, (double) A_2))));
  }

  private float hz(float A_0, float A_1)
  {
    if ((double) A_1 <= 0.0 || (double) A_0 <= 0.0)
      return 0.0f;
    if ((double) A_1 >= (double) A_0)
      return 1f;
    return A_1 / A_0;
  }

  public float ip(float A_0)
  {
    float fq = this.fq;
    return A_0 * fq;
  }

  public float iq(float A_0)
  {
    float fr = this.fr;
    return A_0 * fr;
  }

  public float ig(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 >= 1 && A_0 <= this.jw().Length)
    {
      // ISSUE: reference to a compiler-generated method
      return this.jw()[A_0 - 1];
    }
    return 0.0f;
  }

  private void hz(XmlElement A_0)
  {
    if (A_0.FirstChild == null)
      return;
    foreach (XmlNode childNode in A_0.FirstChild.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Group")
      {
        ab8.h h = new ab8.h();
        h.a = aim.b(A_0_1, "size", 1);
        h.b = aim.c(A_0_1, "bonusfactor", kx.h);
        if (h.a > 1)
          this.g1.Add(h);
      }
    }
    this.g1.Sort();
  }

  public kx ih(int A_0)
  {
    for (int index = this.g1.Count - 1; index >= 0; --index)
    {
      if (this.g1[index].a <= A_0)
        return this.g1[index].b;
    }
    return kx.h;
  }

  public ab8.d ir(float A_0)
  {
    return this.fp[this.@is(A_0)];
  }

  public int @is(float A_0)
  {
    for (int index = 0; index < this.fp.Count - 1; ++index)
    {
      if ((double) A_0 >= (double) this.fp[index].a)
        return index;
    }
    return this.fp.Count - 1;
  }

  public struct a
  {
    public int a;
    public string b;
    public string c;
  }

  public class b
  {
    public float[] a = new float[9];

    public float b(ItemPowerProgressionType A_0)
    {
      int index = (int) A_0;
      if (index >= 0 && index < this.a.Length)
        return this.a[index];
      return 0.0f;
    }
  }

  public class c
  {
    public string a = string.Empty;
    public string b = "safe";
    public float c = 1f;
    public kx d = kx.h;
    public kx e = kx.h;

    [SpecialName]
    public string g()
    {
      return "icon_cluster_" + this.b;
    }
  }

  public class d : IComparable<ab8.d>
  {
    public readonly float a;
    public readonly string b;
    public readonly string c;
    public readonly string d;
    public readonly float e;
    public readonly float f;
    public readonly float g;
    public readonly bool h;
    public readonly float i;
    public readonly float j;
    public readonly float k;
    public readonly global::it.PvpWarningLevel l;
    public readonly string m;

    public d(XmlElement A_0)
    {
      this.a = aim.a(A_0, "requiredpoints", 0.0f);
      this.b = aim.a(A_0, "title", "");
      this.c = aim.a(A_0, "nametagicon", "");
      this.d = aim.a(A_0, "rewardicon", "");
      this.h = aim.a(A_0, "candisablepvp", true);
      this.i = aim.a(A_0, "attackpenalty", 0.0f);
      this.j = aim.a(A_0, "knockdownpenalty", 0.0f);
      this.g = aim.a(A_0, "pvegainfactor", 0.0f);
      this.k = aim.a(A_0, "killpenalty", 0.0f);
      this.f = aim.a(A_0, "recoveryperday", 0.0f);
      this.e = this.f / 86400f;
      this.l = aim.a<global::it.PvpWarningLevel>(A_0, "cityaccessdisplay", global::it.PvpWarningLevel.safe);
      this.m = aim.h(A_0, "crimeprotectionbuff");
    }

    public int CompareTo(ab8.d other)
    {
      return other.a.CompareTo(this.a);
    }
  }

  public class e
  {
    public string a;
    public int b;
    public kx c;

    public e(string A_0, int A_1, kx A_2)
    {
      this.a = A_0;
      this.b = A_1;
      this.c = A_2;
    }
  }

  public class f
  {
    public string a;
    public int b;
    public kx c;
    public float d;

    [SpecialName]
    public string f()
    {
      return kr.b(this.a);
    }
  }

  public class g
  {
  }

  private class h : IComparable<ab8.h>
  {
    public int a;
    public kx b;

    public int CompareTo(ab8.h other)
    {
      return this.a.CompareTo(other.a);
    }
  }
}
