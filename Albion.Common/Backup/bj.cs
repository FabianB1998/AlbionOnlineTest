// Decompiled with JetBrains decompiler
// Type: bj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bj : n
{
  protected List<bi> i;
  protected Dictionary<string, bi> j;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.j.Keys;
  }

  [SpecialName]
  public ICollection<bi> h0()
  {
    return (ICollection<bi>) this.j.Values;
  }

  public bi hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.i.Count)
      return this.i[A_0];
    return (bi) null;
  }

  public bi hz(string A_0)
  {
    if (A_0 == null)
      return (bi) null;
    bi bi = (bi) null;
    this.j.TryGetValue(A_0, out bi);
    return bi;
  }

  public List<bi> hz(IList<string> A_0)
  {
    if (A_0 == null || A_0.Count == 0)
      return (List<bi>) null;
    List<bi> biList = new List<bi>(A_0.Count);
    for (int index = 0; index < this.i.Count; ++index)
    {
      bi bi = this.i[index];
      // ISSUE: reference to a compiler-generated method
      if (A_0.Contains(bi.i()))
        biList.Add(this.i[index]);
    }
    return biList;
  }

  public bi hz(IList<b9> A_0)
  {
    return bj.hz(A_0, (IList<bi>) this.i);
  }

  public bi hz(IList<b9> A_0, IList<string> A_1)
  {
    List<bi> biList = this.hz(A_1);
    return bj.hz(A_0, (IList<bi>) biList);
  }

  public static bi hz(IList<b9> A_0, IList<bi> A_1)
  {
    if (A_0 == null || A_0.Count == 0 || (A_1 == null || A_1.Count == 0))
      return (bi) null;
    int[] numArray = new int[A_1.Count];
    for (int index1 = 0; index1 < A_0.Count; ++index1)
    {
      b9 b9 = A_0[index1];
      if (b9 != null)
      {
        for (int index2 = 0; index2 < A_1.Count; ++index2)
        {
          bi bi = A_1[index2];
          numArray[index2] += bi.j(b9.o);
        }
      }
    }
    int num = 0;
    bi bi1 = (bi) null;
    for (int index = 0; index < numArray.Length; ++index)
    {
      if (numArray[index] > num)
      {
        num = numArray[index];
        bi1 = A_1[index];
      }
    }
    return bi1;
  }

  public void hz(g8 A_0)
  {
    foreach (bi bi in this.i)
      bi.g(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "itemroles")
      throw new AlbionException("[ItemRoleInfo] LoadDataFromXml: XmlTag 'itemroles' not found! Invalid Xml File?");
    bi.g();
    this.j = new Dictionary<string, bi>(A_0.ChildNodes.Count);
    this.i = new List<bi>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bi bi = new bi();
        bi.g(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.j[bi.i()] = bi;
        // ISSUE: reference to a compiler-generated method
        if (bi.h() != this.i.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[ItemRoleInfo] ParseItemRole: Invalid Type enumeration: type is: " + (object) bi.h() + " but should be: " + (object) this.i.Count);
        }
        this.i.Add(bi);
      }
    }
    return true;
  }
}
