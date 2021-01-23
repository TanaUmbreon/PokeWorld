using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PokeWorld.Common
{
    /// <summary>
    /// 識別子と名前を持つ列挙型クラスを提供します。
    /// </summary>
    public abstract class Enumeration : IComparable
    {
        /// <summary>
        /// インスタンスを一意に特定する為の識別子を取得します。
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// インスタンスの名前を取得します。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// <see cref="Enumeration"/> のコンストラクタ。
        /// </summary>
        /// <param name="id">インスタンスを一意に特定する為の識別子。</param>
        /// <param name="name">インスタンスの名前。</param>
        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// この列挙型クラスに含まれている定数の配列を取得します。
        /// </summary>
        /// <typeparam name="T">列挙型クラス。</typeparam>
        /// <returns><typeparamref name="T"/> に含まれている定数を格納する配列。</returns>
        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        /// <summary>
        /// このインスタンスをそれと等価な文字列の値に変換します。
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Name;

        /// <summary>
        /// このインスタンスと、指定したオブジェクトが同一かどうかを判断します。
        /// </summary>
        /// <param name="obj">このインスタンスと比較するオブジェクト。</param>
        /// <returns>指定したオブジェクトがこのインスタンスと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Enumeration otherValue) { return false; }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);
            return typeMatches && valueMatches;
        }

        /// <summary>
        /// このインスタンスのハッシュ コードを返します。
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Id.GetHashCode();

        /// <summary>
        /// このインスタンスを同じ型の別のオブジェクトと比較し、
        /// このインスタンスの並べ替え順序での位置が、
        /// 比較対象のオブジェクトと比べて前か、後か、または同じかを示す整数を返します。
        /// </summary>
        /// <param name="obj">このインスタンスと比較するオブジェクト。</param>
        /// <returns>比較対象オブジェクトの相対順序を示す値。</returns>
        public int CompareTo(object? obj)
        {
            if (obj is not Enumeration otherValue)
            {
                throw new ArgumentException($"{nameof(obj)} の型がこのインスタンスの型と異なります。", nameof(obj));
            }
            return Id.CompareTo(otherValue.Id);
        }

        public static bool operator ==(Enumeration left, Enumeration right) => left is null ? right is null : left.Equals(right);

        public static bool operator !=(Enumeration left, Enumeration right) => !(left == right);

        public static bool operator <(Enumeration left, Enumeration right) => left is null ? right is object : left.CompareTo(right) < 0;

        public static bool operator <=(Enumeration left, Enumeration right) => left is null || left.CompareTo(right) <= 0;

        public static bool operator >(Enumeration left, Enumeration right) => left is object && left.CompareTo(right) > 0;

        public static bool operator >=(Enumeration left, Enumeration right) => left is null ? right is null : left.CompareTo(right) >= 0;
    }
}
