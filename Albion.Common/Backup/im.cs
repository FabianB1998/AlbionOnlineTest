// Decompiled with JetBrains decompiler
// Type: im
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Xml;

public class im
{
  private kx[] a = new kx[8];
  private kx[] b = new kx[8];
  private kx[] c = new kx[8];
  private kx[] d = new kx[8];
  private kx[] e = new kx[8];
  private kx[] f = new kx[8];
  private kx[] g = new kx[8];
  private kx[] h = new kx[8];
  private kx[] i = new kx[8];
  private kx[] j = new kx[8];
  private kx[] k = new kx[9];
  private kx[] l = new kx[8];
  private kx[] m = new kx[8];
  private kx[] n = new kx[8];
  private kx[] o = new kx[8];
  private kx[] p = new kx[8];
  private kx[] q = new kx[8];
  private bool[] r = new bool[6];
  private kx[] x = new kx[8];
  private kx[] y = new kx[8];
  private kx[] z = new kx[8];
  private im.c[] s;
  private kx t;
  private kx u;
  private kx v;
  private kx w;
  private kx aa;
  private kx ab;
  private kx ac;
  private kx ad;
  private kx ae;

  public im()
  {
    // ISSUE: reference to a compiler-generated method
    this.i(new List<im.a>());
    this.s = new im.c[Enum.GetValues(typeof (im.d)).Length];
    for (int index = 0; index < this.s.Length; ++index)
      this.s[index] = new im.c();
  }

  public kx i(int A_0)
  {
    return this.a[A_0 - 1];
  }

  public kx j(int A_0)
  {
    return this.b[A_0 - 1];
  }

  public kx k(int A_0)
  {
    return this.c[A_0 - 1];
  }

  public kx l(int A_0)
  {
    return this.d[A_0 - 1];
  }

  public kx m(int A_0)
  {
    return this.e[A_0 - 1];
  }

  public kx n(int A_0)
  {
    return this.g[A_0 - 1];
  }

  public kx o(int A_0)
  {
    return this.h[A_0 - 1];
  }

  public kx p(int A_0)
  {
    return this.i[A_0 - 1];
  }

  public kx q(int A_0)
  {
    return this.j[A_0 - 1];
  }

  public kx r(int A_0)
  {
    return this.k[A_0];
  }

  public kx s(int A_0)
  {
    return this.l[A_0 - 1];
  }

  public kx t(int A_0)
  {
    return this.m[A_0 - 1];
  }

  public kx u(int A_0)
  {
    return this.o[A_0 - 1];
  }

  public kx v(int A_0)
  {
    return this.p[A_0 - 1];
  }

  public kx w(int A_0)
  {
    return this.q[A_0 - 1];
  }

  public kx i(im.d A_0, int A_1, Random A_2)
  {
    kx A_1_1 = this.s[(int) A_0].b[A_1 - 1];
    kx A_0_1 = this.s[(int) A_0].c[A_1 - 1];
    kx A_1_2 = kx.f(A_2.NextDouble());
    return kx.q(kx.o(kx.p(A_0_1, A_1_1), A_1_2), A_1_1);
  }

  public kx i(im.d A_0, int A_1)
  {
    return this.s[(int) A_0].d[A_1 - 1];
  }

  public kx j(im.d A_0, int A_1)
  {
    return this.s[(int) A_0].a[A_1 - 1];
  }

  public kx k(im.d A_0, int A_1)
  {
    return this.s[(int) A_0].e[A_1 - 1];
  }

  public kx i(bd A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.f((1.0 - Math.Min(1.0, A_1.m() / A_0.dk().m())) * (double) A_0.d5());
  }

