// Decompiled with JetBrains decompiler
// Type: aae
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.ResourceDistribution;
using System;

public struct aae : IEquatable<aae>
{
  public ResourceNodeTypes a;
  public string b;

  public aae(ResourceNodeTypes A_0, string A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public override int GetHashCode()
  {
    return (17 * 23 + this.a.GetHashCode()) * 23 + this.b.GetHashCode();
  }

  public bool Equals(aae other)
  {
    if (this.a == other.a)
      return this.b.Equals(other.b, StringComparison.CurrentCultureIgnoreCase);
    return false;
  }

  public override string ToString()
  {
    return this.a.ToString() + "_" + this.b;
  }
}
