// Decompiled with JetBrains decompiler
// Type: c9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class c9 : n
{
  protected List<da> y;
  protected Dictionary<string, da> z;

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.z.Keys;
  }

  [SpecialName]
  public ICollection<da> h0()
  {
    return (ICollection<da>) this.z.Values;
  }

  public da hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.y.Count)
      return this.y[A_0];
    return (da) null;
  }

  public da hz(string A_0)
  {
    if (A_0 == null)
      return (da) null;
    da da = (da) null;
    this.z.TryGetValue(A_0, out da);
    return da;
  }

  public void hz(g8 A_0)
  {
    foreach (da da in this.y)
      da.ab(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "missions")
      throw new AlbionException("[QuestData] LoadDataFromXml: XmlTag 'missions' not found! Invalid Xml File?");
    da.ab();
    this.z = new Dictionary<string, da>(A_0.ChildNodes.Count);
    this.y = new List<da>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        da da = new da();
        da.ab(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.z[da.ad()] = da;
        // ISSUE: reference to a compiler-generated method
        if (da.ac() != this.y.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[QuestData] ParseMission: Invalid Type enumeration: type is: " + (object) da.ac() + " but should be: " + (object) this.y.Count);
        }
        this.y.Add(da);
      }
    }
    return true;
  }
}
