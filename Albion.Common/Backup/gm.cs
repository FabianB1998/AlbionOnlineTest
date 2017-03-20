// Decompiled with JetBrains decompiler
// Type: gm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Xml;

public class gm : gl
{
  public string i = string.Empty;

  public override bool cp(XmlElement A_0)
  {
    return this.p(A_0, false);
  }

  public virtual bool p(XmlElement A_0, bool A_1)
  {
    base.cp(A_0);
    this.i = aim.a(A_0, "event", "None");
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a<VfxAliveFuncTypes>(A_0, "alive", VfxAliveFuncTypes.None));
    // ISSUE: reference to a compiler-generated method
    this.q(aim.a(A_0, "fadeouttime", A_1 ? -1f : 0.0f));
    return true;
  }

  public void r(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.u(A_0);
  }

  public enum a
  {
    a,
    b,
    c,
    d,
    e,
  }
}
