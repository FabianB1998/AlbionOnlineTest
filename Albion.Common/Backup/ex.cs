// Decompiled with JetBrains decompiler
// Type: ex
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ex : et
{
  public static readonly string ac = "removespelleffectareasoftarget";

  [SpecialName]
  public override string cl()
  {
    return ex.ac;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "spell", ""));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "maxareasremoved", 0));
    return base.cj(A_0);
  }
}
