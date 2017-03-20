// Decompiled with JetBrains decompiler
// Type: v
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class v
{
  private v()
  {
  }

  [SpecialName]
  public string p()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.n().j();
  }

  public static v i(r A_0, int A_1)
  {
    v v = new v();
    // ISSUE: reference to a compiler-generated method
    v.i(A_0);
    // ISSUE: reference to a compiler-generated method
    v.i(A_1);
    return v;
  }

  public void i(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.i(aim.c(A_0, "learningpoints", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "progresstospendlp", 0.0f));
    this.j(aim.e(A_0, "missions"));
    this.k(aim.e(A_0, "rewardgroups"));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(this.i(this.j()));
  }

  public bool i(bc A_0, g8 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.j(this.o()));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.i(A_0.i().g(this.o(), bb.DataType.LpThreshold));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    s s = s.au(A_0.j(), this.n(), this.o());
    // ISSUE: reference to a compiler-generated method
    if (!s.aw(A_0, this.o(), A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.i(new List<s>(1));
    // ISSUE: reference to a compiler-generated method
    this.i().Add(s);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.j(A_0.o(this.o()));
    return true;
  }

  public void q()
  {
    // ISSUE: reference to a compiler-generated method
    this.i(new List<s>());
    // ISSUE: reference to a compiler-generated method
    this.j(new List<List<a1>>());
  }

  public void i(g8 A_0)
  {
    List<string> A_1 = new List<string>();
    this.i(A_0, A_1);
  }

  private bool i(List<List<a1>> A_0)
  {
    if (A_0 == null || A_0.Count == 0)
      return false;
    foreach (List<a1> a1List in A_0)
    {
      foreach (a1 a1 in a1List)
      {
        if (a1.bt())
          return true;
      }
    }
    return false;
  }

  public bool r()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.k().i() > 0L;
  }

  public bool j(float A_0)
  {
    if (this.r())
    {
      // ISSUE: reference to a compiler-generated method
      return (double) A_0 >= (double) this.l();
    }
    return false;
  }

  public kx k(float A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return v.i(A_0, this.l(), this.k());
  }

  public static kx i(float A_0, float A_1, kx A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_2.i() <= 0L || (double) A_0 < (double) A_1)
      return kx.i;
    if ((double) A_0 >= 1.0)
      return kx.g;
    float num = (float) (((double) A_0 - (double) A_1) / (1.0 - (double) A_1));
    return kx.o(A_2, kx.f(1.0 - (double) num)).q();
  }

  protected void j(XmlElement A_0)
  {
    if (A_0 == null)
    {
      // ISSUE: reference to a compiler-generated method
      this.i(new List<s>(0));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.i(new List<s>(A_0.ChildNodes.Count));
      foreach (object obj in (XmlNode) A_0)
      {
        XmlElement A_0_1 = obj as XmlElement;
        if (A_0_1 != null && A_0_1.Name == "mission")
        {
          s s = this.m(A_0_1);
          if (s != null)
          {
            s.ar(A_0_1);
            // ISSUE: reference to a compiler-generated method
            this.i().Add(s);
          }
          else
            ab0.a("Mission couldn't be created from xml: " + A_0_1.ToString());
        }
      }
    }
  }

  protected void k(XmlElement A_0)
  {
    if (A_0 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.j(new List<List<a1>>(A_0.ChildNodes.Count));
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "rewardgroup")
      {
        List<a1> a1List = this.l(A_0_1);
        if (a1List != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.j().Add(a1List);
        }
        else
          ab0.a("RewardGroup couldn't be created from xml: " + A_0_1.ToString());
      }
    }
  }

  protected List<a1> l(XmlElement A_0)
  {
    if (A_0 == null)
      return (List<a1>) null;
    List<a1> a1List = new List<a1>(A_0.ChildNodes.Count);
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "reward")
      {
        a1 a1 = this.n(A_0_1);
        if (a1 != null)
        {
          a1.az(A_0_1);
          a1List.Add(a1);
        }
        else
          ab0.a("Reward couldn't be created from xml: " + A_0_1.ToString());
      }
    }
    return a1List;
  }

  protected s m(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return s.au(aim.a(A_0, "type", string.Empty), this.n(), this.o());
  }

  protected a1 n(XmlElement A_0)
  {
    return a1.au(aim.a(A_0, "type", string.Empty));
  }

  protected bool i(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    if (this.i() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (s s in this.i())
      {
        if (!s.at(A_0, A_1))
          flag = true;
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.j() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (List<a1> a1List in this.j())
      {
        foreach (a1 a1 in a1List)
        {
          if (!a1.a0(A_0, A_1))
            flag = true;
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    if ((double) this.l() >= 1.0)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add("ProgressNeededToUseLearningPoints invalid: " + (object) this.l());
      flag = true;
    }
    return !flag;
  }
}
