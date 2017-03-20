// Decompiled with JetBrains decompiler
// Type: kf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public class kf
{
  public kf(int A_0, int A_1, ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_2);
    // ISSUE: reference to a compiler-generated method
    this.g(A_0);
    // ISSUE: reference to a compiler-generated method
    this.f(A_1);
    // ISSUE: reference to a compiler-generated method
    this.f(new byte[A_0 * A_1]);
  }

  [SpecialName]
  public byte f(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.i()[A_1 * this.f() + A_0];
  }

  [SpecialName]
  public void f(int A_0, int A_1, byte A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i()[A_1 * this.f() + A_0] = A_2;
  }

  public void j()
  {
    // ISSUE: reference to a compiler-generated method
    foreach (byte num in this.i())
      num = (byte) 0;
  }

  public void f(kd A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (!A_0.u().aa())
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num1 = (int) Math.Round((double) A_0.ac().g() - (double) this.h().g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num2 = (int) Math.Round((double) A_0.ac().h() - (double) this.h().h());
    for (int A_1 = 0; A_1 < A_0.aa(); ++A_1)
    {
      for (int A_0_1 = 0; A_0_1 < A_0.z(); ++A_0_1)
        this.f(num1 + A_0_1, num2 + A_1, A_0.q(A_0_1, A_1));
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
}
