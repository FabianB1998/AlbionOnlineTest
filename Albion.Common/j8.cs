// Decompiled with JetBrains decompiler
// Type: j8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class j8 : n
{
  private Dictionary<string, j7> bs = new Dictionary<string, j7>();
  private Dictionary<string, it> bt = new Dictionary<string, it>();
  public Dictionary<string, j6> bu = new Dictionary<string, j6>();
  public Dictionary<string, j5> bv = new Dictionary<string, j5>();
  public Dictionary<string, j4> bw = new Dictionary<string, j4>();
  public readonly j9 bx = new j9();
  private List<j3> by = new List<j3>();

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.bs.Keys;
  }

  [SpecialName]
  public ICollection<string> h0()
  {
    return (ICollection<string>) this.bt.Keys;
  }

  public List<j3> hz(string A_0, j7 A_1)
  {
    List<j3> j3List = new List<j3>();
    ka.ClusterNameInformation A_1_1;
    if (A_1 == null || !ka.b(A_0, out A_1_1))
      return j3List;
    foreach (j3 j3 in this.by)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (j3.h() == A_1_1.Tier && (string.Equals(j3.g(), A_1_1.Faction.ToString(), StringComparison.OrdinalIgnoreCase) || string.Equals(j3.g(), "ANY", StringComparison.OrdinalIgnoreCase)))
        j3List.Add(j3);
    }
    return j3List;
  }

  public j7 hz(string A_0)
  {
    j7 j7 = (j7) null;
    this.bs.TryGetValue(A_0, out j7);
    return j7;
  }

  public it h0(string A_0)
  {
    it it = (it) null;
    this.bt.TryGetValue(A_0, out it);
    return it;
  }

  public j4 h1(string A_0)
  {
    j4 j4 = (j4) null;
    this.bw.TryGetValue(A_0, out j4);
    return j4;
  }

  public j6 h2(string A_0)
  {
    j6 j6 = (j6) null;
    this.bu.TryGetValue(A_0, out j6);
    return j6;
  }

  public j5 h3(string A_0)
  {
    j5 j5 = (j5) null;
    this.bv.TryGetValue(A_0, out j5);
    return j5;
  }

  public Dictionary<string, j5>.ValueCollection h1()
  {
    return this.bv.Values;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "AO-WorldSettings")
      return false;
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "hellgatemobtypes":
            this.h0(A_0_1);
            continue;
          case "archetypes":
            this.hz(A_0_1);
            continue;
          case "clustertypes":
            this.h1(A_0_1);
            continue;
          case "islands":
            this.h2(A_0_1);
            continue;
          case "hellclusters":
            this.h3(A_0_1);
            continue;
          case "timeregions":
            this.h4(A_0_1);
            continue;
          case "worldmap":
            this.bx.i(A_0_1);
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  public void hz(g8 A_0)
  {
    foreach (j7 j7 in this.bs.Values)
      j7.ao(A_0);
    foreach (it it in this.bt.Values)
      it.x(A_0);
  }

  private void h4(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("timeregion"))
    {
      j4 j4 = new j4();
      j4.d(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.bw.Add(j4.d(), j4);
    }
  }

  private void h3(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("hellcluster"))
    {
      j5 j5 = new j5();
      j5.ad(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.bv.Add(j5.ad(), j5);
    }
  }

  private void h2(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("island"))
    {
      j6 j6 = new j6();
      j6.c(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.bu.Add(j6.c(), j6);
    }
  }

  private void h1(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "clustertype")
      {
        j7 j7 = new j7();
        j7.ap(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.bs.Add(j7.a0(), j7);
      }
    }
  }

  private void h0(XmlElement A_0)
  {
    foreach (XmlNode childNode1 in A_0.ChildNodes)
    {
      XmlElement xmlElement = childNode1 as XmlElement;
      if (xmlElement != null && xmlElement.Name == "hellgatemobs")
      {
        foreach (XmlNode childNode2 in xmlElement.ChildNodes)
        {
          XmlElement A_0_1 = childNode2 as XmlElement;
          if (A_0_1 != null && A_0_1.Name == "hellgatemob")
          {
            j3 j3 = new j3();
            j3.e(A_0_1);
            this.by.Add(j3);
          }
        }
      }
    }
  }

  private void hz(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "archetype")
      {
        it it = new it();
        it.x(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.bt.Add(it.x(), it);
      }
    }
  }
}
