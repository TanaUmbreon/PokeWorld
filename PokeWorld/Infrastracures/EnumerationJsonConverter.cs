using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PokeWorld.Common;

namespace PokeWorld.Infrastracures
{
    /// <summary>
    /// 列挙型クラスのオブジェクトを JSON 形式にもしくは JSON 形式から変換する機能を提供します。
    /// </summary>
    /// <typeparam name="T"><see cref="Enumeration"/> を継承する列挙型クラス。</typeparam>
    public class EnumerationJsonConverter<T> : JsonConverter<T> where T : Enumeration
    {
        private readonly IReadOnlyDictionary<string, T> nameValuePairs;

        /// <summary>
        /// <see cref="EnumerationConverter"/> の新しいインスタンスを生成します。
        /// </summary>
        public EnumerationJsonConverter()
        {
            var pairs = new Dictionary<string, T>();
            foreach (T value in Enumeration.GetAll<T>())
            {
                pairs.Add(value.Key, value);
            }
            nameValuePairs = pairs;
        }

        public override T ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string key = reader.Value as string ?? throw new InvalidCastException();
            return nameValuePairs[key];
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value is null) { throw new ArgumentNullException(nameof(value)); }
            writer.WriteValue(value.Key);
        }
    }
}
