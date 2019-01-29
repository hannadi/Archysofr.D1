﻿using System;
using Archysoft.D1.Model.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Archysoft.D1.Web.Api.Model
{
    public class ApiResponse
    {
        private ModelStateDictionary modelState;

        public int Status { get; set; }
        public string Description { get; set; }
        public long Timestamp { get; set; }

        public ApiResponse()
        {
            Status = 1;
            Description = "Success";
            Timestamp = DateTime.UtcNow.ConvertToTimeStamp();
        }

        public ApiResponse(int status, string message)
        {
            Status = status;
            Description = message;
        }

        public ApiResponse(ModelStateDictionary modelState)
        {
            this.modelState = modelState;
        }
    }

    public class ApiResponse<T> : ApiResponse where T : class
    {
        private readonly T _model;
        public T Model { get; set; }

        public ApiResponse(T model)
        {
            _model = model;
        }
    }
}
