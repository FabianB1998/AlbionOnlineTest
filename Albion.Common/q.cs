// Decompiled with JetBrains decompiler
// Type: q
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

public class q : n
{
  protected List<r> d;
  protected Dictionary<string, r> e;
  protected Dictionary<string, HashSet<r>> f;
  protected Dictionary<string, bb> g;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.e.Keys;
  }

  [SpecialName]
  public ICollection<r> h0()
  {
    return (ICollection<r>) this.e.Values;
  }

  public r hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.d.Count)
      return this.d[A_0];
    return (r) null;
  }

  public r h0(string A_0)
  {
    if (A_0 == null)
      return (r) null;
    r r = (r) null;
    this.e.TryGetValue(A_0, out r);
    return r;
  }

  public bb h1(string A_0)
  {
    if (A_0 == null)
      return (bb) null;
    bb bb = (bb) null;
    this.g.TryGetValue(A_0, out bb);
    return bb;
  }

  public HashSet<r> h2(string A_0)
  {
    HashSet<r> rSet = (HashSet<r>) null;
    this.f.TryGetValue(A_0, out rSet);
    return rSet;
  }

  public List<r> h2()
  {
    List<r> rList = new List<r>();
    foreach (r r in this.d)
    {
      // ISSUE: reference to a compiler-generated method
      if (r.j().StartsWith("START"))
        rList.Add(r);
    }
    return rList;
  }

  public void hz(g8 A_0)
  {
    new Stopwatch().Start();
    foreach (r r in this.d)
      r.h(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "achievements")
      throw new AlbionException("[AchievementData] LoadDataFromXml: XmlTag 'achievements' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.a(A_0, "Version", Guid.Empty.ToString()));
    r.h();
    this.e = new Dictionary<string, r>(A_0.ChildNodes.Count);
    this.d = new List<r>(A_0.ChildNodes.Count);
    this.g = new Dictionary<string, bb>();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "templateachievement":
          case "achievement":
            this.hz(A_0_1);
            continue;
          case "template":
            this.h0(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    this.h3();
    return true;
  }

  protected void hz(XmlElement A_0)
  {
    r r = new r();
    r.h(A_0);
    // ISSUE: reference to a compiler-generated method
    this.e[r.j()] = r;
    // ISSUE: reference to a compiler-generated method
    if (r.i() != this.d.Count)
    {
      // ISSUE: reference to a compiler-generated method
      throw new AlbionException("[AchievementData] ParseDataFromXml: Invalid Type enumeration: type is: " + (object) r.i() + " but should be: " + (object) this.d.Count);
    }
    this.d.Add(r);
  }

  protected void h0(XmlElement A_0)
  {
    bb bb = new bb();
    bb.c(A_0);
    // ISSUE: reference to a compiler-generated method
    this.g[bb.c()] = bb;
  }

  public void h3()
  {
    this.f = new Dictionary<string, HashSet<r>>(this.d.Count);
    foreach (r r1 in this.d)
    {
      // ISSUE: reference to a compiler-generated method
      HashSet<string> stringSet = r1.m();
      if (stringSet != null)
      {
        foreach (string A_0 in stringSet)
        {
          r r2 = this.h0(A_0);
          if (r2 != null)
          {
            // ISSUE: reference to a compiler-generated method
            string key = r2.j();
            HashSet<r> rSet;
            if (!this.f.TryGetValue(key, out rSet))
            {
              rSet = new HashSet<r>();
              this.f.Add(key, rSet);
            }
            rSet.Add(r1);
          }
        }
      }
    }
  }
}
