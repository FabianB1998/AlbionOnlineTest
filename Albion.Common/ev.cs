// Decompiled with JetBrains decompiler
// Type: ev
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ev : et
{
  public static readonly string t = "changevariableeffectinfo";

  [SpecialName]
  public override string cl()
  {
    return ev.t;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.h3((double) aim.a(A_0, "value", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ev.Operations>(A_0, "operation", ev.Operations.Set));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "ttl", 0.0f)));
    return base.cj(A_0);
  }

  public enum Operations
  {
    Set,
    Increment,
    Decrement,
  }
}
