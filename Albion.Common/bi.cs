// Decompiled with JetBrains decompiler
// Type: bi
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bi
{
  private static int a;

  [SpecialName]
  public string j()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.k());
  }

  public static void g()
  {
    bi.a = 0;
  }

  public int j(string A_0)
  {
    bi.a a = (bi.a) null;
    // ISSUE: reference to a compiler-generated method
    if (this.m().TryGetValue(A_0, out a))
      return a.b;
    return 0;
  }

  public bool g(XmlElement A_0)
  {
    if (A_0.Name != "role")
      throw new AlbionException("[ItemRoleInfo] ParseFromXml: XmlTag 'role' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.g(bi.a++);
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "displayname", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "uisprite", string.Empty));
    this.h(A_0);
    return true;
  }

  protected void h(XmlElement A_0)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("category");
    if (elementsByTagName == null || elementsByTagName.Count == 0)
      return;
    // ISSUE: reference to a compiler-generated method
    this.g(new Dictionary<string, bi.a>(elementsByTagName.Count));
    foreach (object obj in elementsByTagName)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 == null)
        break;
      string str = aim.a(A_0_1, "value", string.Empty);
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(str) && !this.m().ContainsKey(str))
      {
        int A_1 = aim.b(A_0_1, "rating", 0);
        if (A_1 != 0)
        {
          bi.a a = new bi.a(str, A_1);
          // ISSUE: reference to a compiler-generated method
          this.m().Add(a.a, a);
        }
      }
    }
  }

  public void g(g8 A_0)
  {
  }

  public class a
  {
    public readonly string a;
    public readonly int b;

    public a(string A_0, int A_1)
    {
      this.a = A_0;
      this.b = A_1;
    }

    public override bool Equals(object obj)
    {
      bi.a a = obj as bi.a;
      if (a == null)
        return false;
      return this.a.Equals(a.a);
    }

    public override int GetHashCode()
    {
      return this.a.GetHashCode();
    }
  }
}
