// Decompiled with JetBrains decompiler
// Type: b3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Xml;

public class b3
{
  public readonly b3.a g = new b3.a();
  public readonly b3.a h = new b3.a();
  public float a;
  public float b;
  public float c;
  public float d;
  public float e;
  public float f;

  public b3()
  {
    this.a = this.b = 10f;
    this.c = 0.0f;
    this.d = 1f;
    this.e = 0.0f;
    this.f = 0.0f;
  }

  internal void i(XmlElement A_0)
  {
    this.a = this.b = aim.a(A_0, "attackrange", (float) (((double) this.a + (double) this.b) / 2.0));
    this.a = aim.a(A_0, "engageattackrange", this.a);
    this.b = aim.a(A_0, "disengageattackrange", this.b);
    this.d = (float) aim.b(A_0, "attackintervalinms", (int) ((double) this.d * 1000.0)) / 1000f;
    this.d = aim.a(A_0, "attackinterval", this.d);
    this.c = aim.a(A_0, "attackdamagepercentage", this.c * 100f) / 100f;
    this.c = aim.a(A_0, "attackdamage", this.c);
    this.e = aim.a(A_0, "projectilespeed", this.e);
    this.e = aim.a(A_0, "attackdistancedelay", this.e);
    this.f = aim.a(A_0, "warcampbuffradius", this.f);
    this.f = aim.a(A_0, "buffradius", this.f);
    IEnumerator enumerator1 = A_0.GetElementsByTagName("FriendlyFX").GetEnumerator();
    try
    {
      if (enumerator1.MoveNext())
        this.g.d((XmlElement) enumerator1.Current);
    }
    finally
    {
      IDisposable disposable = enumerator1 as IDisposable;
      if (disposable != null)
        disposable.Dispose();
    }
    IEnumerator enumerator2 = A_0.GetElementsByTagName("HostileFX").GetEnumerator();
    try
    {
      if (!enumerator2.MoveNext())
        return;
      this.h.d((XmlElement) enumerator2.Current);
    }
    finally
    {
      IDisposable disposable = enumerator2 as IDisposable;
      if (disposable != null)
        disposable.Dispose();
    }
  }

  public class a
  {
    public string a = "";
    public string b = "";
    public string c = "";

    internal void d(XmlElement A_0)
    {
      this.a = aim.a(A_0, "beam", this.a);
      this.b = aim.a(A_0, "projectile", this.b);
      this.c = aim.a(A_0, "impact", this.c);
    }
  }
}
