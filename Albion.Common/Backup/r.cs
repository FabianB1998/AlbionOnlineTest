// Decompiled with JetBrains decompiler
// Type: r
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class r
{
  private static int a;

  [SpecialName]
  public int o()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.n() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.n().i().d();
    }
    // ISSUE: reference to a compiler-generated method
    if (this.l() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.l().Count;
    }
    return 0;
  }

  public static void h()
  {
    r.a = 0;
  }

  public bool h(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h(r.a++);
    // ISSUE: reference to a compiler-generated method
    this.h(aim.h(A_0, "id"));
    this.i(aim.e(A_0, "parentachievements"));
    if (A_0.Name == "achievement")
      this.j(aim.e(A_0, "masterylevels"));
    else if (A_0.Name == "templateachievement")
      this.k(A_0);
    return true;
  }

  protected void i(XmlElement A_0)
  {
    if (A_0 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "allrequired", false));
    // ISSUE: reference to a compiler-generated method
    this.h(new HashSet<string>());
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        string str = aim.a(A_0_1, "id", string.Empty);
        if (!string.IsNullOrEmpty(str))
        {
          // ISSUE: reference to a compiler-generated method
          this.m().Add(str);
        }
      }
    }
  }

  protected void j(XmlElement A_0)
  {
    if (A_0 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.h(new List<v>(A_0.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "masterylevel")
      {
        // ISSUE: reference to a compiler-generated method
        v v = v.i(this, this.l().Count);
        v.i(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.l().Add(v);
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.l().Count != 0)
      return;
    // ISSUE: reference to a compiler-generated method
    v v1 = v.i(this, this.l().Count);
    v1.q();
    // ISSUE: reference to a compiler-generated method
    this.l().Capacity = 1;
    // ISSUE: reference to a compiler-generated method
    this.l().Add(v1);
  }

  protected void k(XmlElement A_0)
  {
    if (A_0 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.h(new bc());
    // ISSUE: reference to a compiler-generated method
    this.n().m(A_0);
  }

  public void h(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.ay());
    // ISSUE: reference to a compiler-generated method
    if (this.l() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (v v in this.l())
        v.i(A_0);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.n() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.n().k(A_0);
  }

  protected void h(q A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.m() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in this.m())
      ;
  }

  public kx i(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.n() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.n().j(A_0);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.l() != null && A_0 >= 0 && A_0 < this.l().Count)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.l()[A_0].k();
    }
    return kx.i;
  }

  public float j(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.n() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return this.n().k(A_0);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.l() != null && A_0 >= 0 && A_0 < this.l().Count)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.l()[A_0].l();
    }
    return 1f;
  }

  public bool k(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.i(A_0).i() > 0L;
  }

  public bool h(int A_0, float A_1)
  {
    if (this.k(A_0))
      return (double) A_1 >= (double) this.j(A_0);
    return false;
  }

  public kx i(int A_0, float A_1)
  {
    float A_1_1 = this.j(A_0);
    kx A_2 = this.i(A_0);
    return v.i(A_1, A_1_1, A_2);
  }

  public int l(int A_0)
  {
    if (A_0 < 0 || A_0 >= this.o())
      return 0;
    // ISSUE: reference to a compiler-generated method
    if (this.n() != null)
    {
      // ISSUE: reference to a compiler-generated method
      List<bc.a> aList = this.n().n(A_0);
      if (aList == null)
        return 0;
      return aList.Count;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.l()[A_0].j() == null)
      return 0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.l()[A_0].j().Count;
  }

  public v h(int A_0, g8 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.n() == null)
      return (v) null;
    v v = v.i(this, A_0);
    // ISSUE: reference to a compiler-generated method
    if (v != null && v.i(this.n(), A_1))
      return v;
    return (v) null;
  }

  public s i(int A_0, g8 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.n() == null)
      return (s) null;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    s s = s.au(this.n().j(), this, A_0);
    // ISSUE: reference to a compiler-generated method
    s.aw(this.n(), A_0, A_1);
    return s;
  }

  public List<List<a1>> m(int A_0)
  {
    if (A_0 < 0 || A_0 >= this.o())
      return (List<List<a1>>) null;
    // ISSUE: reference to a compiler-generated method
    if (this.l() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.l()[A_0].j();
    }
    // ISSUE: reference to a compiler-generated method
    if (this.n() == null)
      return (List<List<a1>>) null;
    // ISSUE: reference to a compiler-generated method
    return this.n().o(A_0);
  }

  public List<a1> h(int A_0, int A_1)
  {
    if (A_0 < 0 || A_0 >= this.o() || A_1 < 0)
      return (List<a1>) null;
    List<List<a1>> a1ListList = this.m(A_0);
    if (a1ListList == null || A_1 >= a1ListList.Count)
      return (List<a1>) null;
    return a1ListList[A_1];
  }

  public a1 h(int A_0, int A_1, int A_2)
  {
    if (A_0 < 0 || A_1 < 0 || (A_2 < 0 || A_0 >= this.o()))
      return (a1) null;
    List<a1> a1List = this.h(A_0, A_1);
    if (a1List != null && A_2 < a1List.Count)
      return a1List[A_2];
    return (a1) null;
  }

  public a1.RewardType i(int A_0, int A_1, int A_2)
  {
    a1 a1 = this.h(A_0, A_1, A_2);
    if (a1 != null)
      return a1.ay();
    return a1.RewardType.Num;
  }
}
