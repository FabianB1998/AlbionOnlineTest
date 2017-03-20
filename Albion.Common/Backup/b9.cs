// Decompiled with JetBrains decompiler
// Type: b9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public abstract class b9
{
  protected static int c = 0;
  protected static string d = "descvariable";
  protected static int e = b9.d.Length;
  protected static string[] f = new string[0];

  public int c { get; protected set; }

  public string d { get; protected set; }

  public string e
  {
    get
    {
      return kr.a(this.aj, (object[]) this.gu());
    }
  }

  public int f { get; private set; }

  public float g { get; private set; }

  public int h { get; private set; }

  public b8 i { get; protected set; }

  public string j
  {
    get
    {
      return this.i.d();
    }
  }

  public aa9 k { get; private set; }

  public aa9[] l { get; private set; }

  public bf m { get; private set; }

  public string n { get; private set; }

  public string o { get; private set; }

  public string p { get; private set; }

  public string q { get; private set; }

  public kx r { get; protected set; }

  public kx s { get; protected set; }

  public kx t { get; protected set; }

  public kx u { get; protected set; }

  public kx v { get; private set; }

  public string w { get; private set; }

  public bool x { get; protected set; }

  public bool y { get; protected set; }

  public kx z { get; private set; }

  public kx aa { get; private set; }

  public kx ab { get; private set; }

  public string ac
  {
    get
    {
      return kr.a(this.ak, (object[]) this.gu());
    }
  }

  public string ad { get; private set; }

  public string ae { get; protected set; }

  public bv af { get; protected set; }

  public bw ag { get; private set; }

  public string ah { get; protected set; }

  public virtual bool ai
  {
    get
    {
      return false;
    }
  }

  protected string aj { get; set; }

  protected string ak { get; set; }

  protected List<string> al { get; set; }

  protected string[] am { get; set; }

  public b9(b8 A_0)
  {
    this.c = int.MinValue;
    this.i = A_0;
    this.r = kx.j;
    this.s = kx.j;
    this.ab = kx.j;
    this.t = kx.j;
    this.u = kx.j;
    this.v = kx.g;
    this.w = string.Empty;
    this.y = false;
    this.z = kx.h;
    this.aa = kx.h;
    this.ad = (string) null;
    this.ae = (string) null;
    this.al = (List<string>) null;
    this.x = true;
    this.ah = string.Empty;
  }

  public virtual b9 cg()
  {
    b9 b9 = (b9) this.MemberwiseClone();
    b9.c = b9.c++;
    return b9;
  }

  public static void d0()
  {
    b9.c = 0;
  }

  public bool d1(XmlElement A_0)
  {
    if (this.c < 0)
      this.c = b9.c++;
    if (!this.ch(A_0))
      return false;
    return this.bc(A_0);
  }

  protected virtual bool ch(XmlElement A_0)
  {
    this.aj = b9.b(this.j);
    this.ak = b9.a(this.j);
    this.f = aim.b(A_0, "tier", 1);
    this.q = aim.h(A_0, "resourcetype");
    this.n = aim.h(A_0, "shopcategory");
    this.o = aim.h(A_0, "shopsubcategory1");
    this.p = aim.h(A_0, "shopsubcategory2");
    return true;
  }

  public virtual bool bc(XmlElement A_0)
  {
    this.h = aim.b(A_0, "enchantmentlevel", this.h);
    this.d = b8.d(this.i, this.h);
    this.aj = aim.a(A_0, "namelocatag", this.aj);
    this.ak = aim.a(A_0, "descriptionlocatag", this.ak);
    this.d2(A_0);
    this.g = aim.a(A_0, "weight", this.g);
    this.v = aim.b(A_0, "nutrition", this.v);
    this.w = aim.a(A_0, "foodcategory", this.w);
    this.y = aim.a(A_0, "unlockedtocraft", this.y);
    this.z = aim.c(A_0, "gatherfamegainfactor", this.z);
    this.aa = aim.c(A_0, "craftfamegainfactor", this.aa);
    this.x = aim.a(A_0, "showinmarketplace", this.x);
    this.ab = aim.c(A_0, "famevalue", this.ab);
    this.r = aim.c(A_0, "resourcevalue", this.r);
    this.s = aim.c(A_0, "itemvalue", this.s);
    this.ad = aim.a(A_0, "uiatlas", this.ad);
    if (this.ae == null)
      this.ae = this.j.Substring(3);
    this.ae = aim.a(A_0, "uisprite", this.ae);
    this.b(A_0);
    this.a(A_0);
    string str = bv.h(A_0);
    if (!string.IsNullOrEmpty(str))
      this.ah = str;
    return this.h >= 0 && this.h <= 3;
  }

  private void b(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "craftingrequirements");
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      List<aa9> aa9List = new List<aa9>();
      foreach (XmlElement A_0_1 in xmlElementList)
      {
        aa9 aa9 = new aa9();
        aa9.l(A_0_1);
        aa9List.Add(aa9);
      }
      this.l = aa9List.ToArray();
      if (this.l.Length > 0)
        this.k = this.l[0];
    }
    if (this.l != null)
      return;
    this.l = new aa9[0];
  }

  private void a(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "upgraderequirements");
    if (xmlElementList == null || xmlElementList.Count <= 0)
      return;
    this.m = new bf();
    this.m.f(xmlElementList[0]);
  }

  public string gr()
  {
    return this.aj;
  }

  public string gs()
  {
    return this.ak;
  }

  public List<string> gt()
  {
    return this.al;
  }

  protected void d2(XmlElement A_0)
  {
    this.am = b9.f;
    for (int index = 0; index < A_0.Attributes.Count; ++index)
    {
      XmlAttribute attribute = A_0.Attributes[index];
      if (attribute.Name.StartsWith("descvariable"))
      {
        int result = -1;
        if (int.TryParse(attribute.Name.Substring(b9.e), out result) && result >= 0)
        {
          if (this.al == null)
            this.al = new List<string>();
          while (this.al.Count <= result)
            this.al.Add(string.Empty);
          this.al[result] = attribute.Value;
        }
      }
    }
    if (this.al == null)
      return;
    this.al.TrimExcess();
    this.am = new string[this.al.Count];
    for (int index = 0; index < this.am.Length; ++index)
      this.am[index] = string.Empty;
  }

  protected static string b(string A_0)
  {
    return "@ITEMS_" + A_0;
  }

  protected static string a(string A_0)
  {
    return "@ITEMS_" + A_0 + "_DESC";
  }

  public string[] gu()
  {
    if (this.al != null)
    {
      for (int index = 0; index < this.al.Count; ++index)
        this.am[index] = kr.b(this.al[index]);
    }
    return this.am;
  }

  public virtual void bd(g8 A_0)
  {
    this.r = this.d0(A_0);
    this.s = this.cg(A_0);
    this.ab = this.d1(A_0);
    this.t = this.d2(A_0);
    this.u = this.d3(A_0);
    if (!string.IsNullOrEmpty(this.ah))
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0.a9().ad.ContainsKey(this.ah))
      {
        // ISSUE: reference to a compiler-generated method
        this.af = A_0.a9().ad[this.ah];
      }
      // ISSUE: reference to a compiler-generated method
      if (A_0.a9().ae.ContainsKey(this.ah))
      {
        // ISSUE: reference to a compiler-generated method
        this.ag = A_0.a9().ae[this.ah];
      }
    }
    if (this.af == null)
      this.af = new bv();
    if (this.ag != null)
      return;
    this.ag = new bw();
  }

  public kx cg(g8 A_0)
  {
    if (kx.m(this.s, kx.j))
      this.s = this.bv(A_0);
    return this.s;
  }

  public kx d0(g8 A_0)
  {
    if (kx.m(this.r, kx.j))
      this.r = this.d4(A_0);
    return this.r;
  }

  public kx d1(g8 A_0)
  {
    if (kx.m(this.ab, kx.j))
      this.ab = this.d5(A_0);
    return this.ab;
  }

  public kx d2(g8 A_0)
  {
    if (kx.m(this.t, kx.j))
      this.t = this.b(A_0).o();
    return this.t;
  }

  public kx d3(g8 A_0)
  {
    if (kx.m(this.u, kx.j))
      this.u = this.a(A_0).o();
    return this.u;
  }

  public kx d4(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.r.i() < 0L)
      this.r = this.d4(A_0, new HashSet<string>());
    return this.r;
  }

  private kx d5(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.r.i() < 0L)
      this.r = this.d4(A_0, A_1);
    return this.r;
  }

  private kx d4(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    hj hj = A_0.aw().h1(this.q);
    if (hj != null)
      return hj.d(this.f);
    kx A_0_1 = kx.g;
    if (this.k != null)
    {
      A_1.Add(this.d);
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.k.p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          if (A_1.Contains(b9.d))
            throw new AlbionException("cyclic dependency in craft requirements, current item '" + b9.d + "'");
          kx kx = kx.f(b9.d5(A_0, A_1), a.c);
          // ISSUE: reference to a compiler-generated method
          if (this.k.q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.k.q()));
          }
          A_0_1 = kx.q(A_0_1, kx);
        }
      }
      A_1.Remove(this.d);
    }
    return A_0_1;
  }

  private kx bv(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.s.i() < 0L)
      this.s = this.d2(A_0, new HashSet<string>());
    return this.s;
  }

  private kx d3(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.s.i() < 0L)
      this.s = this.d2(A_0, A_1);
    return this.s;
  }

  private kx d2(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.aw().h1(this.q) != null)
    {
      kx A_0_1 = this.d4(A_0);
      // ISSUE: reference to a compiler-generated method
      return A_0.ar().ic(A_0_1);
    }
    kx A_0_2 = kx.g;
    if (this.k != null)
    {
      A_1.Add(this.d);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_2 = kx.o(this.k.m(), A_0.ar().i7());
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.k.p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          if (A_1.Contains(b9.d))
            throw new AlbionException("cyclic dependency in craft requirements, current item '" + b9.d + "'");
          kx kx = kx.f(b9.d3(A_0, A_1), a.c);
          // ISSUE: reference to a compiler-generated method
          if (this.k.q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.k.q()));
          }
          A_0_2 = kx.q(A_0_2, kx);
        }
      }
      A_1.Remove(this.d);
    }
    return A_0_2;
  }

  public kx d5(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ab.i() < 0L)
      this.ab = this.d0(A_0, new HashSet<string>());
    return this.ab;
  }

  private kx d1(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ab.i() < 0L)
      this.ab = this.d0(A_0, A_1);
    return this.ab;
  }

  private kx d0(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    hj hj = A_0.aw().h1(this.q);
    if (hj != null)
      return hj.e(this.f);
    kx A_0_1 = kx.g;
    if (this.k != null)
    {
      A_1.Add(this.d);
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.k.p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          if (A_1.Contains(b9.d))
            throw new AlbionException("cyclic dependency in craft requirements, current item '" + b9.d + "'");
          kx kx = kx.f(b9.d1(A_0, A_1), a.c);
          // ISSUE: reference to a compiler-generated method
          if (this.k.q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.k.q()));
          }
          A_0_1 = kx.q(A_0_1, kx);
        }
      }
      A_1.Remove(this.d);
    }
    return A_0_1;
  }

  private kx b(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.t.i() < 0L)
      this.t = this.bv(A_0, new HashSet<string>());
    return this.t;
  }

  private kx cg(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.t.i() < 0L)
      this.t = this.bv(A_0, A_1);
    return this.t;
  }

  private kx bv(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.aw().h1(this.q) != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return kx.o(this.bv(A_0), A_0.ar().jc().w(this.f));
    }
    kx A_0_1 = kx.g;
    if (this.k != null)
    {
      A_1.Add(this.d);
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.k.p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          if (A_1.Contains(b9.d))
            throw new AlbionException("cyclic dependency in craft requirements, current item '" + b9.d + "'");
          kx kx = kx.f(b9.cg(A_0, A_1), a.c);
          // ISSUE: reference to a compiler-generated method
          if (this.k.q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.k.q()));
          }
          A_0_1 = kx.q(A_0_1, kx);
        }
      }
      A_1.Remove(this.d);
    }
    return A_0_1;
  }

  private kx a(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.u.i() < 0L)
      this.u = this.a(A_0, new HashSet<string>());
    return this.u;
  }

  private kx b(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.u.i() < 0L)
      this.u = this.a(A_0, A_1);
    return this.u;
  }

  private kx a(g8 A_0, HashSet<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.aw().h1(this.q) != null)
    {
      kx A_0_1 = this.bv(A_0);
      // ISSUE: reference to a compiler-generated method
      return A_0.ar().id(A_0_1);
    }
    kx A_0_2 = kx.g;
    if (this.k != null)
    {
      A_1.Add(this.d);
      // ISSUE: reference to a compiler-generated method
      foreach (aa9.a a in this.k.p())
      {
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_0.an().hz(a.a, a.b);
        if (b9 != null)
        {
          if (A_1.Contains(b9.d))
            throw new AlbionException("cyclic dependency in craft requirements, current item '" + b9.d + "'");
          kx kx = kx.f(b9.b(A_0, A_1), a.c);
          // ISSUE: reference to a compiler-generated method
          if (this.k.q() != 1)
          {
            // ISSUE: reference to a compiler-generated method
            kx = kx.n(kx, kx.g((long) this.k.q()));
          }
          A_0_2 = kx.q(A_0_2, kx);
        }
      }
      A_1.Remove(this.d);
    }
    return A_0_2;
  }
}
