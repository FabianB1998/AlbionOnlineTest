// Decompiled with JetBrains decompiler
// Type: io
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public class io : IComparable
{
  public io(float A_0, float A_1, string A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_0);
    // ISSUE: reference to a compiler-generated method
    this.e(A_1);
    // ISSUE: reference to a compiler-generated method
    this.e(A_2);
  }

  [SpecialName]
  public string h()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.g());
  }

  public int CompareTo(object obj)
  {
    if (obj is io)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (int) ((double) ((io) obj).e() * 100.0) - (int) ((double) this.e() * 100.0);
    }
    return 0;
  }
}
