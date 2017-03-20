// Decompiled with JetBrains decompiler
// Type: bc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

public class bc
{
  private static Dictionary<string, string[]> m = new Dictionary<string, string[]>();
  private static Dictionary<string, string[]> n = new Dictionary<string, string[]>();
  private static Dictionary<string, string[]> o = new Dictionary<string, string[]>();
  protected List<bc.a> a;
  protected List<bc.a> b;
  protected Dictionary<int, List<bc.a>> c;
  protected List<List<a1>> d;
  protected Dictionary<int, List<List<a1>>> e;
  protected Dictionary<int, List<a1>> f;
  protected string[] g;
  protected Dictionary<int, string[]> h;
  protected Dictionary<int, string> i;
  protected Dictionary<int, List<bc.a>> j;
  protected Dictionary<int, List<bc.a>> k;
  protected Dictionary<int, List<List<a1>>> l;

  public bc()
  {
  }

  public bc(bc A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.i());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.j());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.l());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.m());
    if (A_0.g != null)
      this.g = (string[]) A_0.g.Clone();
    if (this.h != null)
      this.h = new Dictionary<int, string[]>((IDictionary<int, string[]>) this.h);
    if (A_0.a != null)
    {
      this.a = new List<bc.a>(A_0.a.Count);
      for (int index = 0; index < A_0.a.Count; ++index)
        this.a.Add((bc.a) A_0.a[index].Clone());
    }
    if (A_0.b != null)
    {
      this.b = new List<bc.a>(A_0.b.Count);
      for (int index = 0; index < A_0.b.Count; ++index)
        this.b.Add((bc.a) A_0.b[index].Clone());
    }
    if (A_0.c != null)
    {
      this.c = new Dictionary<int, List<bc.a>>(A_0.c.Count);
      foreach (KeyValuePair<int, List<bc.a>> keyValuePair in A_0.c)
      {
        List<bc.a> aList1 = keyValuePair.Value;
        List<bc.a> aList2 = new List<bc.a>(aList1.Count);
        for (int index = 0; index < aList1.Count; ++index)
        {
          bc.a a = (bc.a) aList1[index].Clone();
          aList2.Add(a);
        }
        this.c.Add(keyValuePair.Key, aList2);
      }
    }
    if (A_0.d != null)
    {
      this.d = new List<List<a1>>(A_0.d.Count);
      for (int index1 = 0; index1 < A_0.d.Count; ++index1)
      {
        List<a1> a1List1 = A_0.d[index1];
        List<a1> a1List2 = new List<a1>(a1List1.Count);
        for (int index2 = 0; index2 < a1List1.Count; ++index2)
          a1List2.Add(a1List1[index2].a0());
        this.d.Add(a1List2);
      }
    }
    if (A_0.e != null)
    {
      this.e = new Dictionary<int, List<List<a1>>>(A_0.e.Count);
      foreach (KeyValuePair<int, List<List<a1>>> keyValuePair in A_0.e)
      {
        List<List<a1>> a1ListList1 = keyValuePair.Value;
        List<List<a1>> a1ListList2 = new List<List<a1>>(a1ListList1.Count);
        for (int index1 = 0; index1 < a1ListList1.Count; ++index1)
        {
          List<a1> a1List1 = a1ListList1[index1];
          List<a1> a1List2 = new List<a1>(a1List1.Count);
          for (int index2 = 0; index2 < a1List1.Count; ++index2)
            a1List2.Add(a1List1[index2].a0());
          a1ListList2.Add(a1List2);
        }
        this.e.Add(keyValuePair.Key, a1ListList2);
      }
    }
    if (A_0.f == null)
      return;
    this.f = new Dictionary<int, List<a1>>(A_0.f.Count);
    foreach (KeyValuePair<int, List<a1>> keyValuePair in A_0.f)
    {
      List<a1> a1List1 = keyValuePair.Value;
      List<a1> a1List2 = new List<a1>(a1List1.Count);
      for (int index = 0; index < a1List1.Count; ++index)
      {
        a1 a1 = a1List1[index].a0();
        a1List2.Add(a1);
      }
      this.f.Add(keyValuePair.Key, a1List2);
    }
  }

  [SpecialName]
  public ICollection<int> n()
  {
    if (this.f == null)
      return (ICollection<int>) null;
    return (ICollection<int>) this.f.Keys;
  }

  public void m(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "usetemplate", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a<global::s.MissionType>(A_0, "missiontype", global::s.MissionType.Num));
    // ISSUE: reference to a compiler-generated method
    this.h(bc.j(A_0));
    // ISSUE: reference to a compiler-generated method
    this.i(aim.c(A_0, "famemultiplier", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.h(aim.c(A_0, "lpmultiplier", kx.h));
    // ISSUE: reference to a compiler-generated method
    if (!bc.h(this.j()))
      return;
    this.g = bc.i(aim.c(A_0, "itemlist"));
    this.n(aim.c(A_0, "rewards"));
    this.o(A_0);
  }

  protected void n(XmlElement A_0)
  {
    bc.h(A_0, ref this.a, ref this.b);
  }

  protected static void h(XmlElement A_0, ref List<bc.a> A_1, ref List<bc.a> A_2)
  {
    if (A_0 == null)
      return;
    int count = A_0.ChildNodes.Count;
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        bc.a A_0_2 = (bc.a) null;
        switch (A_0_1.Name)
        {
          case "unlock":
            A_0_2 = bc.l(A_0_1);
            break;
          case "bonus":
            A_0_2 = bc.k(A_0_1);
            break;
        }
        if (A_0_2 != null)
        {
          if (A_1 == null)
            A_1 = new List<bc.a>(count);
          A_1.Add(A_0_2);
          if (!bc.h(A_0_2))
          {
            if (A_2 == null)
              A_2 = new List<bc.a>(count);
            A_2.Add(A_0_2);
          }
        }
      }
    }
  }

  protected static bc.a l(XmlElement A_0)
  {
    bc.c c = new bc.c();
    c.a = aim.a<a1.RewardType>(A_0, "type", a1.RewardType.Num);
    c.b = bc.j(A_0);
    c.l = bc.i(A_0);
    c.m = aim.b(A_0, "mintier", 1);
    c.n = aim.b(A_0, "maxtier", 8);
    return (bc.a) c;
  }

  protected static bc.a k(XmlElement A_0)
  {
    bc.b b = new bc.b();
    b.a = aim.a<a1.RewardType>(A_0, "type", a1.RewardType.Num);
    b.b = bc.j(A_0);
    b.c = aim.a<PlayerAttribute>(A_0, "attribute", PlayerAttribute.NumAttributes);
    b.d = aim.a<a6.ResourceGatheringBonusTypes>(A_0, "bufftype", a6.ResourceGatheringBonusTypes.GatheringYield);
    b.e = aim.a(A_0, "bonus", 0.0f);
    b.h = aim.b(A_0, "mintier", 1);
    b.i = aim.b(A_0, "maxtier", 8);
    b.j = bc.i(A_0);
    b.k = bc.h(A_0);
    return (bc.a) b;
  }

  protected void o(XmlElement A_0)
  {
    this.h = (Dictionary<int, string[]>) null;
    List<XmlElement> xmlElementList = aim.d(A_0, "overridemasterylevel");
    if (xmlElementList == null || xmlElementList.Count == 0)
      return;
    for (int index1 = 0; index1 < xmlElementList.Count; ++index1)
    {
      XmlElement A_0_1 = xmlElementList[index1];
      int index2 = aim.b(A_0_1, "level", -1);
      string str = bc.j(A_0_1);
      string[] strArray = bc.i(aim.c(A_0_1, "itemlist"));
      if (strArray != null && strArray.Length > 0)
      {
        if (this.h == null)
          this.h = new Dictionary<int, string[]>();
        this.h[index2] = strArray;
      }
      if (!string.IsNullOrEmpty(str))
      {
        if (this.i == null)
          this.i = new Dictionary<int, string>();
        this.i[index2] = str;
      }
      XmlElement A_0_2 = aim.c(A_0_1, "rewards");
      if (A_0_2 != null)
      {
        List<bc.a> A_1 = (List<bc.a>) null;
        List<bc.a> A_2 = (List<bc.a>) null;
        bc.h(A_0_2, ref A_1, ref A_2);
        if (this.j == null)
          this.j = new Dictionary<int, List<bc.a>>();
        this.j[index2] = A_1;
      }
    }
  }

  public static bool h(bc.a A_0)
  {
    return A_0 is bc.c;
  }

  private static string j(XmlElement A_0)
  {
    XmlElement A_0_1 = aim.c(A_0, "description");
    if (A_0_1 != null)
      return aim.h(A_0_1, "tag");
    return string.Empty;
  }

  public string[] h(int A_0)
  {
    if (this.h != null)
    {
      string[] strArray = (string[]) null;
      if (this.h.TryGetValue(A_0, out strArray))
        return strArray;
    }
    return this.g;
  }

  public kx i(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.o(this.i().f(A_0, bb.DataType.Fame), this.l()).q();
  }

  public kx j(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.o(this.i().f(A_0, bb.DataType.Lp), this.m()).q();
  }

  public float k(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.i().g(A_0, bb.DataType.LpThreshold);
  }

  public bool l(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.j(A_0).i() > 0L;
  }

  public bool h(int A_0, float A_1)
  {
    if (this.l(A_0))
      return (double) A_1 >= (double) this.k(A_0);
    return false;
  }

  public kx i(int A_0, float A_1)
  {
    float A_1_1 = this.k(A_0);
    kx A_2 = this.j(A_0);
    return v.i(A_1, A_1_1, A_2);
  }

  public string m(int A_0)
  {
    if (this.i == null)
      return string.Empty;
    string empty = string.Empty;
    if (this.i.TryGetValue(A_0, out empty))
      return empty;
    // ISSUE: reference to a compiler-generated method
    return this.k();
  }

  public string h(int A_0, int A_1)
  {
    List<bc.a> aList = this.n(A_0);
    if (aList == null || A_1 < 0 || A_1 >= aList.Count)
      return string.Empty;
    return aList[A_1].b;
  }

  public List<bc.a> n(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.i() == null)
      return (List<bc.a>) null;
    // ISSUE: reference to a compiler-generated method
    if (A_0 < 0 || A_0 >= this.i().d())
      return (List<bc.a>) null;
    List<bc.a> aList = (List<bc.a>) null;
    if (this.c != null && this.c.TryGetValue(A_0, out aList) || this.k != null && this.k.TryGetValue(A_0, out aList))
      return aList;
    return this.b;
  }

  public List<List<a1>> o(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 < 0 || A_0 >= this.i().d() || this.i() == null)
      return (List<List<a1>>) null;
    List<List<a1>> a1ListList = (List<List<a1>>) null;
    if (this.e != null && this.e.TryGetValue(A_0, out a1ListList) || this.l != null && this.l.TryGetValue(A_0, out a1ListList))
      return a1ListList;
    return this.d;
  }

  public List<List<a1>> o()
  {
    return this.d;
  }

  public List<a1> p(int A_0)
  {
    List<a1> a1List = (List<a1>) null;
    if (this.f != null)
      this.f.TryGetValue(A_0, out a1List);
    return a1List;
  }

  public List<a1> q(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.i() == null)
      return (List<a1>) null;
    // ISSUE: reference to a compiler-generated method
    if (A_0 < 0 || A_0 > this.i().d())
      return (List<a1>) null;
    if (this.f == null)
      return (List<a1>) null;
    List<a1> a1List = (List<a1>) null;
    foreach (KeyValuePair<int, List<a1>> keyValuePair in this.f)
    {
      int key = keyValuePair.Key;
      if (key < A_0 && (this.l == null || !this.l.ContainsKey(key)))
      {
        if (a1List == null)
          a1List = new List<a1>();
        a1List.AddRange((IEnumerable<a1>) keyValuePair.Value);
      }
    }
    return a1List;
  }

  public Dictionary<int, List<List<a1>>> p()
  {
    return this.l;
  }

  private static Dictionary<bc.a, a1> h(List<bc.a> A_0, g8 A_1)
  {
    Dictionary<bc.a, a1> dictionary = (Dictionary<bc.a, a1>) null;
    if (A_0 != null)
    {
      for (int index = 0; index < A_0.Count; ++index)
      {
        bc.a a = A_0[index];
        a1 a1 = a1.au(a.a);
        if (a1 != null && a1.a1(a, A_1))
        {
          if (dictionary == null)
            dictionary = new Dictionary<bc.a, a1>(A_0.Count);
          dictionary.Add(a, a1);
        }
      }
    }
    return dictionary;
  }

  private void j(g8 A_0)
  {
    this.k = (Dictionary<int, List<bc.a>>) null;
    this.l = (Dictionary<int, List<List<a1>>>) null;
    if (this.j == null)
      return;
    foreach (KeyValuePair<int, List<bc.a>> keyValuePair in this.j)
    {
      int key = keyValuePair.Key;
      List<bc.a> aList1 = keyValuePair.Value;
      List<List<a1>> a1ListList = (List<List<a1>>) null;
      List<bc.a> aList2 = (List<bc.a>) null;
      for (int index = 0; index < aList1.Count; ++index)
      {
        bc.a A_0_1 = aList1[index];
        a1 a1 = a1.au(A_0_1.a);
        if (a1 != null && a1.bs(A_0_1, this, key, A_0))
        {
          if (aList2 == null)
            aList2 = new List<bc.a>(aList1.Count);
          aList2.Add(A_0_1);
          if (a1ListList == null)
            a1ListList = new List<List<a1>>(aList1.Count);
          a1ListList.Add(new List<a1>(1) { a1 });
        }
      }
      if (a1ListList != null && aList2 != null)
      {
        if (this.k == null)
          this.k = new Dictionary<int, List<bc.a>>(this.j.Count);
        this.k.Add(key, aList2);
        if (this.l == null)
          this.l = new Dictionary<int, List<List<a1>>>(this.j.Count);
        this.l.Add(key, a1ListList);
      }
    }
  }

  private void i(g8 A_0)
  {
    this.j(A_0);
    Dictionary<bc.a, a1> A_1 = bc.h(this.b, A_0);
    this.d = (List<List<a1>>) null;
    if (A_1 != null)
    {
      foreach (a1 a1 in A_1.Values)
      {
        if (this.d == null)
          this.d = new List<List<a1>>(A_1.Count);
        this.d.Add(new List<a1>(1) { a1 });
      }
    }
    this.f = (Dictionary<int, List<a1>>) null;
    this.c = (Dictionary<int, List<bc.a>>) null;
    this.e = (Dictionary<int, List<List<a1>>>) null;
    if (this.a == null)
      return;
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.i().d(); ++index)
    {
      bool flag1 = false;
      List<a1> a1List = (List<a1>) null;
      List<List<a1>> a1ListList = (List<List<a1>>) null;
      List<bc.a> aList = (List<bc.a>) null;
      bool flag2 = false;
      if (this.l != null)
        flag2 = this.h(index, A_0, ref a1List, ref a1ListList, ref aList, ref flag1);
      if (!flag2)
        this.h(index, A_1, A_0, ref a1List, ref a1ListList, ref aList, ref flag1);
      if (flag1)
      {
        if (a1List != null)
        {
          if (this.f == null)
          {
            // ISSUE: reference to a compiler-generated method
            this.f = new Dictionary<int, List<a1>>(this.i().d());
          }
          this.f.Add(index, a1List);
        }
        if (aList != null && aList != null)
        {
          if (this.c == null)
          {
            // ISSUE: reference to a compiler-generated method
            this.c = new Dictionary<int, List<bc.a>>(this.i().d());
          }
          this.c.Add(index, aList);
        }
        if (a1ListList != null)
        {
          if (this.e == null)
          {
            // ISSUE: reference to a compiler-generated method
            this.e = new Dictionary<int, List<List<a1>>>(this.i().d());
          }
          this.e.Add(index, a1ListList);
        }
      }
    }
  }

  private void h(int A_0, Dictionary<bc.a, a1> A_1, g8 A_2, ref List<a1> A_3, ref List<List<a1>> A_4, ref List<bc.a> A_5, ref bool A_6)
  {
    for (int index = 0; index < this.a.Count; ++index)
    {
      bc.a a = this.a[index];
      bool flag = false;
      List<a1> a1List = (List<a1>) null;
      a1 a1 = (a1) null;
      if (A_1.TryGetValue(a, out a1))
      {
        a1List = new List<a1>(1) { a1 };
        flag = true;
      }
      else
      {
        a1 = a1.au(a.a);
        if (a1 != null && a1.bs(a, this, A_0, A_2))
        {
          if (A_3 == null)
            A_3 = new List<a1>(this.a.Count);
          a1List = new List<a1>(1) { a1 };
          A_3.Add(a1);
          flag = true;
          A_6 = true;
        }
      }
      if (flag)
      {
        if (A_5 == null)
          A_5 = new List<bc.a>(this.a.Count);
        A_5.Add(a);
        if (a1List != null)
        {
          if (A_4 == null)
            A_4 = new List<List<a1>>(this.a.Count);
          A_4.Add(a1List);
        }
      }
    }
  }

  private bool h(int A_0, g8 A_1, ref List<a1> A_2, ref List<List<a1>> A_3, ref List<bc.a> A_4, ref bool A_5)
  {
    List<List<a1>> a1ListList = (List<List<a1>>) null;
    if (!this.l.TryGetValue(A_0, out a1ListList))
      return false;
    List<bc.a> aList = (List<bc.a>) null;
    this.k.TryGetValue(A_0, out aList);
    for (int index = 0; index < a1ListList.Count; ++index)
    {
      List<a1> a1List = a1ListList[index];
      bc.a A_0_1 = aList[index];
      if (bc.h(A_0_1))
      {
        if (A_2 == null)
          A_2 = new List<a1>(a1ListList.Count);
        A_2.Add(a1List[0]);
        A_5 = true;
      }
      if (A_4 == null)
        A_4 = new List<bc.a>(a1ListList.Count);
      A_4.Add(A_0_1);
      if (a1List != null)
      {
        if (A_3 == null)
          A_3 = new List<List<a1>>(a1ListList.Count);
        A_3.Add(a1List);
      }
    }
    return true;
  }

  public void k(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    bb A_0_1 = A_0.ay().h1(this.h());
    if (A_0_1 == null)
      return;
    this.h(A_0_1, A_0);
  }

  public void h(bb A_0, g8 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.c());
    // ISSUE: reference to a compiler-generated method
    this.h(A_0);
    this.h(A_1);
    this.i(A_1);
  }

  public void l(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.i() != null || A_0 == null || string.IsNullOrEmpty(this.h()))
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    bb A_0_1 = A_0.ay().h1(this.h());
    if (A_0_1 == null)
      return;
    this.h(A_0_1, A_0);
  }

  private void h(g8 A_0)
  {
    for (int index = 0; index < this.a.Count; ++index)
      bc.h(this.a[index], A_0);
    if (this.j == null)
      return;
    foreach (KeyValuePair<int, List<bc.a>> keyValuePair in this.j)
    {
      int key = keyValuePair.Key;
      List<bc.a> aList = keyValuePair.Value;
      for (int index = 0; index < aList.Count; ++index)
        bc.h(aList[index], A_0);
    }
  }

  private static void h(bc.a A_0, g8 A_1)
  {
    bc.b b = A_0 as bc.b;
    if (b == null)
      return;
    if (b.j != null && b.f == null)
    {
      // ISSUE: reference to a compiler-generated method
      b.f = bc.h(A_1.an(), (IList<string>) b.j, b.h, b.i);
      // ISSUE: reference to a compiler-generated method
      if (!g8.am())
        b.j = (string[]) null;
    }
    if (b.k == null || b.g != null)
      return;
    // ISSUE: reference to a compiler-generated method
    b.g = bc.h(A_1.aw(), (IList<string>) b.k);
    // ISSUE: reference to a compiler-generated method
    if (g8.am())
      return;
    b.j = (string[]) null;
  }

  public bool h(g8 A_0, List<string> A_1, HashSet<string> A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.h()))
    {
      if (A_1 != null)
        A_1.Add("no TemplateData set!");
      return false;
    }
    this.l(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.i() == null)
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Template Data not found: " + this.h());
      }
      return false;
    }
    // ISSUE: reference to a compiler-generated method
    if (!bc.h(this.j()))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add(string.Format("MissionType not supported: {0}", (object) this.j().ToString()));
      }
      return false;
    }
    // ISSUE: reference to a compiler-generated method
    global::s s = global::s.cp(this.j());
    if (s == null)
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add(string.Format("MissionType invalid: {0}", (object) this.j().ToString()));
      }
      return false;
    }
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    for (int A_1_1 = 0; A_1_1 < this.i().d(); ++A_1_1)
    {
      if (!s.ax(this, A_1_1, A_0, A_1, A_2))
        flag = true;
    }
    for (int index = 0; index < this.a.Count; ++index)
    {
      bc.a A_0_1 = this.a[index];
      if (!bc.h(A_0_1, A_0, A_1, A_2))
        flag = true;
      a1 a1 = a1.au(A_0_1.a);
      if (!a1.a2(A_0_1, A_0, A_1, A_2))
        flag = true;
      // ISSUE: reference to a compiler-generated method
      for (int A_2_1 = 0; A_2_1 < this.i().d(); ++A_2_1)
      {
        if (!a1.a3(A_0_1, this, A_2_1, A_0, A_1, A_2))
          flag = true;
      }
    }
    return !flag;
  }

  protected static bool h(bc.a A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    bc.b A_0_1 = A_0 as bc.b;
    if (A_0_1 != null)
      return bc.j(A_0_1, A_1, A_2, A_3);
    bc.c A_0_2 = A_0 as bc.c;
    if (A_0_2 != null)
      return bc.h(A_0_2, A_1, A_2, A_3);
    A_2.Add(string.Format("internal error in ValidateRewardDataGeneral!"));
    return false;
  }

  protected static bool j(bc.b A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    if (A_0.a == a1.RewardType.ResourceGatherBonus)
      return bc.h(A_0, A_1, A_2, A_3);
    return bc.i(A_0, A_1, A_2, A_3);
  }

  protected static bool i(bc.b A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    if (A_0.j == null || A_0.j.Length == 0)
    {
      if (A_0.f != null && A_0.f.Length > 0)
        return true;
      if (A_2 != null)
        A_2.Add(string.Format("No ItemPattern specified for BonusReward: {0} in Template!", (object) A_0.a.ToString()));
      return false;
    }
    bool flag = false;
    if (A_0.j != null && A_0.j.Length > 0 && !bc.i(A_0.j, A_0.h, A_0.i, A_0.a, A_1, A_2, A_3))
      flag = true;
    return !flag;
  }

  protected static bool h(bc.b A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    if (A_0.k == null || A_0.k.Length == 0)
    {
      if (A_0.g != null && A_0.g.Length > 0)
        return true;
      if (A_2 != null)
        A_2.Add(string.Format("No ResourcePattern specified for BonusReward: {0} in Template!", (object) A_0.a.ToString()));
      return false;
    }
    bool flag = false;
    if (A_0.k != null && A_0.k.Length > 0 && !bc.h(A_0.k, A_0.a, A_1, A_2, A_3))
      flag = true;
    return !flag;
  }

  protected static bool h(bc.c A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    bool flag = false;
    switch (A_0.a)
    {
      case a1.RewardType.ItemUse:
      case a1.RewardType.ItemCraft:
      case a1.RewardType.BuildingBuild:
      case a1.RewardType.SpellUse:
      case a1.RewardType.FarmableUse:
        string[] l = A_0.l;
        if (l == null || l.Length == 0)
        {
          flag = true;
          if (A_2 != null)
            A_2.Add(string.Format("No UnlockReward ItemPattern specified in Template!"));
        }
        if (A_0.a == a1.RewardType.SpellUse && (A_0.m < 1 || A_0.n > 8))
        {
          flag = true;
          if (A_2 != null)
            A_2.Add(string.Format("min tier ({0}) or max tier ({1}) invalid for UnlockReward type 'spelluse'!", (object) A_0.m, (object) A_0.n));
        }
        return !flag;
      default:
        flag = true;
        if (A_2 != null)
        {
          A_2.Add(string.Format("Invalid Unlock RewardType '{0}' specified in Template!", (object) A_0.a.ToString()));
          goto case a1.RewardType.ItemUse;
        }
        else
          goto case a1.RewardType.ItemUse;
    }
  }

  public static bool i(string[] A_0, int A_1, int A_2, a1.RewardType A_3, g8 A_4, List<string> A_5, HashSet<string> A_6)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0, A_1, A_2, A_3, A_4.an().hz(), "item", A_5, A_6);
  }

  public static bool h(string[] A_0, int A_1, int A_2, a1.RewardType A_3, g8 A_4, List<string> A_5, HashSet<string> A_6)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0, A_1, A_2, A_3, A_4.ap().h1(), "building", A_5, A_6);
  }

  public static bool h(string[] A_0, a1.RewardType A_1, g8 A_2, List<string> A_3, HashSet<string> A_4)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0, 0, 0, A_1, A_2.aw().h6(), "resource", A_3, A_4);
  }

  public static bool h(string[] A_0, int A_1, int A_2, a1.RewardType A_3, List<string> A_4, string A_5, List<string> A_6, HashSet<string> A_7)
  {
    string A_3_1 = "for reward " + A_3.ToString();
    return bc.h(A_0, A_1, A_2, A_3_1, A_4, A_5, A_6, (HashSet<string>) null);
  }

  protected static string[] i(XmlElement A_0)
  {
    return bc.h(A_0, "itempattern");
  }

  protected static string[] h(XmlElement A_0)
  {
    return bc.h(A_0, "resourcepattern");
  }

  protected static string[] h(XmlElement A_0, string A_1)
  {
    if (A_0 == null)
      return (string[]) null;
    List<XmlElement> xmlElementList = aim.d(A_0, A_1);
    if (xmlElementList == null || xmlElementList.Count == 0)
      return (string[]) null;
    List<string> stringList = new List<string>(xmlElementList.Count);
    foreach (XmlElement A_0_1 in xmlElementList)
    {
      string str = aim.a(A_0_1, "pattern", string.Empty);
      if (!string.IsNullOrEmpty(str))
        stringList.Add(str);
    }
    return stringList.ToArray();
  }

  public static string[] h(abc A_0, IList<string> A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0.hz(), A_1, A_2, A_3, bc.m);
  }

  public static string[] h(hi A_0, IList<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0.h6(), A_1, 0, 0, bc.n);
  }

  public static string[] h(aa7 A_0, IList<string> A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    return bc.h(A_0.h1(), A_1, A_2, A_3, bc.o);
  }

  public static string[] h(List<string> A_0, IList<string> A_1, int A_2, int A_3, Dictionary<string, string[]> A_4)
  {
    string empty = string.Empty;
    if (A_4 != null)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (string str in (IEnumerable<string>) A_1)
        stringBuilder.Append(str);
      stringBuilder.Append(A_2);
      stringBuilder.Append(A_3);
      empty = stringBuilder.ToString();
      string[] strArray;
      if (A_4.TryGetValue(empty, out strArray))
        return strArray;
    }
    string[] strArray1;
    if (A_2 == A_3)
    {
      strArray1 = bc.h(A_0, A_1, A_2.ToString());
    }
    else
    {
      List<string> A_4_1 = new List<string>();
      for (int index = 0; index < A_1.Count; ++index)
      {
        string A_1_1 = A_1[index];
        bc.h(A_0, A_1_1, A_2, A_3, ref A_4_1);
      }
      strArray1 = A_4_1.ToArray();
    }
    if (A_4 != null)
      A_4[empty] = strArray1;
    return strArray1;
  }

  public static List<string> h(string A_0, int A_1, int A_2)
  {
    return bc.h(A_0, A_1, A_2, (HashSet<string>) null);
  }

  public static List<string> h(string A_0, int A_1, int A_2, HashSet<string> A_3)
  {
    List<string> stringList = (List<string>) null;
    if (A_0.IndexOf("?") >= 0)
    {
      if (A_1 == A_2)
      {
        string str = A_0.Replace("?", A_1.ToString());
        if (A_3 == null || !A_3.Contains(str))
        {
          stringList = new List<string>(1);
          stringList.Add(str);
        }
      }
      else
      {
        stringList = new List<string>(A_2 - A_1);
        for (int index = A_1; index <= A_2; ++index)
        {
          string str = A_0.Replace("?", index.ToString());
          if ((A_3 == null || !A_3.Contains(str)) && !stringList.Contains(str))
            stringList.Add(str);
        }
      }
    }
    else if (A_3 == null || !A_3.Contains(A_0))
    {
      stringList = new List<string>(1);
      stringList.Add(A_0);
    }
    return stringList;
  }

  protected static void h(List<string> A_0, string A_1, bool A_2, ref List<string> A_3)
  {
    int index = A_0.BinarySearch(A_1);
    if (A_2)
    {
      if (index < 0)
        index = ~index;
      for (; index < A_0.Count && A_0[index].StartsWith(A_1, StringComparison.Ordinal); ++index)
      {
        if (!A_3.Contains(A_0[index]))
          A_3.Add(A_0[index]);
      }
    }
    else
    {
      if (index < 0 || A_3.Contains(A_1))
        return;
      A_3.Add(A_1);
    }
  }

  protected static void h(List<string> A_0, string A_1, int A_2, int A_3, ref List<string> A_4)
  {
    bool A_2_1 = A_1.EndsWith("*");
    A_1 = A_1.TrimEnd('*');
    List<string> stringList = bc.h(A_1, A_2, A_3);
    for (int index = 0; index < stringList.Count; ++index)
    {
      string A_1_1 = stringList[index];
      bc.h(A_0, A_1_1, A_2_1, ref A_4);
    }
  }

  public static string[] h(List<string> A_0, IList<string> A_1, string A_2)
  {
    List<string> A_3 = new List<string>(A_0.Count);
    for (int index = 0; index < A_1.Count; ++index)
    {
      string str = A_1[index];
      bool A_2_1 = str.EndsWith("*");
      string A_1_1 = str.Replace("*", string.Empty).Replace("?", A_2);
      bc.h(A_0, A_1_1, A_2_1, ref A_3);
    }
    return A_3.ToArray();
  }

  public static string[] h(List<string> A_0, IList<string> A_1)
  {
    List<string> A_3 = new List<string>(A_0.Count);
    for (int index = 0; index < A_1.Count; ++index)
    {
      string str = A_1[index];
      bool A_2 = str.EndsWith("*");
      string A_1_1 = str.Replace("*", string.Empty);
      bc.h(A_0, A_1_1, A_2, ref A_3);
    }
    return A_3.ToArray();
  }

  public static bool h(global::s.MissionType A_0)
  {
    switch (A_0)
    {
      case global::s.MissionType.KillMobFame:
      case global::s.MissionType.FarmHarvestFame:
      case global::s.MissionType.FarmRaiseFame:
      case global::s.MissionType.CraftItemFame:
      case global::s.MissionType.GatherFame:
        return true;
      default:
        return false;
    }
  }

  public bool h(int A_0, g8 A_1, List<string> A_2, HashSet<string> A_3)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    if (this.i(A_0).i() <= 0L)
    {
      flag = true;
      if (A_2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(string.Format("Fame Value of TemplateData '{0}' in MasteryLevel {1} is 0!", (object) this.i().c(), (object) A_0));
      }
    }
    // ISSUE: reference to a compiler-generated method
    int num = this.i().h(A_0, bb.DataType.MissionTargetMinTier);
    // ISSUE: reference to a compiler-generated method
    if (this.i().h(A_0, bb.DataType.MissionTargetMaxTier) < num)
    {
      flag = true;
      if (A_2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(string.Format("MaxTier is smaller than MinTier (MissionTarget) of TemplateData '{0}' in MasteryLevel {1}!", (object) this.i().c(), (object) A_0));
      }
    }
    // ISSUE: reference to a compiler-generated method
    int A_1_1 = this.i().h(A_0, bb.DataType.MissionItemMinTier);
    // ISSUE: reference to a compiler-generated method
    int A_2_1 = this.i().h(A_0, bb.DataType.MissionItemMaxTier);
    if (A_2_1 < A_1_1)
    {
      flag = true;
      if (A_2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_2.Add(string.Format("MaxTier is smaller than MinTier (MissionItem) of TemplateData '{0}' in MasteryLevel {1}!", (object) this.i().c(), (object) A_0));
      }
    }
    string[] A_0_1 = this.h(A_0);
    if (A_0_1 == null || A_0_1.Length == 0)
    {
      flag = true;
      if (A_2 != null)
        A_2.Add(string.Format("No Mission ItemPatternsspecified in Template in MasteryLevel {0}!", (object) A_0));
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    List<string> A_4 = A_1.an().hz();
    if (!bc.h(A_0_1, A_1_1, A_2_1, string.Empty, A_4, "item", A_2, (HashSet<string>) null))
      flag = true;
    return !flag;
  }

  public static bool h(string[] A_0, int A_1, int A_2, string A_3, List<string> A_4, string A_5, List<string> A_6, HashSet<string> A_7)
  {
    bool flag1 = false;
    Dictionary<string, List<string>> A_0_1 = (Dictionary<string, List<string>>) null;
    for (int index1 = 0; index1 < A_0.Length; ++index1)
    {
      string str = A_0[index1];
      List<string> stringList = bc.h(str, A_1, A_2, A_7);
      if (stringList != null && stringList.Count > 0)
      {
        if (A_7 != null)
        {
          for (int index2 = 0; index2 < stringList.Count; ++index2)
            A_7.Add(stringList[index2]);
        }
        string[] strArray = bc.h(A_4, (IList<string>) stringList);
        if (strArray != null && strArray.Length > 0)
        {
          flag1 = true;
          break;
        }
      }
      if (A_0_1 == null)
        A_0_1 = new Dictionary<string, List<string>>();
      A_0_1.Add(str, stringList);
    }
    bool flag2 = false;
    if (!flag1)
    {
      flag2 = true;
      bc.h(A_0_1, A_6, A_5, A_3);
    }
    return !flag2;
  }

  private static void h(Dictionary<string, List<string>> A_0, List<string> A_1, string A_2, string A_3)
  {
    if (A_1 == null)
      return;
    if (A_3 == null)
      A_3 = string.Empty;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendFormat("All patterns (see following list) does not match any {0} currently in game! {1}\n", (object) A_2, (object) A_3);
    foreach (KeyValuePair<string, List<string>> keyValuePair in A_0)
    {
      string key = keyValuePair.Key;
      List<string> stringList = keyValuePair.Value;
      if (stringList != null && stringList.Count > 0)
      {
        stringBuilder.AppendFormat(" Pattern {0} get build to patterns:\n", (object) key);
        for (int index = 0; index < stringList.Count; ++index)
          stringBuilder.AppendFormat("  {0}\n", (object) stringList[index]);
      }
      else
        stringBuilder.AppendFormat("  Pattern {0} could not be build to a pattern!\n", (object) key);
    }
    A_1.Add(stringBuilder.ToString());
  }

  public abstract class a : ICloneable
  {
    public a1.RewardType a;
    public string b;

    public abstract object Clone();
  }

  public class b : bc.a
  {
    public PlayerAttribute c;
    public a6.ResourceGatheringBonusTypes d;
    public float e;
    public string[] f;
    public string[] g;
    public int h;
    public int i;
    public string[] j;
    public string[] k;

    public override object Clone()
    {
      bc.b b = (bc.b) this.MemberwiseClone();
      b.f = this.f != null ? (string[]) this.f.Clone() : (string[]) null;
      b.j = this.j != null ? (string[]) this.j.Clone() : (string[]) null;
      b.g = this.g != null ? (string[]) this.g.Clone() : (string[]) null;
      b.k = this.k != null ? (string[]) this.k.Clone() : (string[]) null;
      return (object) b;
    }
  }

  public class c : bc.a
  {
    public string[] l;
    public int m;
    public int n;

    public override object Clone()
    {
      bc.c c = (bc.c) this.MemberwiseClone();
      c.l = this.l != null ? (string[]) this.l.Clone() : (string[]) null;
      return (object) c;
    }
  }
}
