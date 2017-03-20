// Decompiled with JetBrains decompiler
// Type: dh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.ResourceDistribution;
using System;

public class dh : IEquatable<dh>
{
  public readonly ResourceNodeTypes a;
  public readonly string b;
  public readonly int c;

  public dh(ResourceNodeTypes A_0, string A_1, int A_2)
  {
    this.a = A_0;
    this.b = A_1;
    this.c = A_2;
  }

  public override int GetHashCode()
  {
    return ((17 * 23 + this.a.GetHashCode()) * 23 + this.b.GetHashCode()) * 23 + this.c.GetHashCode();
  }

  public bool Equals(dh other)
  {
    if (this.a == other.a && this.b.Equals(other.b, StringComparison.CurrentCultureIgnoreCase))
      return this.c == other.c;
    return false;
  }

  public override string ToString()
  {
    return this.a.ToString() + " | " + this.b + " | " + (object) this.c;
  }
}
