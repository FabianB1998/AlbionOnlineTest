// Decompiled with JetBrains decompiler
// Type: aa7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class aa7 : n
{
  public static readonly kx by = kx.g;
  public static readonly kx bz = kx.f(9.99);
  protected Dictionary<int, bd> b0 = new Dictionary<int, bd>();
  protected Dictionary<string, bd> b1 = new Dictionary<string, bd>();
  protected Dictionary<int, du> b2 = new Dictionary<int, du>();
  protected Dictionary<string, du> b3 = new Dictionary<string, du>();
  protected Dictionary<string, List<bd>> b4 = new Dictionary<string, List<bd>>();

  [SpecialName]
  public ICollection<bd> h0()
  {
    return (ICollection<bd>) this.b0.Values;
  }

  [SpecialName]
  public ICollection<du> h2()
  {
    return (ICollection<du>) this.b2.Values;
  }

  [SpecialName]
  public ICollection<string> h3()
  {
    return (ICollection<string>) this.b3.Keys;
  }

  public bd hz(int A_0)
  {
    bd bd = (bd) null;
    this.b0.TryGetValue(A_0, out bd);
    return bd;
  }

  public bd hz(string A_0)
  {
    if (A_0 == null)
      return (bd) null;
    bd bd = (bd) null;
    this.b1.TryGetValue(A_0, out bd);
    return bd;
  }

  public du h0(int A_0)
  {
    du du = (du) null;
    this.b2.TryGetValue(A_0, out du);
    return du;
  }

  public du h0(string A_0)
  {
    if (A_0 == null)
      return (du) null;
    du du = (du) null;
    this.b3.TryGetValue(A_0, out du);
    return du;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "buildings")
      throw new AlbionException("[BuildingData] LoadDataFromXml: XmlTag 'buildings' not found! Invalid Xml File?");
    bd.ci();
    Dictionary<string, XmlElement> dictionary = new Dictionary<string, XmlElement>();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name != "buildingreference")
      {
        string index = aim.a(A_0_1, "uniquename", "");
        if (index != "")
          dictionary[index] = A_0_1;
      }
    }
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bd bd = (bd) null;
        XmlElement A_0_2 = A_0_1;
        string A_1 = "";
        if (A_0_1.Name == "buildingreference")
        {
          string key = aim.a(A_0_1, "template", "");
          if (key != "" && dictionary.ContainsKey(key))
          {
            A_0_2 = dictionary[key];
            A_1 = aim.a(A_0_1, "uniquename", "");
          }
        }
        switch (A_0_2.Name)
        {
          case "craftbuilding":
            bd = (bd) new aa8();
            break;
          case "playerbuilding":
            bd = (bd) new d0();
            break;
          case "castlegate":
            bd = (bd) new dv();
            break;
          case "bankbuilding":
            bd = (bd) new dw();
            break;
          case "marketplacebuilding":
            bd = (bd) new dz();
            break;
          case "repairbuilding":
            bd = (bd) new dy();
            break;
          case "farmbuilding":
            bd = (bd) new c0();
            break;
          case "labourer":
            bd = (bd) new global::b2();
            break;
          case "meldbuilding":
            bd = (bd) new global::b1();
            break;
          case "arenabuilding":
            bd = (bd) new global::b1();
            break;
        }
        bd.a4(A_0_2, A_1);
        // ISSUE: reference to a compiler-generated method
        this.b0[bd.c8()] = bd;
        // ISSUE: reference to a compiler-generated method
        this.b1[bd.c9()] = bd;
      }
    }
    return true;
  }

  public void hz(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (b9 b9 in (IEnumerable<b9>) A_0.an().h1())
    {
      if (b9 is ep)
      {
        dx dx = new dx((ep) b9);
        // ISSUE: reference to a compiler-generated method
        this.b0[dx.c8()] = (bd) dx;
        // ISSUE: reference to a compiler-generated method
        this.b1[dx.c9()] = (bd) dx;
      }
      else if (b9 is c7)
      {
        c1 c1 = new c1((c7) b9);
        // ISSUE: reference to a compiler-generated method
        this.b0[c1.c8()] = (bd) c1;
        // ISSUE: reference to a compiler-generated method
        this.b1[c1.c9()] = (bd) c1;
      }
    }
    foreach (bd bd in this.b1.Values)
    {
      bd.a9(A_0);
      if (bd.dx() != null)
      {
        foreach (du du in bd.dx())
        {
          // ISSUE: reference to a compiler-generated method
          this.b2.Add(du.h(), du);
          // ISSUE: reference to a compiler-generated method
          this.b3.Add(du.i(), du);
        }
      }
    }
    this.hz();
  }

  private void hz()
  {
    SortedDictionary<string, bd> sortedDictionary = new SortedDictionary<string, bd>();
    foreach (bd bd in this.b0.Values)
    {
      // ISSUE: reference to a compiler-generated method
      sortedDictionary.Add(bd.c9(), bd);
    }
    foreach (bd bd in sortedDictionary.Values)
    {
      string key = "todo";
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(bd.dd()))
      {
        // ISSUE: reference to a compiler-generated method
        key = bd.dd();
      }
      if (!this.b4.ContainsKey(key))
      {
        // ISSUE: reference to a compiler-generated method
        this.b4[bd.dd()] = new List<bd>();
      }
      List<bd> bdList = this.b4[key];
      int num = bdList.BinarySearch(bd, (IComparer<bd>) new aa7.a());
      int index = num >= 0 ? num + 1 : ~num;
      if (index > bdList.Count)
        index = bdList.Count;
      bdList.Insert(index, bd);
    }
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<string>((IEnumerable<string>) this.b1.Keys));
    // ISSUE: reference to a compiler-generated method
    this.h1().Sort();
  }

  public Dictionary<string, List<bd>> h4()
  {
    return this.b4;
  }

  public List<bd> h1(string A_0)
  {
    if (!this.b4.ContainsKey(A_0))
      return (List<bd>) null;
    return this.b4[A_0];
  }

  private class a : IComparer<bd>
  {
    public int Compare(bd a, bd b)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return a.de().CompareTo(b.de());
    }
  }
}
