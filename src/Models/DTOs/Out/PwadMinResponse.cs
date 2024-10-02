﻿using IfaceMainApi.Models.Entities;

namespace IfaceMainApi.src.Models.DTOs.Out
{
    public class PwadMinResponse
    {
        public Guid Id { get; set; }
        public PersonResponse Person { get; set; }
        public string CarefulToken { get; set; }
        public PwadMinResponse() { }


    }
}