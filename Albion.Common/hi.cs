// Decompiled with JetBrains decompiler
// Type: hi
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class hi : n
{
  private HashSet<string> bf = new HashSet<string>();
  private Dictionary<string, hh> bg = new Dictionary<string, hh>();
  private Dictionary<int, hh> bh = new Dictionary<int, hh>();
  private Dictionary<string, hj> bi = new Dictionary<string, hj>();
  private Dictionary<int, hj> bj = new Dictionary<int, hj>();
  private Dictionary<string, List<hh>> bk = new Dictionary<string, List<hh>>();
  private Dictionary<string, List<b9>> bl = new Dictionary<string, List<b9>>();

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.bi.Keys;
  }

  [SpecialName]
  public ICollection<string> h0()
  {
    return (ICollection<string>) this.bg.Keys;
  }

  [SpecialName]
  public HashSet<string> h1()
  {
    return this.bf;
  }

  [SpecialName]
  public Dictionary<string, hh> h2()
  {
    return this.bg;
  }

  [SpecialName]
  public Dictionary<int, hh> h3()
  {
    return this.bh;
  }

  [SpecialName]
  public Dictionary<string, hj> h4()
  {
    return this.bi;
  }

  [SpecialName]
  public Dictionary<int, hj> h5()
  {
    return this.bj;
  }

  public hh h0(string A_0)
  {
    if (A_0 == null)
      return (hh) null;
    hh hh;
    if (this.bg.TryGetValue(A_0, out hh))
      return hh;
    return (hh) null;
  }

  public hh hz(int A_0)
  {
    hh hh;
    if (this.bh.TryGetValue(A_0, out hh))
      return hh;
    return (hh) null;
  }

  public hj h1(string A_0)
  {
    if (A_0 == null)
      return (hj) null;
    hj hj;
    if (this.bi.TryGetValue(A_0, out hj))
      return hj;
    return (hj) null;
  }

  public hj h0(int A_0)
  {
    hj hj;
    if (this.bj.TryGetValue(A_0, out hj))
      return hj;
    return (hj) null;
  }

  public List<hh> h2(string A_0)
  {
    List<hh> hhList = (List<hh>) null;
    this.bk.TryGetValue(A_0, out hhList);
    return hhList;
  }

  public List<b9> h3(string A_0)
  {
    List<b9> b9List = (List<b9>) null;
    this.bl.TryGetValue(A_0, out b9List);
    return b9List;
  }

  public List<string> h7()
  {
    return new List<string>((IEnumerable<string>) this.h0()).FindAll((Predicate<string>) (A_0 =>
    {
      if (!A_0.Contains("SILVERCOINS"))
        return !A_0.Contains("ESSENCE");
      return false;
    }));
  }

  public b9 hz(string A_0, int A_1)
  {
    hj hj = this.h1(A_0);
    if (hj != null)
    {
      // ISSUE: reference to a compiler-generated method
      List<b9> b9List = this.h3(hj.d());
      if (b9List != null)
      {
        foreach (b9 b9 in b9List)
        {
          if (b9.q == A_0 && b9.f == A_1)
            return b9;
        }
      }
    }
    return (b9) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "AO-Resources")
      throw new AlbionException("[ResourceData] LoadDataFromXml: XmlTag AO-Resources not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Harvestables":
            this.h0(A_0_1);
            continue;
          case "Resources":
            this.hz(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<string>((IEnumerable<string>) this.bi.Keys));
    // ISSUE: reference to a compiler-generated method
    this.h6().Sort();
    return true;
  }

  private void h0(XmlElement A_0)
  {
    hh.e();
    this.bf.Clear();
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Harvestable"))
    {
      string A_0_2 = aim.a(A_0_1, "name", "");
      if (string.IsNullOrEmpty(A_0_2))
        throw new AlbionException("[GameData] couldn't parse Harvestable element " + A_0_1.Name);
      string A_1 = aim.a(A_0_1, "resource", "");
      if (string.IsNullOrEmpty(A_0_2))
        throw new AlbionException("[GameData] couldn't parse Harvestable element " + A_0_1.Name);
      hh hh = new hh(A_0_2, A_1);
      hh.e(A_0_1);
      this.bg[A_0_2] = hh;
      // ISSUE: reference to a compiler-generated method
      this.bh[hh.h()] = hh;
      if (!A_0_2.Contains("SILVERCOINS") && !A_0_2.Contains("ESSENCE"))
        this.bf.Add(A_0_2);
      this.bf.Add("MOBCAMP");
    }
  }

  private void hz(XmlElement A_0)
  {
    hj.c();
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("Resource"))
    {
      hj hj = new hj();
      hj.c(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.bi[hj.d()] = hj;
      // ISSUE: reference to a compiler-generated method
      this.bj[hj.e()] = hj;
    }
  }

  public void h0(g8 A_0)
  {
    this.bk.Clear();
    foreach (hh hh in this.bg.Values)
    {
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(hh.g()))
      {
        // ISSUE: reference to a compiler-generated method
        string key = hh.g();
        if (!this.bk.ContainsKey(key))
          this.bk.Add(key, new List<hh>());
        this.bk[key].Add(hh);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (hh.i() != null && hh.i().Length > 0)
        {
          List<b9> b9List1 = new List<b9>();
          // ISSUE: reference to a compiler-generated method
          foreach (hh.b b in hh.i())
          {
            // ISSUE: reference to a compiler-generated method
            if (b != null && !string.IsNullOrEmpty(b.af()))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              b8 b8 = A_0.an().hz(b.af());
              if (b8 != null)
              {
                // ISSUE: reference to a compiler-generated method
                b9List1.Add(b8.f());
              }
            }
          }
          if (b9List1.Count > 0)
          {
            List<b9> b9List2;
            if (this.bl.TryGetValue(key, out b9List2))
              b9List2.AddRange((IEnumerable<b9>) b9List1);
            else
              this.bl.Add(key, b9List1);
          }
        }
      }
    }
    this.hz(A_0);
  }

  private void hz(g8 A_0)
  {
    Dictionary<int, Dictionary<int, List<int>>> dictionary1 = new Dictionary<int, Dictionary<int, List<int>>>();
    // ISSUE: reference to a compiler-generated method
    foreach (KeyValuePair<string, eg> keyValuePair in A_0.@as().hz())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (keyValuePair.Value.ef() != null && keyValuePair.Value.ef().o() != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        foreach (d5 d5 in keyValuePair.Value.ef().o())
        {
          if (d5 is d6)
          {
            // ISSUE: reference to a compiler-generated method
            hh hh = this.h0(((d6) d5).n());
            Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
            // ISSUE: reference to a compiler-generated method
            if (dictionary1.TryGetValue(hh.h(), out dictionary2))
            {
              List<int> intList = new List<int>();
              // ISSUE: reference to a compiler-generated method
              if (dictionary2.TryGetValue(((d6) d5).o(), out intList))
              {
                // ISSUE: reference to a compiler-generated method
                intList.Add(keyValuePair.Value.ek());
              }
              else
              {
                intList = new List<int>();
                // ISSUE: reference to a compiler-generated method
                intList.Add(keyValuePair.Value.ek());
                // ISSUE: reference to a compiler-generated method
                dictionary2.Add(((d6) d5).o(), intList);
              }
            }
            else
            {
              dictionary2 = new Dictionary<int, List<int>>();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              dictionary2.Add(((d6) d5).o(), new List<int>()
              {
                keyValuePair.Value.ek()
              });
              // ISSUE: reference to a compiler-generated method
              dictionary1.Add(hh.h(), dictionary2);
            }
          }
        }
      }
    }
    foreach (KeyValuePair<int, Dictionary<int, List<int>>> keyValuePair1 in dictionary1)
    {
      foreach (KeyValuePair<int, List<int>> keyValuePair2 in keyValuePair1.Value)
      {
        if (keyValuePair2.Value.Count == 1)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          this.hz(keyValuePair1.Key).i()[keyValuePair2.Key - 1].ag(keyValuePair2.Value[0]);
        }
      }
    }
  }
}
