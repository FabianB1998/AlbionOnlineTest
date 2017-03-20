// Decompiled with JetBrains decompiler
// Type: kd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

public class kd
{
  private acf a;
  private Dictionary<string, Dictionary<string, string>> b;

  public kd(acb A_0, acf A_1, float A_2)
    : this(A_0, A_1, A_2, acf.a(), (Dictionary<string, Dictionary<string, string>>) null)
  {
  }

  public kd(acb A_0, acf A_1, float A_2, acf A_3)
    : this(A_0, A_1, new acf(0.0f, A_2, 0.0f), A_3, (Dictionary<string, Dictionary<string, string>>) null)
  {
  }

  public kd(acb A_0, acf A_1, float A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
    : this(A_0, A_1, new acf(0.0f, A_2, 0.0f), A_3, A_4)
  {
  }

  public kd(acb A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.q(A_1);
    this.p(A_2);
    // ISSUE: reference to a compiler-generated method
    this.o(kd.o(this.r()));
    // ISSUE: reference to a compiler-generated method
    this.o(A_3);
    if (A_0 == null)
      throw new AlbionException("Couldn't create TileInstance from Tile");
    // ISSUE: reference to a compiler-generated method
    this.o(A_0);
    this.b = A_4;
  }

  [SpecialName]
  public acf q()
  {
    return this.a;
  }

  [SpecialName]
  private void p(acf A_0)
  {
    this.a = A_0;
  }

  [SpecialName]
  public float r()
  {
    // ISSUE: reference to a compiler-generated method
    return this.q().l();
  }

  [SpecialName]
  public acd y()
  {
    ahk A_0 = this.ac();
    return new acd(A_0, ahk.d(A_0, new ahk((float) this.z(), (float) this.aa())));
  }

  [SpecialName]
  public int z()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.a || this.t() == kd.a.c)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.u().u();
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.u().v();
  }

  [SpecialName]
  public int aa()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.a || this.t() == kd.a.c)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.u().v();
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.u().u();
  }

  [SpecialName]
  public ahk ab()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new ahk(this.u().w().h(), (float) -((double) this.u().u() + (double) this.u().w().g()));
    }
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.c)
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
      return new ahk((float) -((double) this.u().u() + (double) this.u().w().g()), (float) -((double) this.u().v() + (double) this.u().w().h()));
    }
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.d)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new ahk((float) -((double) this.u().v() + (double) this.u().w().h()), this.u().w().g());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk(this.u().w().g(), this.u().w().h());
  }

  public abf o(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.a)
      return new abf(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new abf(this.u().u() - 1 - A_1, A_0);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.t() == kd.a.c)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new abf(this.u().u() - 1 - A_0, this.u().v() - 1 - A_1);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new abf(A_1, this.u().v() - 1 - A_0);
  }

  [SpecialName]
  public ahk ac()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kd.p(this.u(), this.p().o(), this.t());
  }

  public static ahk p(acb A_0, ahk A_1, kd.a A_2)
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
    A_1 = A_2 != kd.a.b ? (A_2 != kd.a.c ? (A_2 != kd.a.d ? ahk.d(A_1, new ahk(A_0.w().g(), A_0.w().h())) : ahk.d(A_1, new ahk((float) -((double) A_0.v() + (double) A_0.w().h()), A_0.w().g()))) : ahk.d(A_1, new ahk((float) -((double) A_0.u() + (double) A_0.w().g()), (float) -((double) A_0.v() + (double) A_0.w().h())))) : ahk.d(A_1, new ahk(A_0.w().h(), (float) -((double) A_0.u() + (double) A_0.w().g())));
    return A_1;
  }

  public static acd o(acb A_0, ahk A_1, kd.a A_2)
  {
    ahk A_0_1 = kd.p(A_0, A_1, A_2);
    if (A_2 == kd.a.a || A_2 == kd.a.c)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return new acd(A_0_1, ahk.d(A_0_1, new ahk((float) A_0.u(), (float) A_0.v())));
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new acd(A_0_1, ahk.d(A_0_1, new ahk((float) A_0.v(), (float) A_0.u())));
  }

  public int o(float A_0, float A_1)
  {
    int A_2;
    int A_3;
    this.o(A_0, A_1, out A_2, out A_3);
    return this.p(A_2, A_3);
  }

  public int p(int A_0, int A_1)
  {
    abf abf = this.o(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return abf.c() + (this.u().v() - abf.d() - 1) * this.u().u();
  }

  protected void o(float A_0, float A_1, out int A_2, out int A_3)
  {
    ahk ahk = this.ab();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0 = A_0 - this.p().k() - ahk.g();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1 = A_1 - this.p().m() - ahk.h();
    A_2 = (int) Math.Min(Math.Round((double) A_0), (double) (this.z() - 1));
    A_3 = (int) Math.Min(Math.Round((double) A_1), (double) (this.aa() - 1));
  }

  public byte p(float A_0, float A_1)
  {
    int A_2;
    int A_3;
    this.o(A_0, A_1, out A_2, out A_3);
    return this.q(A_2, A_3);
  }

  public byte q(int A_0, int A_1)
  {
    abf abf = this.o(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.u().r(abf.c(), abf.d());
  }

  public float q(float A_0, float A_1)
  {
    ahk ahk = this.ab();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0 = A_0 - this.p().k() - ahk.g();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_1 = A_1 - this.p().m() - ahk.h();
    return this.r((int) Math.Min(Math.Round((double) A_0), (double) (this.z() - 1)), (int) Math.Min(Math.Round((double) A_1), (double) (this.aa() - 1)));
  }

  public float r(int A_0, int A_1)
  {
    abf abf = this.o(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.p().l() + this.u().q(abf.c(), abf.d());
  }

  public acb.b s(int A_0, int A_1)
  {
    abf abf = this.o(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.p(this.u().p(abf.c(), abf.d()), this.t());
  }

  public byte t(int A_0, int A_1)
  {
    abf abf = this.o(A_0, A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.u().o(abf.c(), abf.d());
  }

  private acb.b p(acb.b A_0, kd.a A_1)
  {
    switch (A_0)
    {
      case acb.b.a:
        return acb.b.a;
      case acb.b.b:
        return acb.b.b;
      case acb.b.c:
        return acb.b.c;
      case acb.b.d:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.e;
          case kd.a.c:
            return acb.b.f;
          case kd.a.d:
            return acb.b.g;
          default:
            return acb.b.d;
        }
      case acb.b.e:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.f;
          case kd.a.c:
            return acb.b.g;
          case kd.a.d:
            return acb.b.d;
          default:
            return acb.b.e;
        }
      case acb.b.f:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.g;
          case kd.a.c:
            return acb.b.d;
          case kd.a.d:
            return acb.b.e;
          default:
            return acb.b.f;
        }
      case acb.b.g:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.d;
          case kd.a.c:
            return acb.b.e;
          case kd.a.d:
            return acb.b.f;
          default:
            return acb.b.g;
        }
      case acb.b.h:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.i;
          case kd.a.c:
            return acb.b.j;
          case kd.a.d:
            return acb.b.k;
          default:
            return acb.b.h;
        }
      case acb.b.i:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.j;
          case kd.a.c:
            return acb.b.k;
          case kd.a.d:
            return acb.b.h;
          default:
            return acb.b.i;
        }
      case acb.b.j:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.k;
          case kd.a.c:
            return acb.b.h;
          case kd.a.d:
            return acb.b.i;
          default:
            return acb.b.j;
        }
      case acb.b.k:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.h;
          case kd.a.c:
            return acb.b.i;
          case kd.a.d:
            return acb.b.j;
          default:
            return acb.b.k;
        }
      default:
        return acb.b.a;
    }
  }

  private acb.b o(acb.b A_0, kd.a A_1)
  {
    switch (A_0)
    {
      case acb.b.a:
        return acb.b.a;
      case acb.b.b:
        return acb.b.b;
      case acb.b.c:
        return acb.b.c;
      case acb.b.d:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.g;
          case kd.a.c:
            return acb.b.f;
          case kd.a.d:
            return acb.b.e;
          default:
            return acb.b.d;
        }
      case acb.b.e:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.d;
          case kd.a.c:
            return acb.b.g;
          case kd.a.d:
            return acb.b.f;
          default:
            return acb.b.e;
        }
      case acb.b.f:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.e;
          case kd.a.c:
            return acb.b.d;
          case kd.a.d:
            return acb.b.g;
          default:
            return acb.b.f;
        }
      case acb.b.g:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.f;
          case kd.a.c:
            return acb.b.e;
          case kd.a.d:
            return acb.b.d;
          default:
            return acb.b.g;
        }
      case acb.b.h:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.k;
          case kd.a.c:
            return acb.b.j;
          case kd.a.d:
            return acb.b.i;
          default:
            return acb.b.h;
        }
      case acb.b.i:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.h;
          case kd.a.c:
            return acb.b.k;
          case kd.a.d:
            return acb.b.j;
          default:
            return acb.b.i;
        }
      case acb.b.j:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.i;
          case kd.a.c:
            return acb.b.h;
          case kd.a.d:
            return acb.b.k;
          default:
            return acb.b.j;
        }
      case acb.b.k:
        switch (A_1)
        {
          case kd.a.b:
            return acb.b.j;
          case kd.a.c:
            return acb.b.i;
          case kd.a.d:
            return acb.b.h;
          default:
            return acb.b.k;
        }
      default:
        return acb.b.a;
    }
  }

  public static kd.a o(float A_0)
  {
    A_0 %= 360f;
    if ((double) A_0 <= 45.0)
      return kd.a.a;
    if ((double) A_0 <= 135.0)
      return kd.a.b;
    if ((double) A_0 <= 225.0)
      return kd.a.c;
    return (double) A_0 <= 315.0 ? kd.a.d : kd.a.a;
  }

  public void o(string A_0, string A_1, string A_2)
  {
    if (this.b == null)
      this.b = new Dictionary<string, Dictionary<string, string>>();
    if (!this.b.ContainsKey(A_0))
      this.b[A_0] = new Dictionary<string, string>();
    this.b[A_0].Add(A_1, A_2);
  }

  public bool ad()
  {
    if (this.b == null || this.b.Count <= 0)
    {
      // ISSUE: reference to a compiler-generated method
      return this.u().ac();
    }
    return true;
  }

  public bool o(string A_0)
  {
    if (this.b == null || !this.b.ContainsKey(A_0))
    {
      // ISSUE: reference to a compiler-generated method
      return this.u().q(A_0);
    }
    return true;
  }

  public bool o(string A_0, string A_1)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      if (dictionary != null && dictionary.ContainsKey(A_1))
        return true;
    }
    // ISSUE: reference to a compiler-generated method
    return this.u().o(A_0, A_1);
  }

  public string p(string A_0, string A_1, string A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string str;
      if (dictionary != null && dictionary.TryGetValue(A_1, out str))
        return str;
    }
    // ISSUE: reference to a compiler-generated method
    return this.u().p(A_0, A_1, A_2);
  }

  public ahk o(string A_0, string A_1, ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string[] strArray = this.p(A_0, A_1, string.Format("{0} {1}", (object) A_2.g().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), (object) A_2.h().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat))).Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 2)
      return A_2;
    return new ahk(float.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public acf o(string A_0, string A_1, acf A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string[] strArray = this.p(A_0, A_1, string.Format("{0} {1} {2}", (object) A_2.k().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), (object) A_2.l().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), (object) A_2.m().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat))).Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 3)
      return A_2;
    return new acf(float.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public int o(string A_0, string A_1, int A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string s;
      if (dictionary != null && dictionary.TryGetValue(A_1, out s))
        return int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    }
    // ISSUE: reference to a compiler-generated method
    return this.u().o(A_0, A_1, A_2);
  }

  public float o(string A_0, string A_1, float A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string s;
      if (dictionary != null && dictionary.TryGetValue(A_1, out s))
        return float.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    }
    // ISSUE: reference to a compiler-generated method
    return this.u().o(A_0, A_1, A_2);
  }

  public Guid p(string A_0, string A_1)
  {
    return new Guid(this.p(A_0, A_1, ""));
  }

  public bool o(string A_0, string A_1, bool A_2)
  {
    return this.p(A_0, A_1, A_2 ? "true" : "false") == "true";
  }

  public enum a
  {
    a,
    b,
    c,
    d,
  }
}
