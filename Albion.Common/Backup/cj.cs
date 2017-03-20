// Decompiled with JetBrains decompiler
// Type: cj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class cj : ci
{
  private List<ck> c;

  [SpecialName]
  public List<ck> l()
  {
    return this.c;
  }

  public override void be(XmlElement A_0)
  {
    base.be(A_0);
    if (A_0.ChildNodes.Count <= 0)
      return;
    this.c = new List<ck>(A_0.ChildNodes.Count);
    ck.v(this.c, A_0);
  }

  protected HashSet<aie> k(ah6 A_0, g8 A_1)
  {
    HashSet<aie> A_2 = new HashSet<aie>();
    foreach (ck ck in this.l())
      ck.bj(A_0, A_1, ref A_2);
    return A_2;
  }

  public override bool bf(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    if (A_0 != null)
    {
      foreach (ck ck in this.l())
      {
        if (!ck.bk(A_0, A_1))
          flag = true;
      }
    }
    return !flag;
  }
}
