// Decompiled with JetBrains decompiler
// Type: bl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bl : global::n
{
  public static string k = "EXPEDITION_PENALTY";
  protected List<bk> l;
  protected Dictionary<string, bk> m;
  protected Dictionary<string, List<bk>> n;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.m.Keys;
  }

  [SpecialName]
  public ICollection<bk> h0()
  {
    return (ICollection<bk>) this.m.Values;
  }

  public bk hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.l.Count)
      return this.l[A_0];
    return (bk) null;
  }

  public bk hz(string A_0)
  {
    if (A_0 == null)
      return (bk) null;
    bk bk = (bk) null;
    this.m.TryGetValue(A_0, out bk);
    return bk;
  }

  public List<bk> h0(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (List<bk>) null;
    List<bk> bkList = (List<bk>) null;
    this.n.TryGetValue(A_0, out bkList);
    return bkList;
  }

  public void hz(g8 A_0)
  {
    foreach (bk bk in this.l)
      bk.n(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "expeditions")
      throw new AlbionException("[ExpeditionInfo] LoadDataFromXml: XmlTag 'expeditions' not found! Invalid Xml File?");
    bk.n();
    this.m = new Dictionary<string, bk>(A_0.ChildNodes.Count);
    this.l = new List<bk>(A_0.ChildNodes.Count);
    this.n = new Dictionary<string, List<bk>>();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bk bk = new bk();
        bk.n(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.m[bk.p()] = bk;
        // ISSUE: reference to a compiler-generated method
        if (bk.o() != this.l.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[ExpeditionInfo] ParseExpedition: Invalid Type enumeration: type is: " + (object) bk.o() + " but should be: " + (object) this.l.Count);
        }
        this.l.Add(bk);
        List<bk> bkList = (List<bk>) null;
        // ISSUE: reference to a compiler-generated method
        this.n.TryGetValue(bk.s(), out bkList);
        if (bkList == null)
        {
          bkList = new List<bk>();
          // ISSUE: reference to a compiler-generated method
          this.n.Add(bk.s(), bkList);
        }
        bkList.Add(bk);
      }
    }
    return true;
  }
}
