// Decompiled with JetBrains decompiler
// Type: jw
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class jw : ee
{
  protected float[] a = new float[57];
  protected float[] b = new float[57];
  protected float[] c = new float[10];
  protected Dictionary<ba, int> d = new Dictionary<ba, int>();
  protected Dictionary<string, float> e = new Dictionary<string, float>();
  protected float[] f = new float[8];
  protected float[] g = new float[8];
  protected HashSet<string> h = new HashSet<string>();
  protected HashSet<string> i = new HashSet<string>();
  protected HashSet<string> j = new HashSet<string>();
  protected HashSet<string> k = new HashSet<string>();
  protected HashSet<string> l = new HashSet<string>();
  protected HashSet<string> m = new HashSet<string>();
  protected HashSet<string> n = new HashSet<string>();
  protected HashSet<string> o = new HashSet<string>();
  protected HashSet<string> p = new HashSet<string>();
  protected Dictionary<string, float> q = new Dictionary<string, float>();
  protected Dictionary<string, float> r = new Dictionary<string, float>();
  protected Dictionary<string, float> s = new Dictionary<string, float>();

  public jw()
  {
    // ISSUE: reference to a compiler-generated method
    this.j(new Dictionary<int, global::r>());
    // ISSUE: reference to a compiler-generated method
    this.j(new Dictionary<int, jx>());
  }

  [SpecialName]
  public HashSet<string> s()
  {
    return this.h;
  }

  [SpecialName]
  public HashSet<string> t()
  {
    return this.i;
  }

  [SpecialName]
  public HashSet<string> u()
  {
    return this.j;
  }

  [SpecialName]
  public HashSet<string> v()
  {
    return this.k;
  }

  [SpecialName]
  public HashSet<string> w()
  {
    return this.l;
  }

  [SpecialName]
  public HashSet<string> x()
  {
    return this.m;
  }

  [SpecialName]
  public HashSet<string> y()
  {
    return this.n;
  }

  [SpecialName]
  protected abstract g8 f9();

  protected abstract b9 ga();

  protected abstract bool gb(string A_0);

  protected abstract float gd(jx A_0);

  protected abstract kx ge();

  public abstract aas gf(v A_0);

  public void j(IList<string> A_0)
  {
    for (int index = 0; index < A_0.Count; ++index)
      this.s().Add(A_0[index]);
  }

  public void k(IList<string> A_0)
  {
    for (int index = 0; index < A_0.Count; ++index)
      this.v().Add(A_0[index]);
  }

  public bool j(b9 A_0)
  {
    return this.p.Contains(A_0.j);
  }

  public bool k(b9 A_0)
  {
    return this.o.Contains(A_0.j);
  }

  public float j(EquipmentSlot A_0)
  {
    return this.c[(int) A_0];
  }

  public float cc(PlayerAttribute A_0)
  {
    int index = (int) A_0;
    return this.a[index] + this.b[index];
  }

  public float j(int A_0)
  {
    if (A_0 < 1 || A_0 > 8)
      return 0.0f;
    return this.f[A_0 - 1];
  }

  public float k(int A_0)
  {
    if (A_0 < 1 || A_0 > 8)
      return 0.0f;
    return this.g[A_0 - 1];
  }

  public float j(string A_0, int A_1, a6.ResourceGatheringBonusTypes A_2)
  {
    float num;
    if (this.e.Count == 0 || !this.e.TryGetValue(A_1.ToString() + A_0 + (object) A_2, out num))
      return 0.0f;
    return num;
  }

  public float cd(string A_0, int A_1)
  {
    return this.j(A_0, A_1, a6.ResourceGatheringBonusTypes.GatheringSpeed);
  }

  public float ce(string A_0, int A_1)
  {
    return this.j(A_0, A_1, a6.ResourceGatheringBonusTypes.GatheringYield);
  }

  public float j(PlayerAttribute A_0)
  {
    return this.b[(int) A_0];
  }

  public float l(b9 A_0)
  {
    float num = 0.0f;
    this.q.TryGetValue(A_0.j, out num);
    return num;
  }

  public float m(b9 A_0)
  {
    float num = 0.0f;
    this.r.TryGetValue(A_0.j, out num);
    return num;
  }

  public float j(c7 A_0)
  {
    float num = 0.0f;
    this.s.TryGetValue(A_0.j, out num);
    return num;
  }

  protected bool l(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.q().ContainsKey(A_0))
      return true;
    // ISSUE: reference to a compiler-generated method
    return this.r().ContainsKey(A_0);
  }

  public bool m(int A_0)
  {
    return this.j(A_0, 0);
  }

  public bool j(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.q().ContainsKey(A_0))
      return true;
    // ISSUE: reference to a compiler-generated method
    if (this.r().ContainsKey(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.r()[A_0].e() > A_1;
    }
    return false;
  }

  protected bool l(global::r A_0)
  {
    // ISSUE: reference to a compiler-generated method
    global::q q = this.f9().ay();
    // ISSUE: reference to a compiler-generated method
    foreach (string A_0_1 in A_0.m())
    {
      // ISSUE: reference to a compiler-generated method
      bool flag = this.m(q.h0(A_0_1).i());
      // ISSUE: reference to a compiler-generated method
      if (A_0.k() && !flag)
        return false;
      // ISSUE: reference to a compiler-generated method
      if (!A_0.k() && flag)
        return true;
    }
    // ISSUE: reference to a compiler-generated method
    return A_0.k();
  }

  protected void z()
  {
    Array.Clear((Array) this.a, 0, this.a.Length);
    this.d.Clear();
    this.e.Clear();
    Array.Clear((Array) this.f, 0, this.f.Length);
    Array.Clear((Array) this.g, 0, this.g.Length);
    this.h.Clear();
    this.i.Clear();
    this.j.Clear();
    this.k.Clear();
    this.l.Clear();
    this.m.Clear();
    this.n.Clear();
    this.q.Clear();
    this.r.Clear();
    this.s.Clear();
    this.o.Clear();
    this.p.Clear();
  }

  protected void j(a1 A_0)
  {
    this.k(A_0, 1);
  }

  protected void j(a1 A_0, int A_1)
  {
    this.k(A_0, A_1);
  }

  protected void k(a1 A_0, int A_1)
  {
    switch (A_0.ay())
    {
      case a1.RewardType.Avatar:
        this.j((cu) A_0);
        break;
      case a1.RewardType.AvatarRing:
        this.k((cu) A_0);
        break;
      case a1.RewardType.ItemUse:
        this.l((cu) A_0);
        break;
      case a1.RewardType.ItemCraft:
        this.n((cu) A_0);
        break;
      case a1.RewardType.BuildingBuild:
        this.o((cu) A_0);
        break;
      case a1.RewardType.SpellUse:
        this.m((cu) A_0);
        break;
      case a1.RewardType.PassiveBonus:
        this.j((cx) A_0, A_1);
        break;
      case a1.RewardType.ItemWearBonus:
        this.j((ba) A_0, A_1);
        break;
      case a1.RewardType.ItemCraftQuality:
        this.j((a9) A_0, A_1);
        break;
      case a1.RewardType.CraftingFocusCostReduction:
        this.j((a8) A_0, A_1);
        break;
      case a1.RewardType.FarmingFocusCostReduction:
        this.j((a4) A_0, A_1);
        break;
      case a1.RewardType.FarmableUse:
        this.p((cu) A_0);
        break;
      case a1.RewardType.CanLeaveStartArea:
        this.gc();
        break;
      case a1.RewardType.ExpeditionCategory:
        this.q((cu) A_0);
        break;
      case a1.RewardType.ResourceGatherBonus:
        this.j((a6) A_0, A_1);
        break;
      case a1.RewardType.BonusDamageVsMobs:
        this.j((a5) A_0, A_1);
        break;
      case a1.RewardType.BonusDefenseVsMobs:
        this.j((a2) A_0, A_1);
        break;
    }
  }

  protected void j(global::r A_0, int A_1)
  {
    if (A_1 > A_0.o())
      A_1 = A_0.o();
    // ISSUE: reference to a compiler-generated method
    if (A_0.n() != null)
    {
      int num = 0;
      // ISSUE: reference to a compiler-generated method
      Dictionary<int, List<List<a1>>> dictionary = A_0.n().p();
      if (dictionary != null)
      {
        foreach (KeyValuePair<int, List<List<a1>>> keyValuePair in dictionary)
        {
          if (keyValuePair.Key < A_1)
          {
            ++num;
            List<List<a1>> a1ListList = keyValuePair.Value;
            for (int index = 0; index < a1ListList.Count; ++index)
              this.j(a1ListList[index][0]);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      List<List<a1>> a1ListList1 = A_0.n().o();
      if (a1ListList1 != null)
      {
        for (int index1 = 0; index1 < a1ListList1.Count; ++index1)
        {
          List<a1> a1List = a1ListList1[index1];
          for (int index2 = 0; index2 < a1List.Count; ++index2)
          {
            int A_1_1 = A_1 - num;
            this.j(a1List[index2], A_1_1);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      List<a1> a1List1 = A_0.n().q(A_1);
      if (a1List1 == null)
        return;
      for (int index = 0; index < a1List1.Count; ++index)
        this.j(a1List1[index]);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0.l() == null)
        return;
      for (int index = 0; index < A_1; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        List<List<a1>> a1ListList = A_0.l()[index].j();
        if (a1ListList != null)
        {
          foreach (List<a1> a1List in a1ListList)
          {
            foreach (a1 A_0_1 in a1List)
              this.j(A_0_1);
          }
        }
      }
    }
  }

  protected void aa()
  {
    this.z();
    // ISSUE: reference to a compiler-generated method
    foreach (global::r A_0 in this.q().Values)
      this.j(A_0, A_0.o());
    // ISSUE: reference to a compiler-generated method
    foreach (jx jx in this.r().Values)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.j(jx.d(), jx.e());
    }
  }

  protected abstract void gc();

  protected void j(cx A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() >= PlayerAttribute.NumAttributes)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a[(int) A_0.au()] += A_0.av() * (float) A_1;
  }

  protected void j(a6 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int index1 = A_0.av(); index1 <= A_0.aw(); ++index1)
    {
      // ISSUE: reference to a compiler-generated method
      for (int index2 = 0; index2 < A_0.au().Length; ++index2)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        string key = index1.ToString() + A_0.au()[index2] + (object) A_0.ax();
        float num = 0.0f;
        if (!this.e.TryGetValue(key, out num))
          num = 0.0f;
        // ISSUE: reference to a compiler-generated method
        this.e[key] = num + A_0.az() * (float) A_1;
      }
    }
  }

  protected void j(a5 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f[A_0.av() - 1] += A_0.au() * (float) A_1;
  }

  protected void j(a2 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.g[A_0.av() - 1] += A_0.au() * (float) A_1;
  }

  public void ab()
  {
    Array.Clear((Array) this.b, 0, this.b.Length);
    Array.Clear((Array) this.c, 0, this.c.Length);
    this.f9();
    foreach (KeyValuePair<ba, int> keyValuePair in this.d)
      this.k(keyValuePair.Key, keyValuePair.Value);
  }

  protected void j(ba A_0, int A_1)
  {
    if (A_0 == null)
      return;
    int num;
    if (!this.d.TryGetValue(A_0, out num))
      num = 0;
    this.d[A_0] = num + A_1;
  }

  protected void j(ba A_0)
  {
    this.k(A_0, 1);
  }

  protected void k(ba A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    abc abc = this.f9().an();
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_0.au().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string A_0_1 = A_0.au()[index];
      bool flag = this.gb(A_0_1);
      if (!flag)
      {
        b9 b9 = this.ga();
        flag = b9 != null && b9.j == A_0_1;
      }
      // ISSUE: reference to a compiler-generated method
      if (flag && A_0.av() < PlayerAttribute.NumAttributes)
      {
        // ISSUE: reference to a compiler-generated method
        PlayerAttribute playerAttribute = A_0.av();
        if (playerAttribute == PlayerAttribute.ItemPower)
        {
          b8 b8 = abc.hz(A_0_1);
          if (b8 != null)
          {
            // ISSUE: reference to a compiler-generated method
            en en = b8.f() as en;
            if (en != null)
            {
              // ISSUE: reference to a compiler-generated method
              this.c[(int) en.bl] += A_0.aw() * (float) A_1;
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          this.b[(int) playerAttribute] += A_0.aw() * (float) A_1;
        }
      }
    }
  }

  protected void j(a9 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.f9().an();
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_0.au().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string key = A_0.au()[index];
      float num;
      if (!this.q.TryGetValue(key, out num))
        num = 0.0f;
      // ISSUE: reference to a compiler-generated method
      this.q[key] = num + A_0.av() * (float) A_1;
    }
  }

  protected void j(a8 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.f9().an();
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_0.au().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string key = A_0.au()[index];
      float num;
      if (!this.r.TryGetValue(key, out num))
        num = 0.0f;
      // ISSUE: reference to a compiler-generated method
      this.r[key] = num + A_0.av() * (float) A_1;
    }
  }

  protected void j(a4 A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.f9().an();
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_0.au().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string key = A_0.au()[index];
      float num;
      if (!this.s.TryGetValue(key, out num))
        num = 0.0f;
      // ISSUE: reference to a compiler-generated method
      this.s[key] = num + A_0.av() * (float) A_1;
    }
  }

  protected void j(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.h.Add(str);
  }

  protected void k(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.i.Add(str);
  }

  protected void l(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.o.Add(str);
  }

  protected void m(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.j.Add(str);
  }

  protected void n(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.p.Add(str);
  }

  protected void o(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.k.Add(str);
  }

  protected void p(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
    {
      this.m.Add(str);
      this.k.Add(str);
    }
  }

  protected void q(cu A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null || A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.f9().bh();
    // ISSUE: reference to a compiler-generated method
    foreach (string str in A_0.au())
      this.n.Add(str);
  }

  public bool n(int A_0)
  {
    jx A_0_1 = (jx) null;
    // ISSUE: reference to a compiler-generated method
    this.r().TryGetValue(A_0, out A_0_1);
    return this.j(A_0_1);
  }

  private bool j(jx A_0)
  {
    if (A_0 == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    return A_0.f().r();
  }

  private bool j(jx A_0, float A_1)
  {
    if (A_0 == null)
      return false;
    // ISSUE: reference to a compiler-generated method
    return kx.h(A_0.f().k(A_1), this.ge());
  }

  public jy k(int A_0, int A_1)
  {
    jx A_0_1 = (jx) null;
    // ISSUE: reference to a compiler-generated method
    this.r().TryGetValue(A_0, out A_0_1);
    if (A_0_1 == null)
      return jy.b;
    if (this.j(A_0, A_1))
      return jy.d;
    // ISSUE: reference to a compiler-generated method
    v A_0_2 = A_0_1.f();
    // ISSUE: reference to a compiler-generated method
    if (A_0_2.o() != A_1)
      return jy.e;
    if (!A_0_2.r())
      return jy.f;
    float A_0_3 = this.gd(A_0_1);
    if (!A_0_2.j(A_0_3))
      return jy.g;
    if (kx.k(A_0_2.k(A_0_3), this.ge()))
      return jy.c;
    aas aas = this.gf(A_0_2);
    if (aas != aas.a)
      return (jy) (7 + aas);
    return jy.a;
  }

  public void j(a1.RewardType A_0)
  {
    switch (A_0)
    {
      case a1.RewardType.Avatar:
        this.ac();
        break;
      case a1.RewardType.AvatarRing:
        this.ad();
        break;
      case a1.RewardType.ItemUse:
        this.ae();
        break;
      case a1.RewardType.ItemCraft:
        this.af();
        break;
      case a1.RewardType.BuildingBuild:
        this.ah();
        break;
      case a1.RewardType.SpellUse:
        this.ag();
        break;
      case a1.RewardType.FarmableUse:
        this.ai();
        break;
      case a1.RewardType.ExpeditionCategory:
        this.aj();
        break;
    }
  }

  public void ac()
  {
    // ISSUE: reference to a compiler-generated method
    dr dr = this.f9().az();
    this.h.Clear();
    foreach (ds ds in (IEnumerable<ds>) dr.h3())
    {
      // ISSUE: reference to a compiler-generated method
      if (ds.k())
      {
        // ISSUE: reference to a compiler-generated method
        this.h.Add(ds.i());
      }
    }
  }

  public void ad()
  {
    // ISSUE: reference to a compiler-generated method
    dr dr = this.f9().az();
    this.i.Clear();
    foreach (dt dt in (IEnumerable<dt>) dr.h4())
    {
      // ISSUE: reference to a compiler-generated method
      if (dt.j())
      {
        // ISSUE: reference to a compiler-generated method
        this.i.Add(dt.h());
      }
    }
  }

  public void ae()
  {
    // ISSUE: reference to a compiler-generated method
    abc abc = this.f9().an();
    this.o.Clear();
    foreach (b8 b8 in (IEnumerable<b8>) abc.h0())
    {
      // ISSUE: reference to a compiler-generated method
      b9 b9 = b8.f();
      c4 c4 = b9 as c4;
      if (c4 != null && !c4.bz())
        this.o.Add(b9.d);
    }
  }

  public void af()
  {
    // ISSUE: reference to a compiler-generated method
    abc abc = this.f9().an();
    this.p.Clear();
    foreach (b8 b8 in (IEnumerable<b8>) abc.h0())
    {
      // ISSUE: reference to a compiler-generated method
      b9 b9 = b8.f();
      if (!b9.y)
        this.p.Add(b9.d);
    }
  }

  public void ag()
  {
    // ISSUE: reference to a compiler-generated method
    h2 h2 = this.f9().ao();
    this.j.Clear();
    foreach (gr gr in (IEnumerable<gr>) h2.h0())
    {
      // ISSUE: reference to a compiler-generated method
      if (gr != null && !gr.js())
      {
        // ISSUE: reference to a compiler-generated method
        this.j.Add(gr.jp());
      }
    }
  }

  public void ah()
  {
    // ISSUE: reference to a compiler-generated method
    aa7 aa7 = this.f9().ap();
    this.k.Clear();
    foreach (bd bd in (IEnumerable<bd>) aa7.h0())
    {
      // ISSUE: reference to a compiler-generated method
      if (!bd.dc() && !(bd is c1))
      {
        // ISSUE: reference to a compiler-generated method
        this.k.Add(bd.c9());
      }
    }
  }

  public void ai()
  {
    // ISSUE: reference to a compiler-generated method
    aa7 aa7 = this.f9().ap();
    this.m.Clear();
    foreach (bd bd in (IEnumerable<bd>) aa7.h0())
    {
      // ISSUE: reference to a compiler-generated method
      if (!bd.dc() && bd is c1)
      {
        // ISSUE: reference to a compiler-generated method
        this.m.Add(bd.c9());
        // ISSUE: reference to a compiler-generated method
        this.k.Add(bd.c9());
      }
    }
  }

  public void aj()
  {
    // ISSUE: reference to a compiler-generated method
    bg bg = this.f9().bh();
    this.n.Clear();
    foreach (bh bh in (IEnumerable<bh>) bg.hz())
    {
      // ISSUE: reference to a compiler-generated method
      if (!bh.u())
      {
        // ISSUE: reference to a compiler-generated method
        this.n.Add(bh.q());
      }
    }
  }

  public void ak()
  {
    this.ac();
    this.ad();
    this.ae();
    this.af();
    this.ag();
    this.ah();
    this.ai();
    this.aj();
  }
}
