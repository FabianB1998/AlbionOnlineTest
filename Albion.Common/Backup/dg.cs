// Decompiled with JetBrains decompiler
// Type: dg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Linq;

public class dg
{
  public int a;
  public int b;

  public dg(int A_0, int A_1)
  {
    this.a = A_0;
    this.b = A_1;
  }

  public static bool c(string A_0, out dg A_1)
  {
    A_1 = new dg(0, 0);
    string s = new string(((IEnumerable<char>) A_0_1.ToCharArray()).Where<char>((Func<char, bool>) (A_0_2 => !char.IsWhiteSpace(A_0_2))).ToArray<char>());
    if (!s.Contains("-"))
      return int.TryParse(s, out A_1.a);
    string[] strArray = s.Split('-');
    if (!int.TryParse(strArray[0], out A_1.a) || !int.TryParse(strArray[1], out A_1.b))
      return false;
    if (A_1.a > A_1.b)
    {
      ab0.a("DistributionAmountValues Parse failed. RangeEnd is smaller than RangeStart");
      return false;
    }
    A_1.b = A_1.b - A_1.a;
    return true;
  }
}
