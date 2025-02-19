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
    /// ContentV2CardsUpdatePostRequestInnerSizesInner
    /// </summary>
    [DataContract(Name = "_content_v2_cards_update_post_request_inner_sizes_inner")]
    public partial class ContentV2CardsUpdatePostRequestInnerSizesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsUpdatePostRequestInnerSizesInner" /> class.
        /// </summary>
        /// <param name="chrtID">Числовой ID размера для данного артикула WB Обязателен к заполнению для существующих размеров. Для добавляемых размеров не указывается. .</param>
        /// <param name="techSize">Размер товара (XL, S, 45 и др.).</param>
        /// <param name="wbSize">Российский размер товара.</param>
        /// <param name="skus">Баркод.</param>
        public ContentV2CardsUpdatePostRequestInnerSizesInner(int chrtID = default(int), string techSize = default(string), string wbSize = default(string), List<string> skus = default(List<string>))
        {
            this.ChrtID = chrtID;
            this.TechSize = techSize;
            this.WbSize = wbSize;
            this.Skus = skus;
        }

        /// <summary>
        /// Числовой ID размера для данного артикула WB Обязателен к заполнению для существующих размеров. Для добавляемых размеров не указывается. 
        /// </summary>
        /// <value>Числовой ID размера для данного артикула WB Обязателен к заполнению для существующих размеров. Для добавляемых размеров не указывается. </value>
        [DataMember(Name = "chrtID", EmitDefaultValue = false)]
        public int ChrtID { get; set; }

        /// <summary>
        /// Размер товара (XL, S, 45 и др.)
        /// </summary>
        /// <value>Размер товара (XL, S, 45 и др.)</value>
        [DataMember(Name = "techSize", EmitDefaultValue = false)]
        public string TechSize { get; set; }

        /// <summary>
        /// Российский размер товара
        /// </summary>
        /// <value>Российский размер товара</value>
        [DataMember(Name = "wbSize", EmitDefaultValue = false)]
        public string WbSize { get; set; }

        /// <summary>
        /// Баркод
        /// </summary>
        /// <value>Баркод</value>
        [DataMember(Name = "skus", EmitDefaultValue = false)]
        public List<string> Skus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2CardsUpdatePostRequestInnerSizesInner {\n");
            sb.Append("  ChrtID: ").Append(ChrtID).Append("\n");
            sb.Append("  TechSize: ").Append(TechSize).Append("\n");
            sb.Append("  WbSize: ").Append(WbSize).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
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
