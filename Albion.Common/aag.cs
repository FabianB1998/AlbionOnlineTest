// Decompiled with JetBrains decompiler
// Type: aag
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections.Generic;

public class aag
{
  private List<aag.b> a = new List<aag.b>();
  private List<aag.b> b = new List<aag.b>();
  private Random c = new Random();

  public void a()
  {
    this.b.Clear();
    if (this.a.Count == 0)
      return;
    aag.b b = this.a[0];
    while (this.a.Count > 0 && GameTimeStamp.e(b.a, GameTimeStamp.Now))
    {
      this.a.RemoveAt(0);
      if (b.e)
        this.b.Add(b);
      try
      {
        b.c(b.d);
      }
      catch (Exception ex)
      {
        ab0.a(ex.Message + " " + ex.StackTrace.ToString());
      }
      if (this.a.Count > 0)
        b = this.a[0];
    }
    foreach (aag.b A_0 in this.b)
      this.b(A_0);
  }

  public void a(object A_0, aag.a A_1, GameTimeStamp A_2)
  {
    this.a(A_0, A_1, A_2, (object) null);
  }

  public void a(object A_0, aag.a A_1, GameTimeStamp A_2, object A_3)
  {
    this.c(new aag.b()
    {
      b = A_0,
      c = A_1,
      d = A_3,
      e = false,
      a = A_2,
      f = GameTimeStamp.c(A_2, GameTimeStamp.Now)
    });
  }

  public void a(object A_0, aag.a A_1, ahy A_2)
  {
    this.a(A_0, A_1, A_2, (object) null);
  }

  public void a(object A_0, aag.a A_1, ahy A_2, object A_3)
  {
    this.c(new aag.b()
    {
      b = A_0,
      c = A_1,
      d = A_3,
      e = false,
      a = GameTimeStamp.b(GameTimeStamp.Now, A_2),
      f = A_2
    });
  }

  public void b(object A_0, aag.a A_1, GameTimeStamp A_2)
  {
    this.b(A_0, A_1, A_2, (object) null);
  }

  public void b(object A_0, aag.a A_1, ahy A_2)
  {
    this.b(A_0, A_1, A_2, (object) null);
  }

  public void a(object A_0, aag.a A_1, ahy A_2, bool A_3)
  {
    this.a(A_0, A_1, A_2, (object) null, A_3, new ahy(0L), A_2);
  }

  public void a(object A_0, aag.a A_1, ahy A_2, bool A_3, ahy A_4, ahy A_5)
  {
    this.a(A_0, A_1, A_2, (object) null, A_3, A_4, A_5);
  }

  public void a(object A_0, aag.a A_1, ahy A_2, object A_3, bool A_4)
  {
    this.a(A_0, A_1, A_2, A_3, A_4, new ahy(0L), A_2);
  }

  public void b(object A_0, aag.a A_1, ahy A_2, object A_3)
  {
    this.a(A_0, A_1, GameTimeStamp.b(GameTimeStamp.Now, A_2), A_2, A_3);
  }

  public void b(object A_0, aag.a A_1, GameTimeStamp A_2, object A_3)
  {
    ahy A_3_1 = GameTimeStamp.c(A_2, GameTimeStamp.Now);
    this.a(A_0, A_1, A_2, A_3_1, A_3);
  }

  public void a(object A_0, aag.a A_1, ahy A_2, object A_3, bool A_4, ahy A_5, ahy A_6)
  {
    GameTimeStamp now = GameTimeStamp.Now;
    GameTimeStamp A_2_1;
    if (A_4)
    {
      int num = this.c.Next((int) A_5.o, (int) A_6.o);
      A_2_1 = GameTimeStamp.b(now, new ahy((long) num));
    }
    else
      A_2_1 = GameTimeStamp.b(now, A_2);
    this.a(A_0, A_1, A_2_1, A_2, A_3);
  }

  public void a(object A_0, aag.a A_1, GameTimeStamp A_2, ahy A_3)
  {
    this.a(A_0, A_1, A_2, A_3, (object) null);
  }

  public void a(object A_0, aag.a A_1, GameTimeStamp A_2, ahy A_3, object A_4)
  {
    this.c(new aag.b()
    {
      b = A_0,
      c = A_1,
      d = A_4,
      e = true,
      f = A_3,
      a = A_2
    });
  }

  public int a(object A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.c c = new aag.c();
    // ISSUE: reference to a compiler-generated field
    c.a = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.RemoveAll(new Predicate<aag.b>(c.b)) + this.b.RemoveAll(new Predicate<aag.b>(c.c));
  }

