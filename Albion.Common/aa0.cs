// Decompiled with JetBrains decompiler
// Type: aa0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class aa0
{
  private int a = 60;
  public aa0.a b;

  public aa0()
  {
    this.b = new aa0.a(this.a);
  }

  public void d()
  {
    this.b.d();
    // ISSUE: reference to a compiler-generated method
    this.c((aaz) null);
  }

  public string c(int A_0)
  {
    string str = "";
    int num = Math.Max(0, this.b.c() - A_0);
    for (int A_0_1 = this.b.c() - 1; A_0_1 >= num; --A_0_1)
    {
      if (str.Length > 0)
        str += ", ";
      str += (string) (object) this.b.c(A_0_1).p();
    }
    return str;
  }

  public ahy e()
  {
    int num1 = Math.Max(0, this.b.c() - 5);
    ahy A_0_1 = new ahy();
    for (int A_0_2 = this.b.c() - 1; A_0_2 >= num1; --A_0_2)
      A_0_1 = ahy.n(A_0_1, this.b.c(A_0_2).p());
    int num2 = this.b.c() - num1;
    return ahy.l(A_0_1, (float) num2);
  }

  public ahy f()
  {
    int num = Math.Max(0, this.b.c() - 5);
    ahy ahy = new ahy();
    for (int A_0 = this.b.c() - 1; A_0 >= num; --A_0)
      ahy = new ahy(Math.Max(this.b.c(A_0).p().o, ahy.o));
    return ahy;
  }

  public void c(GameTimeStamp A_0, out aaz A_1, out aaz A_2)
  {
    A_1 = (aaz) null;
    A_2 = (aaz) null;
    for (int A_0_1 = this.b.c() - 1; A_0_1 >= 0; --A_0_1)
    {
      aaz aaz = this.b.c(A_0_1);
      // ISSUE: reference to a compiler-generated method
      if (GameTimeStamp.i(aaz.i(), A_0))
      {
        A_1 = aaz;
        break;
      }
      A_2 = aaz;
    }
  }

  public aaz d(aaz A_0)
  {
    bool flag = false;
    for (int A_0_1 = this.b.c() - 1; A_0_1 >= 0; --A_0_1)
    {
      if (this.b.c(A_0_1) == A_0)
        flag = true;
      else if (flag && this.b.c(A_0_1).o())
        return this.b.c(A_0_1);
    }
    return (aaz) null;
  }

  public ahy g()
  {
    ahy A_0_1 = new ahy();
    int num1 = this.b.c() - 1;
    int num2 = Math.Max(0, this.b.c() - 5);
    int num3 = num1 - num2 + 1;
    for (int A_0_2 = num1; A_0_2 >= num2; --A_0_2)
    {
      aaz aaz = this.b.c(A_0_2);
      A_0_1 = ahy.n(A_0_1, aaz.p());
    }
    return ahy.l(A_0_1, (float) num3);
  }

  public void c(ahk A_0, float A_1)
  {
    this.c(A_0, A_1, GameTimeStamp.Now);
  }

  public void c(ahk A_0, float A_1, GameTimeStamp A_2)
  {
    this.c(A_0, A_0, A_2, A_1, 0.0f);
  }

  public bool c(ahk A_0, float A_1, ahk A_2, float A_3, GameTimeStamp A_4)
  {
    return this.c(A_0, A_2, A_4, A_1, A_3);
  }

  public bool c(y3 A_0, float A_1)
  {
    return this.c(ahk.a(A_0.at4), ahk.a(A_0.at6), new GameTimeStamp(A_0.az), A_0.at5, A_1);
  }

  public bool c(po A_0)
  {
    this.d();
    return this.c(ahk.a(A_0.rx), ahk.a(A_0.r0), new GameTimeStamp(A_0.rw), A_0.ry, A_0.rz);
  }

  public bool c(pn A_0)
  {
    return this.c(ahk.a(A_0.rx), ahk.a(A_0.r0), new GameTimeStamp(A_0.rw), A_0.ry, A_0.rz);
  }

  public bool c(abl A_0)
  {
    this.d();
    return this.c(ahk.a(A_0.a05), ahk.a(A_0.a05), new GameTimeStamp(A_0.a04), A_0.a06, 0.0f);
  }

  public bool c(abv A_0)
  {
    this.d();
    return this.c(ahk.a(A_0.a3r), ahk.a(A_0.a3s), A_0.a3t, A_0.a3u, A_0.a3v);
  }

  public bool c(qq A_0)
  {
    this.d();
    return this.c(ahk.a(A_0.xr), ahk.a(A_0.xs), new GameTimeStamp(A_0.xt), A_0.xu, A_0.xv);
  }

  protected bool c(ahk A_0, ahk A_1, GameTimeStamp A_2, float A_3, float A_4)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.c() != null && GameTimeStamp.i(A_2, this.c().i()))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.c(this.b.c(GameTimeStamp.Now, A_0, A_1, A_2, A_3, A_4));
    return true;
  }

  public class a
  {
    private int a;
    private int b;
    private int c;
    private int d;
    private aaz[] e;

    public a(int A_0)
    {
      this.d = A_0;
      this.e = new aaz[this.d];
      for (int index = 0; index < this.d; ++index)
        this.e[index] = new aaz();
    }

    [SpecialName]
    public int c()
    {
      return this.a;
    }

    [SpecialName]
    public aaz c(int A_0)
    {
      if (A_0 < 0 || A_0 >= this.a)
        throw new IndexOutOfRangeException();
      return this.e[(this.c + A_0) % this.b];
    }

    public void d()
    {
      this.c = this.b = this.a = 0;
    }

    public aaz c(GameTimeStamp A_0, ahk A_1, ahk A_2, GameTimeStamp A_3, float A_4, float A_5)
    {
      aaz aaz = this.b != this.e.Length ? this.e[this.b++] : this.e[this.c++ % this.b];
      // ISSUE: reference to a compiler-generated method
      aaz.j(A_0);
      // ISSUE: reference to a compiler-generated method
      aaz.i(A_1);
      // ISSUE: reference to a compiler-generated method
      aaz.j(A_2);
      // ISSUE: reference to a compiler-generated method
      aaz.i(A_3);
      // ISSUE: reference to a compiler-generated method
      aaz.i(A_4);
      // ISSUE: reference to a compiler-generated method
      aaz.j(A_5);
      if (this.a < this.d)
        ++this.a;
      return aaz;
    }
  }
}
