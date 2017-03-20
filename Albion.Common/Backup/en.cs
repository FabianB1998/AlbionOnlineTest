// Decompiled with JetBrains decompiler
// Type: en
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

public class en : global::ca, c4
{
  private static List<gs>[] bo = new List<gs>[0];
  private static List<aba>[] bp = new List<aba>[0];
  private static List<string>[] bq = new List<string>[0];
  private static string[] bn = Enum.GetNames(typeof (ItemPowerProgressionType));
  protected string bl;
  private List<string>[] bm;

  public EquipmentSlot bl { get; private set; }

  public ItemPowerProgressionType bm { get; private set; }

  public bool bn { get; private set; }

  public bool bo { get; private set; }

  public bool bp { get; private set; }

  public string bq { get; private set; }

  public string br { get; private set; }

  public bool bs { get; private set; }

  public int bt { get; private set; }

  public int bu { get; private set; }

  public string b3 { get; private set; }

  public string b4 { get; private set; }

  public string b5 { get; private set; }

  public acf b6 { get; private set; }

  public List<@if> b7 { get; private set; }

  public List<string> b8 { get; private set; }

  public AttackType b9 { get; private set; }

  public float ca { get; private set; }

  public List<gs>[] cb { get; private set; }

  public List<aba>[] cc { get; private set; }

  public Dictionary<string, string> cd { get; private set; }

  public int ce { get; private set; }

  public List<string> cf { get; private set; }

  public kx ch { get; private set; }

  public kx ci { get; private set; }

  public kx cj { get; private set; }

  public kx ck { get; private set; }

  public int cl { get; private set; }

  public float cm { get; private set; }

  public float cn { get; private set; }

  public float co { get; private set; }

  public Dictionary<string, d1> cp { get; private set; }

  public string cq { get; private set; }

  public string cr { get; private set; }

  public ic cs { get; private set; }

  public string ct { get; private set; }

  public float cu
  {
    get
    {
      return this.a(PlayerAttribute.AbilityPower);
    }
  }

  public float cv
  {
    get
    {
      return this.a(PlayerAttribute.ItemPower);
    }
  }

  public string cw
  {
    get
    {
      if (string.IsNullOrEmpty(this.bl))
        return this.j;
      return this.bl;
    }
  }

  public virtual bool cx
  {
    get
    {
      return true;
    }
  }

  protected float[] cy { get; private set; }

  protected HashSet<string> cz { get; private set; }

  static en()
  {
    for (int index = 0; index < en.bn.Length; ++index)
      en.bn[index] = en.bn[index].ToLower();
  }

  public en(global::b8 A_0)
    : base(A_0)
  {
    this.bl = EquipmentSlot.Armor;
    this.bm = ItemPowerProgressionType.None;
    this.bn = false;
    this.b9 = AttackType.None;
    this.ca = 0.0f;
    this.bs = false;
    this.ce = 1;
    this.ch = kx.j;
    this.ci = kx.j;
    this.cj = kx.j;
    this.ck = kx.j;
    this.bl = string.Empty;
    this.bo = false;
    this.bp = false;
    this.b3 = string.Empty;
    this.b4 = string.Empty;
    this.b5 = "RightArm_3";
    this.b6 = acf.e();
    this.cz = (HashSet<string>) null;
    this.bt = 0;
    this.bu = 0;
    this.bq = string.Empty;
    this.br = string.Empty;
    this.cy = new float[57];
    this.cy[53] = 100f;
    this.cy[55] = 100f;
    this.cl = 0;
    this.cm = 0.0f;
    this.cn = 0.0f;
    this.co = 1f;
    this.cq = string.Empty;
    this.cr = string.Empty;
    this.ct = string.Empty;
    this.b7 = (List<@if>) null;
    this.b8 = (List<string>) null;
    this.cb = en.bo;
    this.cc = en.bp;
    this.bm = en.bq;
  }

  public float a(PlayerAttribute A_0)
  {
    return this.cy[(int) A_0];
  }

  public override global::b9 cg()
  {
    en en = base.cg() as en;
    en.cy = en.cy.Clone() as float[];
    return (global::b9) en;
  }

