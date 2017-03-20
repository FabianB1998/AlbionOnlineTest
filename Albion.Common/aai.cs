// Decompiled with JetBrains decompiler
// Type: aai
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using Albion.Common.SimulationObjects.AccessRights;
using System;

public class aai
{
  public static string a(UserGroup A_0)
  {
    return "@_" + (object) A_0;
  }

  public static string a(Guid A_0, GuildRole A_1)
  {
    return "@G_" + (object) A_0 + "@" + (object) A_1;
  }

  public static string a(Guid A_0)
  {
    return "@P_" + (object) A_0;
  }

  public static bool f(string A_0)
  {
    return A_0.StartsWith("@_");
  }

  public static bool e(string A_0)
  {
    return A_0.StartsWith("@G_");
  }

  public static bool d(string A_0)
  {
    return A_0.StartsWith("@P_");
  }

  public static Guid a(string A_0, out GuildRole A_1)
  {
    string g = A_0.Remove(0, 3);
    int length = g.LastIndexOf("@", StringComparison.Ordinal);
    GuildRole guildRole = GuildRole.RECRUIT;
    if (length >= 0)
    {
      string str = g.Substring(length + 1);
      g = g.Substring(0, length);
      try
      {
        guildRole = (GuildRole) Enum.Parse(typeof (GuildRole), str);
      }
      catch (Exception ex)
      {
      }
    }
    A_1 = guildRole;
    try
    {
      return new Guid(g);
    }
    catch (Exception ex)
    {
      return Guid.Empty;
    }
  }

  public static Guid c(string A_0)
  {
    try
    {
      return new Guid(A_0.Remove(0, 3));
    }
    catch (Exception ex)
    {
      return Guid.Empty;
    }
  }

  public static string b(string A_0)
  {
    return A_0.Remove(0, 2);
  }

  public static UserGroup a(string A_0)
  {
    return (UserGroup) Enum.Parse(typeof (UserGroup), aai.b(A_0));
  }
}
