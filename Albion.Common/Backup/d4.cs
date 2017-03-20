// Decompiled with JetBrains decompiler
// Type: d4
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class d4
{
  public bool e(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "uniquename", string.Empty));
    if (A_0.ChildNodes.Count > 0)
    {
      List<d4.c> cList = new List<d4.c>(A_0.ChildNodes.Count);
      foreach (XmlElement A_0_1 in (XmlNode) A_0)
      {
        if (A_0_1.Name == "Item")
        {
          d4.c c = this.d(A_0_1);
          if (c != null)
            cList.Add(c);
        }
      }
      if (cList.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        this.c(cList.ToArray());
      }
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.c(new d4.c[0]);
    }
    return true;
  }

  public d4.c f(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.d() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (d4.c c in this.d())
      {
        if (c.a == A_0)
          return c;
      }
    }
    return (d4.c) null;
  }

  private d4.c d(XmlElement A_0)
  {
    d4.c c = new d4.c();
    c.a = aim.a(A_0, "uniquename", string.Empty);
    c.b = aim.a(A_0, "colorlocatag", string.Empty);
    c.c = aim.b(A_0, "colorid", -1);
    c.d = aim.b(A_0, "colors", -1);
    c.e = aim.a<EquipmentSlot>(A_0, "replaceslot", EquipmentSlot.Invalid);
    if (A_0.ChildNodes.Count > 0)
    {
      List<d4.c.a> aList = new List<d4.c.a>(A_0.ChildNodes.Count);
      foreach (XmlElement A_0_1 in (XmlNode) A_0)
      {
        if (A_0_1.Name == "Mesh")
        {
          d4.c.a a = this.c(A_0_1);
          if (a != null)
            aList.Add(a);
        }
      }
      if (aList.Count > 0)
        c.f = aList.ToArray();
    }
    return c;
  }

  private d4.c.a c(XmlElement A_0)
  {
    d4.c.a A_1 = new d4.c.a();
    A_1.a = aim.a(A_0, "mesh", string.Empty);
    A_1.b = aim.a(A_0, "namelocatag", string.Empty);
    if (A_0.ChildNodes.Count > 0)
    {
      foreach (XmlElement A_0_1 in (XmlNode) A_0)
      {
        if (A_0_1 != null)
          this.c(A_0_1, A_1);
      }
    }
    return A_1;
  }

  private bool c(XmlElement A_0, d4.c.a A_1)
  {
    if (A_0.Name == "FaceState")
    {
      if (A_1.c == null)
        A_1.c = new Dictionary<d4.a, string>();
      d4.a key = d4.d(aim.a(A_0, "state", string.Empty));
      if (key != d4.a.e)
      {
        string str = aim.a(A_0, "mesh", string.Empty);
        A_1.c.Add(key, str);
      }
    }
    else if (A_0.Name == "BeardState")
    {
      if (A_1.d == null)
        A_1.d = new Dictionary<d4.b, string>();
      d4.b key = d4.c(aim.a(A_0, "state", string.Empty));
      if (key != d4.b.e)
      {
        string str = aim.a(A_0, "mesh", string.Empty);
        A_1.d.Add(key, str);
      }
    }
    return true;
  }

  public static d4.a d(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return d4.a.e;
    switch (A_0)
    {
      case "EMPTY":
        return d4.a.a;
      case "HOOD":
        return d4.a.b;
      case "HALF":
        return d4.a.c;
      case "FACE":
        return d4.a.d;
      default:
        return d4.a.e;
    }
  }

  public static d4.b c(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return d4.b.e;
    switch (A_0)
    {
      case "EMPTY":
        return d4.b.a;
      case "HOOD":
        return d4.b.b;
      case "HALF":
        return d4.b.c;
      case "FLAT":
        return d4.b.d;
      default:
        return d4.b.e;
    }
  }

  public enum a
  {
    a,
    b,
    c,
    d,
    e,
  }

  public enum b
  {
    a,
    b,
    c,
    d,
    e,
  }

  public class c
  {
    public string a;
    public string b;
    public int c;
    public int d;
    public EquipmentSlot e;
    public d4.c.a[] f;

    [SpecialName]
    public string h()
    {
      return kr.b(this.b);
    }

    public d4.c.a h(string A_0)
    {
      if (this.f != null)
      {
        foreach (d4.c.a a in this.f)
        {
          if (a.a == A_0)
            return a;
        }
      }
      return (d4.c.a) null;
    }

    public class a
    {
      public string a;
      public string b;
      public Dictionary<d4.a, string> c;
      public Dictionary<d4.b, string> d;

      [SpecialName]
      public string f()
      {
        return kr.b(this.b);
      }

      public string f(d4.a A_0)
      {
        if (A_0 == d4.a.a)
          return string.Empty;
        string str;
        if (A_0 != d4.a.e && this.c.TryGetValue(A_0, out str))
          return str;
        return this.a;
      }

      public string f(d4.b A_0)
      {
        if (A_0 == d4.b.a)
          return string.Empty;
        string str;
        if (A_0 != d4.b.e && this.d.TryGetValue(A_0, out str))
          return str;
        return this.a;
      }
    }
  }
}
