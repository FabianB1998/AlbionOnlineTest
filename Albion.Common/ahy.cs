// Decompiled with JetBrains decompiler
// Type: ahy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public struct ahy : IComparable, IComparable<ahy>, IEquatable<ahy>, ISerializable
{
  public static readonly ahy f = new ahy(long.MaxValue);
  public static readonly ahy g = new ahy(long.MinValue);
  public static readonly ahy h = new ahy(0L);
  public static readonly ahy i = new ahy(1L);
  public static readonly ahy j = new ahy(10000L);
  public static readonly ahy k = new ahy(10000000L);
  public static readonly ahy l = new ahy(600000000L);
  public static readonly ahy m = new ahy(36000000000L);
  public static readonly ahy n = new ahy(864000000000L);
  public const long a = 10000;
  public const long b = 10000000;
  public const long c = 600000000;
  public const long d = 36000000000;
  public const long e = 864000000000;
  public readonly long o;

  public ahy(long A_0)
  {
    this = new ahy();
    this.o = A_0;
  }

  public ahy(int A_0, int A_1, int A_2, int A_3, int A_4)
  {
    this = new ahy();
    this.o = 864000000000L * (long) A_0 + 36000000000L * (long) A_1 + 600000000L * (long) A_2 + 10000000L * (long) A_3 + 10000L * (long) A_4;
  }

  private ahy(SerializationInfo A_0, StreamingContext A_1)
  {
    if (A_0 == null)
      throw new ArgumentNullException("info");
    bool flag = false;
    long num = 0;
    SerializationInfoEnumerator enumerator = A_0.GetEnumerator();
    while (enumerator.MoveNext())
    {
      if (enumerator.Name == "ticks")
      {
        num = Convert.ToInt64(enumerator.Value, (IFormatProvider) CultureInfo.InvariantCulture);
        flag = true;
        break;
      }
    }
    if (!flag)
      throw new SerializationException("Serialization: Missing GameTimeStamp Data");
    this.o = num;
  }

  [SpecialName]
  public long k()
  {
    return this.o / 864000000000L;
  }

  [SpecialName]
  public long l()
  {
    return this.o % 864000000000L / 36000000000L;
  }

  [SpecialName]
  public long m()
  {
    return this.o % 36000000000L / 600000000L;
  }

  [SpecialName]
  public long n()
  {
    return this.o % 600000000L / 10000000L;
  }

  [SpecialName]
  public long p()
  {
    return this.o % 10000000L / 10000L;
  }

  [SpecialName]
  public double q()
  {
    return (double) this.o / 864000000000.0;
  }

  [SpecialName]
  public double r()
  {
    return (double) this.o / 36000000000.0;
  }

  [SpecialName]
  public double s()
  {
    return (double) this.o / 600000000.0;
  }

  [SpecialName]
  public double t()
  {
    return (double) this.o / 10000000.0;
  }

  [SpecialName]
  public double u()
  {
    return (double) this.o / 10000.0;
  }

  public bool v()
  {
    return this.o < 0L;
  }

  public bool w()
  {
    return this.o <= 0L;
  }

  public static ahy k(long A_0)
  {
    return new ahy(A_0);
  }

  public static ahy p(int A_0)
  {
    return new ahy((long) A_0 * 864000000000L);
  }

  public static ahy n(int A_0)
  {
    return new ahy((long) A_0 * 36000000000L);
  }

  public static ahy m(int A_0)
  {
    return new ahy((long) A_0 * 600000000L);
  }

  public static ahy l(int A_0)
  {
    return new ahy((long) A_0 * 10000000L);
  }

  public static ahy k(int A_0)
  {
    return new ahy((long) A_0 * 10000L);
  }

  public static ahy p(double A_0)
  {
    return new ahy((long) (A_0 * 864000000000.0 + 0.5));
  }

  public static ahy n(double A_0)
  {
    return new ahy((long) (A_0 * 36000000000.0 + 0.5));
  }

  public static ahy m(double A_0)
  {
    return new ahy((long) (A_0 * 600000000.0 + 0.5));
  }

  public static ahy l(double A_0)
  {
    return new ahy((long) (A_0 * 10000000.0 + 0.5));
  }

  public static ahy k(double A_0)
  {
    return new ahy((long) (A_0 * 10000.0 + 0.5));
  }

  public static ahy k(TimeSpan A_0)
  {
    return new ahy(A_0.Ticks);
  }

  public static ahy w(ahy A_0, ahy A_1)
  {
    if (ahy.u(A_0, A_1))
      return A_0;
    return A_1;
  }

  public static ahy v(ahy A_0, ahy A_1)
  {
    if (ahy.t(A_0, A_1))
      return A_0;
    return A_1;
  }

  public ahy x()
  {
    if (this.o < 0L)
      return new ahy(-this.o);
    return new ahy(this.o);
  }

  [SpecialName]
  public static bool u(ahy A_0, ahy A_1)
  {
    return A_0.o < A_1.o;
  }

  [SpecialName]
  public static bool t(ahy A_0, ahy A_1)
  {
    return A_0.o > A_1.o;
  }

  [SpecialName]
  public static bool s(ahy A_0, ahy A_1)
  {
    return A_0.o == A_1.o;
  }

  [SpecialName]
  public static bool r(ahy A_0, ahy A_1)
  {
    return A_0.o != A_1.o;
  }

  [SpecialName]
  public static bool q(ahy A_0, ahy A_1)
  {
    return A_0.o <= A_1.o;
  }

  [SpecialName]
  public static bool p(ahy A_0, ahy A_1)
  {
    return A_0.o >= A_1.o;
  }

  [SpecialName]
  public static ahy n(ahy A_0, ahy A_1)
  {
    return new ahy(A_0.o + A_1.o);
  }

  [SpecialName]
  public static ahy m(ahy A_0, ahy A_1)
  {
    return new ahy(A_0.o - A_1.o);
  }

  [SpecialName]
  public static float l(ahy A_0, ahy A_1)
  {
    return (float) A_0.o / (float) A_1.o;
  }

  [SpecialName]
  public static ahy l(ahy A_0, float A_1)
  {
    return new ahy((long) ((double) A_0.o / (double) A_1));
  }

  [SpecialName]
  public static ahy k(ahy A_0, float A_1)
  {
    return new ahy((long) ((double) A_0.o * (double) A_1));
  }

  [SpecialName]
  public static ahy k(float A_0, ahy A_1)
  {
    return new ahy((long) ((double) A_0 * (double) A_1.o));
  }

  [SpecialName]
  public static ahy l(ahy A_0)
  {
    return new ahy(A_0.o);
  }

  [SpecialName]
  public static ahy k(ahy A_0)
  {
    return new ahy(-A_0.o);
  }

  public int CompareTo(object obj)
  {
    if (obj == null || !(obj is ahy))
      throw new ArgumentException();
    ahy ahy = (ahy) obj;
    if (this.o > ahy.o)
      return 1;
    return this.o == ahy.o ? 0 : -1;
  }

  public int CompareTo(ahy xOther)
  {
    if (this.o > xOther.o)
      return 1;
    return this.o == xOther.o ? 0 : -1;
  }

  public override bool Equals(object value)
  {
    if (value != null && value is ahy)
      return ((GameTimeStamp) value).Ticks == this.o;
    throw new ArgumentException();
  }

  public static float k(ahy A_0, ahy A_1)
  {
    float num = (float) A_0.t();
    if ((double) num <= 0.0)
      return 1f;
    return Math.Max(0.0f, Math.Min(1f, (float) (1.0 - A_1.t() / (double) num)));
  }

  public bool Equals(ahy other)
  {
    return other.o == this.o;
  }

  public override int GetHashCode()
  {
    return (int) this.o;
  }

  public override string ToString()
  {
    return this.o.ToString();
  }

  public string y()
  {
    if (this.o < 600000000L)
      return string.Format("{0:0}.{1:000}s", (object) this.n(), (object) this.p());
    if (this.o < 36000000000L)
      return string.Format("{0:0}:{1:00}.{2:000}", (object) this.m(), (object) this.n(), (object) this.p());
    return string.Format("{0:0}:{1:00}:{2:00}.{3:000}", (object) (this.l() + this.k() * 24L), (object) this.m(), (object) this.n(), (object) this.p());
  }

  void ISerializable.k(SerializationInfo A_0, StreamingContext A_1)
  {
    if (A_0 == null)
      throw new ArgumentNullException("info");
    A_0.AddValue("ticks", this.o);
  }
}
