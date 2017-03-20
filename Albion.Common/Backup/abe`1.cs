// Decompiled with JetBrains decompiler
// Type: abe
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections;
using System.Collections.Generic;

public class abe<a>
{
  private Hashtable a = new Hashtable();

  public void a(System.Type A_0)
  {
    if (this.a.ContainsKey((object) A_0))
      return;
    this.a[(object) A_0] = (object) new HashSet<a>();
  }

  public void b(System.Type A_0)
  {
    this.a.Remove((object) A_0);
  }

  public void a()
  {
    foreach (HashSet<a> aSet in (IEnumerable) this.a.Values)
      aSet.Clear();
  }

  public void a(a A_0)
  {
    foreach (DictionaryEntry dictionaryEntry in this.a)
    {
      if (((System.Type) dictionaryEntry.Key).IsAssignableFrom(A_0.GetType()))
        ((HashSet<a>) dictionaryEntry.Value).Add(A_0);
    }
  }

  public void b(a A_0)
  {
    foreach (DictionaryEntry dictionaryEntry in this.a)
    {
      if (((System.Type) dictionaryEntry.Key).IsAssignableFrom(A_0.GetType()))
        ((HashSet<a>) dictionaryEntry.Value).Remove(A_0);
    }
  }

  public ICollection<a> c(System.Type A_0)
  {
    return (ICollection<a>) this.a[(object) A_0];
  }

  public int d(System.Type A_0)
  {
    return ((HashSet<a>) this.a[(object) A_0]).Count;
  }
}
