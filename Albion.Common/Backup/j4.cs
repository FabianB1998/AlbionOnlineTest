// Decompiled with JetBrains decompiler
// Type: j4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Xml;

public class j4
{
  public bool d(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.d(aim.a(A_0, "starttime", new DateTime()).TimeOfDay);
    // ISSUE: reference to a compiler-generated method
    this.d(aim.b(A_0, "timezone", 0));
    return true;
  }
}
