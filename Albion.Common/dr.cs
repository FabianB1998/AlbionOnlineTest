// Decompiled with JetBrains decompiler
// Type: dr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class dr : n
{
  protected ds[] af;
  protected Dictionary<string, ds> ag;
  protected dt[] ah;
  protected Dictionary<string, dt> ai;
  protected List<ds> aj;
  protected List<dt> ak;
  protected Dictionary<string, List<ds>> al;
  protected Dictionary<string, List<dt>> am;
  protected List<ds> an;

  [SpecialName]
  public ICollection<string> h1()
  {
    return (ICollection<string>) this.ag.Keys;
  }

  [SpecialName]
  public ICollection<string> h2()
  {
    return (ICollection<string>) this.ai.Keys;
  }

  [SpecialName]
  public ICollection<ds> h3()
  {
    return (ICollection<ds>) this.af;
  }

  [SpecialName]
  public ICollection<dt> h4()
  {
    return (ICollection<dt>) this.ah;
  }

  public ds hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.af.Length)
      return this.af[A_0];
    return (ds) null;
  }

  public ds hz(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (ds) null;
    ds ds;
    if (this.ag.TryGetValue(A_0, out ds))
      return ds;
    return (ds) null;
  }

  public ds h5()
  {
    foreach (ds ds in this.af)
    {
      // ISSUE: reference to a compiler-generated method
      if (!ds.k())
        return ds;
    }
    return (ds) null;
  }

  public dt h0(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.ah.Length)
      return this.ah[A_0];
    return (dt) null;
  }

  public dt h0(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (dt) null;
    dt dt;
    if (this.ai.TryGetValue(A_0, out dt))
      return dt;
    return (dt) null;
  }

  public dt h6()
  {
    foreach (dt dt in this.ah)
    {
      // ISSUE: reference to a compiler-generated method
      if (!dt.j())
        return dt;
    }
    return (dt) null;
  }

  public List<ds> h7()
  {
    return this.aj;
  }

  public List<dt> h8()
  {
    return this.ak;
  }

  public List<ds> h1(string A_0)
  {
    List<ds> dsList = (List<ds>) null;
    this.al.TryGetValue(A_0, out dsList);
    return dsList;
  }

  public List<dt> h2(string A_0)
  {
    List<dt> dtList = (List<dt>) null;
    this.am.TryGetValue(A_0, out dtList);
    return dtList;
  }

  public List<ds> h9()
  {
    return this.an;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "avatars")
      throw new AlbionException("[AvatarData] LoadDataFromXml: XmlTag 'avatars' not found! Invalid Xml File?");
    ds.g();
    dt.f();
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      if (childNode1.Name == "avatars")
      {
        this.ag = new Dictionary<string, ds>(childNode1.ChildNodes.Count);
        foreach (XmlNode childNode2 in childNode1.ChildNodes)
        {
          XmlElement A_0_1 = childNode2 as XmlElement;
          if (A_0_1 != null && A_0_1.Name == "avatar")
          {
            ds ds = new ds();
            ds.g(A_0_1);
            // ISSUE: reference to a compiler-generated method
            this.ag.Add(ds.i(), ds);
          }
        }
      }
      else if (childNode1.Name == "avatarrings")
      {
        this.ai = new Dictionary<string, dt>(childNode1.ChildNodes.Count);
        foreach (XmlNode childNode2 in childNode1.ChildNodes)
        {
          XmlElement A_0_1 = childNode2 as XmlElement;
          if (A_0_1 != null && A_0_1.Name == "avatarring")
          {
            dt dt = new dt();
            dt.f(A_0_1);
            // ISSUE: reference to a compiler-generated method
            this.ai.Add(dt.h(), dt);
          }
        }
      }
    }
    this.h0();
    this.hz();
    return true;
  }

  private void h0()
  {
    if (this.ag != null)
    {
      this.af = new ds[this.ag.Count];
      foreach (ds ds in this.ag.Values)
      {
        // ISSUE: reference to a compiler-generated method
        this.af[ds.h()] = ds;
      }
      foreach (ds ds in this.af)
        ;
    }
    if (this.ai == null)
      return;
    this.ah = new dt[this.ai.Count];
    foreach (dt dt in this.ai.Values)
    {
      // ISSUE: reference to a compiler-generated method
      this.ah[dt.g()] = dt;
    }
    foreach (dt dt in this.ah)
      ;
  }

  private void hz()
  {
    this.aj = new List<ds>();
    this.al = new Dictionary<string, List<ds>>();
    this.an = new List<ds>();
    foreach (ds ds in this.af)
    {
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(ds.l()))
      {
        List<ds> dsList = (List<ds>) null;
        // ISSUE: reference to a compiler-generated method
        this.al.TryGetValue(ds.l(), out dsList);
        if (dsList == null)
        {
          dsList = new List<ds>();
          // ISSUE: reference to a compiler-generated method
          this.al.Add(ds.l(), dsList);
        }
        dsList.Add(ds);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        if (ds.m())
          this.an.Add(ds);
        else
          this.aj.Add(ds);
      }
    }
    this.ak = new List<dt>();
    this.am = new Dictionary<string, List<dt>>();
    foreach (dt dt in this.ah)
    {
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(dt.k()))
      {
        List<dt> dtList = (List<dt>) null;
        // ISSUE: reference to a compiler-generated method
        this.am.TryGetValue(dt.k(), out dtList);
        if (dtList == null)
        {
          dtList = new List<dt>();
          // ISSUE: reference to a compiler-generated method
          this.am.Add(dt.k(), dtList);
        }
        dtList.Add(dt);
      }
      else
        this.ak.Add(dt);
    }
  }

  public static string hz(XmlElement A_0)
  {
    string str = aim.a(A_0, "founderneeded", string.Empty);
    if (!string.IsNullOrEmpty(str))
    {
      switch (str)
      {
        case "none":
          return string.Empty;
        case "veteran":
          return el.a;
        case "epic":
          return el.b;
        case "legendary":
          return el.c;
      }
    }
    return string.Empty;
  }
}
