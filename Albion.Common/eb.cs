// Decompiled with JetBrains decompiler
// Type: eb
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class eb : ea
{
  public override void cb(XmlElement A_0)
  {
    base.cb(A_0);
    // ISSUE: reference to a compiler-generated method
    this.n(0.0f);
    // ISSUE: reference to a compiler-generated method
    foreach (d5 d5 in this.o())
    {
      eb eb = this;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      double num = (double) eb.n() + (double) d5.s();
      // ISSUE: reference to a compiler-generated method
      eb.n((float) num);
    }
  }
}
