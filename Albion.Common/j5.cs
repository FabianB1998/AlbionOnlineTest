// Decompiled with JetBrains decompiler
// Type: j5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class j5
{
  [SpecialName]
  public string a3()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b(this.a2());
  }

  public bool ad(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ai(aim.h(A_0, "type"));
    // ISSUE: reference to a compiler-generated method
    this.ah(aim.h(A_0, "hellclusterlevel"));
    // ISSUE: reference to a compiler-generated method
    int length = this.ae().IndexOf("_");
    if (length >= 0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ah(this.ae().Substring(0, length));
    }
    // ISSUE: reference to a compiler-generated method
    this.ae((byte) aim.b(A_0, "hellgateplayerslots", 5));
    // ISSUE: reference to a compiler-generated method
    this.ad((byte) aim.b(A_0, "hellgatelimit", 3));
    // ISSUE: reference to a compiler-generated method
    this.ap(aim.b(A_0, "hellgateentrancetimer", 4));
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.b(A_0, "hellclustertimelimit", 29));
    // ISSUE: reference to a compiler-generated method
    this.an(aim.b(A_0, "hellbosstimer", 100));
    // ISSUE: reference to a compiler-generated method
    this.am(aim.b(A_0, "hellgatemobdespawntime", 3));
    // ISSUE: reference to a compiler-generated method
    this.al(aim.b(A_0, "hellgatemobwavetimer", 9));
    // ISSUE: reference to a compiler-generated method
    this.ak(aim.b(A_0, "hellgatemobspawnmaxamount", 19));
    // ISSUE: reference to a compiler-generated method
    this.aj(aim.b(A_0, "hellgatemobchargepool", 199));
    // ISSUE: reference to a compiler-generated method
    this.ai(aim.b(A_0, "hellgatemobchargesadded", 19));
    // ISSUE: reference to a compiler-generated method
    this.ah(aim.b(A_0, "hellgatemobchargetime", 19));
    // ISSUE: reference to a compiler-generated method
    this.ag(aim.b(A_0, "hellclusterjointimelimit", 19));
    // ISSUE: reference to a compiler-generated method
    this.af(aim.a(A_0, "hellclusterconnectionchance", 30.3f));
    // ISSUE: reference to a compiler-generated method
    this.af(aim.b(A_0, "hellgatemindistance", 3));
    // ISSUE: reference to a compiler-generated method
    this.ae(aim.a(A_0, "hellgatejointime", 3.3f));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.a(A_0, "hellgateleavetime", 3.3f));
    // ISSUE: reference to a compiler-generated method
    this.ae(aim.b(A_0, "hellgateexittimer", 3));
    // ISSUE: reference to a compiler-generated method
    this.ag(aim.a(A_0, "hellclusterkillsonclosing", false));
    // ISSUE: reference to a compiler-generated method
    this.af(aim.a(A_0, "allowloggingout", true));
    // ISSUE: reference to a compiler-generated method
    this.ae(aim.a(A_0, "enableenterwarningmessage", true));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.b(A_0, "showhellgatetimerwhenxminareleft", 10));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.a(A_0, "hellgatedeath", true));
    // ISSUE: reference to a compiler-generated method
    this.ag(aim.a(A_0, "minimapicon", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.af(aim.a(A_0, "gateentertitle", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ae(aim.a(A_0, "gateprefab", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.ad(aim.a(A_0, "exitprefab", string.Empty));
    return true;
  }
}
