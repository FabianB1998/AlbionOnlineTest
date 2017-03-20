// Decompiled with JetBrains decompiler
// Type: aho
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class aho : ahn
{
  public aho(aht A_0)
    : base(A_0)
  {
  }

  [SpecialName]
  public override k2 c7()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ah() == null)
      return this.ad();
    // ISSUE: reference to a compiler-generated method
    return this.ah().c7();
  }

  public override ahm c8(aht A_0)
  {
    aho aho = new aho(A_0);
    aho.ae();
    // ISSUE: reference to a compiler-generated method
    if (this.y() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aho.z((ahn) this.y().c8(A_0));
      // ISSUE: reference to a compiler-generated method
      aho.y((ahm) aho.y());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aho.z(this.aa());
    }
    // ISSUE: reference to a compiler-generated method
    if (this.z() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aho.y((ahn) this.z().c8(A_0));
      // ISSUE: reference to a compiler-generated method
      aho.y((ahm) aho.z());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aho.y(this.ab());
    }
    return (ahm) aho;
  }

  public override void dc(XmlElement A_0)
  {
    this.ae();
    if (A_0 == null)
      return;
    XmlElement A_0_1 = aim.e(A_0, "shape");
    if (A_0_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.z(new ahn(this.ag()));
      // ISSUE: reference to a compiler-generated method
      this.y().dc(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.y((ahm) this.y());
      // ISSUE: reference to a compiler-generated method
      this.z(aim.h(A_0_1, "material"));
    }
    XmlElement A_0_2 = aim.e(A_0, "fill");
    if (A_0_2 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.y(new ahn(this.ag()));
    // ISSUE: reference to a compiler-generated method
    this.z().dc(A_0_2);
    // ISSUE: reference to a compiler-generated method
    this.y((ahm) this.z());
    // ISSUE: reference to a compiler-generated method
    this.y(aim.h(A_0_2, "material"));
  }

  public override float c9()
  {
    // ISSUE: reference to a compiler-generated method
    return this.y().c9();
  }

  public override ahm da(ace A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.y().da(A_0);
  }
}
