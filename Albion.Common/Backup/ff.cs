// Decompiled with JetBrains decompiler
// Type: ff
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class ff : er
{
  public static readonly string cb = "spelleffectarea";

  public bool h3(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ff.Visibility>(A_0, "visible", ff.Visibility.True));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<ff.SIARoot>(A_0, "position", ff.SIARoot.AtTarget));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a<ff.SIARoot>(A_0, "rotation", ff.SIARoot.AtCaster));
    if (A_0.HasChildNodes)
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(new aht());
      // ISSUE: reference to a compiler-generated method
      this.h4().t(A_0);
      // ISSUE: reference to a compiler-generated method
      if (this.h4().y())
      {
        // ISSUE: reference to a compiler-generated method
        this.h3((aht) null);
      }
    }
    return true;
  }

  public void h3(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h4() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.h4().t(A_0);
  }

  protected override string ck(er.a A_0)
  {
    return base.ck(A_0);
  }

  public enum Visibility
  {
    False,
    True,
    Friendly,
    Hostile,
  }

  public enum SIARoot
  {
    AtTarget,
    AtCaster,
  }
}
