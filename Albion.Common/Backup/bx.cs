// Decompiled with JetBrains decompiler
// Type: bx
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class bx
{
  public static Dictionary<string, Dictionary<gs.SpellUiType, bw.SoundEventEntry>> a = new Dictionary<string, Dictionary<gs.SpellUiType, bw.SoundEventEntry>>();

  public static void a()
  {
    bx.a.Clear();
  }

  public static void a(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        string name = A_0_1.Name;
        if (!bx.a.ContainsKey(name))
          bx.a.Add(name, new Dictionary<gs.SpellUiType, bw.SoundEventEntry>());
        gs.SpellUiType key = aim.a<gs.SpellUiType>(A_0_1, "uitype", gs.SpellUiType.None);
        bw.SoundEventEntry soundEventEntry = bw.b(A_0_1);
        bx.a[name].Add(key, soundEventEntry);
      }
    }
  }
}
