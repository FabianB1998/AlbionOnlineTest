// Decompiled with JetBrains decompiler
// Type: ha
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Xml;

public class ha : n
{
  protected Dictionary<int, hb> a2 = new Dictionary<int, hb>();
  protected Dictionary<string, hb> a3 = new Dictionary<string, hb>();
  protected Dictionary<int, hc> a4 = new Dictionary<int, hc>();
  protected Dictionary<string, hc> a5 = new Dictionary<string, hc>();
  protected List<int> a6 = new List<int>();
  private List<hc> a7 = new List<hc>();
  private List<hc> a8 = new List<hc>();

  [SpecialName]
  public ICollection<hb> hz()
  {
    return (ICollection<hb>) this.a2.Values;
  }

  [SpecialName]
  public ICollection<string> h0()
  {
    return (ICollection<string>) this.a3.Keys;
  }

  [SpecialName]
  public ICollection<hc> h1()
  {
    return (ICollection<hc>) this.a4.Values;
  }

  [SpecialName]
  public ICollection<string> h2()
  {
    return (ICollection<string>) this.a5.Keys;
  }

  [SpecialName]
  public ReadOnlyCollection<int> h3()
  {
    return this.a6.AsReadOnly();
  }

  public hb h2(int A_0)
  {
    hb hb = (hb) null;
    this.a2.TryGetValue(A_0, out hb);
    return hb;
  }

  public hb hz(string A_0)
  {
    if (A_0 == null)
      return (hb) null;
    hb hb = (hb) null;
    this.a3.TryGetValue(A_0, out hb);
    return hb;
  }

  public List<hc> ib()
  {
    return this.a7;
  }

  public List<hc> hz(List<string> A_0)
  {
    List<hc> hcList = new List<hc>();
    if (A_0 != null && A_0.Count > 0)
    {
      foreach (hc hc in this.a8)
      {
        // ISSUE: reference to a compiler-generated method
        if (A_0.Contains(hc.g()))
          hcList.Add(hc);
      }
    }
    return hcList;
  }

  public hc h3(int A_0)
  {
    hc hc = (hc) null;
    this.a4.TryGetValue(A_0, out hc);
    return hc;
  }

  public hc h0(string A_0)
  {
    if (A_0 == null)
      return (hc) null;
    hc hc = (hc) null;
    this.a5.TryGetValue(A_0, out hc);
    return hc;
  }

  public int ic()
  {
    if (this.h3().Count > 0)
    {
      using (IEnumerator<int> enumerator = this.h3().GetEnumerator())
      {
        if (enumerator.MoveNext())
          return enumerator.Current;
      }
    }
    return 0;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "GuildLogoData")
      throw new AlbionException("[GuildLogoData] LoadDataFromXml: XmlTag 'guildlogodata' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Symbols":
            this.h1(A_0_1);
            continue;
          case "SymbolColors":
            this.h0(A_0_1);
            continue;
          case "Schemas":
            this.hz(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private void h1(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h2(aim.a(A_0, "minscale", 1f));
    // ISSUE: reference to a compiler-generated method
    this.h1(aim.a(A_0, "maxscale", 1f));
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.a(A_0, "minoffsety", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.a(A_0, "maxoffsety", 0.0f));
    this.a5.Clear();
    this.a4.Clear();
    hc.e();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Symbol")
      {
        hc hc = new hc();
        if (!hc.e(A_0_1))
          throw new AlbionException("[GuildLogoData] couldn't parse symbol element " + A_0_1.Name);
        // ISSUE: reference to a compiler-generated method
        this.a5[hc.g()] = hc;
        // ISSUE: reference to a compiler-generated method
        this.a4[hc.f()] = hc;
      }
    }
    this.a7.Clear();
    this.a8.Clear();
    foreach (hc hc in this.a4.Values)
    {
      // ISSUE: reference to a compiler-generated method
      if (hc.i())
        this.a8.Add(hc);
      else
        this.a7.Add(hc);
    }
    this.a8.TrimExcess();
    this.a7.TrimExcess();
  }

  private void h0(XmlElement A_0)
  {
    this.a6.Clear();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "SymbolColor")
        this.a6.Add(ha.hz((byte) aim.b(A_0_1, "r", 1), (byte) aim.b(A_0_1, "g", 1), (byte) aim.b(A_0_1, "b", 1)));
    }
    this.a6.TrimExcess();
  }

  private void hz(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h1(aim.b(A_0, "quadrants", -1));
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.b(A_0, "colors", -1));
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.b(A_0, "defaultcolor", -1));
    this.a3.Clear();
    this.a2.Clear();
    hb.e();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Schema")
      {
        // ISSUE: reference to a compiler-generated method
        hb hb = new hb(this.h4());
        if (!hb.e(A_0_1))
          throw new AlbionException("[GuildLogoData] couldn't parse schema element " + A_0_1.Name);
        // ISSUE: reference to a compiler-generated method
        this.a3[hb.f()] = hb;
        // ISSUE: reference to a compiler-generated method
        this.a2[hb.g()] = hb;
      }
    }
  }

  public static int hz(byte A_0, byte A_1, byte A_2)
  {
    return ((int) A_0 << 16) + ((int) A_1 << 8) + (int) A_2;
  }

  public static void hz(int A_0, out byte A_1, out byte A_2, out byte A_3)
  {
    A_1 = (byte) ((A_0 & 16711680) >> 16);
    A_2 = (byte) ((A_0 & 65280) >> 8);
    A_3 = (byte) (A_0 & (int) byte.MaxValue);
  }
}
