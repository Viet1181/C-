//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenQuocViet_2122110285.Context
{
    [Table("Categories")]
    public partial class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
            this.Categories1 = new HashSet<Category>();
        }
    
        public int CategoryID { get; set; }
    
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }
    
        [Display(Name = "Đường dẫn tĩnh")]
        public string Slug { get; set; }
    
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
    
        [Display(Name = "Hình ảnh")]
        public string ImageURL { get; set; }
    
        [Display(Name = "Danh mục cha")]
        public Nullable<int> ParentCategoryID { get; set; }
    
        [Display(Name = "Thứ tự hiển thị")]
        public Nullable<int> DisplayOrder { get; set; }
    
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    
        [Display(Name = "Đã xóa")]
        public bool IsDeleted { get; set; }
    
        [Display(Name = "Ngày tạo")]
        public System.DateTime CreatedDate { get; set; }
    
        [Display(Name = "Ngày sửa")]
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [ForeignKey("ParentCategoryID")]
        public virtual Category Category1 { get; set; }
        public virtual ICollection<Category> Categories1 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