  public bool fo()
  {
    if (this.cz != null)
      return this.cz.Count > 0;
    return false;
  }

  public bool d4(string A_0)
  {
    if (this.cz == null)
      return false;
    return this.cz.Contains(A_0);
  }

  public bool fp()
  {
    return this.ce > 1;
  }

  public bool d0(int A_0)
  {
    return this.ce >= A_0;
  }

  public int d1(int A_0)
  {
    if (this.d0(A_0))
      return A_0;
    for (int A_0_1 = A_0 - 1; A_0_1 > 1; --A_0_1)
    {
      if (this.d0(A_0_1))
        return A_0_1;
    }
    return 1;
  }

  protected override bool ch(XmlElement A_0)
  {
    if (!base.ch(A_0))
      return false;
    this.bl = aim.a<EquipmentSlot>(A_0, "slottype", this.bl);
    try
    {
      string lowerInvariant = aim.a(A_0, "itempowerprogressiontype", this.bl.ToString()).ToLowerInvariant();
      this.bm = Array.IndexOf<string>(en.bn, lowerInvariant) < 0 ? ItemPowerProgressionType.None : (ItemPowerProgressionType) Enum.Parse(typeof (ItemPowerProgressionType), lowerInvariant, true);
    }
    catch (Exception ex)
    {
      this.bm = ItemPowerProgressionType.None;
    }
    return true;
  }