  public int a(object A_0, aag.a A_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.d d = new aag.d();
    // ISSUE: reference to a compiler-generated field
    d.a = A_0;
    // ISSUE: reference to a compiler-generated field
    d.b = A_1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.RemoveAll(new Predicate<aag.b>(d.c)) + this.b.RemoveAll(new Predicate<aag.b>(d.d));
  }

  public int a(object A_0, aag.a A_1, object A_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.e e = new aag.e();
    // ISSUE: reference to a compiler-generated field
    e.a = A_0;
    // ISSUE: reference to a compiler-generated field
    e.b = A_1;
    // ISSUE: reference to a compiler-generated field
    e.c = A_2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.RemoveAll(new Predicate<aag.b>(e.d)) + this.b.RemoveAll(new Predicate<aag.b>(e.e));
  }

  public int a(object A_0, aag.a A_1, ahy A_2, bool A_3, object A_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.f f = new aag.f();
    // ISSUE: reference to a compiler-generated field
    f.a = A_0;
    // ISSUE: reference to a compiler-generated field
    f.b = A_1;
    // ISSUE: reference to a compiler-generated field
    f.c = A_2;
    // ISSUE: reference to a compiler-generated field
    f.d = A_3;
    // ISSUE: reference to a compiler-generated field
    f.e = A_4;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.RemoveAll(new Predicate<aag.b>(f.f)) + this.b.RemoveAll(new Predicate<aag.b>(f.g));
  }

  public int a(object A_0, aag.a A_1, GameTimeStamp A_2, bool A_3, object A_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.g g = new aag.g();
    // ISSUE: reference to a compiler-generated field
    g.a = A_0;
    // ISSUE: reference to a compiler-generated field
    g.b = A_1;
    // ISSUE: reference to a compiler-generated field
    g.c = A_2;
    // ISSUE: reference to a compiler-generated field
    g.d = A_3;
    // ISSUE: reference to a compiler-generated field
    g.e = A_4;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.RemoveAll(new Predicate<aag.b>(g.f)) + this.b.RemoveAll(new Predicate<aag.b>(g.g));
  }

  public int b(object A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.h h = new aag.h();
    // ISSUE: reference to a compiler-generated field
    h.a = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.FindAll(new Predicate<aag.b>(h.b)).Count + this.b.FindAll(new Predicate<aag.b>(h.c)).Count;
  }

  public int b(object A_0, aag.a A_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.i i = new aag.i();
    // ISSUE: reference to a compiler-generated field
    i.a = A_0;
    // ISSUE: reference to a compiler-generated field
    i.b = A_1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.FindAll(new Predicate<aag.b>(i.c)).Count + this.b.FindAll(new Predicate<aag.b>(i.d)).Count;
  }

  public int b(object A_0, aag.a A_1, object A_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    aag.j j = new aag.j();
    // ISSUE: reference to a compiler-generated field
    j.a = A_0;
    // ISSUE: reference to a compiler-generated field
    j.b = A_1;
    // ISSUE: reference to a compiler-generated field
    j.c = A_2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return 0 + this.a.FindAll(new Predicate<aag.b>(j.d)).Count + this.b.FindAll(new Predicate<aag.b>(j.e)).Count;
  }

  private void c(aag.b A_0)
  {
    this.a(A_0);
  }

  private void b(aag.b A_0)
  {
    aag.b b = A_0;
    GameTimeStamp gameTimeStamp = GameTimeStamp.b(b.a, A_0.f);
    b.a = gameTimeStamp;
    this.a(A_0);
  }

  private void a(aag.b A_0)
  {
    if (this.a.Count == 0)
      this.a.Add(A_0);
    else if (this.a[0].CompareTo((object) A_0) > 0)
      this.a.Insert(0, A_0);
    else if (this.a[this.a.Count - 1].CompareTo((object) A_0) <= 0)
    {
      this.a.Add(A_0);
    }
    else
    {
      int num = this.a.BinarySearch(A_0);
      if (num < 0)
      {
        this.a.Insert(~num, A_0);
      }
      else
      {
        int index = num + 1;
        while (index < this.a.Count && this.a[index].CompareTo((object) A_0) == 0)
          ++index;
        if (index < this.a.Count)
          this.a.Insert(index, A_0);
        else
          this.a.Add(A_0);
      }
    }
  }

  public delegate void a(object A_0);

  private class b : IComparable
  {
    public GameTimeStamp a;
    public object b;
    public aag.a c;
    public object d;
    public bool e;
    public ahy f;

    public int CompareTo(object pObject)
    {
      aag.b b = pObject as aag.b;
      if (GameTimeStamp.g(b.a, this.a))
        return 0;
      return GameTimeStamp.i(b.a, this.a) ? 1 : -1;
    }
  }
}
