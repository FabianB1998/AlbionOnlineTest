// Decompiled with JetBrains decompiler
// Type: hb
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class hb
{
  private static int a;

  public hb(int A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(new bool[A_0]);
  }

  public static void e()
  {
    hb.a = 0;
  }

  public bool e(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(hb.a++);
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "displayname", string.Empty));
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "QuadrantMarked")
      {
        int index = aim.b(A_0_1, "id", -1);
        // ISSUE: reference to a compiler-generated method
        if (index >= 0 && index < this.i().Length)
        {
          // ISSUE: reference to a compiler-generated method
          this.i()[index] = true;
        }
      }
    }
    return true;
  }
}
