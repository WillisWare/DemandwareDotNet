using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public sealed class Product
    {
        #region Properties

        /// <summary>
        /// The product's brand.
        /// </summary>
        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The array of all bundled products of this product.
        /// </summary>
        [JsonProperty(PropertyName = "bundled_products")]
        public IEnumerable<BundledProduct> BundledProducts { get; set; }

        /// <summary>
        /// The ISO 4217 mnemonic code of the currency.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The European Article Number.
        /// </summary>
        [JsonProperty(PropertyName = "ean")]
        public string EuropeanArticleNumber { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.DisallowNull)]
        [StringLength(100, MinimumLength = 1)]
        public string Id { get; set; }

        /// <summary>
        /// The array of product image groups.
        /// </summary>
        [JsonProperty(PropertyName = "image_groups")]
        public IEnumerable<ImageGroup> ImageGroups { get; set; }

        /// <summary>
        /// The array of product inventories explicitly requested via 'inventory_ids' query parameter.
        /// </summary>
        /// <remarks>This property is only returned in context of the 'availability' expansion.</remarks>
        [JsonProperty(PropertyName = "inventories")]
        public IEnumerable<Inventory> Inventories { get; set; }

        /// <summary>
        /// The site default inventory information.
        /// </summary>
        /// <remarks>This property is only returned in context of the 'availability' expansion.</remarks>
        [JsonProperty(PropertyName = "inventory")]
        public Inventory Inventory { get; set; }

        /// <summary>
        /// The array of source and target products links information.
        /// </summary>
        [JsonProperty(PropertyName = "product_links")]
        public IEnumerable<ProductLink> Links { get; set; }

        /// <summary>
        /// The localized product long description.
        /// </summary>
        [JsonProperty(PropertyName = "long_description")]
        public string LongDescription { get; set; }

        /// <summary>
        /// The products manufacturer name.
        /// </summary>
        [JsonProperty(PropertyName = "manufacturer_name")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// The products manufacturer sku.
        /// </summary>
        [JsonProperty(PropertyName = "manufacturer_sku")]
        // ReSharper disable once InconsistentNaming
        public string ManufacturerSKU { get; set; }

        /// <summary>
        /// The master product information.
        /// </summary>
        /// <remarks>Only for types master, variation group and variant.</remarks>
        [JsonProperty(PropertyName = "master")]
        public Master Master { get; set; }

        /// <summary>
        /// The maximum sales of related child products in case of complex products like master or set.
        /// </summary>
        [JsonProperty(PropertyName = "pice_max")]
        public decimal MaximumPrice { get; set; }

        /// <summary>
        /// The minimum order quantity for this product.
        /// </summary>
        [JsonProperty(PropertyName = "min_order_quantity")]
        public decimal MinimumOrderQuantity { get; set; }

        /// <summary>
        /// The localized product name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The array of product options. This array can be empty.
        /// </summary>
        /// <remarks>Only for type option.</remarks>
        [JsonProperty(PropertyName = "options")]
        public IEnumerable<Option> Options { get; set; }

        /// <summary>
        /// The localized products page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_description")]
        public string PageDescription { get; set; }

        /// <summary>
        /// The localized products page description.
        /// </summary>
        [JsonProperty(PropertyName = "page_keywords")]
        public string PageKeywords { get; set; }

        /// <summary>
        /// The localized products page title.
        /// </summary>
        [JsonProperty(PropertyName = "page_title")]
        public string PageTitle { get; set; }

        /// <summary>
        /// The sales price of the product. In case of complex products like master or set this is the minimum price of related child products.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The prices map with price book ids and their values.
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        public IDictionary<string, decimal> Prices { get; set; }

        /// <summary>
        /// The id of the products primary category.
        /// </summary>
        [JsonProperty(PropertyName = "primary_category_id")]
        public string PrimaryCategoryId { get; set; }

        /// <summary>
        /// The array of active customer product promotions for this product. This array can be empty.
        /// </summary>
        /// <remarks>Coupon promotions are not returned in this array.</remarks>
        [JsonProperty(PropertyName = "product_promotions")]
        public IEnumerable<ProductPromotion> Promotions { get; set; }

        /// <summary>
        /// Returns a list of recommendations.
        /// </summary>
        [JsonProperty(PropertyName = "product_recommendations")]
        public IEnumerable<Recommendation> Recommendations { get; set; }

        /// <summary>
        /// The array of set products of this product.
        /// </summary>
        [JsonProperty(PropertyName = "set_products")]
        public IEnumerable<Product> SetProducts { get; set; }

        /// <summary>
        /// The localized product short description.
        /// </summary>
        [JsonProperty(PropertyName = "short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The steps in which the order amount of the product can be increased.
        /// </summary>
        [JsonProperty(PropertyName = "step_quantity")]
        public decimal StepQuantity { get; set; }

        /// <summary>
        /// The product type information. Can be one or multiple of the following values: item,master,variation_group,variant,bundle,set.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ProductType Type { get; set; }

        /// <summary>
        /// The sales unit of the product.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The Universal Product Code.
        /// </summary>
        [JsonProperty(PropertyName = "upc")]
        // ReSharper disable once InconsistentNaming
        public string UPC { get; set; }

        /// <summary>
        /// The array of actual variants. This array can be empty.
        /// </summary>
        /// <remarks>Only for types master, variation group and variant.</remarks>
        [JsonProperty(PropertyName = "variants")]
        public IEnumerable<Variant> Variants { get; set; }

        /// <summary>
        /// Sorted array of variation attributes information. This array can be empty.
        /// </summary>
        /// <remarks>Only for types master, variation group and variant.</remarks>
        [JsonProperty(PropertyName = "variation_attributes")]
        public IEnumerable<VariationAttribute> VariationAttributes { get; set; }

        /// <summary>
        /// The array of actual variation groups. This array can be empty.
        /// </summary>
        /// <remarks>Only for types master, variation group and variant.</remarks>
        [JsonProperty(PropertyName = "variation_groups")]
        public IEnumerable<BaseVariationGroup> VariationGroups { get; set; }

        /// <summary>
        /// The actual variation attribute id - value pairs.
        /// </summary>
        /// <remarks>Only for type variant and variation group.</remarks>
        [JsonProperty(PropertyName = "variation_values")]
        public IDictionary<string, string> VariationValues { get; set; }

        #endregion
    }
}
