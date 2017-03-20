// Decompiled with JetBrains decompiler
// Type: ep
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.SimulationObjects.AccessRights;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

public class ep : ca, c6
{
  private static string bw = "default";

  public ep(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.b(0);
    // ISSUE: reference to a compiler-generated method
    this.bv(kx.g);
    // ISSUE: reference to a compiler-generated method
    this.b(kx.h);
    // ISSUE: reference to a compiler-generated method
    this.b(ep.bw);
    // ISSUE: reference to a compiler-generated method
    this.a(global::b2.FurnitureType.None);
    // ISSUE: reference to a compiler-generated method
    this.a(global::b2.LaborerType.None);
    // ISSUE: reference to a compiler-generated method
    this.a(1);
    // ISSUE: reference to a compiler-generated method
    this.a(kx.g);
    // ISSUE: reference to a compiler-generated method
    this.a(Preset.Closed);
    // ISSUE: reference to a compiler-generated method
    this.a(false);
    // ISSUE: reference to a compiler-generated method
    this.a(abc.Placeability.Nowhere);
  }

  [SpecialName]
  public override bool bv()
  {
    return true;
  }

  [SpecialName]
  public ep.c ed()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ec() as ep.c;
  }

  [SpecialName]
  public ep.d ee()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ec() as ep.d;
  }

  [SpecialName]
  public ep.b ef()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ec() as ep.b;
  }

  [SpecialName]
  public ep.e eg()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ec() as ep.e;
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "tile", this.d));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.b(A_0, "residencyslots", this.d5()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.c(A_0, "durabilitylossperdayfactor", this.d1()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.c(A_0, "durabilitylossperusefactor", this.d2()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "animationid", this.b3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a<global::b2.FurnitureType>(A_0, "labourerfurnituretype", this.d6()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a<global::b2.LaborerType>(A_0, "labourersaffected", this.d7()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.b(A_0, "labourersperfurnitureitem", this.d8()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.c(A_0, "labourerhappiness", this.d9()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a<Preset>(A_0, "accessrightspreset", this.ea()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "customizewithguildlogo", this.d4()));
    // ISSUE: reference to a compiler-generated method
    bool flag1 = aim.a(A_0, "placeableindoors", (this.d0() & abc.Placeability.Indoor) != abc.Placeability.Nowhere);
    // ISSUE: reference to a compiler-generated method
    bool flag2 = aim.a(A_0, "placeableoutdoors", (this.d0() & abc.Placeability.Outdoor) != abc.Placeability.Nowhere);
    // ISSUE: reference to a compiler-generated method
    bool flag3 = aim.a(A_0, "placeableindungeons", (this.d0() & abc.Placeability.Dungeons) != abc.Placeability.Nowhere);
    // ISSUE: reference to a compiler-generated method
    this.a(abc.Placeability.Nowhere);
    if (flag1)
    {
      ep ep = this;
      // ISSUE: reference to a compiler-generated method
      int num = (int) (ep.d0() | abc.Placeability.Indoor);
      // ISSUE: reference to a compiler-generated method
      ep.a((abc.Placeability) num);
    }
    if (flag2)
    {
      ep ep = this;
      // ISSUE: reference to a compiler-generated method
      int num = (int) (ep.d0() | abc.Placeability.Outdoor);
      // ISSUE: reference to a compiler-generated method
      ep.a((abc.Placeability) num);
    }
    if (flag3)
    {
      ep ep = this;
      // ISSUE: reference to a compiler-generated method
      int num = (int) (ep.d0() | abc.Placeability.Dungeons);
      // ISSUE: reference to a compiler-generated method
      ep.a((abc.Placeability) num);
    }
    List<XmlElement> xmlElementList1 = aim.d(A_0, "container");
    if (xmlElementList1 != null && xmlElementList1.Count > 0)
    {
      foreach (XmlElement A_0_1 in xmlElementList1)
      {
        if (A_0_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.a((ep.a) new ep.c());
          // ISSUE: reference to a compiler-generated method
          this.ec().ci(A_0_1);
        }
      }
    }
    List<XmlElement> xmlElementList2 = aim.d(A_0, "buffprovider");
    if (xmlElementList2 != null && xmlElementList2.Count > 0)
    {
      foreach (XmlElement A_0_1 in xmlElementList2)
      {
        if (A_0_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.a((ep.a) new ep.d());
          // ISSUE: reference to a compiler-generated method
          this.ec().ci(A_0_1);
        }
      }
    }
    List<XmlElement> xmlElementList3 = aim.d(A_0, "repairkit");
    if (xmlElementList3 != null && xmlElementList3.Count > 0)
    {
      foreach (XmlElement A_0_1 in xmlElementList3)
      {
        if (A_0_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.a((ep.a) new ep.b());
          // ISSUE: reference to a compiler-generated method
          this.ec().ci(A_0_1);
        }
      }
    }
    List<XmlElement> xmlElementList4 = aim.d(A_0, "cheatprovider");
    if (xmlElementList4 != null && xmlElementList4.Count > 0)
    {
      foreach (XmlElement A_0_1 in xmlElementList4)
      {
        if (A_0_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.a((ep.a) new ep.e());
          // ISSUE: reference to a compiler-generated method
          this.ec().ci(A_0_1);
        }
      }
    }
    return true;
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    ep ep1 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = kx.o(ep1.fr(), A_0.ar().jc().n(this.f));
    // ISSUE: reference to a compiler-generated method
    ep1.d0(A_0_1);
    ep ep2 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_2 = kx.o(ep2.d1(), A_0.ar().jc().u(this.f));
    // ISSUE: reference to a compiler-generated method
    ep2.bv(A_0_2);
    ep ep3 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_3 = kx.o(ep3.d2(), A_0.ar().jc().v(this.f));
    // ISSUE: reference to a compiler-generated method
    ep3.b(A_0_3);
    this.a(A_0);
  }

  public abc.Placeability b4()
  {
    // ISSUE: reference to a compiler-generated method
    return this.d0();
  }

  public bool b5()
  {
    return true;
  }

  public string b6()
  {
    return this.d;
  }

  public kx b7()
  {
    return kx.g;
  }

  public abstract class a
  {
    public abstract bool ci(XmlElement A_0);
  }

  public class b : ep.a
  {
    public override bool ci(XmlElement A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(aim.c(A_0, "repaircostfactor", kx.h));
      // ISSUE: reference to a compiler-generated method
      this.o(aim.b(A_0, "maxtier", int.MaxValue));
      return true;
    }
  }

  public class c : ep.a
  {
    [SpecialName]
    public bool q()
    {
      // ISSUE: reference to a compiler-generated method
      return this.r().Length == 0;
    }

    public override bool ci(XmlElement A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(aim.b(A_0, "capacity", 10));
      // ISSUE: reference to a compiler-generated method
      this.o(aim.a(A_0, "weightlimit", float.NaN));
      XmlNodeList elementsByTagName = A_0.GetElementsByTagName("alloweditem");
      // ISSUE: reference to a compiler-generated method
      this.o(new string[elementsByTagName.Count]);
      for (int index = 0; index < elementsByTagName.Count; ++index)
      {
        XmlElement A_0_1 = (XmlElement) elementsByTagName[index];
        // ISSUE: reference to a compiler-generated method
        this.r()[index] = aim.h(A_0_1, "name");
      }
      return true;
    }
  }

  public class d : ep.a
  {
    public override bool ci(XmlElement A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(aim.b(A_0, "charges", 1));
      // ISSUE: reference to a compiler-generated method
      this.o(ahy.l((double) aim.a(A_0, "rechargetimeseconds", 60f)));
      // ISSUE: reference to a compiler-generated method
      this.r(aim.h(A_0, "buffspell"));
      // ISSUE: reference to a compiler-generated method
      this.o(aim.a(A_0, "abilitypower", 100f));
      // ISSUE: reference to a compiler-generated method
      this.q(aim.h(A_0, "usebuttontext"));
      // ISSUE: reference to a compiler-generated method
      this.p(aim.h(A_0, "nextchargereadytext"));
      // ISSUE: reference to a compiler-generated method
      this.o(aim.h(A_0, "chargesreadytext"));
      List<int> intList = new List<int>();
      foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Charge"))
      {
        string s = aim.a(A_0_1, "level", "0");
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
        while (intList.Count < num2 + 1)
          intList.Add(0);
        int num3 = aim.b(A_0_1, "gfxstate", 0);
        for (int index = num1; index <= num2; ++index)
          intList[index] = num3;
      }
      // ISSUE: reference to a compiler-generated method
      this.o(intList.ToArray());
      return true;
    }
  }

  public class e : ep.a
  {
    public override bool ci(XmlElement A_0)
    {
      return true;
    }
  }
}
