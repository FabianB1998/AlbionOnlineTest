// Decompiled with JetBrains decompiler
// Type: bn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bn : global::n
{
  protected List<bm> m;
  protected Dictionary<string, bm> n;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.n.Keys;
  }

  [SpecialName]
  public ICollection<bm> h0()
  {
    return (ICollection<bm>) this.n.Values;
  }

  public bm hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.m.Count)
      return this.m[A_0];
    return (bm) null;
  }

  public bm hz(string A_0)
  {
    if (A_0 == null)
      return (bm) null;
    bm bm = (bm) null;
    this.n.TryGetValue(A_0, out bm);
    return bm;
  }

  public void hz(g8 A_0)
  {
    foreach (bm bm in this.m)
      bm.g(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "expeditionagents")
      throw new AlbionException("[ExpeditionAgentData] LoadDataFromXml: XmlTag 'expeditionagents' not found! Invalid Xml File?");
    bm.g();
    this.n = new Dictionary<string, bm>(A_0.ChildNodes.Count);
    this.m = new List<bm>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bm bm = new bm();
        bm.g(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.n[bm.i()] = bm;
        // ISSUE: reference to a compiler-generated method
        if (bm.h() != this.m.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[ExpeditionAgentData] ParseAgent: Invalid Type enumeration: type is: " + (object) bm.h() + " but should be: " + (object) this.m.Count);
        }
        this.m.Add(bm);
      }
    }
    return true;
  }
}
