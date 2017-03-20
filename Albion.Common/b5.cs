// Decompiled with JetBrains decompiler
// Type: b5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class b5
{
  public b5(bk A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(A_0);
    // ISSUE: reference to a compiler-generated method
    this.f(A_1);
  }

  [SpecialName]
  public string i()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.h());
  }

  public void f(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "description", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.f(new List<s>(A_0.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        s s = s.au(A_0_1.Name, this);
        s.ar(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.j().Add(s);
      }
    }
  }
}
