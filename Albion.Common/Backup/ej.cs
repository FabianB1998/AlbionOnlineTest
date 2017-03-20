// Decompiled with JetBrains decompiler
// Type: ej
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.Chat;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ej : n
{
  protected ej.a[] au;
  protected ej.a av;
  protected ej.a aw;
  protected ej.a ax;

  [SpecialName]
  public ICollection<ej.a> h3()
  {
    return (ICollection<ej.a>) this.au;
  }

  public ej.a hz(string A_0)
  {
    if (this.au != null)
    {
      foreach (ej.a a in this.au)
      {
        if (a.f() == A_0)
          return a;
      }
    }
    return (ej.a) null;
  }

  public ej.a h4()
  {
    return this.av;
  }

  public ej.a h5()
  {
    return this.aw;
  }

  public ej.a h6()
  {
    return this.ax;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "ChatSettings")
      throw new AlbionException("[ChatSettings] LoadDataFromXml: XmlTag 'chatsettings' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "ChatUi")
        this.hz(A_0_1);
    }
    // ISSUE: reference to a compiler-generated method
    Math.Min(this.h0(), this.au.Length - 1);
    return true;
  }

  protected void hz(XmlElement A_0)
  {
    if (A_0.Name != "ChatUi")
      throw new AlbionException("[ChatSettings] LoadDataFromXml: XmlTag 'ChatUi' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.h2(aim.b(A_0, "maxtabs", -1));
    // ISSUE: reference to a compiler-generated method
    this.h1(aim.b(A_0, "selectedtab", 0));
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.b(A_0, "maxmuted", -1));
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.b(A_0, "maxtabnamelength", -1));
    List<ej.a> aList = new List<ej.a>();
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        ej.a a = this.h0(A_0_1);
        switch (A_0_1.Name)
        {
          case "DefaultTab":
            aList.Add(a);
            continue;
          case "GuildTab":
            this.av = a;
            continue;
          case "AllianceTab":
            this.aw = a;
            continue;
          case "PartyTab":
            this.ax = a;
            continue;
          default:
            continue;
        }
      }
    }
    this.au = aList.ToArray();
  }

  protected ej.a h0(XmlElement A_0)
  {
    string str = aim.a(A_0, "name", string.Empty);
    List<ChatChannelType> chatChannelTypeList = new List<ChatChannelType>();
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Channel")
      {
        ej.XmlChatChannel A_0_2 = aim.a<ej.XmlChatChannel>(A_0_1, "id", ej.XmlChatChannel.invalid);
        if (A_0_2 != ej.XmlChatChannel.invalid)
        {
          ChatChannelType chatChannelType = this.hz(A_0_2);
          chatChannelTypeList.Add(chatChannelType);
        }
      }
    }
    switch (A_0.Name)
    {
      case "GuildTab":
        str = "@CHAT_SETTINGS_TAB_NAME_GUILD";
        break;
      case "AllianceTab":
        str = "@CHAT_SETTINGS_TAB_NAME_ALLIANCE";
        break;
      case "PartyTab":
        str = "@CHAT_SETTINGS_TAB_NAME_PARTY";
        break;
    }
    return new ej.a() { a = str, b = chatChannelTypeList.ToArray(), c = aim.a(A_0, "showtimestamps", false), d = aim.a(A_0, "showchannelnames", false) };
  }

  private ChatChannelType hz(ej.XmlChatChannel A_0)
  {
    switch (A_0)
    {
      case ej.XmlChatChannel.global:
        return ChatChannelType.Global;
      case ej.XmlChatChannel.trade:
        return ChatChannelType.Trade;
      case ej.XmlChatChannel.recruit:
        return ChatChannelType.Recruit;
      case ej.XmlChatChannel.lookingforgroup:
        return ChatChannelType.LookingForGroup;
      case ej.XmlChatChannel.help:
        return ChatChannelType.Help;
      case ej.XmlChatChannel.guild:
        return ChatChannelType.Guild;
      case ej.XmlChatChannel.alliance:
        return ChatChannelType.Alliance;
      case ej.XmlChatChannel.party:
        return ChatChannelType.Party;
      case ej.XmlChatChannel.local:
        return ChatChannelType.Area;
      case ej.XmlChatChannel.personal:
        return ChatChannelType.Private;
      case ej.XmlChatChannel.say:
        return ChatChannelType.Surrounding;
      case ej.XmlChatChannel.emote:
        return ChatChannelType.SurroundingEmote;
      case ej.XmlChatChannel.system:
        return ChatChannelType.System;
      case ej.XmlChatChannel.takedamage:
        return ChatChannelType.TakeDamage;
      case ej.XmlChatChannel.givedamage:
        return ChatChannelType.GiveDamage;
      case ej.XmlChatChannel.killplayer:
        return ChatChannelType.KillPlayer;
      case ej.XmlChatChannel.healplayer:
        return ChatChannelType.HealPlayer;
      case ej.XmlChatChannel.spelleffect:
        return ChatChannelType.SpellEffect;
      case ej.XmlChatChannel.loot:
        return ChatChannelType.Loot;
      case ej.XmlChatChannel.reputation:
        return ChatChannelType.Reputation;
      default:
        return ChatChannelType.System;
    }
  }

  private enum XmlChatChannel
  {
    global,
    trade,
    recruit,
    lookingforgroup,
    help,
    guild,
    alliance,
    party,
    local,
    personal,
    say,
    emote,
    system,
    takedamage,
    givedamage,
    killplayer,
    healplayer,
    spelleffect,
    loot,
    reputation,
    invalid,
  }

  public class a
  {
    public string a;
    public ChatChannelType[] b;
    public bool c;
    public bool d;

    [SpecialName]
    public string f()
    {
      return kr.b(this.a);
    }
  }
}
