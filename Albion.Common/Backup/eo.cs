// Decompiled with JetBrains decompiler
// Type: eo
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Collections.Generic;
using System.Xml;

public class eo : en
{
  private static string cy = string.Empty;
  private static string cz = string.Empty;
  private static string c0 = string.Empty;

  public eo(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.bv(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.b(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.a(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.d0(eo.cy);
    // ISSUE: reference to a compiler-generated method
    this.cg(eo.cz);
    // ISSUE: reference to a compiler-generated method
    this.bv(eo.c0);
    // ISSUE: reference to a compiler-generated method
    this.d1(ahy.l(1));
    // ISSUE: reference to a compiler-generated method
    this.d0(ahy.l(1));
    // ISSUE: reference to a compiler-generated method
    this.a(ahy.l(1));
    // ISSUE: reference to a compiler-generated method
    this.cg(ahy.l(1));
    // ISSUE: reference to a compiler-generated method
    this.b(ahy.l(13));
    // ISSUE: reference to a compiler-generated method
    this.bv(ahy.l(1));
    // ISSUE: reference to a compiler-generated method
    this.b(1f);
    // ISSUE: reference to a compiler-generated method
    this.a(0.0f);
    // ISSUE: reference to a compiler-generated method
    this.d1(1000f);
    // ISSUE: reference to a compiler-generated method
    this.d0(1f);
    // ISSUE: reference to a compiler-generated method
    this.b(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.cg(1f);
    // ISSUE: reference to a compiler-generated method
    this.a(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.bv(1f);
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.c(A_0, "durabilityloss_receivedattack_mounted", this.d0()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.c(A_0, "durabilityloss_receivedspell_mounted", this.d1()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.b(A_0, "durabilityloss_mounting", this.d2()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d0(aim.a(A_0, "mountedbuff", this.d3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cg(aim.a(A_0, "dismountbuff", this.d4()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.a(A_0, "halfmountedbuff", this.d5()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "halfmountrange", this.ef()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "remountdistance", this.ek()));
    if (A_0.HasAttribute("mounttime"))
    {
      // ISSUE: reference to a compiler-generated method
      this.d1(ahy.l((double) aim.a(A_0, "mounttime", 1f)));
    }
    if (A_0.HasAttribute("dismounttime"))
    {
      // ISSUE: reference to a compiler-generated method
      this.d0(ahy.l((double) aim.a(A_0, "dismounttime", 1f)));
    }
    if (A_0.HasAttribute("remounttime"))
    {
      // ISSUE: reference to a compiler-generated method
      this.a(ahy.l((double) aim.a(A_0, "remounttime", 1f)));
    }
    if (A_0.HasAttribute("forceddismountcooldown"))
    {
      // ISSUE: reference to a compiler-generated method
      this.cg(ahy.l((double) aim.a(A_0, "forceddismountcooldown", 1f)));
    }
    if (A_0.HasAttribute("forceddismountspellcooldown"))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.b(ahy.l((double) aim.a(A_0, "forceddismountspellcooldown", (float) this.ei().t())));
    }
    if (A_0.HasAttribute("fulldismountcooldown"))
    {
      // ISSUE: reference to a compiler-generated method
      this.bv(ahy.l((double) aim.a(A_0, "fulldismountcooldown", 1f)));
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d1(aim.a(A_0, "mounthitpointsmax", this.d9()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d0(aim.a(A_0, "mounthitpointsregeneration", this.ea()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(aim.a(A_0, "prefabname", this.eb()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cg(aim.a(A_0, "prefabscaling", this.ec()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "despawneffect", this.ed()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(aim.a(A_0, "despawneffectscaling", this.ee()));
    this.a(A_0);
    return true;
  }

  protected void a(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "mountspelllist");
    if (xmlElementList == null || xmlElementList.Count == 0)
      return;
    // ISSUE: reference to a compiler-generated method
    this.a((string[]) null);
    foreach (object obj in (XmlNode) xmlElementList[0])
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        if (this.d6() == null)
        {
          // ISSUE: reference to a compiler-generated method
          this.a(new string[8]);
        }
        string str = aim.a(A_0_1, "uniquename", string.Empty);
        CharacterSpellSlot characterSpellSlot = aim.a<CharacterSpellSlot>(A_0_1, "spellslot", CharacterSpellSlot.Invalid);
        int index = (int) characterSpellSlot;
        // ISSUE: reference to a compiler-generated method
        if (index >= 0 && index < this.d6().Length && !string.IsNullOrEmpty(str))
        {
          // ISSUE: reference to a compiler-generated method
          this.d6()[index] = str;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          if (index < 0 || index >= this.d6().Length)
            ab0.a("mount " + this.d + " has invalid spellslot: " + characterSpellSlot.ToString());
          else
            ab0.a("mount " + this.d + " has no spell in spellslot set");
        }
      }
    }
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.cg(A_0.ao().h0(this.d3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.bv(A_0.ao().h0(this.d4()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b(A_0.ao().h0(this.d5()));
    // ISSUE: reference to a compiler-generated method
    if (this.el() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (es es in this.el().jt())
      {
        e7 e7 = es as e7;
        if (e7 != null)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.a(A_0.ao().h0(e7.h3()));
          break;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.d6() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(new gt[this.d6().Length]);
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.d6().Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      string A_0_1 = this.d6()[index];
      if (!string.IsNullOrEmpty(A_0_1))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.ep()[index] = A_0.ao().h0(A_0_1) as gt;
      }
    }
  }

  public float a(PlayerAttribute A_0, ab8 A_1, aie A_2, ab7 A_3, List<aba> A_4, int A_5, kx A_6, float A_7, float A_8, float A_9)
  {
    float num = 0.0f;
    float A_3_1 = this.cg(PlayerAttribute.AbilityPower, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
    // ISSUE: reference to a compiler-generated method
    if (this.eo() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.eo(), A_3_1);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.el() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.el(), A_3_1);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.d5() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.en(), A_3_1);
    }
    return num;
  }

  public float b(PlayerAttribute A_0, ab8 A_1, aie A_2, ab7 A_3, List<aba> A_4, int A_5, kx A_6, float A_7, float A_8, float A_9)
  {
    float num = 0.0f;
    float A_3_1 = this.cg(PlayerAttribute.AbilityPower, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
    // ISSUE: reference to a compiler-generated method
    if (this.d5() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.en(), A_3_1);
    }
    return num;
  }

  public float bv(PlayerAttribute A_0, ab8 A_1, aie A_2, ab7 A_3, List<aba> A_4, int A_5, kx A_6, float A_7, float A_8, float A_9)
  {
    float num = 0.0f;
    float A_3_1 = this.cg(PlayerAttribute.AbilityPower, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
    // ISSUE: reference to a compiler-generated method
    if (this.el() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.el(), A_3_1);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.d5() != null)
    {
      // ISSUE: reference to a compiler-generated method
      num += this.a(A_0, A_1, this.en(), A_3_1);
    }
    return num;
  }

  private float a(PlayerAttribute A_0, ab8 A_1, gs A_2, float A_3)
  {
    float A_1_1 = 0.0f;
    if (A_2 != null && A_2 != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (es es in A_2.jt())
      {
        ht ht = es as ht;
        // ISSUE: reference to a compiler-generated method
        if (ht != null && ht.h4() == A_0)
        {
          // ISSUE: reference to a compiler-generated method
          A_1_1 += ht.h3();
        }
      }
    }
    return p3.a(A_0, A_1_1, A_1, A_3, false);
  }
}
