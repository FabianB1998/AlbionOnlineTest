// Decompiled with JetBrains decompiler
// Type: di
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;

public class di : IComparer<dh>
{
  public int Compare(dh x, dh y)
  {
    if (x != null && y != null)
    {
      int num = ((int) y.a).CompareTo((int) x.a);
      if (num == 0)
        num = string.Compare(x.b, y.b, StringComparison.CurrentCultureIgnoreCase);
      if (num == 0)
        num = y.c.CompareTo(x.c);
      return num;
    }
    if (x != null)
      return 1;
    return y != null ? -1 : 0;
  }
}
