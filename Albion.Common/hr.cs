// Decompiled with JetBrains decompiler
// Type: hr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class hr : et
{
  public static readonly string gd = "spelleffectarea";

  [SpecialName]
  public override string cl()
  {
    return hr.gd;
  }

  public override es.a cm()
  {
    return es.a.b;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h8(aim.a(A_0, "removeonleave", true));
    // ISSUE: reference to a compiler-generated method
    this.h7(aim.a(A_0, "applyeffectonlyoncepertarget", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hr.Visibility>(A_0, "visible", hr.Visibility.True));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "effect", ""));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "time", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hr.SEARoot>(A_0, "position", hr.SEARoot.AtTarget));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<hr.SEARotation>(A_0, "rotation", hr.SEARotation.CasterRotation));
    // ISSUE: reference to a compiler-generated method
    this.h6(aim.a(A_0, "deletewhenmaxtargetshit", false));
    // ISSUE: reference to a compiler-generated method
    this.h5(aim.a(A_0, "removeoncasterdeath", false));
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "removewhencastergone", false));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "removeonlandscapecollision", false));
    float A_0_1 = aim.a(A_0, "skillshotindicatormin", 0.0f);
    float A_1 = aim.a(A_0, "skillshotindicatormax", 0.0f);
    if ((double) A_0_1 > (double) A_1)
      A_1 = A_0_1;
    // ISSUE: reference to a compiler-generated method
    this.h3(new ahk(A_0_1, A_1));
    if (A_0.HasChildNodes)
    {
      // ISSUE: reference to a compiler-generated method
      this.h3(new aht());
      // ISSUE: reference to a compiler-generated method
      this.h8().t(A_0);
      // ISSUE: reference to a compiler-generated method
      if (this.h8().y())
      {
        // ISSUE: reference to a compiler-generated method
        this.h3((aht) null);
      }
    }
    return base.cj(A_0);
  }

  public override void cn(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.h8() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.h8().t(A_0);
    }
    base.cn(A_0);
  }

  protected override string ck(er.a A_0)
  {
    switch (A_0.a)
    {
      case "time":
        // ISSUE: reference to a compiler-generated method
        return er.h3(this.h7());
      case "effect":
        // ISSUE: reference to a compiler-generated method
        return er.h5(this.h6(), A_0);
      default:
        return base.ck(A_0);
    }
  }

  public enum Visibility
  {
    False,
    True,
    Friendly,
    Hostile,
  }

  public enum SEARoot
  {
    AtTarget,
    AtCaster,
  }

  public enum SEARotation
  {
    CasterRotation,
    TargetRotation,
    CastDirection,
  }
}
