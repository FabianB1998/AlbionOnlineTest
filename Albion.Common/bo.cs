// Decompiled with JetBrains decompiler
// Type: bo
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bo : n
{
  protected List<bp> o;
  protected Dictionary<string, bp> p;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.p.Keys;
  }

  [SpecialName]
  public ICollection<bp> h0()
  {
    return (ICollection<bp>) this.p.Values;
  }

  public bp hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.o.Count)
      return this.o[A_0];
    return (bp) null;
  }

  public bp hz(string A_0)
  {
    if (A_0 == null)
      return (bp) null;
    bp bp = (bp) null;
    this.p.TryGetValue(A_0, out bp);
    return bp;
  }

  public void hz(g8 A_0)
  {
    foreach (bp bp in this.o)
      bp.l(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "agents")
      throw new AlbionException("[AgentData] LoadDataFromXml: XmlTag 'agents' not found! Invalid Xml File?");
    bp.l();
    this.p = new Dictionary<string, bp>(A_0.ChildNodes.Count);
    this.o = new List<bp>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bp bp = new bp();
        bp.l(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.p[bp.n()] = bp;
        // ISSUE: reference to a compiler-generated method
        if (bp.m() != this.o.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[AgentData] ParseAgent: Invalid Type enumeration: type is: " + (object) bp.m() + " but should be: " + (object) this.o.Count);
        }
        this.o.Add(bp);
      }
    }
    return true;
  }
}
