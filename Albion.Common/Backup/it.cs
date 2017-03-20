// Decompiled with JetBrains decompiler
// Type: it
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class it
{
  public ab8.c a = ab8.fh;
  private string b;
  public static readonly it c;

  static it()
  {
    it it = new it();
    // ISSUE: reference to a compiler-generated method
    it.y("DEFAULT");
    // ISSUE: reference to a compiler-generated method
    it.x(it.PvpRules.PvpAllowed);
    // ISSUE: reference to a compiler-generated method
    it.ad(true);
    // ISSUE: reference to a compiler-generated method
    it.ac(false);
    // ISSUE: reference to a compiler-generated method
    it.ab(true);
    // ISSUE: reference to a compiler-generated method
    it.z(false);
    // ISSUE: reference to a compiler-generated method
    it.y(false);
    // ISSUE: reference to a compiler-generated method
    it.x(false);
    // ISSUE: reference to a compiler-generated method
    it.y(ahy.l(0));
    // ISSUE: reference to a compiler-generated method
    it.y(0.0f);
    // ISSUE: reference to a compiler-generated method
    it.y(kx.h);
    // ISSUE: reference to a compiler-generated method
    it.x(kx.h);
    // ISSUE: reference to a compiler-generated method
    it.x(float.MinValue);
    it.c = it;
  }

  public bool ae(bool A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (!A_0 || this.y() != it.PvpRules.PvpAllowed)
    {
      // ISSUE: reference to a compiler-generated method
      return this.y() == it.PvpRules.PvpForced;
    }
    return true;
  }

  public bool x(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.y(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.a<it.PvpRules>(A_0, "pvprule", it.PvpRules.PvpAllowed));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.a(A_0, "playersarelethal", true));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.a(A_0, "mobsarelethal", false));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.a(A_0, "gvgallowed", true));
    // ISSUE: reference to a compiler-generated method
    this.aa(aim.a(A_0, "allowtrade", true));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.a<it.UiPvpTypes>(A_0, "uipvptype", it.UiPvpTypes.Safe));
    // ISSUE: reference to a compiler-generated method
    this.z(aim.a(A_0, "showpvpplayeronminimap", false));
    // ISSUE: reference to a compiler-generated method
    this.y(aim.a(A_0, "showfriendlycount", false));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.a(A_0, "showhostilecount", false));
    // ISSUE: reference to a compiler-generated method
    this.y(ahy.l(aim.b(A_0, "logoutseconds", 0)));
    // ISSUE: reference to a compiler-generated method
    this.x(ahy.l(aim.b(A_0, "spellcooldownsonenteringseconds", 0)));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.a<it.PvpWarningLevel>(A_0, "pvpwarningtype", it.PvpWarningLevel.safe));
    // ISSUE: reference to a compiler-generated method
    this.y(aim.a(A_0, "craftefficiencybonus", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.y(aim.c(A_0, "buildingcraftcapacityregenfactor", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.c(A_0, "durabilitydecaydivider", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.a(A_0, "itempowersoftcap", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.a(A_0, "itempowerscalingfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.aa(aim.a(A_0, "animalgrowthfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.z(aim.a(A_0, "cropyieldfactor", 1f));
    // ISSUE: reference to a compiler-generated method
    this.x(aim.h(A_0, "knockdownbuffaftergetup"));
    this.b = aim.a(A_0, "clusterdangerbonustype", string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.x(aim.a(A_0, "requiredreputationtoenter", float.MinValue));
    return true;
  }

  public void x(g8 A_0)
  {
    if (string.IsNullOrEmpty(this.b))
      return;
    ab8.c c = (ab8.c) null;
    // ISSUE: reference to a compiler-generated method
    A_0.ar().fi.TryGetValue(this.b, out c);
    if (c == null)
      return;
    this.a = c;
  }

  public enum PvpRules
  {
    PvpDisabled,
    PvpAllowed,
    PvpForced,
  }

  public enum PvpWarningLevel
  {
    safe,
    yellow,
    red,
    black,
  }

  public enum UiPvpTypes
  {
    Safe,
    Limited,
    Full,
    Black,
  }
}
