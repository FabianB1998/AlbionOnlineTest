// Decompiled with JetBrains decompiler
// Type: fh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fh : e9
{
  public static readonly string cn = "dash";

  [SpecialName]
  public override string cl()
  {
    return fh.cn;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(e9.MovementTypes.Dash);
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fh.RuleSets>(A_0, "ruleset", fh.RuleSets.TimeBasedOnDistance));
    return base.cj(A_0);
  }

  public enum RuleSets
  {
    TimeBasedOnDistance,
    ConstantTime,
  }
}
