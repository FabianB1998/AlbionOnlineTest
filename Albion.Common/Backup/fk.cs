// Decompiled with JetBrains decompiler
// Type: fk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fk : e9
{
  public static readonly string c1 = "pull";

  [SpecialName]
  public override string cl()
  {
    return fk.c1;
  }

  public override es.a cm()
  {
    return es.a.c;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(e9.MovementTypes.Pull);
    // ISSUE: reference to a compiler-generated method
    this.h4(7.5f);
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "enddistance", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fk.PullWheres>(A_0, "pullwhere", fk.PullWheres.ToCaster));
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.ic(true);
    return true;
  }

  public enum PullWheres
  {
    ToCaster,
    ToTarget,
  }
}
