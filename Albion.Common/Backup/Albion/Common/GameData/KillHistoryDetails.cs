// Decompiled with JetBrains decompiler
// Type: Albion.Common.GameData.KillHistoryDetails
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

namespace Albion.Common.GameData
{
  public class KillHistoryDetails
  {
    public const int MaxItems = 6;
    public DateTime dt;
    public string kn;
    public string dn;
    public string kgn;
    public string dgn;
    public long f;
    public string c;
    public int p;
    public KillHistoryDetails.Item[] ki;
    public KillHistoryDetails.Item[] di;

    public class Item
    {
      public int q = 1;
      public string id;
      public int c;
      public string[] asp;
      public string[] psp;
    }
  }
}
