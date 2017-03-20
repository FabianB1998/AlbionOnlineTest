// Decompiled with JetBrains decompiler
// Type: bq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bq : n
{
  protected List<br> q;
  protected Dictionary<string, List<br>> r;

  [SpecialName]
  public ICollection<br> hz()
  {
    return (ICollection<br>) this.q;
  }

  public br hz(int A_0)
  {
    if (A_0 >= 0 && A_0 < this.q.Count)
      return this.q[A_0];
    return (br) null;
  }

  public br hz(string A_0, string A_1)
  {
    if (string.IsNullOrEmpty(A_1) || string.IsNullOrEmpty(A_0))
      return (br) null;
    List<br> brList = (List<br>) null;
    if (this.r.TryGetValue(A_0, out brList))
    {
      for (int index = 0; index < brList.Count; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        if (brList[index].g() == A_1)
          return brList[index];
      }
    }
    return (br) null;
  }

  public void hz(g8 A_0)
  {
    foreach (br br in this.q)
      br.e(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "agentreferences")
      throw new AlbionException("[AgentReferenceData] LoadDataFromXml: XmlTag 'agentreferences' not found! Invalid Xml File?");
    br.e();
    this.r = new Dictionary<string, List<br>>();
    this.q = new List<br>(A_0.ChildNodes.Count);
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        br br = new br();
        br.e(A_0_1);
        // ISSUE: reference to a compiler-generated method
        if (br.f() != this.q.Count)
        {
          // ISSUE: reference to a compiler-generated method
          throw new AlbionException("[AgentReferenceData] ParseAgentReference: Invalid Type enumeration: type is: " + (object) br.f() + " but should be: " + (object) this.q.Count);
        }
        this.q.Add(br);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.hz(br.h(), br.g()) == null)
        {
          List<br> brList = (List<br>) null;
          // ISSUE: reference to a compiler-generated method
          if (!this.r.TryGetValue(br.h(), out brList))
          {
            brList = new List<br>();
            // ISSUE: reference to a compiler-generated method
            this.r.Add(br.h(), brList);
          }
          brList.Add(br);
        }
      }
    }
    return true;
  }
}
