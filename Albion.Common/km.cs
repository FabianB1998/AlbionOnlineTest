// Decompiled with JetBrains decompiler
// Type: km
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;

public class km
{
  public km(ahk[] A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(A_0);
  }

  public km(float[] A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(new ahk[A_0.Length / 2]);
    int index1 = 0;
    int num1 = 0;
    // ISSUE: reference to a compiler-generated method
    for (; index1 < this.d().Length; ++index1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ahk& local1 = @this.d()[index1];
      float[] numArray1 = A_0;
      int index2 = num1;
      int num2 = 1;
      int num3 = index2 + num2;
      double num4 = (double) numArray1[index2];
      // ISSUE: explicit reference operation
      // ISSUE: reference to a compiler-generated method
      (^local1).a((float) num4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      ahk& local2 = @this.d()[index1];
      float[] numArray2 = A_0;
      int index3 = num3;
      int num5 = 1;
      num1 = index3 + num5;
      double num6 = (double) numArray2[index3];
      // ISSUE: explicit reference operation
      // ISSUE: reference to a compiler-generated method
      (^local2).b((float) num6);
    }
  }

  [SpecialName]
  public ahk e()
  {
    // ISSUE: reference to a compiler-generated method
    return this.d()[0];
  }

  [SpecialName]
  public ahk f()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.d()[this.d().Length - 1];
  }

  public float g()
  {
    float num = 0.0f;
    // ISSUE: reference to a compiler-generated method
    for (int index = 1; index < this.d().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      num += ahk.c(this.d()[index - 1], this.d()[index]).k();
    }
    return num;
  }

  public float[] h()
  {
    // ISSUE: reference to a compiler-generated method
    float[] numArray1 = new float[this.d().Length * 2];
    int index1 = 0;
    int num1 = 0;
    // ISSUE: reference to a compiler-generated method
    for (; index1 < this.d().Length; ++index1)
    {
      float[] numArray2 = numArray1;
      int index2 = num1;
      int num2 = 1;
      int num3 = index2 + num2;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      double num4 = (double) this.d()[index1].g();
      numArray2[index2] = (float) num4;
      float[] numArray3 = numArray1;
      int index3 = num3;
      int num5 = 1;
      num1 = index3 + num5;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      double num6 = (double) this.d()[index1].h();
      numArray3[index3] = (float) num6;
    }
    return numArray1;
  }
}
