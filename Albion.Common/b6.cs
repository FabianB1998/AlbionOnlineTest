// Decompiled with JetBrains decompiler
// Type: b6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class b6 : n
{
  protected List<b7> s;
  protected Dictionary<string, b7> t;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.t.Keys;
  }

  [SpecialName]
  public ICollection<b7> h0()
  {
    return (ICollection<b7>) this.t.Values;
  }

  public b7 hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.s.Count)
      return this.s[A_0];
    return (b7) null;
  }

  public b7 hz(string A_0)
  {
    if (A_0 == null)
      return (b7) null;
    b7 b7 = (b7) null;
    this.t.TryGetValue(A_0, out b7);
    return b7;
  }

  public void hz(g8 A_0)
  {
    foreach (b7 b7 in this.s)
      b7.f(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "factions")
      throw new AlbionException("[FactionData] LoadDataFromXml: XmlTag 'Factions' not found! Invalid Xml File?");
    b7.f();
    this.t = new Dictionary<string, b7>(A_0.ChildNodes.Count);
    this.s = new List<b7>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        b7 b7 = new b7();
        b7.f(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.t[b7.j()] = b7;
        // ISSUE: reference to a compiler-generated method
        if (b7.i() != this.s.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[FactionData] ParseFaction: Invalid Type enumeration: type is: " + (object) b7.i() + " but should be: " + (object) this.s.Count);
        }
        this.s.Add(b7);
      }
    }
    return true;
  }
}
