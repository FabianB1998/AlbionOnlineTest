// Decompiled with JetBrains decompiler
// Type: kc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class kc
{
  public kc(string A_0, params kc.a[] A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.c(A_0);
    // ISSUE: reference to a compiler-generated method
    this.c(new List<kc.a>((IEnumerable<kc.a>) A_1));
  }

  public class a
  {
    private acf a;
    public Dictionary<string, Dictionary<string, string>> b;

    public a(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
    {
      // ISSUE: reference to a compiler-generated method
      this.f(A_0);
      // ISSUE: reference to a compiler-generated method
      this.h(A_1);
      this.a = A_2;
      // ISSUE: reference to a compiler-generated method
      this.f(A_3);
      this.b = A_4;
    }

    [SpecialName]
    public acf h()
    {
      return this.a;
    }

    [SpecialName]
    private void g(acf A_0)
    {
      this.a = A_0;
    }
  }
}
