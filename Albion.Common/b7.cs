// Decompiled with JetBrains decompiler
// Type: b7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Runtime.CompilerServices;
using System.Xml;

public class b7
{
  private static int a;

  [SpecialName]
  public string k()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.h());
  }

  [SpecialName]
  public string l()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.g());
  }

  public static void f()
  {
    b7.a = 0;
  }

  public bool f(XmlElement A_0)
  {
    if (A_0.Name != "faction")
      throw new AlbionException("[FactionInfo] ParseFromXml: XmlTag 'Faction' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.f(b7.a++);
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "title", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "description", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a<b7.UiIcon>(A_0, "icon", b7.UiIcon.Royal));
    return true;
  }

  public void f(g8 A_0)
  {
  }

  public enum UiIcon
  {
    Royal,
    Morgana,
    Demon,
    Undead,
    Keeper,
  }
}
