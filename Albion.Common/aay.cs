// Decompiled with JetBrains decompiler
// Type: aay
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class aay
{
  public static bool d = true;
  private float a = 1f;
  private float b = 0.3f;
  private aay.b c = new aay.b();

  public aay(ab9 A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new aa0());
    // ISSUE: reference to a compiler-generated method
    this.a(A_0);
    // ISSUE: reference to a compiler-generated method
    this.w(A_1);
    // ISSUE: reference to a compiler-generated method
    this.a(aay.c.a);
    // ISSUE: reference to a compiler-generated method
    this.s(false);
    // ISSUE: reference to a compiler-generated method
    this.s(7f);
  }

  [SpecialName]
  public float s()
  {
    return 0.3f;
  }

  [SpecialName]
  public float u()
  {
    return this.b;
  }

  [SpecialName]
  public void t(float A_0)
  {
    this.b = A_0;
  }

  public void a(ahk A_0, ahk A_1, float A_2, float A_3)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(true);
    // ISSUE: reference to a compiler-generated method
    this.s(A_0);
    // ISSUE: reference to a compiler-generated method
    this.a(A_1);
    // ISSUE: reference to a compiler-generated method
    this.a(A_2 + A_3);
  }

  public void aj()
  {
    // ISSUE: reference to a compiler-generated method
    this.a(false);
  }

  public static ahk a(ahk A_0, ahk A_1, float A_2, float A_3, float A_4)
  {
    if ((double) A_4 == 1.0 && (double) ahk.c(A_0, A_1).k() < (double) A_2 + (double) A_3)
      return A_0;
    ahk A_0_1 = ahk.c(A_0, A_1).m();
    return ahk.d(A_1, ahk.b(ahk.b(A_0_1, A_4), A_2 + A_3));
  }

  public ahk u(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ae())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return aay.a(this.ab(), A_0, this.ah(), 0.0f, 1f);
    }
    return ahk.d();
  }

  public ahk ak()
  {
    return this.x(1f);
  }

  public ahk x(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ae())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return aay.a(this.ab(), this.af(), this.ah(), 0.0f, A_0);
    }
    return ahk.d();
  }

  public void a(aaz A_0, aaz A_1, GameTimeStamp A_2, aay.c A_3, out ahk A_4, out float A_5)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num = (float) (GameTimeStamp.c(A_2, A_0.i()).t() / GameTimeStamp.c(A_1.i(), A_0.i()).t());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_3 == aay.c.b && (double) ahk.c(A_0.k(), A_1.k()).j() >= 0.0100000007078052)
    {
      // ISSUE: reference to a compiler-generated method
      ahk A_1_1 = abh.g(A_0.m());
      // ISSUE: reference to a compiler-generated method
      ahk A_3_1 = abh.g(A_1.m());
      ahk A_7;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      abh.a(A_0.k(), A_1_1, A_1.k(), A_3_1, 0.2f, num, out A_4, out A_7);
      A_5 = abh.b(A_7);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ahk A_0_1 = ahk.c(A_1.k(), A_0.k());
      // ISSUE: reference to a compiler-generated method
      A_4 = ahk.d(A_0.k(), ahk.b(A_0_1, num));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_5 = abh.c(A_0.m(), A_1.m(), abh.a(num));
    }
  }

  public void a(aaz A_0, GameTimeStamp A_1, out ahk A_2, out float A_3, out float A_4)
  {
    if (!A_0.o())
    {
      // ISSUE: reference to a compiler-generated method
      A_2 = A_0.k();
      // ISSUE: reference to a compiler-generated method
      A_3 = A_0.m();
      // ISSUE: reference to a compiler-generated method
      aaz aaz = this.x().d(A_0);
      if (aaz != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_4 = aaz.n();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        A_4 = A_0.n();
      }
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      float val1 = (float) GameTimeStamp.c(A_1, A_0.i()).t();
      float num1 = Math.Min(val1, this.a);
      // ISSUE: reference to a compiler-generated method
      float num2 = A_0.n();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ahk A_0_1 = ahk.c(A_0.l(), A_0.k());
      float A_1_1 = A_0_1.k();
      ahk A_0_2 = ahk.a(A_0_1, A_1_1);
      // ISSUE: reference to a compiler-generated method
      if ((double) val1 * (double) A_0.n() >= (double) A_1_1)
      {
        // ISSUE: reference to a compiler-generated method
        A_2 = A_0.l();
        // ISSUE: reference to a compiler-generated method
        A_3 = A_0.m();
        // ISSUE: reference to a compiler-generated method
        A_4 = A_0.n();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        A_2 = ahk.d(A_0.k(), ahk.b(A_0_2, num2 * num1));
        // ISSUE: reference to a compiler-generated method
        A_3 = A_0.m();
        // ISSUE: reference to a compiler-generated method
        A_4 = A_0.n();
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_2 = this.a().f(A_0.k(), A_2, this.ai(), 0);
    }
  }

  public aay.b al()
  {
    return this.a(GameTimeStamp.Now, this.b, 0.0f);
  }

  public aay.b a(GameTimeStamp A_0, float A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num1 = ahk.c(this.ab(), this.af()).j();
    aay.b.MovementMode A_0_1;
    float A_4;
    ahk A_0_2;
    float A_0_3;
    float A_0_4;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (aay.d && this.ae() && (double) num1 < (double) this.t() * (double) this.t() && (double) ahk.c(this.x().c().k(), this.af()).j() > (double) this.ah() * (double) this.ah())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      float num2 = ahk.c(this.ab(), ahk.d(this.af(), ahk.b(this.ag(), A_2))).j();
      A_0_1 = aay.b.MovementMode.PredictedPursuit;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      float val2 = this.x().c().n();
      // ISSUE: reference to a compiler-generated method
      float num3 = Math.Min(this.ag().k(), val2);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_4 = this.x().c().n();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) num1 <= (double) this.ah() * (double) this.ah() && (double) num2 <= (double) num1)
      {
        // ISSUE: reference to a compiler-generated method
        A_0_2 = this.ab();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_3 = abh.b(ahk.c(this.af(), this.ab()));
        A_4 = 0.0f;
        A_0_4 = 0.0f;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ahk ahk1 = aay.a(this.x().c().k(), this.af(), this.ah(), 0.0f, 1f);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ahk ahk2 = this.x().c().k();
        ahk A_0_5 = ahk.c(ahk1, ahk2);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float A_0_6 = ((float) GameTimeStamp.c(A_0, this.x().c().i()).t() + 0.3f) * this.x().c().n();
        ahk ahk3;
        float num4;
        if ((double) A_0_6 >= (double) A_0_5.k())
        {
          ahk3 = ahk1;
          // ISSUE: reference to a compiler-generated method
          num4 = abh.b(ahk.c(this.af(), ahk1));
          A_0_4 = num3;
        }
        else
        {
          ahk3 = ahk.d(ahk2, ahk.a(A_0_6, A_0_5.m()));
          num4 = abh.b(A_0_5);
          A_0_4 = val2;
        }
        // ISSUE: reference to a compiler-generated method
        ahk ahk4 = ahk.c(ahk1, this.ab());
        // ISSUE: reference to a compiler-generated method
        ahk A_0_7 = ahk.c(ahk3, this.ab());
        if ((double) ahk4.b(A_0_7) < 0.0)
        {
          // ISSUE: reference to a compiler-generated method
          ahk3 = ahk.d(this.ab(), ahk.b(ahk.b(ahk4.m(), A_4 * 0.8f), A_2));
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_2 = this.a().f(ahk2, ahk3, this.ai(), 0);
        A_0_3 = num4;
      }
    }
    else
    {
      GameTimeStamp gameTimeStamp = GameTimeStamp.a(A_0, ahy.l((double) A_1));
      aaz A_1_1;
      aaz A_2_1;
      // ISSUE: reference to a compiler-generated method
      this.x().c(gameTimeStamp, out A_1_1, out A_2_1);
      if (A_2_1 != null && A_1_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.a(A_1_1, A_2_1, gameTimeStamp, this.v(), out A_0_2, out A_0_3);
        // ISSUE: reference to a compiler-generated method
        A_4 = A_1_1.n();
        // ISSUE: reference to a compiler-generated method
        A_0_4 = A_1_1.n();
        A_0_1 = aay.b.MovementMode.Interpolation;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.z() == null || GameTimeStamp.f(gameTimeStamp, this.z().ab()))
          A_0_1 = aay.b.MovementMode.TimeStampNotChanged;
      }
      else if (A_2_1 == null && A_1_1 != null)
      {
        this.a(A_1_1, gameTimeStamp, out A_0_2, out A_0_3, out A_4);
        A_0_4 = A_4;
        A_0_1 = aay.b.MovementMode.DeadReckoning;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        A_0_2 = this.ab();
        // ISSUE: reference to a compiler-generated method
        A_0_3 = this.ac();
        A_4 = 0.0f;
        A_0_4 = 0.0f;
        A_0_1 = aay.b.MovementMode.NoData;
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.c.f(A_0_2);
    // ISSUE: reference to a compiler-generated method
    this.c.f(A_0_3);
    // ISSUE: reference to a compiler-generated method
    this.c.g(A_4);
    // ISSUE: reference to a compiler-generated method
    this.c.h(A_0_4);
    // ISSUE: reference to a compiler-generated method
    this.c.f(A_0_1);
    return this.c;
  }

  public aay.a a(ahk A_0, float A_1, float A_2, GameTimeStamp A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aay.a A_0_1 = new aay.a(this.ab(), this.ac(), A_3);
    float A_1_1 = A_2 * A_1;
    // ISSUE: reference to a compiler-generated method
    if (this.ab().c(A_0, 1f / 1000f))
    {
      // ISSUE: reference to a compiler-generated method
      this.t(A_0);
      return A_0_1;
    }
    // ISSUE: reference to a compiler-generated method
    ahk A_0_2 = ahk.c(A_0, this.ab());
    float A_1_2 = A_0_2.k();
    ahk A_0_3 = ahk.a(A_0_2, A_1_2);
    // ISSUE: reference to a compiler-generated method
    ahk A_1_3 = ahk.d(this.ab(), ahk.b(A_0_3, A_1_1));
    if ((double) A_1_2 < (double) A_1_1)
      A_1_3 = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_4 = this.a().h(this.ab(), A_1_3, this.ai());
    // ISSUE: reference to a compiler-generated method
    float A_0_5 = ahk.c(A_0_4, this.ab()).k();
    // ISSUE: reference to a compiler-generated method
    A_0_1.p(ahk.a(A_0_4, A_1_3));
    // ISSUE: reference to a compiler-generated method
    A_0_1.q((double) A_0_5 < (double) A_1_1 * 0.100000001490116);
    // ISSUE: reference to a compiler-generated method
    A_0_1.o(true);
    // ISSUE: reference to a compiler-generated method
    A_0_1.q(A_0_5);
    // ISSUE: reference to a compiler-generated method
    this.t(A_0_4);
    // ISSUE: reference to a compiler-generated method
    this.u(abh.b(A_0_3));
    // ISSUE: reference to a compiler-generated method
    this.v(A_0_5 / A_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.p(this.ab());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.p(this.ac());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.t(this.ad());
    // ISSUE: reference to a compiler-generated method
    this.s(A_0_1);
    return A_0_1;
  }

  public aay.a y(float A_0)
  {
    return this.a(GameTimeStamp.Now, A_0);
  }

  public aay.a a(GameTimeStamp A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.a((int) this.x().f().u());
    // ISSUE: reference to a compiler-generated method
    if (this.aa() == null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.a(new aay.a(this.ab(), this.ac(), A_0));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().o(A_0);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().o(this.ab());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().o(this.ac());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().p(this.ab());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().p(this.ac());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().o(false);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.aa().u(0.0f);
    }
    // ISSUE: reference to a compiler-generated method
    aay.a A_0_1 = this.aa();
    aay.b A_0_2 = this.a(A_0, this.b, A_1);
    // ISSUE: reference to a compiler-generated method
    this.a(A_0_2);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ab().c(A_0_2.f(), 0.0001f) && A_0_2.j() != aay.b.MovementMode.TimeStampNotChanged)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.t(A_0_2.f());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.u(A_0_2.g());
      // ISSUE: reference to a compiler-generated method
      this.v(0.0f);
      // ISSUE: reference to a compiler-generated method
      this.s(A_0_1);
      return A_0_1;
    }
    float A_1_1 = 20f;
    float A_1_2 = A_1_1 * 0.3f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_1_3 = ahk.c(A_0_2.f(), this.ab());
    float A_2 = A_1_3.k();
    if ((double) A_2 > (double) A_1_2)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.t(A_0_2.f());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.u(A_0_2.g());
      // ISSUE: reference to a compiler-generated method
      this.v(0.0f);
      // ISSUE: reference to a compiler-generated method
      A_0_1.o(true);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1.p(this.ab());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1.p(this.ac());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1.q(ahk.c(A_0_1.t(), A_0_1.r()).k());
      // ISSUE: reference to a compiler-generated method
      A_0_1.s(0.0f);
      // ISSUE: reference to a compiler-generated method
      A_0_1.t(0.0f);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1.r(A_0_1.z());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1.u(A_0_1.z());
      // ISSUE: reference to a compiler-generated method
      this.s(A_0_1);
      return A_0_1;
    }
    // ISSUE: reference to a compiler-generated method
    float A_0_3 = A_0_2.h();
    // ISSUE: reference to a compiler-generated method
    if (A_0_2.j() != aay.b.MovementMode.PredictedPursuit)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_3 = abh.d(A_0_2.h(), A_1_1, abh.e(1f, A_1_2, A_2));
    }
    ahk A_0_4;
    if ((double) A_2 < (double) A_0_3 * (double) A_1)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_4 = A_0_2.f();
    }
    else
    {
      A_1_3.l();
      // ISSUE: reference to a compiler-generated method
      A_0_4 = ahk.d(this.ab(), ahk.a(A_0_3 * A_1, A_1_3));
    }
    // ISSUE: reference to a compiler-generated method
    float A_0_5 = ahk.c(A_0_4, A_0_1.r()).k();
    // ISSUE: reference to a compiler-generated method
    this.t(A_0_4);
    // ISSUE: reference to a compiler-generated method
    this.v(A_0_5 / A_1);
    // ISSUE: reference to a compiler-generated method
    if (this.w())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.u(abh.b(ahk.c(A_0_4, A_0_1.r())));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.u(A_0_2.g());
    }
    // ISSUE: reference to a compiler-generated method
    A_0_1.o(true);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.p(this.ab());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.p(this.ac());
    // ISSUE: reference to a compiler-generated method
    A_0_1.q(A_0_5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.r(A_0_2.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.u(A_0_2.i());
    // ISSUE: reference to a compiler-generated method
    A_0_1.s(A_0_3);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0_1.t(this.ad());
    // ISSUE: reference to a compiler-generated method
    this.s(A_0_1);
    return A_0_1;
  }

  public void a(int A_0)
  {
    this.t((float) (((double) A_0 * 1.5 + 100.0) / 1000.0));
  }

  public class a
  {
    public a(ahk A_0, float A_1, GameTimeStamp A_2)
    {
      // ISSUE: reference to a compiler-generated method
      this.o(A_2);
      // ISSUE: reference to a compiler-generated method
      this.o(A_0);
      // ISSUE: reference to a compiler-generated method
      this.o(A_1);
      // ISSUE: reference to a compiler-generated method
      this.p(A_0);
      // ISSUE: reference to a compiler-generated method
      this.p(A_1);
    }
  }

  public class b
  {
    public enum MovementMode
    {
      NoData,
      Interpolation,
      DeadReckoning,
      PredictedPursuit,
      TimeStampNotChanged,
    }
  }

  public enum c
  {
    a,
    b,
  }
}
