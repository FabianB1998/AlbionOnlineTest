// Decompiled with JetBrains decompiler
// Type: fi
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class fi : e9
{
  public static readonly string cp = "forcedmovement";

  [SpecialName]
  public override string cl()
  {
    return fi.cp;
  }

  public override es.a cm()
  {
    return es.a.c;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(e9.MovementTypes.ForcedMovement);
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fi.InitialDirections>(A_0, "initialdirection", fi.InitialDirections.AwayFromSource));
    // ISSUE: reference to a compiler-generated method
    this.h6(ahy.l((double) aim.a(A_0, "MinDirectionChangeTime", 0.3f)));
    // ISSUE: reference to a compiler-generated method
    this.h5(ahy.l((double) aim.a(A_0, "MaxDirectionChangeTime", 0.6f)));
    // ISSUE: reference to a compiler-generated method
    this.h4(ahy.l((double) aim.a(A_0, "MinWaitTime", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(ahy.l((double) aim.a(A_0, "MaxWaitTime", 0.0f)));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "staywithinradius", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a<fi.MoveSpeedPresets>(A_0, "movespeedpreset", fi.MoveSpeedPresets.Run));
    if (!base.cj(A_0))
      return false;
    // ISSUE: reference to a compiler-generated method
    this.ic(true);
    return true;
  }

  public enum InitialDirections
  {
    Random,
    AwayFromSource,
    TowardsSource,
  }

  public enum MoveSpeedPresets
  {
    Walk,
    Run,
    Custom,
  }
}
