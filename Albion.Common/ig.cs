// Decompiled with JetBrains decompiler
// Type: ig
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ig : fb
{
  public static readonly string hk = "applyeffectoneventpassive";

  [SpecialName]
  public override string cl()
  {
    return ig.hk;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ig.Target>(A_0, "target", ig.Target.Self));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ig.Event>(A_0, "event", ig.Event.DoDamage));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "spell"));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "chance", 0.0f));
    return true;
  }

  public enum Target
  {
    Self,
    Enemy,
    GroundAtEnemy,
  }

  public enum Event
  {
    Equipped,
    Unequipped,
    DoDamage,
    ReceiveDamage,
    AutoAttack,
    CastFinished,
  }
}
