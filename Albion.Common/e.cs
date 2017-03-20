// Decompiled with JetBrains decompiler
// Type: e
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Chat;
using Albion.Common.Time;

public class e
{
  public const int a = 160;
  public readonly string b;
  public readonly string c;
  public readonly ChatChannelType d;
  public readonly string e;
  public readonly byte f;
  public readonly GameTimeStamp g;

  public e(string A_0, ChatChannelType A_1, string A_2, byte A_3, GameTimeStamp A_4)
  {
    this.b = A_0;
    this.c = (string) null;
    this.d = A_1;
    this.e = A_2;
    this.f = A_3;
    this.g = A_4;
  }

  public e(string A_0, string A_1, ChatChannelType A_2, string A_3, byte A_4, GameTimeStamp A_5)
  {
    this.b = A_0;
    this.c = A_1;
    this.d = A_2;
    this.e = A_3;
    this.f = A_4;
    this.g = A_5;
  }
}
