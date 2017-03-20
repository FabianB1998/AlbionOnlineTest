// Decompiled with JetBrains decompiler
// Type: h
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class h<a> : ICollection<a>, IEnumerable<a>, IEnumerable
{
  private List<a> a = new List<a>();
  private k3 b;

  public h()
  {
    this.b = new k3();
  }

  public h(int A_0, IEnumerable<a> A_1)
  {
    this.b = new k3(A_0);
    this.a = new List<a>(A_1);
  }

  public h(k3 A_0)
  {
    this.b = A_0;
  }

  public h(int A_0)
  {
    this.b = new k3(A_0);
  }

  [SpecialName]
  public int get_Count()
  {
    return this.a.Count;
  }

  [SpecialName]
  public bool get_IsReadOnly()
  {
    return false;
  }

  public a c()
  {
    if (this.a.Count > 0)
      return this.a[this.b.Next(this.a.Count)];
    throw new IndexOutOfRangeException("You can't access a random element of an Empty RandomAccessList. Please check for proper Count() first.");
  }

  public a d()
  {
    if (this.a.Count <= 0)
      throw new IndexOutOfRangeException("You can't access a random element of an Empty RandomAccessList. Please check for proper Count() first.");
    int index = this.b.Next(this.a.Count);
    a a = this.a[index];
    this.a[index] = this.a[this.a.Count - 1];
    this.a.RemoveAt(this.a.Count - 1);
    return a;
  }

  public void c(IComparer<a> A_0)
  {
    this.a.Sort(A_0);
  }

  public IEnumerator<a> GetEnumerator()
  {
    return (IEnumerator<a>) this.a.GetEnumerator();
  }

  IEnumerator IEnumerable.e()
  {
    return (IEnumerator) this.GetEnumerator();
  }

  public void Add(a A_0)
  {
    this.a.Add(A_0);
  }

  public void Clear()
  {
    this.a.Clear();
  }

  public bool Contains(a item)
  {
    return this.a.Contains(item);
  }

  public void CopyTo(a[] array, int arrayIndex)
  {
    this.a.CopyTo(array, arrayIndex);
  }

  public bool Remove(a item)
  {
    return this.a.Remove(item);
  }
}
