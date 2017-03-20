// Decompiled with JetBrains decompiler
// Type: ku
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class ku : Random, kt
{
  public ku()
  {
  }

  public ku(int A_0)
    : base(A_0)
  {
  }

  public double cw(double A_0, double A_1)
  {
    return A_0 + this.NextDouble() * (A_1 - A_0);
  }

  public ahy a(ahy A_0, ahy A_1)
  {
    return ahy.k(A_0.o + (long) (this.NextDouble() * (double) (A_1.o - A_0.o)));
  }

  public ahk cx()
  {
    return new k4(1f, (float) this.cw(0.0, 2.0 * Math.PI)).c();
  }

  public int cy(float A_0)
  {
    double num = (double) A_0 - Math.Floor((double) A_0);
    if ((double) A_0 < 0.0)
      num = 1.0 - num;
    if (this.NextDouble() > num)
      return (int) Math.Floor((double) A_0);
    return (int) Math.Ceiling((double) A_0);
  }

  public bool cz(float A_0)
  {
    if ((double) A_0 <= 0.0)
      return false;
    if ((double) A_0 >= 1.0)
      return true;
    return this.cw(0.0, 1.0) <= (double) A_0;
  }
}
