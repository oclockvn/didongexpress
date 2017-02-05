using System;

namespace didongexpress.entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// if parent id == null ==> this is a category
        /// otherwise, this is a sub-category, and parent is parent id
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// sony-xperia-xa-16gb-dual-white ==> this is called slug (name of product for seo)
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// higher is first
        /// </summary>
        public int Order { get; set; }

        // if you like navigation property, you can do like this
        // I dont want too
        // public ICollection<Product> Products { get; set; } // that mean, 1 category has many products
    }
}
