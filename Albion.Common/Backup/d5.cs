// Decompiled with JetBrains decompiler
// Type: d5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public abstract class d5
{
  public d5()
  {
    // ISSUE: reference to a compiler-generated method
    this.n(true);
  }

  public virtual void cb(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "chance", 1f));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "weight", 1f));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "candropmultipletimes", this.t()));
  }
}