  public override bool bc(XmlElement A_0)
  {
    if (!base.bc(A_0))
      return false;
    this.bn = aim.a(A_0, "twohanded", this.bn);
    this.b9 = aim.a<AttackType>(A_0, "attacktype", this.b9);
    this.ca = aim.a(A_0, "attackbuildingdamage", this.ca);
    this.bs = (double) this.ca > 0.0;
    this.ce = aim.b(A_0, "maxqualitylevel", this.ce);
    this.ch = aim.c(A_0, "durabilityloss_attack", this.ch);
    this.ci = aim.c(A_0, "durabilityloss_spelluse", this.ci);
    this.cj = aim.c(A_0, "durabilityloss_receivedattack", this.cj);
    this.ck = aim.c(A_0, "durabilityloss_receivedspell", this.ck);
    this.bl = aim.a(A_0, "mesh", this.bl);
    this.bo = aim.a(A_0, "unlockedtoequip", this.bo);
    this.bp = aim.a(A_0, "unequipincombat", this.bp);
    this.b3 = aim.a(A_0, "mainhandanimationtype", this.b3);
    this.b3 = this.b3.ToLowerInvariant();
    if (this.b3 == "none")
      this.b3 = string.Empty;
    this.b4 = aim.a(A_0, "offhandanimationtype", this.b4);
    this.b4 = this.b4.ToLowerInvariant();
    if (this.b4 == "none")
      this.b4 = string.Empty;
    this.b5 = aim.a(A_0, "fxbonename", this.b5);
    this.b6 = aim.a(A_0, "fxboneoffset", this.b6);
    List<XmlElement> xmlElementList1 = aim.d(A_0, "canharvest");
    if (xmlElementList1 != null && xmlElementList1.Count > 0)
    {
      this.cz = new HashSet<string>();
      foreach (XmlNode xmlNode in xmlElementList1)
      {
        XmlElement A_0_1 = xmlNode as XmlElement;
        if (A_0_1 != null)
          this.cz.Add(aim.a(A_0_1, "resourcetype", ""));
      }
    }
    this.bt = aim.b(A_0, "activespellslots", this.bt);
    this.bu = aim.b(A_0, "passivespellslots", this.bu);
    this.bq = aim.a(A_0, "facestate", this.bq);
    this.br = aim.a(A_0, "beardstate", this.br);
    this.cl = aim.b(A_0, "requiredaccesslevel", this.cl);
    this.cy[0] = aim.a(A_0, "hitpointsmax", this.cy[0]);
    this.cy[1] = aim.a(A_0, "hitpointsmaxbonus", this.cy[1]);
    this.cy[2] = aim.a(A_0, "hitpointsregeneration", this.cy[2]);
    this.cy[3] = aim.a(A_0, "hitpointsregenerationbonus", this.cy[3]);
    this.cy[4] = aim.a(A_0, "energymax", this.cy[4]);
    this.cy[5] = aim.a(A_0, "energymaxbonus", this.cy[5]);
    this.cy[6] = aim.a(A_0, "energyregeneration", this.cy[6]);
    this.cy[7] = aim.a(A_0, "energyregenerationbonus", this.cy[7]);
    this.cy[12] = aim.a(A_0, "movespeed", this.cy[12]);
    this.cy[13] = aim.a(A_0, "movespeedbonus", this.cy[13]);
    this.cy[14] = aim.a(A_0, "maxload", this.cy[14]);
    this.cy[15] = aim.a(A_0, "maxloadbonus", this.cy[15]);
    this.cy[16] = aim.a(A_0, "attackdamage", this.cy[16]);
    this.cy[17] = aim.a(A_0, "physicalattackdamagebonus", this.cy[17]);
    this.cy[18] = aim.a(A_0, "magicattackdamagebonus", this.cy[18]);
    this.cy[19] = aim.a(A_0, "attackrangebonus", this.cy[19]);
    this.cy[20] = aim.a(A_0, "attackspeedbonus", this.cy[20]);
    this.cy[21] = aim.a(A_0, "physicalspelldamagebonus", this.cy[21]);
    this.cy[22] = aim.a(A_0, "magicspelldamagebonus", this.cy[22]);
    this.cy[28] = aim.a(A_0, "healbonus", this.cy[28]);
    this.cy[29] = aim.a(A_0, "healmodifier", this.cy[29]);
    this.cy[30] = aim.a(A_0, "energycostreduction", this.cy[30]);
    this.cy[23] = aim.a(A_0, "magiccasttimereduction", this.cy[23]);
    this.cy[24] = (float) (1.0 / (1.0 - (double) this.cy[23]) - 1.0);
    this.cy[25] = aim.a(A_0, "magiccooldownreduction", this.cy[25]);
    this.cy[26] = (float) (1.0 / (1.0 - (double) this.cy[25]) - 1.0);
    this.cy[27] = aim.a(A_0, "magiccastingresilience", this.cy[27]);
    this.cy[31] = aim.a(A_0, "physicalarmor", this.cy[31]);
    this.cy[32] = aim.a(A_0, "magicresistance", this.cy[32]);
    this.cy[33] = aim.a(A_0, "crowdcontrolresistance", this.cy[33]);
    this.cy[37] = aim.a(A_0, "focusfireprotectionpeneration", this.cy[37]);
    this.cy[41] = aim.a(A_0, "gatheringyield", this.cy[41]);
    this.cy[53] = aim.a(A_0, "abilitypower", this.cy[53]);
    this.cy[54] = aim.a(A_0, "abilitypowerbonus", this.cy[54]);
    this.cy[55] = aim.a(A_0, "itempower", this.cy[55]);
    this.cy[56] = aim.a(A_0, "threatbonus", this.cy[56]);
    this.cy[45] = aim.a(A_0, "bonusccdurationvsplayers", this.cy[45]);
    this.cy[49] = aim.a(A_0, "bonusccdurationvsmobs", this.cy[49]);
    this.cy[44] = aim.a(A_0, "bonusccrvsplayers", this.cy[44]);
    this.cy[48] = aim.a(A_0, "bonusccrvsmobs", this.cy[48]);
    this.cy[42] = aim.a(A_0, "bonusdamagevsplayers", this.cy[42]);
    this.cy[46] = aim.a(A_0, "bonusdamagevsmobs", this.cy[46]);
    this.cy[43] = aim.a(A_0, "bonusdefensevsplayers", this.cy[43]);
    this.cy[47] = aim.a(A_0, "bonusdefensevsmobs", this.cy[47]);
    this.cm = aim.a(A_0, "attackrange", this.cm);
    this.cn = aim.a(A_0, "attackspeed", this.cn);
    this.co = aim.a(A_0, "attackdamagetimefactor", this.co);
    string str1 = id.p(A_0);
    if (!string.IsNullOrEmpty(str1))
      this.cq = str1;
    string str2 = d1.a(A_0);
    if (!string.IsNullOrEmpty(str2))
      this.cr = str2;
    string str3 = ic.c(A_0);
    if (!string.IsNullOrEmpty(str3))
      this.ct = str3;
    List<@if> ifList = @if.i(A_0);
    if (ifList != null && ifList.Count > 0)
      this.b7 = ifList;
    List<string> stringList = (List<string>) null;
    List<XmlElement> xmlElementList2 = aim.d(A_0, "meleehitvfx");
    if (xmlElementList2 != null && xmlElementList2.Count > 0)
    {
      stringList = new List<string>();
      foreach (XmlNode xmlNode in xmlElementList2)
        stringList.Add(aim.a(xmlNode as XmlElement, "prefab", "Prefabs/Vfx/MeleeHit/MeleeHit"));
    }
    if (stringList != null)
      this.b8 = stringList;
    this.a(A_0);
    return true;
  }

