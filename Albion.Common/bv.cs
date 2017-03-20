// Decompiled with JetBrains decompiler
// Type: bv
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class bv
{
  public bu pCharType { get; private set; }

  public static bv i(XmlElement A_0)
  {
    bv bv = new bv();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "CharType":
            bv.pCharType = new bu(bu.a.c, "Char_Type", aim.a(A_0_1, "name", ""));
            continue;
          case "Gender":
            // ISSUE: reference to a compiler-generated method
            bv.n(new bu(bu.a.c, "Gender", aim.a(A_0_1, "name", "")));
            continue;
          case "MobFaction":
            // ISSUE: reference to a compiler-generated method
            bv.m(new bu(bu.a.c, "Mob_Faction", aim.a(A_0_1, "name", "")));
            continue;
          case "MobType":
            // ISSUE: reference to a compiler-generated method
            bv.l(new bu(bu.a.c, "Mob_Type", aim.a(A_0_1, "name", "")));
            continue;
          case "Size":
            // ISSUE: reference to a compiler-generated method
            bv.k(new bu(bu.a.c, "Size", aim.a(A_0_1, "name", "")));
            continue;
          case "ArmorType":
            // ISSUE: reference to a compiler-generated method
            bv.j(new bu(bu.a.c, "Armor_Type", aim.a(A_0_1, "name", "")));
            continue;
          case "WeaponType":
            // ISSUE: reference to a compiler-generated method
            bv.i(new bu(bu.a.c, "Weapon_Type", aim.a(A_0_1, "name", "")));
            continue;
          case "MountType":
            // ISSUE: reference to a compiler-generated method
            bv.h(new bu(bu.a.c, "Mount_Type", aim.a(A_0_1, "name", "")));
            continue;
          default:
            continue;
        }
      }
    }
    return bv;
  }

  public static string h(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "AudioInfo");
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      if (xmlElementList.Count > 1)
        ab0.a("Too many MobAudio Tags defined in Mob: " + aim.a(A_0, "uniquename", A_0.Name) + " First is used.");
      string str = aim.a(xmlElementList[0], "name", "");
      if (!string.IsNullOrEmpty(str))
        return str;
    }
    return string.Empty;
  }
}
