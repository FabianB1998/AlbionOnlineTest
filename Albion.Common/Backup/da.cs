// Decompiled with JetBrains decompiler
// Type: da
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class da
{
  private static int a = 0;
  private static char[] b = new char[3]{ ' ', ',', ';' };

  [SpecialName]
  public string ae()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.a0());
  }

  [SpecialName]
  public string af()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.a1());
  }

  [SpecialName]
  public string ag()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.a2());
  }

  public static void ab()
  {
    da.a = 0;
  }

  public bool ab(XmlElement A_0)
  {
    if (A_0.Name != "mission")
      throw new AlbionException("[QuestInfo] ParseFromXml: XmlTag 'mission' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.ae(da.a++);
    // ISSUE: reference to a compiler-generated method
    this.ag(aim.h(A_0, "uniquename"));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.b(A_0, "priority", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.b(A_0, "minlevel", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.b(A_0, "maxlevel", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    this.af(aim.a(A_0, "faction", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.a(A_0, "onceonly", false));
    // ISSUE: reference to a compiler-generated method
    this.ae(aim.a(A_0, "nextmission", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.a<da.Category>(A_0, "uicategory", da.Category.Fighting));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.a(A_0, "title", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.a(A_0, "offertext", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.a(A_0, "progresstext", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ab(aim.a(A_0, "previousmissions", string.Empty).Split(da.b, StringSplitOptions.RemoveEmptyEntries));
    // ISSUE: reference to a compiler-generated method
    this.ad(ahy.l(aim.b(A_0, "offertimeout", int.MinValue)));
    // ISSUE: reference to a compiler-generated method
    this.ac(ahy.l(aim.b(A_0, "missiontimeout", int.MinValue)));
    // ISSUE: reference to a compiler-generated method
    this.ab(ahy.l(aim.b(A_0, "missionslotcooldown", int.MinValue)));
    // ISSUE: reference to a compiler-generated method
    this.ac(aim.a(A_0, "tags", string.Empty).Split(da.b, StringSplitOptions.RemoveEmptyEntries));
    this.ac(aim.e(A_0, "tasks"));
    this.ad(aim.e(A_0, "rewards"));
    this.ae(aim.e(A_0, "variables"));
    return true;
  }

  public bool ab(bp A_0, int A_1, ah6 A_2, g8 A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_1 < 0 || A_1 >= A_0.w().Count || (this.al() != A_0.q() || this.ai() > A_0.r()) || this.aj() < A_0.r())
      return false;
    // ISSUE: reference to a compiler-generated method
    string[] strArray = A_0.w()[A_1];
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (strArray != null && strArray.Length > 0 && (this.ak() != null && this.ak().Length > 0))
    {
      foreach (string str in strArray)
      {
        // ISSUE: reference to a compiler-generated method
        if (Array.IndexOf<string>(this.ak(), str) < 0)
          return false;
      }
    }
    // ISSUE: reference to a compiler-generated method
    foreach (ci ci in this.au())
    {
      if (!ci.bn(A_2, A_3))
        return false;
    }
    return true;
  }

  public da.a ab(kx A_0, kx A_1, bool A_2)
  {
    da.a a = da.a.a;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.ab(A_1).i() > A_0.i())
      a |= da.a.b;
    return a;
  }

  public kx ab(kx A_0)
  {
    kx A_0_1 = kx.g;
    // ISSUE: reference to a compiler-generated method
    foreach (a1 a1 in this.ax())
    {
      a7 A_0_2 = a1 as a7;
      if (A_0_2 != null)
        A_0_1 = kx.q(A_0_1, this.ab(A_0_2, A_0));
    }
    return A_0_1;
  }

  public kx ab(a7 A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (A_0.au().i() != 0L)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0.au();
    }
    // ISSUE: reference to a compiler-generated method
    kx A_0_1 = kx.o(A_1, A_0.av());
    // ISSUE: reference to a compiler-generated method
    if (kx.j(A_0_1, A_0.aw()))
    {
      // ISSUE: reference to a compiler-generated method
      A_0_1 = A_0.aw();
    }
    return A_0_1;
  }

  protected void ac(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ab(new List<c8>(A_0.ChildNodes.Count));
    // ISSUE: reference to a compiler-generated method
    this.ab(false);
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        if (A_0_1.Name == "missionstep")
        {
          // ISSUE: reference to a compiler-generated method
          c8 c8 = new c8(this, this.av().Count);
          c8.e(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.av().Add(c8);
        }
        else if (A_0_1.Name == "completionstep")
        {
          c8 A_0_2 = new c8(this, -1);
          A_0_2.e(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.ab(A_0_2);
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (A_0_2.e() != null && A_0_2.e().Count == 1)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            ae ae = A_0_2.e()[A_0_2.e().Count - 1] as ae;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (ae != null && ae.cr() == null && (ae.cp() == null || ae.cp().Count == 0))
            {
              // ISSUE: reference to a compiler-generated method
              this.ab(true);
            }
          }
        }
      }
    }
  }

  protected void ad(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ab(new List<a1>(A_0.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        a1 a1 = a1.au(A_0_1.Name);
        if (a1 != null)
        {
          a1.az(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.ax().Add(a1);
        }
        else
          ab0.a("Reward couldn't be created from xml: " + A_0_1.ToString());
      }
    }
  }

  protected void ae(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ab(new List<ci>(A_0.ChildNodes.Count));
    // ISSUE: reference to a compiler-generated method
    this.ab(new List<cr>());
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        ci ci = ci.k(A_0_1.Name);
        if (ci != null)
        {
          ci.be(A_0_1);
          // ISSUE: reference to a compiler-generated method
          this.au().Add(ci);
          cr cr = ci as cr;
          if (cr != null)
          {
            // ISSUE: reference to a compiler-generated method
            this.az().Add(cr);
          }
        }
        else
          ab0.a("Variables couldn't be created from xml: " + A_0_1.ToString());
      }
    }
  }

  public void ab(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.an() != null && this.an().Length > 0)
    {
      // ISSUE: reference to a compiler-generated method
      List<int> intList = new List<int>(this.an().Length);
      // ISSUE: reference to a compiler-generated method
      c9 c9 = A_0.a0();
      // ISSUE: reference to a compiler-generated method
      for (int index = 0; index < this.an().Length; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        da da = c9.hz(this.an()[index]);
        if (da != null)
        {
          // ISSUE: reference to a compiler-generated method
          intList.Add(da.ac());
        }
      }
      // ISSUE: reference to a compiler-generated method
      this.ab(intList.ToArray());
    }
    List<string> A_1 = new List<string>();
    this.ab(A_0, A_1);
  }

  protected bool ab(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    if (this.au() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ci ci in this.au())
      {
        if (!ci.bf(A_0, A_1))
          flag = true;
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.av() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (c8 c8 in this.av())
      {
        // ISSUE: reference to a compiler-generated method
        if (c8.e() != null)
        {
          // ISSUE: reference to a compiler-generated method
          foreach (global::s s in c8.e())
          {
            // ISSUE: reference to a compiler-generated method
            if (!s.@as(this.au(), A_1))
              flag = true;
            if (!s.at(A_0, A_1))
              flag = true;
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.aw() != null && this.aw().e() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (global::s s in this.aw().e())
      {
        // ISSUE: reference to a compiler-generated method
        if (!s.@as(this.au(), A_1))
          flag = true;
        if (!s.at(A_0, A_1))
          flag = true;
      }
    }
    // ISSUE: reference to a compiler-generated method
    foreach (a1 a1 in this.ax())
    {
      if (!a1.a0(A_0, A_1))
        flag = true;
    }
    return !flag;
  }

  [System.Flags]
  public enum a : byte
  {
    a = 0,
    b = 1,
    c = 255,
  }

  public enum Category
  {
    Gathering,
    Fighting,
    Transport,
    Crafting,
    Promotion,
  }
}
