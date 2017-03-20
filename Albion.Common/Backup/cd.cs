// Decompiled with JetBrains decompiler
// Type: cd
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public class cd : n
{
  private Dictionary<string, cd.a> u = new Dictionary<string, cd.a>();

  public void hz(string A_0, string A_1, string A_2, out string A_3, out string A_4)
  {
    A_3 = string.Empty;
    A_4 = string.Empty;
    if (A_1 == null || A_2 == null)
      return;
    k3 k3 = new k3((A_1 + A_2).GetHashCode());
    this.hz(A_0, (kt) k3, out A_3, out A_4);
  }

  public void hz(string A_0, int A_1, out string A_2, out string A_3)
  {
    k3 k3 = new k3(A_1);
    this.hz(A_0, (kt) k3, out A_2, out A_3);
  }

  public void hz(string A_0, kt A_1, out string A_2, out string A_3)
  {
    A_2 = string.Empty;
    A_3 = string.Empty;
    if (A_0 == null)
      return;
    cd.a a = (cd.a) null;
    this.u.TryGetValue(A_0, out a);
    if (a == null)
      return;
    int index1 = A_1.Next(a.b.Count);
    int index2 = A_1.Next(a.c.Count);
    A_2 = a.b[index1];
    A_3 = a.c[index2];
  }

  public bool hz(string A_0)
  {
    return this.u.ContainsKey(A_0);
  }

  protected override bool aq(XmlElement A_0)
  {
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
        this.hz(A_0_1);
    }
    return true;
  }

  private void hz(XmlElement A_0)
  {
    string str1 = aim.a(A_0, "uniquename", string.Empty);
    if (string.IsNullOrEmpty(str1))
      return;
    cd.a a = new cd.a();
    a.a = str1;
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        string str2 = aim.a(A_0_1, "name", string.Empty);
        switch (A_0_1.Name)
        {
          case "firstname":
            a.b.Add(str2);
            continue;
          case "surname":
            a.c.Add(str2);
            continue;
          default:
            continue;
        }
      }
    }
    this.u.Add(a.a, a);
  }

  private class a
  {
    public List<string> b = new List<string>();
    public List<string> c = new List<string>();
    public string a;
  }
}
