// Decompiled with JetBrains decompiler
// Type: cm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class cm : ck
{
  private ck.ConditionType e;

  public cm(ck.ConditionType A_0)
  {
    this.e = A_0;
  }

  [SpecialName]
  public override ck.ConditionType bg()
  {
    return this.e;
  }

  public override void bh(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.v(new List<ck>());
    // ISSUE: reference to a compiler-generated method
    ck.v(this.v(), A_0);
  }

  public override bool bi(aie A_0, ah6 A_1, g8 A_2)
  {
    if (this.bg() == ck.ConditionType.And)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (!ck.bi(A_0, A_1, A_2))
          return false;
      }
    }
    else if (this.bg() == ck.ConditionType.Or)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (ck.bi(A_0, A_1, A_2))
          return true;
      }
    }
    else if (this.bg() == ck.ConditionType.Not)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (ck.bi(A_0, A_1, A_2))
          return false;
      }
    }
    return false;
  }

  public override bool bl(ah6 A_0, ah6 A_1, g8 A_2)
  {
    if (this.bg() == ck.ConditionType.And)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (!ck.bl(A_0, A_1, A_2))
          return false;
      }
    }
    else if (this.bg() == ck.ConditionType.Or)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (ck.bl(A_0, A_1, A_2))
          return true;
      }
    }
    else if (this.bg() == ck.ConditionType.Not)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (ck.bl(A_0, A_1, A_2))
          return false;
      }
    }
    return false;
  }

  public override bool bk(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    if (A_0 != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ck ck in this.v())
      {
        if (!ck.bk(A_0, A_1))
          flag = true;
      }
    }
    return !flag;
  }
}
