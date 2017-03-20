// Decompiled with JetBrains decompiler
// Type: ah6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ah6
{
  public ah6(XmlElement A_0, aie A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.k(A_1);
    // ISSUE: reference to a compiler-generated method
    this.k(new Guid(aim.a(A_0, "id", string.Empty)));
    // ISSUE: reference to a compiler-generated method
    this.k(aim.a(A_0, "pos", ahk.d()));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "firstname", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.k(aim.a(A_0, "surname", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "type", string.Empty));
  }

  [SpecialName]
  public string r()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.p());
  }

  [SpecialName]
  public string s()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.q());
  }

  [SpecialName]
  public string t()
  {
    return this.r() + " " + this.s();
  }

  public void k(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.k(A_0.a2().hz(this.n()));
  }
}
