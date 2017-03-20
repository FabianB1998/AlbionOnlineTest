// Decompiled with JetBrains decompiler
// Type: kn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class kn
{
  private readonly List<kn.a> a = new List<kn.a>();

  [SpecialName]
  public int c()
  {
    return this.a.Count;
  }

  [SpecialName]
  public kn.a c(int A_0)
  {
    return this.a[A_0];
  }

  public void c(ahk A_0, float A_1, bool A_2)
  {
    this.a.Add(new kn.a() { a = A_0, b = A_1, c = A_2 });
  }

  public struct a
  {
    public ahk a;
    public float b;
    public bool c;
  }
}
