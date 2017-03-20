// Decompiled with JetBrains decompiler
// Type: il
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class il
{
  private kx a;
  private kx b;
  private kx c;

  [SpecialName]
  public kx d()
  {
    return this.a;
  }

  [SpecialName]
  public kx e()
  {
    return this.b;
  }

  [SpecialName]
  public kx f()
  {
    return this.c;
  }

  public bool d(XmlElement A_0)
  {
    this.a = aim.c(A_0, "default", kx.j);
    this.b = aim.c(A_0, "minimum", kx.j);
    this.c = aim.c(A_0, "maximum", kx.j);
    return true;
  }
}
