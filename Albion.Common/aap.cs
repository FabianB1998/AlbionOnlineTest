// Decompiled with JetBrains decompiler
// Type: aap
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class aap
{
  public static string c(Guid A_0)
  {
    return "@" + aap.ClusterInstanceType.ISLAND.ToString() + "@" + (object) A_0;
  }

  public static Guid c(string A_0)
  {
    return new Guid(A_0.Replace("@" + aap.ClusterInstanceType.ISLAND.ToString() + "@", "").Trim());
  }

  public static string b(Guid A_0)
  {
    return "@" + aap.ClusterInstanceType.HELLCLUSTER.ToString() + "@" + (object) A_0;
  }

  public static string a(Guid A_0)
  {
    return "@" + aap.ClusterInstanceType.EXPEDITION.ToString() + "@" + (object) A_0;
  }

  public static Guid b(string A_0)
  {
    string[] strArray = A_0.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    if (strArray.Length >= 2)
      return new Guid(strArray[1]);
    return Guid.Empty;
  }

  public static aap.ClusterInstanceType a(string A_0)
  {
    foreach (object obj in Enum.GetValues(typeof (aap.ClusterInstanceType)))
    {
      if (A_0.StartsWith("@" + obj.ToString()))
        return (aap.ClusterInstanceType) obj;
    }
    return aap.ClusterInstanceType.NONE;
  }

  public enum ClusterInstanceType
  {
    NONE,
    ISLAND,
    HELLCLUSTER,
    EXPEDITION,
  }
}
