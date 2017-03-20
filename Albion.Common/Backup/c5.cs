// Decompiled with JetBrains decompiler
// Type: c5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Runtime.CompilerServices;
using System.Xml;

public class c5 : c3, c4
{
  public c5(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(EquipmentSlot.Invalid);
    // ISSUE: reference to a compiler-generated method
    this.a(false);
    // ISSUE: reference to a compiler-generated method
    this.a((string) null);
    // ISSUE: reference to a compiler-generated method
    this.b(100f);
    // ISSUE: reference to a compiler-generated method
    this.a(100f);
  }

  [SpecialName]
  public ItemPowerProgressionType bx()
  {
    return ItemPowerProgressionType.None;
  }

  [SpecialName]
  public bool by()
  {
    return false;
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a<EquipmentSlot>(A_0, "slottype", this.bw()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "unlockedtoequip", this.bz()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "consumespell", this.d0()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "abilitypower", this.b0()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "itempower", this.b1()));
    return true;
  }
}
