namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(10)]
        public string TK { get; set; }

        [Required]
        [StringLength(10)]
        public string MK { get; set; }

        [Required]
        [StringLength(10)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string TheThanhVien { get; set; }

        public DateTime? ThoiGianThe { get; set; }
    }
}
