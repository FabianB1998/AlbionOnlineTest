// Decompiled with JetBrains decompiler
// Type: c7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class c7 : c3, c6
{
  private static string a0 = "default";

  public c7(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.b(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.a(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.bv(false);
    // ISSUE: reference to a compiler-generated method
    this.b(false);
    // ISSUE: reference to a compiler-generated method
    this.a(false);
    // ISSUE: reference to a compiler-generated method
    this.b(c7.a0);
    // ISSUE: reference to a compiler-generated method
    this.a(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.a(1f);
    // ISSUE: reference to a compiler-generated method
    this.a(c7.Kind.Plant);
  }

  [SpecialName]
  public bool eg()
  {
    bool flag1 = false;
    // ISSUE: reference to a compiler-generated method
    if (this.d9() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      flag1 = this.d9().n() && (double) this.d9().m() >= 0.0;
    }
    bool flag2 = false;
    // ISSUE: reference to a compiler-generated method
    if (this.ea() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      flag2 = this.ea().p() && (double) this.ea().o() >= 0.0;
    }
    // ISSUE: reference to a compiler-generated method
    if ((double) this.eb() <= 0.0)
      return false;
    if (!flag1)
      return flag2;
    return true;
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.b(A_0, "placecost", this.d1()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.b(A_0, "placefame", this.d2()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.a(A_0, "pickupable", this.d3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "destroyable", this.d4()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "unlockedtoplace", this.d5()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "animationid", this.b3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a<c7.Kind>(A_0, "kind", this.d6()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.a(A_0, "activefarmfocuscost", this.eb()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "activefarmbonus", this.ec()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.b(A_0, "activefarmmaxcycles", this.ed()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "activefarmcyclelengthseconds", this.ee()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "activefarmactiondurationseconds", this.ef()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "prefabname", this.ei()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "prefabscale", this.ej()));
    // ISSUE: reference to a compiler-generated method
    if (this.d0() == null)
    {
      // ISSUE: reference to a compiler-generated method
      this.bv(this.d);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.a(A_0, "tile", this.d0()));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "consumption":
            this.d0(A_0_1);
            continue;
          case "harvest":
            this.cg(A_0_1);
            continue;
          case "grownitem":
            this.bv(A_0_1);
            continue;
          case "products":
            this.b(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    // ISSUE: reference to a compiler-generated method
    aa7 aa7 = A_0.ap();
    // ISSUE: reference to a compiler-generated method
    this.a(new List<int>());
    foreach (global::bd bd in (IEnumerable<global::bd>) aa7.h0())
    {
      c0 c0 = bd as c0;
      // ISSUE: reference to a compiler-generated method
      if (c0 != null && c0.ci().Contains(this.d))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.eh().Add(c0.c8());
      }
    }
  }

  private void d0(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new List<c7.d>());
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        c7.d d = this.a(A_0_1);
        if (d != null)
        {
          d.b8(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.d7().Add(d);
        }
      }
    }
  }

  private void cg(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new c7.a());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d9().h(aim.b(A_0, "growtime", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d9().h(aim.b(A_0, "fame", kx.j));
    string A_0_1 = aim.a(A_0, "lootlist", (string) null);
    float A_1 = aim.a(A_0, "lootchance", float.MinValue);
    d9 d9 = new d9();
    d9.n(A_0_1, A_1, 1f);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d9().h((d5) d9);
    if (A_0.ChildNodes.Count <= 0)
      return;
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_2 = obj as XmlElement;
      if (A_0_2 != null && A_0_2.Name == "seed")
      {
        float A_0_3 = aim.a(A_0_2, "chance", 1f);
        int A_3;
        int A_4;
        aim.a(A_0_2, "amount", 1, out A_3, out A_4);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.d9().h(A_0_3);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.d9().i(A_3);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.d9().j(A_4);
        break;
      }
    }
  }

  private void bv(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new c7.b());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ea().i(aim.a(A_0, "uniquename", (string) null));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ea().i(aim.b(A_0, "enchantmentlevel", 0));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ea().j(aim.b(A_0, "growtime", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ea().i(aim.b(A_0, "fame", kx.j));
    if (A_0.ChildNodes.Count <= 0)
      return;
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "offspring")
      {
        float A_0_2 = aim.a(A_0_1, "chance", 1f);
        int A_3;
        int A_4;
        aim.a(A_0_1, "amount", 1, out A_3, out A_4);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.ea().i(A_0_2);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.ea().k(A_3);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.ea().l(A_4);
      }
    }
  }

  private void b(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new List<c7.c>());
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "product")
      {
        c7.c c = new c7.c();
        // ISSUE: reference to a compiler-generated method
        c.f(aim.a(A_0_1, "actionname", string.Empty));
        // ISSUE: reference to a compiler-generated method
        c.f(aim.b(A_0_1, "productiontime", int.MinValue));
        // ISSUE: reference to a compiler-generated method
        c.f(aim.b(A_0_1, "fame", kx.j));
        string A_0_2 = aim.a(A_0_1, "lootlist", (string) null);
        float A_1 = aim.a(A_0_1, "lootchance", 1f);
        d9 d9 = new d9();
        d9.n(A_0_2, A_1, 1f);
        // ISSUE: reference to a compiler-generated method
        c.f((d5) d9);
        // ISSUE: reference to a compiler-generated method
        this.d8().Add(c);
      }
    }
  }

  private c7.d a(XmlElement A_0)
  {
    switch (A_0.Name)
    {
      case "food":
        return (c7.d) new c7.f();
      default:
        return (c7.d) null;
    }
  }

  public abc.Placeability b4()
  {
    return abc.Placeability.Indoor;
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
    // ISSUE: reference to a compiler-generated method
    return this.d1();
  }

  protected d5 b(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.d9() == null || !this.d9().n())
      return (d5) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.a(this.d9().m(), this.d9().k(), this.d9().l(), A_0);
  }

  protected d5 bv(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ea() == null || !this.ea().p())
      return (d5) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.a(this.ea().o(), this.ea().m(), this.ea().n(), A_0);
  }

  protected d5 a(float A_0, int A_1, int A_2, int A_3)
  {
    float num = 0.0f;
    if (A_3 > 0)
    {
      // ISSUE: reference to a compiler-generated method
      num = (float) A_3 * this.ec();
    }
    float A_3_1 = A_0 + num;
    if ((double) A_3_1 <= 0.0)
      return (d5) null;
    d8 d8 = new d8();
    d8.n(this.d, A_1, A_2, A_3_1, 1f);
    ec ec = new ec();
    ec.n(new List<d5>(1) { (d5) d8 }, 1f, 1f);
    return (d5) ec;
  }

  public List<c7.e> a(GameTimeStamp A_0, int A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.d9() == null || !this.d9().n())
      return (List<c7.e>) null;
    d5 A_0_1 = this.b(A_1);
    if (A_0_1 == null)
      return (List<c7.e>) null;
    return this.a(A_0_1, A_0, A_1, A_2);
  }

  protected List<c7.e> a(d5 A_0, GameTimeStamp A_1, int A_2, g8 A_3)
  {
    return c7.a(A_0, A_1, 1f, false, 1f, A_3);
  }

  public static List<c7.e> a(d5 A_0, GameTimeStamp A_1, float A_2, bool A_3, float A_4, g8 A_5)
  {
    k3 k3 = new k3((int) A_1.Ticks);
    // ISSUE: reference to a compiler-generated method
    List<d5> d5List = A_5.at().hz(A_0, (kt) k3);
    if (d5List == null)
      return (List<c7.e>) null;
    // ISSUE: reference to a compiler-generated method
    abc abc = A_5.an();
    List<c7.e> eList = new List<c7.e>();
    foreach (d5 d5 in d5List)
    {
      d8 d8 = d5 as d8;
      if (d8 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        b9 A_0_1 = abc.hz(d8.n(), d8.o());
        if (A_0_1 != null)
        {
          int num1 = k3.Next(d8.p(), d8.q());
          if ((double) A_4 != 1.0)
            num1 = (int) Math.Round((double) num1 * (double) A_4);
          int num2 = 0;
          int A_3_1 = 0;
          if ((double) A_2 != 1.0 && A_0_1 is c3 && !(A_0_1 is c7))
          {
            int num3 = k3.cy((float) num1 * A_2);
            if (A_3)
              num2 = num3 - num1;
            else
              A_3_1 = num3 - num1;
          }
          c3 c3 = A_0_1 as c3;
          if (c3 != null)
          {
            for (int index = 0; index < eList.Count; ++index)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (eList[index].f().c == A_0_1.c && eList[index].j() < c3.ek())
              {
                // ISSUE: reference to a compiler-generated method
                int num3 = Math.Min(num2, c3.ek() - eList[index].j());
                if (num3 > 0)
                {
                  num2 -= num3;
                  c7.e e = eList[index];
                  // ISSUE: reference to a compiler-generated method
                  int A_0_2 = e.h() + num3;
                  // ISSUE: reference to a compiler-generated method
                  e.g(A_0_2);
                }
                // ISSUE: reference to a compiler-generated method
                int num4 = Math.Min(num1, c3.ek() - eList[index].j());
                if (num4 > 0)
                {
                  num1 -= num4;
                  c7.e e = eList[index];
                  // ISSUE: reference to a compiler-generated method
                  int A_0_2 = e.g() + num4;
                  // ISSUE: reference to a compiler-generated method
                  e.f(A_0_2);
                }
                c7.e e1 = eList[index];
                // ISSUE: reference to a compiler-generated method
                int A_0_3 = e1.i() + A_3_1;
                // ISSUE: reference to a compiler-generated method
                e1.h(A_0_3);
                A_3_1 = 0;
              }
            }
          }
          if (num1 + num2 + A_3_1 > 0)
          {
            c7.e e = new c7.e(A_0_1, num1, num2, A_3_1);
            eList.Add(e);
          }
        }
      }
    }
    return eList;
  }

  public void a(GameTimeStamp A_0, int A_1, g8 A_2, out List<string> A_3, out List<int> A_4)
  {
    A_3 = (List<string>) null;
    A_4 = (List<int>) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ea() == null || !this.ea().p())
      return;
    d5 A_0_1 = this.bv(A_1);
    if (A_0_1 == null)
      return;
    c7.a(A_0_1, A_0, A_2, out A_3, out A_4);
  }

  protected static void a(d5 A_0, GameTimeStamp A_1, g8 A_2, out List<string> A_3, out List<int> A_4)
  {
    k3 k3 = new k3((int) A_1.Ticks);
    // ISSUE: reference to a compiler-generated method
    List<d5> d5List = A_2.at().hz(A_0, (kt) k3);
    A_3 = new List<string>(d5List.Count);
    A_4 = new List<int>(d5List.Count);
    // ISSUE: reference to a compiler-generated method
    abc abc = A_2.an();
    foreach (d5 d5 in d5List)
    {
      d8 d8 = d5 as d8;
      if (d8 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        b9 b9 = abc.hz(d8.n(), d8.o());
        if (b9 != null)
        {
          int num = k3.Next(d8.p(), d8.q());
          for (int index1 = 0; index1 < A_3.Count; ++index1)
          {
            if (A_3[index1] == b9.d)
            {
              List<int> intList;
              int index2;
              (intList = A_4)[index2 = index1] = intList[index2] + num;
              num = 0;
              break;
            }
          }
          if (num > 0)
          {
            A_3.Add(b9.d);
            A_4.Add(num);
          }
        }
      }
    }
  }

  public enum Kind
  {
    Plant = 0,
    Animal = 1,
    Count = 2,
    Invalid = 2,
  }

  public class a
  {
    [SpecialName]
    public bool n()
    {
      // ISSUE: reference to a compiler-generated method
      return this.l() > 0;
    }
  }

  public class b
  {
    [SpecialName]
    public bool p()
    {
      // ISSUE: reference to a compiler-generated method
      return this.n() > 0;
    }
  }

  public class c
  {
    [SpecialName]
    public string i()
    {
      // ISSUE: reference to a compiler-generated method
      return kr.b(this.j());
    }
  }

  public abstract class d
  {
    public abstract bool b8(XmlElement A_0);

    public abstract bool b9(b9 A_0);
  }

  public class e
  {
    public e(b9 A_0, int A_1)
    {
      // ISSUE: reference to a compiler-generated method
      this.f(A_0);
      // ISSUE: reference to a compiler-generated method
      this.f(A_1);
    }

    public e(b9 A_0, int A_1, int A_2, int A_3)
    {
      // ISSUE: reference to a compiler-generated method
      this.f(A_0);
      // ISSUE: reference to a compiler-generated method
      this.f(A_1);
      // ISSUE: reference to a compiler-generated method
      this.g(A_2);
      // ISSUE: reference to a compiler-generated method
      this.h(A_3);
    }

    [SpecialName]
    public int j()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.g() + this.h();
    }
  }

  public class f : c7.d
  {
    public List<string> a;
    public kx b;
    public kx c;

    public override bool b8(XmlElement A_0)
    {
      this.b = aim.b(A_0, "nutritionmax", kx.j);
      this.c = aim.c(A_0, "secondspernutrition", kx.j);
      this.a = new List<string>();
      foreach (object obj in (XmlNode) A_0)
      {
        XmlElement A_0_1 = obj as XmlElement;
        if (A_0_1 != null && A_0_1.Name == "acceptedfood")
        {
          string str = aim.a(A_0_1, "foodcategory", (string) null);
          if (!string.IsNullOrEmpty(str))
            this.a.Add(str);
        }
      }
      return true;
    }

    public override bool b9(b9 A_0)
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0.v.i() <= 0L)
        return false;
      return this.a.Contains(A_0.w);
    }
  }
}
