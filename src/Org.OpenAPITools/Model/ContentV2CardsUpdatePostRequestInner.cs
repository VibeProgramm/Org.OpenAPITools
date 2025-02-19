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
    /// ContentV2CardsUpdatePostRequestInner
    /// </summary>
    [DataContract(Name = "_content_v2_cards_update_post_request_inner")]
    public partial class ContentV2CardsUpdatePostRequestInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsUpdatePostRequestInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentV2CardsUpdatePostRequestInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2CardsUpdatePostRequestInner" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB (required).</param>
        /// <param name="vendorCode">Артикул продавца (required).</param>
        /// <param name="brand">Бренд.</param>
        /// <param name="title">Наименование товара.</param>
        /// <param name="description">Описание товара. Максимальное количество символов зависит от категории товара. Стандарт — 2000, минимум — 1000, максимум — 5000.&lt;br&gt; Подробно о правилах описания в **Правилах заполнения карточки товара** в разделе [Инструкции](https://seller.wildberries.ru/help-center/article/A-113#описание) на портале продавцов. .</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="characteristics">Характеристики товара.</param>
        /// <param name="sizes">Массив размеров артикула. &lt;br&gt; Для безразмерного товара все равно нужно передавать данный массив без параметров (wbSize и techSize), но с баркодом.                            (required).</param>
        public ContentV2CardsUpdatePostRequestInner(int nmID = default(int), string vendorCode = default(string), string brand = default(string), string title = default(string), string description = default(string), ContentV2CardsUpdatePostRequestInnerDimensions dimensions = default(ContentV2CardsUpdatePostRequestInnerDimensions), List<ContentV2CardsUpdatePostRequestInnerCharacteristicsInner> characteristics = default(List<ContentV2CardsUpdatePostRequestInnerCharacteristicsInner>), List<ContentV2CardsUpdatePostRequestInnerSizesInner> sizes = default(List<ContentV2CardsUpdatePostRequestInnerSizesInner>))
        {
            this.NmID = nmID;
            // to ensure "vendorCode" is required (not null)
            if (vendorCode == null)
            {
                throw new ArgumentNullException("vendorCode is a required property for ContentV2CardsUpdatePostRequestInner and cannot be null");
            }
            this.VendorCode = vendorCode;
            // to ensure "sizes" is required (not null)
            if (sizes == null)
            {
                throw new ArgumentNullException("sizes is a required property for ContentV2CardsUpdatePostRequestInner and cannot be null");
            }
            this.Sizes = sizes;
            this.Brand = brand;
            this.Title = title;
            this.Description = description;
            this.Dimensions = dimensions;
            this.Characteristics = characteristics;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        [DataMember(Name = "nmID", IsRequired = true, EmitDefaultValue = true)]
        public int NmID { get; set; }

        /// <summary>
        /// Артикул продавца
        /// </summary>
        /// <value>Артикул продавца</value>
        [DataMember(Name = "vendorCode", IsRequired = true, EmitDefaultValue = true)]
        public string VendorCode { get; set; }

        /// <summary>
        /// Бренд
        /// </summary>
        /// <value>Бренд</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        /// <value>Наименование товара</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Описание товара. Максимальное количество символов зависит от категории товара. Стандарт — 2000, минимум — 1000, максимум — 5000.&lt;br&gt; Подробно о правилах описания в **Правилах заполнения карточки товара** в разделе [Инструкции](https://seller.wildberries.ru/help-center/article/A-113#описание) на портале продавцов. 
        /// </summary>
        /// <value>Описание товара. Максимальное количество символов зависит от категории товара. Стандарт — 2000, минимум — 1000, максимум — 5000.&lt;br&gt; Подробно о правилах описания в **Правилах заполнения карточки товара** в разделе [Инструкции](https://seller.wildberries.ru/help-center/article/A-113#описание) на портале продавцов. </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public ContentV2CardsUpdatePostRequestInnerDimensions Dimensions { get; set; }

        /// <summary>
        /// Характеристики товара
        /// </summary>
        /// <value>Характеристики товара</value>
        [DataMember(Name = "characteristics", EmitDefaultValue = false)]
        public List<ContentV2CardsUpdatePostRequestInnerCharacteristicsInner> Characteristics { get; set; }

        /// <summary>
        /// Массив размеров артикула. &lt;br&gt; Для безразмерного товара все равно нужно передавать данный массив без параметров (wbSize и techSize), но с баркодом.                           
        /// </summary>
        /// <value>Массив размеров артикула. &lt;br&gt; Для безразмерного товара все равно нужно передавать данный массив без параметров (wbSize и techSize), но с баркодом.                           </value>
        [DataMember(Name = "sizes", IsRequired = true, EmitDefaultValue = true)]
        public List<ContentV2CardsUpdatePostRequestInnerSizesInner> Sizes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2CardsUpdatePostRequestInner {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("  Sizes: ").Append(Sizes).Append("\n");
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
