// Decompiled with JetBrains decompiler
// Type: a3
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class a3 : a1
{
  [SpecialName]
  public override a1.RewardType ay()
  {
    return a1.RewardType.CanLeaveStartArea;
  }

  public override void az(XmlElement A_0)
  {
  }

  public override bool a0(g8 A_0, List<string> A_1)
  {
    return true;
  }
}
