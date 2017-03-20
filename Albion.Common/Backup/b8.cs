// Decompiled with JetBrains decompiler
// Type: b8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class b8
{
  public static string a = "@";
  protected b9[] b = new b9[4];

  [SpecialName]
  public b9[] e()
  {
    return this.b;
  }

  public virtual bool d(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(aim.h(A_0, "uniquename"));
    // ISSUE: reference to a compiler-generated method
    if (this.f() == null)
    {
      // ISSUE: reference to a compiler-generated method
      this.d(this.e(A_0));
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.f() == null || !this.f().d1(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.b[this.f().h] = this.f();
    // ISSUE: reference to a compiler-generated method
    return this.d(A_0, this.f());
  }

  protected b9 e(XmlElement A_0)
  {
    switch (A_0.Name)
    {
      case "stackableitem":
        return (b9) new c3(this);
      case "furnitureitem":
        return (b9) new ep(this);
      case "equipmentitem":
        return (b9) new en(this);
      case "weapon":
        return (b9) new en(this);
      case "mount":
        return (b9) new eo(this);
      case "farmableitem":
        return (b9) new c7(this);
      case "consumableitem":
        return (b9) new c5(this);
      case "journalitem":
        return (b9) new cb(this);
      default:
        return (b9) null;
    }
  }

  public b9 d(int A_0)
  {
    if (A_0 < 0 || A_0 > 3)
      return (b9) null;
    return this.b[A_0];
  }

  protected bool d(XmlElement A_0, b9 A_1)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("enchantments");
    if (elementsByTagName != null && elementsByTagName.Count > 0)
    {
      foreach (object obj in elementsByTagName[0])
      {
        XmlElement A_0_1 = obj as XmlElement;
        if (A_0_1 != null)
        {
          int index = aim.b(A_0_1, "enchantmentlevel", 0);
          b9 b9;
          if (this.b[index] != null)
          {
            b9 = this.b[index];
            b9.d1(A_0);
          }
          else
          {
            b9 = A_1.cg();
            this.b[index] = b9;
          }
          if (!b9.bc(A_0_1))
            return false;
        }
      }
    }
    return true;
  }

  public void d(g8 A_0)
  {
    for (int index = 0; index < this.b.Length; ++index)
    {
      b9 b9 = this.b[index];
      if (b9 != null)
        b9.bd(A_0);
    }
  }

  public static string d(b8 A_0, int A_1)
  {
    if (A_1 == 0)
    {
      // ISSUE: reference to a compiler-generated method
      return A_0.d();
    }
    // ISSUE: reference to a compiler-generated method
    return A_0.d() + b8.a + A_1.ToString();
  }

  public static b8 e(b8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    cb cb = A_0.f() as cb;
    if (cb == null)
      return (b8) null;
    b8 A_1 = new b8();
    // ISSUE: reference to a compiler-generated method
    A_1.d(cb.b(cb.d));
    for (int index = 0; index < 4; ++index)
    {
      cb A_0_1 = A_0.b[index] as cb;
      if (A_0_1 != null)
        A_1.b[index] = (b9) cb.b(A_0_1, A_1);
    }
    // ISSUE: reference to a compiler-generated method
    A_1.d(A_1.b[cb.h]);
    return A_1;
  }

  public static b8 d(b8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    cb cb = A_0.f() as cb;
    if (cb == null)
      return (b8) null;
    b8 A_1 = new b8();
    // ISSUE: reference to a compiler-generated method
    A_1.d(cb.a(cb.d));
    for (int index = 0; index < 4; ++index)
    {
      cb A_0_1 = A_0.b[index] as cb;
      if (A_0_1 != null)
        A_1.b[index] = (b9) cb.a(A_0_1, A_1);
    }
    // ISSUE: reference to a compiler-generated method
    A_1.d(A_1.b[cb.h]);
    return A_1;
  }
}
