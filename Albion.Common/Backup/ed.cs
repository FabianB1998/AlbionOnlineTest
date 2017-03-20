// Decompiled with JetBrains decompiler
// Type: ed
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ed : c2
{
  private Dictionary<string, eg> ao = new Dictionary<string, eg>();
  private Dictionary<int, eg> ap = new Dictionary<int, eg>();

  [SpecialName]
  public Dictionary<string, eg> hz()
  {
    return this.ao;
  }

  [SpecialName]
  public Dictionary<int, eg> h0()
  {
    return this.ap;
  }

  [SpecialName]
  public ICollection<string> h1()
  {
    return (ICollection<string>) this.ao.Keys;
  }

  public eg hz(string A_0)
  {
    eg eg;
    if (this.ao.TryGetValue(A_0, out eg))
      return eg;
    return (eg) null;
  }

  public eg hz(int A_0)
  {
    eg eg;
    if (this.ap.TryGetValue(A_0, out eg))
      return eg;
    return (eg) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "Mobs")
      throw new AlbionException("[MobData] LoadDataFromXml: XmlTag 'mobdata' not found! Invalid Xml File?");
    return this.hz(A_0);
  }

  private bool hz(XmlElement A_0)
  {
    return this.hz(A_0, false);
  }

  protected override bool bu(XmlElement A_0)
  {
    return this.hz(A_0, true);
  }

  protected bool hz(XmlElement A_0, bool A_1)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        eg eg;
        if (A_1 && this.ao.TryGetValue(aim.h(A_0_1, "uniquename"), out eg))
        {
          eg.c4(A_0_1);
        }
        else
        {
          eg = new eg();
          if (!eg.c4(A_0_1))
            throw new AlbionException("[GameData] couldn't parse mob element " + A_0_1.Name);
          // ISSUE: reference to a compiler-generated method
          this.ao[eg.ej()] = eg;
          // ISSUE: reference to a compiler-generated method
          this.ap[eg.ek()] = eg;
        }
        ef ef;
        if (A_1 && c2.v.TryGetValue(aim.h(A_0_1, "uniquename"), out ef))
        {
          ef = (ef) eg;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          c2.v[eg.ej()] = (ef) eg;
          // ISSUE: reference to a compiler-generated method
          c2.w[eg.ek()] = (ef) eg;
        }
      }
    }
    return true;
  }

  public void hz(g8 A_0)
  {
    HashSet<string> stringSet = new HashSet<string>();
    foreach (eg eg in this.ao.Values)
    {
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(eg.dq()))
      {
        // ISSUE: reference to a compiler-generated method
        stringSet.Add(eg.dq());
      }
    }
    List<string> stringList = new List<string>();
    foreach (eg eg in this.ao.Values)
    {
      stringList.Clear();
      // ISSUE: reference to a compiler-generated method
      foreach (string str in eg.dw())
      {
        if (!stringSet.Contains(str))
          stringList.Add(str);
      }
      foreach (string str in stringList)
      {
        // ISSUE: reference to a compiler-generated method
        eg.dw().Remove(str);
      }
    }
    foreach (ef ef in this.ao.Values)
      ef.cf(A_0);
  }

  public enum GuardType
  {
    BASIC,
    ELITE,
    LORD,
  }
}
