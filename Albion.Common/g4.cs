// Decompiled with JetBrains decompiler
// Type: g4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class g4 : gm
{
  public g4()
  {
    // ISSUE: reference to a compiler-generated method
    this.p(hk.d());
  }

  public override bool cp(XmlElement A_0)
  {
    base.cp(A_0);
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "source":
          // ISSUE: reference to a compiler-generated method
          this.p(aim.a(childNode, "socket", "damage"));
          // ISSUE: reference to a compiler-generated method
          this.p(hk.a(childNode, hk.d()));
          continue;
        case "target":
          // ISSUE: reference to a compiler-generated method
          this.u(aim.a(childNode, "socket", "damage"));
          // ISSUE: reference to a compiler-generated method
          this.q(hk.a(childNode, hk.d()));
          continue;
        default:
          continue;
      }
    }
    return true;
  }

  public void q(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.p(A_0);
  }
}
