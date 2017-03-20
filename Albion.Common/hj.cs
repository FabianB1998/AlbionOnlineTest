// Decompiled with JetBrains decompiler
// Type: hj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Xml;

public class hj
{
  private kx[] a = new kx[8];
  private kx[] b = new kx[8];
  private static int c;

  public hj()
  {
    // ISSUE: reference to a compiler-generated method
    this.c(hj.c++);
  }

  public static void c()
  {
    hj.c = 0;
  }

  public kx d(int A_0)
  {
    return this.a[A_0 - 1];
  }

  public kx e(int A_0)
  {
    return this.b[A_0 - 1];
  }

  public void c(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.c(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.d()))
      throw new AlbionException("[GameData] couldn't parse Resource element " + A_0.Name);
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("ResourceTier"))
    {
      int index = aim.b(A_0_1, "value", 0) - 1;
      this.a[index] = aim.c(A_0_1, "resourcevalue", kx.j);
      this.b[index] = aim.c(A_0_1, "famevalue", kx.j);
    }
  }
}
