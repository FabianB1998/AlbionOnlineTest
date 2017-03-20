// Decompiled with JetBrains decompiler
// Type: ahs
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class ahs : ahp
{
  private kz x;

  public ahs(aht A_0, int A_1)
    : base(A_0, A_1)
  {
  }

  public override ahm c8(aht A_0)
  {
    // ISSUE: reference to a compiler-generated method
    ahs ahs = new ahs(A_0, this.ac());
    ahs.x = this.x;
    ahs.l = this.l;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahs.y(this.ae());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahs.y(this.ad());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ahs.y(this.af());
    return (ahm) ahs;
  }

  public override float c9()
  {
    return this.x.c0();
  }

  public override ahm da(ace A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.y() == 0.0)
      return (ahm) null;
    // ISSUE: reference to a compiler-generated method
    if (!new ace(this.c7().i(), this.y()).c(A_0))
      return (ahm) null;
    return (ahm) this;
  }

  public override bool db(ab9 A_0)
  {
    return ((int) A_0.i(this.c7().i()) & 5) != 0;
  }

  public override void dd(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.y(this.x.c2(A_0));
  }

  public override void dc(XmlElement A_0)
  {
    base.dc(A_0);
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.ab()))
    {
      // ISSUE: reference to a compiler-generated method
      this.y("SEA_CIRC");
    }
    this.x = this.y(A_0, "radius");
  }
}
