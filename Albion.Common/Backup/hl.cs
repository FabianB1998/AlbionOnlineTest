// Decompiled with JetBrains decompiler
// Type: hl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class hl : et
{
  public static readonly string fn = "changeaggro";

  [SpecialName]
  public override string cl()
  {
    return hl.fn;
  }

  public override es.a cm()
  {
    // ISSUE: reference to a compiler-generated method
    if ((double) this.h3() > 0.0)
      return es.a.c;
    // ISSUE: reference to a compiler-generated method
    return (double) this.h3() < 0.0 ? es.a.a : es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "value", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "aggroradius", 10f));
    return base.cj(A_0);
  }
}
