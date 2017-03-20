// Decompiled with JetBrains decompiler
// Type: cb
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;

public class cb : ca
{
  public static string al = "_EMPTY";
  public static string am = "_FULL";
  protected cb an;

  public cb(b8 A_0)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.a(kx.g);
    // ISSUE: reference to a compiler-generated method
    this.a(-1f);
    this.x = false;
  }

  public static cb b(cb A_0, b8 A_1)
  {
    cb cb = new cb(A_1);
    cb.c = b9.c++;
    cb.an = A_0;
    cb.d = A_0.d6();
    cb.d5();
    cb.x = true;
    return cb;
  }

  public static cb a(cb A_0, b8 A_1)
  {
    cb cb = new cb(A_1);
    cb.c = b9.c++;
    cb.an = A_0;
    cb.d = A_0.d8();
    cb.d5();
    cb.x = true;
    return cb;
  }

  public void d5()
  {
    cb an = this.an;
    string d = this.d;
    b8 i = this.i;
    int c = this.c;
    if (this.an != null)
      cb.a<cb>(this.an, this);
    this.c = c;
    this.an = an;
    this.d = d;
    this.i = i;
    this.aj = b9.b(this.d);
    this.ak = b9.a(this.d);
    this.ae = an.ae;
    if (this.j.EndsWith(cb.am))
    {
      this.ae += cb.am;
    }
    else
    {
      if (!this.j.EndsWith(cb.al))
        return;
      this.ae += cb.al;
    }
  }

  private static void a<a>(a A_0, a A_1)
  {
    for (System.Type A_0_1 = typeof (a); A_0_1 != null; A_0_1 = A_0_1.BaseType)
      cb.a<a>(A_0_1, A_0, A_1);
  }

  private static void a<a>(System.Type A_0, a A_1, a A_2)
  {
    foreach (FieldInfo field in A_0.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      field.SetValue((object) A_2, field.GetValue((object) A_1));
  }

  public string d6()
  {
    string d = this.d;
    if (this.an != null)
      d = this.an.d;
    return cb.b(d);
  }

  public new static string b(string A_0)
  {
    int startIndex = A_0.IndexOf(b8.a);
    if (startIndex >= 0)
      return A_0.Insert(startIndex, cb.al);
    return A_0 + cb.al;
  }

  public string d7()
  {
    if (this.an != null)
      return this.an.d;
    return this.d;
  }

  public string d8()
  {
    string d = this.d;
    if (this.an != null)
      d = this.an.d;
    return cb.a(d);
  }

  public new static string a(string A_0)
  {
    int startIndex = A_0.IndexOf(b8.a);
    if (startIndex >= 0)
      return A_0.Insert(startIndex, cb.am);
    return A_0 + cb.am;
  }

  public cb.a a(kt A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.d3() != null)
    {
      // ISSUE: reference to a compiler-generated method
      float num1 = (float) A_0.cw(0.0, (double) this.d4());
      float num2 = 0.0f;
      // ISSUE: reference to a compiler-generated method
      foreach (cb.a a in this.d3())
      {
        num2 += (float) a.b;
        if ((double) num1 <= (double) num2)
          return a;
      }
    }
    return (cb.a) null;
  }

  public override bool bc(XmlElement A_0)
  {
    base.bc(A_0);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.b(A_0, "maxfame", this.d0()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.a(aim.a(A_0, "baselootamount", this.d1()));
    this.b(A_0);
    this.a(A_0);
    return true;
  }

  private void b(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, "famefillingmissions");
    if (xmlElementList == null || xmlElementList.Count == 0)
      return;
    XmlElement xmlElement = xmlElementList[0];
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.a(new List<s>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        s s = s.au(A_0_1.Name, this);
        s.ar(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.d2().Add(s);
      }
    }
  }

  private void a(XmlElement A_0)
  {
    List<XmlElement> xmlElementList = aim.d(A_0_1, "lootlist");
    if (xmlElementList == null || xmlElementList.Count == 0)
      return;
    XmlElement xmlElement = xmlElementList[0];
    if (xmlElement == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.a(0);
    // ISSUE: reference to a compiler-generated method
    this.a(new List<cb.a>(xmlElement.ChildNodes.Count));
    foreach (object obj in (XmlNode) xmlElement)
    {
      XmlElement A_0_2 = obj as XmlElement;
      if (A_0_2 != null)
      {
        cb.a a = new cb.a() { b = aim.b(A_0_2, "weight", 0), a = aim.c(A_0_2, "labourerfame", kx.g), c = aim.a(A_0_2, "itemname", (string) null), d = aim.b(A_0_2, "itemenchantmentlevel", 0), f = aim.b(A_0_2, "itemamount", 0), g = aim.c(A_0_2, "silveramount", kx.g) };
        // ISSUE: reference to a compiler-generated method
        this.d3().Add(a);
        cb cb = this;
        // ISSUE: reference to a compiler-generated method
        int A_0_3 = cb.d4() + a.b;
        // ISSUE: reference to a compiler-generated method
        cb.a(A_0_3);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.d3().Sort((Comparison<cb.a>) ((A_0_2, A_1) => A_0_2.b.CompareTo(A_1.b)));
  }

  public override void bd(g8 A_0)
  {
    base.bd(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.d3() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (cb.a a in this.d3())
    {
      if (!string.IsNullOrEmpty(a.c))
      {
        // ISSUE: reference to a compiler-generated method
        a.e = A_0.an().hz(a.c, a.d);
      }
    }
  }

  public class a
  {
    public kx a;
    public int b;
    public string c;
    public int d;
    public b9 e;
    public int f;
    public kx g;
  }
}
