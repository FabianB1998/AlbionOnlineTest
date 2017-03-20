// Decompiled with JetBrains decompiler
// Type: ah5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ah5
{
  public ah5(XmlElement A_0, aik A_1, aie A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(A_2);
    // ISSUE: reference to a compiler-generated method
    this.d(new Guid(aim.h(A_0, "id").Split('@')[0]));
  }

  [SpecialName]
  public string f()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.d().ToString() + (this.e() != null ? (object) ("@" + this.e().ah()) : (object) "");
  }
}
