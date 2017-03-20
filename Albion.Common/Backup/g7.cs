// Decompiled with JetBrains decompiler
// Type: g7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Xml;

public class g7
{
  public kx g(b9 A_0, int A_1)
  {
    return this.g(A_0, A_0.ab, A_1);
  }

  public kx g(b9 A_0, kx A_1, int A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.z.i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(kx.o(kx.f(A_1, A_2), this.h()), A_0.z);
  }

  public kx h(b9 A_0, int A_1)
  {
    return this.h(A_0, A_0.ab, A_1);
  }

  public kx h(b9 A_0, kx A_1, int A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.aa.i() == 0L)
      return kx.g;
    // ISSUE: reference to a compiler-generated method
    return kx.o(kx.o(kx.f(A_1, A_2), this.i()), A_0.aa);
  }

  public kx i(b9 A_0, int A_1)
  {
    return this.i(A_0, A_0.s, A_1);
  }

  public kx i(b9 A_0, kx A_1, int A_2)
  {
    kx A_1_1 = this.g(A_1, A_0.f, A_0.h, A_2);
    // ISSUE: reference to a compiler-generated method
    return kx.o(kx.o(kx.f(A_1, A_2), this.j()), A_1_1);
  }

  public kx j(b9 A_0, int A_1)
  {
    return this.j(A_0, A_0.s, A_1);
  }

  public kx j(b9 A_0, kx A_1, int A_2)
  {
    kx A_1_1 = this.g(A_1, A_0.f, A_0.h, A_2);
    // ISSUE: reference to a compiler-generated method
    return kx.o(kx.o(kx.f(A_1, A_2), this.g()), A_1_1);
  }

  private kx g(kx A_0, int A_1, int A_2, int A_3)
  {
    kx.f(A_0, A_3);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return kx.f(Math.Pow(this.k().m(), (double) (A_1 + (A_2 + 1) - this.l())));
  }

  public bool h(XmlElement A_0)
  {
    if (A_0.Name != "FameGainFactors")
      throw new AlbionException("[FameGainFactors] LoadDataFromXml: XmlTag 'FameGainFactors' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.g(aim.c(A_0, "itemvaluetofameprogressionfactor", kx.j));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.b(A_0, "progressionstarttier", 1));
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "KillPlayerIv":
            // ISSUE: reference to a compiler-generated method
            this.k(this.g(A_0_1));
            continue;
          case "GatherResource":
            // ISSUE: reference to a compiler-generated method
            this.j(this.g(A_0_1));
            continue;
          case "CraftItem":
            // ISSUE: reference to a compiler-generated method
            this.i(this.g(A_0_1));
            continue;
          case "InstallResourceIv":
            // ISSUE: reference to a compiler-generated method
            this.h(this.g(A_0_1));
            continue;
          default:
            continue;
        }
      }
    }
    return true;
  }

  private kx g(XmlElement A_0)
  {
    return aim.c(A_0, "factor", kx.j);
  }
}
