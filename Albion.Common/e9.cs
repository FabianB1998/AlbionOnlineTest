// Decompiled with JetBrains decompiler
// Type: e9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public abstract class e9 : e3
{
  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "movespeed", this.ia()));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.h(A_0, "endeffect"));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "scaleAnim", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "animID", string.Empty));
    return base.cj(A_0);
  }

  public enum MovementTypes : byte
  {
    Dash,
    Teleport,
    Knockback,
    ForcedMovement,
    Pull,
  }
}
