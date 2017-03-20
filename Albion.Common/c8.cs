// Decompiled with JetBrains decompiler
// Type: c8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class c8
{
  public c8(da A_0, int A_1)
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
    return this.f().ad();
  }

  public void e(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(new List<s>(A_0.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        s s = s.au(A_0_1.Name, this);
        s.ar(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.e().Add(s);
      }
    }
  }
}
