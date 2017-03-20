// Decompiled with JetBrains decompiler
// Type: o
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.SimulationObjects.AccessRights;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

public class o : n
{
  private static readonly char[] i = new char[2]{ ' ', ',' };
  private Dictionary<string, o.c> j = new Dictionary<string, o.c>();
  public const int c = 50;
  public const string d = "noaccess";
  public const string e = "user";
  public const string f = "friend";
  public const string g = "coowner";
  public const string h = "owner";

  [SpecialName]
  public ICollection<string> hz()
  {
    return (ICollection<string>) this.j.Keys;
  }

  public ICollection<o.b> hz(string A_0)
  {
    o.c c;
    if (this.j.TryGetValue(A_0, out c))
      return (ICollection<o.b>) c.c.Values;
    return (ICollection<o.b>) null;
  }

  public ICollection<o.a> h0(string A_0)
  {
    o.c c;
    if (this.j.TryGetValue(A_0, out c))
      return (ICollection<o.a>) c.e;
    return (ICollection<o.a>) null;
  }

  public bool h0<a>()
  {
    if (!typeof (a).IsEnum)
      return false;
    o.c c;
    if (this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return c.c.Count <= 2;
    return true;
  }

  public bool h1<a>(string A_0) where a : struct, IConvertible
  {
    o.c c;
    if (!typeof (a).IsEnum || !this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return false;
    return c.b.ContainsKey(A_0);
  }

  public IEnumerable<string> h1<a>() where a : struct, IConvertible
  {
    if (!typeof (a).IsEnum)
      return (IEnumerable<string>) null;
    o.c c;
    if (this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return (IEnumerable<string>) c.d;
    return (IEnumerable<string>) null;
  }

  public IEnumerable<KeyValuePair<string, o.b>> h2<a>() where a : struct, IConvertible
  {
    if (!typeof (a).IsEnum)
      return (IEnumerable<KeyValuePair<string, o.b>>) null;
    o.c c;
    if (this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return (IEnumerable<KeyValuePair<string, o.b>>) c.c;
    return (IEnumerable<KeyValuePair<string, o.b>>) null;
  }

  public bool hz<a>(string A_0, a A_1) where a : struct, IConvertible
  {
    o.c c;
    if (!typeof (a).IsEnum || !this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return false;
    string lower = A_1.ToString((IFormatProvider) CultureInfo.InvariantCulture).ToLower();
    HashSet<string> stringSet;
    if (c.a.TryGetValue(lower, out stringSet))
      return stringSet.Contains(A_0);
    return false;
  }

  public bool hz<a>(string A_0, string A_1) where a : struct, IConvertible
  {
    o.c c;
    HashSet<string> stringSet;
    if (!typeof (a).IsEnum || !this.j.TryGetValue(typeof (a).Name.ToLower(), out c) || !c.b.TryGetValue(A_0, out stringSet))
      return false;
    return stringSet.Contains(A_1);
  }

  public bool hz<a>(Preset A_0) where a : struct, IConvertible
  {
    return this.h0<a>(A_0) != null;
  }

  public o.a h0<a>(Preset A_0) where a : struct, IConvertible
  {
    if (typeof (a) == typeof (AccessRightsNull))
      return (o.a) null;
    if (!typeof (a).IsEnum)
      return (o.a) null;
    o.c c;
    if (this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
    {
      int index = (int) A_0;
      if (index < c.e.Length)
        return c.e[index];
    }
    return (o.a) null;
  }

  public o.a[] h3<a>() where a : struct, IConvertible
  {
    if (!typeof (a).IsEnum)
      return (o.a[]) null;
    o.c c;
    if (this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return c.e;
    return (o.a[]) null;
  }

  public o.b h2<a>(string A_0) where a : struct, IConvertible
  {
    if (!typeof (a).IsEnum)
      return (o.b) null;
    o.c c;
    if (!this.j.TryGetValue(typeof (a).Name.ToLower(), out c))
      return (o.b) null;
    o.b b = (o.b) null;
    c.c.TryGetValue(A_0, out b);
    return b;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "accessrights")
      throw new AlbionException("[AccessRightsData] LoadDataFromXml: XmlTag 'accessrights' not found! Invalid Xml File?");
    foreach (XmlElement xmlElement in A_0.GetElementsByTagName("accessclass"))
    {
      o.c A_0_1 = new o.c();
      A_0_1.c.Add("owner", new o.b());
      A_0_1.b.Add("owner", new HashSet<string>());
      A_0_1.d.Add("owner");
      string lower = aim.h(xmlElement, "name").ToLower();
      this.h1(A_0_1, xmlElement);
      this.h0(A_0_1, xmlElement);
      this.hz(A_0_1, xmlElement);
      this.j.Add(lower, A_0_1);
    }
    return true;
  }

  private void h1(o.c A_0, XmlElement A_1)
  {
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("role"))
    {
      string lower = aim.h(A_0_1, "name").ToLower();
      string str1 = aim.h(A_0_1, "displayname");
      string str2 = aim.h(A_0_1, "description");
      if (lower != "noaccess")
      {
        HashSet<string> stringSet = new HashSet<string>((IEnumerable<string>) aim.h(A_0_1, "managesroles").Split(o.i, StringSplitOptions.RemoveEmptyEntries));
        stringSet.Remove("owner");
        stringSet.Remove("noaccess");
        o.b b = new o.b() { a = lower, b = str1, c = str2 };
        A_0.c[b.a] = b;
        A_0.b[lower] = stringSet;
        if (!A_0.d.Contains(lower))
          A_0.d.Add(lower);
      }
    }
    o.b b1 = new o.b() { a = "noaccess", b = "@ACCESSRIGHTS_DEFAULT_NAME_NOACCESS", c = "@ACCESSRIGHTS_DEFAULT_DESC_NOACCESS" };
    A_0.c.Add(b1.a, b1);
    A_0.b.Add("noaccess", new HashSet<string>());
    if (A_0.d.Contains("noaccess"))
      return;
    A_0.d.Add("noaccess");
  }

  private void h0(o.c A_0, XmlElement A_1)
  {
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("right"))
    {
      string index = aim.h(A_0_1, "name").ToLower().Replace("_", "");
      HashSet<string> stringSet = new HashSet<string>((IEnumerable<string>) aim.h(A_0_1, "roles").Split(o.i, StringSplitOptions.RemoveEmptyEntries));
      foreach (string str in stringSet)
        ;
      A_0.a[index] = stringSet;
    }
  }

  private void hz(o.c A_0, XmlElement A_1)
  {
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("preset"))
    {
      string lower1 = aim.h(A_0_1, "name").ToLower();
      string str1 = aim.h(A_0_1, "description");
      int index = (int) aaj.a(lower1);
      if (index < A_0.e.Length)
      {
        o.a a = new o.a() { c = str1, a = "noaccess", b = "noaccess" };
        foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("userpreset"))
        {
          string str2 = aim.h(A_0_2, "who");
          string lower2 = aim.h(A_0_2, "role").ToLower();
          if (str2 == "guild")
            a.b = lower2;
          else if (str2 == "everyone")
            a.a = lower2;
        }
        A_0.e[index] = a;
      }
    }
  }

  public void hz(g8 A_0)
  {
    foreach (o.c c in this.j.Values)
    {
      foreach (o.a a in c.e)
        ;
    }
  }

  public class a
  {
    public string a;
    public string b;
    public string c;

    [SpecialName]
    public string e()
    {
      return kr.b(this.c);
    }
  }

  public class b
  {
    public string a;
    public string b;
    public string c;

    [SpecialName]
    public string f()
    {
      return kr.b(this.b);
    }

    [SpecialName]
    public string g()
    {
      return kr.b(this.c);
    }
  }

  private class c
  {
    public Dictionary<string, HashSet<string>> a = new Dictionary<string, HashSet<string>>();
    public Dictionary<string, HashSet<string>> b = new Dictionary<string, HashSet<string>>();
    public Dictionary<string, o.b> c = new Dictionary<string, o.b>();
    public List<string> d = new List<string>();
    public o.a[] e = new o.a[4];
  }
}