  private kx l(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() == 0L)
      return kx.g;
    kx kx = kx.o(A_0, A_1).q();
    // ISSUE: reference to a compiler-generated method
    if (kx.i() == 0L)
      return kx.h;
    return kx;
  }

  private kx k(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 0L)
      return kx.g;
    kx kx = kx.n(A_0, A_1);
    return kx.q(kx.o(kx, this.t), kx.o(kx.p(kx.h, kx), this.u));
  }

  public kx i(ca A_0, kx A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.v.i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = kx.o(this.k(A_1, A_0.fr()), this.v);
    return this.l(A_2.ia(A_0.s), A_1_1);
  }

  public kx i(ca A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.v.i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = kx.o(this.k(A_1, A_0.fr()), this.v);
    // ISSUE: reference to a compiler-generated method
    return this.l(A_0.k.n(), A_1_1);
  }

  public kx j(ca A_0, kx A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = this.k(A_1, A_0.fr());
    return this.l(A_2.ie(A_0.s), A_1_1);
  }

  public kx k(ca A_0, kx A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = this.k(A_1, A_0.fr());
    return this.l(A_0.u, A_1_1);
  }

  public kx l(ca A_0, kx A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = this.k(A_1, A_0.fr());
    return this.l(A_0.t, A_1_1);
  }

  public kx m(ca A_0, kx A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = this.k(A_1, A_0.fr());
    return this.l(A_0.s, A_1_1);
  }

  public kx i(float A_0)
  {
    return kx.o(kx.f((double) A_0), this.w);
  }

  private kx j(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() == 0L)
      return kx.g;
    kx kx = kx.o(A_0, A_1).q();
    // ISSUE: reference to a compiler-generated method
    if (kx.i() == 0L)
      return kx.h;
    return kx;
  }

  public float i(float A_0, kx A_1)
  {
    return A_0 * (float) A_1.m();
  }

  public int i(int A_0, kx A_1, ku A_2)
  {
    float A_0_1 = this.i((float) A_0, A_1);
    return A_2.cy(A_0_1);
  }

  public kx i(kx A_0, kx A_1, ku A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() == 0L)
      return kx.g;
    float A_0_1 = this.i((float) A_0.m(), A_1);
    return kx.g((long) A_2.cy(A_0_1));
  }

  private kx i(kx A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 0L)
      return kx.g;
    kx kx = kx.n(A_0, A_1);
    return kx.q(kx.o(kx, this.ab), kx.o(kx.p(kx.h, kx), this.aa));
  }

  public kx j(ca A_0, kx A_1)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(this.i(A_1, A_0.fr()), this.x[index]);
  }

  public kx i(c3 A_0)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    return this.x[index];
  }

  public kx k(ca A_0, kx A_1)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(this.i(A_1, A_0.fr()), this.y[index]);
  }

  public kx j(c3 A_0)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    return this.y[index];
  }

  public kx l(ca A_0, kx A_1)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(this.i(A_1, A_0.fr()), this.z[index]);
  }

  public kx k(c3 A_0)
  {
    int index = A_0.f - 1;
    if (index < 0 || index >= 8)
      return kx.g;
    return this.z[index];
  }

  public kx j(float A_0)
  {
    return kx.o(kx.f((double) A_0), this.ac);
  }

  public kx k(float A_0)
  {
    return kx.o(kx.f((double) A_0), this.ac);
  }

  public kx l(float A_0)
  {
    return kx.o(kx.f((double) A_0), this.ae);
  }

  public kx i(en A_0, ab8 A_1)
  {
    kx ad = this.ad;
    kx A_0_1 = A_1.ia(A_0.s);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0_1.i() == 0L || ad.i() == 0L)
      return kx.g;
    return kx.o(A_0_1, ad).q();
  }

  public bool i(im.FurnitureDurabilityLossPlace A_0)
  {
    if (A_0 < im.FurnitureDurabilityLossPlace.Indoors || A_0 >= im.FurnitureDurabilityLossPlace.Num)
      return false;
    return this.r[(int) A_0];
  }

  public im.FurnitureDurabilityLossPlace i(j7 A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
  {
    if (A_1)
      return im.FurnitureDurabilityLossPlace.Indoors;
    // ISSUE: reference to a compiler-generated method
    if (A_0.a8())
      return im.FurnitureDurabilityLossPlace.Dungeons;
    if (A_3)
      return im.FurnitureDurabilityLossPlace.PlayerIsland;
    if (A_2)
      return im.FurnitureDurabilityLossPlace.GuildIsland;
    return A_4 && A_5 ? im.FurnitureDurabilityLossPlace.GuildTerritory : im.FurnitureDurabilityLossPlace.Outdoors;
  }

  public bool j(j7 A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
  {
    return this.i(this.i(A_0, A_1, A_2, A_3, A_4, A_5));
  }

  public bool y(XmlElement A_0)
  {
    if (A_0.Name != "DurabilityData")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "ItemBrokenState":
            if (!this.x(A_0_1))
              return false;
            continue;
          case "Durability":
            if (!this.s(A_0_1))
              return false;
            continue;
          case "DurabilityIndicators":
            if (!this.w(A_0_1))
              return false;
            continue;
          case "DurabilityLoss":
            if (!this.q(A_0_1))
              return false;
            continue;
          case "ItemLoss":
            if (!this.o(A_0_1))
              return false;
            continue;
          case "Repair":
            if (!this.n(A_0_1))
              return false;
            continue;
          case "Salvage":
            if (!this.l(A_0_1))
              return false;
            continue;
          case "RerollQuality":
            if (!this.j(A_0_1))
              return false;
            continue;
          case "ShowItemWarning":
            if (!this.v(A_0_1))
              return false;
            continue;
          case "MinCraftDurability":
            if (!this.u(A_0_1))
              return false;
            continue;
          case "MinDurabilityDecay":
            if (!this.t(A_0_1))
              return false;
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool x(XmlElement A_0)
  {
    if (A_0.Name != "ItemBrokenState")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'ItemBrokenState' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.m(aim.c(A_0, "percentunder", kx.j));
    return true;
  }

  private bool w(XmlElement A_0)
  {
    if (A_0.Name != "DurabilityIndicators")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityIndicators' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "trashhudcolor", acf.e()));
    // ISSUE: reference to a compiler-generated method
    this.i((byte) aim.b(A_0, "hudalpha", 0));
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "DurabilityIndicator":
            // ISSUE: reference to a compiler-generated method
            this.n().Add(new im.a(aim.b(A_0_1, "percentageaboveorequal", 0), aim.h(A_0_1, "spritename"), aim.a(A_0_1, "hudcolor", acf.e()), aim.a(A_0_1, "iconcolor", acf.e()), aim.a(A_0_1, "hidehud", false), aim.a(A_0_1, "itempowerreduction", 0.0f)));
            continue;
          default:
            continue;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.n().Sort();
    return true;
  }

  private bool v(XmlElement A_0)
  {
    if (A_0.Name != "ShowItemWarning")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'ShowItemWarning' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.l(aim.c(A_0, "percentunder", kx.j));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.j().i() >= 0L;
  }

  private bool u(XmlElement A_0)
  {
    if (A_0.Name != "MinCraftDurability")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'MinCraftDurability' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.k(aim.c(A_0, "minpercent", kx.j));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.k().i() >= 0L;
  }

  private bool t(XmlElement A_0)
  {
    if (A_0.Name != "MinDurabilityDecay")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'MinDurabilityDecay' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.j(aim.c(A_0, "minpercent", kx.j));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.l().i() >= 0L;
  }

  private bool s(XmlElement A_0)
  {
    if (A_0.Name != "Durability")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Durability' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Tools":
            aim.c(A_0_1, "durability", ref this.a);
            continue;
          case "Weapons":
            aim.c(A_0_1, "durability", ref this.b);
            continue;
          case "Armors":
            aim.c(A_0_1, "durability", ref this.c);
            continue;
          case "Mounts":
            aim.c(A_0_1, "durability", ref this.d);
            continue;
          case "Buildings":
            aim.c(A_0_1, "durability", ref this.e);
            continue;
          case "FurnitureItems":
            aim.c(A_0_1, "durability", ref this.g);
            continue;
          case "ConstructionSite":
            this.r(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool r(XmlElement A_0)
  {
    if (A_0.Name != "ConstructionSite")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'ConstructionSite' under XmlTag 'Durability' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.i(aim.b(A_0, "mindurability", kx.j));
    return true;
  }

  private bool q(XmlElement A_0)
  {
    if (A_0.Name != "DurabilityLoss")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityLoss' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "ToolUse":
            aim.c(A_0_1, "durabilityloss", ref this.h);
            continue;
          case "Attack":
            aim.c(A_0_1, "durabilityloss", ref this.i);
            continue;
          case "UseSpell":
            aim.c(A_0_1, "durabilityloss", ref this.j);
            continue;
          case "ArmorOnReceiveAttack":
            aim.a(A_0_1, "durabilityloss", ref this.k);
            continue;
          case "ArmorOnReceiveSpell":
            aim.c(A_0_1, "durabilityloss", ref this.l);
            continue;
          case "PerTimeBuilding":
            aim.c(A_0_1, "durabilityloss", ref this.m);
            continue;
          case "PerTimeFurnitureObject":
            aim.c(A_0_1, "durabilityloss", ref this.o);
            continue;
          case "PerUseFurnitureObject":
            aim.c(A_0_1, "durabilityloss", ref this.p);
            continue;
          case "BuildingOnCraftedItem":
            aim.c(A_0_1, "itemvaluefactor", ref this.q);
            continue;
          case "FurnitureObjectPerPlace":
            this.p(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private void p(XmlElement A_0)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        bool flag = aim.a(A_0_1, "decay", false);
        im.FurnitureDurabilityLossPlace durabilityLossPlace = aim.a<im.FurnitureDurabilityLossPlace>(A_0_1, "type", im.FurnitureDurabilityLossPlace.Num);
        if (durabilityLossPlace != im.FurnitureDurabilityLossPlace.Num)
          this.r[(int) durabilityLossPlace] = flag;
      }
    }
  }

  private bool o(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_1 = childNode as XmlElement;
      if (A_1 != null)
      {
        switch (A_1.Name)
        {
          case "AliveToDead":
            this.i(this.s[0], A_1);
            continue;
          case "AliveToKO":
            this.i(this.s[1], A_1);
            continue;
          case "KOToDead":
            this.i(this.s[2], A_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool i(im.c A_0, XmlElement A_1)
  {
    foreach (XmlNode childNode in A_1.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "DurabilityLoss":
            aim.b(A_0_1, "minpercent", ref A_0.b);
            aim.b(A_0_1, "maxpercent", ref A_0.c);
            aim.a(A_0_1, "minimumpercentremaining", ref A_0.d, kx.g);
            continue;
          case "Destroyed":
            aim.b(A_0_1, "percentage", ref A_0.a);
            continue;
          case "StackLoss":
            aim.b(A_0_1, "percentage", ref A_0.e);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool n(XmlElement A_0)
  {
    if (A_0.Name != "Repair")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Repair' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Items":
            this.m(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool m(XmlElement A_0)
  {
    if (A_0.Name != "Items")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/Repair' not found! Invalid Xml File?");
    this.t = kx.j;
    this.u = kx.j;
    this.v = kx.j;
    this.w = kx.j;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "CostFactors")
      {
        this.t = aim.c(A_0_1, "lower", kx.j);
        this.u = aim.c(A_0_1, "upper", kx.j);
      }
      else if (A_0_1 != null && A_0_1.Name == "Modifier")
        this.v = aim.c(A_0_1, "silver", kx.j);
      else if (A_0_1 != null && A_0_1.Name == "Time")
        this.w = aim.c(A_0_1, "crafttimefactor", kx.j);
    }
    return true;
  }

  private bool l(XmlElement A_0)
  {
    if (A_0.Name != "Salvage")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Repair' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Items":
            this.k(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool k(XmlElement A_0)
  {
    if (A_0.Name != "Items")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/Salvage' not found! Invalid Xml File?");
    this.aa = kx.j;
    this.ab = kx.j;
    this.ac = kx.j;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "RewardFactors":
            this.aa = aim.c(A_0_1, "lower", kx.j);
            this.ab = aim.c(A_0_1, "upper", kx.j);
            continue;
          case "Time":
            this.ac = aim.c(A_0_1, "crafttimefactor", kx.j);
            continue;
          case "GainFactors":
            aim.b(A_0_1, "resource", ref this.x);
            aim.b(A_0_1, "silver", ref this.y);
            aim.b(A_0_1, "gold", ref this.z);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool j(XmlElement A_0)
  {
    if (A_0.Name != "RerollQuality")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'RerollQuality' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Items":
            this.i(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private bool i(XmlElement A_0)
  {
    if (A_0.Name != "Items")
      throw new AlbionException("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/RerollQuality' not found! Invalid Xml File?");
    this.ad = kx.j;
    this.ae = kx.j;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "CostModifier":
            this.ad = aim.c(A_0_1, "silver", kx.j);
            continue;
          case "Time":
            this.ae = aim.c(A_0_1, "crafttimefactor", kx.j);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public class a : IComparable<im.a>
  {
    public a(int A_0, string A_1, acf A_2, acf A_3, bool A_4, float A_5)
    {
      // ISSUE: reference to a compiler-generated method
      this.g(A_0);
      // ISSUE: reference to a compiler-generated method
      this.g(A_1);
      // ISSUE: reference to a compiler-generated method
      this.h(A_2);
      // ISSUE: reference to a compiler-generated method
      this.g(A_3);
      // ISSUE: reference to a compiler-generated method
      this.g(A_4);
      // ISSUE: reference to a compiler-generated method
      this.g(A_5);
    }

    public int CompareTo(im.a other)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.g().CompareTo(other.g());
    }
  }

  private struct b : IComparable
  {
    public readonly kx a;
    public readonly kx b;

    public b(kx A_0, kx A_1)
    {
      this.a = A_0;
      this.b = A_1;
    }

    public int CompareTo(object obj)
    {
      if (!(obj is im.b))
        throw new ArgumentException();
      return this.a.CompareTo(((im.b) obj).a);
    }
  }

  public enum FurnitureDurabilityLossPlace
  {
    Indoors = 0,
    Outdoors = 1,
    Dungeons = 2,
    PlayerIsland = 3,
    GuildIsland = 4,
    GuildTerritory = 5,
    Invalid = 6,
    Num = 6,
  }

  public class c
  {
    public kx[] a = new kx[8];
    public kx[] b = new kx[8];
    public kx[] c = new kx[8];
    public kx[] d = new kx[8];
    public kx[] e = new kx[8];
  }

  public enum d
  {
    a,
    b,
    c,
    d,
  }
}
