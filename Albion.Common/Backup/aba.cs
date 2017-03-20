// Decompiled with JetBrains decompiler
// Type: aba
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class aba : gr
{
  public override bool cq(XmlElement A_0)
  {
    if (!base.cq(A_0))
      return false;
    XmlNodeList childNodes = A_0.ChildNodes;
    // ISSUE: reference to a compiler-generated method
    this.h3(new List<es>(childNodes.Count));
    foreach (XmlElement A_0_1 in childNodes)
    {
      es es = gr.h3(A_0_1.Name, (gr) this);
      es.cj(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.jt().Add(es);
    }
    return true;
  }
}
