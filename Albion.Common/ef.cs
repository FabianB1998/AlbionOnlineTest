// Decompiled with JetBrains decompiler
// Type: ef
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ef : ee
{
  protected bool a;
  private static int b;

  [SpecialName]
  public string el()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.em());
  }

  public float c4(PlayerAttribute A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.f0()[(int) A_0];
  }

  [SpecialName]
  public float e7()
  {
    return this.c4(PlayerAttribute.HitpointsMax);
  }

  [SpecialName]
  public float e8()
  {
    return this.c4(PlayerAttribute.HitpointsRegeneration);
  }

  [SpecialName]
  public float e9()
  {
    return this.c4(PlayerAttribute.HitpointsRegenerationBonus);
  }

  [SpecialName]
  public float fa()
  {
    return this.c4(PlayerAttribute.EnergyMax);
  }

  [SpecialName]
  public float fb()
  {
    return this.c4(PlayerAttribute.EnergyRegeneration);
  }

  [SpecialName]
  public float fc()
  {
    return this.c4(PlayerAttribute.EnergyRegenerationBonus);
  }

  [SpecialName]
  public float fd()
  {
    return this.c4(PlayerAttribute.MoveSpeed);
  }

  [SpecialName]
  public float fe()
  {
    return this.c4(PlayerAttribute.MoveSpeedBonus);
  }

  [SpecialName]
  public float ff()
  {
    return this.c4(PlayerAttribute.MaxLoad);
  }

  [SpecialName]
  public float fg()
  {
    return this.c4(PlayerAttribute.MaxLoadBonus);
  }

  [SpecialName]
  public float fh()
  {
    return this.c4(PlayerAttribute.AttackDamage);
  }

  [SpecialName]
  public float fi()
  {
    return this.c4(PlayerAttribute.PhysicalAttackDamageBonus);
  }

  [SpecialName]
  public float fj()
  {
    return this.c4(PlayerAttribute.MagicAttackDamageBonus);
  }

  [SpecialName]
  public float fk()
  {
    return this.c4(PlayerAttribute.AttackRangeBonus);
  }

  [SpecialName]
  public float fl()
  {
    return this.c4(PlayerAttribute.AttackSpeedBonus);
  }

  [SpecialName]
  public float fm()
  {
    return this.c4(PlayerAttribute.PhysicalSpellDamageBonus);
  }

  [SpecialName]
  public float fn()
  {
    return this.c4(PlayerAttribute.MagicSpellDamageBonus);
  }

  [SpecialName]
  public float fo()
  {
    return this.c4(PlayerAttribute.MagicCastTimeReductionRaw);
  }

  [SpecialName]
  public float fp()
  {
    return this.c4(PlayerAttribute.MagicCastTimeReductionAdjusted);
  }

  [SpecialName]
  public float fq()
  {
    return this.c4(PlayerAttribute.MagicCoolDownReductionRaw);
  }

  [SpecialName]
  public float fr()
  {
    return this.c4(PlayerAttribute.MagicCoolDownReductionAdjusted);
  }

  [SpecialName]
  public float fs()
  {
    return this.c4(PlayerAttribute.MagicCastingResilience);
  }

  [SpecialName]
  public float ft()
  {
    return this.c4(PlayerAttribute.HealBonus);
  }

  [SpecialName]
  public float fu()
  {
    return this.c4(PlayerAttribute.HealModifier);
  }

  [SpecialName]
  public float fv()
  {
    return this.c4(PlayerAttribute.EnergyCostReduction);
  }

  [SpecialName]
  public float fw()
  {
    return this.c4(PlayerAttribute.PhysicalArmor);
  }

  [SpecialName]
  public float fx()
  {
    return this.c4(PlayerAttribute.MagicResistance);
  }

  [SpecialName]
  public float fy()
  {
    return this.c4(PlayerAttribute.CrowdControlResistance);
  }

  [SpecialName]
  public float fz()
  {
    return this.c4(PlayerAttribute.AbilityPower);
  }

  public static void c9()
  {
    ef.b = 0;
  }

  public float cc(PlayerAttribute A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.f0()[(int) A_0];
  }

  public float cd(string A_0, int A_1)
  {
    return 0.0f;
  }

  public float ce(string A_0, int A_1)
  {
    return 0.0f;
  }

  protected virtual void c4()
  {
    if (this.a)
      return;
    // ISSUE: reference to a compiler-generated method
    if (this.ek() == 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.dd(ef.b++);
    }
    // ISSUE: reference to a compiler-generated method
    this.de(0.75f);
    // ISSUE: reference to a compiler-generated method
    this.dd(0.75f);
    // ISSUE: reference to a compiler-generated method
    this.c4(new float[57]);
    // ISSUE: reference to a compiler-generated method
    this.f0()[0] = 1000f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[2] = 1f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[4] = 100f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[6] = 5f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[7] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[12] = 5f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[13] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[14] = 25f;
    // ISSUE: reference to a compiler-generated method
    this.da(0.36f);
    // ISSUE: reference to a compiler-generated method
    this.c9(0.36f);
    // ISSUE: reference to a compiler-generated method
    this.c4(0.36f);
    // ISSUE: reference to a compiler-generated method
    this.f0()[53] = 100f;
    // ISSUE: reference to a compiler-generated method
    this.df(1f);
    // ISSUE: reference to a compiler-generated method
    this.dg("T0_LOOTBAG");
    this.a = true;
  }

  public bool c9(XmlElement A_0)
  {
    this.c4();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.de(aim.a(A_0, "uniquename", this.ej()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.df(aim.a(A_0, "namelocatag", this.em()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dd(aim.a(A_0, "prefab", this.en()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.de(aim.a(A_0, "collisionradius", this.eq()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dd(aim.a(A_0, "attackcollisionradius", this.er()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[0] = aim.a(A_0, "hitpointsmax", this.f0()[0]);
    // ISSUE: reference to a compiler-generated method
    this.f0()[1] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[2] = aim.a(A_0, "hitpointsregeneration", this.f0()[2]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[3] = aim.a(A_0, "hitpointsregenerationbonus", this.f0()[3]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[4] = aim.a(A_0, "energymax", this.f0()[4]);
    // ISSUE: reference to a compiler-generated method
    this.f0()[5] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[6] = aim.a(A_0, "energyregeneration", this.f0()[6]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[7] = aim.a(A_0, "energyregenerationbonus", this.f0()[7]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[12] = aim.a(A_0, "movespeed", this.f0()[12]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[13] = aim.a(A_0, "movespeedbonus", this.f0()[13]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[14] = (float) Math.Max(0.01, (double) aim.a(A_0, "maxload", this.f0()[14]));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[15] = aim.a(A_0, "maxloadbonus", this.f0()[15]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[16] = aim.a(A_0, "attackdamage", this.f0()[16]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[17] = aim.a(A_0, "physicalattackdamagebonus", this.f0()[17]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[18] = aim.a(A_0, "magicattackdamagebonus", this.f0()[18]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[19] = aim.a(A_0, "attackrangebonus", this.f0()[19]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[20] = aim.a(A_0, "attackspeedbonus", this.f0()[20]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[21] = aim.a(A_0, "physicalspelldamagebonus", this.f0()[21]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[22] = aim.a(A_0, "magicspelldamagebonus", this.f0()[22]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[23] = aim.a(A_0, "magiccasttimereduction", this.f0()[23]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[24] = (float) (1.0 / (1.0 - (double) this.f0()[23]) - 1.0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[25] = aim.a(A_0, "magiccooldownreduction", this.f0()[25]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[26] = (float) (1.0 / (1.0 - (double) this.f0()[25]) - 1.0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[27] = aim.a(A_0, "magiccastingresilience", this.f0()[27]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[28] = aim.a(A_0, "healbonus", this.f0()[28]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[29] = aim.a(A_0, "healmodifier", this.f0()[29]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[30] = aim.a(A_0, "energycostreduction", this.f0()[30]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[31] = aim.a(A_0, "physicalarmor", this.f0()[31]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[32] = aim.a(A_0, "magicresistance", this.f0()[32]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[33] = aim.a(A_0, "crowdcontrolresistance", this.f0()[33]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[53] = aim.a(A_0, "abilitypower", this.f0()[53]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[54] = aim.a(A_0, "abilitypowerbonus", this.f0()[54]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.db(aim.a(A_0, "attackrange", this.eu()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.a(A_0, "attackspeed", this.et()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.da(aim.a(A_0, "meleeattackdamagetime", this.ev()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.a(A_0, "rangedattackdamagetime", this.ew()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a(A_0, "magicattackdamagetime", this.ex()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.df(aim.a(A_0, "prefabscale", this.ep()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dg(aim.a(A_0, "lootprefab", this.eo()));
    // ISSUE: reference to a compiler-generated method
    this.dc(bv.h(A_0));
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.e2()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.dc(this.ej());
    }
    // ISSUE: reference to a compiler-generated method
    this.db(d1.a(A_0));
    // ISSUE: reference to a compiler-generated method
    this.da(ic.c(A_0));
    // ISSUE: reference to a compiler-generated method
    this.c9(gl.p(A_0));
    // ISSUE: reference to a compiler-generated method
    this.c4(id.p(A_0));
    return true;
  }

  public virtual void cf(g8 A_0)
  {
    ic A_0_1 = new ic();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.e4()) && A_0.bb().br.ContainsKey(this.e4()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_1 = A_0.bb().br[this.e4()];
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(A_0_1);
    bv A_0_2 = new bv();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.e2()) && A_0.a9().ad.ContainsKey(this.e2()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_2 = A_0.a9().ad[this.e2()];
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(A_0_2);
    bw A_0_3 = new bw();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.e2()) && A_0.a9().ae.ContainsKey(this.e2()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_3 = A_0.a9().ae[this.e2()];
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(A_0_3);
    Dictionary<string, d1> A_0_4 = new Dictionary<string, d1>();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.e3()) && A_0.ba().ab.ContainsKey(this.e3()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0_4 = A_0.ba().ab[this.e3()];
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(A_0_4);
  }
}
