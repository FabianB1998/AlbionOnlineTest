// Decompiled with JetBrains decompiler
// Type: dm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class dm : IEquatable<dm>
{
  public readonly string a;
  public readonly int b;

  public dm(string A_0, int A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public override int GetHashCode()
  {
    return (17 * 23 + this.a.GetHashCode()) * 23 + this.b.GetHashCode();
  }

  public bool Equals(dm other)
  {
    if (this.a.Equals(other.a, StringComparison.CurrentCultureIgnoreCase))
      return this.b == other.b;
    return false;
  }

  public override string ToString()
  {
    return this.a + " | " + (object) this.b;
  }
}
