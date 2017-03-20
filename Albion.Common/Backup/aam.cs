// Decompiled with JetBrains decompiler
// Type: aam
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

public class aam
{
  private const float a = 0.1f;
  private Action<aam> b;
  protected ef c;
  protected ee d;
  protected ee e;
  protected ee f;
  private float[] g;
  private ab8 h;

  public aam(ab8 A_0, ef A_1, ee A_2, ee A_3, ee A_4)
  {
    this.g = new float[41];
    this.cx();
    this.h = A_0;
    this.c = A_1;
    this.d = A_2;
    this.e = A_3;
    this.f = A_4;
  }

  [SpecialName]
  public void a8(Action<aam> A_0)
  {
    Action<aam> action = this.b;
    Action<aam> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<aam>>(ref this.b, comparand + A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public void a9(Action<aam> A_0)
  {
    Action<aam> action = this.b;
    Action<aam> comparand;
    do
    {
      comparand = action;
      action = Interlocked.CompareExchange<Action<aam>>(ref this.b, comparand - A_0, comparand);
    }
    while (action != comparand);
  }

  [SpecialName]
  public float a9()
  {
    return this.a9(aam.a.a);
  }

  [SpecialName]
  public float ba()
  {
    return this.a9(aam.a.b);
  }

  [SpecialName]
  public float bb()
  {
    return this.a9(aam.a.c);
  }

  [SpecialName]
  public float bc()
  {
    return this.a9(aam.a.d);
  }

  [SpecialName]
  public float bd()
  {
    return this.a9(aam.a.g);
  }

  [SpecialName]
  public float be()
  {
    return this.a9(aam.a.h);
  }

  [SpecialName]
  public float bf()
  {
    return this.a9(aam.a.i);
  }

  [SpecialName]
  public float bg()
  {
    return this.a9(aam.a.j);
  }

  [SpecialName]
  public float bh()
  {
    return this.a9(aam.a.k);
  }

  [SpecialName]
  public float bi()
  {
    return Math.Max(0.1f, 1f + this.a9(aam.a.l));
  }

  [SpecialName]
  public float bj()
  {
    return Math.Max(0.1f, 1f + this.a9(aam.a.m));
  }

  [SpecialName]
  public float bk()
  {
    return this.a9(aam.a.n);
  }

  [SpecialName]
  public float bl()
  {
    return Math.Max(0.0f, 1f + this.bk());
  }

  [SpecialName]
  public float bm()
  {
    return this.a9(aam.a.o);
  }

  [SpecialName]
  public float bn()
  {
    return Math.Max(0.0f, 1f + this.bm());
  }

  [SpecialName]
  public float bo()
  {
    return this.a9(aam.a.r);
  }

  [SpecialName]
  public float bp()
  {
    return (float) (100.0 / (100.0 + (double) this.bo()));
  }

  [SpecialName]
  public float bq()
  {
    return Math.Max(0.0f, (float) (1.0 - 1.0 / ((double) this.a9(aam.a.p) + 1.0)));
  }

  [SpecialName]
  public float br()
  {
    return Math.Max(0.0f, 1f - this.bq());
  }

  [SpecialName]
  public float bs()
  {
    return Math.Max(0.0f, (float) (1.0 - 1.0 / (double) Math.Max(1f, this.a9(aam.a.q) + 1f)));
  }

  [SpecialName]
  public float bt()
  {
    return Math.Max(0.0f, 1f - this.bs());
  }

  [SpecialName]
  public float bu()
  {
    return Math.Max(0.0f, (float) (1.0 - 1.0 / (double) Math.Max(1f, this.a9(aam.a.ak) + 1f)));
  }

  [SpecialName]
  public float bv()
  {
    return Math.Max(0.0f, 1f - this.bu());
  }

  [SpecialName]
  public float bw()
  {
    return this.a9(aam.a.s);
  }

  [SpecialName]
  public float bx()
  {
    return Math.Max(0.0f, 1f + this.bw());
  }

  [SpecialName]
  public float by()
  {
    return this.a9(aam.a.t);
  }

  [SpecialName]
  public float bz()
  {
    return Math.Max(0.0f, 1f + this.by());
  }

  [SpecialName]
  public float b0()
  {
    return this.a9(aam.a.u);
  }

  [SpecialName]
  public float b1()
  {
    return Math.Max(0.0f, 1f - this.b0());
  }

  [SpecialName]
  public float b2()
  {
    return this.a9(aam.a.v);
  }

  [SpecialName]
  public float b3()
  {
    return (float) (100.0 / (100.0 + (double) this.b2()));
  }

  [SpecialName]
  public float b4()
  {
    return this.a9(aam.a.w);
  }

  [SpecialName]
  public float b5()
  {
    return (float) (100.0 / (100.0 + (double) this.b4()));
  }

  [SpecialName]
  public float b6()
  {
    return this.a9(aam.a.x);
  }

  [SpecialName]
  public float b7()
  {
    return (float) (100.0 / (100.0 + (double) this.b6()));
  }

  [SpecialName]
  public float b8()
  {
    return Math.Max(0.1f, 1f - this.a9(aam.a.z));
  }

  [SpecialName]
  public float b9()
  {
    return this.a9(aam.a.aa);
  }

  [SpecialName]
  public float ca()
  {
    return Math.Max(0.1f, 1f - this.a9(aam.a.y));
  }

  [SpecialName]
  public float cb()
  {
    return Math.Max(0.0f, this.a9(aam.a.ab));
  }

  [SpecialName]
  public float cc()
  {
    return 1f + this.a9(aam.a.ac);
  }

  [SpecialName]
  public float cd()
  {
    return 1f + this.a9(aam.a.ad);
  }

  [SpecialName]
  public float ce()
  {
    return 1f + this.a9(aam.a.ae);
  }

  [SpecialName]
  public float cf()
  {
    return 1f + this.a9(aam.a.af);
  }

  [SpecialName]
  public float cg()
  {
    return 1f + this.a9(aam.a.ai);
  }

  [SpecialName]
  public float ch()
  {
    return 1f + this.a9(aam.a.aj);
  }

  [SpecialName]
  public float ci()
  {
    return this.a9(aam.a.an);
  }

  [SpecialName]
  public float cj()
  {
    return Math.Max(0.0f, 1f + this.ci());
  }

  [SpecialName]
  public float ck()
  {
    return Math.Max(0.0f, 1f + this.a9(aam.a.ao));
  }

  [SpecialName]
  public float cl()
  {
    return this.d.d();
  }

  [SpecialName]
  public float cm()
  {
    return Math.Max(0.0f, 1f + this.d.d());
  }

  [SpecialName]
  public float cn()
  {
    return Math.Max(0.0f, 1f - this.d.c());
  }

  [SpecialName]
  public float co()
  {
    return Math.Max(Math.Min(1f, this.f.b()), 0.0f);
  }

  [SpecialName]
  public float cp()
  {
    return Math.Max(0.0f, 1f - this.d.a());
  }

  [SpecialName]
  public float cq()
  {
    return this.a9(aam.a.al);
  }

  [SpecialName]
  public float cr()
  {
    return this.a9(aam.a.y);
  }

  [SpecialName]
  public float cs()
  {
    return this.a9(aam.a.e);
  }

  [SpecialName]
  public float ct()
  {
    return this.a9(aam.a.f);
  }

  [SpecialName]
  public float cu()
  {
    return this.a9(aam.a.am);
  }

  public void cv()
  {
    this.cx();
    if (this.b == null)
      return;
    this.b(this);
  }

  public void cw()
  {
    this.cx();
    if (this.b == null)
      return;
    this.b(this);
  }

  public float a8(float A_0)
  {
    return 1f + (this.a9(aam.a.ag) + A_0);
  }

  public float a9(float A_0)
  {
    return (float) (1.0 / (1.0 + (double) (this.a9(aam.a.ah) + A_0)));
  }

  public float a8(string A_0, int A_1)
  {
    return this.f.cd(A_0, A_1) + this.e.cd(A_0, A_1) + this.d.cd(A_0, A_1);
  }

  public float a9(string A_0, int A_1)
  {
    return this.f.ce(A_0, A_1) + this.e.ce(A_0, A_1) + this.d.ce(A_0, A_1);
  }

  protected void cx()
  {
    for (int index = 0; index < 41; ++index)
      this.g[index] = float.NaN;
  }

  protected PlayerAttribute a8(aam.a A_0)
  {
    switch (A_0)
    {
      case aam.a.l:
        return PlayerAttribute.AttackRangeBonus;
      case aam.a.m:
        return PlayerAttribute.AttackSpeedBonus;
      case aam.a.n:
        return PlayerAttribute.PhysicalSpellDamageBonus;
      case aam.a.o:
        return PlayerAttribute.MagicSpellDamageBonus;
      case aam.a.p:
        return PlayerAttribute.MagicCastTimeReductionAdjusted;
      case aam.a.q:
        return PlayerAttribute.MagicCoolDownReductionAdjusted;
      case aam.a.r:
        return PlayerAttribute.MagicCastingResilience;
      case aam.a.s:
        return PlayerAttribute.HealBonus;
      case aam.a.t:
        return PlayerAttribute.HealModifier;
      case aam.a.u:
        return PlayerAttribute.EnergyCostReduction;
      case aam.a.v:
        return PlayerAttribute.PhysicalArmor;
      case aam.a.w:
        return PlayerAttribute.MagicResistance;
      case aam.a.x:
        return PlayerAttribute.CrowdControlResistance;
      case aam.a.y:
        return PlayerAttribute.CraftTime;
      case aam.a.z:
        return PlayerAttribute.InstallTime;
      case aam.a.aa:
        return PlayerAttribute.GatheringSpeed;
      case aam.a.ab:
        return PlayerAttribute.GatheringYield;
      case aam.a.ac:
        return PlayerAttribute.BonusDamageVsPlayers;
      case aam.a.ad:
        return PlayerAttribute.BonusDefenseVsPlayers;
      case aam.a.ae:
        return PlayerAttribute.BonusCCRVsPlayers;
      case aam.a.af:
        return PlayerAttribute.BonusCCDurationVsPlayers;
      case aam.a.ag:
        return PlayerAttribute.BonusDamageVsMobs;
      case aam.a.ah:
        return PlayerAttribute.BonusDefenseVsMobs;
      case aam.a.ai:
        return PlayerAttribute.BonusCCRVsMobs;
      case aam.a.aj:
        return PlayerAttribute.BonusCCDurationVsMobs;
      case aam.a.ak:
        return PlayerAttribute.CrowdControlDiminishingReturn;
      case aam.a.al:
        return PlayerAttribute.CraftingQuality;
      case aam.a.am:
        return PlayerAttribute.CraftingFocusCostReduction;
      case aam.a.an:
        return PlayerAttribute.AbilityPowerBonus;
      case aam.a.ao:
        return PlayerAttribute.ThreatBonus;
      default:
        return PlayerAttribute.NumAttributes;
    }
  }

  protected float bb(PlayerAttribute A_0, PlayerAttribute A_1)
  {
    return (float) (((double) this.c.cc(A_0) + (double) this.e.cc(A_0) + (double) this.f.cc(A_0)) * (1.0 + (double) this.e.cc(A_1) + (double) this.f.cc(A_1)));
  }

  protected virtual float c3(aam.a A_0)
  {
    switch (A_0)
    {
      case aam.a.a:
        return this.bb(PlayerAttribute.HitpointsMax, PlayerAttribute.HitpointsMaxBonus);
      case aam.a.b:
        return this.bb(PlayerAttribute.HitpointsRegeneration, PlayerAttribute.HitpointsRegenerationBonus);
      case aam.a.c:
        return this.bb(PlayerAttribute.EnergyMax, PlayerAttribute.EnergyMaxBonus);
      case aam.a.d:
        return this.bb(PlayerAttribute.EnergyRegeneration, PlayerAttribute.EnergyRegenerationBonus);
      case aam.a.e:
        return this.bb(PlayerAttribute.CraftingFocusMax, PlayerAttribute.CraftingFocusMaxBonus);
      case aam.a.f:
        return this.bb(PlayerAttribute.CraftingFocusRegeneration, PlayerAttribute.CraftingFocusRegenerationBonus);
      case aam.a.g:
        return this.bb(PlayerAttribute.MoveSpeed, PlayerAttribute.MoveSpeedBonus);
      case aam.a.h:
        return this.bb(PlayerAttribute.MaxLoad, PlayerAttribute.MaxLoadBonus);
      case aam.a.i:
        return this.bb(PlayerAttribute.AttackDamage, PlayerAttribute.PhysicalAttackDamageBonus);
      case aam.a.j:
        return this.bb(PlayerAttribute.AttackDamage, PlayerAttribute.PhysicalAttackDamageBonus);
      case aam.a.k:
        return this.bb(PlayerAttribute.AttackDamage, PlayerAttribute.MagicAttackDamageBonus);
      case aam.a.l:
      case aam.a.m:
      case aam.a.n:
      case aam.a.o:
      case aam.a.p:
      case aam.a.q:
      case aam.a.r:
      case aam.a.s:
      case aam.a.t:
      case aam.a.u:
      case aam.a.v:
      case aam.a.w:
      case aam.a.x:
      case aam.a.y:
      case aam.a.z:
      case aam.a.aa:
      case aam.a.ab:
      case aam.a.ac:
      case aam.a.ad:
      case aam.a.ae:
      case aam.a.af:
      case aam.a.ag:
      case aam.a.ah:
      case aam.a.ai:
      case aam.a.aj:
      case aam.a.ak:
      case aam.a.al:
      case aam.a.am:
      case aam.a.an:
      case aam.a.ao:
        PlayerAttribute A_0_1 = this.a8(A_0);
        return this.c.cc(A_0_1) + this.e.cc(A_0_1) + this.f.cc(A_0_1);
      default:
        return 0.0f;
    }
  }

  protected float a8(float A_0, PlayerAttribute A_1)
  {
    ab8.g g = this.h.hz(A_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return abh.b(A_0, g.e(), g.f());
  }

  protected float a8(PlayerAttribute A_0, PlayerAttribute A_1, float A_2)
  {
    ab8.g g = this.h.hz(A_0);
    // ISSUE: reference to a compiler-generated method
    float num1 = Math.Max(A_2, g.d());
    if ((double) num1 == 0.0)
      return 0.0f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    float num2 = abh.b(this.d.cc(A_0) / num1, g.e(), g.f());
    float num3 = this.a8(this.d.cc(A_1), A_1);
    return (float) (((double) A_2 + (double) num1 * (double) num2) * (1.0 + (double) num3));
  }

  protected float a8(aam.a A_0, float A_1)
  {
    switch (A_0)
    {
      case aam.a.a:
        return this.a8(PlayerAttribute.HitpointsMax, PlayerAttribute.HitpointsMaxBonus, A_1);
      case aam.a.b:
        return this.a8(PlayerAttribute.HitpointsRegeneration, PlayerAttribute.HitpointsRegenerationBonus, A_1);
      case aam.a.c:
        return this.a8(PlayerAttribute.EnergyMax, PlayerAttribute.EnergyMaxBonus, A_1);
      case aam.a.d:
        return this.a8(PlayerAttribute.EnergyRegeneration, PlayerAttribute.EnergyRegenerationBonus, A_1);
      case aam.a.e:
        return this.a8(PlayerAttribute.CraftingFocusMax, PlayerAttribute.CraftingFocusMaxBonus, A_1);
      case aam.a.f:
        return this.a8(PlayerAttribute.CraftingFocusRegeneration, PlayerAttribute.CraftingFocusRegenerationBonus, A_1);
      case aam.a.g:
        return this.a8(PlayerAttribute.MoveSpeed, PlayerAttribute.MoveSpeedBonus, A_1);
      case aam.a.h:
        return this.a8(PlayerAttribute.MaxLoad, PlayerAttribute.MaxLoadBonus, A_1);
      case aam.a.i:
        return this.a8(PlayerAttribute.AttackDamage, PlayerAttribute.PhysicalAttackDamageBonus, A_1);
      case aam.a.j:
        return this.a8(PlayerAttribute.AttackDamage, PlayerAttribute.PhysicalAttackDamageBonus, A_1);
      case aam.a.k:
        return this.a8(PlayerAttribute.AttackDamage, PlayerAttribute.MagicAttackDamageBonus, A_1);
      case aam.a.l:
      case aam.a.m:
      case aam.a.n:
      case aam.a.o:
      case aam.a.p:
      case aam.a.q:
      case aam.a.r:
      case aam.a.s:
      case aam.a.t:
      case aam.a.u:
      case aam.a.y:
      case aam.a.z:
      case aam.a.aa:
      case aam.a.ab:
      case aam.a.ac:
      case aam.a.ad:
      case aam.a.ae:
      case aam.a.af:
      case aam.a.ag:
      case aam.a.ah:
      case aam.a.ai:
      case aam.a.aj:
      case aam.a.ak:
      case aam.a.am:
      case aam.a.an:
      case aam.a.ao:
        PlayerAttribute playerAttribute = this.a8(A_0);
        return A_1 + this.a8(this.d.cc(playerAttribute), playerAttribute);
      case aam.a.v:
      case aam.a.w:
      case aam.a.x:
      case aam.a.al:
        PlayerAttribute A_0_1 = this.a8(A_0);
        ab8.g g = this.h.hz(A_0_1);
        // ISSUE: reference to a compiler-generated method
        float num1 = Math.Max(A_1, g.d());
        if ((double) num1 == 0.0)
          return 0.0f;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        float num2 = abh.b(this.d.cc(A_0_1) / num1, g.e(), g.f());
        return A_1 + num1 * num2;
      default:
        return 0.0f;
    }
  }

  protected float a9(aam.a A_0)
  {
    if (!float.IsNaN(this.g[(int) A_0]))
      return this.g[(int) A_0];
    float A_1 = this.c3(A_0);
    float val2 = this.a8(A_0, A_1);
    switch (A_0)
    {
      case aam.a.a:
      case aam.a.b:
      case aam.a.i:
      case aam.a.j:
      case aam.a.k:
      case aam.a.n:
      case aam.a.o:
      case aam.a.s:
        val2 *= this.cm();
        break;
      case aam.a.x:
        val2 = (float) ((double) val2 * (1.0 + (double) this.cl()) + 100.0 * (double) this.cl());
        break;
    }
    switch (A_0)
    {
      case aam.a.a:
        val2 = (float) Math.Round((double) Math.Max(1f, val2));
        break;
      case aam.a.b:
      case aam.a.d:
      case aam.a.f:
      case aam.a.g:
      case aam.a.i:
      case aam.a.j:
      case aam.a.k:
      case aam.a.r:
      case aam.a.v:
      case aam.a.w:
      case aam.a.x:
      case aam.a.ac:
      case aam.a.ad:
      case aam.a.ae:
      case aam.a.af:
      case aam.a.ag:
      case aam.a.ah:
      case aam.a.ai:
      case aam.a.aj:
        val2 = Math.Max(0.0f, val2);
        break;
      case aam.a.c:
        val2 = (float) Math.Round((double) Math.Max(0.0f, val2));
        break;
      case aam.a.e:
        val2 = (float) Math.Round((double) Math.Max(0.0f, val2));
        break;
      case aam.a.h:
        val2 = Math.Max(1f, val2);
        break;
    }
    this.g[(int) A_0] = val2;
    return val2;
  }

  protected enum a
  {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
    j,
    k,
    l,
    m,
    n,
    o,
    p,
    q,
    r,
    s,
    t,
    u,
    v,
    w,
    x,
    y,
    z,
    aa,
    ab,
    ac,
    ad,
    ae,
    af,
    ag,
    ah,
    ai,
    aj,
    ak,
    al,
    am,
    an,
    ao,
    ap,
  }
}
