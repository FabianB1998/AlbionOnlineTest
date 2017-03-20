// Decompiled with JetBrains decompiler
// Type: aia
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class aia
{
  public Dictionary<string, aig> a = new Dictionary<string, aig>();
  public Dictionary<string, aia.a> b = new Dictionary<string, aia.a>();

  public aia(g8 A_0, string A_1)
  {
    string A_0_1 = Path.Combine(A_1, "tiles.xml");
    kq A_0_2 = new kq();
    A_0_2.d(A_0_1);
    // ISSUE: reference to a compiler-generated method
    foreach (aie aie in A_0.ax().h2())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (aie.aq().c() != 0)
      {
        // ISSUE: reference to a compiler-generated method
        string str = Path.Combine(A_1, aie.ai());
        if (File.Exists(str))
        {
          // ISSUE: reference to a compiler-generated method
          ab9 A_1_1 = new ab9(aie.ah());
          // ISSUE: reference to a compiler-generated method
          aig aig = new aig(A_0_2, A_1_1, A_0, aie.ah(), this);
          aig.u(str);
          aig.o();
          // ISSUE: reference to a compiler-generated method
          this.a.Add(aie.ah(), aig);
        }
      }
    }
  }

  public aia.a c(Guid A_0, string A_1)
  {
    return this.c(A_0.ToString() + "@" + A_1);
  }

  public aia.a c(string A_0)
  {
    aia.a a;
    this.b.TryGetValue(A_0, out a);
    return a;
  }

  public class a
  {
    [SpecialName]
    public string l()
    {
      // ISSUE: reference to a compiler-generated method
      if (!(this.m() == Guid.Empty))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return this.m().ToString() + "@" + this.h();
      }
      return string.Empty;
    }
  }
}
