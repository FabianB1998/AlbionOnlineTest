// Decompiled with JetBrains decompiler
// Type: aac
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;

public class aac : IEqualityComparer<aae>, IComparer<aae>
{
  public int Compare(aae p1, aae p2)
  {
    int num = p2.a.CompareTo((object) p1.a);
    if (num == 0)
      num = p2.b.CompareTo(p1.b);
    return num;
  }

  public bool Equals(aae x, aae y)
  {
    return x.Equals(y);
  }

  public int GetHashCode(aae obj)
  {
    return obj.GetHashCode();
  }
}
