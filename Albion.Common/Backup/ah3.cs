// Decompiled with JetBrains decompiler
// Type: ah3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class ah3
{
  private string a;

  public ah3(XmlElement A_0, aie A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(A_1);
    this.a = aim.a(A_0, "type", string.Empty);
    // ISSUE: reference to a compiler-generated method
    this.d(aim.a(A_0, "pos", ahk.d()));
  }

  public void d(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d(A_0.be().hz(this.a));
  }
}
