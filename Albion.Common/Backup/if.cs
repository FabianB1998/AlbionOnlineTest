// Decompiled with JetBrains decompiler
// Type: if
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class @if
{
  public string a = "";
  public string b = "";
  public string c = "";
  public float d = 20f;
  public List<ie> f = new List<ie>();
  public float e;

  public ahy i(float A_0)
  {
    return ahy.l((double) (A_0 / this.d));
  }

  public void i(XmlNode A_0)
  {
    this.a = aim.a(A_0 as XmlElement, "prefab", "Prefabs/Vfx/Projectiles/Arrow");
    this.b = aim.a(A_0 as XmlElement, "startsocket", "");
    this.c = aim.a(A_0 as XmlElement, "hitsocket", "");
    this.d = aim.a(A_0 as XmlElement, "flyspeed", 20f);
    this.e = aim.a(A_0 as XmlElement, "timeoffset", 0.0f);
    XmlNodeList elementsByTagName = (A_0 as XmlElement).GetElementsByTagName("impactvfx");
    // ISSUE: reference to a compiler-generated method
    this.i(bv.h(A_0 as XmlElement));
    if (elementsByTagName == null || elementsByTagName.Count <= 0)
      return;
    foreach (XmlNode A_0_1 in elementsByTagName)
    {
      ie ie = new ie();
      ie.f(A_0_1);
      this.f.Add(ie);
    }
  }

  public virtual void i(g8 A_0)
  {
    bw A_0_1 = new bw();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.j()) && A_0.a9().ae.ContainsKey(this.j()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1 = A_0.a9().ae[this.j()];
    }
    // ISSUE: reference to a compiler-generated method
    this.i(A_0_1);
  }

  public static List<@if> i(XmlElement A_0)
  {
    List<@if> ifList = new List<@if>();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode is XmlElement)
      {
        XmlElement xmlElement = (XmlElement) childNode;
        if (xmlElement != null && xmlElement.Name == "projectile")
        {
          @if @if = new @if();
          @if.i((XmlNode) xmlElement);
          ifList.Add(@if);
        }
      }
    }
    return ifList;
  }
}
