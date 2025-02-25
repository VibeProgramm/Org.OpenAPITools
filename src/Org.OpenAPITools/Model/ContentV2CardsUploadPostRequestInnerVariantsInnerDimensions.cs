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
    /// Габариты упаковки товара. Указывать в **сантиметрах** для любого товара.  &lt;br&gt;  Если не указать структуру dimensions в запросе, то она сгенерируется системой автоматически с нулевыми значениями длины, ширины, высоты 
    /// </summary>
    [DataContract(Name = "_content_v2_cards_upload_post_request_inner_variants_inner_dimensions")]
    public partial class ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions" /> class.
        /// </summary>
        /// <param name="length">Длина, см.</param>
        /// <param name="width">Ширина, см.</param>
        /// <param name="height">Высота, см.</param>
        public ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions(int length = default(int), int width = default(int), int height = default(int))
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Длина, см
        /// </summary>
        /// <value>Длина, см</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// Ширина, см
        /// </summary>
        /// <value>Ширина, см</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Высота, см
        /// </summary>
        /// <value>Высота, см</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2CardsUploadPostRequestInnerVariantsInnerDimensions {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
