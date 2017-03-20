// Decompiled with JetBrains decompiler
// Type: kl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class kl
{
  private ab9 a;
  protected byte[] b;

  public kl(ab9 A_0, float A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_1);
    // ISSUE: reference to a compiler-generated method
    this.e(A_2);
    this.a = A_0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e((int) Math.Ceiling((double) A_0.f() * (double) A_1));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f((int) Math.Ceiling((double) A_0.g() * (double) A_1));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b = new byte[this.g() * this.h()];
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e(0, 0, this.a.f(), this.a.g());
  }

  public abf e(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new abf((int) Math.Round((double) A_0.g() * (double) this.e()), (int) Math.Round((double) A_0.h() * (double) this.e()));
  }

  public ahk e(abf A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return new ahk((float) A_0.c() / this.e(), (float) A_0.d() / this.e());
  }

  public void e(int A_0, int A_1, int A_2, int A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num1 = Math.Max(0, (int) Math.Ceiling(((double) A_0 - (double) this.f()) * (double) this.e()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num2 = Math.Max(0, (int) Math.Ceiling(((double) A_1 - (double) this.f()) * (double) this.e()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num3 = Math.Min(this.g() - 1, (int) (((double) (A_0 + A_2) + (double) this.f()) * (double) this.e()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num4 = Math.Min(this.h() - 1, (int) (((double) (A_1 + A_3) + (double) this.f()) * (double) this.e()));
    for (int index1 = num2; index1 <= num4; ++index1)
    {
      for (int index2 = num1; index2 <= num3; ++index2)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int num5 = (int) ((double) index2 / (double) this.e() - (double) this.f());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int num6 = (int) ((double) index1 / (double) this.e() - (double) this.f());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int num7 = (int) ((double) index2 / (double) this.e() + (double) this.f());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int num8 = (int) ((double) index1 / (double) this.e() + (double) this.f());
        byte num9 = 0;
        for (int A_1_1 = num6; A_1_1 <= num8; ++A_1_1)
        {
          for (int A_0_1 = num5; A_0_1 <= num7; ++A_0_1)
            num9 |= this.a.f(A_0_1, A_1_1);
        }
        byte num10 = (byte) ((uint) num9 & 5U);
        // ISSUE: reference to a compiler-generated method
        this.b[index1 * this.g() + index2] = num10;
      }
    }
  }

  public byte e(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return this.b[A_1 * this.g() + A_0];
  }
}
