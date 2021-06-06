using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LuuThiHanHanh_01.Models
{
    [Table("Sinhviens")]
    public class SinhVien
    {
        [ Key]
        [MaxLength(20)]
        public string MaSinhVien { get; set; }
        [MaxLength(50)]
        public string Hoten { get; set; }
        [MaxLength(20)]
        public string MaLop { get; set; }
    }
}