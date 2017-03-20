// Decompiled with JetBrains decompiler
// Type: aaq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using Albion.Common.Time;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class aaq : ee, IDisposable
{
  protected List<aak> e = new List<aak>();
  protected const int a = 3;
  protected aaq.b b;
  protected aaq.c c;
  protected aaq.d d;
  protected aag f;
  protected g8 g;

  public aaq(aag A_0, g8 A_1)
  {
    this.f = A_0;
    this.g = A_1;
    // ISSUE: reference to a compiler-generated method
    this.o(new List<aaq.e>());
  }

  [SpecialName]
  public bool o()
  {
    return this.o(typeof (hx));
  }

  [SpecialName]
  public bool p()
  {
    return this.o(typeof (g2));
  }

  [SpecialName]
  public bool q()
  {
    return this.o((Func<aak, bool>) (A_0 =>
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0.n() is g2)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ((g2) A_0.n()).h3() != g2.InvisibleTo.Mobs;
      }
      return false;
    }));
  }

  [SpecialName]
  public bool r()
  {
    return this.o(typeof (g1));
  }

  [SpecialName]
  public bool s()
  {
    return this.o(typeof (h0));
  }

  [SpecialName]
  public bool t()
  {
    return this.o(typeof (h1));
  }

  [SpecialName]
  public bool u()
  {
    return this.o(typeof (hz));
  }

  [SpecialName]
  public bool v()
  {
    return this.o(typeof (hu));
  }

  [SpecialName]
  public bool w()
  {
    return this.o(typeof (e4));
  }

  [SpecialName]
  public IEnumerable<aak> y()
  {
    return (IEnumerable<aak>) this.e;
  }

  [SpecialName]
  public void o(aaq.b A_0)
  {
    this.b += A_0;
  }

  [SpecialName]
  public void p(aaq.b A_0)
  {
    this.b -= A_0;
  }

  [SpecialName]
  public void o(aaq.c A_0)
  {
    this.c += A_0;
  }

  [SpecialName]
  public void p(aaq.c A_0)
  {
    this.c -= A_0;
  }

  [SpecialName]
  public void o(aaq.d A_0)
  {
    this.d += A_0;
  }

  [SpecialName]
  public void p(aaq.d A_0)
  {
    this.d -= A_0;
  }

  public void Dispose()
  {
    this.z();
    if (this.f == null)
      return;
    this.f.a((object) this);
  }

  public float cc(PlayerAttribute A_0)
  {
    if (A_0 == PlayerAttribute.BalanceModifier || A_0 == PlayerAttribute.FocusFireModifier || A_0 == PlayerAttribute.HealingSicknessModifier)
      return this.p(A_0);
    return this.o(A_0);
  }

  public float cd(string A_0, int A_1)
  {
    return this.o(A_0, A_1, e6.ResourceGatheringBuffTypes.GatheringSpeed);
  }

  public float ce(string A_0, int A_1)
  {
    return this.o(A_0, A_1, e6.ResourceGatheringBuffTypes.GatheringYield);
  }

  private float o(string A_0, int A_1, e6.ResourceGatheringBuffTypes A_2)
  {
    this.ac();
    float num1 = 0.0f;
    for (int index = 0; index < this.e.Count; ++index)
    {
      aak aak = this.e[index];
      // ISSUE: reference to a compiler-generated method
      e6 e6 = aak.n() as e6;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (e6 != null && e6.h5() == A_2 && (e6.h3() == A_0 && e6.h4() == A_1))
      {
        // ISSUE: reference to a compiler-generated method
        float num2 = e6.h6();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float num3 = (num2 + num2 * e6.iw() * (float) aak.v()) * (float) this.e[index].u();
        num1 += num3;
      }
    }
    return num1;
  }

  public void z()
  {
    if (this.e.Count > 0)
    {
      List<aak> e = this.e;
      this.e = new List<aak>();
      foreach (aak aak in e)
        aak.Dispose();
    }
    // ISSUE: reference to a compiler-generated method
    this.x().Clear();
    this.o(aaq.a.f);
  }

  public bool aa()
  {
    return this.e.Count == 0;
  }

  protected bool p(aak A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aaq.f f = new aaq.f();
    // ISSUE: reference to a compiler-generated field
    f.a = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aaq.e e1 = this.x().Find(new Predicate<aaq.e>(f.b));
    if (e1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      if (GameTimeStamp.f(e1.l(), e1.k()) && (GameTimeStamp.h(f.a.r(), e1.l()) || GameTimeStamp.g(f.a.q(), f.a.r())))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        e1.i(f.a.r());
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      e1.n()[f.a.p()] = f.a;
      return true;
    }
    int num = 0;
    aaq.e e2 = (aaq.e) null;
    // ISSUE: reference to a compiler-generated method
    foreach (aaq.e e3 in this.x())
    {
      // ISSUE: reference to a compiler-generated field
      if (e3.j() == f.a.o())
      {
        ++num;
        if (e3.j().d8 == gs.StackingRules.ReplaceWeakest)
        {
          if (e2 == null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if ((double) e3.i().e() <= (double) f.a.l().e())
              e2 = e3;
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if ((double) e3.i().e() < (double) e2.i().e() || (double) e3.i().e() == (double) e2.i().e() && GameTimeStamp.i(e3.k(), e2.k()))
              e2 = e3;
          }
        }
        else if (e2 == null || GameTimeStamp.i(e3.k(), e2.k()))
          e2 = e3;
      }
    }
    // ISSUE: reference to a compiler-generated field
    if (num >= f.a.o().d6)
    {
      if (e2 == null)
        return false;
      // ISSUE: reference to a compiler-generated method
      foreach (aak aak in e2.n())
      {
        if (aak != null)
        {
          this.e.Remove(aak);
          aak.Dispose();
        }
      }
      // ISSUE: reference to a compiler-generated method
      this.x().Remove(e2);
      this.o(aaq.a.e);
    }
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    aaq.e e4 = new aaq.e(f.a.l());
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    e4.i(f.a.r());
    aaq.e e5 = e4;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated field
    e5.n()[f.a.p()] = f.a;
    // ISSUE: reference to a compiler-generated method
    this.x().Add(e5);
    return true;
  }

  protected void ab()
  {
    aaq.e[] array = (aaq.e[]) null;
    if (this.d != null || this.c != null)
    {
      // ISSUE: reference to a compiler-generated method
      array = this.x().ToArray();
    }
    // ISSUE: reference to a compiler-generated method
    this.x().Clear();
    foreach (aak A_0 in this.e)
      this.p(A_0);
    if (this.d != null)
    {
      foreach (aaq.e e in array)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        aaq.g g = new aaq.g();
        // ISSUE: reference to a compiler-generated field
        g.a = e;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!this.x().Exists(new Predicate<aaq.e>(g.b)))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.d(g.a.j(), g.a.k());
        }
      }
    }
    if (this.c == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (aaq.e e in this.x())
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      aaq.h h = new aaq.h();
      // ISSUE: reference to a compiler-generated field
      h.a = e;
      // ISSUE: reference to a compiler-generated method
      if (!Array.Exists<aaq.e>(array, new Predicate<aaq.e>(h.b)))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.c(h.a.j(), h.a.k());
      }
    }
  }

  protected float o(PlayerAttribute A_0)
  {
    this.ac();
    float num1 = 0.0f;
    for (int index = 0; index < this.e.Count; ++index)
    {
      aak aak = this.e[index];
      // ISSUE: reference to a compiler-generated method
      ht ht = aak.n() as ht;
      // ISSUE: reference to a compiler-generated method
      if (ht != null && ht.h4() == A_0)
      {
        // ISSUE: reference to a compiler-generated method
        float num2 = ht.h3();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float A_1 = (num2 + num2 * ht.iw() * (float) aak.v()) * (float) this.e[index].u();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        num1 += p3.a(A_0, A_1, this.g.ar(), aak.l().e(), ht.i3());
      }
    }
    return num1;
  }

  public float o(string A_0)
  {
    this.ac();
    float num1 = 0.0f;
    for (int index = 0; index < this.e.Count; ++index)
    {
      aak aak = this.e[index];
      // ISSUE: reference to a compiler-generated method
      e5 e5 = aak.n() as e5;
      // ISSUE: reference to a compiler-generated method
      if (e5 != null && e5.h3() == A_0)
      {
        // ISSUE: reference to a compiler-generated method
        float num2 = e5.h5();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float num3 = (num2 + num2 * e5.iw() * (float) aak.v()) * (float) this.e[index].u();
        num1 += num3;
      }
    }
    return num1;
  }

  protected float p(PlayerAttribute A_0)
  {
    this.ac();
    float num1 = 0.0f;
    bool flag = false;
    foreach (aak aak in this.e)
    {
      // ISSUE: reference to a compiler-generated method
      if (aak.n() is ht)
      {
        // ISSUE: reference to a compiler-generated method
        ht ht = (ht) aak.n();
        // ISSUE: reference to a compiler-generated method
        if (ht.h4() == A_0)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          float num2 = p3.a(A_0, ht.h3(), this.g.ar(), aak.l().e(), ht.i3());
          if ((double) num1 < (double) num2 || !flag)
          {
            // ISSUE: reference to a compiler-generated method
            num1 = ht.h3();
            flag = true;
          }
        }
      }
    }
    return num1;
  }

  protected bool o(System.Type A_0)
  {
    foreach (aak aak in this.e)
    {
      // ISSUE: reference to a compiler-generated method
      if (aak.n().GetType() == A_0)
        return true;
    }
    return false;
  }

  public void o(short[] A_0, float[] A_1, long[] A_2, BitArray A_3, int[] A_4, byte[] A_5, byte[] A_6, h2 A_7)
  {
    if (this.f != null)
      this.f.a((object) this);
    aaq.e[] array = (aaq.e[]) null;
    if (this.d != null || this.c != null)
    {
      // ISSUE: reference to a compiler-generated method
      array = this.x().ToArray();
    }
    this.z();
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    for (int index = 0; index < A_0.Length; ++index)
    {
      gs A_0_1 = A_7.h0((int) A_0[index]);
      byte num4 = A_5[index];
      if (A_0_1 != null)
      {
        GameTimeStamp A_0_2 = new GameTimeStamp(A_2[index]);
        float A_0_3 = A_1[index];
        aal aal = new aal();
        // ISSUE: reference to a compiler-generated method
        aal.d(A_0_1);
        // ISSUE: reference to a compiler-generated method
        aal.d(A_0_3);
        // ISSUE: reference to a compiler-generated method
        aal.d(A_0_2);
        aal A_1_1 = aal;
        // ISSUE: reference to a compiler-generated method
        for (int A_3_1 = 0; A_3_1 < A_0_1.jt().Count; ++A_3_1)
        {
          // ISSUE: reference to a compiler-generated method
          et et = (et) A_0_1.jt()[A_3_1];
          if (et is e3 && A_3[num1 * 3])
          {
            ahy A_1_2 = ahy.h;
            if (A_3[num1 * 3 + 1])
              A_1_2 = ahy.k(A_4[num2++]);
            int A_0_4 = 0;
            if (A_3[num1 * 3 + 2])
              A_0_4 = (int) A_6[num3++];
            // ISSUE: reference to a compiler-generated method
            aak A_0_5 = new aak(this, A_1_1, (e3) et, A_3_1, A_1_2.o > 0L ? GameTimeStamp.b(A_0_2, A_1_2) : GameTimeStamp.b(A_0_2, ((e3) et).@if()));
            // ISSUE: reference to a compiler-generated method
            A_0_5.m((int) num4);
            // ISSUE: reference to a compiler-generated method
            A_0_5.n(A_0_4);
            this.q(A_0_5);
          }
          ++num1;
        }
      }
    }
    if (this.d != null)
    {
      foreach (aaq.e e in array)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        aaq.i i = new aaq.i();
        // ISSUE: reference to a compiler-generated field
        i.a = e;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!this.x().Exists(new Predicate<aaq.e>(i.b)))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.d(i.a.j(), i.a.k());
        }
      }
    }
    if (this.c != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (aaq.e e in this.x())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        aaq.j j = new aaq.j();
        // ISSUE: reference to a compiler-generated field
        j.a = e;
        // ISSUE: reference to a compiler-generated method
        if (!Array.Exists<aaq.e>(array, new Predicate<aaq.e>(j.b)))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.c(j.a.j(), j.a.k());
        }
      }
    }
    this.o(aaq.a.a);
    this.ac();
  }

  public bool o(Func<aak, bool> A_0)
  {
    for (int index = this.e.Count - 1; index >= 0; --index)
    {
      if (A_0(this.e[index]))
        return true;
    }
    return false;
  }

  public bool o(gs.SpellCategory A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    return this.o(new Func<aak, bool>(new aaq.k() { a = A_0 }.b));
  }

  public bool p(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.x().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (this.x()[index].j().jp() == A_0)
        return true;
    }
    return false;
  }

  public bool o(gs A_0)
  {
    return this.o(A_0, true);
  }

  public bool p(gs A_0)
  {
    return this.o(A_0, false);
  }

  public bool o(gs A_0, bool A_1)
  {
    if (A_0 == null)
      return false;
    for (int index = this.e.Count - 1; index >= 0; --index)
    {
      // ISSUE: reference to a compiler-generated method
      g3 g3 = this.e[index].n() as g3;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (g3 != null && (!string.IsNullOrEmpty(g3.h3()) && (g3.h3() == A_0.jp() || A_1 && g3.h3() == "*") || g3.h4() != gs.SpellCategory.None && g3.h4() == A_0.d1))
        return true;
    }
    return false;
  }

  protected void ac()
  {
    int count = this.e.Count;
    // ISSUE: reference to a compiler-generated method
    while (this.e.Count > 0 && this.e[0].t() && GameTimeStamp.e(this.e[0].r(), GameTimeStamp.Now))
    {
      aak aak = this.e[0];
      this.e.RemoveAt(0);
      aak.Dispose();
    }
    if (count == this.e.Count)
      return;
    this.ab();
    this.o(aaq.a.c);
  }

  protected aak q(aak A_0)
  {
    if (!this.p(A_0_1))
      return (aak) null;
    int index = this.e.BinarySearch(A_0_1);
    if (index < 0)
      index = ~index;
    this.e.Insert(index, A_0_1);
    if (A_0_1.t() && this.f != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.f.a((object) this, (aag.a) (A_0_2 => this.ac()), A_0_1.r());
    }
    return A_0_1;
  }

  protected virtual void o(aaq.a A_0)
  {
    try
    {
      if (this.b == null)
        return;
      this.b(this, A_0);
    }
    catch (Exception ex)
    {
      ab0.a(ex.ToString());
    }
  }

  public enum a
  {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
  }

  public delegate void b(aaq A_0, aaq.a A_1);

  public delegate void c(gs A_0, GameTimeStamp A_1);

  public delegate void d(gs A_0, GameTimeStamp A_1);

  public class e
  {
    public e(aal A_0)
    {
      // ISSUE: reference to a compiler-generated method
      this.i(A_0);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.i(new aak[A_0.d().jt().Count]);
    }

    [SpecialName]
    public gs j()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.i().d();
    }

    [SpecialName]
    public GameTimeStamp k()
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.i().f();
    }

    [SpecialName]
    public bool m()
    {
      // ISSUE: reference to a compiler-generated method
      return GameTimeStamp.f(this.k(), this.l());
    }

    [SpecialName]
    public float o()
    {
      if (this.m())
      {
        // ISSUE: reference to a compiler-generated method
        return abh.b(this.k().Ticks, this.l().Ticks, GameTimeStamp.Now.Ticks);
      }
      return 0.0f;
    }

    [SpecialName]
    public int p()
    {
      int num = 1;
      // ISSUE: reference to a compiler-generated method
      for (int index = 0; index < this.n().Length; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.n()[index] != null && this.n()[index].u() > num)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          num = this.n()[index].u();
        }
      }
      return num;
    }
  }
}
