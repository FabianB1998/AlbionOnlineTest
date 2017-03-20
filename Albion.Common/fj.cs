// Decompiled with JetBrains decompiler
// Type: fj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fj : e9
{
  public static readonly string cx = "knockback";

  [SpecialName]
  public override string cl()
  {
    return fj.cx;
  }

  public override es.a cm()
  {
    return es.a.c;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(e9.MovementTypes.Knockback);
    // ISSUE: reference to a compiler-generated method
    this.h4(7.5f);
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "distance", 7.5f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fj.RuleSets>(A_0, "ruleset", fj.RuleSets.TimeBasedOnDistance));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fj.FromWheres>(A_0, "fromwhere", fj.FromWheres.FromCollisionPoint));
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.ic(true);
    return true;
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "distance":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return er.h4(p3.b(this.h3(), A_0.d.ar(), A_0.e, this.i3()));
      default:
        return base.ck(A_0);
    }
  }

  public enum RuleSets
  {
    TimeBasedOnDistance,
    ConstantTime,
  }

  public enum FromWheres
  {
    FromCaster,
    FromCollisionPoint,
  }
}
