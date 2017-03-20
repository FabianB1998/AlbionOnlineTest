// Decompiled with JetBrains decompiler
// Type: d2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class d2
{
  protected Dictionary<string, d2.ItemSetting> a = new Dictionary<string, d2.ItemSetting>();

  public d2(ab7 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(A_0);
    this.m();
  }

  public d2(d2 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.g(A_0.g());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.g(A_0.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(A_0.i());
    this.a = new Dictionary<string, d2.ItemSetting>(A_0.a.Count);
    foreach (KeyValuePair<string, d2.ItemSetting> keyValuePair in A_0.a)
    {
      d2.ItemSetting itemSetting = new d2.ItemSetting() { MeshId = keyValuePair.Value.MeshId, Color = keyValuePair.Value.Color };
      this.a.Add(keyValuePair.Key, itemSetting);
    }
  }

  [SpecialName]
  public d4 j()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.g().d5();
  }

  [SpecialName]
  public int k()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.g().ek();
  }

  [SpecialName]
  public string l()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.g().dr();
  }

  public void m()
  {
    this.a.Clear();
    // ISSUE: reference to a compiler-generated method
    foreach (d4.c c in this.j().d())
    {
      d2.ItemSetting itemSetting = new d2.ItemSetting();
      itemSetting.Color = 0;
      if (c.f != null && c.f.Length > 0)
        itemSetting.MeshId = c.f[0].a;
      this.a.Add(c.a, itemSetting);
    }
  }

  public d2.ItemSetting h(string A_0)
  {
    d2.ItemSetting itemSetting = (d2.ItemSetting) null;
    this.a.TryGetValue(A_0, out itemSetting);
    return itemSetting;
  }

  public void g(ds A_0, dt A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(A_0);
    // ISSUE: reference to a compiler-generated method
    this.h(A_1);
  }

  public bool h(string A_0, string A_1)
  {
    d4.c c = this.j().f(A_0);
    if (c == null || c.h(A_1) == null || !this.a.ContainsKey(A_0))
      return false;
    this.a[A_0].MeshId = A_1;
    return true;
  }

  public bool g(string A_0, int A_1)
  {
    d4.c c = this.j().f(A_0);
    if (c == null || A_1 < 0 && A_1 >= c.d || !this.a.ContainsKey(A_0))
      return false;
    this.a[A_0].Color = A_1;
    return true;
  }

  public string n()
  {
    // ISSUE: reference to a compiler-generated method
    return d2.g(this.h(), this.j());
  }

  public string o()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.i() == null)
      return string.Empty;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.i().h();
  }

  public string p()
  {
    // ISSUE: reference to a compiler-generated method
    string str = this.j().c();
    foreach (d2.ItemSetting itemSetting in this.a.Values)
    {
      if (!string.IsNullOrEmpty(itemSetting.MeshId))
        str = str + "_" + itemSetting.MeshId;
      str += (string) (object) itemSetting.Color;
    }
    return str;
  }

  public static string g(ds A_0, d4 A_1)
  {
    if (A_0 == null)
      return string.Empty;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return d2.g(A_0.i(), A_1.c());
  }

  public static string g(dt A_0)
  {
    if (A_0 == null)
      return string.Empty;
    // ISSUE: reference to a compiler-generated method
    return d2.g(A_0.h());
  }

  public static string g(string A_0, string A_1)
  {
    if (string.IsNullOrEmpty(A_0) || string.IsNullOrEmpty(A_1))
      return string.Empty;
    return A_1 + "_" + A_0;
  }

  public static string g(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return string.Empty;
    return A_0;
  }

  public class ItemSetting
  {
    public string MeshId;
    public int Color;
  }
}
