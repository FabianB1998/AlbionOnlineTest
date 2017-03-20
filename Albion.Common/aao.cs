// Decompiled with JetBrains decompiler
// Type: aao
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Runtime.CompilerServices;

public class aao : aam
{
  protected bool a7;

  public aao(ab8 A_0, ab7 A_1, aaq A_2, ee A_3, ee A_4, bool A_5)
    : base(A_0, (ef) A_1, (ee) A_2, A_3, A_4)
  {
    this.a7 = A_5;
  }

  [SpecialName]
  public bool a8()
  {
    return this.a7;
  }

  [SpecialName]
  public void a8(bool A_0)
  {
    if (this.a7 == A_0)
      return;
    this.a7 = A_0;
    this.cv();
  }

  protected float a8(PlayerAttribute A_0, PlayerAttribute A_1)
  {
    ab7 c = this.c as ab7;
    if (c != null)
    {
      // ISSUE: reference to a compiler-generated method
      return (float) (((this.a8() ? (double) c.dd() : (double) c.c9()) + (double) this.e.cc(A_0) + (double) this.f.cc(A_0)) * (1.0 + (double) this.e.cc(A_1) + (double) this.f.cc(A_1)));
    }
    return 0.0f;
  }

  protected float a9(PlayerAttribute A_0, PlayerAttribute A_1)
  {
    ab7 c = this.c as ab7;
    if (c != null)
    {
      // ISSUE: reference to a compiler-generated method
      return (float) (((this.a8() ? (double) c.de() : (double) c.da()) + (double) this.e.cc(A_0) + (double) this.f.cc(A_0)) * (1.0 + (double) this.e.cc(A_1) + (double) this.f.cc(A_1)));
    }
    return 0.0f;
  }

  protected float ba(PlayerAttribute A_0, PlayerAttribute A_1)
  {
    ab7 c = this.c as ab7;
    if (c != null)
    {
      // ISSUE: reference to a compiler-generated method
      return (float) (((double) c.dw() + (double) this.c.cc(A_0) + (double) this.e.cc(A_0) + (double) this.f.cc(A_0)) * (1.0 + (double) this.e.cc(A_1) + (double) this.f.cc(A_1)));
    }
    return 0.0f;
  }

  protected override float c3(aam.a A_0)
  {
    switch (A_0)
    {
      case aam.a.e:
        return this.a8(PlayerAttribute.CraftingFocusMax, PlayerAttribute.CraftingFocusMaxBonus);
      case aam.a.f:
        return this.a9(PlayerAttribute.CraftingFocusRegeneration, PlayerAttribute.CraftingFocusRegenerationBonus);
      case aam.a.i:
        return this.ba(PlayerAttribute.AttackDamage, PlayerAttribute.PhysicalAttackDamageBonus);
      default:
        return base.c3(A_0);
    }
  }
}
