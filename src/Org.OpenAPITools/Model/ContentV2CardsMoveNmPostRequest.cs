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
    /// ContentV2CardsMoveNmPostRequest
    /// </summary>
    [JsonConverter(typeof(ContentV2CardsMoveNmPostRequestJsonConverter))]
    [DataContract(Name = "_content_v2_cards_moveNm_post_request")]
    public partial class ContentV2CardsMoveNmPostRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsMoveNmPostRequest" /> class
        /// with the <see cref="RequestMoveNmsImtConn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RequestMoveNmsImtConn.</param>
        public ContentV2CardsMoveNmPostRequest(RequestMoveNmsImtConn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsMoveNmPostRequest" /> class
        /// with the <see cref="RequestMoveNmsImtDisconn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RequestMoveNmsImtDisconn.</param>
        public ContentV2CardsMoveNmPostRequest(RequestMoveNmsImtDisconn actualInstance)
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
                if (value.GetType() == typeof(RequestMoveNmsImtConn) || value is RequestMoveNmsImtConn)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RequestMoveNmsImtDisconn) || value is RequestMoveNmsImtDisconn)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: RequestMoveNmsImtConn, RequestMoveNmsImtDisconn");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `RequestMoveNmsImtConn`. If the actual instance is not `RequestMoveNmsImtConn`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RequestMoveNmsImtConn</returns>
        public RequestMoveNmsImtConn GetRequestMoveNmsImtConn()
        {
            return (RequestMoveNmsImtConn)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RequestMoveNmsImtDisconn`. If the actual instance is not `RequestMoveNmsImtDisconn`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RequestMoveNmsImtDisconn</returns>
        public RequestMoveNmsImtDisconn GetRequestMoveNmsImtDisconn()
        {
            return (RequestMoveNmsImtDisconn)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentV2CardsMoveNmPostRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ContentV2CardsMoveNmPostRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ContentV2CardsMoveNmPostRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ContentV2CardsMoveNmPostRequest</returns>
        public static ContentV2CardsMoveNmPostRequest FromJson(string jsonString)
        {
            ContentV2CardsMoveNmPostRequest newContentV2CardsMoveNmPostRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newContentV2CardsMoveNmPostRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RequestMoveNmsImtConn).GetProperty("AdditionalProperties") == null)
                {
                    newContentV2CardsMoveNmPostRequest = new ContentV2CardsMoveNmPostRequest(JsonConvert.DeserializeObject<RequestMoveNmsImtConn>(jsonString, ContentV2CardsMoveNmPostRequest.SerializerSettings));
                }
                else
                {
                    newContentV2CardsMoveNmPostRequest = new ContentV2CardsMoveNmPostRequest(JsonConvert.DeserializeObject<RequestMoveNmsImtConn>(jsonString, ContentV2CardsMoveNmPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RequestMoveNmsImtConn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RequestMoveNmsImtConn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RequestMoveNmsImtDisconn).GetProperty("AdditionalProperties") == null)
                {
                    newContentV2CardsMoveNmPostRequest = new ContentV2CardsMoveNmPostRequest(JsonConvert.DeserializeObject<RequestMoveNmsImtDisconn>(jsonString, ContentV2CardsMoveNmPostRequest.SerializerSettings));
                }
                else
                {
                    newContentV2CardsMoveNmPostRequest = new ContentV2CardsMoveNmPostRequest(JsonConvert.DeserializeObject<RequestMoveNmsImtDisconn>(jsonString, ContentV2CardsMoveNmPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RequestMoveNmsImtDisconn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RequestMoveNmsImtDisconn: {1}", jsonString, exception.ToString()));
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
            return newContentV2CardsMoveNmPostRequest;
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
    /// Custom JSON converter for ContentV2CardsMoveNmPostRequest
    /// </summary>
    public class ContentV2CardsMoveNmPostRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ContentV2CardsMoveNmPostRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return ContentV2CardsMoveNmPostRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ContentV2CardsMoveNmPostRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
