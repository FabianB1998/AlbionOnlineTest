// Decompiled with JetBrains decompiler
// Type: aij
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class aij
{
  public aij(XmlElement A_0, aie A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(A_1);
    string g = aim.h(A_0, "id");
    // ISSUE: reference to a compiler-generated method
    this.l(new Guid(g));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.h(A_0, "name"));
    string str1 = aim.h(A_0, "territorytype");
    if (string.IsNullOrEmpty(str1))
    {
      // ISSUE: reference to a compiler-generated method
      this.l(aij.TerritoryType.NORMAL);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.l((aij.TerritoryType) Enum.Parse(typeof (aij.TerritoryType), str1));
    }
    string str2 = aim.h(A_0, "resourcetype");
    if (!string.IsNullOrEmpty(str2))
    {
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.l((g5.ResourceTerritoryType) Enum.Parse(typeof (g5.ResourceTerritoryType), str2, true));
      }
      catch (Exception ex)
      {
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "center", ahk.d()));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "size", ahk.b(new ahk(1f, 1f), 140f)));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "monolith", this.s()));
    // ISSUE: reference to a compiler-generated method
    this.l(new List<aih>());
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("connections");
    if (elementsByTagName.Count <= 0)
      return;
    foreach (XmlElement A_0_1 in ((XmlElement) elementsByTagName[0]).GetElementsByTagName("connection"))
    {
      string A_0_2 = aim.h(A_0_1, "to");
      string str3 = aim.h(A_0_1, "type");
      if (!string.IsNullOrEmpty(g) && A_0_2.Contains("@"))
      {
        aih.Direction A_1_1 = (aih.Direction) Enum.Parse(typeof (aih.Direction), str3);
        // ISSUE: reference to a compiler-generated method
        this.l().Add(new aih(A_0_2, A_1_1));
      }
    }
  }

  [SpecialName]
  public string m()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.n().ToString() + "@" + this.p().ah();
  }

  public void l(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.p().an().a3())
    {
      // ISSUE: reference to a compiler-generated method
      this.l(aij.TerritoryType.CITY);
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.v() == aij.TerritoryType.CASTLE || this.v() == aij.TerritoryType.SIEGECAMP || this.v() != aij.TerritoryType.NORMAL && this.v() != aij.TerritoryType.WATCHTOWER && this.v() != aij.TerritoryType.CITY)
      return;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.l(A_0.a6().hz(this.v().ToString()));
  }

  public enum TerritoryType
  {
    NORMAL,
    CASTLE,
    CITY,
    WATCHTOWER,
    SIEGECAMP,
  }
}
