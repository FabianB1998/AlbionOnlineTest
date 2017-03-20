// Decompiled with JetBrains decompiler
// Type: iq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;

public class iq
{
  private static ip[] a = new ip[Enum.GetNames(typeof (GuildRole)).Length];

  static iq()
  {
    iq.a[8] = ip.a | ip.b | ip.c | ip.d | ip.e | ip.f | ip.g | ip.h | ip.i | ip.j | ip.k | ip.l | ip.m | ip.n | ip.o | ip.p | ip.q | ip.r | ip.s | ip.t;
    iq.a[7] = ip.a | ip.b | ip.c | ip.d | ip.e | ip.f | ip.g | ip.h | ip.i | ip.j | ip.k | ip.l | ip.m | ip.n | ip.o | ip.p | ip.q | ip.r | ip.t;
    iq.a[6] = ip.a | ip.b | ip.c | ip.d | ip.f | ip.g | ip.h | ip.i | ip.j | ip.k | ip.l | ip.m | ip.p | ip.q;
    iq.a[5] = ip.a | ip.b | ip.c | ip.d | ip.e | ip.f | ip.g | ip.h | ip.j | ip.k | ip.l | ip.m;
    iq.a[4] = ip.d | ip.f | ip.h | ip.j | ip.k | ip.m;
    iq.a[3] = ip.j | ip.k;
    iq.a[2] = ip.k;
    iq.a[1] = (ip) 0;
    iq.a[0] = (ip) 0;
  }

  public static bool a(GuildRole A_0, ip A_1)
  {
    return (iq.a[(int) A_0] & A_1) == A_1;
  }

  public static string a(GuildRole A_0)
  {
    switch (A_0)
    {
      case GuildRole.NONE:
        return "NONE";
      case GuildRole.RECRUIT:
        return "RCRT";
      case GuildRole.MEMBER:
        return "MMBR";
      case GuildRole.GUARDSMAN:
        return "GRDM";
      case GuildRole.OFFICER:
        return "OFFR";
      case GuildRole.WARMASTER:
        return "WMST";
      case GuildRole.MASTER_OF_COIN:
        return "MOCN";
      case GuildRole.THE_RIGHT_HAND:
        return "RGHT";
      case GuildRole.GUILDMASTER:
        return "MSTR";
      default:
        return "";
    }
  }

  public static GuildRole a(string A_0)
  {
    switch (A_0)
    {
      case "NONE":
        return GuildRole.NONE;
      case "MSTR":
        return GuildRole.GUILDMASTER;
      case "RGHT":
        return GuildRole.THE_RIGHT_HAND;
      case "MOCN":
        return GuildRole.MASTER_OF_COIN;
      case "WMST":
        return GuildRole.WARMASTER;
      case "OFFR":
        return GuildRole.OFFICER;
      case "GRDM":
        return GuildRole.GUARDSMAN;
      case "MMBR":
        return GuildRole.MEMBER;
      case "RCRT":
        return GuildRole.RECRUIT;
      default:
        return GuildRole.NONE;
    }
  }
}
