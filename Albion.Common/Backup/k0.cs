// Decompiled with JetBrains decompiler
// Type: k0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;

public class k0 : kz
{
  private k0.b[] c;

  public k0(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.k(k0.a.a);
    this.c = new k0.b[A_0];
  }

  [SpecialName]
  public float m()
  {
    return this.c[0].a;
  }

  [SpecialName]
  public float n()
  {
    // ISSUE: reference to a compiler-generated method
    return this.c[this.l() - 1].a;
  }

  [SpecialName]
  public override float c0()
  {
    float num = float.MinValue;
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.l(); ++index)
    {
      if ((double) this.c[index].c > (double) num)
        num = this.c[index].c;
    }
    return num;
  }

  [SpecialName]
  public override float c1()
  {
    float num = float.MaxValue;
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.l(); ++index)
    {
      if ((double) this.c[index].c < (double) num)
        num = this.c[index].c;
    }
    return num;
  }

  public void o()
  {
    // ISSUE: reference to a compiler-generated method
    this.k(0);
  }

  public void k(float A_0, float A_1)
  {
    // ISSUE: reference to a compiler-generated method
    int index1 = this.l();
    // ISSUE: reference to a compiler-generated method
    for (int index2 = 0; index2 < this.l(); ++index2)
    {
      if ((double) this.c[index2].a == (double) A_0)
      {
        this.c[index2].c = A_1;
        return;
      }
      if ((double) this.c[index2].a > (double) A_0)
      {
        index1 = index2;
        break;
      }
    }
    // ISSUE: reference to a compiler-generated method
    for (int index2 = this.l(); index2 > index1; --index2)
      this.c[index2] = this.c[index2 - 1];
    this.c[index1].a = A_0;
    this.c[index1].c = A_1;
    if (index1 > 0)
    {
      this.c[index1 - 1].b = (float) (1.0 / ((double) this.c[index1].a - (double) this.c[index1 - 1].a));
      this.c[index1 - 1].d = this.c[index1].c - this.c[index1 - 1].c;
    }
    // ISSUE: reference to a compiler-generated method
    if (index1 < this.l())
    {
      this.c[index1].b = (float) (1.0 / ((double) this.c[index1 + 1].a - (double) this.c[index1].a));
      this.c[index1].d = this.c[index1 + 1].c - this.c[index1].c;
    }
    k0 k0 = this;
    // ISSUE: reference to a compiler-generated method
    int A_0_1 = k0.l() + 1;
    // ISSUE: reference to a compiler-generated method
    k0.k(A_0_1);
  }

  public override float c2(float A_0)
  {
    if ((double) A_0 < (double) this.c[0].a)
      return this.c[0].c;
    // ISSUE: reference to a compiler-generated method
    if ((double) A_0 > (double) this.c[this.l() - 1].a)
    {
      // ISSUE: reference to a compiler-generated method
      return this.c[this.l() - 1].c;
    }
    int index1 = 0;
    // ISSUE: reference to a compiler-generated method
    int index2 = this.l() - 1;
    while (index2 - index1 > 1)
    {
      int index3 = index1 + index2 >> 1;
      if ((double) this.c[index3].a <= (double) A_0)
        index1 = index3;
      else
        index2 = index3;
    }
    // ISSUE: reference to a compiler-generated method
    if (this.k() == k0.a.a)
    {
      if ((double) A_0 < (double) this.c[index2].a)
        return this.c[index1].c;
      return this.c[index2].c;
    }
    float num = (A_0 - this.c[index1].a) * this.c[index1].b;
    // ISSUE: reference to a compiler-generated method
    if (this.k() == k0.a.c)
      num = (double) num >= 0.5 ? (float) (1.0 - (1.0 - (double) num) * (1.0 - (double) num) * 2.0) : (float) ((double) num * (double) num * 2.0);
    return this.c[index1].c + this.c[index1].d * num;
  }

  public enum a
  {
    a,
    b,
    c,
  }

  private struct b
  {
    public float a;
    public float b;
    public float c;
    public float d;
  }
}
