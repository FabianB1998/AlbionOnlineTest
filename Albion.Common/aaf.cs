// Decompiled with JetBrains decompiler
// Type: aaf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public struct aaf : IEquatable<aaf>
{
  public acf a;
  public float b;
  public float c;

  public aaf(acf A_0, float A_1, float A_2)
  {
    this.a = A_0;
    this.b = A_1;
    this.c = A_2;
  }

  public override int GetHashCode()
  {
    return ((17 * 23 + this.a.GetHashCode()) * 23 + this.b.GetHashCode()) * 23 + this.c.GetHashCode();
  }

  public bool Equals(aaf other)
  {
    return this.a.Equals((object) other.a);
  }
}
