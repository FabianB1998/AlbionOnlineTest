// Decompiled with JetBrains decompiler
// Type: bg
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bg : n
{
  public static string g = "DPS";
  public static string[] h = new string[3]{ "TANK", "HEAL", bg.g };
  protected List<bh> i;
  protected Dictionary<string, bh> j;
  protected List<bi> k;
  protected bi l;

  [SpecialName]
  public ICollection<bh> hz()
  {
    return (ICollection<bh>) this.i;
  }

  [SpecialName]
  public IList<bi> h0()
  {
    return (IList<bi>) this.k;
  }

  public bh hz(int A_0, bh.Group A_1)
  {
    foreach (bh bh in this.i)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (bh.s() == A_1 && bh.r() == A_0)
        return bh;
    }
    return (bh) null;
  }

  public bh hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.i.Count)
      return this.i[A_0];
    return (bh) null;
  }

  public bh hz(string A_0)
  {
    if (A_0 == null)
      return (bh) null;
    bh bh = (bh) null;
    this.j.TryGetValue(A_0, out bh);
    return bh;
  }

  public bi hz(IList<b9> A_0)
  {
    return bj.hz(A_0, (IList<bi>) this.k) ?? this.l;
  }

  public void hz(g8 A_0)
  {
    foreach (bh bh in this.i)
      bh.n(A_0);
    // ISSUE: reference to a compiler-generated method
    this.l = A_0.bk().hz(bg.g);
    this.k = new List<bi>(bg.h.Length);
    for (int index = 0; index < bg.h.Length; ++index)
    {
      string A_0_1 = bg.h[index];
      // ISSUE: reference to a compiler-generated method
      this.k.Add(A_0.bk().hz(A_0_1));
    }
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "expeditioncategories")
      throw new AlbionException("[ExpeditionCategoryData] LoadDataFromXml: XmlTag 'expeditioncategories' not found! Invalid Xml File?");
    bh.o();
    this.j = new Dictionary<string, bh>(A_0.ChildNodes.Count);
    this.i = new List<bh>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bh bh = new bh();
        bh.n(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.j[bh.q()] = bh;
        // ISSUE: reference to a compiler-generated method
        if (bh.p() != this.i.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[ExpeditionCategoryData] ParseData: Invalid Type enumeration: type is: " + (object) bh.p() + " but should be: " + (object) this.i.Count);
        }
        this.i.Add(bh);
      }
    }
    return true;
  }
}
