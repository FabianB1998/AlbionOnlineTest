// Decompiled with JetBrains decompiler
// Type: ahv
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class ahv : IDisposable
{
  protected SortedList<int, ahu> b = new SortedList<int, ahu>();
  private Action<ahu, ahu> a;
  private bool c;

  public ahv()
  {
    // ISSUE: reference to a compiler-generated method
    this.f(false);
    // ISSUE: reference to a compiler-generated method
    this.h(-1);
    // ISSUE: reference to a compiler-generated method
    this.g(-1);
    // ISSUE: reference to a compiler-generated method
    this.f((ahu) null);
  }

  [SpecialName]
  public void f(Action<ahu, ahu> A_0)
  {
    Action<ahu, ahu> action = this.a;
    Action<ahu, ahu> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<ahu, ahu>>(ref this.a, comparand + A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public void g(Action<ahu, ahu> A_0)
  {
    Action<ahu, ahu> action = this.a;
    Action<ahu, ahu> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<ahu, ahu>>(ref this.a, comparand - A_0, comparand);
    }
    while (action != comparand);
  }

  public void Dispose()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.i())
      return;
    // ISSUE: reference to a compiler-generated method
    if (this.h() != null && !this.c)
    {
      // ISSUE: reference to a compiler-generated method
      this.h().OnLeave();
    }
    // ISSUE: reference to a compiler-generated method
    this.f(true);
  }

  public virtual void nj(int A_0, ahu A_1)
  {
    A_1.b(this);
    this.b.Add(A_0, A_1);
  }

  public virtual bool nk(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (!this.b.ContainsKey(A_0) || this.i())
      return false;
    // ISSUE: reference to a compiler-generated method
    if (this.f() == A_0)
      return true;
    if (!this.f(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    int A_0_1 = this.f();
    // ISSUE: reference to a compiler-generated method
    ahu ahu = this.h();
    // ISSUE: reference to a compiler-generated method
    if (this.h() != null)
    {
      this.c = true;
      // ISSUE: reference to a compiler-generated method
      this.h().OnLeave();
      this.c = false;
    }
    // ISSUE: reference to a compiler-generated method
    this.g(A_0_1);
    // ISSUE: reference to a compiler-generated method
    this.h(A_0);
    // ISSUE: reference to a compiler-generated method
    this.f(this.b[A_0]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.h() != null && !this.i())
    {
      // ISSUE: reference to a compiler-generated method
      this.h().na();
    }
    if (this.a != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.a(ahu, this.h());
    }
    return true;
  }

  public virtual void nl(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!this.b.ContainsKey(A_0) || this.i() || this.f() == A_0)
      return;
    // ISSUE: reference to a compiler-generated method
    int A_0_1 = this.f();
    // ISSUE: reference to a compiler-generated method
    if (this.h() != null)
    {
      this.c = true;
      // ISSUE: reference to a compiler-generated method
      this.h().OnLeave();
      this.c = false;
    }
    // ISSUE: reference to a compiler-generated method
    this.g(A_0_1);
    // ISSUE: reference to a compiler-generated method
    this.h(A_0);
    // ISSUE: reference to a compiler-generated method
    this.f(this.b[A_0]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.h() == null || this.i())
      return;
    // ISSUE: reference to a compiler-generated method
    this.h().na();
  }

  private bool f(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.b.ContainsKey(A_0) && (this.h() == null || this.h().hg(A_0));
  }

  public ahu i(int A_0)
  {
    if (!this.b.ContainsKey(A_0))
      return (ahu) null;
    return this.b[A_0];
  }

  public void j()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.h().nb();
  }
}
