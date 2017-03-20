// Decompiled with JetBrains decompiler
// Type: gr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class gr : er
{
  private static Dictionary<string, System.Type> cl = new Dictionary<string, System.Type>();
  private static int cm = 0;
  protected static char[] da = new char[10]{ ' ', '\n', ':', '!', '?', ';', ',', '"', ')', '(' };

  static gr()
  {
    System.Type c = typeof (es);
    foreach (System.Type type in c.Assembly.GetTypes())
    {
      if (type.IsSubclassOf(c) && !type.IsAbstract)
      {
        es instance = (es) Activator.CreateInstance(type);
        gr.cl.Add(instance.cl(), type);
      }
    }
  }

  public gr()
  {
    // ISSUE: reference to a compiler-generated method
    this.h7(int.MinValue);
  }

  [SpecialName]
  public string jq()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.h5());
  }

  [SpecialName]
  public string jr()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.h4());
  }

  public static void h3()
  {
    gr.cm = 0;
  }

  public virtual bool cq(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.jo() < 0)
    {
      // ISSUE: reference to a compiler-generated method
      this.h7(gr.cm++);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h7(aim.a(A_0, "uniquename", this.jp()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h4("@SPELLS_" + this.jp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h3("@SPELLS_" + this.jp() + "_DESC");
    // ISSUE: reference to a compiler-generated method
    this.h8(aim.a(A_0, "uiatlas", (string) null));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h9(aim.a(A_0, "uisprite", this.jp()));
    // ISSUE: reference to a compiler-generated method
    this.h6(bv.h(A_0));
    List<XmlElement> xmlElementList = aim.d(A_0, "screenshakeinfo");
    if (xmlElementList != null && xmlElementList.Count > 0)
    {
      if (xmlElementList.Count > 1)
        ab0.a("Too many screenshakeinfo Tags defined in spell: " + aim.a(A_0, "uniquename", A_0.Name) + " First is used.");
      // ISSUE: reference to a compiler-generated method
      this.h5(aim.a(xmlElementList[0], "name", ""));
    }
    // ISSUE: reference to a compiler-generated method
    this.@if(aim.a(A_0, "unlockedtoequip", true));
    return true;
  }

  public virtual void cr(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (es es in this.jt())
    {
      if (es != null)
        es.cn(A_0);
    }
  }

  public static es h3(string A_0, gr A_1)
  {
    System.Type type;
    if (!gr.cl.TryGetValue(A_0, out type))
      return (es) null;
    es instance = (es) Activator.CreateInstance(type);
    instance.h4(A_1);
    return instance;
  }

  public string h3(float A_0, aam A_1, g8 A_2)
  {
    return this.h3(this.jr(), A_0, A_1, A_2);
  }

  public string h3(string A_0, float A_1, aam A_2, g8 A_3)
  {
    string str1 = A_0;
    for (int startIndex = str1.IndexOf('$'); startIndex >= 0; startIndex = str1.IndexOf('$'))
    {
      int num = str1.IndexOfAny(gr.da, startIndex);
      if (num > 0 && (int) str1[num - 1] == 46)
        --num;
      string str2 = num < 0 ? str1.Substring(startIndex) : str1.Substring(startIndex, num - startIndex);
      if (!string.IsNullOrEmpty(str2))
      {
        string newValue = this.h4(str2, A_1, A_2, A_3);
        str1 = string.IsNullOrEmpty(newValue) ? str1.Replace(str2, "[wrongtag]") : str1.Replace(str2, newValue);
      }
      else
        str1 = str1.Remove(startIndex);
    }
    return str1;
  }

  public string h4(string A_0, float A_1, aam A_2, g8 A_3)
  {
    if (A_2 == null || A_3 == null)
      return string.Empty;
    if (!A_0.StartsWith("$"))
      return (string) null;
    er.a A_1_1 = new er.a() { e = A_1, f = A_2, d = A_3 };
    if (A_0.StartsWith("$$"))
    {
      A_0 = A_0.Substring(2);
      return er.h6(A_0, A_1_1);
    }
    A_0 = A_0.Substring(1);
    return this.h7(A_0, A_1_1);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "name":
        return this.jq();
      case "removeactiveeffects":
        return this.h5<ho>(A_0);
      case "buff":
        return this.h5<abb>(A_0);
      case "weightbonus":
        return this.h5<fc>(A_0);
      case "reflectdamage":
        return this.h5<ij>(A_0);
      case "directattributechange":
        return this.h5<hn>(A_0);
      case "buffovertime":
        return this.h5<ht>(A_0);
      case "weightbonusovertime":
        return this.h5<e5>(A_0);
      case "attributechangeovertime":
        return this.h5<hs>(A_0);
      case "spelleffectarea":
        return this.h5<hr>(A_0);
      case "stun":
        return this.h5<h1>(A_0);
      case "silence":
        return this.h5<h0>(A_0);
      case "invisibility":
        return this.h5<g2>(A_0);
      case "invincibility":
        return this.h5<hx>(A_0);
      case "nothittable":
        return this.h5<e4>(A_0);
      case "root":
        return this.h5<hz>(A_0);
      case "resetcooldown":
        return this.h5<hp>(A_0);
      case "knockback":
        return this.h5<fj>(A_0);
      case "damageshield":
        return this.h5<hv>(A_0);
      case "applyeffectoneventactive":
        return this.h5<fg>(A_0);
      case "applyspell":
        return this.h5<e0>(A_0);
      case "reflectdamageactive":
        return this.h5<hy>(A_0);
      case "pull":
        return this.h5<fk>(A_0);
      case "resourcegatheringbuffovertime":
        return this.h5<e6>(A_0);
      default:
        return base.ck(A_0);
    }
  }

  protected string h5<a>(er.a A_0) where a : es
  {
    a a = this.h8<a>(A_0.b);
    if ((object) a != null)
      return a.h6(A_0);
    return (string) null;
  }

  protected a h8<a>(int A_0) where a : es
  {
    int num = 0;
    // ISSUE: reference to a compiler-generated method
    foreach (es es in this.jt())
    {
      a a = es as a;
      if ((object) a != null && num++ == A_0)
        return a;
    }
    return default (a);
  }
}
