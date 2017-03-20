// Decompiled with JetBrains decompiler
// Type: j2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class j2
{
  public j2(XmlElement A_0, aik A_1, aie A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(A_2);
    // ISSUE: reference to a compiler-generated method
    this.e(new Guid(aim.h(A_0, "id")));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "pos", ahk.d()));
  }

  [SpecialName]
  public string h()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.f().ToString() + (this.g() != null ? (object) ("@" + this.g().ah()) : (object) "");
  }
}
