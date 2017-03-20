// Decompiled with JetBrains decompiler
// Type: j6
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class j6
{
  public j6()
  {
    // ISSUE: reference to a compiler-generated method
    this.c(new List<j6.a>());
  }

  public j6.a c(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    foreach (j6.a a in this.d())
    {
      // ISSUE: reference to a compiler-generated method
      if (a.h() == A_0)
        return a;
    }
    return (j6.a) null;
  }

  public int e()
  {
    int num = 0;
    // ISSUE: reference to a compiler-generated method
    foreach (j6.a a in this.d())
    {
      // ISSUE: reference to a compiler-generated method
      if (a.h() > num)
      {
        // ISSUE: reference to a compiler-generated method
        num = a.h();
      }
    }
    return num;
  }

  public bool c(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.c(aim.h(A_0, "name"));
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("cluster"))
    {
      string A_0_2 = aim.h(A_0_1, "name");
      int length = A_0_2.IndexOf("_");
      if (length >= 0)
        A_0_2 = A_0_2.Substring(0, length);
      string A_4 = aim.h(A_0_1, "descloca");
      int A_1 = aim.b(A_0_1, "level", 0);
      int A_3 = aim.b(A_0_1, "premiumrequirement", 0);
      kx A_2 = aim.b(A_0_1, "silverprice", kx.h);
      // ISSUE: reference to a compiler-generated method
      this.d().Add(new j6.a(A_0_2, A_1, A_2, A_3, A_4));
    }
    return true;
  }

  public class a
  {
    public a(string A_0, int A_1, kx A_2, int A_3, string A_4)
    {
      // ISSUE: reference to a compiler-generated method
      this.f(A_3);
      // ISSUE: reference to a compiler-generated method
      this.g(A_0);
      // ISSUE: reference to a compiler-generated method
      this.g(A_1);
      // ISSUE: reference to a compiler-generated method
      this.f(A_2);
      // ISSUE: reference to a compiler-generated method
      this.f(A_4);
    }
  }
}
