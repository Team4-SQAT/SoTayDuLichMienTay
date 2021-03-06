﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Security.AccessControl;
using Antlr.Runtime;
using Microsoft.Ajax.Utilities;
using System.ComponentModel.DataAnnotations;

namespace DuLichProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        

        public int id { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Tên đăng nhập không hợp lệ -  Giới hạn từ 5-30 kí tự !!!")]
        public string username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Mật khẩu không hợp lệ - Giới hạn từ 5-30 kí tự!!!<br/>")]
        public string password { get; set; }
        public string avatar { get; set; }
        public string address { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email không hợp lệ!!!")]
        public string email { get; set; }


    }
}
