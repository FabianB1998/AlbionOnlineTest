// Decompiled with JetBrains decompiler
// Type: Albion.Common.AlbionException
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.Serialization;

namespace Albion.Common
{
  [Serializable]
  public class AlbionException : ApplicationException
  {
    public AlbionException()
    {
    }

    public AlbionException(string A_0)
      : base(A_0)
    {
    }

    protected AlbionException(SerializationInfo A_0, StreamingContext A_1)
      : base(A_0, A_1)
    {
    }

    public AlbionException(string A_0, Exception A_1)
      : base(A_0, A_1)
    {
    }
  }
}
