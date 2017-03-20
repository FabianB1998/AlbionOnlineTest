// Decompiled with JetBrains decompiler
// Type: bw
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class bw
{
  public Dictionary<string, bw.SoundEventEntry> a = new Dictionary<string, bw.SoundEventEntry>();

  public static bw c(XmlElement A_0)
  {
    bw bw = new bw();
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        bw.SoundEventEntry soundEventEntry = bw.b(A_0_1);
        bw.a.Add(A_0_1.Name, soundEventEntry);
      }
    }
    return bw;
  }

  public static bw.SoundEventEntry b(XmlElement A_0)
  {
    bw.SoundEventEntry soundEventEntry = new bw.SoundEventEntry();
    soundEventEntry.bPlayImpact = false;
    if (aim.i(A_0, "name"))
    {
      soundEventEntry.wwiseEvent = new bu(bu.a.a, (string) null, aim.a(A_0, "name", ""));
      foreach (XmlElement childNode in A_0.ChildNodes)
      {
        if (childNode.Name == "ImpactType")
        {
          soundEventEntry.bPlayImpact = true;
          if (aim.i(childNode, "override"))
            soundEventEntry.overrideImpactType = new bu(bu.a.c, "Impact_Type", aim.a(A_0, "overide", ""));
        }
      }
    }
    return soundEventEntry;
  }

  public struct SoundEventEntry
  {
    public bu wwiseEvent { get; set; }

    public bool bPlayImpact { get; set; }

    public bu overrideImpactType { get; set; }
  }
}
