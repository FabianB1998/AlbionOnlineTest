// Decompiled with JetBrains decompiler
// Type: aad
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;

public class aad : IEqualityComparer<aaf>
{
  public bool Equals(aaf x, aaf y)
  {
    return x.Equals(y);
  }

  public int GetHashCode(aaf obj)
  {
    return obj.GetHashCode();
  }
}
