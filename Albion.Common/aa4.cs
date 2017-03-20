// Decompiled with JetBrains decompiler
// Type: aa4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class aa4
{
  private GameTimeStamp a;
  private GameTimeStamp b;
  private ahy c;

  public aa4()
  {
  }

  public aa4(aa4 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.r(A_0.o());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.q(A_0.p());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.p(A_0.q());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(A_0.r());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.o(A_0.s());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(A_0.t());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(A_0.v());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.o(A_0.w());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(A_0.x());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(A_0.y());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(A_0.z());
    this.a = A_0.a;
    this.b = A_0.b;
    this.c = A_0.c;
  }

  [SpecialName]
  public GameTimeStamp u()
  {
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.a(this.b, this.t());
  }

  public void m(double A_0)
  {
    this.m(A_0, true, false);
  }

  public void m(double A_0, bool A_1)
  {
    this.m(A_0, A_1, false);
  }

  public void m(double A_0, bool A_1, bool A_2)
  {
    kx kx = kx.f(A_0);
    if (A_1)
      this.n(kx.g, kx, kx, kx.h, A_2);
    else
      this.n(kx, kx, kx.g, kx.g(kx.h), A_2);
  }

  public void m(kx A_0, kx A_1, kx A_2)
  {
    this.m(A_0, A_1, A_1, A_2, false);
  }

  public void m(kx A_0, kx A_1, kx A_2, kx A_3)
  {
    this.m(A_0, A_1, A_2, A_3, false);
  }

  public void m(kx A_0, kx A_1, kx A_2, kx A_3, bool A_4)
  {
    this.m(A_0, kx.g, A_1, A_2, A_3, false, A_4);
  }

  public void m(kx A_0, kx A_1, kx A_2, kx A_3, kx A_4, bool A_5, bool A_6)
  {
    if (kx.k(A_1, A_2))
      A_1 = A_2;
    // ISSUE: reference to a compiler-generated method
    this.p(A_3);
    // ISSUE: reference to a compiler-generated method
    this.r(kx.f(A_2, A_3));
    // ISSUE: reference to a compiler-generated method
    this.q(kx.g(A_1, A_3));
    // ISSUE: reference to a compiler-generated method
    if (A_4.i() == 0L)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(kx.g);
      // ISSUE: reference to a compiler-generated method
      this.n(new ahy(0L));
      // ISSUE: reference to a compiler-generated method
      this.m(ahy.h);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.n(ahy.l(Math.Abs(A_4.m())));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.o(A_4.i() < 0L ? kx.g(kx.h) : kx.h);
      if (A_5)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.o(kx.k(this.q(), A_0) ? kx.h : kx.g(kx.h));
      }
      this.n();
    }
    // ISSUE: reference to a compiler-generated method
    this.c = this.y();
    this.n(GameTimeStamp.Now, A_0, !A_6);
  }

  public void n(kx A_0, kx A_1, kx A_2)
  {
    this.n(A_0, A_1, A_1, A_2, false);
  }

  public void n(kx A_0, kx A_1, kx A_2, kx A_3)
  {
    this.n(A_0, A_1, A_2, A_3, false);
  }

  public void n(kx A_0, kx A_1, kx A_2, kx A_3, bool A_4)
  {
    this.n(A_0, kx.g, A_1, A_2, A_3, false, A_4);
  }

  public void n(kx A_0, kx A_1, kx A_2, kx A_3, kx A_4, bool A_5, bool A_6)
  {
    if (kx.k(A_1, A_2))
      A_1 = A_2;
    // ISSUE: reference to a compiler-generated method
    this.p(A_3);
    // ISSUE: reference to a compiler-generated method
    this.r(kx.f(A_2, A_3));
    // ISSUE: reference to a compiler-generated method
    this.q(kx.g(A_1, A_3));
    // ISSUE: reference to a compiler-generated method
    if (A_4.i() == 0L)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(kx.g);
      // ISSUE: reference to a compiler-generated method
      this.n(new ahy(0L));
      // ISSUE: reference to a compiler-generated method
      this.m(ahy.h);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.n(ahy.l(1));
      // ISSUE: reference to a compiler-generated method
      this.o(A_4);
      if (A_5)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.o(kx.k(this.q(), A_0) ? kx.f(A_4) : kx.g(kx.f(A_4)));
      }
      this.n();
    }
    // ISSUE: reference to a compiler-generated method
    this.c = this.y();
    this.n(GameTimeStamp.Now, A_0, !A_6);
  }

  public void m(GameTimeStamp A_0, kx A_1, bool A_2)
  {
    this.t(A_0);
    // ISSUE: reference to a compiler-generated method
    this.p(A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.r(kx.f(this.o(), A_1));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.q(kx.g(this.p(), A_1));
    if (A_2)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kx.k(this.q(), this.v()))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.s().i() < 0L)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.o(kx.g(this.s()));
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.s().i() > 0L)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.o(kx.g(this.s()));
        }
      }
    }
    this.b = this.m(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(this.v());
    // ISSUE: reference to a compiler-generated method
    this.o(this.u());
    this.n();
    this.ac();
  }

  private void n()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.s().i() == 0L)
    {
      // ISSUE: reference to a compiler-generated method
      this.m(ahy.h);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      kx A_0 = kx.p(this.o(), this.p());
      // ISSUE: reference to a compiler-generated method
      kx kx = kx.f(this.s());
      if (kx.m(kx, kx.h))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.m(ahy.k(this.t(), (float) A_0.m()));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.m(ahy.k(this.t(), (float) kx.n(A_0, kx).p()));
      }
    }
  }

  public kx aa()
  {
    return this.t(GameTimeStamp.Now);
  }

  public bool ab()
  {
    return this.p(GameTimeStamp.Now);
  }

  public bool p(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.r() || GameTimeStamp.i(A_0, this.w()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return kx.m(this.x(), this.q());
    }
    // ISSUE: reference to a compiler-generated method
    return this.z().Ticks <= A_0.Ticks;
  }

  public void s(kx A_0)
  {
    this.m(A_0, GameTimeStamp.Now);
  }

  public void m(kx A_0, GameTimeStamp A_1)
  {
    this.t(A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    kx kx = kx.f(kx.q(this.v(), A_0), this.p(), this.o());
    // ISSUE: reference to a compiler-generated method
    if (!kx.l(kx, this.v()))
      return;
    // ISSUE: reference to a compiler-generated method
    if (this.p(A_1) && !this.r())
    {
      this.m(A_1, kx);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.n(kx);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.m(this.v());
      // ISSUE: reference to a compiler-generated method
      this.o(this.u());
      this.ac();
    }
  }

  protected void ac()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.s().i() == 0L || this.t().o == 0L)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (kx.m(this.v(), this.q()))
      {
        this.c = ahy.h;
        // ISSUE: reference to a compiler-generated method
        this.n(this.u());
      }
      else
      {
        this.c = ahy.f;
        // ISSUE: reference to a compiler-generated method
        this.n(GameTimeStamp.MaxValue);
      }
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (this.r())
      {
        // ISSUE: reference to a compiler-generated method
        this.n(this.u());
        this.m();
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
        if (this.s().i() < 0L && kx.h(this.v(), this.q()) || this.s().i() > 0L && kx.i(this.v(), this.q()))
        {
          this.c = ahy.h;
          // ISSUE: reference to a compiler-generated method
          this.n(this.u());
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.n(GameTimeStamp.b(this.u(), ahy.k(this.t(), (float) kx.n(kx.f(kx.p(this.q(), this.v())), kx.f(this.s())).p())));
        }
      }
    }
  }

  public ahy ad()
  {
    return this.q(GameTimeStamp.Now);
  }

  public ahy q(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.s().i() == 0L || this.t().o == 0L || this.r())
      return this.c;
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.c(this.z(), A_0);
  }

  private void m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c = ahy.k(this.t(), (float) kx.n(kx.f(kx.p(this.q(), this.v())), kx.f(this.s())).p());
  }

  public void ae()
  {
    this.r(GameTimeStamp.Now);
  }

  public void r(GameTimeStamp A_0)
  {
    this.t(A_0);
    // ISSUE: reference to a compiler-generated method
    this.m(true);
    this.a = this.u();
    // ISSUE: reference to a compiler-generated method
    this.n(this.u());
    // ISSUE: reference to a compiler-generated method
    this.o(this.u());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(this.v());
    this.ac();
  }

  public void af()
  {
    this.s(GameTimeStamp.Now);
  }

  public void s(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(false);
    // ISSUE: reference to a compiler-generated method
    this.m(A_0, this.v());
  }

  public void m(GameTimeStamp A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.n(A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(kx.f(this.v(), this.p(), this.o()));
    this.a = A_0;
    // ISSUE: reference to a compiler-generated method
    this.b = GameTimeStamp.b(A_0, this.t());
    // ISSUE: reference to a compiler-generated method
    this.o(this.u());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.m(this.v());
    this.ac();
  }

  public void n(GameTimeStamp A_0, kx A_1, bool A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_2);
    this.m(A_0, A_1);
  }

  public void m(GameTimeStamp A_0, kx A_1, kx A_2, bool A_3, bool A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(A_4);
    this.m(A_0, A_1, A_2, A_3);
  }

  public void m(GameTimeStamp A_0, kx A_1, kx A_2, bool A_3)
  {
    // ISSUE: reference to a compiler-generated method
    this.n(A_1);
    this.a = A_0;
    // ISSUE: reference to a compiler-generated method
    this.b = GameTimeStamp.b(A_0, this.t());
    this.m(A_0, A_2, A_3);
  }

  private GameTimeStamp m(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.s().i() == 0L)
      return GameTimeStamp.MaxValue;
    if (GameTimeStamp.h(this.a, A_0))
      A_0 = this.a;
    // ISSUE: reference to a compiler-generated method
    ahy A_1 = new ahy(GameTimeStamp.c(A_0, this.a).o % this.t().o);
    // ISSUE: reference to a compiler-generated method
    return GameTimeStamp.a(GameTimeStamp.b(A_0, this.t()), A_1);
  }

  public void m(GameTimeStamp A_0, kx A_1, GameTimeStamp A_2)
  {
    bool flag = GameTimeStamp.i(A_2, A_0);
    this.n(A_0, A_1, !flag);
    if (flag || !GameTimeStamp.e(A_2, GameTimeStamp.Now))
      return;
    this.s(A_2);
  }

  public void n(GameTimeStamp A_0, kx A_1, GameTimeStamp A_2)
  {
    bool A_2_1 = GameTimeStamp.i(A_2, A_0);
    this.n(A_0, A_1, A_2_1);
    if (A_2_1 || !GameTimeStamp.e(A_2, GameTimeStamp.Now))
      return;
    this.r(A_2);
  }

  public kx t(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.r() || GameTimeStamp.h(this.b, A_0) || this.t().o <= 0L || this.s().i() == 0L || (this.s().i() < 0L && kx.h(this.v(), this.p()) || this.s().i() > 0L && kx.i(this.v(), this.o())) || (this.s().i() < 0L && kx.h(this.v(), this.q()) || this.s().i() > 0L && kx.i(this.v(), this.q())))
    {
      // ISSUE: reference to a compiler-generated method
      return this.v();
    }
    // ISSUE: reference to a compiler-generated method
    if (GameTimeStamp.d(A_0, this.z()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.n(this.q());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b = GameTimeStamp.b(this.z(), this.t());
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      long A_1 = GameTimeStamp.c(A_0, this.b).o / this.t().o + 1L;
      aa4 aa4 = this;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      kx A_0_1 = kx.q(aa4.v(), kx.f(this.s(), A_1));
      // ISSUE: reference to a compiler-generated method
      aa4.n(A_0_1);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.n(kx.f(this.v(), this.p(), this.o()));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (this.s().i() < 0L)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.n(kx.f(this.v(), this.q(), this.o()));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.n(kx.f(this.v(), this.p(), this.q()));
      }
      this.b = this.m(A_0);
    }
    // ISSUE: reference to a compiler-generated method
    return this.v();
  }
}
