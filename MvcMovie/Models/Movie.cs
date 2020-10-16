﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //display特性指定要显示的字段名称的内容
        //datatype属性指定数据的类型
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public string Rating { set; get; }
    }
}
