// Decompiled with JetBrains decompiler
// Type: gs
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public class gs : gr
{
  public List<ik> di { get; protected set; }

  public List<gn> dj { get; protected set; }

  public List<g4> dk { get; protected set; }

  public List<gq> dl { get; protected set; }

  public List<gp> dm { get; protected set; }

  public List<@if> dn { get; protected set; }

  public bw @do { get; private set; }

  public cz dp { get; private set; }

  public float dq { get; private set; }

  public string dr { get; protected set; }

  public int ds { get; private set; }

  public bool dt { get; private set; }

  public ahy du { get; private set; }

  public bool dv { get; private set; }

  public float dw { get; private set; }

  public bool dx { get; protected set; }

  public gs.SpellTarget dy { get; protected set; }

  public bool dz { get; protected set; }

  public gs.SpellUiType d0 { get; protected set; }

  public gs.SpellCategory d1 { get; protected set; }

  public gs.SpellAssessment d2 { get; protected set; }

  public string d3 { get; private set; }

  public gs.AnimationMode d4 { get; private set; }

  public string d5 { get; private set; }

  public int d6 { get; protected set; }

  public int d7 { get; protected set; }

  public gs.StackingRules d8 { get; protected set; }

  public bool d9 { get; protected set; }

  public bool ea { get; private set; }

  public bool eb { get; private set; }

  public bool ec { get; private set; }

  public bool ed { get; private set; }

  public int ee { get; private set; }

  public bool ef { get; private set; }

  public List<ff> eg { get; private set; }

  public override bool cq(XmlElement A_0)
  {
    if (!base.cq(A_0))
      return false;
    this.ds = aim.b(A_0, "energyusage", 1);
    this.dt = aim.a(A_0, "showgizmo", false);
    this.du = ahy.l((double) aim.a(A_0, "hitdelay", 0.0f));
    this.dv = aim.a(A_0, "damagecancelscasting", false);
    this.dw = aim.a(A_0, "disruptionfactor", 1f);
    this.ed = aim.a(A_0, "allowedinknockdown", false);
    this.dx = aim.a(A_0, "hidespelleffecticon", false);
    this.d6 = aim.b(A_0, "maxstack", 1);
    this.d7 = aim.b(A_0, "maxcharges", 1);
    this.d8 = aim.a<gs.StackingRules>(A_0, "stackingrule", gs.StackingRules.ReplaceOldest);
    this.d9 = aim.a(A_0, "interruptiblebyspell", true);
    this.d9 = aim.a(A_0, "interruptiblebyspell", true);
    this.dy = aim.a<gs.SpellTarget>(A_0, "target", gs.SpellTarget.None);
    this.dz = aim.a(A_0, "adjustgroundtargettorange", false);
    this.ef = aim.a(A_0, "keepmovingaftercast", true);
    this.d5 = aim.a(A_0, "spelleffectanimation", string.Empty);
    if (string.Equals(this.d5, "none", StringComparison.CurrentCultureIgnoreCase))
      this.d5 = string.Empty;
    this.d3 = aim.a(A_0, "castanimation", string.Empty).ToLower();
    if (string.Equals(this.d3, "none", StringComparison.CurrentCultureIgnoreCase))
      this.d3 = string.Empty;
    this.d4 = aim.a<gs.AnimationMode>(A_0, "animmode", gs.AnimationMode.StartLoopClimaxEnd);
    this.dr = cz.d(A_0);
    this.d0 = aim.a<gs.SpellUiType>(A_0, "uitype", gs.SpellUiType.None);
    this.d1 = aim.a<gs.SpellCategory>(A_0, "category", gs.SpellCategory.None);
    this.d2 = aim.a<gs.SpellAssessment>(A_0, "assessment", gs.SpellAssessment.Negative);
    this.dn = @if.i(A_0);
    XmlNodeList childNodes = A_0.ChildNodes;
    this.eg = new List<ff>();
    // ISSUE: reference to a compiler-generated method
    this.h3(new List<es>());
    this.dj = new List<gn>();
    this.dk = new List<g4>();
    this.di = new List<ik>();
    this.dl = new List<gq>();
    this.dm = new List<gp>();
    this.dq = -1f;
    foreach (XmlNode xmlNode in childNodes)
    {
      if (xmlNode is XmlElement)
      {
        XmlElement A_0_1 = (XmlElement) xmlNode;
        if (A_0_1 != null)
        {
          switch (A_0_1.Name)
          {
            case "tintfx":
              this.ee = aim.a(A_0_1, "color", this.ee);
              continue;
            case "spelleffectfx":
              ik ik = new ik();
              ik.cp(A_0_1);
              this.di.Add(ik);
              continue;
            case "beamvfx":
              g4 g4 = new g4();
              g4.cp(A_0_1);
              this.dk.Add(g4);
              continue;
            case "fofIndicator":
              gp gp = new gp();
              gp.cp(A_0_1);
              this.dm.Add(gp);
              continue;
            case "spellvfx":
            case "impacteffect":
            case "spellcastfx":
            case "groundeffect":
              gq gq = new gq();
              gq.cp(A_0_1);
              this.dl.Add(gq);
              continue;
            case "AudioInfo":
            case "projectile":
              continue;
            case "scalefx":
              this.dq = aim.a(A_0_1, "scalevalue", -1f);
              continue;
            case "spellindicationarea":
              ff ff = new ff();
              if (ff.h3(A_0_1))
              {
                this.eg.Add(ff);
                continue;
              }
              continue;
            default:
              es es = gr.h3(A_0_1.Name, (gr) this);
              if (es != null)
              {
                es.cj(A_0_1);
                // ISSUE: reference to a compiler-generated method
                this.jt().Add(es);
                continue;
              }
              continue;
          }
        }
      }
    }
    this.ea = this.jl();
    this.eb = this.jj();
    this.ec = this.jk();
    return true;
  }

  public bool h3(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
  {
    return gs.h3(this.dy, A_0, A_1, A_2, A_3, A_4, A_5);
  }

  public static bool h3(gs.SpellTarget A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6)
  {
    switch (A_0)
    {
      case gs.SpellTarget.None:
        return false;
      case gs.SpellTarget.Self:
        if (A_1 && !A_3 && !A_4)
          return !A_5;
        return false;
      case gs.SpellTarget.Other:
        if (!A_1 && !A_3 && !A_4)
          return !A_5;
        return false;
      case gs.SpellTarget.All:
        if (!A_3 && !A_4)
          return !A_5;
        return false;
      case gs.SpellTarget.AllMobs:
        if (!A_3 && !A_4 && !A_5)
          return !A_6;
        return false;
      case gs.SpellTarget.AllPlayers:
        if (!A_3 && !A_4 && !A_5)
          return A_6;
        return false;
      case gs.SpellTarget.Enemy:
        if (A_2 && !A_3 && !A_4)
          return !A_5;
        return false;
      case gs.SpellTarget.EnemyMobs:
        if (A_2 && !A_3 && (!A_4 && !A_5))
          return !A_6;
        return false;
      case gs.SpellTarget.EnemyPlayers:
        if (A_2 && !A_3 && (!A_4 && !A_5))
          return A_6;
        return false;
      case gs.SpellTarget.FriendOther:
        if (!A_2 && !A_1 && (!A_3 && !A_4))
          return !A_5;
        return false;
      case gs.SpellTarget.FriendOtherMobs:
        if (!A_2 && !A_1 && (!A_3 && !A_4) && !A_5)
          return !A_6;
        return false;
      case gs.SpellTarget.FriendOtherPlayers:
        if (!A_2 && !A_1 && (!A_3 && !A_4) && !A_5)
          return A_6;
        return false;
      case gs.SpellTarget.FriendAll:
        if (!A_2 && !A_3 && !A_4)
          return !A_5;
        return false;
      case gs.SpellTarget.FriendAllMobs:
        if (!A_2 && !A_3 && (!A_4 && !A_5))
          return !A_6;
        return false;
      case gs.SpellTarget.FriendAllPlayers:
        if (!A_2 && !A_3 && (!A_4 && !A_5))
          return A_6;
        return false;
      case gs.SpellTarget.Ground:
        return false;
      case gs.SpellTarget.KnockedDownPlayer:
        if (A_4 && !A_5)
          return A_6;
        return false;
      case gs.SpellTarget.DeadPlayer:
        if (A_3)
          return A_6;
        return false;
      default:
        throw new ArgumentOutOfRangeException("SpellTarget", (object) A_0, (string) null);
    }
  }

  protected bool jj()
  {
    // ISSUE: reference to a compiler-generated method
    for (int index = 1; index < this.jt().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) ((et) this.jt()[index]).@is() != (double) ((et) this.jt()[index - 1]).@is())
        return true;
    }
    return false;
  }

  protected bool jk()
  {
    // ISSUE: reference to a compiler-generated method
    for (int index = 1; index < this.jt().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (((et) this.jt()[index]).iu() != ((et) this.jt()[index - 1]).iu())
        return true;
    }
    return false;
  }

  protected bool jl()
  {
    // ISSUE: reference to a compiler-generated method
    for (int index = 1; index < this.jt().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (((et) this.jt()[index]).ir() != ((et) this.jt()[index - 1]).ir())
        return true;
    }
    return false;
  }

  public bool h3(System.Type A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (es es in this.jt())
    {
      if (A_0.IsAssignableFrom(es.GetType()))
        return true;
    }
    return false;
  }

  public float jm()
  {
    float val2 = 0.0f;
    // ISSUE: reference to a compiler-generated method
    foreach (et et in this.jt())
    {
      // ISSUE: reference to a compiler-generated method
      val2 = Math.Max(et.@is(), val2);
    }
    return val2;
  }

  public ahy jn()
  {
    ahy A_0 = ahy.h;
    // ISSUE: reference to a compiler-generated method
    foreach (es es in this.jt())
    {
      // ISSUE: reference to a compiler-generated method
      if (es is e3 && ahy.u(A_0, ((e3) es).@if()))
      {
        // ISSUE: reference to a compiler-generated method
        A_0 = ((e3) es).@if();
      }
    }
    return A_0;
  }

  public override void cr(g8 A_0)
  {
    if (this.dn != null)
    {
      foreach (@if @if in this.dn)
        @if.i(A_0);
    }
    bw bw = new bw();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.jw()) && A_0.a9().ae.ContainsKey(this.jw()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      bw = A_0.a9().ae[this.jw()];
    }
    this.@do = bw;
    cz cz = new cz();
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.dr) && A_0.bc().u.ContainsKey(this.dr))
    {
      // ISSUE: reference to a compiler-generated method
      this.dp = A_0.bc().u[this.dr];
    }
    foreach (ff ff in this.eg)
      ff.h3(A_0);
    base.cr(A_0);
  }

  public static int h3(int A_0, ab8 A_1, float A_2, float A_3)
  {
    return (int) Math.Round((double) p3.a((float) A_0, A_1, A_2) * (double) A_3);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "target":
        return er.h3((Enum) this.dy);
      case "hitdelay":
        return er.h3(this.du);
      case "disruptionfactor":
        return string.Format("{0:0.##}", (object) this.dw);
      case "category":
        return er.h3((Enum) this.d1);
      case "energyusage":
        return gs.h3(this.ds, A_0);
      default:
        return base.ck(A_0);
    }
  }

  public static string h3(int A_0, er.a A_1)
  {
    // ISSUE: reference to a compiler-generated method
    return string.Format("{0:0}", (object) gs.h3(A_0, A_1.d.ar(), A_1.e, A_1.f.b1()));
  }

  public enum SpellTarget
  {
    None,
    Self,
    Other,
    All,
    AllMobs,
    AllPlayers,
    Enemy,
    EnemyMobs,
    EnemyPlayers,
    FriendOther,
    FriendOtherMobs,
    FriendOtherPlayers,
    FriendAll,
    FriendAllMobs,
    FriendAllPlayers,
    Ground,
    KnockedDownPlayer,
    DeadPlayer,
  }

  public enum SpellUiType
  {
    None,
    Heal,
    CrowdControl,
    Damage,
    Buff,
    Debuff,
    Movement,
  }

  public enum SpellCategory
  {
    None,
    Heal,
    CrowdControl,
    Damage,
    Buff,
    Debuff,
    Instant,
    Cheat,
    MatchBonus,
    CrimeDebuff,
    CrimeProtectionBuff,
    FocusFire,
    HealingSickness,
    DiminishingReturn,
    MountBuff,
    FurnitureBuff,
    FoodBuff,
    MovementBuff,
    TerritoryBuff,
    ForcedMovement,
  }

  public enum SpellAssessment
  {
    Negative,
    Positive,
  }

  public enum SpellAnimation
  {
    None,
    Cast_Heal,
    Cast_StandardAttack,
    Ranged_HorizontalShot,
    Ranged_StandardShot,
    Melee_StandardStrike,
    Melee_HighStrike,
    Melee_PierceStrike,
    Melee_ShieldSlam,
    Cast_Stomp,
    Cast_Silence,
    Cast_StaffOnGround,
    Melee_AreaDamage,
    Cast_AreaDamage,
    Cast_SpawnMob,
    Ranged_ThrowingKnife,
    Cast_Horn,
    Melee_GroundSlam,
    Melee_SweepingBlow,
    Ranged_AimCrossbow,
    Cast_2hMageStaff,
    Ranged_HeavyCrossbow,
    MagicStaff2H_Attack,
    MagicStaff2H_AoeSpell,
    MainStaff1H_Attack,
    MainStaff1H_AoeSpell,
    Ability_Eat,
    NumOfEntries,
  }

  public enum AnimationMode
  {
    SingleAnim,
    StartLoopClimaxEnd,
  }

  public enum StackingRules
  {
    ReplaceOldest,
    ReplaceWeakest,
  }
}
