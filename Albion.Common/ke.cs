// Decompiled with JetBrains decompiler
// Type: ke
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public abstract class ke : kd
{
  public ke(acf A_0, float A_1, ahk A_2, int A_3, int A_4, string A_5)
    : base(new acb("--dummy--", "", A_3, A_4, A_2, true, A_5, "", "", new byte[A_3 * A_4 * 2]), A_0, A_1)
  {
  }

  public void o()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.u().p().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.u().p()[index] = (byte) 0;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.u().p(false);
  }

  public void o(int A_0, int A_1, acb.b A_2, byte A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int index = (A_1 * this.u().u() + A_0) * 2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.u().p()[index] = (byte) A_2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.u().p()[index + 1] = A_3;
    if ((int) A_3 == 0)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.u().p(true);
  }

  public void o(acd A_0, acb.b A_1, byte A_2)
  {
    // ISSUE: reference to a compiler-generated method
    int num1 = Math.Max(0, (int) Math.Floor((double) A_0.a.g()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num2 = Math.Min(this.u().u() - 1, (int) Math.Ceiling((double) A_0.b.g()));
    // ISSUE: reference to a compiler-generated method
    int num3 = Math.Max(0, (int) Math.Floor((double) A_0.a.h()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num4 = Math.Min(this.u().v() - 1, (int) Math.Ceiling((double) A_0.b.h()));
    for (int index1 = num3; index1 <= num4; ++index1)
    {
      for (int index2 = num1; index2 <= num2; ++index2)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int index3 = (index1 * this.u().u() + index2) * 2;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.u().p()[index3] = (byte) A_1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.u().p()[index3 + 1] = A_2;
      }
    }
    if ((int) A_2 == 0)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.u().p(true);
  }
}
