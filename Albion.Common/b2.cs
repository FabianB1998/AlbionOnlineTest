// Decompiled with JetBrains decompiler
// Type: b2
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class b2 : global::bd
{
  private const string av = "@LABOURER_TIERNAME_TIER_";
  private const string aw = "@LABOURER_PROFESSION_";

  public b2()
  {
    // ISSUE: reference to a compiler-generated method
    this.ca(true);
  }

  [SpecialName]
  public override bool ba()
  {
    return false;
  }

  [SpecialName]
  public override string bb()
  {
    return this.c5();
  }

  [SpecialName]
  public string c5()
  {
    return this.c7() + " " + this.c6();
  }

  [SpecialName]
  public string c6()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.cv());
  }

  [SpecialName]
  public string c7()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.cw());
  }

  public override bool a4(XmlElement A_0, string A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.cl(aim.c(A_0, "hireprice", kx.j));
    // ISSUE: reference to a compiler-generated method
    this.ck(aim.c(A_0, "fametoprogress", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ci(aim.b(A_0, "settleintime", -1));
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.b(A_0, "joblength", -1));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a(A_0, "yieldmultiplier", -1f));
    // ISSUE: reference to a compiler-generated method
    this.cj(aim.c(A_0, "happinessmovementtickrate", kx.j));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.b(A_0, "happinessunits", -1));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a<b2.LaborerType>(A_0, "profession", b2.LaborerType.None));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.b(A_0, "happinessunitsafterhire", 0));
    // ISSUE: reference to a compiler-generated method
    this.ca(aim.c(A_0, "maxbedcontribution", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.c(A_0, "maxtablecontribution", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.c(A_0, "maxtrophycontribution", kx.g));
    // ISSUE: reference to a compiler-generated method
    this.ci(aim.a(A_0, "professionname", string.Empty));
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.cv()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ci("@LABOURER_PROFESSION_" + this.cz().ToString().ToUpperInvariant());
    }
    // ISSUE: reference to a compiler-generated method
    this.cj(aim.a(A_0, "namegeneratorid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.bb(aim.a(A_0, "avatar", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ba(aim.a(A_0, "avatarring", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.bb(this.ba(A_0, "journalssold"));
    // ISSUE: reference to a compiler-generated method
    this.ba(this.ba(A_0, "journalsaccepted"));
    if (!base.a4(A_0, A_1))
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ca("@LABOURER_TIERNAME_TIER_" + this.db().ToString());
    // ISSUE: reference to a compiler-generated method
    this.ca(true);
    return true;
  }

  private List<string> ba(XmlElement A_0, string A_1)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName(A_1);
    if (elementsByTagName == null || elementsByTagName.Count <= 0)
      return (List<string>) null;
    XmlNode xmlNode = elementsByTagName[0];
    List<string> stringList = new List<string>(xmlNode.ChildNodes.Count);
    foreach (XmlNode childNode in xmlNode.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        string str = aim.h(A_0_1, "uniquename");
        stringList.Add(str);
      }
    }
    return stringList;
  }

  public override void a9(g8 A_0)
  {
    base.a9(A_0);
    // ISSUE: reference to a compiler-generated method
    if (this.c0() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.bb(new List<cb>(this.c0().Count));
      // ISSUE: reference to a compiler-generated method
      foreach (string A_0_1 in this.c0())
      {
        // ISSUE: reference to a compiler-generated method
        b8 b8 = A_0.an().hz(A_0_1);
        if (b8 != null)
        {
          for (int index = 0; index < 4; ++index)
          {
            cb cb = b8.e()[index] as cb;
            if (cb != null)
            {
              // ISSUE: reference to a compiler-generated method
              this.c2().Add(cb);
            }
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.c1() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ba(new List<cb>(this.c1().Count));
      // ISSUE: reference to a compiler-generated method
      foreach (string A_0_1 in this.c1())
      {
        // ISSUE: reference to a compiler-generated method
        b8 b8 = A_0.an().hz(A_0_1);
        if (b8 != null)
        {
          for (int index = 0; index < 4; ++index)
          {
            cb cb = b8.e()[index] as cb;
            if (cb != null)
            {
              // ISSUE: reference to a compiler-generated method
              this.c3().Add(cb);
            }
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ci(kx.f(this.co(), A_0.ar().ft));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ba(new SortedList<int, kx>(this.c3().Count));
    // ISSUE: reference to a compiler-generated method
    foreach (b9 b9 in this.c3())
    {
      int f = b9.f;
      // ISSUE: reference to a compiler-generated method
      if (!this.c4().ContainsKey(f))
      {
        // ISSUE: reference to a compiler-generated method
        kx kx = kx.f(A_0.ar().ft, f);
        // ISSUE: reference to a compiler-generated method
        this.c4().Add(f, kx);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.c4().TrimExcess();
  }

  public kx cj(int A_0)
  {
    kx kx;
    // ISSUE: reference to a compiler-generated method
    if (this.c4().TryGetValue(A_0, out kx))
      return kx;
    return kx.i;
  }

  public float ba(kx A_0, int A_1, ab8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i() == 0L)
      return 0.0f;
    kx A_1_1 = this.cj(A_1);
    // ISSUE: reference to a compiler-generated method
    if (A_1_1.i() == 0L)
      return 0.0f;
    float val1;
    if (kx.j(A_0, A_1_1))
    {
      val1 = (float) (A_0.m() / A_1_1.m());
    }
    else
    {
      if (!kx.k(A_0, A_1_1))
        return 1f;
      kx A_0_1 = kx.f(A_1 + 1, A_2.ft);
      kx kx1 = kx.p(A_0, A_1_1);
      kx kx2 = kx.p(A_0_1, A_1_1);
      // ISSUE: reference to a compiler-generated method
      if (kx2.i() == 0L)
        return 1f;
      float num = A_2.fx - 1f;
      val1 = (float) (kx1.m() / kx2.m()) * num + 1f;
    }
    return Math.Min(val1, A_2.fx);
  }

  public float ba(kx A_0, int A_1, float A_2, ab8 A_3)
  {
    float num1 = this.ba(A_0, A_1, A_3);
    if ((double) num1 == 0.0)
      return 0.0f;
    float num2 = 0.0f;
    if ((double) A_2 != 0.0)
    {
      // ISSUE: reference to a compiler-generated method
      num2 = num1 * this.cm() * A_2;
    }
    return num2;
  }

  protected kx ba(int A_0, List<dx> A_1, Func<dx, bool> A_2)
  {
    if (A_0_1 == 0 || A_1_1 == null || A_1_1.Count == 0)
      return kx.g;
    List<kx> kxList = new List<kx>(Math.Max(A_1_1.Count, A_0_1));
    foreach (dx dx in A_1_1)
    {
      // ISSUE: reference to a compiler-generated method
      ep ep = dx.ci();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((ep.d7() == b2.LaborerType.All || ep.d7() == this.cz()) && A_2(dx))
      {
        // ISSUE: reference to a compiler-generated method
        for (int index = 0; index < ep.d8(); ++index)
        {
          // ISSUE: reference to a compiler-generated method
          kxList.Add(ep.d9());
        }
      }
    }
    if (kxList.Count > A_0_1)
    {
      kxList.Sort((Comparison<kx>) ((A_0_2, A_1_2) => -A_0_2.CompareTo(A_1_2)));
      kxList.RemoveRange(A_0_1, kxList.Count - A_0_1);
    }
    else if (kxList.Count < A_0_1)
    {
      while (kxList.Count < A_0_1)
        kxList.Add(kx.g);
    }
    kx A_0 = kx.g;
    for (int index = 0; index < kxList.Count; ++index)
      A_0 = kx.q(A_0, kxList[index]);
    if (kxList.Count == 0)
      return kx.g;
    return kx.n(A_0, kx.g((long) kxList.Count));
  }

  public kx ba(int A_0, List<dx> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.g(this.ba(A_0_1, A_1, (Func<dx, bool>) (A_0_2 => A_0_2.ci().d6() == b2.FurnitureType.Bed)), this.cr());
  }

  public kx bb(int A_0, List<dx> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.g(this.ba(A_0_1, A_1, (Func<dx, bool>) (A_0_2 => A_0_2.ci().d6() == b2.FurnitureType.Table)), this.cs());
  }

  public kx ca(int A_0, List<dx> A_1)
  {
    List<string> stringList = new List<string>(A_1.Count);
    foreach (dx dx in A_1)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (dx.ci().d6() == b2.FurnitureType.Trophy && !stringList.Contains(dx.c9()))
      {
        // ISSUE: reference to a compiler-generated method
        stringList.Add(dx.c9());
      }
    }
    if (stringList.Count <= 0)
      return kx.g;
    List<kx> kxList = new List<kx>(stringList.Count);
    foreach (string str in stringList)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      kx kx = this.ba(A_0, A_1, new Func<dx, bool>(new b2.a() { a = str }.b));
      kxList.Add(kx);
    }
    kx A_0_1 = kx.g;
    for (int index = 0; index < kxList.Count; ++index)
      A_0_1 = kx.q(A_0_1, kxList[index]);
    // ISSUE: reference to a compiler-generated method
    return kx.g(A_0_1, this.ct());
  }

  public kx ci(int A_0, List<dx> A_1)
  {
    int A_0_1 = A_0;
    List<dx> A_1_1 = A_1;
    // ISSUE: reference to a compiler-generated method
    return kx.g(kx.q(kx.q(this.ba(A_0_1, A_1_1), this.bb(A_0_1, A_1_1)), this.ca(A_0_1, A_1_1)), this.cp());
  }

  public enum FurnitureType
  {
    None,
    Bed,
    Table,
    Trophy,
  }

  public enum LaborerType
  {
    None,
    All,
    Wood,
    Stone,
    Ore,
    Fiber,
    Hide,
    mercenary,
    warrior,
    hunter,
    mage,
    toolmaker,
  }
}
