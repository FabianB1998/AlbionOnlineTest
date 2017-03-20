// Decompiled with JetBrains decompiler
// Type: bk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bk
{
  private static int a;

  [SpecialName]
  public string x()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.y());
  }

  public static void n()
  {
    bk.a = 0;
  }

  public string v(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return kr.a(this.z(), new object[1]{ (object) A_0 });
  }

  public string w(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return kr.a(this.aa(), new object[1]{ (object) A_0 });
  }

  public bool n(XmlElement A_0)
  {
    if (A_0.Name != "expedition")
      throw new AlbionException("[ExpeditionInfo] ParseFromXml: XmlTag 'expedition' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.n(bk.a++);
    // ISSUE: reference to a compiler-generated method
    this.u(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.t(aim.a(A_0, "cluster", string.Empty));
    // ISSUE: reference to a compiler-generated method
    int length = this.q().IndexOf("_");
    if (length >= 0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.t(this.q().Substring(0, length));
    }
    // ISSUE: reference to a compiler-generated method
    this.s(aim.a(A_0, "category", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "timeout", ahy.h));
    this.o(A_0);
    this.p(A_0);
    return true;
  }

  protected void o(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.q(string.Empty);
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("narrator");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement A_0_1 = elementsByTagName[0] as XmlElement;
    if (A_0_1 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.q(aim.a(A_0_1, "uiavatar", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a(A_0_1, "namegenerator", string.Empty));
  }

  protected void p(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("mission");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    XmlElement A_0_1 = elementsByTagName[0] as XmlElement;
    if (A_0_1 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0_1, "title", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0_1, "introtext", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0_1, "extrotext", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.n(new List<b5>(A_0_1.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0_1)
    {
      XmlElement A_0_2 = obj as XmlElement;
      if (A_0_2 != null && A_0_2.Name == "step")
      {
        // ISSUE: reference to a compiler-generated method
        b5 b5 = new b5(this, this.w().Count);
        b5.f(A_0_2);
        // ISSUE: reference to a compiler-generated method
        this.w().Add(b5);
      }
    }
  }

  public void n(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(A_0.bh().hz(this.s()));
  }
}
