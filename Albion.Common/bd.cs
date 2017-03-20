// Decompiled with JetBrains decompiler
// Type: bd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.SimulationObjects.AccessRights;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class bd
{
  public List<acb.TileGroundType> c = new List<acb.TileGroundType>();
  private List<bd.a> e = new List<bd.a>();
  public const string a = "none";
  public const string b = "T0_LOOTBAG_BUILDING";
  private List<du> d;
  protected static int f;

  [SpecialName]
  public virtual string bb()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.ec());
  }

  [SpecialName]
  public virtual string ca()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.ed());
  }

  [SpecialName]
  public ReadOnlyCollection<du> dx()
  {
    if (this.d == null)
      return (ReadOnlyCollection<du>) null;
    return this.d.AsReadOnly();
  }

  [SpecialName]
  public List<bd.a> d2()
  {
    return this.e;
  }

  public static void ci()
  {
    bd.f = 0;
    du.g();
  }

  public kx ba(j7 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_1 = A_0.br().ar();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 0L || this.dl().i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    if (A_1.i() == 10000L)
    {
      // ISSUE: reference to a compiler-generated method
      return this.dl();
    }
    // ISSUE: reference to a compiler-generated method
    return kx.n(this.dl(), A_1);
  }

  public du ct(string A_0)
  {
    if (this.d != null)
    {
      foreach (du du in this.d)
      {
        // ISSUE: reference to a compiler-generated method
        if (du.i() == A_0)
          return du;
      }
    }
    return (du) null;
  }

  public du cn(int A_0)
  {
    if (this.d != null)
    {
      foreach (du du in this.d)
      {
        // ISSUE: reference to a compiler-generated method
        if (du.h() == A_0)
          return du;
      }
    }
    return (du) null;
  }

  public bool cu(string A_0)
  {
    if (this.d != null)
    {
      foreach (du du in this.d)
      {
        // ISSUE: reference to a compiler-generated method
        if (du.i() == A_0)
          return true;
      }
    }
    return false;
  }

  public bool co(int A_0)
  {
    if (this.d != null)
    {
      foreach (du du in this.d)
      {
        // ISSUE: reference to a compiler-generated method
        if (du.h() == A_0)
          return true;
      }
    }
    return false;
  }

  public bool ba(acb.TileGroundType A_0)
  {
    return this.c.IndexOf(A_0) != -1;
  }

  public kx cv(string A_0)
  {
    foreach (bd.a a in this.e)
    {
      // ISSUE: reference to a compiler-generated method
      if (a.d() == A_0)
      {
        // ISSUE: reference to a compiler-generated method
        return a.e();
      }
    }
    return kx.g;
  }

  public string ba(kt A_0)
  {
    if (this.e == null || this.e.Count == 0)
      return string.Empty;
    if (this.e.Count == 1)
    {
      // ISSUE: reference to a compiler-generated method
      return this.e[0].d();
    }
    bd.a a = this.ba((float) A_0.cw(0.0, 1.0));
    if (a == null)
      return string.Empty;
    // ISSUE: reference to a compiler-generated method
    return a.d();
  }

  public int ee()
  {
    if (this.e == null)
      return 0;
    return this.e.Count;
  }

  private bd.a ba(float A_0)
  {
    foreach (bd.a a in this.e)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0 < (double) a.f())
        return a;
    }
    return (bd.a) null;
  }

  public virtual bool a4(XmlElement A_0, string A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.ck(bd.f++);
    string A_0_1 = aim.h(A_0, "uniquename");
    // ISSUE: reference to a compiler-generated method
    this.ck(string.IsNullOrEmpty(A_1) ? A_0_1 : A_1);
    // ISSUE: reference to a compiler-generated method
    this.cj(aim.h(A_0, "warningpopupstring"));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cq(aim.a(A_0, "tile", this.c9()));
    // ISSUE: reference to a compiler-generated method
    this.cr(aim.a(A_0, "namelocatag", "@BUILDINGS_" + A_0_1));
    // ISSUE: reference to a compiler-generated method
    this.cs(aim.a(A_0, "descriptionlocatag", "@BUILDINGS_" + A_0_1 + "_DESC"));
    // ISSUE: reference to a compiler-generated method
    this.cl(aim.b(A_0, "tier", 1));
    // ISSUE: reference to a compiler-generated method
    this.cv(aim.b(A_0, "placecost", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.a(A_0, "unlocked", false));
    // ISSUE: reference to a compiler-generated method
    this.cm(aim.c(A_0, "durability", kx.f(100.0)));
    // ISSUE: reference to a compiler-generated method
    this.cn(aim.c(A_0, "durabilityloss", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.c(A_0, "nutritionstorage", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.cq(aim.c(A_0, "nutritionloss", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.cr(aim.c(A_0, "craftcapacity", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.cs(aim.c(A_0, "craftcapacityregeneration", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.cl(aim.a(A_0, "category", "none"));
    // ISSUE: reference to a compiler-generated method
    this.cm(aim.b(A_0, "displaygroup", 0));
    // ISSUE: reference to a compiler-generated method
    this.ci(aim.a(A_0, "upgradeableto", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.a(A_0, "upgradestate", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.cn(A_0_1);
    // ISSUE: reference to a compiler-generated method
    this.co(aim.a(A_0, "iconAtlas", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "iconSprite", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.a(A_0, "hideonclustermap", false));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a<Preset>(A_0, "accessrightspreset", Preset.Public));
    // ISSUE: reference to a compiler-generated method
    this.ci(aim.a(A_0, "usesbuildingplacementrules", true));
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.a(A_0, "repaircostfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.a(A_0, "destructionreturnfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bb(Math.Min(this.d6(), 1f - this.d5()));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.a(A_0, "lootprefab", "T0_LOOTBAG_BUILDING"));
    // ISSUE: reference to a compiler-generated method
    this.ba(bv.h(A_0));
    this.bb(A_0);
    this.ba(A_0);
    XmlNodeList elementsByTagName1 = A_0.GetElementsByTagName("craftingrequirements");
    XmlElement A_0_2 = (XmlElement) null;
    foreach (object obj in elementsByTagName1)
    {
      A_0_2 = obj as XmlElement;
      if (A_0_2 != null)
        break;
    }
    if (A_0_2 != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ba(new aa9());
      // ISSUE: reference to a compiler-generated method
      this.dr().l(A_0_2);
    }
    XmlNodeList elementsByTagName2 = A_0.GetElementsByTagName("skins");
    if (elementsByTagName2.Count > 0 && elementsByTagName2[0].HasChildNodes)
    {
      this.d = new List<du>(elementsByTagName2[0].ChildNodes.Count);
      foreach (XmlNode childNode in elementsByTagName2[0].ChildNodes)
      {
        XmlElement A_0_3 = childNode as XmlElement;
        if (A_0_3 != null)
        {
          du du = new du();
          if (du.g(A_0_3))
            this.d.Add(du);
        }
      }
      this.d.TrimExcess();
    }
    return true;
  }

  protected void bb(XmlElement A_0)
  {
    this.c.Clear();
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("buildablegrounds");
    if (elementsByTagName.Count > 0)
    {
      foreach (object obj1 in elementsByTagName)
      {
        XmlElement xmlElement = obj1 as XmlElement;
        if (xmlElement != null)
        {
          foreach (object obj2 in (XmlNode) xmlElement)
          {
            XmlElement A_0_1 = obj2 as XmlElement;
            if (A_0_1 != null && A_0_1.Name == "buildableground")
            {
              acb.TileGroundType tileGroundType = aim.a<acb.TileGroundType>(A_0_1, "ground", ~acb.TileGroundType.Normal);
              if (tileGroundType != ~acb.TileGroundType.Normal && !this.c.Contains(tileGroundType))
                this.c.Add(tileGroundType);
            }
          }
        }
      }
    }
    else
      this.c.Add(acb.TileGroundType.BuildingArea);
  }

  private void ba(XmlElement A_0)
  {
    this.e = (List<bd.a>) null;
    XmlNodeList elementsByTagName1 = A_0_1.GetElementsByTagName("favoritedish");
    if (elementsByTagName1.Count == 0)
      return;
    XmlElement A_0_3 = elementsByTagName1[0] as XmlElement;
    if (A_0_3 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.ba(ahy.n(aim.b(A_0_3, "hourstoeval", 0)));
    int num1 = 0;
    XmlNodeList elementsByTagName2 = A_0_3.GetElementsByTagName("dish");
    this.e = new List<bd.a>(elementsByTagName2.Count);
    foreach (XmlElement A_0_2 in elementsByTagName2)
    {
      int num2 = aim.b(A_0_2, "weight", -1);
      if (num2 >= 0)
      {
        kx A_0_4 = aim.c(A_0_2, "bonus", kx.j);
        string A_0_5 = aim.a(A_0_2, "item", (string) null);
        bd.a a = new bd.a();
        // ISSUE: reference to a compiler-generated method
        a.d(A_0_5);
        // ISSUE: reference to a compiler-generated method
        a.d(A_0_4);
        // ISSUE: reference to a compiler-generated method
        a.d((float) num2);
        this.e.Add(a);
        num1 += num2;
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e.Sort((Comparison<bd.a>) ((A_0_2, A_1) => -A_0_2.f().CompareTo(A_1.f())));
    float num3 = 0.0f;
    foreach (bd.a a in this.e)
    {
      // ISSUE: reference to a compiler-generated method
      float num2 = a.f() / (float) num1;
      // ISSUE: reference to a compiler-generated method
      a.d(num3 + num2);
      // ISSUE: reference to a compiler-generated method
      num3 = a.f();
    }
    // ISSUE: reference to a compiler-generated method
    this.e[0].d(1f);
  }

  protected void ca(bd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ba(A_0);
  }

  public virtual void a9(g8 A_0)
  {
    bd bd1 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = kx.o(bd1.dk(), A_0.ar().jc().m(this.db()));
    // ISSUE: reference to a compiler-generated method
    bd1.cm(A_0_1);
    bd bd2 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_2 = kx.o(bd2.dl(), A_0.ar().jc().t(this.db()));
    // ISSUE: reference to a compiler-generated method
    bd2.cn(A_0_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.co(kx.o(A_0.ar().jc().l(), this.dk()));
    bd bd3 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_3 = kx.o(bd3.dn(), A_0.ar().ia(this.db()));
    // ISSUE: reference to a compiler-generated method
    bd3.cp(A_0_3);
    bd bd4 = this;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx A_0_4 = kx.o(bd4.@do(), A_0.ar().h9(this.db()));
    // ISSUE: reference to a compiler-generated method
    bd4.cq(A_0_4);
    this.bb(A_0);
    // ISSUE: reference to a compiler-generated method
    kx A_1_1 = this.ba(A_0, this.dr(), true);
    // ISSUE: reference to a compiler-generated method
    if (A_1_1.i() > 0L)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      kx A_1_2 = A_0.ar().jc().m();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ba(kx.n(kx.p(this.dk(), A_1_2), A_1_1));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kx.j(kx.q(kx.o(this.dz(), A_1_1), A_1_2), this.dk()))
      {
        bd bd5 = this;
        // ISSUE: reference to a compiler-generated method
        kx A_0_5 = kx.q(bd5.dz(), kx.f(1L));
        // ISSUE: reference to a compiler-generated method
        bd5.ba(A_0_5);
      }
      // ISSUE: reference to a compiler-generated method
      kx.q(kx.o(this.dz(), A_1_1), A_1_2);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bb(A_0.ap().hz(this.dv()));
    // ISSUE: reference to a compiler-generated method
    if (this.d3() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.d3().ca(this);
    }
    bv A_0_6 = new bv();
    bw A_0_7 = new bw();
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.eb()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0.a9().ad.ContainsKey(this.eb()))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_6 = A_0.a9().ad[this.eb()];
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0.a9().ae.ContainsKey(this.eb()))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_7 = A_0.a9().ae[this.eb()];
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.ba(A_0_6);
    // ISSUE: reference to a compiler-generated method
    this.ba(A_0_7);
  }

  protected void bb(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.cu(kx.g);
    // ISSUE: reference to a compiler-generated method
    this.ct(kx.g);
    // ISSUE: reference to a compiler-generated method
    if (this.dr() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cu(this.ba(A_0, this.dr(), false));
    // ISSUE: reference to a compiler-generated method
    this.cw(this.ca(A_0));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dr().l(this.dt(), A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ct(this.dr().m());
  }

  private kx ba(g8 A_0, aa9 A_1, bool A_2)
  {
    kx A_0_1 = kx.g;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.dr().p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          kx A_0_2 = b9.d4(A_0).o();
          // ISSUE: reference to a compiler-generated method
          if (A_2 && A_0_2.i() == 0L)
            A_0_2 = kx.h;
          A_0_1 = kx.q(A_0_1, kx.f(A_0_2, a.c));
        }
      }
    }
    return A_0_1;
  }

  public kx ca(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.d8().i() < 0L)
    {
      // ISSUE: reference to a compiler-generated method
      this.cw(this.ba(A_0));
    }
    // ISSUE: reference to a compiler-generated method
    return this.d8();
  }

  private kx ba(g8 A_0)
  {
    kx A_0_1 = kx.g;
    // ISSUE: reference to a compiler-generated method
    if (this.dr() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1 = kx.o(this.dr().m(), A_0.ar().i7());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.dr().p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          kx kx = kx.f(b9.cg(A_0), a.c);
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (this.dr().q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.dr().q()));
          }
          A_0_1 = kx.q(A_0_1, kx);
        }
      }
    }
    return A_0_1;
  }

  public Dictionary<b9, int> ba(kx A_0, abc A_1)
  {
    Dictionary<b9, int> A_0_1 = new Dictionary<b9, int>();
    this.ba(A_0_1, A_1);
    this.ba(A_0_1, A_0);
    return A_0_1;
  }

  public Dictionary<b9, int> bb(kx A_0, abc A_1)
  {
    Dictionary<b9, int> A_0_1 = new Dictionary<b9, int>();
    // ISSUE: reference to a compiler-generated method
    for (bd bd = this; bd != null; bd = bd.d4())
      bd.ba(A_0_1, A_1);
    this.ba(A_0_1, A_0);
    return A_0_1;
  }

  protected void ba(Dictionary<b9, int> A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num = this.d6() + this.d5() * (float) (A_1.m() / this.dk().m());
    foreach (b9 index in new List<b9>((IEnumerable<b9>) A_0.Keys))
      A_0[index] = (int) Math.Ceiling((double) A_0[index] * (double) num);
  }

  protected void ba(Dictionary<b9, int> A_0, abc A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || this.dr() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    foreach (aa9.a a in this.dr().p())
    {
      b9 key = A_1.hz(a.a, a.b);
      if (key != null)
      {
        if (A_0.ContainsKey(key))
        {
          Dictionary<b9, int> dictionary;
          b9 index;
          (dictionary = A_0)[index = key] = dictionary[index] + a.c;
        }
        else
          A_0.Add(key, a.c);
      }
    }
  }

  public class a
  {
  }
}
