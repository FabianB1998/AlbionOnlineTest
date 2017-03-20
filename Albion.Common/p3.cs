// Decompiled with JetBrains decompiler
// Type: p3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;

public class p3
{
  public static float e(float A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return A_0 * (float) Math.Pow((double) A_2 / (double) A_1.jj(), (double) A_1.jl());
    }
    return A_0;
  }

  public static float d(float A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0 * A_2 / A_1.jj();
    }
    return A_0;
  }

  public static float c(float A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0 * A_2 / A_1.jj();
    }
    return A_0;
  }

  public static float b(float A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0 * A_2 / A_1.jj();
    }
    return A_0;
  }

  public static float a(float A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0 * A_2 / A_1.jj();
    }
    return A_0;
  }

  public static ahy a(ahy A_0, ab8 A_1, float A_2, bool A_3)
  {
    if (!A_3)
    {
      // ISSUE: reference to a compiler-generated method
      return ahy.l(ahy.k(A_0, A_2), A_1.jj());
    }
    return A_0;
  }

  public static float a(float A_0, ab8 A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    return A_0 * (A_2 / A_1.jj());
  }

  public static float a(PlayerAttribute A_0, float A_1, ab8 A_2, float A_3, bool A_4)
  {
    if (A_4 || (double) A_1 == 0.0)
      return A_1;
    switch (A_0)
    {
      case PlayerAttribute.PhysicalArmor:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return 200f * A_1 * (float) Math.Pow((double) A_3 / (double) A_2.jj(), (double) A_2.jm());
      case PlayerAttribute.MagicResistance:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return 200f * A_1 * (float) Math.Pow((double) A_3 / (double) A_2.jj(), (double) A_2.jm());
      case PlayerAttribute.CrowdControlResistance:
        // ISSUE: reference to a compiler-generated method
        return (float) (100.0 * (double) A_1 * ((double) A_3 / (double) A_2.jj()));
      case PlayerAttribute.CrowdControlDiminishingReturn:
        return A_3 * A_1;
      case PlayerAttribute.AbilityPower:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (A_3 / A_2.jj());
      case PlayerAttribute.HitpointsMax:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return A_1 * (float) Math.Pow((double) A_3 / (double) A_2.jj(), (double) A_2.jl());
      case PlayerAttribute.HitpointsRegeneration:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return A_1 * (float) Math.Pow((double) A_3 / (double) A_2.jj(), (double) A_2.jl());
      case PlayerAttribute.EnergyMax:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (A_3 / A_2.jj());
      case PlayerAttribute.EnergyRegeneration:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (A_3 / A_2.jj());
      case PlayerAttribute.MaxLoad:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return A_1 * (A_2.jk() * (float) Math.Pow((double) A_3 / (double) A_2.jj(), (double) A_2.jn()) - A_2.jk());
      case PlayerAttribute.AttackDamage:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (A_3 / A_2.jj());
      default:
        return A_1;
    }
  }

  public static bool c(PlayerAttribute A_0)
  {
    switch (A_0)
    {
      case PlayerAttribute.PhysicalArmor:
      case PlayerAttribute.MagicResistance:
      case PlayerAttribute.CrowdControlResistance:
      case PlayerAttribute.AbilityPower:
      case PlayerAttribute.ItemPower:
      case PlayerAttribute.HitpointsMax:
      case PlayerAttribute.HitpointsRegeneration:
      case PlayerAttribute.EnergyMax:
      case PlayerAttribute.EnergyRegeneration:
      case PlayerAttribute.AttackDamage:
        return true;
      default:
        return false;
    }
  }

  public static float a(PlayerAttribute A_0, float A_1, ab8 A_2, ab7 A_3, float A_4, ItemPowerProgressionType A_5)
  {
    switch (A_0)
    {
      case PlayerAttribute.PhysicalArmor:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_2.jo() * (double) A_2.c3.b(A_5)) * Math.Pow((double) A_2.ju(), (double) A_4 / 100.0) - (double) A_2.jo() * (double) A_2.c3.b(A_5));
      case PlayerAttribute.MagicResistance:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_2.jo() * (double) A_2.c3.b(A_5)) * Math.Pow((double) A_2.ju(), (double) A_4 / 100.0) - (double) A_2.jo() * (double) A_2.c3.b(A_5));
      case PlayerAttribute.CrowdControlResistance:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_2.jp() * (double) A_2.c4.b(A_5)) * Math.Pow((double) A_2.jv(), (double) A_4 / 100.0) - (double) A_2.jp() * (double) A_2.c4.b(A_5));
      case PlayerAttribute.AbilityPower:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (float) Math.Pow((double) A_2.jr(), (double) A_4 / 100.0);
      case PlayerAttribute.ItemPower:
        return A_4;
      case PlayerAttribute.HitpointsMax:
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_3.e7() * (double) A_2.c5.b(A_5)) * Math.Pow((double) A_2.js(), (double) A_4 / 100.0) - (double) A_3.e7() * (double) A_2.c5.b(A_5));
      case PlayerAttribute.HitpointsRegeneration:
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_3.e8() * (double) A_2.c5.b(A_5)) * Math.Pow((double) A_2.js(), (double) A_4 / 100.0) - (double) A_3.e8() * (double) A_2.c5.b(A_5));
      case PlayerAttribute.EnergyMax:
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_3.fa() * (double) A_2.c6.b(A_5)) * Math.Pow((double) A_2.jt(), (double) A_4 / 100.0) - (double) A_3.fa() * (double) A_2.c6.b(A_5));
      case PlayerAttribute.EnergyRegeneration:
        // ISSUE: reference to a compiler-generated method
        return (float) (((double) A_1 + (double) A_3.fb() * (double) A_2.c6.b(A_5)) * Math.Pow((double) A_2.jt(), (double) A_4 / 100.0) - (double) A_3.fb() * (double) A_2.c6.b(A_5));
      case PlayerAttribute.AttackDamage:
        // ISSUE: reference to a compiler-generated method
        return A_1 * (float) Math.Pow((double) A_2.jq(), (double) A_4 / 100.0);
      default:
        return A_1;
    }
  }

  public static bool b(PlayerAttribute A_0)
  {
    switch (A_0)
    {
      case PlayerAttribute.HitpointsMaxBonus:
      case PlayerAttribute.HitpointsRegenerationBonus:
      case PlayerAttribute.EnergyMaxBonus:
      case PlayerAttribute.EnergyRegenerationBonus:
      case PlayerAttribute.CraftingFocusMaxBonus:
      case PlayerAttribute.CraftingFocusRegenerationBonus:
      case PlayerAttribute.MoveSpeedBonus:
      case PlayerAttribute.MaxLoadBonus:
      case PlayerAttribute.PhysicalAttackDamageBonus:
      case PlayerAttribute.MagicAttackDamageBonus:
      case PlayerAttribute.AttackRangeBonus:
      case PlayerAttribute.AttackSpeedBonus:
      case PlayerAttribute.PhysicalSpellDamageBonus:
      case PlayerAttribute.MagicSpellDamageBonus:
      case PlayerAttribute.MagicCastTimeReductionAdjusted:
      case PlayerAttribute.MagicCoolDownReductionAdjusted:
      case PlayerAttribute.HealBonus:
      case PlayerAttribute.HealModifier:
      case PlayerAttribute.EnergyCostReduction:
      case PlayerAttribute.FocusFireModifier:
      case PlayerAttribute.HealingSicknessModifier:
      case PlayerAttribute.GatheringSpeed:
      case PlayerAttribute.GatheringYield:
      case PlayerAttribute.BonusDamageVsPlayers:
      case PlayerAttribute.BonusDefenseVsPlayers:
      case PlayerAttribute.BonusCCRVsPlayers:
      case PlayerAttribute.BonusCCDurationVsPlayers:
      case PlayerAttribute.BonusDamageVsMobs:
      case PlayerAttribute.BonusDefenseVsMobs:
      case PlayerAttribute.BonusCCRVsMobs:
      case PlayerAttribute.BonusCCDurationVsMobs:
      case PlayerAttribute.CraftingFocusCostReduction:
      case PlayerAttribute.AbilityPowerBonus:
      case PlayerAttribute.ThreatBonus:
        return true;
      default:
        return false;
    }
  }

  public static bool a(PlayerAttribute A_0)
  {
    switch (A_0)
    {
      case PlayerAttribute.HitpointsMax:
      case PlayerAttribute.HitpointsMaxBonus:
      case PlayerAttribute.HitpointsRegeneration:
      case PlayerAttribute.HitpointsRegenerationBonus:
      case PlayerAttribute.EnergyMax:
      case PlayerAttribute.EnergyMaxBonus:
      case PlayerAttribute.EnergyRegeneration:
      case PlayerAttribute.EnergyRegenerationBonus:
      case PlayerAttribute.CraftingFocusMax:
      case PlayerAttribute.CraftingFocusMaxBonus:
      case PlayerAttribute.CraftingFocusRegeneration:
      case PlayerAttribute.CraftingFocusRegenerationBonus:
        return true;
      default:
        return false;
    }
  }

  public static PlayerAttribute a(string A_0)
  {
    try
    {
      return (PlayerAttribute) Enum.Parse(typeof (PlayerAttribute), A_0);
    }
    catch
    {
      return PlayerAttribute.NumAttributes;
    }
  }
}
