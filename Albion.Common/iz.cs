// Decompiled with JetBrains decompiler
// Type: iz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;

public abstract class iz
{
  public static Dictionary<System.Type, List<ahz>> a = new Dictionary<System.Type, List<ahz>>();

  static iz()
  {
    iz.a = ah1.b(typeof (iz));
  }
}
