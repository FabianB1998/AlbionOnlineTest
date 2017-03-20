// Decompiled with JetBrains decompiler
// Type: aax
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;

public class aax
{
  private ahy a;
  private ahy b;
  private ahk c;
  private ahy d;
  private k3 e;

  public void j(GameTimeStamp A_0, ahk A_1, float A_2, float A_3, ahy A_4, ahy A_5)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(A_1);
    // ISSUE: reference to a compiler-generated method
    this.l(A_2);
    this.a = A_4;
    this.b = A_5;
    // ISSUE: reference to a compiler-generated method
    this.k(A_3);
    this.j(A_0, A_1);
  }

  public void j(GameTimeStamp A_0, ahk A_1, ahk A_2, float A_3, float A_4, ahy A_5, ahy A_6)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(A_2);
    // ISSUE: reference to a compiler-generated method
    this.l(A_3);
    this.a = A_5;
    this.b = A_6;
    // ISSUE: reference to a compiler-generated method
    this.k(A_4);
    this.j(A_0, A_1);
  }

  protected void j(GameTimeStamp A_0, ahk A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.k(A_0);
    // ISSUE: reference to a compiler-generated method
    this.j(A_1);
    // ISSUE: reference to a compiler-generated method
    this.k(A_1);
    this.e = new k3((int) A_0.Ticks);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c = ahk.d(this.j(), ahk.b(ahk.b(this.e.cx(), this.k()), (float) this.e.j()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d = ahy.l((double) ahk.c(this.m(), this.c).k() / (double) this.l());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.j(GameTimeStamp.b(GameTimeStamp.b(this.p(), this.d), ahy.k(ahy.m(this.b, this.a), (float) this.e.j())));
    // ISSUE: reference to a compiler-generated method
    this.j(true);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.j(abh.b(ahk.c(this.c, this.r())));
  }

  public void l(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    while (GameTimeStamp.d(A_0, this.q()))
    {
      // ISSUE: reference to a compiler-generated method
      this.j(this.q(), this.c);
    }
    // ISSUE: reference to a compiler-generated method
    GameTimeStamp A_1 = GameTimeStamp.b(this.p(), this.d);
    if (GameTimeStamp.d(A_0, A_1))
    {
      // ISSUE: reference to a compiler-generated method
      this.j(false);
      // ISSUE: reference to a compiler-generated method
      this.k(this.c);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.j(true);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.k(ahk.a(this.r(), this.c, abh.b(this.p().Ticks, A_1.Ticks, A_0.Ticks)));
    }
  }
}
