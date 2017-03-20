// Decompiled with JetBrains decompiler
// Type: c3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class c3 : b9
{
  protected bool aq;

  public c3(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.cg(0);
    this.aq = false;
  }

  [SpecialName]
  public override bool bv()
  {
    return this.aq;
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cg(aim.b(A_0, "maxstacksize", this.ek()));
    this.aq = aim.a(A_0, "salvageable", this.aq);
    return true;
  }
}
