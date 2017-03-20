// Decompiled with JetBrains decompiler
// Type: d6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class d6 : d5
{
  public d6()
  {
    // ISSUE: reference to a compiler-generated method
    this.n(false);
  }

  public override void cb(XmlElement A_0)
  {
    base.cb(A_0);
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "type", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.b(A_0, "tier", 0));
  }
}
