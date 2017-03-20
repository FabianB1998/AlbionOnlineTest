// Decompiled with JetBrains decompiler
// Type: ahx
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Runtime.CompilerServices;

public class ahx
{
  private const int a = 60;
  private const float b = 0.2f;
  private const float c = 0.93f;
  private ahy d;
  private bool e;
  private ahx.a f;

  public ahx()
  {
    this.d = ahy.m(60);
  }

  [SpecialName]
  public void f(ahx.a A_0)
  {
    this.f += A_0;
  }

  [SpecialName]
  public void g(ahx.a A_0)
  {
    this.f -= A_0;
  }

  public void j()
  {
    if (global::a.c)
    {
      // ISSUE: reference to a compiler-generated method
      this.f(0.5f);
      // ISSUE: reference to a compiler-generated method
      this.f(false);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (this.i())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.f(this.h());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.f((double) this.f() < 0.200000002980232 || (double) this.f() > 0.930000007152557);
      }
      else
      {
        GameTimeStamp now = GameTimeStamp.Now;
        if (now.Ticks == 0L)
          return;
        // ISSUE: reference to a compiler-generated method
        bool flag = this.g();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.f(Math.Min(1f, (float) (((double) (now.Ticks % this.d.o) / (double) this.d.o + (double) this.h()) % 1.0)));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.f((double) this.f() < 0.200000002980232 || (double) this.f() > 0.930000007152557);
        if (!this.e)
        {
          // ISSUE: reference to a compiler-generated method
          if (this.g())
            this.k();
          else
            this.l();
          this.e = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          if (!flag && this.g())
          {
            this.k();
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            if (!flag || this.g())
              return;
            this.l();
          }
        }
      }
    }
  }

  public virtual void k()
  {
    if (this.f == null)
      return;
    this.f(true);
  }

  public virtual void l()
  {
    if (this.f == null)
      return;
    this.f(false);
  }

  public delegate void a(bool A_0);
}
