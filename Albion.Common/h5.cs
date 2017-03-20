// Decompiled with JetBrains decompiler
// Type: h5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public class h5
{
  public bool d(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(new SortedDictionary<int, List<TimeSpan>>());
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName("SpawnTimes");
    if (elementsByTagName.Count > 0)
    {
      XmlElement A_0_1 = (XmlElement) elementsByTagName[0];
      // ISSUE: reference to a compiler-generated method
      this.d(aim.a(A_0_1, "startdate", DateTime.MinValue));
      // ISSUE: reference to a compiler-generated method
      this.d(aim.a(A_0_1, "calculateusingclustertimezone", false));
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("day"))
      {
        int key = aim.b(A_0_2, "number", -1);
        if (key > 0)
        {
          List<TimeSpan> timeSpanList = new List<TimeSpan>();
          foreach (XmlElement A_0_3 in A_0_2.GetElementsByTagName("SpawnTime"))
          {
            TimeSpan timeSpan = aim.a(A_0_3, "utctime", new TimeSpan());
            timeSpanList.Add(timeSpan);
          }
          timeSpanList.Sort();
          // ISSUE: reference to a compiler-generated method
          this.f().Add(key, timeSpanList);
        }
      }
    }
    return true;
  }
}
