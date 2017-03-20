// Decompiled with JetBrains decompiler
// Type: aaj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.SimulationObjects.AccessRights;
using System;

public class aaj
{
  public static Preset a(string A_0)
  {
    string str = ((int) char.ToUpper(A_0[0])).ToString() + A_0.Substring(1).ToLower();
    Preset preset = Preset.Invalid;
    try
    {
      preset = (Preset) Enum.Parse(typeof (Preset), str);
    }
    catch
    {
    }
    return preset;
  }

  public static string b(Preset A_0)
  {
    return A_0.ToString().ToLower();
  }

  public static string a(Preset A_0)
  {
    return kr.b("@ACCESSRIGHTS_MODE_" + A_0.ToString().ToUpper());
  }
}
