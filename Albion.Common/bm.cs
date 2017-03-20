// Decompiled with JetBrains decompiler
// Type: bm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class bm
{
  private static int a;

  public static void g()
  {
    bm.a = 0;
  }

  public bool g(XmlElement A_0)
  {
    if (A_0.Name != "expeditionagent")
      throw new AlbionException("[ExpeditionAgentInfo] ParseFromXml: XmlTag 'expeditionagent' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.g(bm.a++);
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "namegenerator", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "uiavatar", string.Empty));
    this.h(A_0);
    return true;
  }

  protected void h(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("expeditions");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement xmlElement = elementsByTagName[0] as XmlElement;
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.g(new List<string>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        string str = aim.a(A_0_1, "category", string.Empty);
        // ISSUE: reference to a compiler-generated method
        if (!string.IsNullOrEmpty(str) && !this.l().Contains(str))
        {
          // ISSUE: reference to a compiler-generated method
          this.l().Add(str);
        }
      }
    }
  }

  public void g(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.g(new List<bh>(this.l().Count));
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.l().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string A_0_1 = this.l()[index];
      // ISSUE: reference to a compiler-generated method
      bh bh = A_0.bh().hz(A_0_1);
      if (bh != null)
      {
        // ISSUE: reference to a compiler-generated method
        this.m().Add(bh);
      }
    }
  }
}
