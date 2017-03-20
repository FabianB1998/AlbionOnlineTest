// Decompiled with JetBrains decompiler
// Type: i
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class i<a> : ICollection<a>, IEnumerable<a>, IEnumerable
{
  private List<a> a = new List<a>();
  private Dictionary<a, int> b = new Dictionary<a, int>();
  private Random c;

  public i()
  {
    this.c = new Random();
  }

  public i(Random A_0)
  {
    this.c = A_0;
  }

  public i(int A_0)
  {
    this.c = new Random(A_0);
  }

  [SpecialName]
  public a d(int A_0)
  {
    return this.a[A_0];
  }

  public a d()
  {
    if (this.a.Count > 0)
      return this.a[this.c.Next(this.a.Count)];
    throw new IndexOutOfRangeException("You can't access a random element of an Empty RandomAccessSet. Please check for proper Count() first.");
  }

  public void Add(a A_0)
  {
    if (this.b.ContainsKey(A_0))
      return;
    this.b.Add(A_0, this.a.Count);
    this.a.Add(A_0);
  }

  public bool Remove(a item)
  {
    int index;
    if (this.a.Count <= 0 || !this.b.TryGetValue(item, out index))
      return false;
    this.a[index] = this.a[this.a.Count - 1];
    this.b[this.a[this.a.Count - 1]] = index;
    this.b.Remove(item);
    this.a.RemoveAt(this.a.Count - 1);
    return true;
  }

  public void Clear()
  {
    this.a.Clear();
    this.b.Clear();
  }

  public bool Contains(a item)
  {
    return this.b.ContainsKey(item);
  }

  public void CopyTo(a[] array, int arrayIndex)
  {
    this.a.CopyTo(array, arrayIndex);
  }

  [SpecialName]
  public int get_Count()
  {
    return this.b.Keys.Count;
  }

  [SpecialName]
  public bool get_IsReadOnly()
  {
    return false;
  }

  public IEnumerator<a> GetEnumerator()
  {
    return (IEnumerator<a>) this.b.Keys.GetEnumerator();
  }

  IEnumerator IEnumerable.e()
  {
    return (IEnumerator) this.b.Keys.GetEnumerator();
  }
}
