﻿// Decompiled with JetBrains decompiler
// Type: fl
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Xml;

public class fl : e3
{
  public static readonly string c4 = "pulsingspell";

  [SpecialName]
  public override string cl()
  {
    return fl.c4;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "spell", ""));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "interval", 3f)));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "initialinterval", (float) this.h5().t())));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.b(A_0, "count", 10));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h7(ahy.v(ahy.k(1L), ahy.n(this.h6(), ahy.k((float) Math.Max(this.h7() - 1, 0), this.h5()))));
    return true;
  }

  public override void cn(g8 A_0)
  {
    base.cn(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3(A_0.ao().h0(this.h3()));
  }
}
