// Decompiled with JetBrains decompiler
// Type: br
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Xml;

public class br
{
  private static int a;

  public static void e()
  {
    br.a = 0;
  }

  public bool e(XmlElement A_0)
  {
    if (A_0.Name != "agentreference")
      throw new AlbionException("[AgentReferenceInfo] ParseFromXml: XmlTag 'Agent' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.e(br.a++);
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "referencename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "cluster", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "agenttype", string.Empty));
    return true;
  }

  public void e(g8 A_0)
  {
  }
}
