// Decompiled with JetBrains decompiler
// Type: gk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class gk : fm
{
  public override void co(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a<gk.TargetTypes>(A_0, "type", gk.TargetTypes.Enemy));
  }

  public enum TargetTypes
  {
    FriendAll,
    FriendOther,
    Self,
    Enemy,
    GroupMember,
    GroupOther,
    Mob,
    Player,
    GuildMember,
    AllianceMember,
  }
}
