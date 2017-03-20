// Decompiled with JetBrains decompiler
// Type: g
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class g<a, b> where b : IComparable
{
  private SortedDictionary<b, LinkedList<a>> a = new SortedDictionary<b, LinkedList<a>>((IComparer<b>) new g<a, b>.a<b>((IComparer<b>) Comparer<b>.Default));

  [SpecialName]
  public bool e()
  {
    // ISSUE: reference to a compiler-generated method
    return this.d() == 0;
  }

  public SortedDictionary<b, LinkedList<a>> f()
  {
    return this.a;
  }

  public void c(a A_0)
  {
    this.c(A_0, default (b));
  }

  public void c(a A_0, b A_1)
  {
    g<a, b> g = this;
    // ISSUE: reference to a compiler-generated method
    int A_0_1 = g.d() + 1;
    // ISSUE: reference to a compiler-generated method
    g.c(A_0_1);
    LinkedList<a> linkedList;
    this.a.TryGetValue(A_1, out linkedList);
    if (linkedList == null)
    {
      linkedList = new LinkedList<a>();
      this.a[A_1] = linkedList;
    }
    linkedList.AddLast(A_0);
  }

  public void d(a A_0, b A_1)
  {
    LinkedList<a> linkedList;
    if (!this.a.TryGetValue(A_1, out linkedList))
      return;
    if (linkedList.Count == 1)
    {
      this.a.Remove(A_1);
      g<a, b> g = this;
      // ISSUE: reference to a compiler-generated method
      int A_0_1 = g.d() - 1;
      // ISSUE: reference to a compiler-generated method
      g.c(A_0_1);
    }
    else
    {
      int count = linkedList.Count;
      LinkedListNode<a> next;
      for (LinkedListNode<a> node = linkedList.First; node != null; node = next)
      {
        next = node.Next;
        if (node.Value.Equals((object) A_0))
        {
          linkedList.Remove(node);
          break;
        }
      }
      g<a, b> g = this;
      // ISSUE: reference to a compiler-generated method
      int A_0_1 = g.d() - (count - linkedList.Count);
      // ISSUE: reference to a compiler-generated method
      g.c(A_0_1);
    }
  }

  public void c(a A_0, b A_1, b A_2)
  {
    this.d(A_0, A_1);
    this.c(A_0, A_2);
  }

  private KeyValuePair<b, LinkedList<a>> c()
  {
    if (this.a.Count > 0)
    {
      using (SortedDictionary<b, LinkedList<a>>.Enumerator enumerator = this.a.GetEnumerator())
      {
        if (enumerator.MoveNext())
          return enumerator.Current;
      }
    }
    return new KeyValuePair<b, LinkedList<a>>();
  }

  public a g()
  {
    g<a, b> g = this;
    // ISSUE: reference to a compiler-generated method
    int A_0 = g.d() - 1;
    // ISSUE: reference to a compiler-generated method
    g.c(A_0);
    KeyValuePair<b, LinkedList<a>> keyValuePair = this.c();
    if (keyValuePair.Value.Count == 1)
      this.a.Remove(keyValuePair.Key);
    LinkedListNode<a> first = keyValuePair.Value.First;
    keyValuePair.Value.RemoveFirst();
    return first.Value;
  }

  public void h()
  {
    this.a.Clear();
    // ISSUE: reference to a compiler-generated method
    this.c(0);
  }

  public a i()
  {
    return this.c().Value.First.Value;
  }

  public KeyValuePair<a, b>[] j()
  {
    // ISSUE: reference to a compiler-generated method
    KeyValuePair<a, b>[] keyValuePairArray = new KeyValuePair<a, b>[this.d()];
    int num = 0;
    foreach (KeyValuePair<b, LinkedList<a>> keyValuePair in this.a)
    {
      foreach (a key in keyValuePair.Value)
        keyValuePairArray[num++] = new KeyValuePair<a, b>(key, keyValuePair.Key);
    }
    return keyValuePairArray;
  }

  public sealed class a<c> : IComparer<c>
  {
    private readonly IComparer<c> a;

    public a(IComparer<c> A_0)
    {
      this.a = A_0;
    }

    public int Compare(c left, c right)
    {
      return this.a.Compare(right, left);
    }
  }
}
