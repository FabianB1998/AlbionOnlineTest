// Decompiled with JetBrains decompiler
// Type: id
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class id : gl
{
  public override bool cp(XmlElement A_0)
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
    this.q(hk.a(A_0, hk.c()));
    return true;
  }

  public new static string p(XmlElement A_0)
  {
    return gl.p(A_0, "FootStepVfxPreset", "name");
  }
}
