// Decompiled with JetBrains decompiler
// Type: eg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class eg : ef
{
  private List<eg.b> a2 = new List<eg.b>();
  private List<eg.b> a3 = new List<eg.b>();
  public const string a1 = "@MOB_";

  [SpecialName]
  public List<eg.b> eg()
  {
    return this.a2;
  }

  [SpecialName]
  public List<eg.b> eh()
  {
    return this.a3;
  }

  [SpecialName]
  public bool ei()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.fh() > 0.0 && this.db() != AttackType.None)
      return true;
    if (this.eg() != null)
      return this.eg().Count > 0;
    return false;
  }

  public bool c4(XmlElement A_0)
  {
    this.c9(A_0);
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.em()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.df("@MOB_" + this.ej());
    }
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.b(A_0, "tier", 0));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.b(A_0, "fame", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.dh(aim.a(A_0, "roamingradius", 10f));
    // ISSUE: reference to a compiler-generated method
    this.dg(aim.a(A_0, "roamingidletimemin", 1f));
    // ISSUE: reference to a compiler-generated method
    this.df(aim.a(A_0, "roamingidletimemax", 3f));
    // ISSUE: reference to a compiler-generated method
    this.dj(aim.a(A_0, "aggroradius", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.c9(ahy.l((double) aim.a(A_0, "aggrodelayafterspawn", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.di(aim.a(A_0, "pursuitradius", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.de(aim.a(A_0, "damageaggrofactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.dd(aim.a(A_0, "healingaggrofactor", 0.5f));
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.a(A_0, "groupdamageaggrofactor", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.db(aim.a(A_0, "alertradius", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.h(A_0, "faction").ToLower());
    // ISSUE: reference to a compiler-generated method
    this.db(aim.h(A_0, "category").ToLower());
    string str = aim.a(A_0, "alertsfactions", "all");
    string[] strArray = str.Split(new char[2]{ ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int index = 0; index < strArray.Length; ++index)
      strArray[index] = strArray[index].ToLower();
    // ISSUE: reference to a compiler-generated method
    this.dd(str.Contains("all"));
    // ISSUE: reference to a compiler-generated method
    this.c4(new HashSet<string>((IEnumerable<string>) strArray));
    // ISSUE: reference to a compiler-generated method
    this.db(true);
    // ISSUE: reference to a compiler-generated method
    this.da(aim.a(A_0, "isabletoexecute", true));
    // ISSUE: reference to a compiler-generated method
    this.da(aim.a(A_0, "minthreatfactorforchangetotargetinattackrange", 1.1f));
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.a(A_0, "minthreatfactorforchangetotargetoutsideattackrange", 1.3f));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a<AttackType>(A_0, "attacktype", AttackType.None));
    // ISSUE: reference to a compiler-generated method
    this.dk(aim.a(A_0, "attackmovespeed", 5f));
    // ISSUE: reference to a compiler-generated method
    this.de(aim.a(A_0, "immunetoforcedmovement", false));
    // ISSUE: reference to a compiler-generated method
    this.db(ahy.l((double) aim.a(A_0, "respawntimesecondsmin", 1f)));
    // ISSUE: reference to a compiler-generated method
    this.da(ahy.l((double) aim.a(A_0, "respawntimesecondsmax", 2f)));
    // ISSUE: reference to a compiler-generated method
    this.da(aim.a(A_0, "avatar", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.a(A_0, "avatarring", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a<eg.MobDangerState>(A_0, "dangerstate", eg.MobDangerState.Normal));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a<eg.MobAlignments>(A_0, "npchostility", eg.MobAlignments.Hostile));
    // ISSUE: reference to a compiler-generated method
    this.db(aim.b(A_0, "maxcharges", 1));
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.b(A_0, "startcharges", 1));
    // ISSUE: reference to a compiler-generated method
    this.da(aim.b(A_0, "chargesperchargeup", 1));
    // ISSUE: reference to a compiler-generated method
    this.c4(ahy.l((double) aim.a(A_0, "timeperchargeseconds", 3600f)));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.b(A_0, "focusfireattackersthreshold", -1));
    // ISSUE: reference to a compiler-generated method
    this.df(aim.a(A_0, "fixedrotation", false));
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Spells"))
      eg.c4(A_0_1, this.a2);
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("DeathSpells"))
      eg.c4(A_0_1, this.a3);
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Loot"))
    {
      // ISSUE: reference to a compiler-generated method
      this.c4(aim.a(A_0_1, "itemdropquality", 1f));
      if (A_0_1.ChildNodes.Count != 0)
      {
        // ISSUE: reference to a compiler-generated method
        this.c4(new ec());
        // ISSUE: reference to a compiler-generated method
        this.ef().cb(A_0_1);
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ef() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.c4(this.ef().p<d7>() != null);
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(new List<string>());
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("meleehitvfx");
    if (elementsByTagName != null && elementsByTagName.Count > 0)
    {
      foreach (XmlNode xmlNode in elementsByTagName)
      {
        // ISSUE: reference to a compiler-generated method
        this.ed().Add(aim.a(xmlNode as XmlElement, "prefab", "Prefabs/Vfx/MeleeHit/MeleeHit"));
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(@if.i(A_0));
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a(A_0, "lootprefab", "T0_LOOTBAG_PREMIUM"));
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.a(A_0, "onlysimpleroaming", false));
    if ((double) this.fh() > 0.0 || this.eg() != null && this.eg().Count > 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.c9(false);
    }
    return true;
  }

  protected static void c4(XmlElement A_0, List<eg.b> A_1)
  {
    A_1.Clear();
    foreach (XmlElement xmlElement in A_0.GetElementsByTagName("spell"))
    {
      string A_0_1 = aim.h(xmlElement, "name");
      float A_0_2 = aim.a(xmlElement, "groundtargetoffset", 0.0f);
      string A_0_3 = aim.a(xmlElement, "saytext", (string) null);
      eg.b.Target A_0_4 = aim.a<eg.b.Target>(xmlElement, "target", eg.b.Target.Current);
      eg.b b1 = new eg.b();
      // ISSUE: reference to a compiler-generated method
      b1.g(A_0_1);
      // ISSUE: reference to a compiler-generated method
      b1.g(A_0_4);
      // ISSUE: reference to a compiler-generated method
      b1.g(A_0_2);
      // ISSUE: reference to a compiler-generated method
      b1.h(A_0_3);
      // ISSUE: reference to a compiler-generated method
      b1.g(new List<eg.a>());
      eg.b b2 = b1;
      // ISSUE: reference to a compiler-generated method
      eg.c4(b2.l(), xmlElement);
      A_1.Add(b2);
    }
  }

  protected static void c4(List<eg.a> A_0, XmlElement A_1)
  {
    foreach (XmlNode childNode in A_1.ChildNodes)
    {
      XmlElement xmlElement = childNode as XmlElement;
      if (xmlElement != null)
      {
        if (xmlElement.Name == "condition")
        {
          eg.a a1 = new eg.a();
          // ISSUE: reference to a compiler-generated method
          a1.e(aim.a<eg.a.Type>(xmlElement, "type", eg.a.Type.Chance));
          // ISSUE: reference to a compiler-generated method
          a1.e(aim.a(xmlElement, "value", 0.0f));
          // ISSUE: reference to a compiler-generated method
          a1.e(aim.a(xmlElement, "value", ""));
          eg.a a2 = a1;
          A_0.Add(a2);
        }
        else if (xmlElement.Name == "and")
        {
          eg.a a1 = new eg.a();
          // ISSUE: reference to a compiler-generated method
          a1.e(eg.a.Type.And);
          // ISSUE: reference to a compiler-generated method
          a1.e(new List<eg.a>());
          eg.a a2 = a1;
          // ISSUE: reference to a compiler-generated method
          eg.c4(a2.h(), xmlElement);
          A_0.Add(a2);
        }
        else if (xmlElement.Name == "or")
        {
          eg.a a1 = new eg.a();
          // ISSUE: reference to a compiler-generated method
          a1.e(eg.a.Type.Or);
          // ISSUE: reference to a compiler-generated method
          a1.e(new List<eg.a>());
          eg.a a2 = a1;
          // ISSUE: reference to a compiler-generated method
          eg.c4(a2.h(), xmlElement);
          A_0.Add(a2);
        }
        else if (xmlElement.Name == "not")
        {
          eg.a a1 = new eg.a();
          // ISSUE: reference to a compiler-generated method
          a1.e(eg.a.Type.Not);
          // ISSUE: reference to a compiler-generated method
          a1.e(new List<eg.a>());
          eg.a a2 = a1;
          // ISSUE: reference to a compiler-generated method
          eg.c4(a2.h(), xmlElement);
          A_0.Add(a2);
        }
      }
    }
  }

  public override void cf(g8 A_0)
  {
    base.cf(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.ec() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (@if @if in this.ec())
        @if.i(A_0);
    }
    // ISSUE: reference to a compiler-generated method
    this.c4(new List<hh.b>());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ef() != null && this.ef().o() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (d5 d5 in this.ef().o())
      {
        if (d5 is d6)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          hh hh = A_0.aw().h0(((d6) d5).n());
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (hh != null && !hh.i()[((d6) d5).o() - 1].ag())
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.d7().Add(hh.i()[((d6) d5).o() - 1]);
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dc((double) this.dp() > 0.0 && (this.ds() || this.dw().Count > 0));
    // ISSUE: reference to a compiler-generated method
    if (this.d8() >= 0)
      return;
    int A_0_1 = 0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.ar().jg().TryGetValue(this.dz(), out A_0_1))
    {
      // ISSUE: reference to a compiler-generated method
      this.c4(A_0_1);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.c4(0);
    }
  }

  public class a
  {
    public enum Type
    {
      And,
      Or,
      Not,
      Chance,
      FightDuration,
      OwnHealthBelow,
      OwnHealthAbove,
      OwnHealthBelowPercentage,
      OwnHealthAbovePercentage,
      OwnEnergyBelow,
      OwnEnergyAbove,
      OwnEnergyAbovePercentage,
      OwnEnergyBelowPercentage,
      TargetHealthBelow,
      TargetHealthAbove,
      TargetHealthAbovePercentage,
      TargetHealthBelowPercentage,
      TargetEnergyBelow,
      TargetEnergyAbove,
      TargetEnergyAbovePercentage,
      TargetEnergyBelowPercentage,
      TargetRangeAbove,
      TargetRangeBelow,
      TargetSpellActive,
      TargetSpellCategoryActive,
      TargetWeaponEquipped,
      TargetWeaponTypeEquipped,
      SelfSpellActive,
      SelfSpellCategoryActive,
      TargetTookDamage,
      IsTargetTopOfThreatList,
      TotalNumberOfTargetsOnThreatListGreaterThan,
      TotalNumberOfTargetsOnThreatListLessThanOrEqualTo,
      IsSummonedMobCountGreaterThan,
      IsAnyEnemyInRange,
      IsAnyFactionMemberInRange,
      IsTargetCasting,
    }
  }

  public class b
  {
    [SpecialName]
    public string j()
    {
      // ISSUE: reference to a compiler-generated method
      return kr.b(this.k());
    }

    public enum Target
    {
      Self,
      Current,
      AnyEnemy,
      AnyFriend,
    }
  }

  public class c
  {
    private string a;
    private hk b;
    private string c;

    public void a(XmlNode A_0)
    {
      this.a = aim.a(A_0 as XmlElement, "prefab", "MeleeHit/MeleeHit");
      this.c = aim.a(A_0 as XmlElement, "impactsocket", "");
      this.b = hk.a(A_0 as XmlElement, hk.c());
    }
  }

  public enum MobDangerState
  {
    Normal,
    Veteran,
    Elite,
  }

  public enum MobAlignments
  {
    Hostile,
    Guard,
    PvpRuleDepended,
  }
}
