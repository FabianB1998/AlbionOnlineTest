// Decompiled with JetBrains decompiler
// Type: k5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class k5
{
  private acd a;

  public k5(int A_0)
  {
    this.a = new acd(ahk.d(), new ahk((float) A_0, (float) A_0));
  }

  public k5(ahk A_0, int A_1)
  {
    this.a = new acd(A_0, ahk.d(A_0, new ahk((float) A_1, (float) A_1)));
  }

  public int a(int A_0)
  {
    return A_0 + 2 >> 2;
  }

  public int b(int A_0)
  {
    return 4 * A_0 - 2;
  }

  public int c(int A_0)
  {
    return 4 * A_0 + 1;
  }

  public int d(int A_0)
  {
    return ((int) Math.Pow(4.0, (double) A_0) - 1) / 3;
  }

  public acd e(int A_0)
  {
    ahk A_0_1 = ahk.d();
    float num1 = 1f;
    while (A_0 > 1)
    {
      int num2 = (A_0 + 2) % 4;
      ahk A_1 = new ahk((float) (num2 % 2) * num1, (float) (num2 / 2) * num1);
      A_0_1 = ahk.d(A_0_1, A_1);
      A_0 = this.a(A_0);
      num1 *= 2f;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_2 = this.a.a.g() + this.a.k().g() * A_0_1.g() / num1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_0_3 = this.a.a.g() + this.a.k().g() * (A_0_1.g() + 1f) / num1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_1 = this.a.a.h() + this.a.k().h() * A_0_1.h() / num1;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float A_1_2 = this.a.a.h() + this.a.k().h() * (A_0_1.h() + 1f) / num1;
    return new acd(new ahk(A_0_2, A_1_1), new ahk(A_0_3, A_1_2));
  }
}
