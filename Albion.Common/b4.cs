// Decompiled with JetBrains decompiler
// Type: b4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Xml;

public class b4 : n
{
  public bool hz(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.hz().ContainsKey(A_0);
  }

  public b4.a h0(string A_0)
  {
    b4.a a = (b4.a) null;
    // ISSUE: reference to a compiler-generated method
    if (this.hz().TryGetValue(A_0, out a))
      return a;
    return (b4.a) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new Dictionary<string, b4.a>());
    if (A_0.Name != "EmoteData")
      throw new AlbionException("[EmoteInfo] LoadDataFromXml: XmlTag 'EmoteData' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      b4.a a = new b4.a();
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1.Name != "Emote")
        throw new AlbionException("[EmoteInfo] LoadDataFromXml: could not parse 'EmoteData'! Invalid Xml File?");
      if (A_0_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        a.i(aim.a(A_0_1, "name", ""));
        // ISSUE: reference to a compiler-generated method
        a.j(aim.a(A_0_1, "message", ""));
        // ISSUE: reference to a compiler-generated method
        a.k(aim.a(A_0_1, "target_message", ""));
        // ISSUE: reference to a compiler-generated method
        a.l(aim.a(A_0_1, "animation", ""));
        // ISSUE: reference to a compiler-generated method
        a.l(aim.a(A_0_1, "allow_target", false));
        // ISSUE: reference to a compiler-generated method
        a.i(aim.a(A_0_1, "loop", false));
        // ISSUE: reference to a compiler-generated method
        a.j(aim.a(A_0_1, "allow_while_moving", false));
        // ISSUE: reference to a compiler-generated method
        a.k(aim.a(A_0_1, "allow_while_mounted", false));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.hz().Add(a.i(), a);
      }
    }
    return true;
  }

  public class a
  {
  }
}
