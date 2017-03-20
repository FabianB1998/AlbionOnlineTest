// Decompiled with JetBrains decompiler
// Type: ca
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class ca : b9
{
  public ca(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d0(kx.h);
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d0(aim.c(A_0, "durability", this.fr()));
    aa9 k = this.k;
    return true;
  }

  protected void a(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d1(kx.o(this.fr(), A_0.ar().jc().i()));
    ca ca = this;
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = kx.p(ca.fs(), kx.k);
    // ISSUE: reference to a compiler-generated method
    ca.d1(A_0_1);
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    this.a(A_0);
  }
}
