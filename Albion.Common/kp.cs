// Decompiled with JetBrains decompiler
// Type: kp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

public class kp : ke
{
  public kp(acf A_0, float A_1, ahk A_2, int A_3, int A_4)
    : base(A_0, A_1, A_2, A_3, A_4, "RealEstate")
  {
  }

  public void o(acd A_0)
  {
    this.o(A_0, acb.a.f);
  }

  public void p(acd A_0)
  {
    this.o(A_0, acb.a.b);
  }

  private void o(acd A_0, acb.a A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int A_0_1 = 0; A_0_1 < this.u().u(); ++A_0_1)
    {
      this.o(A_0_1, 0, acb.b.a, (byte) A_1);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.o(A_0_1, this.u().v() - 1, acb.b.a, (byte) A_1);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int A_1_1 = 0; A_1_1 < this.u().v(); ++A_1_1)
    {
      this.o(0, A_1_1, acb.b.a, (byte) A_1);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.o(this.u().u() - 1, A_1_1, acb.b.a, (byte) A_1);
    }
    // ISSUE: reference to a compiler-generated method
    A_0 = acd.j(A_0, this.p().o());
    A_0 = acd.j(A_0, this.ab());
    // ISSUE: explicit reference operation
    // ISSUE: variable of a reference type
    acd& local = @A_0;
    // ISSUE: explicit reference operation
    ahk ahk = ahk.c((^local).b, new ahk(1f, 1f));
    // ISSUE: explicit reference operation
    (^local).b = ahk;
    this.o(A_0, acb.b.a, (byte) 32);
  }
}
