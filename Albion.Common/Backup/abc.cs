// Decompiled with JetBrains decompiler
// Type: abc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.GameData;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class abc : n
{
  protected Dictionary<string, global::b8> b2 = new Dictionary<string, global::b8>();
  protected Dictionary<int, global::b9> b3 = new Dictionary<int, global::b9>();
  protected Dictionary<string, global::b9> b4 = new Dictionary<string, global::b9>();
  protected Dictionary<string, global::b9> b5 = new Dictionary<string, global::b9>();
  protected Dictionary<string, global::b8> b6 = new Dictionary<string, global::b8>();
  protected Dictionary<string, HashSet<string>> b7 = new Dictionary<string, HashSet<string>>();
  protected HashSet<string> b8 = new HashSet<string>();

  [SpecialName]
  public ICollection<global::b8> h0()
  {
    return (ICollection<global::b8>) this.b2.Values;
  }

  [SpecialName]
  public ICollection<global::b9> h1()
  {
    return (ICollection<global::b9>) this.b4.Values;
  }

  [SpecialName]
  public ICollection<global::b9> h2()
  {
    return (ICollection<global::b9>) this.b5.Values;
  }

  [SpecialName]
  public ICollection<global::b8> h3()
  {
    return (ICollection<global::b8>) this.b6.Values;
  }

  [SpecialName]
  public ICollection<string> h4()
  {
    return (ICollection<string>) this.b2.Keys;
  }

  [SpecialName]
  public HashSet<string> h5()
  {
    return this.b8;
  }

  [SpecialName]
  public Dictionary<string, HashSet<string>> h6()
  {
    return this.b7;
  }

  public global::b8 hz(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (global::b8) null;
    global::b8 b8 = (global::b8) null;
    this.b2.TryGetValue(A_0, out b8);
    return b8;
  }

  public global::b9 hz(int A_0)
  {
    global::b9 b9;
    if (this.b3.TryGetValue(A_0, out b9))
      return b9;
    return (global::b9) null;
  }

  public global::b9 hz(string A_0, int A_1)
  {
    if (string.IsNullOrEmpty(A_0) || A_1 < 0 || A_1 > 3)
      return (global::b9) null;
    global::b8 b8;
    if (this.b2.TryGetValue(A_0, out b8))
      return b8.e()[A_1];
    return (global::b9) null;
  }

  public global::b9 h0(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (global::b9) null;
    global::b9 b9 = (global::b9) null;
    this.b4.TryGetValue(A_0, out b9);
    return b9;
  }

  public static bool hz(global::b9 A_0)
  {
    if (A_0.x)
      return !A_0.j.EndsWith("_PROTOTYPE");
    return false;
  }

  public en h0(int A_0)
  {
    return this.hz(A_0) as en;
  }

  public en h0(string A_0, int A_1)
  {
    return this.hz(A_0, A_1) as en;
  }

  public c3 h1(int A_0)
  {
    return this.hz(A_0) as c3;
  }

  public c3 h1(string A_0, int A_1)
  {
    return this.hz(A_0, A_1) as c3;
  }

  public ep h2(int A_0)
  {
    return this.hz(A_0) as ep;
  }

  public ep h2(string A_0, int A_1)
  {
    return this.hz(A_0, A_1) as ep;
  }

  public c7 h3(int A_0)
  {
    return this.hz(A_0) as c7;
  }

  public c7 h3(string A_0, int A_1)
  {
    return this.hz(A_0, A_1) as c7;
  }

  public c5 h4(int A_0)
  {
    return this.hz(A_0) as c5;
  }

  public c5 h4(string A_0, int A_1)
  {
    return this.hz(A_0, A_1) as c5;
  }

  public void h7()
  {
    foreach (global::b8 b8 in this.b2.Values)
    {
      // ISSUE: reference to a compiler-generated method
      global::b9 b9 = b8.f();
      string lower1 = b9.n.ToLower();
      string lower2 = b9.o.ToLower();
      if (this.b7.ContainsKey(lower1))
        this.b7[lower1].Add(lower2);
      else
        this.b7.Add(lower1, new HashSet<string>() { lower2 });
      if (b9.n == "resources")
        this.b8.Add(b9.d);
    }
  }

  public void hz(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (global::b8 A_0_1 in new List<global::b8>((IEnumerable<global::b8>) A_0.an().b2.Values))
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0_1.f() is cb)
      {
        this.hz(A_0_1);
        this.h0(A_0_1);
      }
    }
    foreach (global::b8 b8 in this.b2.Values)
      b8.d(A_0);
  }

  protected void hz(global::b8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.d().EndsWith(cb.al) || A_0.d().EndsWith(cb.am))
      return;
    // ISSUE: reference to a compiler-generated method
    string key = cb.b(A_0.d());
    global::b8 b8 = (global::b8) null;
    if (this.b2.TryGetValue(key, out b8))
    {
      foreach (global::b9 b9 in b8.e())
      {
        cb cb = b9 as cb;
        if (cb != null)
          cb.d5();
      }
    }
    else
    {
      b8 = global::b8.e(A_0);
      foreach (global::b9 A_0_1 in b8.e())
        this.h0(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.b2.ContainsKey(b8.d());
      // ISSUE: reference to a compiler-generated method
      this.b2[b8.d()] = b8;
    }
  }

  protected void h0(global::b8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.d().EndsWith(cb.al) || A_0.d().EndsWith(cb.am))
      return;
    // ISSUE: reference to a compiler-generated method
    string key = cb.a(A_0.d());
    global::b8 b8 = (global::b8) null;
    if (this.b2.TryGetValue(key, out b8))
    {
      foreach (global::b9 b9 in b8.e())
      {
        cb cb = b9 as cb;
        if (cb != null)
          cb.d5();
      }
    }
    else
    {
      b8 = global::b8.d(A_0);
      foreach (global::b9 A_0_1 in b8.e())
        this.h0(A_0_1);
      // ISSUE: reference to a compiler-generated method
      this.b2.ContainsKey(b8.d());
      // ISSUE: reference to a compiler-generated method
      this.b2[b8.d()] = b8;
    }
  }

  protected override bool aq(XmlElement A_0)
  {
    global::b9.d0();
    return this.hz(A_0, false);
  }

  protected override bool bu(XmlElement A_0)
  {
    return this.hz(A_0, true);
  }

  private bool hz(XmlElement A_0, bool A_1)
  {
    if (A_0.Name != "items")
      throw new AlbionException("[ItemData] LoadDataFromXml: XmlTag 'items' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        global::b8 b8_1 = (global::b8) null;
        string key = aim.h(A_0_1, "uniquename");
        if (A_1 && this.b2.TryGetValue(key, out b8_1))
        {
          b8_1.d(A_0_1);
          // ISSUE: reference to a compiler-generated method
          if (key != b8_1.d())
          {
            this.b2.Remove(key);
            // ISSUE: reference to a compiler-generated method
            this.b2.ContainsKey(b8_1.d());
            // ISSUE: reference to a compiler-generated method
            this.b2[b8_1.d()] = b8_1;
          }
          foreach (global::b9 b9 in b8_1.e())
          {
            if (b9 != null)
            {
              if (!this.b3.ContainsKey(b9.c) || this.b3[b9.c] != b9)
                this.b3[b9.c] = b9;
              if (!this.b4.ContainsKey(b9.d) || this.b4[b9.d] != b9)
                this.b4[b9.d] = b9;
            }
          }
        }
        else
        {
          global::b8 b8_2 = new global::b8();
          b8_2.d(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.b2.ContainsKey(b8_2.d());
          // ISSUE: reference to a compiler-generated method
          this.b2[b8_2.d()] = b8_2;
          foreach (global::b9 A_0_2 in b8_2.e())
            this.h0(A_0_2);
        }
      }
    }
    this.h7();
    // ISSUE: reference to a compiler-generated method
    this.hz(new List<string>((IEnumerable<string>) this.b6.Keys));
    // ISSUE: reference to a compiler-generated method
    this.hz().Sort();
    return true;
  }

  protected void h0(global::b9 A_0)
  {
    if (A_0 == null)
      return;
    this.b3.ContainsKey(A_0.c);
    this.b3[A_0.c] = A_0;
    this.b4.ContainsKey(A_0.d);
    this.b4[A_0.d] = A_0;
    if (abc.hz(A_0))
    {
      this.b5.ContainsKey(A_0.d);
      this.b5[A_0.d] = A_0;
      if (this.b6.ContainsKey(A_0.j))
        return;
      global::b8 i = A_0.i;
      // ISSUE: reference to a compiler-generated method
      this.b6.Add(i.d(), i);
    }
    else
    {
      if (this.b5.ContainsKey(A_0.d))
        this.b5.Remove(A_0.d);
      if (!this.b6.ContainsKey(A_0.j))
        return;
      this.b6.Remove(A_0.j);
    }
  }

  public en hz(hh A_0, int A_1, int A_2)
  {
    en en1 = (en) null;
    foreach (global::b8 b8 in this.b2.Values)
    {
      for (int index = 0; index < 4; ++index)
      {
        en en2 = b8.e()[index] as en;
        // ISSUE: reference to a compiler-generated method
        if (en2 != null && en2.bl == EquipmentSlot.MainHand && (en2.d4(A_0.g()) && A_0.e(A_1, en2.f, A_2)) && (en1 == null || en2.f < en1.f || en2.f == en1.f && en2.h < en1.h))
          en1 = en2;
      }
    }
    return en1;
  }

  [System.Flags]
  public enum Placeability : byte
  {
    Nowhere = 0,
    Indoor = 1,
    Outdoor = 2,
    Dungeons = 4,
    Everywhere = Dungeons | Outdoor | Indoor,
  }
}
