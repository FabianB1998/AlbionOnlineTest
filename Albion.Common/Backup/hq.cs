﻿// Decompiled with JetBrains decompiler
// Type: hq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class hq : et
{
  public static readonly string f5 = "spawnmob";

  [SpecialName]
  public override string cl()
  {
    return hq.f5;
  }

  public override es.a cm()
  {
    return es.a.c;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.h(A_0, "type"));
    // ISSUE: reference to a compiler-generated method
    this.h5(ahy.l((double) aim.a(A_0, "ttl", 10f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "ttlaftercasterdeath", -1f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "ttlafterreset", -1f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "limit", 1));
    // ISSUE: reference to a compiler-generated method
    this.h4(abh.d(aim.a(A_0, "anglefromcaster", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "distancefromtarget", 0.0f));
    return base.cj(A_0);
  }
}
