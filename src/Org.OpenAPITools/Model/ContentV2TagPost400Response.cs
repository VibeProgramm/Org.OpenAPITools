/*
 * Работа с товарами
 *
 * Работа с товарами включает в себя:   1. [Создание](/openapi/work-with-products#tag/Sozdanie-kartochek-tovarov) и [редактирование](/openapi/work-with-products#tag/Kartochki-tovarov) карточек товаров: в том числе, получение [категорий, предметов и характеристик товаров](/openapi/work-with-products#tag/Kategorii-predmety-i-harakteristiki) и загрузку [медиафайлов](/openapi/work-with-products#tag/Mediafajly).   2. Настройку [ярлыков](/openapi/work-with-products#tag/Yarlyki) для удобного поиска товаров.   3. Установку [цен и скидок](/openapi/work-with-products#tag/Ceny-i-skidki).   4. Управление [остатками товаров](/openapi/work-with-products#tag/Ostatki-na-skladah-prodavca) и [складами](/openapi/work-with-products#tag/Sklady-prodavca), если вы работаете по модели продаж со склада продавца. 
 *
 * The version of the OpenAPI document: products
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ContentV2TagPost400Response
    /// </summary>
    [JsonConverter(typeof(ContentV2TagPost400ResponseJsonConverter))]
    [DataContract(Name = "_content_v2_tag_post_400_response")]
    public partial class ContentV2TagPost400Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2TagPost400Response" /> class
        /// with the <see cref="ResponseBodyContentError400" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ResponseBodyContentError400.</param>
        public ContentV2TagPost400Response(ResponseBodyContentError400 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2TagPost400Response" /> class
        /// with the <see cref="ResponseContentError4" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ResponseContentError4.</param>
        public ContentV2TagPost400Response(ResponseContentError4 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2TagPost400Response" /> class
        /// with the <see cref="ResponseContentError6" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ResponseContentError6.</param>
        public ContentV2TagPost400Response(ResponseContentError6 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ResponseBodyContentError400) || value is ResponseBodyContentError400)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ResponseContentError4) || value is ResponseContentError4)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ResponseContentError6) || value is ResponseContentError6)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ResponseBodyContentError400, ResponseContentError4, ResponseContentError6");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ResponseBodyContentError400`. If the actual instance is not `ResponseBodyContentError400`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ResponseBodyContentError400</returns>
        public ResponseBodyContentError400 GetResponseBodyContentError400()
        {
            return (ResponseBodyContentError400)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ResponseContentError4`. If the actual instance is not `ResponseContentError4`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ResponseContentError4</returns>
        public ResponseContentError4 GetResponseContentError4()
        {
            return (ResponseContentError4)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ResponseContentError6`. If the actual instance is not `ResponseContentError6`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ResponseContentError6</returns>
        public ResponseContentError6 GetResponseContentError6()
        {
            return (ResponseContentError6)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentV2TagPost400Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ContentV2TagPost400Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ContentV2TagPost400Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ContentV2TagPost400Response</returns>
        public static ContentV2TagPost400Response FromJson(string jsonString)
        {
            ContentV2TagPost400Response newContentV2TagPost400Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newContentV2TagPost400Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ResponseBodyContentError400).GetProperty("AdditionalProperties") == null)
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseBodyContentError400>(jsonString, ContentV2TagPost400Response.SerializerSettings));
                }
                else
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseBodyContentError400>(jsonString, ContentV2TagPost400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ResponseBodyContentError400");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ResponseBodyContentError400: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ResponseContentError4).GetProperty("AdditionalProperties") == null)
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseContentError4>(jsonString, ContentV2TagPost400Response.SerializerSettings));
                }
                else
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseContentError4>(jsonString, ContentV2TagPost400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ResponseContentError4");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ResponseContentError4: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ResponseContentError6).GetProperty("AdditionalProperties") == null)
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseContentError6>(jsonString, ContentV2TagPost400Response.SerializerSettings));
                }
                else
                {
                    newContentV2TagPost400Response = new ContentV2TagPost400Response(JsonConvert.DeserializeObject<ResponseContentError6>(jsonString, ContentV2TagPost400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ResponseContentError6");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ResponseContentError6: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newContentV2TagPost400Response;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for ContentV2TagPost400Response
    /// </summary>
    public class ContentV2TagPost400ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ContentV2TagPost400Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return ContentV2TagPost400Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ContentV2TagPost400Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
