using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Novorfay.Models.ConData
{
  [Table("ProductCategories", Schema = "dbo")]
  public partial class ProductCategory
  {
    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("@odata.etag")]
    public string ETag
    {
        get;
        set;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryID
    {
      get;
      set;
    }

    public IEnumerable<Product> Products { get; set; }
    [ConcurrencyCheck]
    public string CategoryName
    {
      get;
      set;
    }
  }
}
