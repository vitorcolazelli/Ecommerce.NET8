﻿using static Ecommerce.Web.Utility.SD;

namespace Ecommerce.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public object AccessToken { get; set; }
    }
}
