// Decompiled with JetBrains decompiler
// Type: gl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class gl
{
  public float a = 1f;

  public gl()
  {
    // ISSUE: reference to a compiler-generated method
    this.s(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.u("floor");
    // ISSUE: reference to a compiler-generated method
    this.q(hk.d());
    // ISSUE: reference to a compiler-generated method
    this.r(0.0f);
    // ISSUE: reference to a compiler-generated method
    this.s(0.0f);
  }

  public virtual bool cp(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.s(aim.a(A_0, "prefab", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.t(aim.a(A_0, "target", "none"));
    this.a = aim.a(A_0, "size", this.a);
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a(A_0, "duration", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.s(aim.a(A_0, "timeoffset", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.u(aim.a(A_0, "socket", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "ignoresocketscale", false));
    // ISSUE: reference to a compiler-generated method
    this.q(hk.a(A_0, hk.d()));
    return true;
  }

  public static string p(XmlElement A_0)
  {
    return gl.p(A_0, "VfxPreset", "name");
  }

  protected static string p(XmlElement A_0, string A_1, string A_2)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, A_1);
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      if (xmlElementList.Count > 1)
        ab0.a("Too many " + A_1 + " Tags defined in: " + aim.a(A_0, "uniquename", A_0.Name) + " First is used.");
      string str = aim.a(xmlElementList[0], A_2, string.Empty);
      if (!string.IsNullOrEmpty(str))
        return str;
    }
    return string.Empty;
  }
}
