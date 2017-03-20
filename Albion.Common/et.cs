// Decompiled with JetBrains decompiler
// Type: et
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public abstract class et : es
{
  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "effectarearadius", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "showarearadius", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<et.EffectTarget>(A_0, "target", et.EffectTarget.Other));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "maxeffectareatargets", 99999));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ic(aim.a(A_0, "interruptscasting", this.iv()));
    // ISSUE: reference to a compiler-generated method
    this.h7(aim.a(A_0, "targetcountvaluebonusfactor", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<et.TargetCountTargetTypes>(A_0, "targetcounttargettype", et.TargetCountTargetTypes.Enemy));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.b(A_0, "targetcountthresholdmin", 0));
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.b(A_0, "targetcountthresholdmax", 0));
    // ISSUE: reference to a compiler-generated method
    this.h8(aim.a(A_0, "chance", 1f));
    // ISSUE: reference to a compiler-generated method
    this.id(aim.a(A_0, "donttriggerdiminishingreturns", false));
    // ISSUE: reference to a compiler-generated method
    this.ie(aim.a(A_0, "ignorediminishingreturns", false));
    // ISSUE: reference to a compiler-generated method
    this.h9(aim.a(A_0, "diminishingreturnfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.@if(aim.a(A_0, "ignoreabilitypowerscaling", false));
    if (A_0.HasChildNodes && A_0.HasChildNodes)
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(new fq());
      // ISSUE: reference to a compiler-generated method
      this.i5().co(A_0);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (this.i5().r().Count == 0)
      {
        // ISSUE: reference to a compiler-generated method
        this.h3((fq) null);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.h3(new List<gq>());
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "spellvfx":
            gq gq = new gq();
            gq.cp(A_0_1);
            // ISSUE: reference to a compiler-generated method
            this.i6().Add(gq);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public bool h3(bool A_0, bool A_1, bool A_2)
  {
    // ISSUE: reference to a compiler-generated method
    switch (this.ir())
    {
      case et.EffectTarget.None:
        return false;
      case et.EffectTarget.Self:
        return A_0;
      case et.EffectTarget.Other:
        return !A_0;
      case et.EffectTarget.OtherPlayers:
        if (!A_0)
          return A_2;
        return false;
      case et.EffectTarget.All:
        return true;
      case et.EffectTarget.AllMobs:
        return !A_2;
      case et.EffectTarget.AllPlayers:
        return A_2;
      case et.EffectTarget.Enemy:
        return A_1;
      case et.EffectTarget.EnemyMobs:
        if (A_1)
          return !A_2;
        return false;
      case et.EffectTarget.EnemyPlayers:
        if (A_1)
          return A_2;
        return false;
      case et.EffectTarget.FriendOther:
        if (!A_1)
          return !A_0;
        return false;
      case et.EffectTarget.FriendOtherPlayers:
        if (!A_1 && !A_0)
          return A_2;
        return false;
      case et.EffectTarget.FriendAll:
        return !A_1;
      case et.EffectTarget.FriendAllMobs:
        if (!A_1 && !A_0)
          return !A_2;
        return false;
      case et.EffectTarget.FriendAllPlayers:
        if (!A_1 && !A_0)
          return A_2;
        return false;
      case et.EffectTarget.Ground:
        return false;
      default:
        return false;
    }
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "target":
        // ISSUE: reference to a compiler-generated method
        return er.h3((Enum) this.ir());
      case "effectarearadius":
        // ISSUE: reference to a compiler-generated method
        return er.h4(this.@is());
      case "maxeffectareatargets":
        // ISSUE: reference to a compiler-generated method
        return string.Format("{0:0}", (object) this.iu());
      default:
        return base.ck(A_0);
    }
  }

  public enum EffectTarget
  {
    None,
    Self,
    Other,
    OtherPlayers,
    All,
    AllMobs,
    AllPlayers,
    Enemy,
    EnemyMobs,
    EnemyPlayers,
    FriendOther,
    FriendOtherPlayers,
    FriendAll,
    FriendAllMobs,
    FriendAllPlayers,
    Ground,
  }

  public enum TargetCountTargetTypes
  {
    Friend,
    Enemy,
    All,
  }
}
