// Decompiled with JetBrains decompiler
// Type: d8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class d8 : d5
{
  private int g;
  private int h;

  [SpecialName]
  public int p()
  {
    return this.g;
  }

  [SpecialName]
  public int q()
  {
    return this.h;
  }

  public override void cb(XmlElement A_0)
  {
    base.cb(A_0);
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "type", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.b(A_0, "enchantmentlevel", 0));
    aim.a(A_0, "amount", 1, out this.g, out this.h);
  }

  public void n(string A_0, int A_1, int A_2, float A_3, float A_4)
  {
    // ISSUE: reference to a compiler-generated method
    this.n(A_0);
    this.g = A_1;
    this.h = A_2;
    // ISSUE: reference to a compiler-generated method
    this.o(A_3);
    // ISSUE: reference to a compiler-generated method
    this.p(A_4);
  }
}
