// Decompiled with JetBrains decompiler
// Type: ahn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ahn : ahm
{
  private float i = float.MinValue;
  private k2 d;
  private k2 e;
  private bool f;
  private kz g;
  private kz h;

  public ahn(aht A_0)
    : base(A_0)
  {
    this.e = k2.a();
    this.d = k2.a();
    this.f = false;
  }

  [SpecialName]
  public void y(k2 A_0)
  {
    this.d = A_0;
    this.z();
  }

  [SpecialName]
  public k2 ad()
  {
    return this.d;
  }

  [SpecialName]
  public override k2 c7()
  {
    this.y();
    return this.e;
  }

  public override ahm c8(aht A_0)
  {
    ahn ahn = new ahn(A_0) { g = this.g, h = this.h };
    // ISSUE: reference to a compiler-generated method
    if (this.ac() != null)
    {
      // ISSUE: reference to a compiler-generated method
      if (this.ac().Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ahn.y(new List<ahm>(this.ac().Count));
      }
      // ISSUE: reference to a compiler-generated method
      foreach (ahm ahm in this.ac())
        ahn.y(ahm.c8(A_0));
    }
    return (ahm) ahn;
  }

  public override float c9()
  {
    float num1 = 0.0f;
    // ISSUE: reference to a compiler-generated method
    if (this.ac() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ahm ahm in this.ac())
      {
        float num2 = ahm.c9();
        if ((double) num2 > (double) num1)
          num1 = num2;
      }
    }
    return Math.Max(Math.Abs(this.g.c0()), Math.Abs(this.g.c1())) + num1;
  }

  public override ahm da(ace A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ac() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ahm ahm1 in this.ac())
      {
        ahm ahm2 = ahm1.da(A_0);
        if (ahm2 != null)
          return ahm2;
      }
    }
    return (ahm) null;
  }

  public override bool db(ab9 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ac() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ahm ahm in this.ac())
      {
        if (ahm.db(A_0))
          return true;
      }
    }
    return false;
  }

  private ahm y(string A_0)
  {
    switch (A_0)
    {
      case "node":
        // ISSUE: reference to a compiler-generated method
        return (ahm) new ahn(this.ag());
      case "arc":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (ahm) new ahr(this.ag(), this.ag().i++);
      case "circle":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (ahm) new ahs(this.ag(), this.ag().i++);
      case "rectangle":
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (ahm) new ahq(this.ag(), this.ag().i++);
      default:
        return (ahm) null;
    }
  }

  public override void dc(XmlElement A_0)
  {
    this.g = this.y(A_0, "distance");
    this.h = this.y(A_0, "angle");
    foreach (object childNode in A_0.ChildNodes)
    {
      if (childNode is XmlElement)
      {
        XmlElement A_0_1 = (XmlElement) childNode;
        ahm A_0_2 = this.y(A_0_1.Name);
        if (A_0_2 != null)
          A_0_2.dc(A_0_1);
        this.y(A_0_2);
      }
    }
  }

  public void ae()
  {
    this.g = (kz) new k1(0.0f);
    this.h = (kz) new k1(0.0f);
  }

  public void y(GameTimeStamp A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.dd((float) GameTimeStamp.c(A_0, this.ag().aa()).t());
  }

  public override void dd(float A_0)
  {
    if ((double) this.i == (double) A_0)
      return;
    this.i = A_0;
    float A_1 = this.g.c2(A_0);
    float A_0_1 = this.h.c2(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.ah() != null)
    {
      this.y(k2.a(k2.a(new ahk(0.0f, A_1)), k2.a(abh.d(A_0_1))));
      this.z();
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ac() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (ahm ahm in this.ac())
      ahm.dd(A_0);
  }

  public void y(ahm A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ac() == null)
    {
      // ISSUE: reference to a compiler-generated method
      this.y(new List<ahm>());
    }
    // ISSUE: reference to a compiler-generated method
    A_0.aa(this);
    if (A_0 is ahn)
      ((ahn) A_0).z();
    // ISSUE: reference to a compiler-generated method
    this.ac().Add(A_0);
  }

  private void z()
  {
    if (this.f)
      return;
    this.f = true;
    // ISSUE: reference to a compiler-generated method
    if (this.ac() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (ahm ahm in this.ac())
    {
      if (ahm is ahn)
        ((ahn) ahm).z();
    }
  }

  private void y()
  {
    if (!this.f)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.e = this.ah() == null ? this.ad() : k2.a(this.ad(), this.ah().c7());
    this.f = false;
  }
}
