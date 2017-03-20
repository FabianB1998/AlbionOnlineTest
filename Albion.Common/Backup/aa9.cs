// Decompiled with JetBrains decompiler
// Type: aa9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public class aa9
{
  private bool a;

  public virtual bool l(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.n(aim.b(A_0, "silver", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.b(A_0, "gold", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "time", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.b(A_0, "amountcrafted", 1));
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "forcesinglecraft", false));
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "payonlywithgold", false));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "swaptransaction", true));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.b(A_0, "craftingfocus", 0));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.b(A_0, "silverinrvpercentage", kx.j));
    // ISSUE: reference to a compiler-generated method
    if (kx.l(this.o(), kx.j))
    {
      this.a = true;
      aa9 aa9 = this;
      // ISSUE: reference to a compiler-generated method
      kx A_0_1 = kx.o(aa9.o(), kx.f(0.00999999977648258));
      // ISSUE: reference to a compiler-generated method
      aa9.l(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.n(kx.g);
    }
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("craftresource");
    // ISSUE: reference to a compiler-generated method
    this.l(new List<aa9.a>(elementsByTagName.Count));
    foreach (XmlNode xmlNode in elementsByTagName)
    {
      XmlElement A_0_1 = xmlNode as XmlElement;
      if (A_0_1 != null)
      {
        aa9.a a = new aa9.a() { a = aim.h(A_0_1, "uniquename"), b = aim.b(A_0_1, "enchantmentlevel", 0), c = aim.b(A_0_1, "count", 0), d = aim.b(A_0_1, "maxreturnamount", int.MaxValue), e = aim.a(A_0_1, "usedinrepair", true) };
        a.d = Math.Min(a.d, a.c);
        // ISSUE: reference to a compiler-generated method
        this.p().Add(a);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.l(false);
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < this.p().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      if (this.p()[index].d > 0)
      {
        // ISSUE: reference to a compiler-generated method
        this.l(true);
        break;
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.u() > 0 && !this.v())
    {
      // ISSUE: reference to a compiler-generated method
      this.l(0);
    }
    return true;
  }

  public int l(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (aa9.a a in this.p())
    {
      if (a.a == A_0)
        return a.c;
    }
    return 0;
  }

  public void l(kx A_0, g8 A_1)
  {
    if (!this.a)
      return;
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = A_1.ar().ic(A_0);
    // ISSUE: reference to a compiler-generated method
    kx A_0_2 = A_1.ar().ia(A_0_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.o().i() == 10000L)
    {
      // ISSUE: reference to a compiler-generated method
      this.n(A_0_2);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (this.o().i() == 0L)
      {
        // ISSUE: reference to a compiler-generated method
        this.n(kx.g);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.n(kx.o(A_0_2, this.o()));
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(this.m().o());
  }

  public class a
  {
    public string a = string.Empty;
    public int c = 1;
    public int d = 1;
    public bool e = true;
    public int b;
  }
}
