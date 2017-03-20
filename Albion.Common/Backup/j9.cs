// Decompiled with JetBrains decompiler
// Type: j9
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public sealed class j9
{
  public j9.a a;
  public j9.a b;
  public j9.a c;
  public j9.a d;

  public j9()
  {
    // ISSUE: reference to a compiler-generated method
    this.i(new string[0]);
    // ISSUE: reference to a compiler-generated method
    this.i(new Dictionary<string, string>());
    // ISSUE: reference to a compiler-generated method
    this.i(new Dictionary<aif.Kind, string>());
    // ISSUE: reference to a compiler-generated method
    this.i(new Dictionary<g5.ResourceTerritoryType, j9.a>());
  }

  public string i(j7 A_0)
  {
    string str;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.j().TryGetValue(A_0.a0(), out str) || this.j().TryGetValue(A_0.br().x(), out str))
      return str;
    return string.Empty;
  }

  private static string[] i(XmlElement A_0, string A_1)
  {
    List<string> stringList = new List<string>();
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      if (childNode.Name == A_1)
        stringList.Add(aim.h(childNode, "resource"));
    }
    return stringList.ToArray();
  }

  public bool i(XmlElement A_0)
  {
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "banners":
          // ISSUE: reference to a compiler-generated method
          j9.i(this.j(), childNode);
          continue;
        case "castle":
          this.a.a = aim.h(childNode, "resource");
          this.a.b = aim.h(childNode, "gui");
          continue;
        case "city":
          this.b.a = aim.h(childNode, "resource");
          this.b.b = aim.h(childNode, "gui");
          continue;
        case "siegecamp":
          this.c.a = aim.h(childNode, "resource");
          this.c.b = aim.h(childNode, "gui");
          continue;
        case "territory":
          this.d.a = aim.h(childNode, "resource");
          this.d.b = aim.h(childNode, "gui");
          // ISSUE: reference to a compiler-generated method
          j9.i(this.l(), childNode);
          continue;
        case "exits":
          // ISSUE: reference to a compiler-generated method
          j9.i(this.k(), childNode);
          continue;
        case "settlements":
          // ISSUE: reference to a compiler-generated method
          this.i(j9.i(childNode, "settlement"));
          continue;
        default:
          continue;
      }
    }
    return true;
  }

  private static void i(Dictionary<string, string> A_0, XmlElement A_1)
  {
    A_0.Clear();
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("banner"))
    {
      string index = aim.a(A_0_1, "type", string.Empty);
      string str = aim.a(A_0_1, "resource", string.Empty);
      if (!string.IsNullOrEmpty(index))
        A_0[index] = str;
    }
  }

  private static void i(Dictionary<aif.Kind, string> A_0, XmlElement A_1)
  {
    A_0.Clear();
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("exit"))
    {
      string str1 = aim.a(A_0_1, "type", string.Empty);
      string str2 = aim.a(A_0_1, "resource", string.Empty);
      if (!string.IsNullOrEmpty(str1))
      {
        try
        {
          aif.Kind index = (aif.Kind) Enum.Parse(typeof (aif.Kind), str1, true);
          A_0[index] = str2;
        }
        catch (Exception ex)
        {
          ab0.a("Undefined exit kind: '" + str1 + "'\n" + ex.Message);
        }
      }
    }
  }

  private static void i(Dictionary<g5.ResourceTerritoryType, j9.a> A_0, XmlElement A_1)
  {
    A_0.Clear();
    foreach (XmlElement A_0_1 in A_1.GetElementsByTagName("resourcetype"))
    {
      string str1 = aim.a(A_0_1, "type", string.Empty);
      string str2 = aim.a(A_0_1, "resource", string.Empty);
      string str3 = aim.a(A_0_1, "gui", string.Empty);
      if (!string.IsNullOrEmpty(str1))
      {
        try
        {
          g5.ResourceTerritoryType index = (g5.ResourceTerritoryType) Enum.Parse(typeof (g5.ResourceTerritoryType), str1, true);
          A_0[index] = new j9.a() { a = str2, b = str3 };
        }
        catch (Exception ex)
        {
        }
      }
    }
  }

  public struct a
  {
    public string a;
    public string b;
  }
}
