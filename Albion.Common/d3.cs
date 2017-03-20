// Decompiled with JetBrains decompiler
// Type: d3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class d3 : c2
{
  private Dictionary<string, ab7> aj = new Dictionary<string, ab7>();
  private Dictionary<int, ab7> ak = new Dictionary<int, ab7>();
  private List<d3.a> al = new List<d3.a>();
  private Dictionary<string, d4> am = new Dictionary<string, d4>();
  private HashSet<d3.b> an = new HashSet<d3.b>();
  private Dictionary<string, d2> ao = new Dictionary<string, d2>();

  [SpecialName]
  public ICollection<string> h0()
  {
    return (ICollection<string>) this.aj.Keys;
  }

  [SpecialName]
  public ICollection<ab7> h1()
  {
    return (ICollection<ab7>) this.aj.Values;
  }

  [SpecialName]
  public ICollection<d3.a> h2()
  {
    return (ICollection<d3.a>) this.al;
  }

  [SpecialName]
  public ICollection<d4> h3()
  {
    return (ICollection<d4>) this.am.Values;
  }

  public ab7 hz(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (ab7) null;
    ab7 ab7;
    if (this.aj.TryGetValue(A_0, out ab7))
      return ab7;
    return (ab7) null;
  }

  public ab7 hz(int A_0)
  {
    ab7 ab7;
    if (this.ak.TryGetValue(A_0, out ab7))
      return ab7;
    return (ab7) null;
  }

  public d4 h0(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (d4) null;
    d4 d4;
    if (this.am.TryGetValue(A_0, out d4))
      return d4;
    return (d4) null;
  }

  public d2 h1(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (d2) null;
    d2 d2;
    if (this.ao.TryGetValue(A_0, out d2))
      return d2;
    return (d2) null;
  }

  public d3.a h0(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.al.Count)
      return this.al[A_0];
    return (d3.a) null;
  }

  public d3.a h2(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (d3.a) null;
    foreach (d3.a a in this.al)
    {
      if (A_0 == a.c || A_0 == a.d)
        return a;
    }
    return (d3.a) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "CharacterData")
      throw new AlbionException("[CharacterData] LoadDataFromXml: XmlTag 'characterdata' not found! Invalid Xml File?");
    ef.c9();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "Characters":
            this.h0(A_0_1);
            continue;
          case "Customizations":
            this.h1(A_0_1);
            continue;
          case "Races":
            this.h2(A_0_1);
            continue;
          case "AvatarToCustomizationPresets":
            this.hz(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public void h0(g8 A_0)
  {
    foreach (ef ef in this.ak.Values)
      ef.cf(A_0);
    this.hz(A_0);
  }

  private void h2(XmlElement A_0)
  {
    this.al.Capacity = A_0.ChildNodes.Count;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Race")
      {
        string str = aim.a(A_0_1, "namelocatag", (string) null);
        if (!string.IsNullOrEmpty(str))
        {
          d3.a A_1 = new d3.a();
          A_1.a = str;
          A_1.b = aim.a(A_0_1, "avatar", string.Empty);
          this.hz(A_0_1, A_1);
          this.al.Add(A_1);
        }
      }
    }
  }

  private void hz(XmlElement A_0, d3.a A_1)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        if (A_0_1.Name == "Male")
          A_1.c = aim.a(A_0_1, "uniquename", (string) null);
        else if (A_0_1.Name == "Female")
          A_1.d = aim.a(A_0_1, "uniquename", (string) null);
      }
    }
  }

  private void h1(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Customization")
      {
        d4 d4 = new d4();
        if (!d4.e(A_0_1))
          throw new AlbionException("[CharacterData] couldn't parse customization element " + A_0_1.Name);
        // ISSUE: reference to a compiler-generated method
        this.am[d4.c()] = d4;
      }
    }
  }

  private void h0(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(ahy.l((double) aim.a(A_0, "globalcastdelay", 0.0f)));
    XmlElement A_1 = (XmlElement) null;
    IEnumerator enumerator = A_0.GetElementsByTagName("DefaultValues").GetEnumerator();
    try
    {
      if (enumerator.MoveNext())
        A_1 = (XmlElement) enumerator.Current;
    }
    finally
    {
      IDisposable disposable = enumerator as IDisposable;
      if (disposable != null)
        disposable.Dispose();
    }
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Character")
      {
        ab7 ab7 = new ab7();
        if (!ab7.c4(A_0_1, A_1))
          throw new AlbionException("[CharacterData] couldn't parse character element " + A_0_1.Name);
        // ISSUE: reference to a compiler-generated method
        this.aj[ab7.ej()] = ab7;
        // ISSUE: reference to a compiler-generated method
        c2.v[ab7.ej()] = (ef) ab7;
        // ISSUE: reference to a compiler-generated method
        this.ak[ab7.ek()] = ab7;
        // ISSUE: reference to a compiler-generated method
        c2.w[ab7.ek()] = (ef) ab7;
      }
    }
  }

  private void hz(XmlElement A_0)
  {
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode1 as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Preset")
      {
        string str1 = aim.a(A_0_1, "avatar", string.Empty);
        if (!string.IsNullOrEmpty(str1))
        {
          string str2 = aim.a(A_0_1, "charactertype", string.Empty);
          if (!string.IsNullOrEmpty(str2))
          {
            d3.b b = new d3.b();
            b.b = str1;
            b.a = str2;
            foreach (object childNode2 in A_0_1.ChildNodes)
            {
              XmlElement A_0_2 = childNode2 as XmlElement;
              if (A_0_2 != null && A_0_2.Name == "CustomizationItem")
              {
                string key = aim.a(A_0_2, "item", string.Empty);
                if (!string.IsNullOrEmpty(key))
                  b.c.Add(key, new d2.ItemSetting()
                  {
                    MeshId = aim.a(A_0_2, "mesh", string.Empty),
                    Color = aim.b(A_0_2, "color", -1)
                  });
              }
            }
            this.an.Add(b);
          }
        }
      }
    }
  }

  private void hz(g8 A_0)
  {
    foreach (d3.b b in this.an)
    {
      ab7 A_0_1 = this.hz(b.a);
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        ds A_0_2 = A_0.az().hz(b.b);
        if (A_0_2 != null)
        {
          // ISSUE: reference to a compiler-generated method
          dt A_1 = A_0.az().h0(0);
          d2 d2 = new d2(A_0_1);
          d2.g(A_0_2, A_1);
          foreach (KeyValuePair<string, d2.ItemSetting> keyValuePair in b.c)
          {
            string key = keyValuePair.Key;
            d2.ItemSetting itemSetting = keyValuePair.Value;
            if (itemSetting.Color >= 0)
              d2.g(key, itemSetting.Color);
            if (!string.IsNullOrEmpty(itemSetting.MeshId))
              d2.h(key, itemSetting.MeshId);
          }
          string key1 = d2.n();
          if (!this.ao.ContainsKey(key1))
            this.ao.Add(key1, d2);
        }
      }
    }
  }

  public class a
  {
    public string a;
    public string b;
    public string c;
    public string d;

    [SpecialName]
    public string f()
    {
      return kr.b(this.a);
    }
  }

  private class b
  {
    public Dictionary<string, d2.ItemSetting> c = new Dictionary<string, d2.ItemSetting>();
    public string a;
    public string b;
  }
}
