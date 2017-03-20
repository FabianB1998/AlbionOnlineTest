// Decompiled with JetBrains decompiler
// Type: ek
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Chat;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ek
{
  protected List<ek.a> b = new List<ek.a>();
  protected HashSet<string> c = new HashSet<string>();
  public const string a = "@CHAT_SETTINGS_TAB_NAME_COMBAT_LOG";

  [SpecialName]
  public ICollection<ek.a> c()
  {
    return (ICollection<ek.a>) this.b;
  }

  [SpecialName]
  public ICollection<string> d()
  {
    return (ICollection<string>) this.c;
  }

  public bool f(string A_0)
  {
    return this.c.Contains(A_0.ToLowerInvariant());
  }

  public bool g(string A_0)
  {
    return this.c.Add(A_0.ToLowerInvariant());
  }

  public bool h(string A_0)
  {
    return this.c.Remove(A_0.ToLowerInvariant());
  }

  public ek.a i(string A_0)
  {
    foreach (ek.a a in this.b)
    {
      if (a.a == A_0)
        return a;
    }
    return (ek.a) null;
  }

  public int j(string A_0)
  {
    int num = -1;
    for (int index = 0; index < this.b.Count; ++index)
    {
      if (this.b[index].a == A_0)
      {
        num = index;
        break;
      }
    }
    return num;
  }

  public ek.a c(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.b.Count)
      return this.b[A_0];
    return (ek.a) null;
  }

  protected bool c(ej.a A_0)
  {
    if (A_0 == null)
      return false;
    return this.d(A_0.f(), A_0.b, A_0.c, A_0.d);
  }

  protected bool d(string A_0, ChatChannelType[] A_1, bool A_2, bool A_3)
  {
    if (string.IsNullOrEmpty(A_0) || this.i(A_0) != null)
      return false;
    this.c(new ek.a()
    {
      a = A_0,
      b = this.c((IEnumerable<ChatChannelType>) A_1),
      c = A_2,
      d = A_3
    });
    return true;
  }

  protected void c(ek.a A_0)
  {
    if (this.b.Count > 0 && A_0.a != "@CHAT_SETTINGS_TAB_NAME_COMBAT_LOG")
    {
      int index = this.b.Count - 1;
      if (this.b[index].a == "@CHAT_SETTINGS_TAB_NAME_COMBAT_LOG")
      {
        this.b.Insert(index, A_0);
        return;
      }
    }
    this.b.Add(A_0);
  }

  protected void c(ek.ChatSettingsJson A_0)
  {
    if (A_0 == null)
      return;
    this.c.Clear();
    this.b.Clear();
    if (A_0.M != null)
      this.c = A_0.M;
    if (A_0.L == null)
      return;
    foreach (ek.ChatSettingsJson.ChatTab chatTab in A_0.L)
    {
      if (chatTab != null)
        this.c(new ek.a()
        {
          a = chatTab.N,
          b = this.c((IEnumerable<string>) chatTab.L),
          c = chatTab.T,
          d = chatTab.C
        });
    }
  }

  protected ek.ChatSettingsJson e()
  {
    List<ek.ChatSettingsJson.ChatTab> chatTabList = new List<ek.ChatSettingsJson.ChatTab>();
    foreach (ek.a a in this.b)
    {
      List<string> stringList = new List<string>();
      foreach (ChatChannelType chatChannelType in a.b)
        stringList.Add(chatChannelType.ToString());
      ek.ChatSettingsJson.ChatTab chatTab = new ek.ChatSettingsJson.ChatTab() { N = a.a, L = stringList, T = a.c, C = a.d };
      chatTabList.Add(chatTab);
    }
    return new ek.ChatSettingsJson() { L = chatTabList, M = this.c };
  }

  protected HashSet<ChatChannelType> c(IEnumerable<string> A_0)
  {
    HashSet<ChatChannelType> chatChannelTypeSet = new HashSet<ChatChannelType>();
    foreach (string str in A_0)
    {
      try
      {
        ChatChannelType chatChannelType = (ChatChannelType) Enum.Parse(typeof (ChatChannelType), str, true);
        chatChannelTypeSet.Add(chatChannelType);
      }
      catch
      {
      }
    }
    return chatChannelTypeSet;
  }

  protected HashSet<ChatChannelType> c(IEnumerable<ChatChannelType> A_0)
  {
    HashSet<ChatChannelType> chatChannelTypeSet = new HashSet<ChatChannelType>();
    foreach (ChatChannelType chatChannelType in A_0)
      chatChannelTypeSet.Add(chatChannelType);
    return chatChannelTypeSet;
  }

  public class a
  {
    public bool c = true;
    public bool d = true;
    public string a;
    public HashSet<ChatChannelType> b;
  }

  protected class ChatSettingsJson
  {
    public List<ek.ChatSettingsJson.ChatTab> L;
    public HashSet<string> M;

    public class ChatTab
    {
      public string N;
      public List<string> L;
      public bool T;
      public bool C;
    }
  }
}
