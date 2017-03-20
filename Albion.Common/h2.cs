// Decompiled with JetBrains decompiler
// Type: h2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class h2 : n
{
  protected Dictionary<int, gr> bn = new Dictionary<int, gr>();
  protected Dictionary<string, gr> bo = new Dictionary<string, gr>();

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.bo.Keys;
  }

  [SpecialName]
  public ICollection<gr> h0()
  {
    return (ICollection<gr>) this.bo.Values;
  }

  public gr hz(int A_0)
  {
    gr gr;
    if (!this.bn.TryGetValue(A_0, out gr))
      return (gr) null;
    return gr;
  }

  public gr hz(string A_0)
  {
    gr gr;
    if (!this.bo.TryGetValue(A_0, out gr))
      return (gr) null;
    return gr;
  }

  public gs h0(int A_0)
  {
    return this.hz(A_0) as gs;
  }

  public gs h0(string A_0)
  {
    return this.hz(A_0) as gs;
  }

  public aba h1(int A_0)
  {
    return this.hz(A_0) as aba;
  }

  public aba h1(string A_0)
  {
    return this.hz(A_0) as aba;
  }

  public static CharacterSpellSlot hz(EquipmentSlot A_0, int A_1)
  {
    switch (A_0)
    {
      case EquipmentSlot.MainHand:
        switch (A_1)
        {
          case 0:
            return CharacterSpellSlot.MainHand1;
          case 1:
            return CharacterSpellSlot.MainHand2;
          case 2:
            return CharacterSpellSlot.OffHandOrMainHand3;
        }
      case EquipmentSlot.OffHand:
        return CharacterSpellSlot.OffHandOrMainHand3;
      case EquipmentSlot.Head:
        return CharacterSpellSlot.Head;
      case EquipmentSlot.Armor:
        return CharacterSpellSlot.Armor;
      case EquipmentSlot.Shoes:
        return CharacterSpellSlot.Shoes;
      case EquipmentSlot.Potion:
        return CharacterSpellSlot.Potion;
      case EquipmentSlot.Food:
        return CharacterSpellSlot.Food;
    }
    return CharacterSpellSlot.Invalid;
  }

  public static EquipmentSlot hz(CharacterSpellSlot A_0, en A_1, out int A_2)
  {
    A_2 = 0;
    switch (A_0)
    {
      case CharacterSpellSlot.MainHand1:
        return EquipmentSlot.MainHand;
      case CharacterSpellSlot.MainHand2:
        A_2 = 1;
        return EquipmentSlot.MainHand;
      case CharacterSpellSlot.OffHandOrMainHand3:
        if (A_1 == null || A_1.bt <= 2)
          return EquipmentSlot.OffHand;
        A_2 = 2;
        return EquipmentSlot.MainHand;
      case CharacterSpellSlot.Armor:
        return EquipmentSlot.Armor;
      case CharacterSpellSlot.Head:
        return EquipmentSlot.Head;
      case CharacterSpellSlot.Shoes:
        return EquipmentSlot.Shoes;
      case CharacterSpellSlot.Potion:
        return EquipmentSlot.Potion;
      case CharacterSpellSlot.Food:
        return EquipmentSlot.Food;
      default:
        return EquipmentSlot.Invalid;
    }
  }

  public static EquipmentSlot hz(CharacterSpellSlot A_0, out int A_1)
  {
    A_1 = 0;
    if (A_0 != CharacterSpellSlot.OffHandOrMainHand3)
      return EquipmentSlot.Invalid;
    A_1 = 2;
    return EquipmentSlot.MainHand;
  }

  protected override bool aq(XmlElement A_0)
  {
    gr.h3();
    return this.hz(A_0, false);
  }

  protected override bool bu(XmlElement A_0)
  {
    return this.hz(A_0, true);
  }

  protected bool hz(XmlElement A_0, bool A_1)
  {
    if (A_0.Name != "spells")
      throw new AlbionException("[SpellData] LoadDataFromXml: XmlTag 'spells' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        gr gr = (gr) null;
        if (A_1 && this.bo.TryGetValue(aim.h(A_0_1, "uniquename"), out gr))
        {
          gr.cq(A_0_1);
          // ISSUE: reference to a compiler-generated method
          if (gr is gt && ((gt) gr).ij() != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.bn[((gt) gr).ij().jo()] = (gr) ((gt) gr).ij();
          }
        }
        else
        {
          switch (A_0_1.Name)
          {
            case "activespell":
              gr = (gr) new gt();
              break;
            case "passivespell":
              gr = (gr) new aba();
              break;
          }
          gr.cq(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.bn[gr.jo()] = gr;
          // ISSUE: reference to a compiler-generated method
          if (gr is gt && ((gt) gr).ij() != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.bn[((gt) gr).ij().jo()] = (gr) ((gt) gr).ij();
          }
          // ISSUE: reference to a compiler-generated method
          this.bo[gr.jp()] = gr;
        }
      }
    }
    return true;
  }

  public void hz(g8 A_0)
  {
    foreach (gr gr in this.bo.Values)
      gr.cr(A_0);
  }
}
