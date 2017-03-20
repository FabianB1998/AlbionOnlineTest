// Decompiled with JetBrains decompiler
// Type: aie
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData.WorldInfos;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class aie
{
  public aie(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, ahk A_6, ahk A_7, ahk A_8, string A_9, string A_10, string A_11)
  {
    // ISSUE: reference to a compiler-generated method
    this.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.aq(A_1);
    // ISSUE: reference to a compiler-generated method
    int length = this.ai().IndexOf(".cluster.xml", StringComparison.InvariantCultureIgnoreCase);
    if (length >= 0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ap(this.ai().Substring(0, length));
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ap(this.ai());
    }
    ka.ClusterNameInformation A_1_1;
    // ISSUE: reference to a compiler-generated method
    if (!ka.b(this.aj(), out A_1_1))
      A_1_1 = (ka.ClusterNameInformation) null;
    // ISSUE: reference to a compiler-generated method
    this.ah(A_1_1);
    // ISSUE: reference to a compiler-generated method
    this.ao(A_2);
    // ISSUE: reference to a compiler-generated method
    this.an(A_3);
    // ISSUE: reference to a compiler-generated method
    this.am(A_10);
    // ISSUE: reference to a compiler-generated method
    this.ah(new j1());
    // ISSUE: reference to a compiler-generated method
    this.ah(new List<aic>());
    // ISSUE: reference to a compiler-generated method
    this.ah(new List<aib>());
    // ISSUE: reference to a compiler-generated method
    this.al(A_5);
    // ISSUE: reference to a compiler-generated method
    this.ak(A_4);
    // ISSUE: reference to a compiler-generated method
    this.aj(A_6);
    // ISSUE: reference to a compiler-generated method
    this.ai(A_7);
    // ISSUE: reference to a compiler-generated method
    this.ah(A_8);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ak(this.at());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.al(ahk.d(this.at(), this.au()));
    // ISSUE: reference to a compiler-generated method
    this.ah(true);
    // ISSUE: reference to a compiler-generated method
    this.aj(A_9);
    // ISSUE: reference to a compiler-generated method
    this.ai(A_11);
    // ISSUE: reference to a compiler-generated method
    this.ah(new aid());
  }

  [SpecialName]
  public bool aw()
  {
    // ISSUE: reference to a compiler-generated method
    return this.ah().Contains("#");
  }

  [SpecialName]
  public bool ba()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.al().ClusterType != ClusterTypes.Hellgate && this.al().ClusterType != ClusterTypes.Island)
    {
      // ISSUE: reference to a compiler-generated method
      return this.al().ClusterType == ClusterTypes.Expedition;
    }
    return true;
  }

  public static bool ah(string A_0)
  {
    return A_0.Contains("@");
  }

  public ah6 ah(Guid A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.a2() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (ah6 ah6 in this.a2())
      {
        // ISSUE: reference to a compiler-generated method
        if (ah6.k() == A_0)
          return ah6;
      }
    }
    return (ah6) null;
  }

  public aij ai(Guid A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.a0() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (aij aij in this.a0())
      {
        // ISSUE: reference to a compiler-generated method
        if (aij.n() == A_0)
          return aij;
      }
    }
    return (aij) null;
  }

  public ahk be()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return ahk.d(this.at(), ahk.a(0.5f, this.au()));
  }
}
