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
    /// ContentV2GetCardsListPost200ResponseCardsInnerTagsInner
    /// </summary>
    [DataContract(Name = "_content_v2_get_cards_list_post_200_response_cards_inner_tags_inner")]
    public partial class ContentV2GetCardsListPost200ResponseCardsInnerTagsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2GetCardsListPost200ResponseCardsInnerTagsInner" /> class.
        /// </summary>
        /// <param name="id">ID ярлыка.</param>
        /// <param name="name">Название ярлыка.</param>
        /// <param name="color">Цвет ярлыка. &lt;dl&gt; &lt;dt&gt;Доступные цвета:&lt;/dt&gt; &lt;dd&gt;&lt;code&gt;D1CFD7&lt;/code&gt; - серый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FEE0E0&lt;/code&gt; - красный&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;ECDAFF&lt;/code&gt; - фиолетовый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;E4EAFF&lt;/code&gt; - синий&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;DEF1DD&lt;/code&gt; - зеленый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FFECC7&lt;/code&gt; - желтый&lt;/dd&gt; &lt;/dl&gt;         .</param>
        public ContentV2GetCardsListPost200ResponseCardsInnerTagsInner(int id = default(int), string name = default(string), string color = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
        }

        /// <summary>
        /// ID ярлыка
        /// </summary>
        /// <value>ID ярлыка</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Название ярлыка
        /// </summary>
        /// <value>Название ярлыка</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Цвет ярлыка. &lt;dl&gt; &lt;dt&gt;Доступные цвета:&lt;/dt&gt; &lt;dd&gt;&lt;code&gt;D1CFD7&lt;/code&gt; - серый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FEE0E0&lt;/code&gt; - красный&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;ECDAFF&lt;/code&gt; - фиолетовый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;E4EAFF&lt;/code&gt; - синий&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;DEF1DD&lt;/code&gt; - зеленый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FFECC7&lt;/code&gt; - желтый&lt;/dd&gt; &lt;/dl&gt;         
        /// </summary>
        /// <value>Цвет ярлыка. &lt;dl&gt; &lt;dt&gt;Доступные цвета:&lt;/dt&gt; &lt;dd&gt;&lt;code&gt;D1CFD7&lt;/code&gt; - серый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FEE0E0&lt;/code&gt; - красный&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;ECDAFF&lt;/code&gt; - фиолетовый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;E4EAFF&lt;/code&gt; - синий&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;DEF1DD&lt;/code&gt; - зеленый&lt;/dd&gt; &lt;dd&gt;&lt;code&gt;FFECC7&lt;/code&gt; - желтый&lt;/dd&gt; &lt;/dl&gt;         </value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2GetCardsListPost200ResponseCardsInnerTagsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
