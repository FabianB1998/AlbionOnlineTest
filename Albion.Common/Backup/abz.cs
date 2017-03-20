// Decompiled with JetBrains decompiler
// Type: abz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;

public class abz
{
  private ahy a;

  public void g(gt A_0, c4 A_1, long A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(A_0);
    // ISSUE: reference to a compiler-generated method
    this.g(A_1);
    // ISSUE: reference to a compiler-generated method
    this.g(A_2);
  }

  public bool i(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h() != null)
    {
      // ISSUE: reference to a compiler-generated method
      return GameTimeStamp.e(this.l(), A_0);
    }
    return false;
  }

  public float j(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h() == null)
      return 0.0f;
    // ISSUE: reference to a compiler-generated method
    if (GameTimeStamp.e(this.l(), A_0))
      return 1f;
    // ISSUE: reference to a compiler-generated method
    return (float) (1.0 - (double) GameTimeStamp.c(this.l(), A_0).o / (double) this.a.o);
  }

  public ahy k(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (GameTimeStamp.h(this.l(), A_0))
    {
      // ISSUE: reference to a compiler-generated method
      return GameTimeStamp.c(this.l(), A_0);
    }
    return ahy.h;
  }

  public void g(GameTimeStamp A_0, ahy A_1, abz.a A_2)
  {
    if (!ahy.q(this.k(A_0), A_1))
      return;
    // ISSUE: reference to a compiler-generated method
    this.g(A_2);
    // ISSUE: reference to a compiler-generated method
    this.h(A_0);
    // ISSUE: reference to a compiler-generated method
    this.g(GameTimeStamp.b(A_0, A_1));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a = GameTimeStamp.c(this.l(), this.k());
  }

  public void g(bool A_0, bool A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_1 && this.g() == abz.a.b)
      return;
    // ISSUE: reference to a compiler-generated method
    if (A_0 && this.h() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (es es in this.h().jt())
      {
        if (es is hp)
          return;
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.g(GameTimeStamp.Now);
  }

  public void l(GameTimeStamp A_0)
  {
    this.a = ahy.l(GameTimeStamp.c(A_0, GameTimeStamp.Now).t() / (1.0 - (double) this.j(GameTimeStamp.Now)));
    // ISSUE: reference to a compiler-generated method
    this.g(A_0);
  }

  public enum a
  {
    a,
    b,
  }
}