  private void a(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "craftingspelllist");
    if (xmlElementList == null || xmlElementList.Count <= 0)
      return;
    this.bm = new List<string>[Math.Max(this.bt, this.bu)];
    for (int index = 0; index < this.bm.Length; ++index)
      this.bm[index] = new List<string>();
    foreach (XmlNode childNode in xmlElementList[0].ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        string key = aim.h(A_0_1, "uniquename");
        string str1 = aim.h(A_0_1, "tag");
        if (!string.IsNullOrEmpty(str1))
        {
          if (this.cd == null)
            this.cd = new Dictionary<string, string>();
          if (!this.cd.ContainsKey(key))
            this.cd.Add(key, str1);
        }
        string str2 = aim.a(A_0_1, "slots", "all");
        if (str2 == "all" && this.bm.Length > 0)
        {
          for (int index = 0; index < this.bm.Length; ++index)
            this.bm[index].Add(key);
        }
        else
        {
          string str3 = str2;
          char[] separator = new char[1]{ ',' };
          int num = 1;
          foreach (string s in str3.Split(separator, (StringSplitOptions) num))
          {
            int result;
            if (int.TryParse(s, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result) && result > 0 && result <= this.bm.Length)
            {
              this.bm[result - 1].Add(key);
            }
            else
            {
              if (this.cf == null)
                this.cf = new List<string>();
              this.cf.Add(key);
            }
          }
        }
      }
    }
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    ic ic = new ic();
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.ct) && A_0.bb().br.ContainsKey(this.ct))
    {
      // ISSUE: reference to a compiler-generated method
      ic = A_0.bb().br[this.ct];
    }
    this.cs = ic;
    Dictionary<string, d1> dictionary = new Dictionary<string, d1>();
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cr) && A_0.ba().ab.ContainsKey(this.cr))
    {
      // ISSUE: reference to a compiler-generated method
      dictionary = A_0.ba().ab[this.cr];
    }
    this.cp = dictionary;
    if (this.b7 != null)
    {
      foreach (@if @if in this.b7)
        @if.i(A_0);
    }
    if (this.bl == EquipmentSlot.MainHand)
    {
      if (this.fo())
      {
        en en = this;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        kx A_0_1 = kx.o(en.fr(), A_0.ar().jc().i(this.f));
        // ISSUE: reference to a compiler-generated method
        en.d0(A_0_1);
      }
      else
      {
        en en = this;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        kx A_0_1 = kx.o(en.fr(), A_0.ar().jc().j(this.f));
        // ISSUE: reference to a compiler-generated method
        en.d0(A_0_1);
      }
    }
    else if (this.bl == EquipmentSlot.Mount)
    {
      en en = this;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      kx A_0_1 = kx.o(en.fr(), A_0.ar().jc().l(this.f));
      // ISSUE: reference to a compiler-generated method
      en.d0(A_0_1);
    }
    else
    {
      en en = this;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      kx A_0_1 = kx.o(en.fr(), A_0.ar().jc().k(this.f));
      // ISSUE: reference to a compiler-generated method
      en.d0(A_0_1);
    }
    this.a(A_0);
    if (this.cz != null)
    {
      foreach (string A_0_1 in this.cz)
      {
        // ISSUE: reference to a compiler-generated method
        A_0.aw().h1(A_0_1);
      }
    }
    if (this.bt > 0)
    {
      this.cb = new List<gs>[this.bt];
      for (int index = 0; index < this.bt; ++index)
        this.cb[index] = new List<gs>();
    }
    else
      this.cb = en.bo;
    if (this.bu > 0)
    {
      this.cc = new List<aba>[this.bu];
      for (int index = 0; index < this.bu; ++index)
        this.cc[index] = new List<aba>();
    }
    else
      this.cc = en.bp;
    for (int index = 0; index < Math.Max(this.bt, this.bu); ++index)
    {
      if (index < this.bm.Length)
      {
        foreach (string A_0_1 in this.bm[index])
        {
          // ISSUE: reference to a compiler-generated method
          gr gr = A_0.ao().hz(A_0_1);
          if (gr != null)
          {
            if (gr is gs)
            {
              if (index < this.bt)
                this.cb[index].Add((gs) gr);
            }
            else if (index < this.bu)
              this.cc[index].Add((aba) gr);
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (!g8.am())
      this.bm = (List<string>[]) null;
    this.cf = (List<string>) null;
  }

  public List<string>[] fq()
  {
    return this.bm;
  }

  public float a(ab8 A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    float num1 = (float) (A_1.m() / this.fr().m()) * 100f;
    float num2 = 0.0f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    foreach (im.a a in A_0.jc().n())
    {
      // ISSUE: reference to a compiler-generated method
      if ((double) num1 >= (double) a.g())
      {
        // ISSUE: reference to a compiler-generated method
        num2 = a.l();
      }
      else
        break;
    }
    return num2;
  }

  public float cg(PlayerAttribute A_0, ab8 A_1, aie A_2, ab7 A_3, List<aba> A_4, int A_5, kx A_6, float A_7, float A_8, float A_9)
  {
    float A_1_1 = 0.0f + this.a(A_0);
    float A_4_1 = this.cv + A_7 - this.a(A_1, A_6) + A_1.ig(A_5);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_2 != null && (double) A_2.an().bf() > 0.0 && ((double) A_4_1 > (double) A_2.an().bf() && this.bl != EquipmentSlot.Mount) && (this.bl != EquipmentSlot.Bag && A_0 != PlayerAttribute.MaxLoad && A_0 != PlayerAttribute.MaxLoadBonus))
    {
      // ISSUE: reference to a compiler-generated method
      float num1 = A_2.an().bg();
      // ISSUE: reference to a compiler-generated method
      float num2 = A_2.an().bf();
      A_4_1 = num2 + (float) ((double) num1 * 100.0 * (1.0 - Math.Pow((double) num1, ((double) A_4_1 - (double) num2) / 100.0)) / (1.0 - (double) num1));
    }
    float num = p3.a(A_0, A_1_1, A_1, A_3, A_4_1, this.bm);
    if (A_4 != null && A_4.Count > 0)
    {
      if (A_0 == PlayerAttribute.MaxLoad || A_0 == PlayerAttribute.MaxLoadBonus)
      {
        float A_3_1 = this.cg(PlayerAttribute.AbilityPower, A_1, (aie) null, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
        num += this.a(A_0, A_1, A_4, A_3_1);
      }
      else if (A_0 == PlayerAttribute.AbilityPower)
      {
        num += this.a(A_0, A_1, A_4, this.cu);
      }
      else
      {
        float A_3_1 = this.cg(PlayerAttribute.AbilityPower, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
        num += this.a(A_0, A_1, A_4, A_3_1);
      }
    }
    return num;
  }

  public float a(PlayerAttribute A_0, ab8 A_1, List<aba> A_2, float A_3)
  {
    float A_1_1 = 0.0f;
    if (A_2 != null)
    {
      foreach (aba aba in A_2)
      {
        if (aba != null)
        {
          // ISSUE: reference to a compiler-generated method
          foreach (es es in aba.jt())
          {
            // ISSUE: reference to a compiler-generated method
            if (es is abb && ((abb) es).h4() == A_0)
            {
              // ISSUE: reference to a compiler-generated method
              A_1_1 += ((abb) es).h3();
            }
          }
        }
      }
    }
    return p3.a(A_0, A_1_1, A_1, A_3, false);
  }
}
