// Decompiled with JetBrains decompiler
// Type: es
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class es : er
{
  [SpecialName]
  public abstract string cl();

  public virtual bool cj(XmlElement A_0)
  {
    return true;
  }

  public void h4(gr A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(A_0);
  }

  public abstract es.a cm();

  public bool i8()
  {
    return this.cm() == es.a.a;
  }

  public bool i9()
  {
    return this.cm() == es.a.c;
  }

  public static bool h3(et A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (!(A_0 is e3) || ((e3) A_0).iq())
      return false;
    if (A_0 is ht)
    {
      ht ht = (ht) A_0;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((ht.h4() == PlayerAttribute.MoveSpeed || ht.h4() == PlayerAttribute.MoveSpeedBonus) && (double) ht.h3() < 0.0)
        return true;
    }
    return A_0 is h0 || A_0 is h1 || A_0 is hz;
  }

  public virtual void cn(g8 A_0)
  {
  }

  public enum a
  {
    a,
    b,
    c,
  }
}
