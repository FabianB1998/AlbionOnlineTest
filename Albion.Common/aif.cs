// Decompiled with JetBrains decompiler
// Type: aif
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;

public class aif
{
  public aif(aie A_0, Guid A_1, aie A_2, Guid A_3, Guid A_4, bool A_5, ahk A_6, aif.Kind A_7)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(A_1);
    // ISSUE: reference to a compiler-generated method
    this.m(A_3);
    // ISSUE: reference to a compiler-generated method
    this.n(A_4);
    // ISSUE: reference to a compiler-generated method
    this.l(A_5);
    // ISSUE: reference to a compiler-generated method
    this.m(A_0);
    // ISSUE: reference to a compiler-generated method
    this.l(A_2);
    // ISSUE: reference to a compiler-generated method
    this.l(A_6);
    // ISSUE: reference to a compiler-generated method
    this.l(A_7);
  }

  [SpecialName]
  public string n()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.m().ToString() + (this.l() != null ? (object) ("@" + this.l().ah()) : (object) "");
  }

  [SpecialName]
  public string q()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.p().ToString() + (this.o() != null ? (object) ("@" + this.o().ah()) : (object) "");
  }

  [SpecialName]
  public string t()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.s().ToString() + "@" + this.l().ah();
  }

  public enum Kind
  {
    Cluster,
    DungeonSolo,
    DungeonGroup,
    DungeonRaid,
    DungeonSpecial,
    DungeonSandbox,
    DungeonStubGroup,
    DungeonStubSolo,
  }
}
