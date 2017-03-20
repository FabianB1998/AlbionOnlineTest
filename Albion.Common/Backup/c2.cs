// Decompiled with JetBrains decompiler
// Type: c2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class c2 : n
{
  protected static Dictionary<string, ef> v = new Dictionary<string, ef>();
  protected static Dictionary<int, ef> w = new Dictionary<int, ef>();

  [SpecialName]
  public Dictionary<string, ef> h4()
  {
    return c2.v;
  }

  [SpecialName]
  public Dictionary<int, ef> h5()
  {
    return c2.w;
  }

  [SpecialName]
  public ICollection<string> h6()
  {
    return (ICollection<string>) c2.v.Keys;
  }

  public static ef hz(string A_0)
  {
    ef ef;
    if (c2.v.TryGetValue(A_0, out ef))
      return ef;
    return (ef) null;
  }

  public static ef hz(int A_0)
  {
    ef ef;
    if (c2.w.TryGetValue(A_0, out ef))
      return ef;
    return (ef) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    throw new NotImplementedException();
  }
}
