// Decompiled with JetBrains decompiler
// Type: aht
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;

public class aht
{
  public static ahy a = ahy.k(100);
  public bool f = true;
  public bool g = true;
  private float j = float.MinValue;
  private Action<long, ahm> b;
  private Action<long> c;
  private aho d;
  private Dictionary<long, aht.a> e;
  public bool h;
  public int i;
  private ab9 k;

  [SpecialName]
  public void t(Action<long, ahm> A_0)
  {
    Action<long, ahm> action = this.b;
    Action<long, ahm> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<long, ahm>>(ref this.b, comparand + A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public void u(Action<long, ahm> A_0)
  {
    Action<long, ahm> action = this.b;
    Action<long, ahm> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<long, ahm>>(ref this.b, comparand - A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public void t(Action<long> A_0)
  {
    Action<long> action = this.c;
    Action<long> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<long>>(ref this.c, comparand + A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public void u(Action<long> A_0)
  {
    Action<long> action = this.c;
    Action<long> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<long>>(ref this.c, comparand - A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public aho x()
  {
    return this.d;
  }

  [SpecialName]
  public bool y()
  {
    return this.d == null;
  }

  [SpecialName]
  public float ad()
  {
    return this.j;
  }

  public void t(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.t(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.v(aim.a(A_0, "time", 1f));
    // ISSUE: reference to a compiler-generated method
    this.u(aim.a(A_0, "maxheightdelta", -1f));
    this.t(aim.e(A_0, "area"), ref this.d);
    this.w(0.0f);
  }

  public void t(long A_0, ahk A_1, float A_2, GameTimeStamp A_3, ab9 A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.t(A_0);
    this.x().y(k2.a(k2.a(abh.d(A_2)), k2.a(A_1)));
    // ISSUE: reference to a compiler-generated method
    this.u(A_3);
    // ISSUE: reference to a compiler-generated method
    this.t(A_3);
    // ISSUE: reference to a compiler-generated method
    this.t(A_1);
    // ISSUE: reference to a compiler-generated method
    this.t(A_2);
    // ISSUE: reference to a compiler-generated method
    this.t(new ace(A_1, this.x().c9()));
    this.k = A_4;
    // ISSUE: reference to a compiler-generated method
    this.t(false);
  }

  public void t(g8 A_0)
  {
    foreach (ahp ahp in this.ah())
      ahp.y(A_0);
  }

  public List<ahp> ah()
  {
    List<ahp> A_1 = new List<ahp>();
    this.t((ahm) this.x(), ref A_1);
    return A_1;
  }

  private void t(ahm A_0, ref List<ahp> A_1)
  {
    if (A_0 is ahn)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ahm A_0_1 in (A_0 as ahn).ac())
        this.t(A_0_1, ref A_1);
    }
    else
    {
      if (!(A_0 is ahp))
        return;
      A_1.Add(A_0 as ahp);
    }
  }

  private void t(XmlElement A_0, ref aho A_1)
  {
    if (A_0 == null)
      return;
    A_1 = new aho(this);
    A_1.dc(A_0);
  }

  public void t(long A_0, ahk A_1, float A_2, GameTimeStamp A_3, bool A_4)
  {
    if (this.e == null)
      this.e = new Dictionary<long, aht.a>();
    aht.a A_0_1;
    if (this.e.TryGetValue(A_0, out A_0_1))
    {
      if (A_4)
      {
        while (GameTimeStamp.i(GameTimeStamp.b(A_0_1.e, aht.a), A_3))
        {
          GameTimeStamp A_1_1 = GameTimeStamp.b(A_0_1.e, aht.a);
          A_0_1.d = ahk.a(A_0_1.d, A_1, abh.b(A_0_1.e.Ticks, A_3.Ticks, A_1_1.Ticks));
          A_0_1.e = A_1_1;
          this.t(A_0_1, A_1_1);
        }
      }
      A_0_1.e = A_3;
      A_0_1.d = A_1;
      this.t(A_0_1, A_3);
    }
    else
    {
      aht.a A_0_2 = new aht.a()
      {
        a = A_0,
        d = A_1,
        f = A_2,
        e = A_3
      };
      this.e.Add(A_0, A_0_2);
      this.t(A_0_2, A_3);
    }
  }

  public void v(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.t(A_0);
    if (this.e == null || this.e.Count <= 0)
      return;
    // ISSUE: reference to a compiler-generated method
    this.x().y().y(A_0);
    this.t();
    foreach (KeyValuePair<long, aht.a> keyValuePair in this.e)
      this.t(keyValuePair.Value, A_0);
  }

  private void t()
  {
    // ISSUE: reference to a compiler-generated method
    if (!this.h || this.k == null || this.ag())
      return;
    // ISSUE: reference to a compiler-generated method
    this.t(this.x().db(this.k));
  }

  private void t(aht.a A_0, GameTimeStamp A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (!this.f && A_0.b && (!this.g || !A_0.c) || GameTimeStamp.i(A_1, this.aa()))
      return;
    // ISSUE: reference to a compiler-generated method
    float A_0_1 = (float) GameTimeStamp.c(A_1, this.aa()).t();
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0_1 > (double) this.u())
      return;
    // ISSUE: reference to a compiler-generated method
    this.x().y().dd(A_0_1);
    ahm ahm = this.u(new ace(A_0.d, A_0.f));
    bool flag = ahm != null;
    if (!flag && A_0.c && (this.g && this.c != null))
      this.c(A_0.a);
    if (flag && !A_0.c && this.b != null)
      this.b(A_0.a, ahm);
    A_0.c = flag;
    A_0.b |= flag;
  }

  public aht ai()
  {
    aht aht = new aht();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aht.v(this.u());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aht.t(this.z());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aht.u(this.w());
    aht A_0 = aht;
    A_0.d = (aho) this.d.c8(A_0);
    return A_0;
  }

  public ahm u(ace A_0)
  {
    if (this.x() != null)
      return this.x().da(A_0);
    return (ahm) null;
  }

  public void w(float A_0)
  {
    if ((double) this.j == (double) A_0)
      return;
    this.j = A_0;
    if (this.x() == null)
      return;
    this.x().dd(A_0);
  }

  public void w(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.w((float) GameTimeStamp.c(A_0, this.aa()).t());
  }

  private class a
  {
    public long a;
    public bool b;
    public bool c;
    public ahk d;
    public GameTimeStamp e;
    public float f;
  }
}
