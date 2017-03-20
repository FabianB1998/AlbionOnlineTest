// Decompiled with JetBrains decompiler
// Type: ab7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ab7 : ef
{
  private Dictionary<string, string> cc = new Dictionary<string, string>();
  private Dictionary<string, string> ce = new Dictionary<string, string>();
  private Dictionary<string, string> cg = new Dictionary<string, string>();
  private Dictionary<string, string> ci = new Dictionary<string, string>();
  private string cb;
  private string cd;
  private string cf;
  private string ch;

  [SpecialName]
  public float c9()
  {
    return this.c4(PlayerAttribute.CraftingFocusMax);
  }

  [SpecialName]
  public float da()
  {
    return this.c4(PlayerAttribute.CraftingFocusRegeneration);
  }

  [SpecialName]
  public float db()
  {
    return this.c4(PlayerAttribute.CraftingFocusRegenerationBonus);
  }

  public string c9(string A_0)
  {
    if (this.cc.ContainsKey(A_0))
      return this.cc[A_0];
    return this.cb;
  }

  public string da(string A_0)
  {
    if (this.ce.ContainsKey(A_0))
      return this.ce[A_0];
    return this.cd;
  }

  public string db(string A_0)
  {
    if (this.cg.ContainsKey(A_0))
      return this.cg[A_0];
    return this.cf;
  }

  public string dc(string A_0)
  {
    if (this.ci.ContainsKey(A_0))
      return this.ci[A_0];
    return this.ch;
  }

  protected override void c4()
  {
    if (this.a)
      return;
    base.c4();
    // ISSUE: reference to a compiler-generated method
    this.f0()[8] = 20000f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[9] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    this.f0()[10] = 20000f;
    // ISSUE: reference to a compiler-generated method
    this.@do(float.MinValue);
    // ISSUE: reference to a compiler-generated method
    this.dn(20000f);
    // ISSUE: reference to a compiler-generated method
    this.dm(20000f);
    // ISSUE: reference to a compiler-generated method
    this.df(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.dd(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.dc(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.db(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.de(kx.j);
    // ISSUE: reference to a compiler-generated method
    this.da(kx.h);
    // ISSUE: reference to a compiler-generated method
    this.dl(1f);
    // ISSUE: reference to a compiler-generated method
    this.c9(kx.h);
    // ISSUE: reference to a compiler-generated method
    this.c4(kx.h);
    // ISSUE: reference to a compiler-generated method
    this.dk(0.0f);
    // ISSUE: reference to a compiler-generated method
    this.dj(0.0f);
    // ISSUE: reference to a compiler-generated method
    this.di(0.0f);
    // ISSUE: reference to a compiler-generated method
    this.c4(string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.da(30);
    // ISSUE: reference to a compiler-generated method
    this.dh(2f);
    // ISSUE: reference to a compiler-generated method
    this.dg(2f);
    // ISSUE: reference to a compiler-generated method
    this.df(20f);
    // ISSUE: reference to a compiler-generated method
    this.de(1f);
    // ISSUE: reference to a compiler-generated method
    this.dd(2f);
    // ISSUE: reference to a compiler-generated method
    this.dc(2f);
    // ISSUE: reference to a compiler-generated method
    this.db(8f);
    // ISSUE: reference to a compiler-generated method
    this.da(8f);
    // ISSUE: reference to a compiler-generated method
    this.c9(8f);
    // ISSUE: reference to a compiler-generated method
    this.c4(3f);
    // ISSUE: reference to a compiler-generated method
    this.c9(9999);
    // ISSUE: reference to a compiler-generated method
    this.c4(9999);
    // ISSUE: reference to a compiler-generated method
    this.dg("T0_DEADBODY");
  }

  public bool c4(XmlElement A_0, XmlElement A_1)
  {
    if (A_1 != null && !this.c4(A_1))
      return false;
    return this.c4(A_0);
  }

  protected bool c4(XmlElement A_0)
  {
    this.c9(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[8] = aim.a(A_0, "craftingfocusmax", this.f0()[8]);
    // ISSUE: reference to a compiler-generated method
    this.f0()[9] = 0.0f;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[10] = aim.a(A_0, "craftingfocusregenerationperday", this.f0()[10]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[11] = aim.a(A_0, "craftingfocusreregenerationbonus", this.f0()[11]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.@do(aim.a(A_0, "craftingfocusatstart", this.dc()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dn(aim.a(A_0, "premiumcraftingfocusmax", this.dd()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dm(aim.a(A_0, "premiumcraftingfocusregenerationperday", this.de()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.df(aim.c(A_0, "learningpointsmax", this.df()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dd(aim.c(A_0, "learningpointsecondsperpoint", this.dh()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.c(A_0, "learningpointsmaxpremium", this.di()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.db(aim.c(A_0, "learningpointsecondsperpointpremium", this.dj()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.de(aim.c(A_0, "learningpointsatstart", this.dg()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (kx.k(this.dg(), this.df()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.de(this.df());
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.da(aim.c(A_0, "premiummarkettransactionfeefactor", this.dk()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dl(aim.a(A_0, "premiummoblootfactor", this.dl()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.c(A_0, "premiumsilverlootfactor", this.dm()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.c(A_0, "premiumdestinyboardprogressionfactor", this.dn()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dk(aim.a(A_0, "premiumgatheringyieldbonuschance", this.@do()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dj(aim.a(A_0, "premiumcropyieldfactor", this.dp()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.di(aim.a(A_0, "premiumanimalgrowthfactor", this.dq()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a(A_0, "equipmentsuffix", this.dr()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.da(aim.b(A_0, "inventorysize", this.ds()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dh(aim.a(A_0, "harvestrange", this.dt()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dg(aim.a(A_0, "useobjectrange", this.du()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.df(aim.a(A_0, "usecraftbuildingrange", this.dv()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.de(aim.a(A_0, "barehandphysicaldamage", this.dw()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dd(aim.a(A_0, "barehandrange", this.dx()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dc(aim.a(A_0, "barehandattackspeed", this.dy()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.db(aim.a(A_0, "warcamprange", this.dz()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.da(aim.a(A_0, "orbclaimrange", this.d0()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.a(A_0, "monolithrange", this.d1()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.a(A_0, "treasurechestrange", this.d2()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.f0()[53] = aim.a(A_0, "abilitypower", this.f0()[53]);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dg(aim.a(A_0, "lootprefab", this.eo()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c9(aim.b(A_0, "maxfoodslotstacksize", this.d3()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(aim.b(A_0, "maxpotionslotstacksize", this.d4()));
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("ToolsForActionAnimation");
    if (elementsByTagName != null && elementsByTagName.Count > 0)
    {
      XmlElement A_0_1 = elementsByTagName[0] as XmlElement;
      if (A_0_1 != null)
      {
        ab7.c4(A_0_1, "crafting", ref this.cb, this.cc);
        ab7.c4(A_0_1, "placing", ref this.cd, this.ce);
        ab7.c4(A_0_1, "installing", ref this.cf, this.cg);
        ab7.c4(A_0_1, "careing", ref this.ch, this.ci);
      }
    }
    return true;
  }

  protected static void c4(XmlElement A_0, string A_1, ref string A_2, Dictionary<string, string> A_3)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName(A_1);
    if (elementsByTagName == null || elementsByTagName.Count <= 0)
      return;
    XmlElement A_0_1 = elementsByTagName[0] as XmlElement;
    if (A_0_1 == null)
      return;
    A_2 = aim.a(A_0_1, "defaultmesh", string.Empty);
    foreach (object obj in (XmlNode) A_0_1)
    {
      XmlElement A_0_2 = obj as XmlElement;
      if (A_0_2 != null && A_0_2.Name == "target")
      {
        string key = aim.a(A_0_2, "id", string.Empty);
        string str = aim.a(A_0_2, "mesh", string.Empty);
        if (!string.IsNullOrEmpty(key) && !A_3.ContainsKey(key))
        {
          if (str == "none")
            str = string.Empty;
          A_3.Add(key, str);
        }
      }
    }
  }

  public override void cf(g8 A_0)
  {
    base.cf(A_0);
    // ISSUE: reference to a compiler-generated method
    this.f0()[10] /= 86400f;
    ab7 ab7 = this;
    // ISSUE: reference to a compiler-generated method
    double num = (double) ab7.de() / 86400.0;
    // ISSUE: reference to a compiler-generated method
    ab7.dm((float) num);
    // ISSUE: reference to a compiler-generated method
    if (A_0 == null && A_0.au() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.c4(A_0.au().h0(this.ej()));
  }
}
