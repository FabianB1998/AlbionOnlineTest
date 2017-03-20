// Decompiled with JetBrains decompiler
// Type: fg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fg : e3
{
  public static readonly string cf = "applyeffectoneventactive";

  [SpecialName]
  public override string cl()
  {
    return fg.cf;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fg.ApplyEffectTarget>(A_0, "applyeffecttarget", fg.ApplyEffectTarget.Enemy));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fg.Event>(A_0, "event", fg.Event.DoDamage));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "count", 0));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "spell"));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "applychance", 1f));
    return base.cj(A_0);
  }

  public enum ApplyEffectTarget
  {
    Self,
    Enemy,
    GroundAtEnemy,
  }

  public enum Event
  {
    DoDamage,
    ReceiveDamage,
    AutoAttack,
    CastFinished,
  }
}
