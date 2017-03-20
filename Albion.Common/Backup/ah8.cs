// Decompiled with JetBrains decompiler
// Type: ah8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class ah8
{
  public ah8(XmlElement A_0, aik A_1, aie A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(A_2);
    // ISSUE: reference to a compiler-generated method
    this.e(new Guid(aim.h(A_0, "id")));
    Guid guid = new Guid(aim.h(A_0, "travelpointid"));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e(A_1.h6(guid.ToString() + "@" + A_2.ah()));
  }

  [SpecialName]
  public string e()
  {
    // ISSUE: reference to a compiler-generated method
    if (!(this.f() == Guid.Empty))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.f().ToString() + "@" + this.h().ah();
    }
    return string.Empty;
  }
}
