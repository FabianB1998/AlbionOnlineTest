// Decompiled with JetBrains decompiler
// Type: ch
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ch
{
  public ch(cg A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(A_0);
    // ISSUE: reference to a compiler-generated method
    this.e(A_1);
  }

  [SpecialName]
  public string h()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.f().n().ad();
  }

  public void e(c8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e(new List<s>(A_0.e().Count));
    // ISSUE: reference to a compiler-generated method
    foreach (s s1 in A_0.e())
    {
      s s2 = s1.cp(this);
      if (s2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.e().Add(s2);
      }
    }
  }
}
