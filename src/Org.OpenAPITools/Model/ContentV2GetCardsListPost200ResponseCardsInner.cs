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
    /// ContentV2GetCardsListPost200ResponseCardsInner
    /// </summary>
    [DataContract(Name = "_content_v2_get_cards_list_post_200_response_cards_inner")]
    public partial class ContentV2GetCardsListPost200ResponseCardsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentV2GetCardsListPost200ResponseCardsInner" /> class.
        /// </summary>
        /// <param name="nmID">Артикул WB.</param>
        /// <param name="imtID">ID карточки товара. &lt;br&gt; Артикулы WB из одной карточки товара будут иметь одинаковый imtID.</param>
        /// <param name="nmUUID">Внутренний технический ID товара.</param>
        /// <param name="subjectID">ID предмета.</param>
        /// <param name="vendorCode">Артикул продавца.</param>
        /// <param name="subjectName">Название предмета.</param>
        /// <param name="brand">Бренд.</param>
        /// <param name="title">Наименование товара.</param>
        /// <param name="photos">Массив фото.</param>
        /// <param name="video">URL видео.</param>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="characteristics">Характеристики.</param>
        /// <param name="sizes">Размеры товара.</param>
        /// <param name="tags">Ярлыки.</param>
        /// <param name="createdAt">Дата создания.</param>
        /// <param name="updatedAt">Дата изменения.</param>
        public ContentV2GetCardsListPost200ResponseCardsInner(int nmID = default(int), int imtID = default(int), Guid nmUUID = default(Guid), int subjectID = default(int), string vendorCode = default(string), string subjectName = default(string), string brand = default(string), string title = default(string), List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner> photos = default(List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner>), string video = default(string), ContentV2GetCardsListPost200ResponseCardsInnerDimensions dimensions = default(ContentV2GetCardsListPost200ResponseCardsInnerDimensions), List<ContentV2GetCardsListPost200ResponseCardsInnerCharacteristicsInner> characteristics = default(List<ContentV2GetCardsListPost200ResponseCardsInnerCharacteristicsInner>), List<ContentV2GetCardsListPost200ResponseCardsInnerSizesInner> sizes = default(List<ContentV2GetCardsListPost200ResponseCardsInnerSizesInner>), List<ContentV2GetCardsListPost200ResponseCardsInnerTagsInner> tags = default(List<ContentV2GetCardsListPost200ResponseCardsInnerTagsInner>), string createdAt = default(string), string updatedAt = default(string))
        {
            this.NmID = nmID;
            this.ImtID = imtID;
            this.NmUUID = nmUUID;
            this.SubjectID = subjectID;
            this.VendorCode = vendorCode;
            this.SubjectName = subjectName;
            this.Brand = brand;
            this.Title = title;
            this.Photos = photos;
            this.Video = video;
            this.Dimensions = dimensions;
            this.Characteristics = characteristics;
            this.Sizes = sizes;
            this.Tags = tags;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Артикул WB
        /// </summary>
        /// <value>Артикул WB</value>
        [DataMember(Name = "nmID", EmitDefaultValue = false)]
        public int NmID { get; set; }

        /// <summary>
        /// ID карточки товара. &lt;br&gt; Артикулы WB из одной карточки товара будут иметь одинаковый imtID
        /// </summary>
        /// <value>ID карточки товара. &lt;br&gt; Артикулы WB из одной карточки товара будут иметь одинаковый imtID</value>
        [DataMember(Name = "imtID", EmitDefaultValue = false)]
        public int ImtID { get; set; }

        /// <summary>
        /// Внутренний технический ID товара
        /// </summary>
        /// <value>Внутренний технический ID товара</value>
        [DataMember(Name = "nmUUID", EmitDefaultValue = false)]
        public Guid NmUUID { get; set; }

        /// <summary>
        /// ID предмета
        /// </summary>
        /// <value>ID предмета</value>
        [DataMember(Name = "subjectID", EmitDefaultValue = false)]
        public int SubjectID { get; set; }

        /// <summary>
        /// Артикул продавца
        /// </summary>
        /// <value>Артикул продавца</value>
        [DataMember(Name = "vendorCode", EmitDefaultValue = false)]
        public string VendorCode { get; set; }

        /// <summary>
        /// Название предмета
        /// </summary>
        /// <value>Название предмета</value>
        [DataMember(Name = "subjectName", EmitDefaultValue = false)]
        public string SubjectName { get; set; }

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
        /// Массив фото
        /// </summary>
        /// <value>Массив фото</value>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        public List<ContentV2GetCardsListPost200ResponseCardsInnerPhotosInner> Photos { get; set; }

        /// <summary>
        /// URL видео
        /// </summary>
        /// <value>URL видео</value>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        public string Video { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public ContentV2GetCardsListPost200ResponseCardsInnerDimensions Dimensions { get; set; }

        /// <summary>
        /// Характеристики
        /// </summary>
        /// <value>Характеристики</value>
        [DataMember(Name = "characteristics", EmitDefaultValue = false)]
        public List<ContentV2GetCardsListPost200ResponseCardsInnerCharacteristicsInner> Characteristics { get; set; }

        /// <summary>
        /// Размеры товара
        /// </summary>
        /// <value>Размеры товара</value>
        [DataMember(Name = "sizes", EmitDefaultValue = false)]
        public List<ContentV2GetCardsListPost200ResponseCardsInnerSizesInner> Sizes { get; set; }

        /// <summary>
        /// Ярлыки
        /// </summary>
        /// <value>Ярлыки</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<ContentV2GetCardsListPost200ResponseCardsInnerTagsInner> Tags { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        /// <value>Дата создания</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        /// <value>Дата изменения</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentV2GetCardsListPost200ResponseCardsInner {\n");
            sb.Append("  NmID: ").Append(NmID).Append("\n");
            sb.Append("  ImtID: ").Append(ImtID).Append("\n");
            sb.Append("  NmUUID: ").Append(NmUUID).Append("\n");
            sb.Append("  SubjectID: ").Append(SubjectID).Append("\n");
            sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
            sb.Append("  SubjectName: ").Append(SubjectName).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("  Sizes: ").Append(Sizes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
