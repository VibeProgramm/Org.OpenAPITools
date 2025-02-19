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

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ContentV2GetCardsTrashPost200Response
    /// </summary>
    [DataContract(Name = "_content_v2_get_cards_trash_post_200_response")]
    public partial class ContentV2GetCardsTrashPost200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2GetCardsTrashPost200Response" /> class.
        /// </summary>
        /// <param name="cards">Массив карточек товаров.</param>
        /// <param name="cursor">cursor.</param>
        public ContentV2GetCardsTrashPost200Response(List<ContentV2GetCardsTrashPost200ResponseCardsInner> cards = default(List<ContentV2GetCardsTrashPost200ResponseCardsInner>), ContentV2GetCardsTrashPost200ResponseCursor cursor = default(ContentV2GetCardsTrashPost200ResponseCursor))
        {
            this.Cards = cards;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Массив карточек товаров
        /// </summary>
        /// <value>Массив карточек товаров</value>
        [DataMember(Name = "cards", EmitDefaultValue = false)]
        public List<ContentV2GetCardsTrashPost200ResponseCardsInner> Cards { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public ContentV2GetCardsTrashPost200ResponseCursor Cursor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2GetCardsTrashPost200Response {\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
