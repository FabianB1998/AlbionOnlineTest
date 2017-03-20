// Decompiled with JetBrains decompiler
// Type: k4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class k4
{
  public float a;
  public float b;

  public k4(float A_0, float A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public static k4 c(ahk A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return k4.c(A_0.g(), A_0.h());
  }

  public static k4 c(float A_0, float A_1)
  {
    return new k4((float) Math.Sqrt((double) A_0 * (double) A_0 + (double) A_1 * (double) A_1), (float) Math.Atan2((double) A_1, (double) A_0));
  }

  public ahk c()
  {
    return new ahk(this.a * (float) Math.Cos((double) this.b), this.a * (float) Math.Sin((double) this.b));
  }
}
