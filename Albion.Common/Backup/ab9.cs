// Decompiled with JetBrains decompiler
// Type: ab9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class ab9
{
  protected Dictionary<KeyValuePair<float, float>, kl> b = new Dictionary<KeyValuePair<float, float>, kl>();
  private object c = new object();
  protected byte[] a;

  public ab9(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_0);
  }

  [SpecialName]
  public acd i()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(this.h(), ahk.d(this.h(), new ahk((float) this.f(), (float) this.g())));
  }

  public void f(int A_0, int A_1, ahk A_2)
  {
    this.f(A_0, A_1, A_2, new byte[A_0 * A_1 * 2]);
  }

  public void f(int A_0, int A_1, ahk A_2, byte[] A_3)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_2);
    // ISSUE: reference to a compiler-generated method
    this.f(A_0);
    // ISSUE: reference to a compiler-generated method
    this.g(A_1);
    this.a = A_3;
    int index = 0;
    while (index < this.a.Length)
    {
      this.a[index] = (byte) 0;
      this.a[index + 1] = (byte) 5;
      index += 2;
    }
    this.b.Clear();
  }

  public byte[] k()
  {
    return this.a;
  }

  public void l()
  {
    int index = 0;
    while (index < this.a.Length)
    {
      this.a[index] = (byte) 0;
      this.a[index + 1] = (byte) 5;
      index += 2;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(0, 0, this.f(), this.g());
  }

  public void f(kd A_0, ab9.a A_1)
  {
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (!A_0.u().o() && A_1 == ab9.a.b)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      int A_0_1 = (int) Math.Round((double) A_0.ac().g() - (double) this.h().g());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      int A_1_1 = (int) Math.Round((double) A_0.ac().h() - (double) this.h().h());
      for (int A_1_2 = 0; A_1_2 < A_0.aa(); ++A_1_2)
      {
        for (int A_0_2 = 0; A_0_2 < A_0.z(); ++A_0_2)
        {
          if (A_1 == ab9.a.a)
          {
            this.f(A_0_1 + A_0_2, A_1_1 + A_1_2, A_0.s(A_0_2, A_1_2), A_0.t(A_0_2, A_1_2));
          }
          else
          {
            acb.b b = this.i(A_0_1 + A_0_2, A_1_1 + A_1_2);
            byte num1 = A_0.t(A_0_2, A_1_2);
            if ((int) num1 != 0)
            {
              byte num2 = this.f(A_0_1 + A_0_2, A_1_1 + A_1_2);
              acb.b A_2 = A_0.s(A_0_2, A_1_2);
              if ((int) num2 != 0 && A_2 != b)
                A_2 = acb.b.a;
              this.f(A_0_1 + A_0_2, A_1_1 + A_1_2, A_2, (byte) ((uint) num2 | (uint) num1));
            }
          }
        }
      }
      this.h(A_0_1, A_1_1, A_0.z(), A_0.aa());
    }
    catch (Exception ex)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ab0.a("Applying TileInstance to CollisionGrid failed: " + A_0.u().s() + " | context: " + this.j());
      ab0.a(ex);
    }
  }

  protected ahk g(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return ahk.c(A_0, this.h());
  }

  protected ahk h(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return ahk.d(A_0, this.h());
  }

  protected void f(int A_0, int A_1, acb.b A_2, byte A_3)
  {
    // ISSUE: reference to a compiler-generated method
    int index = (A_1 * this.f() + A_0) * 2;
    this.a[index] = (byte) A_2;
    this.a[index + 1] = A_3;
  }

  public byte f(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 >= 0 && A_1 >= 0 && (A_0 < this.f() && A_1 < this.g()))
    {
      // ISSUE: reference to a compiler-generated method
      return this.a[(A_1 * this.f() + A_0) * 2 + 1];
    }
    return byte.MaxValue;
  }

  public byte g(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.a[(A_1 * this.f() + A_0) * 2 + 1];
  }

  public acb.b h(int A_0, int A_1)
  {
    if (((int) this.f(A_0, A_1) & 4) != 0)
      return acb.b.a;
    return this.i(A_0, A_1);
  }

  protected internal acb.b i(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0 >= 0 && A_1 >= 0 && (A_0 < this.f() && A_1 < this.g()))
    {
      // ISSUE: reference to a compiler-generated method
      return (acb.b) this.a[(A_1 * this.f() + A_0) * 2];
    }
    return acb.b.a;
  }

  public byte f(acf A_0)
  {
    return this.i(A_0.o());
  }

  public byte i(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.f((int) Math.Floor((double) A_0.g() - (double) this.h().g()), (int) Math.Floor((double) A_0.h() - (double) this.h().h()));
  }

  public void m()
  {
    byte num1 = 4;
    // ISSUE: reference to a compiler-generated method
    for (int A_1 = 0; A_1 < this.g(); ++A_1)
    {
      // ISSUE: reference to a compiler-generated method
      for (int A_0 = 0; A_0 < this.f(); ++A_0)
      {
        byte num2 = this.f(A_0, A_1);
        if ((int) num2 != (int) byte.MaxValue && ((int) num2 & (int) num1) != 0)
        {
          byte A_3 = (byte) ((uint) num2 ^ (uint) num1);
          this.f(A_0, A_1, this.i(A_0, A_1), A_3);
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(0, 0, this.f(), this.g());
  }

  public void n()
  {
    byte num = 4;
    // ISSUE: reference to a compiler-generated method
    for (int A_1 = 0; A_1 < this.g(); ++A_1)
    {
      // ISSUE: reference to a compiler-generated method
      for (int A_0 = 0; A_0 < this.f(); ++A_0)
      {
        byte A_3 = (byte) ((uint) this.f(A_0, A_1) | (uint) num);
        this.f(A_0, A_1, this.i(A_0, A_1), A_3);
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(0, 0, this.f(), this.g());
  }

  public void f(acd A_0)
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
    this.g((int) Math.Floor((double) A_0.a.g() - (double) this.h().g()), (int) Math.Floor((double) A_0.a.h() - (double) this.h().h()), (int) Math.Ceiling((double) A_0.b.g() - (double) this.h().g()), (int) Math.Ceiling((double) A_0.b.h() - (double) this.h().h()));
  }

  private void g(int A_0, int A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    A_0 = Math.Max(0, Math.Min(A_0, this.f()));
    // ISSUE: reference to a compiler-generated method
    A_1 = Math.Max(0, Math.Min(A_1, this.g()));
    // ISSUE: reference to a compiler-generated method
    A_2 = Math.Max(0, Math.Min(A_2, this.f()));
    // ISSUE: reference to a compiler-generated method
    A_3 = Math.Max(0, Math.Min(A_3, this.g()));
    byte num = 4;
    for (int A_1_1 = A_1; A_1_1 < A_3; ++A_1_1)
    {
      for (int A_0_1 = A_0; A_0_1 < A_2; ++A_0_1)
      {
        byte A_3_1 = (byte) ((uint) this.f(A_0_1, A_1_1) | (uint) num);
        this.f(A_0_1, A_1_1, this.i(A_0_1, A_1_1), A_3_1);
      }
    }
    this.h(A_0, A_1, A_2, A_3);
  }

  public void g(acd A_0)
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
    this.f((int) Math.Floor((double) A_0.a.g() - (double) this.h().g()), (int) Math.Floor((double) A_0.a.h() - (double) this.h().h()), (int) Math.Ceiling((double) A_0.b.g() - (double) this.h().g()), (int) Math.Ceiling((double) A_0.b.h() - (double) this.h().h()));
  }

  private void f(int A_0, int A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    A_0 = Math.Max(0, Math.Min(A_0, this.f()));
    // ISSUE: reference to a compiler-generated method
    A_1 = Math.Max(0, Math.Min(A_1, this.g()));
    // ISSUE: reference to a compiler-generated method
    A_2 = Math.Max(0, Math.Min(A_2, this.f()));
    // ISSUE: reference to a compiler-generated method
    A_3 = Math.Max(0, Math.Min(A_3, this.g()));
    byte num1 = 4;
    for (int A_1_1 = A_1; A_1_1 < A_3; ++A_1_1)
    {
      for (int A_0_1 = A_0; A_0_1 < A_2; ++A_0_1)
      {
        byte num2 = this.f(A_0_1, A_1_1);
        if ((int) num2 != (int) byte.MaxValue && ((int) num2 & (int) num1) != 0)
        {
          byte A_3_1 = (byte) ((uint) num2 ^ (uint) num1);
          this.f(A_0_1, A_1_1, this.i(A_0_1, A_1_1), A_3_1);
        }
      }
    }
    this.h(A_0, A_1, A_2, A_3);
  }

  protected float f(float A_0, float A_1, ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (float) (((double) A_0 - (double) A_2.g()) * ((double) A_0 - (double) A_2.g()) + ((double) A_1 - (double) A_2.h()) * ((double) A_1 - (double) A_2.h()));
  }

  protected float f(ahk A_0, float A_1, float A_2, float A_3, float A_4)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return Math.Abs((float) (((double) A_3 - (double) A_1) * ((double) A_2 - (double) A_0.h()) - ((double) A_1 - (double) A_0.g()) * ((double) A_4 - (double) A_2))) / (float) Math.Sqrt(((double) A_3 - (double) A_1) * ((double) A_3 - (double) A_1) + ((double) A_4 - (double) A_2) * ((double) A_4 - (double) A_2));
  }

  protected ahk f(ahk A_0, ahk A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    float num1 = A_2 - A_0.g();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num2 = A_1.h() / A_1.g();
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_2, A_0.h() + num2 * num1);
  }

  protected ahk g(ahk A_0, ahk A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    float num1 = A_2 - A_0.h();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num2 = A_1.g() / A_1.h();
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() + num2 * num1, A_2);
  }

  protected bool f(ahk A_0, float A_1, int A_2, int A_3, out ahk A_4)
  {
    switch (this.h(A_2, A_3))
    {
      case acb.b.a:
        return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
      case acb.b.b:
        return this.f(A_0, A_1, 0.5f, A_2, A_3, out A_4);
      case acb.b.c:
        return this.f(A_0, A_1, 0.25f, A_2, A_3, out A_4);
      case acb.b.d:
        return this.h(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.e:
        return this.h(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.f:
        return this.h(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.g:
        return this.h(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.h:
        return this.g(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.i:
        return this.g(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.j:
        return this.g(A_0, A_1, A_2, A_3, out A_4);
      case acb.b.k:
        return this.g(A_0, A_1, A_2, A_3, out A_4);
      default:
        throw new AlbionException("invalid collision shape!");
    }
  }

  protected bool f(ahk A_0, float A_1, float A_2, int A_3, int A_4, out ahk A_5)
  {
    ahk ahk = new ahk((float) A_3 + 0.5f, (float) A_4 + 0.5f);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.f(ahk.g(), ahk.h(), A_0) >= ((double) A_1 + (double) A_2) * ((double) A_1 + (double) A_2))
    {
      A_5 = ahk.d();
      return false;
    }
    ahk A_0_1 = ahk.c(A_0, ahk).m();
    ahk A_0_2 = ahk.d(ahk, ahk.b(A_0_1, (float) ((double) A_1 + (double) A_2 + 9.99999974737875E-05)));
    A_5 = ahk.c(A_0_2, A_0);
    return true;
  }

  protected bool g(ahk A_0, float A_1, int A_2, int A_3, out ahk A_4)
  {
    switch (this.h(A_2, A_3))
    {
      case acb.b.h:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2 > (double) A_0.g() || (double) A_0.g() > (double) (A_2 + 1) || (double) (A_3 + 1) - (double) A_0.h() < (double) A_1 - 9.99999974737875E-05)
          return this.f(A_0, A_1, (float) A_2, (float) (A_3 + 1), (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
        A_4 = ahk.d();
        return false;
      case acb.b.i:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3 > (double) A_0.h() || (double) A_0.h() > (double) (A_3 + 1) || (double) (A_2 + 1) - (double) A_0.g() < (double) A_1 - 9.99999974737875E-05)
          return this.f(A_0, A_1, (float) (A_2 + 1), (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
        A_4 = ahk.d();
        return false;
      case acb.b.j:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2 > (double) A_0.g() || (double) A_0.g() > (double) (A_2 + 1) || (double) A_0.h() - (double) A_3 < (double) A_1 - 9.99999974737875E-05)
          return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) A_3, out A_4);
        A_4 = ahk.d();
        return false;
      case acb.b.k:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3 > (double) A_0.h() || (double) A_0.h() > (double) (A_3 + 1) || (double) A_0.g() - (double) A_2 < (double) A_1 - 9.99999974737875E-05)
          return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) A_2, (float) (A_3 + 1), out A_4);
        A_4 = ahk.d();
        return false;
      default:
        throw new AlbionException();
    }
  }

  protected bool f(ahk A_0, float A_1, float A_2, float A_3, float A_4, float A_5, out ahk A_6)
  {
    float num1 = (float) (((double) A_2 + (double) A_4) / 2.0);
    float num2 = (float) (((double) A_3 + (double) A_5) / 2.0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_2 <= (double) A_0.g() && (double) A_0.g() <= (double) A_4)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.h() < (double) num2)
      {
        // ISSUE: reference to a compiler-generated method
        A_6 = new ahk(0.0f, A_3 - A_1 - A_0.h());
        return true;
      }
      // ISSUE: reference to a compiler-generated method
      A_6 = new ahk(0.0f, A_5 + A_1 - A_0.h());
      return true;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) A_3 <= (double) A_0.h() && (double) A_0.h() < (double) A_5)
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() < (double) num1)
      {
        // ISSUE: reference to a compiler-generated method
        A_6 = new ahk(A_2 - A_1 - A_0.g(), 0.0f);
        return true;
      }
      // ISSUE: reference to a compiler-generated method
      A_6 = new ahk(A_4 + A_1 - A_0.g(), 0.0f);
      return true;
    }
    float num3 = A_1 * A_1;
    ahk ahk;
    // ISSUE: reference to a compiler-generated method
    if ((double) num1 < (double) A_0.g())
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) num2 < (double) A_0.h())
      {
        if ((double) this.f(A_4, A_5, A_0) < (double) num3)
        {
          ahk = new ahk(A_4, A_5);
        }
        else
        {
          A_6 = ahk.d();
          return false;
        }
      }
      else if ((double) this.f(A_4, A_3, A_0) < (double) num3)
      {
        ahk = new ahk(A_4, A_3);
      }
      else
      {
        A_6 = ahk.d();
        return false;
      }
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) num2 < (double) A_0.h())
      {
        if ((double) this.f(A_2, A_5, A_0) < (double) num3)
        {
          ahk = new ahk(A_2, A_5);
        }
        else
        {
          A_6 = ahk.d();
          return false;
        }
      }
      else if ((double) this.f(A_2, A_3, A_0) < (double) num3)
      {
        ahk = new ahk(A_2, A_3);
      }
      else
      {
        A_6 = ahk.d();
        return false;
      }
    }
    ahk A_0_1 = ahk.c(A_0, ahk).m();
    ahk A_0_2 = ahk.d(ahk, ahk.b(A_0_1, A_1 + 0.0001f));
    A_6 = ahk.c(A_0_2, A_0);
    return true;
  }

  protected bool h(ahk A_0, float A_1, int A_2, int A_3, out ahk A_4)
  {
    acb.b b = this.h(A_2, A_3);
    A_4 = ahk.d();
    ahk ahk = ahk.d();
    if (b == acb.b.d)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() <= (double) A_2 || (double) A_0.h() <= (double) A_3)
        return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() > (double) (A_2 + 1) && (double) A_0.h() - (double) A_3 < (double) A_0.g() - (double) A_2 - 1.0)
      {
        ahk = new ahk((float) (A_2 + 1), (float) A_3);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_0.h() - (double) A_3 - 1.0 > (double) A_0.g() - (double) A_2)
        {
          ahk = new ahk((float) A_2, (float) (A_3 + 1));
        }
        else
        {
          float num = this.f(A_0, (float) A_2, (float) (A_3 + 1), (float) (A_2 + 1), (float) A_3);
          if ((double) num >= (double) A_1)
          {
            A_4 = ahk.d();
            return false;
          }
          A_4 = new ahk(A_1 - num, A_1 - num);
          return true;
        }
      }
    }
    else if (b == acb.b.g)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() >= (double) (A_2 + 1) || (double) A_0.h() <= (double) A_3)
        return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() < (double) A_2 && (double) A_0.h() - (double) A_3 < (double) A_2 - (double) A_0.g())
      {
        ahk = new ahk((float) A_2, (float) A_3);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_0.h() - (double) A_3 - 1.0 > (double) (A_2 + 1) - (double) A_0.g())
        {
          ahk = new ahk((float) (A_2 + 1), (float) (A_3 + 1));
        }
        else
        {
          float num = this.f(A_0, (float) (A_2 + 1), (float) (A_3 + 1), (float) A_2, (float) A_3);
          if ((double) num >= (double) A_1)
          {
            A_4 = ahk.d();
            return false;
          }
          A_4 = new ahk((float) -((double) A_1 - (double) num), A_1 - num);
          return true;
        }
      }
    }
    if (b == acb.b.e)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() <= (double) A_2 || (double) A_0.h() >= (double) (A_3 + 1))
        return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() > (double) (A_2 + 1) && (double) (A_3 + 1) - (double) A_0.h() < (double) A_0.g() - (double) A_2 - 1.0)
      {
        ahk = new ahk((float) (A_2 + 1), (float) (A_3 + 1));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3 - (double) A_0.h() > (double) A_0.g() - (double) A_2)
        {
          ahk = new ahk((float) A_2, (float) A_3);
        }
        else
        {
          float num = this.f(A_0, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1));
          if ((double) num >= (double) A_1)
          {
            A_4 = ahk.d();
            return false;
          }
          A_4 = new ahk(A_1 - num, (float) -((double) A_1 - (double) num));
          return true;
        }
      }
    }
    if (b == acb.b.f)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() >= (double) (A_2 + 1) || (double) A_0.h() >= (double) (A_3 + 1))
        return this.f(A_0, A_1, (float) A_2, (float) A_3, (float) (A_2 + 1), (float) (A_3 + 1), out A_4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) A_0.g() < (double) A_2 && (double) (A_3 + 1) - (double) A_0.h() < (double) A_2 - (double) A_0.g())
      {
        ahk = new ahk((float) A_2, (float) (A_3 + 1));
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3 - (double) A_0.h() > (double) (A_2 + 1) - (double) A_0.g())
        {
          ahk = new ahk((float) (A_2 + 1), (float) A_3);
        }
        else
        {
          float num = this.f(A_0, (float) (A_2 + 1), (float) A_3, (float) A_2, (float) (A_3 + 1));
          if ((double) num >= (double) A_1)
          {
            A_4 = ahk.d();
            return false;
          }
          A_4 = new ahk((float) -((double) A_1 - (double) num), (float) -((double) A_1 - (double) num));
          return true;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if ((double) this.f(ahk.g(), ahk.h(), A_0) >= (double) A_1 * (double) A_1)
    {
      A_4 = ahk.d();
      return false;
    }
    ahk A_0_1 = ahk.c(A_0, ahk).m();
    ahk A_0_2 = ahk.d(ahk, ahk.b(A_0_1, A_1 + 0.0001f));
    A_4 = ahk.c(A_0_2, A_0);
    return true;
  }

  public byte f(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_1 = new ahk(A_0.g() - this.h().g(), A_0.h() - this.h().h());
    byte num1 = 0;
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Floor((double) A_0_1.g() - (double) A_1 + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num3 = (int) Math.Floor((double) A_0_1.h() - (double) A_1 + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num4 = (int) Math.Ceiling((double) A_0_1.g() + (double) A_1 - 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num5 = (int) Math.Ceiling((double) A_0_1.h() + (double) A_1 - 9.99999974737875E-05);
    for (int index1 = num3; index1 < num5; ++index1)
    {
      for (int index2 = num2; index2 < num4; ++index2)
      {
        byte num6 = this.f(index2, index1);
        ahk A_4;
        if ((int) num6 != 0 && this.f(A_0_1, A_1, index2, index1, out A_4))
          num1 |= num6;
      }
    }
    return num1;
  }

  public byte h(acd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num1 = (int) Math.Floor((double) A_0.a.g() - (double) this.h().g() + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Floor((double) A_0.a.h() - (double) this.h().h() + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num3 = (int) Math.Ceiling((double) A_0.b.g() - (double) this.h().g() - 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num4 = (int) Math.Ceiling((double) A_0.b.h() - (double) this.h().h() - 9.99999974737875E-05);
    byte num5 = 0;
    for (int A_1 = num2; A_1 < num4; ++A_1)
    {
      for (int A_0_1 = num1; A_0_1 < num3; ++A_0_1)
        num5 |= this.f(A_0_1, A_1);
    }
    return num5;
  }

  public byte f(acd A_0, byte A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num1 = (int) Math.Floor((double) A_0.a.g() - (double) this.h().g() + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Floor((double) A_0.a.h() - (double) this.h().h() + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num3 = (int) Math.Ceiling((double) A_0.b.g() - (double) this.h().g() - 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num4 = (int) Math.Ceiling((double) A_0.b.h() - (double) this.h().h() - 9.99999974737875E-05);
    byte num5 = A_1;
    for (int A_1_1 = num2; A_1_1 < num4; ++A_1_1)
    {
      for (int A_0_1 = num1; A_0_1 < num3; ++A_0_1)
      {
        num5 &= this.f(A_0_1, A_1_1);
        if ((int) num5 == 0)
          return num5;
      }
    }
    return num5;
  }

  protected ahk g(ahk A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahk A_0_1 = new ahk(A_0.g() - this.h().g(), A_0.h() - this.h().h());
    // ISSUE: reference to a compiler-generated method
    int num1 = (int) Math.Floor((double) A_0_1.g() - (double) A_1 + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Floor((double) A_0_1.h() - (double) A_1 + 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num3 = (int) Math.Ceiling((double) A_0_1.g() + (double) A_1 - 9.99999974737875E-05);
    // ISSUE: reference to a compiler-generated method
    int num4 = (int) Math.Ceiling((double) A_0_1.h() + (double) A_1 - 9.99999974737875E-05);
    for (int index1 = num2; index1 < num4; ++index1)
    {
      for (int index2 = num1; index2 < num3; ++index2)
      {
        ahk A_4;
        if (((int) this.f(index2, index1) & 5) != 0 && this.f(A_0_1, A_1, index2, index1, out A_4))
          return A_4;
      }
    }
    return new ahk(0.0f, 0.0f);
  }

  public ahk h(ahk A_0, ahk A_1, float A_2)
  {
    return this.f(A_0, A_1, A_2, 5);
  }

  public ahk f(ahk A_0, ahk A_1, float A_2, int A_3)
  {
    ahk A_0_1 = ahk.c(A_1, A_0);
    float A_1_1 = A_0_1.k();
    ahk A_0_2 = ahk.a(A_0_1, A_1_1);
    ahk A_0_3 = A_0;
    float val1 = A_1_1;
label_6:
    if ((double) val1 <= 0.0)
      return A_0_3;
    float A_1_2 = Math.Min(val1, 0.1f);
    val1 -= A_1_2;
    ahk ahk1 = ahk.d(A_0_3, ahk.b(A_0_2, A_1_2));
    int num = 0;
    ahk A_0_4 = ahk1;
    do
    {
      ahk ahk2 = this.g(A_0_4, A_2);
      if (ahk.b(ahk2, ahk.d()))
      {
        A_0_3 = A_0_4;
        goto label_6;
      }
      else
      {
        A_0_4 = ahk.d(A_0_4, ahk2);
        ++num;
      }
    }
    while (num <= A_3);
    return A_0_3;
  }

  protected bool f(int A_0, int A_1, float A_2, ahk A_3, ahk A_4, out ahk A_5)
  {
    ace ace = new ace(new ahk((float) A_0 + 0.5f, (float) A_1 + 0.5f), A_2);
    if (ace.c(A_3))
    {
      A_5 = A_3;
      return true;
    }
    ahk A_2_1;
    ahk A_3_1;
    switch (ace.c(A_3, A_4, out A_2_1, out A_3_1))
    {
      case 0:
        A_5 = ahk.d();
        return false;
      case 1:
        A_5 = A_2_1;
        return true;
      default:
        A_5 = (double) ahk.c(A_3, A_2_1).j() < (double) ahk.c(A_3, A_3_1).j() ? A_2_1 : A_3_1;
        return true;
    }
  }

  protected ahk f(ahk A_0, ahk A_1, ahk A_2, ahk A_3)
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
    float num = (float) ((((double) A_3.g() - (double) A_2.g()) * ((double) A_0.h() - (double) A_2.h()) - ((double) A_3.h() - (double) A_2.h()) * ((double) A_0.g() - (double) A_2.g())) / (((double) A_3.h() - (double) A_2.h()) * ((double) A_1.g() - (double) A_0.g()) - ((double) A_3.g() - (double) A_2.g()) * ((double) A_1.h() - (double) A_0.h())));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(A_0.g() + num * (A_1.g() - A_0.g()), A_0.h() + num * (A_1.h() - A_0.h()));
  }

  protected bool f(int A_0, int A_1, ahk A_2, ahk A_3, out ahk A_4, byte A_5)
  {
    A_4 = ahk.d();
    if (((int) this.f(A_0, A_1) & (int) A_5) == 0)
      return false;
    switch (this.h(A_0, A_1))
    {
      case acb.b.a:
        A_4 = A_2;
        return true;
      case acb.b.b:
        return this.f(A_0, A_1, 0.5f, A_2, A_3, out A_4);
      case acb.b.c:
        return this.f(A_0, A_1, 0.25f, A_2, A_3, out A_4);
      case acb.b.d:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() - (double) A_0 + ((double) A_2.h() - (double) A_1) <= 1.0)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() - (double) A_0 + ((double) A_3.h() - (double) A_1) > 1.0)
          return false;
        A_4 = this.f(A_2, A_3, new ahk((float) A_0, (float) (A_1 + 1)), new ahk((float) (A_0 + 1), (float) A_1));
        return true;
      case acb.b.e:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() - (double) A_0 <= (double) A_2.h() - (double) A_1)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() - (double) A_0 > (double) A_3.h() - (double) A_1)
          return false;
        A_4 = this.f(A_2, A_3, new ahk((float) A_0, (float) A_1), new ahk((float) (A_0 + 1), (float) (A_1 + 1)));
        return true;
      case acb.b.f:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() - (double) A_0 + ((double) A_2.h() - (double) A_1) >= 1.0)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() - (double) A_0 + ((double) A_3.h() - (double) A_1) < 1.0)
          return false;
        A_4 = this.f(A_2, A_3, new ahk((float) A_0, (float) (A_1 + 1)), new ahk((float) (A_0 + 1), (float) A_1));
        return true;
      case acb.b.g:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() - (double) A_0 >= (double) A_2.h() - (double) A_1)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() - (double) A_0 < (double) A_3.h() - (double) A_1)
          return false;
        A_4 = this.f(A_2, A_3, new ahk((float) A_0, (float) A_1), new ahk((float) (A_0 + 1), (float) (A_1 + 1)));
        return true;
      case acb.b.h:
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.h() == (double) (A_1 + 1))
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.h() != (double) (A_1 + 1))
          return false;
        A_4 = A_3;
        return true;
      case acb.b.i:
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() == (double) (A_0 + 1))
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() != (double) (A_0 + 1))
          return false;
        A_4 = A_3;
        return true;
      case acb.b.j:
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.h() == (double) A_1)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.h() != (double) A_1)
          return false;
        A_4 = A_3;
        return true;
      case acb.b.k:
        // ISSUE: reference to a compiler-generated method
        if ((double) A_2.g() == (double) A_0)
        {
          A_4 = A_2;
          return true;
        }
        // ISSUE: reference to a compiler-generated method
        if ((double) A_3.g() != (double) A_0)
          return false;
        A_4 = A_3;
        return true;
      default:
        return false;
    }
  }

  public bool f(ahk A_0, ahk A_1, out ahk A_2, byte A_3)
  {
    A_0 = this.g(A_0);
    A_1 = this.g(A_1);
    ahk A_1_1 = ahk.c(A_1, A_0).m();
    ahk ahk = A_0;
    ahk A_3_1 = ahk.d();
    // ISSUE: reference to a compiler-generated method
    int num1 = (int) Math.Floor((double) A_1.g());
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Floor((double) A_1.h());
    // ISSUE: reference to a compiler-generated method
    int A_0_1 = (int) Math.Floor((double) A_0.g());
    // ISSUE: reference to a compiler-generated method
    int A_1_2 = (int) Math.Floor((double) A_0.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    while ((A_0_1 != num1 || A_1_2 != num2) && ((double) A_1_1.g() >= 0.0 || A_0_1 >= num1) && (((double) A_1_1.h() >= 0.0 || A_1_2 >= num2) && ((double) A_1_1.g() <= 0.0 || A_0_1 <= num1)) && ((double) A_1_1.h() <= 0.0 || A_1_2 <= num2))
    {
      int A_0_2 = A_0_1;
      int A_1_3 = A_1_2;
      bool flag = false;
      // ISSUE: reference to a compiler-generated method
      if ((double) A_1_1.g() < 0.0)
      {
        A_3_1 = this.f(ahk, A_1_1, (float) A_0_1);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_1_2 <= (double) A_3_1.h() && (double) A_3_1.h() <= (double) (A_1_2 + 1))
        {
          --A_0_1;
          flag = true;
        }
      }
      // ISSUE: reference to a compiler-generated method
      if (!flag && (double) A_1_1.g() > 0.0)
      {
        A_3_1 = this.f(ahk, A_1_1, (float) (A_0_1 + 1));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_1_2 <= (double) A_3_1.h() && (double) A_3_1.h() <= (double) (A_1_2 + 1))
        {
          ++A_0_1;
          flag = true;
        }
      }
      // ISSUE: reference to a compiler-generated method
      if (!flag && (double) A_1_1.h() < 0.0)
      {
        A_3_1 = this.g(ahk, A_1_1, (float) A_1_2);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_0_1 <= (double) A_3_1.g() && (double) A_3_1.g() <= (double) (A_0_1 + 1))
        {
          --A_1_2;
          flag = true;
        }
      }
      // ISSUE: reference to a compiler-generated method
      if (!flag && (double) A_1_1.h() > 0.0)
      {
        A_3_1 = this.g(ahk, A_1_1, (float) (A_1_2 + 1));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if ((double) A_0_1 <= (double) A_3_1.g() && (double) A_3_1.g() <= (double) (A_0_1 + 1))
        {
          ++A_1_2;
          flag = true;
        }
      }
      if (!flag)
        throw new Exception();
      if (this.f(A_0_2, A_1_3, ahk, A_3_1, out A_2, A_3))
        return true;
      ahk = A_3_1;
    }
    if (this.f(A_0_1, A_1_2, ahk, A_1, out A_2, A_3))
      return true;
    A_2 = ahk.d();
    return false;
  }

  public ahk h(ahk A_0, float A_1)
  {
    if (((int) this.f(A_0, A_1) & 5) == 0)
      return A_0;
    ahk[] ahkArray = new ahk[8]{ new ahk(-1f, 0.0f), new ahk(1f, 0.0f), new ahk(0.0f, -1f), new ahk(0.0f, 1f), new ahk(-1f, -1f), new ahk(-1f, 1f), new ahk(1f, -1f), new ahk(1f, 1f) };
    float A_1_1 = A_1 / 2f;
    while ((double) A_1_1 < 25.0)
    {
      for (int index = 0; index < ahkArray.Length; ++index)
      {
        ahk A_0_1 = ahk.d(A_0, ahk.b(ahkArray[index], A_1_1));
        if (((int) this.f(A_0_1, A_1) & 5) == 0)
          return A_0_1;
      }
      A_1_1 += A_1 / 2f;
    }
    if (ahk.a(A_0, ahk.d()))
      return this.h(ahk.d(), A_1);
    return ahk.d();
  }

  protected void h(int A_0, int A_1, int A_2, int A_3)
  {
    foreach (kl kl in this.b.Values)
      kl.e(A_0, A_1, A_2, A_3);
  }

  public kl f(float A_0, float A_1)
  {
    lock (this.c)
    {
      kl local_0;
      if (this.b.TryGetValue(new KeyValuePair<float, float>(A_0, A_1), out local_0))
        return local_0;
      Stopwatch local_1 = new Stopwatch();
      local_1.Start();
      local_0 = new kl(this, A_0, A_1);
      this.b.Add(new KeyValuePair<float, float>(A_0, A_1), local_0);
      local_1.Stop();
      return local_0;
    }
  }

  public enum a
  {
    a,
    b,
  }
}
